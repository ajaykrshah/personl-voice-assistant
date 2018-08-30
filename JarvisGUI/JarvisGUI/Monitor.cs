using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarvisGUI
{
    public partial class Monitor : Form
    {
        
        public Monitor()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            progressBarCPU.Value = (int)fcpu;
            progressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);

        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

      

     
        private void Monitor_Click(object sender, EventArgs e)
        {

            Process.Start("resmon");
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Monitor_Click(sender, e);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Monitor_Click(sender, e);
        }
    }
}
