using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Net;
using System.ComponentModel;
using System.IO;

namespace RemoteControl
{
    /// <summary>
    /// Interaction logic for RemoteControl.xaml
    /// </summary>
    public partial class RemoteControl1 : UserControl
    {
        private readonly BackgroundWorker worker;
        private bool cancelling = false;
        private HttpListener listener;
        private int portNumber = 80;  //if you change this, Android phone doesn't work

        //The Dictionary is used to pass parameters from the background thread to the UI thread.  Using a static works in this case as long as 
        //rate of input is slow enough that UI events are consumed faster than button-presses are received from the remote device.
        //Otherwise the dictionary could be overwritten before it is used. A queue or some sort of semaphone might be needed if this proves to be a problem
        static Dictionary<string, string> pageParams = new Dictionary<string, string>();

        public RemoteControl1()
        {
            InitializeComponent();
            worker = this.FindResource("backgroundWorker") as BackgroundWorker;
        }

        public void StartServer()
        {
            worker.RunWorkerAsync();
            //Display some useful info
            RemoteText.Inlines.Clear();
            string portString = "";
            if (portNumber != 80)
                portString = ":" + portNumber.ToString();
            //display the local machine name /  IP address for use with remote handler
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            string ipString = null;
            foreach (IPAddress ip in localIPs)
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    ipString = ip.ToString();
            RemoteText.Inlines.Add("http://" + ipString + portString + "  OR");
            RemoteText.Inlines.Add(new LineBreak());
            RemoteText.Inlines.Add("http://" + Dns.GetHostName() + portString);
            RemoteText.Inlines.Add(new LineBreak());
            RemoteText.Background = new SolidColorBrush(Colors.LightGreen);
         }

        public void StopServer()
        {
            worker.CancelAsync();
            cancelling = true; //this prevents the error message display from the exception in the next line
            listener.Close(); //this causes the the listener to throw an exception
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Create a listener.
            listener = new HttpListener();
            // Add the prefixes.
            listener.Prefixes.Add("http://*:" + portNumber.ToString() + "/");
            try
            {
                listener.Start();
                //read in the html page to serve
                TextReader tr = new StreamReader("RemoteControlPage.htm");
                string pageString = tr.ReadToEnd();
                while (!worker.CancellationPending)
                {
                    // Note: The GetContext method blocks while waiting for a request. 
                    HttpListenerContext context = listener.GetContext();
                    if (context.Request.HttpMethod == "POST")
                    {
                        //this is a POST, handle the input parameters
                        var body = new StreamReader(context.Request.InputStream).ReadToEnd();
                        ParsePostParameters(body);
                        worker.ReportProgress(1); //raise the event
                    }
                    // Set up the response object to serve the page
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(pageString);
                    context.Response.ContentLength64 = buffer.Length;
                    context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    context.Response.Close();
                }
                listener.Stop();
            }
            catch (Exception e1)
            {
                if (!cancelling)
                    MessageBox.Show("Remote Listener failed. " + e1.Message);
            }
        }

        private static void ParsePostParameters(string body)
        {
            string[] stringParams = body.Split('&');
            pageParams.Clear();
            foreach (string s in stringParams)
            {
                int index = s.IndexOf('=');
                if (index > -1)
                {
                    string key = s.Substring(0, index);
                    string value = s.Substring(index + 1);
                    value = System.Uri.UnescapeDataString(value); //removes all the secret special-character encoding
                    pageParams.Add(key, value);
                }
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            cancelling = false;
            RemoteText.Inlines.Clear();
            RemoteText.Inlines.Add("Remote Control Stopped");
            RemoteText.Background = new SolidColorBrush(Colors.Red);
        }

        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            RoutedEventArgs newEventArgs = new RemoteControlEventArgs(pageParams);
            RaiseEvent(newEventArgs);
            System.Media.SystemSounds.Beep.Play();
        }

        //This is the code needed for the generated event
        public static readonly RoutedEvent RemoteControlEvent = EventManager.RegisterRoutedEvent(
"RemoteControl", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UserControl));

        public class RemoteControlEventArgs : RoutedEventArgs
        {
            public RemoteControlEventArgs(Dictionary<string, string> pageParams)
            {
                RoutedEvent = RemoteControl1.RemoteControlEvent;
                this.pageParams = pageParams;
            }
            public Dictionary<string, string> pageParams;
        }
        public event RoutedEventHandler RemoteControl
        {
            add { AddHandler(RemoteControlEvent, value); }
            remove { RemoveHandler(RemoteControlEvent, value); }
        }
    }
}
