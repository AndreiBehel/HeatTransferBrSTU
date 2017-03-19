using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DfEditor;

namespace Physics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessageService service = new MessageService();
            ParamCalc pc = new ParamCalc();
            MainPresenter presenter = new MainPresenter(form, pc, service);

            Application.Run(form);
        }
    }
}
