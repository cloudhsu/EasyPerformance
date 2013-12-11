using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CloudBox.Performance;

namespace TestForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PerformanceDetector.Instance.initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            PerformanceDetector.Instance.destory();
        }
    }
}
