using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace withness01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int Sleep(long dwTime);

        private void Form1_Load(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._20791802;
            SoundPlayer snd = new SoundPlayer(str);

            Sleep(60000);
            Sleep(60000);
            
            snd.Play();
            
            Sleep(6000);
            Sleep(60000);
            Sleep(60000);
            Sleep(60000);
            
            snd.Play();
            
            Sleep(6000);
            
            Application.Exit();
        }
    }
}
