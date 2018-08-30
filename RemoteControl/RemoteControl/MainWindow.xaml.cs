using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RemoteControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            remoteControl1.StartServer();
        }

        private void buttonRed_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Red);
        }

        private void buttonGreen_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Green);
        }

        private void buttonBlue_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Blue);
        }

        private void remoteControl11_RemoteControl(object sender, RoutedEventArgs e1)
        {
            var e = e1 as RemoteControl1.RemoteControlEventArgs;
            if (e.pageParams.ContainsKey("red"))
                buttonRed_Click(null, null);
            if (e.pageParams.ContainsKey("blue"))
                buttonBlue_Click(null, null);
            if (e.pageParams.ContainsKey("green"))
                buttonGreen_Click(null, null);
            if (e.pageParams.ContainsKey("name") && e.pageParams["name"] != "")
            {
                textBlockHello.Text = e.pageParams["name"];
                System.Diagnostics.Process.Start("http://google.com/search?q=" + textBlockHello.Text);
            }
            else
            {
                textBlockHello.Text = "";
            }
        }
    }
}
