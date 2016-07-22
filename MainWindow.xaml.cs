using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

        #region global vars
        //bool to check that we are running so we can't hit _python again
        private string _args;
        private bool _canShutdown;

        //processes that will be started
        private readonly Process _python = new Process();
        private readonly Process _web = new Process();

        private readonly Application _application = Application.Current;
        #endregion

        #region Main Window
        public MainWindow()
        {
            Process[] processes= Process.GetProcessesByName("python");

            if (processes.Length > 0)
            {
                MessageBox.Show(
                    "There is already a python server running. Please close the python server and try again.");
                Application.Current.Shutdown();
            }

            InitializeComponent();
        }
        #endregion

        #region Run

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            //auth arg
            string auth = "-a " + authService.Text;
            //user arg
            string user = "-u " + userText.Text;
            //pass arg
            string pass = "-p " + passText.Password;
            //location arg
            string locate = "-l " + "'" + locateText.Text + "'";
            //steps arg
            string steps = "-st " + steps1.Text;

            //main arg string
            _args = "example.py " + auth + " " + user + " " + pass + " " + locate + " " + steps;

                //execute the example.py
                run_cmd("C:/Python27/python.exe", _args);
        }

        #endregion

        #region Run Python Server
        private void run_cmd(string cmd, string args)
        {
            //cmd is full path to python.exe
            _python.StartInfo.FileName = cmd;
            //_args is path to .py file and any cmd line _args
            _python.StartInfo.Arguments = args;
            //open python server
            _python.Start();
            //disable use of start button.
            RunButton.IsEnabled = false;
            //open the web & trigger shut down
            Task.Delay(1500).ContinueWith(_ =>
            {
                System.Diagnostics.Process.Start("http://localhost:5000");
                _canShutdown = true;
            }
    );
            //after the web has started, shut down the easy start application
            do
            {
                _application.Shutdown();
            } while (!_canShutdown);

        }
        #endregion
    }
}
