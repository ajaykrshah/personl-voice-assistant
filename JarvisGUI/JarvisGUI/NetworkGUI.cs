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
    public partial class NetworkGUI : Form
    {
        
        InternetConnectionSettings checker;
        int xaxis;

        public NetworkGUI()
        {
            InitializeComponent();
        }

        private void NetworkGUI_Load(object sender, EventArgs e)
        {
            checker = new InternetConnectionSettings();
           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checker.connectionCheck()==true)
            {
                chart1.Series[0].Points.AddXY(xaxis++, checker.CheckInternetSpeed() / 1024);
                label1.Text = (checker.CheckInternetSpeed() / 1024).ToString("0.000")+" Kbps";

                if (chart1.Series[0].Points.Count > 10)
                {
                    chart1.Series[0].Points.Remove(chart1.Series[0].Points[0]);
                    chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
                    chart1.ChartAreas[0].AxisX.Maximum = xaxis;
                }
            }
            else
            {
                label1.Text = "0.00 Kbps";
                chart1.Series[0].Points.AddXY(xaxis++,0);
            }

        }


        public string speed()
        {
            return label1.Text ;
        }

    }
}
