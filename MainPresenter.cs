using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DfEditor;
using System.Drawing;
using System.IO;

namespace Physics
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IMessageService _messageService;
        private readonly IParamCalc _paramCalc;

        public MainPresenter(IMainForm view, IParamCalc paramCalc, IMessageService messageService)
        {
            _view = view;
            _messageService = messageService;
            _paramCalc = paramCalc;

            _view.CalculateClick += new EventHandler(_view_CalculateClick);
            _view.GraphClick += new EventHandler(_view_GraphClick);
        }

        void _view_CalculateClick(object sender, EventArgs e)
        {
            if (_paramCalc.Calc(_view.airTemp, _view.bottomTemp, _view.charSize, _view.length, _view.emissivity, _view.isHorizontal))
            {
                //выводим результаты
                _view.avTemp = _paramCalc.AvTemp.ToString("F2");

                _view.grashof = _paramCalc.Grashof.ToString("F3");
                _view.rayleigh = _paramCalc.Rayleigh.ToString("F3");
                _view.nusselt = _paramCalc.Nusselt.ToString("F3");
                _view.heatTransferCoeff = _paramCalc.HeatTransfer.ToString("F3");
                //File.Delete("Eq2ImgWinForms.gif");
                //рендерим картинку и добавляем в окно
                try
                {
                    string path = Path.GetTempPath() + "Eq2ImgWinForms.gif";
                    _view.formula = null;
                    NativeMethods.CreateGifFromEq(_paramCalc.EqStr, path);
                    _view.formula = Image.FromFile(path);
                    _view.grButtonisEnabled = true;
                }
                catch (Exception ex)
                {
                    _messageService.ShowExclamation(ex.Message);
                }    
            }
            else
            {
                _messageService.ShowExclamation("Проверьте корректность входных данных");
            }
        }
        void _view_GraphClick(object sender, EventArgs e)
        {
            GraphForm form = new GraphForm();
            form.data = _paramCalc.PlotData;
            form.ShowDialog();  
        }
    }
    [System.Security.SuppressUnmanagedCodeSecurity()]
    internal class NativeMethods
    {
        private NativeMethods()
        { //all methods in this class would be static
        }

        [System.Runtime.InteropServices.DllImport("MimeTex.dll")]
        internal static extern int CreateGifFromEq(string expr, string fileName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        internal extern static IntPtr GetModuleHandle(string lpModuleName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        internal extern static bool FreeLibrary(IntPtr hLibModule);
    }
}
