using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Windows.Forms.Integration;
using RemoteControl;

namespace JarvisGUI
{
    public partial class Form1 : Form
    {
        Monitor mo;
        NetworkGUI ng;
        MyDrives drives;
        Profiler profile;
        SciFiButton scifi;
        DownBorder downborder;
        InternetConnectionSettings myConnection;
        BatteryStatus bs;
        CommandWindow cw;
        int counterForTvJarvisDsply = 0;


        /// <summary>
        /// ///////////////////////////////DLL Loader
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        DictationGrammar dg = new DictationGrammar();
        Choices command = new Choices();

        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
        [DllImport("user32.dll")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]



        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        int voice = 0;
        /// </summary>

        ////////////////////////////  Is Process Open Checker
        public bool IsProcessOpen(string name)
        {

            foreach (Process clsProcess in Process.GetProcesses())
            {

                if (clsProcess.ProcessName.Contains(name))
                {

                    return true;
                }
            }

            return false;
        }



        public Form1()
        {
            InitializeComponent();
            treeView1.SelectedNode = null;
            treeView1.SelectedNode = null;
            drives = new MyDrives();
            profile = new Profiler();
            myConnection = new InternetConnectionSettings();
            scifi = new SciFiButton();
            ng = new NetworkGUI();
            downborder = new DownBorder();
            bs = new BatteryStatus();
            mo = new Monitor();
            var wpf = new MainWindow();

            hostBy();


        }

        private void hostBy()
        {
            int portNumber = 80;
            string portString = "";
            if (portNumber != 80)
                portString = ":" + portNumber.ToString();
            //display the local machine name /  IP address for use with remote handler
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            string ipString = null;
            foreach (IPAddress ip in localIPs)
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    ipString = ip.ToString();
            label10.Text=("http://" + Dns.GetHostName() + portString);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            makeTrnasparent();
            mergeOtherForms();
            jVoice();
          
        }

        private void makeTrnasparent()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent; 
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
        }

        private void mergeOtherForms()
        {
            drives.Location = new System.Drawing.Point(1095, 490);
            profile.Location = new System.Drawing.Point(1070, 10);
            scifi.Location = new System.Drawing.Point(508, 10);
            ng.Location = new System.Drawing.Point(30, 260);
            downborder.Location = new System.Drawing.Point(285, 668);
            bs.Location = new System.Drawing.Point(1077, 265);
            mo.Location = new System.Drawing.Point(1095,580);

            drives.TopLevel = false;
            profile.TopLevel = false;
            scifi.TopLevel = false;
            ng.TopLevel = false;
            downborder.TopLevel = false;
            bs.TopLevel = false;
            mo.TopLevel = false;
            
            drives.Parent = this;
            profile.Parent = this;
            scifi.Parent = this;
            ng.Parent = this;
            downborder.Parent = this;
            bs.Parent = this;
            mo.Parent = this;
           

            this.Controls.Add(drives);
            this.Controls.Add(profile);
            this.Controls.Add(scifi);
            this.Controls.Add(ng);
            this.Controls.Add(downborder);
            this.Controls.Add(bs);
            this.Controls.Add(mo);
           

            drives.Show();
            profile.Show();
            scifi.Show();
            ng.Show();
            downborder.Show();
            bs.Show();
            mo.Show();
           
        }

