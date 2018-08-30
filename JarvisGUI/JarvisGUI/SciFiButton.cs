using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarvisGUI
{
    public partial class SciFiButton : Form
    {
        public SciFiButton()
        {
            InitializeComponent();
            this.Cursor = Cursors.SizeAll;
            this.Enabled = Enabled;
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            facebook.BackgroundImage = JarvisGUI.Properties.Resources.F_selected;
            Process.Start("chrome.exe", "www.facebook.com");
        }

        private void facebook_MouseHover(object sender, EventArgs e)
        {
            facebook.BackgroundImage = JarvisGUI.Properties.Resources.F_hover;
        }

        private void facebook_MouseLeave(object sender, EventArgs e)
        {
            facebook.BackgroundImage = JarvisGUI.Properties.Resources.F_show;
        }

        private void gtalk_Click(object sender, EventArgs e)
        {
            gtalk.BackgroundImage = JarvisGUI.Properties.Resources.g_selected;
            Process.Start("chrome.exe", "www.gmail.com");
        }

        private void gtalk_MouseHover(object sender, EventArgs e)
        {
            gtalk.BackgroundImage = JarvisGUI.Properties.Resources.g_hover;
        }

        private void gtalk_MouseLeave(object sender, EventArgs e)
        {
            gtalk.BackgroundImage = JarvisGUI.Properties.Resources.g_show;
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            youtube.BackgroundImage = JarvisGUI.Properties.Resources.y_selected;
            Process.Start("chrome.exe", "www.youtube.com");
        }

        private void youtube_MouseHover(object sender, EventArgs e)
        {
            youtube.BackgroundImage = JarvisGUI.Properties.Resources.y_hover;
        }

        private void youtube_MouseLeave(object sender, EventArgs e)
        {
            youtube.BackgroundImage = JarvisGUI.Properties.Resources.y_show;
        }

        private void google_Click(object sender, EventArgs e)
        {
            google.BackgroundImage = JarvisGUI.Properties.Resources.google_selected;
            google.BackColor = Color.DarkGreen;
            Process.Start("chrome.exe", "www.google.com");
        }

        private void google_MouseHover(object sender, EventArgs e)
        {
            google.BackgroundImage = JarvisGUI.Properties.Resources.google_hover;
            google.BackColor = Color.ForestGreen;
        }

        private void google_MouseLeave(object sender, EventArgs e)
        {
            google.BackgroundImage = JarvisGUI.Properties.Resources.google_show;
            google.BackColor = Color.DarkGreen;
        }

        private void wiki_Click(object sender, EventArgs e)
        {
            wiki.BackgroundImage = JarvisGUI.Properties.Resources.wikipedia_selected;
            Process.Start("chrome.exe", "www.wikipedia.com");
        }

        private void wiki_MouseHover(object sender, EventArgs e)
        {
            wiki.BackgroundImage = JarvisGUI.Properties.Resources.wikipedia_hover;
        }

        private void wiki_MouseLeave(object sender, EventArgs e)
        {
            wiki.BackgroundImage = JarvisGUI.Properties.Resources.wikipedia_show;
        }
    }
}
