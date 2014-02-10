namespace Inventway
{
    partial class Articles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articles));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.articleBox = new System.Windows.Forms.TextBox();
            this.article = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.Label();
            this.scannedData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // articleBox
            // 
            this.articleBox.Location = new System.Drawing.Point(23, 98);
            this.articleBox.Name = "articleBox";
            this.articleBox.Size = new System.Drawing.Size(194, 23);
            this.articleBox.TabIndex = 0;
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(24, 70);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(182, 25);
            this.article.Text = "saisie manuelle";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(24, 152);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(193, 23);
            this.stateBox.TabIndex = 4;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(24, 124);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(193, 25);
            this.state.Text = "Etat";
            // 
            // scannedData
            // 
            this.scannedData.BackColor = System.Drawing.Color.Aquamarine;
            this.scannedData.Location = new System.Drawing.Point(23, 33);
            this.scannedData.Name = "scannedData";
            this.scannedData.Size = new System.Drawing.Size(195, 25);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(143, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.Text = "Suivant";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.Text = "Retour";
            // 
            // pBLogin
            // 
            this.pBLogin.BackColor = System.Drawing.Color.White;
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.Location = new System.Drawing.Point(141, 190);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(53, 53);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogin.Click += new System.EventHandler(this.pBLogin_Click);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(46, 190);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(53, 53);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBLogin);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.scannedData);
            this.Controls.Add(this.state);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.article);
            this.Controls.Add(this.articleBox);
            this.Menu = this.mainMenu1;
            this.Name = "Articles";
            this.Text = "articles";
            this.Load += new System.EventHandler(this.articles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox articleBox;
        private System.Windows.Forms.Label article;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label scannedData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.PictureBox pBHome;
    }
}