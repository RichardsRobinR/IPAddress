using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getIpaddress();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ipadress_Name.Text = "IP Address";
            this.ipaddress_Textbox.Text = getIpaddress();
        }

        String getIpaddress()
        {
            Process process = new Process();
            
            process.StartInfo.FileName = "ipconfig.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            StreamReader reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            //Console.WriteLine(output);

            process.WaitForExit();

            var getIpadress = output.IndexOf("IPv4 Address. . . . . . . . . . . :");


            return output.Substring((getIpadress + 36), 17);
        }
    }
}
