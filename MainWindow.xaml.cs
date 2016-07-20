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

        #region global vars
        //bool to check that we are running so we can't hit _python again
        private bool isRunning = false;
        private string _args;

        //processes that will be started
        private readonly Process _python = new Process();
        private readonly Process _web = new Process();
        #endregion

        #region Main Window
        public MainWindow()
        {
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
            string pass = "-p " + passText.Text;
            //location arg
            string locate = "-l " + "'" + locateText.Text + "'";
            //steps arg
            string steps = "-st " + steps1.Text;

            //main arg string
            _args = "example.py " + auth + " " + user + " " + pass + " " + locate + " " + steps;

            if (isRunning)
            {
                if (_python.HasExited)
                {
                    isRunning = false;
                    run_cmd("C:/Python27/python.exe", _args);
                }
                else
                {
                    MessageBox.Show("The python server is already running. Stop the server and try again.");
                }
            }
            else
            {
                //execute the example.py
                run_cmd("C:/Python27/python.exe", _args);
                isRunning = true;
            }
        }

        #endregion

        #region Stop
        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                //stop processes and let us open everything back up.
                _python.CloseMainWindow();
                isRunning = false;
            }
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
            //we are running now
            isRunning = true;
            //open the web
            Task.Delay(5000).ContinueWith(_ =>
            {
                System.Diagnostics.Process.Start("http://localhost:5000");
            }
    );
        }
        #endregion
    }
}
