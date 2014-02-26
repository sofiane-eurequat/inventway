namespace Inventway
{
    partial class ArticleDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleDetail));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.Label1 = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.pBSuiv = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(13, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 20);
            this.Label1.Text = "Designation";
            // 
            // labelDesignation
            // 
            this.labelDesignation.BackColor = System.Drawing.Color.Transparent;
            this.labelDesignation.Location = new System.Drawing.Point(13, 69);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(217, 50);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.Text = "Marque";
            // 
            // labelMarque
            // 
            this.labelMarque.BackColor = System.Drawing.Color.Transparent;
            this.labelMarque.Location = new System.Drawing.Point(73, 130);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(157, 20);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.Text = "Type";
            // 
            // labelType
            // 
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Location = new System.Drawing.Point(73, 167);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(157, 20);
            // 
            // pBSuiv
            // 
            this.pBSuiv.BackColor = System.Drawing.Color.White;
            this.pBSuiv.Image = ((System.Drawing.Image)(resources.GetObject("pBSuiv.Image")));
            this.pBSuiv.Location = new System.Drawing.Point(139, 190);
            this.pBSuiv.Name = "pBSuiv";
            this.pBSuiv.Size = new System.Drawing.Size(53, 53);
            this.pBSuiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSuiv.Click += new System.EventHandler(this.pBSuiv_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(139, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.Text = "Suivant";
            // 
            // ArticleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pBSuiv);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.Label1);
            this.Menu = this.mainMenu1;
            this.Name = "ArticleDetail";
            this.Text = "ArticleDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.PictureBox pBSuiv;
        private System.Windows.Forms.Label label4;
    }
}