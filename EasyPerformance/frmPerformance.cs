using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudBox.Performance
{
    public partial class frmPerformance : Form
    {
        public frmPerformance()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                txtCPU.Text = PerformanceDetector.Instance.CpuUsage.ToString();
                txtMemory.Text = PerformanceDetector.Instance.MainMemory.GetCurrentKB();
                pgbCPU.Value = PerformanceDetector.Instance.CpuUsage;
            }
            catch{}
        }

        private void frmPerformance_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void frmPerformance_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
