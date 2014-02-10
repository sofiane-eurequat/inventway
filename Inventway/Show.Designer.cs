namespace Inventway
{
    partial class Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.inventoryGrid = new System.Windows.Forms.DataGrid();
            this.pBQuitter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.inventoryGrid.Location = new System.Drawing.Point(15, 24);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.Size = new System.Drawing.Size(218, 177);
            this.inventoryGrid.TabIndex = 0;
            this.inventoryGrid.CurrentCellChanged += new System.EventHandler(this.invontoryGrid_CurrentCellChanged);
            // 
            // pBQuitter
            // 
            this.pBQuitter.Image = ((System.Drawing.Image)(resources.GetObject("pBQuitter.Image")));
            this.pBQuitter.Location = new System.Drawing.Point(88, 207);
            this.pBQuitter.Name = "pBQuitter";
            this.pBQuitter.Size = new System.Drawing.Size(43, 43);
            this.pBQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBQuitter.Click += new System.EventHandler(this.pBQuitter_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Fermer";
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBQuitter);
            this.Controls.Add(this.inventoryGrid);
            this.Menu = this.mainMenu1;
            this.Name = "Show";
            this.Text = "Visualisation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid inventoryGrid;
        private System.Windows.Forms.PictureBox pBQuitter;
        private System.Windows.Forms.Label label1;
    }
}