        /// <summary>
        /// Commands of jarvis
        /// </summary>
        private void jVoice()
        {

            command.Add(new String[] { " open system", "open Main Screen", "jarvis", " open cmd","close cmd", "lock pc", "do log off",
                                       " do hibernate", "goto sleep", "open chrome", "open notepad",
                                       "find", "change Voice","close notepad","close chrome","what is network speed",
                                       "go offline",   "open google","open fb","open facebook","open wiki","open wikipedia",
                                       " open youtube","open mail","open gmail","open charge condition","show commands","hide commands"
            });

            //command.Add(File.ReadAllLines(@"C:\Users\Aksh\Desktop\commands.txt"));
            //// command.Add(File.ReadAllLines(@"A:\WORKSPACE CODES\Innotion WebSites\Personal Assistant\Personal Assistant\selfGrammer.txt"));

            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(command);
            Grammar grammar = new Grammar(gbuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }


        /// <summary>
        /// COMMANDS Executions by Jarvis
        /// </summary>
        /// 
        Boolean flag = false;
        public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            switch (e.Result.Text)
            {

                case "change Voice":
                    synthesizer.SpeakAsync("Voice has been changed.");

                    if (voice == 0)
                    {
                        // select male senior (if it exists)
                        synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
                        voice = 1;
                    }
                    else
                    {
                        // select female senior (if it exists)
                        synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
                        voice = 0;
                    }
                    break;

                case "what time is it":
                    synthesizer.SpeakAsync(DateTime.Now.ToString("h mm:tt"));
                    break;

                case "what is today":
                case "date":
                    synthesizer.SpeakAsync(DateTime.Now.ToString("M/d/yyyy"));
                    break;

                case "find":
                    synthesizer.SpeakAsync("try to find...but for what?");
                    flag = true;
                    try
                    {
                        recEngine.LoadGrammarAsync(dg);
                    }
                    catch (Exception)
                    {

                    }
                   
                    break;

                case "go offline":

                    // synthesizer.SpeakAsync(Clipboard.SetText());
                    synthesizer.SpeakAsync("Have a nice day..I'm going Offline");
                    Thread.Sleep(3000);
                    this.Dispose();
                    break;
                case "show commands":
                    cw = new CommandWindow();
                    cw.Show();
                    break;

                case "hide commands":
                    try
                    {
                        cw.Dispose();
                    }
                    catch (Exception)
                    {

                       
                    }
                    break;
                case "open charge condition":
                    synthesizer.SpeakAsync(bs.percentage().ToString()+ "percentages");
                    break;

                case "what is network speed":
                    synthesizer.SpeakAsync(ng.speed().ToString());
                    break;


                case "open Main Screen":
                    if (WindowState == FormWindowState.Maximized)
                    {
                        synthesizer.SpeakAsync("Compressing");
                        this.WindowState = FormWindowState.Minimized;
                    }
                    else
                    {
                        synthesizer.SpeakAsync("Expanding");
                        this.WindowState = FormWindowState.Maximized;
                    }

                    break;

                case "jarvis":
                    string[] tell = { "hello sir","in your service sir","how can i help you sir" };
                    synthesizer.SpeakAsync(tell[new Random().Next(0, tell.Length)]);
                    break;

                case "open system":
                    synthesizer.SpeakAsync("System openning...");
                    Process.Start("userinit");
                    break;

                
                case "open cmd":
                    synthesizer.SpeakAsync("cmd is openning...");
                    Process.Start("cmd");
                    break;

                case "close cmd":
                    if (IsProcessOpen("cmd") == true)
                    {
                        foreach (var process in Process.GetProcessesByName("cmd"))
                        {
                            synthesizer.SpeakAsync("cmd is closing...");
                            process.Kill();
                        }
                    }


                    break;

                case "open chrome":
                    synthesizer.SpeakAsync("Chrome is openning...");
                    Process.Start("chrome.exe");
                    break;

                case "close chrome":
                    if (IsProcessOpen("chrome") == true)
                    {
                        foreach (var process in Process.GetProcessesByName("chrome"))
                        {
                            
                            process.Kill();
                        }
                        synthesizer.SpeakAsync("chrome is closing...");
                    }

                    break;

                case "open google":
                    synthesizer.SpeakAsync("google is openning...");
                    Process.Start("chrome.exe", "www.google.com");
                    break;
                 
                case "open fb":
                case "open facebook":
                    synthesizer.SpeakAsync("facebook is openning...");
                    Process.Start("chrome.exe", "www.facebook.com");
                    break;

                case "open wiki":
                case "open wikipedia":
                    synthesizer.SpeakAsync("wikipedia is openning...");
                    Process.Start("chrome.exe", "www.wikipedia.com");
                    break;

                case "open youtube":
                    synthesizer.SpeakAsync("youtube is openning...");
                    Process.Start("chrome.exe", "www.youtube.com");
                    break;

                case "open mail":
                case "open gmail":
                    synthesizer.SpeakAsync("Gmail is openning...");
                    Process.Start("chrome.exe", "www.gmail.com");
                    break;

                case "open notepad":

                    synthesizer.SpeakAsync("Notepad is openning...");
                    Process.Start("notepad.exe");

                    break;

                case "close notepad":
                    if (IsProcessOpen("notepad") == true)
                    {
                        foreach (var process in Process.GetProcessesByName("notepad"))
                        {
                            synthesizer.SpeakAsync("notepad is closing...");
                            process.Kill();
                        }
                    }

                    break;


                case "lock pc":
                    synthesizer.SpeakAsync("Locked...");
                    LockWorkStation();
                    break;

                case "do log off":
                    synthesizer.SpeakAsync("log offed...");
                    ExitWindowsEx(0, 0);
                    break;

                case "do hibernate":
                    synthesizer.SpeakAsync("Hiberneted...");
                    SetSuspendState(true, true, true);
                    break;

                case "goto sleep":
                    synthesizer.SpeakAsync("Sleeping...");
                    SetSuspendState(false, true, true);
                    break;

                default:
                    if (flag == true)
                    {
                        searchText.Text = e.Result.Text.ToString();
                        recEngine.UnloadGrammar(dg);
                        flag = false;
                    }
                    //else
                    //{
                    //   // synthesizer.SpeakAsync("Please speek clearly..I am not getting you");
                    //}
                    break;


            }
        }
















