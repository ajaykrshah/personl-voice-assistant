using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace JarvisGUI
{
    public partial class MyDrives : Form
    {
        double divideBYthis = Math.Pow(1024, 3);
        ListViewItem lvi;
       string drivename;
        public MyDrives()
        {
            InitializeComponent();
           
        }
        private void getdrive()
        {
            string[] dir = Directory.GetLogicalDrives();

            foreach (var item in dir)
            {
                try
                {

                    DriveInfo driveInfo = new DriveInfo(item);
                    double Availabe_space = driveInfo.AvailableFreeSpace / divideBYthis;
                    double total_space = driveInfo.TotalSize / divideBYthis;



                    double pv = 100 * Availabe_space / total_space;
                   
                    AddLVItem(item, string.Format("{0:0.0}", Availabe_space), (int)pv);
                   
                }
                catch (Exception)
                {


                }
            }
        }

        private void MyDrives_Load(object sender, EventArgs e)
        {
             getdrive();
        }
        private void AddLVItem(string key, string name, int value)
        {
            lvi = new ListViewItem();
            MetroFramework.Controls.MetroProgressBar pb = new MetroFramework.Controls.MetroProgressBar();
            lvi.SubItems[0].Text = key;

            

            lvi.SubItems.Add(name);
            lvi.SubItems.Add("");
            lvi.SubItems.Add("GB");
            listView1.Items.Add(lvi);

            Rectangle r = lvi.SubItems[2].Bounds;
            pb.SetBounds(r.X, r.Y + 6, r.Width, r.Height - 5);
            pb.Minimum = 1;
            pb.Maximum = 100;
            pb.Size = new Size(120,5);
            pb.Style = MetroFramework.MetroColorStyle.Purple;
            pb.Value = value;
            pb.Name = key;
            listView1.Controls.Add(pb);
            listView1.Cursor = Cursors.Hand;
        }

       
        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            drivename =(e.Item.Text.ToString());
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Process.Start(drivename);
            lvi.Focused = false;
            listView1.SelectedItems[0].Selected = false;
           
        }
    }
}

