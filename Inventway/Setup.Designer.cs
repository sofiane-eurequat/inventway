namespace Inventway
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.openFileInventory = new System.Windows.Forms.OpenFileDialog();
            this.analytique = new System.Windows.Forms.TextBox();
            this.regionBox = new System.Windows.Forms.TextBox();
            this.analytiqueLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileInventory
            // 
            this.openFileInventory.FileName = "charger Inventaire";
            // 
            // analytique
            // 
            this.analytique.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.analytique.Location = new System.Drawing.Point(10, 117);
            this.analytique.Name = "analytique";
            this.analytique.Size = new System.Drawing.Size(221, 23);
            this.analytique.TabIndex = 0;
            this.analytique.Visible = false;
            // 
            // regionBox
            // 
            this.regionBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.regionBox.Location = new System.Drawing.Point(10, 169);
            this.regionBox.MaxLength = 2;
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(47, 23);
            this.regionBox.TabIndex = 1;
            // 
            // analytiqueLabel
            // 
            this.analytiqueLabel.Location = new System.Drawing.Point(10, 91);
            this.analytiqueLabel.Name = "analytiqueLabel";
            this.analytiqueLabel.Size = new System.Drawing.Size(166, 23);
            this.analytiqueLabel.Text = "Compte Analytique";
            // 
            // regionLabel
            // 
            this.regionLabel.Location = new System.Drawing.Point(10, 143);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(89, 23);
            this.regionLabel.Text = "Code Région";
            // 
            // UserLabel
            // 
            this.UserLabel.Location = new System.Drawing.Point(10, 39);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(166, 23);
            this.UserLabel.Text = "Utilisateur";
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.userBox.Location = new System.Drawing.Point(10, 56);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(112, 23);
            this.userBox.TabIndex = 11;
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(103, 193);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(53, 53);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click_1);
            // 
            // pBLogin
            // 
            this.pBLogin.BackColor = System.Drawing.Color.White;
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.Location = new System.Drawing.Point(171, 193);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(53, 53);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogin.Click += new System.EventHandler(this.pBLogin_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(107, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.Text = "Retour";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.Text = "Suivant";
            // 
            // Setup
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
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.analytiqueLabel);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.analytique);
            this.Menu = this.mainMenu1;
            this.Name = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileInventory;
        private System.Windows.Forms.TextBox analytique;
        private System.Windows.Forms.TextBox regionBox;
        private System.Windows.Forms.Label analytiqueLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}