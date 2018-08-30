using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JarvisGUI.Properties;

namespace JarvisGUI
{
    public partial class Profiler : Form
    {
        string img;
        public Profiler()
        {
            InitializeComponent();
            
        }
        private void Profiler_Load(object sender, EventArgs e)
        {
            try
            {
                img = Settings.Default["avtar"].ToString();
                avtar.BackgroundImage = Bitmap.FromFile(img);
                avtar.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {

                avtar.BackgroundImage = Properties.Resources.profile;
                avtar.BackgroundImageLayout = ImageLayout.Stretch;
            }
           
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            //When the user select the file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = openFileDialog1.FileName;
                Settings.Default["avtar"] = img;
                Settings.Default.Save();
                avtar.BackgroundImage = Bitmap.FromFile(img);
                avtar.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void avtar_MouseHover(object sender, EventArgs e)
        {
            //var bm = new Bitmap(avtar.BackgroundImage, new Size(avtar.Width + 500, avtar.Height + 10));
            //avtar.BackgroundImage = bm;
            //avtar.Width += 5;
            //avtar.Height += 5;
            //avtar.Location = new Point(67 ,10);
        }

        private void avtar_MouseLeave(object sender, EventArgs e)
        {
            //avtar.Width -= 5;
            //avtar.Height -= 5;
            //avtar.Location = new Point(69, 12);
        }
    }
}
