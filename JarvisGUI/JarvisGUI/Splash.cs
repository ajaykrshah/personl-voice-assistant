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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                this.Hide();
                new Form1().Show();
                timer1.Stop();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            axWindowsMediaPlayer1.Size = this.Size;
          
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState==1)
            {
                this.Hide();
                new Form1().Show();
                timer1.Stop();
            }
        }
    }
}
