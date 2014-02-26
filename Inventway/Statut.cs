using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventway
{
    public partial class Statut : Form
    {

        public bool rejete = false;
        public Statut()
        {
            InitializeComponent();
        }

       
        private void pBLogin_Click_1(object sender, EventArgs e)
        {
            rejete = false;
            
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rejete = true;

            this.Close();
        }
    }
}