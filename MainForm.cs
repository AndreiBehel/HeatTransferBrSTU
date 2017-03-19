using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physics
{
    public interface IMainForm
    {     
        string charSize { get; }
        string length { get; }
        string emissivity { get; }
        string airTemp { get; }
        bool isHorizontal { get; }
        string[] bottomTemp { get; }
        string rayleigh { set; }
        string grashof { set; }
        string nusselt { set; }
        string heatTransferCoeff { set; }
        string avTemp { set; }
        //string secondParam { set; }
        Image formula { set; }
        bool grButtonisEnabled { set; }
        event EventHandler CalculateClick;
        event EventHandler GraphClick;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            CalculateBut.Click += new EventHandler(CalculateBut_Click);
            GraphButton.Click += new EventHandler(GraphButton_Click);
        }

        void CalculateBut_Click(object sender, EventArgs e)
        {
            if (CalculateClick != null) CalculateClick(this, EventArgs.Empty);
        }
        void GraphButton_Click(object sender, EventArgs e)
        {
            if (GraphClick != null) GraphClick(this, EventArgs.Empty);
        }
        #region Входные параметры
        public string charSize
        {
            get { return charSizeFld.Text; }
        }
        public string length
        {
            get { return lengthFld.Text; }
        }
        
        public string emissivity
        {
            get { return emissivityFld.Text; }
        }
        public bool isHorizontal
        {
            get { return horizontalRButton.Checked; }
        }
        public string airTemp
        {
            get { return airTempFld.Text; }
        }

        public string[] bottomTemp
        {
            get {
                string[] arr = new string[5];

                arr[0] = t1TextBox.Text ;
                arr[1] = t2TextBox.Text;
                arr[2] = t3TextBox.Text;
                arr[3] = t4TextBox.Text;
                arr[4] = t5TextBox.Text;
                return arr;
            }
        }
        #endregion
        #region Вывод результатов
        public string avTemp 
        {
            set { avTempTextBox.Text = value; }
        }

        public string rayleigh
        {
            set { rayleighFld.Text = value; }
        }

        public string grashof
        {
            set { grashofFld.Text = value; }
        }

        public string nusselt
        {
            set { nusseltFld.Text = value; }
        }

        public string heatTransferCoeff
        {
            set { heatTransferCoeffFld.Text = value; }
        }
        public bool grButtonisEnabled
        {
            set { GraphButton.Enabled = value; }
        }
        public Image formula
        {
            set
            {
                if (value == null && equtionPicBox.Image!= null)
                    equtionPicBox.Image.Dispose();
                equtionPicBox.Image = value;
            }
        }
        #endregion
        public event EventHandler CalculateClick;
        public event EventHandler GraphClick;

        private void verticalRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (isHorizontal)
            {
                secondParamLabel.Text = "Длина цилиндра";
            }
            else
            {
                secondParamLabel.Text = "Диаметр цилиндра D";
            }
        }

    }
}
