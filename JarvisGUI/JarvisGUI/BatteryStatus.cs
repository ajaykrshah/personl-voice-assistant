using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JarvisGUI
{
    public partial class BatteryStatus : Form
    {
        public BatteryStatus()
        {
            InitializeComponent();
          
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           
            PowerStatus status = SystemInformation.PowerStatus;
            circularProgressBar1.Value = (int)(status.BatteryLifePercent * 100);
            circularProgressBar1.Text = String.Format("{0}", (status.BatteryLifePercent * 100))+"%";
            
            switch (status.PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    circularProgressBar1.ProgressColor = Color.SeaGreen;
                    textBox1.Text = "charging...";
                    break;

                case PowerLineStatus.Offline:
                    circularProgressBar1.ProgressColor = Color.DarkSeaGreen;
                    textBox1.Text = "discharging...";
                    break;

            }
        }

        public int percentage() {
            return circularProgressBar1.Value;
        }
        private void BatteryStatus_Load(object sender, EventArgs e)
        {

        }

        private void verticalProgressBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