        /////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Form1 Designs...
        /// </summary>
      
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            drives.Update();
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString("h:mm:tt");
            counterForTvJarvisDsply++;
           

          

        }

        

        private void label1_Click(object sender, EventArgs e)   ///LeftLblMenu
        {
             Process.Start("taskmgr");
           
        }

        private void label3_Click(object sender, EventArgs e)   ///TopLblMenu
        {
            Process.Start("dxdiag");
        }

        private void label2_Click(object sender, EventArgs e)   ///RightLblMenu
        {
            Process.Start("devmgmt.msc");
        }

        private void label4_Click(object sender, EventArgs e)   ///DownLblMenu
        {
            Process.Start("winver");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            Process.Start("timedate.cpl");
            
        }
        private void lblTime_MouseHover(object sender, EventArgs e)
        {
            lblTime.ForeColor = Color.BurlyWood;
        }

        private void lblTime_MouseLeave(object sender, EventArgs e)
        {
            lblTime.ForeColor = Color.White;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
                switch (e.Node.Text)
            {
                case "Explorer":
                    Process.Start(@"explorer");
                    break;

                case "Voice":
                    Process.Start(@"C:\Windows\SysWOW64\Speech\SpeechUX\sapi.cpl");
                    break;

                case "Volume":
                    Process.Start("sndvol");
                    break;

                case "Control":
                    Process.Start("control");
                    break;

               case "Media Player":
                    Process.Start("wmplayer");
                    break;
            }
            
        }

     
        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
           
            foreach (TreeNode item in treeView1.Nodes)
            {
                item.NodeFont = new Font("BatmanForeverAlternate", 8.25f, System.Drawing.FontStyle.Italic);
                
                treeView1.SelectedNode = null;
                for (int i = 0; i < item.Nodes.Count; i++)
                {
                    item.Nodes[i].NodeFont = new Font("BatmanForeverAlternate", 8.25f, System.Drawing.FontStyle.Italic);

                }

            }

            e.Node.NodeFont = new Font("BatmanForeverAlternate", 8.7f, System.Drawing.FontStyle.Italic);
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("dcomcnfg");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("utilman");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc");
        }

        private void Search_Click(object sender, EventArgs e)
        {

            Process.Start("http://google.com/search?q=" + searchText.Text);
        }



        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);




        private void button1_Click(object sender, EventArgs e)
        {
            Process[] notepads = Process.GetProcessesByName("notepad"); if (notepads.Length == 0) return; if (notepads[0] != null)

            {

                IntPtr child = FindWindowEx(notepads[0].MainWindowHandle, new IntPtr(0), "Edit", null);

                SendMessage(child, 0x000C, 0, searchText.Text);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] cmds = Process.GetProcessesByName("cmd"); if (cmds.Length == 0) return; if (cmds[0] != null)

            {

                IntPtr child = FindWindowEx(cmds[0].MainWindowHandle, new IntPtr(0), "Edit", null);

                SendMessage(child, 0x000C, 0, searchText.Text);

            }

        }
    }
}