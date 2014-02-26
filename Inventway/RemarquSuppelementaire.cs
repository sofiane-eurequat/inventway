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
    public partial class RemarquSuppelementaire : Form
    {
        public RemarquSuppelementaire()
        {
            InitializeComponent();
           
        }

        public string getRemarque()
        {
            return TBRemarque.Text;
        }

        private void pBSuiv_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}