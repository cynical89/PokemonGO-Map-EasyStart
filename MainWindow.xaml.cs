using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokeGoMap_EasyButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            //auth arg
            string _auth = "-a " + auth.Text;
            //user arg
            string _user = "-u " + userText.Text;
            //pass arg
            string _pass = "-p " + passText.Text;
            //location arg
            string _locate = "-l " + "'" + locateText.Text + "'";
            //steps arg
            string _steps = "-st " + steps1.Text;

            //main arg string
            string args = "example.py " + _auth + " " + _user + " " + _pass + " " + _locate + " " + _steps;

            //execute the example.py
            run_cmd("C:/Python27/python.exe", args);
            //open web browser after 5 seconds
            Task.Delay(5000).ContinueWith(_ =>
                {
                    System.Diagnostics.Process.Start("http://localhost:5000");
                }
            );
        }

        private void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cmd;//cmd is full path to python.exe
            start.Arguments = args;//args is path to .py file and any cmd line args
            Process.Start(start);
        }
    }
}
