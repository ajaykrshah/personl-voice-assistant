using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarvisGUI
{
    public partial class CommandWindow : Form
    {
        private System.Speech.Synthesis.SpeechSynthesizer synthesizer = new System.Speech.Synthesis.SpeechSynthesizer();

        public CommandWindow()
        {
            InitializeComponent();
            
        }

        private void CommandWindow_Load(object sender, EventArgs e)
        {
           // string[] yaView = File.ReadAllLines(@"C:\Users\Aksh\Desktop\commands.txt");
           //// String[] yaArray = yaView.Split(new char[] { ',' });
           // foreach (string ya in yaView)
           // {
           //     listBox1.Items.Add(ya);
           // }
        }

     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync(listBox1.SelectedItem.ToString());
        }
    }
    }


