namespace withness03
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
            this.btn_Doo = new System.Windows.Forms.Button();
            this.lbl_S = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Doo
            // 
            this.btn_Doo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Doo.Location = new System.Drawing.Point(0, 0);
            this.btn_Doo.Name = "btn_Doo";
            this.btn_Doo.Size = new System.Drawing.Size(261, 81);
            this.btn_Doo.TabIndex = 0;
            this.btn_Doo.Text = "Do";
            this.btn_Doo.UseVisualStyleBackColor = true;
            this.btn_Doo.Click += new System.EventHandler(this.btn_Doo_Click);
            // 
            // lbl_S
            // 
            this.lbl_S.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_S.Location = new System.Drawing.Point(0, 0);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(261, 81);
            this.lbl_S.TabIndex = 1;
            this.lbl_S.Text = "label1";
            this.lbl_S.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 81);
            this.Controls.Add(this.btn_Doo);
            this.Controls.Add(this.lbl_S);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Doo;
        private System.Windows.Forms.Label lbl_S;
    }
}

