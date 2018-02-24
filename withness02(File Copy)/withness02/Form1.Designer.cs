namespace withness02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clb_Files = new System.Windows.Forms.CheckedListBox();
            this.lbl_size = new System.Windows.Forms.Label();
            this.txt_dest = new System.Windows.Forms.TextBox();
            this.pb_PB = new System.Windows.Forms.ProgressBar();
            this.btn_cut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb_Files
            // 
            this.clb_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb_Files.CheckOnClick = true;
            this.clb_Files.FormattingEnabled = true;
            this.clb_Files.Location = new System.Drawing.Point(12, 12);
            this.clb_Files.Name = "clb_Files";
            this.clb_Files.ScrollAlwaysVisible = true;
            this.clb_Files.Size = new System.Drawing.Size(403, 227);
            this.clb_Files.Sorted = true;
            this.clb_Files.TabIndex = 0;
            this.clb_Files.SelectedIndexChanged += new System.EventHandler(this.clb_Files_SelectedIndexChanged);
            // 
            // lbl_size
            // 
            this.lbl_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_size.Location = new System.Drawing.Point(12, 243);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(403, 16);
            this.lbl_size.TabIndex = 1;
            // 
            // txt_dest
            // 
            this.txt_dest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dest.Location = new System.Drawing.Point(12, 262);
            this.txt_dest.Name = "txt_dest";
            this.txt_dest.Size = new System.Drawing.Size(403, 20);
            this.txt_dest.TabIndex = 2;
            this.txt_dest.Text = "G:\\";
            // 
            // pb_PB
            // 
            this.pb_PB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_PB.Location = new System.Drawing.Point(12, 288);
            this.pb_PB.Name = "pb_PB";
            this.pb_PB.Size = new System.Drawing.Size(403, 23);
            this.pb_PB.Step = 1;
            this.pb_PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_PB.TabIndex = 3;
            // 
            // btn_cut
            // 
            this.btn_cut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cut.Location = new System.Drawing.Point(12, 317);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(403, 23);
            this.btn_cut.TabIndex = 4;
            this.btn_cut.Text = "Cut";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 349);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.pb_PB);
            this.Controls.Add(this.txt_dest);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.clb_Files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Files;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.TextBox txt_dest;
        private System.Windows.Forms.ProgressBar pb_PB;
        private System.Windows.Forms.Button btn_cut;
    }
}

