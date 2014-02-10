namespace Inventway
{
    partial class Inventaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventaire));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(25, 79);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(189, 23);
            this.locationBox.TabIndex = 0;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(25, 35);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(183, 28);
            this.location.Text = "Emplacement";
            this.location.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(120, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.Text = "Suivant";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.Text = "Retour";
            // 
            // pBLogin
            // 
            this.pBLogin.BackColor = System.Drawing.Color.White;
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.Location = new System.Drawing.Point(118, 143);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(53, 53);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogin.Click += new System.EventHandler(this.pBLogin_Click);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(50, 143);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(53, 53);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click);
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 272);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBLogin);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.location);
            this.Controls.Add(this.locationBox);
            this.Menu = this.mainMenu1;
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.PictureBox pBHome;
    }
}