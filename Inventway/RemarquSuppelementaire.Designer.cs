namespace Inventway
{
    partial class RemarquSuppelementaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemarquSuppelementaire));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.TBRemarque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pBSuiv = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.Text = "Remarques Supplementaire";
            // 
            // TBRemarque
            // 
            this.TBRemarque.Location = new System.Drawing.Point(3, 48);
            this.TBRemarque.Multiline = true;
            this.TBRemarque.Name = "TBRemarque";
            this.TBRemarque.Size = new System.Drawing.Size(240, 102);
            this.TBRemarque.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(144, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.Text = "Suivant";
            // 
            // pBSuiv
            // 
            this.pBSuiv.BackColor = System.Drawing.Color.White;
            this.pBSuiv.Image = ((System.Drawing.Image)(resources.GetObject("pBSuiv.Image")));
            this.pBSuiv.Location = new System.Drawing.Point(144, 192);
            this.pBSuiv.Name = "pBSuiv";
            this.pBSuiv.Size = new System.Drawing.Size(53, 53);
            this.pBSuiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSuiv.Click += new System.EventHandler(this.pBSuiv_Click);
            // 
            // RemarquSuppelementaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pBSuiv);
            this.Controls.Add(this.TBRemarque);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "RemarquSuppelementaire";
            this.Text = "RemarquSuppelementaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBRemarque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pBSuiv;
    }
}