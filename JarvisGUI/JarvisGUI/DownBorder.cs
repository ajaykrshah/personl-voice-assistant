using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarvisGUI
{
    public partial class DownBorder : Form
    {
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
        [DllImport("user32.dll")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public DownBorder()
        {
            InitializeComponent();
        }

        private void DownBorder_Load(object sender, EventArgs e)
        {
       
        }

        private void Lock_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void Lock_MouseHover(object sender, EventArgs e)
        {
            Lock.ForeColor = Color.BurlyWood;
        }

        private void Lock_MouseLeave(object sender, EventArgs e)
        {
            Lock.ForeColor = Color.White;
        }

        private void logOff_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }

        private void logOff_MouseHover(object sender, EventArgs e)
        {
            logOff.ForeColor = Color.BurlyWood;
        }

        private void logOff_MouseLeave(object sender, EventArgs e)
        {
            logOff.ForeColor = Color.White;
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");

        }

        private void shutdown_MouseHover(object sender, EventArgs e)
        {
            shutdown.ForeColor = Color.BurlyWood;
        }

        private void shutdown_MouseLeave(object sender, EventArgs e)
        {
            shutdown.ForeColor = Color.White;
        }

        private void Sleep_Click(object sender, EventArgs e)
        {
            SetSuspendState(false, true, true);
        }

        private void Sleep_MouseHover(object sender, EventArgs e)
        {
            Sleep.ForeColor = Color.BurlyWood;
        }

        private void Sleep_MouseLeave(object sender, EventArgs e)
        {
            Sleep.ForeColor = Color.White;
        }
        private void Hibernate_Click(object sender, EventArgs e)
        {
            SetSuspendState(true, true, true);
        }

        private void Hibernate_MouseHover(object sender, EventArgs e)
        {
            Hibernate.ForeColor = Color.BurlyWood;
        }

        private void Hibernate_MouseLeave(object sender, EventArgs e)
        {
            Hibernate.ForeColor = Color.White;
        }
    }
}
