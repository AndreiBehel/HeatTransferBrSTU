using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Physics.Properties;

namespace Physics
{
    interface IParamCalc
    {
        double Rayleigh { get; }
        double Grashof { get; }
        double Nusselt { get; }
        double HeatTransfer { get; }
        string EqStr { get; }
        double AvTemp { get; }
        myData[] PlotData { get; }

        bool Calc(string wt, string[] bt, string cs, string len, string em, bool isHoriz);
    }
    class InputData
    {
        public double viscosity;
        public double heatConducCoeff;
        public double prandtlNumber;
        public double charTemp;
    }

    class ParamCalc : IParamCalc
    {
        private const double C_0 = 5.67;
        private const double G_ACCEL = 9.81;

        private double airTemp;
        private double bottomTemp;
        private double charTemp;
        bool isHorizontal;
        private double charactSize;
        private double length;
        private double emissivity;

        private int index;
        private double rayleighNumber;
        private double grashofNumber;
        private double nusseltNumber;
        private double heatTransferCoeff;

        private double Qc;
        private double Qr;

        private InputData inDa = new InputData();

        private List<InputData> ar = new List<InputData>();

        private StringBuilder sb = new StringBuilder();

        public bool Calc(string at, string[] bt, string cs, string len, string em, bool isHoriz)
        {
            if (Double.TryParse(at.Replace('.', ','), out airTemp) && Double.TryParse(cs, out charactSize)
                && Double.TryParse(len, out length) && Double.TryParse(em.Replace('.', ','), out emissivity)
                && (charactSize > 0) && (length > 0) && (emissivity > 0) && (emissivity < 1))
            {
                //converts parameters from milimeters to meters
                charactSize /= 1000;
                length /= 1000;

                double t = 0;
                int numOfPar = 0;
                for(int i = 0; i < bt.Length; ++i) {
                    double temp = 0;
                    if (!System.String.IsNullOrEmpty(bt[i]))
                    {
                        if (Double.TryParse(bt[i], out temp))
                        {
                            numOfPar++;
                            t += temp;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                isHorizontal = isHoriz;
                bottomTemp = t / numOfPar;
                charTemp = getCharTemp();
                //read air characteristics into array from input resourse
                readCharData();
                //get 
                index = getValue(this.charTemp);
                inDa.heatConducCoeff = ar.ElementAt(index).heatConducCoeff;
                inDa.prandtlNumber = ar.ElementAt(index).prandtlNumber;
                inDa.viscosity = ar.ElementAt(index).viscosity;

                calculateGrAndRa(isHoriz);

                return true;
            }
            return false;
        }

        //Расчеты неизвестных 
        public void calculateGrAndRa(bool isHoriz)
        {

            sb.Length = 0;
            //sb.Append("g = ").Append(9.81).Append("\\, m/s^2; \\\\");
            sb.Append("l =").Append(charactSize).Append("\\ m; \\\\");
            sb.Append("t_\\infty = ").Append(airTemp).Append("^{\\circ} C; \\\\");
            sb.Append("t = ").Append(Math.Round(bottomTemp, 3)).Append("^{\\circ} C; \\\\");
            sb.Append("t_m  = {{t + t_\\infty  } \\over 2} = {{").Append(Math.Round(bottomTemp, 2)).Append("+")
                .Append(airTemp).Append("} \\over 2}=").Append(Math.Round(charTemp, 2)).Append("^{\\circ}C; \\\\");

            sb.Append("\\fbox{ \\text{Physical\\,properties\\,of\\,dry\\,air:} \\\\");
            sb.Append("\\beta = ").Append(getVolumeCoefficient(this.charTemp).ToString("F5")).Append("\\ K^{-1}; \\\\");
            sb.Append("\\nu = ").Append(inDa.viscosity).Append("\\ m^{2}/s; \\\\");
            sb.Append("Pr = ").Append(inDa.prandtlNumber).Append("; \\\\");
            sb.Append("\\lambda = ").Append(inDa.heatConducCoeff).Append("\\ W/(m \\cdot K);} \\\\");

            grashofNumber = getGrashofNumber();

            sb.Append("Gr = \\beta {{g \\cdot {l}^3 } \\over {\\nu}^2 }\\left( {t - t_\\infty  } \\right) = ")
                .Append(grashofNumber.ToString("F3")).Append("; \\\\");
            
            rayleighNumber = inDa.prandtlNumber * grashofNumber;
            sb.Append("Ra = Pr \\cdot Gr =  \\\\").Append(inDa.prandtlNumber.ToString("F3"))
                .Append(" \\cdot ").Append(grashofNumber.ToString("F3")).Append(" = ").Append(rayleighNumber.ToString("F3")).Append("; \\\\");
            if (isHoriz)
            {
                calculateNuForHoriz();
            }
            else
            {
                calculateNuForVert();
            }
            
            heatTransferCoeff = nusseltNumber * inDa.heatConducCoeff / charactSize;
            sb.Append(" \\\\ \\alpha  = {{Nu \\cdot \\lambda } \\over {l}} = ").Append(heatTransferCoeff.ToString("F3"))
                .Append("\\ W/(m^{2}\\cdot K); \\\\[10]");

            sb.Append("\\varepsilon = ").Append(emissivity).Append("; \\\\");
            sb.Append(" C_0 = 5.67 \\ W/(m^{2} \\cdot K) ; \\\\");
            sb.Append("Q_c = \\alpha \\left( { T - T_\\infty}\\right) F = \\alpha \\left( { T - T_\\infty}\\right) \\pi \\cdot d \\cdot l = ").
                Append(getQc(this.bottomTemp).ToString("F3")).Append("\\ W; \\\\");
            sb.Append("Q_r = \\varepsilon \\cdot C_0 \\left[ {{\\left({ {T}\\over {100}}\\right)}^{4} - {\\left( {{T_\\infty}\\over {100}}\\right)}^{4}} \\right]").
                Append("\\cdot F = \\\\");
            sb.Append("=\\varepsilon \\cdot C_0 \\left[ {{\\left({ {T}\\over {100}}\\right)}^{4} - {\\left( {{T_\\infty}\\over {100}}\\right)}^{4}} \\right] \\pi \\cdot d \\cdot l =").
                Append(getQr(this.bottomTemp).ToString("F3")).Append("\\ W; \\\\");
        }
        private double getGrashofNumber()
        {
            return getVolumeCoefficient(this.charTemp) * G_ACCEL * Math.Pow(charactSize, 3) * (bottomTemp - airTemp) / Math.Pow(inDa.viscosity, 2);
        }
        public void calculateNuForVert()
        {

            double C = 0;
            double n = 0;

            if (rayleighNumber > 2.0E+7)
            {
                sb.Append("Re\\, >\\, 2\\cdot10^{7}\\,\\Rightarrow ");
                C = 0.135;
                n = 1.0 / 3.0;
            }
            else if (rayleighNumber > 5.0E+2)
            {
                sb.Append("2\\cdot10^{7} \\, > \\, Re \\,> 5\\cdot10^{2}\\,\\Rightarrow ");
                C = 0.54;
                n = 1.0 / 4.0;
            }
            else
            {
                sb.Append("Ra\\, < \\, 5\\cdot10^{2}\\,\\Rightarrow ");
                C = 1.18;
                n = 1.0 / 8.0;
            }
            //sb.Append("C = ").Append(C).Append("\\:");
            //sb.Append("n = ").Append(n.ToString("F3")).Append("; \\\\");
            nusseltNumber = C * Math.Pow(rayleighNumber, n);
            sb.Append("Nu = ").Append(C).Append("\\cdot \\left( Gr \\cdot Pr\\right)^{")
            .Append(n).Append("} =").Append(nusseltNumber.ToString("F3")).Append("; \\\\");
        }

        private void calculateNuForHoriz()
        {
            double C = 0;
            double n = 0;

            if (rayleighNumber > 1.0E+9)
            {
                sb.Append("Re\\, > \\, 10^{9}\\,\\Rightarrow ");
                C = 0.15;
                n = 0.33;
            }
            else
            {
                sb.Append("Re \\,< \\, 10^{9}\\,\\Rightarrow ");
                C = 0.75;
                n = 0.25;
            }
            //sb.Append("C = ").Append(C).Append("\\,");
            //sb.Append("n = ").Append(n).Append("; \\\\");
            nusseltNumber = C * Math.Pow(rayleighNumber, n);
            sb.Append("Nu = ").Append(C).Append("\\cdot \\left( Gr \\cdot Pr\\right)^{")
            .Append(n).Append("} =").Append(nusseltNumber.ToString("F3")).Append("; \\\\");
        }

        //нахождение хар. температуры
        private double getCharTemp()
        {
            return (airTemp + bottomTemp) / 2;
        }
        //нахождение беты
        private double getVolumeCoefficient(double charTemp)
        {
            return 1 / (charTemp + 273.15);
        }
        private double getQc(double bottomTemp)
        {
            double htc = 0;
            int ind = getValue((bottomTemp + this.airTemp) / 2);
            double ra = ar.ElementAt(ind).prandtlNumber * getVolumeCoefficient((bottomTemp + this.airTemp) / 2) * G_ACCEL *
                Math.Pow(charactSize, 3) * (bottomTemp - airTemp) / Math.Pow(ar.ElementAt(ind).viscosity, 2);
            double C = 0;
            double n = 0;
            if (isHorizontal && ra > 1.0E+9) 
            {
                C = 0.15;
                n = 0.33;
            }
            else if (isHorizontal) 
            {
                C = 0.75;
                n = 0.25;
            }
            else if (!isHorizontal && ra > 2.0E+7) 
            {
                C = 0.135;
                n = 1.0 / 3.0;
            }
             else if (!isHorizontal && ra > 5.0E+2) 
            {
                C = 0.54;
                n = 1.0 / 4.0;
            }
             else if (!isHorizontal) 
            {
                C = 1.18;
                n = 1.0 / 8.0;
            }
            htc = C * Math.Pow(rayleighNumber, n) * ar.ElementAt(ind).heatConducCoeff;
            return htc * (bottomTemp - airTemp) * Math.PI * length;
        }
        private double getQr(double bottomTemp)
        {
            return C_0 * emissivity * (Math.Pow(((bottomTemp + 273.15) / 100), 4) - Math.Pow(((airTemp + 273.15) / 100), 4))
                * Math.PI * length * charactSize;
        }
        //находим наиболее подходящее значение хар. температуры в таблице
        private int getValue(double charTemp)
        {
            int i = 0;
            double prevDiff;
            double curDiff;
            do
            {
                prevDiff = ar.ElementAt(i++).charTemp - charTemp;
                curDiff = ar.ElementAt(i).charTemp - charTemp;
            } while ((i < ar.Count -1) && (Math.Abs(curDiff) < Math.Abs(prevDiff)));
            return --i;
        }
        //считываем таблицу из файла
        private void readCharData()
        {
            string[] lines = Resources.data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            InputData np;
            foreach (string line in lines)
            {
                string[] data = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                np = new InputData();
                try
                {
                    np.charTemp = Convert.ToDouble(data[0]);
                    np.heatConducCoeff = Convert.ToDouble(data[1]) * 1.0E-2;
                    np.viscosity = Convert.ToDouble(data[2]) * 1.0E-6;
                    np.prandtlNumber = Convert.ToDouble(data[3]);
                    ar.Add(np);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.", e);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.", data[0]);
                }
            }
        }
        public double AvTemp
        {
            get { return bottomTemp; }
        }
        public double Rayleigh 
        {
            get { return rayleighNumber; } 
        }
        public double Grashof
        {
            get { return grashofNumber; }
        }
        public double Nusselt
        {
            get { return nusseltNumber; }
        }
        public double HeatTransfer
        {
            get { return heatTransferCoeff; }
        }
        public string EqStr
        {
            get { return sb.ToString(); }
        }

        public myData[] PlotData
        {
            get { 
                myData[] t = new myData[900];
                for (int i = 0; i < t.Length; i++)
                {
                    t[i] = new myData();
                    t[i].X = i + airTemp + 1;
                    t[i].Y_c = getQc(t[i].X);
                    t[i].Y_r = getQr(t[i].X);
                    t[i].Y_total = t[i].Y_c + t[i].Y_r;
                }
                return t;
            }
        }
    }

}
