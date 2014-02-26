namespace Inventway
{
    partial class LoadInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadInventory));
            this.inventoySelectBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CBBase = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inventoySelectBox
            // 
            this.inventoySelectBox.Location = new System.Drawing.Point(20, 34);
            this.inventoySelectBox.Name = "inventoySelectBox";
            this.inventoySelectBox.Size = new System.Drawing.Size(214, 23);
            this.inventoySelectBox.TabIndex = 0;
            this.inventoySelectBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(139, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.Text = "Suivant";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.Text = "Retour";
            // 
            // pBLogin
            // 
            this.pBLogin.BackColor = System.Drawing.Color.White;
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.Location = new System.Drawing.Point(137, 138);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(53, 53);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogin.Click += new System.EventHandler(this.pBLogin_Click_1);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.White;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(41, 138);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(53, 53);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CBBase
            // 
            this.CBBase.Location = new System.Drawing.Point(20, 92);
            this.CBBase.Name = "CBBase";
            this.CBBase.Size = new System.Drawing.Size(214, 23);
            this.CBBase.TabIndex = 4;
            // 
            // LoadInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 272);
            this.Controls.Add(this.CBBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBLogin);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.inventoySelectBox);
            this.Name = "LoadInventory";
            this.Text = "Charger Inventaire";
            this.Load += new System.EventHandler(this.LoadInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox inventoySelectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CBBase;
    }
}