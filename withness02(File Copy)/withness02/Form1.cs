using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace withness02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] FNS;
        int FNum = 0, FSize = 0;
        bool Pro = true;

        withness02.TXTED TRX = new TXTED();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string Id in Directory.GetDirectories(@"D:\TAT\T.S.2\S.R.F\"))
            {
                clb_Files.Items.Add(Id);
            }
        }

        private void clb_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            FNum = 0;
            FSize = 0;
            foreach (string r in clb_Files.CheckedItems)
            {
                FNum += Directory.GetFiles(/*@"D:\TAT\T.S.2\S.R.F\" +*/ r.ToString() + "\\").Length;
                FSize += (int)CalculateFolderSize(/*@"D:\TAT\T.S.2\S.R.F\" +*/ r);
            }
            lbl_size.Text = FNum.ToString() + " Files, " + FSize.ToString() + " Bytes.";
        }

        protected static float CalculateFolderSize(string folder)
        {
            float folderSize = 0.0f;
            try
            {
                //Checks if the path is valid or not
                if (!Directory.Exists(folder))
                    return folderSize;
                else
                {
                    try
                    {
                        foreach (string file in Directory.GetFiles(folder))
                        {
                            if (File.Exists(file))
                            {
                                FileInfo finfo = new FileInfo(file);
                                folderSize += finfo.Length;
                            }
                        }

                        foreach (string dir in Directory.GetDirectories(folder))
                            folderSize += CalculateFolderSize(dir);
                    }
                    catch (NotSupportedException e)
                    {
                        //Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
                        MessageBox.Show("Error!!!");
                        Application.Exit();
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                //Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
                MessageBox.Show("Error!!!");
                Application.Exit();

            }
            return folderSize;
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            btn_cut.Enabled = false;
            pb_PB.Value = 0;
            int Poro = 0;
            foreach (string r in clb_Files.CheckedItems)
            {
                Directory.CreateDirectory(txt_dest.Text + Path.GetFileNameWithoutExtension(r + ".mp4"));
                foreach(string You in Directory.GetFiles(r,"*.R"))
                    File.Move(You, txt_dest.Text + Path.GetFileNameWithoutExtension(r + ".mp4") + "\\" + Path.GetFileNameWithoutExtension(You) + ".txt");
                foreach (string Y in Directory.GetFiles(r))
                {
                    File.Move(Y, txt_dest.Text + Path.GetFileNameWithoutExtension(r + ".mp4") + "\\" + TRX.HexStrToStrDE(Path.GetFileNameWithoutExtension(Y)) + ".png");
                    Poro++;
                    pb_PB.Value = (Poro / FNum) * 100;
                    this.Refresh();
                }
                Directory.Delete(r);
            }

            btn_cut.Enabled = true;
            pb_PB.Value = 100;
            foreach (string Id in Directory.GetDirectories(@"D:\TAT\T.S.2\S.R.F\"))
            {
                clb_Files.Items.Add(Id);
            }
        }
    }
}
