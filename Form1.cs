using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace disconnetti
{
    public partial class Disconnessione : Form
    {
        public Disconnessione()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Retrieves access to the processes
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //Sets the starting parameters
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //Window hidden, the command prompt window won't appear
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //The command to run. "cmd.exe /C shutdown -l" sends a logoff request to the OS.
            //The user will be prompted to close any application still running and blocking the logoff.
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -l";
            //Passes the parameters to the process
            process.StartInfo = startInfo;
            //Starts the process
            process.Start();
        }
    }
}
