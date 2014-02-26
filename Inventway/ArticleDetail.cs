using System;
using System.Windows.Forms;

namespace Inventway
{
    public partial class ArticleDetail : Form
    {

        public ArticleDetail(string id)
        {
            InitializeComponent();

            if (id != "" && Program.inventaireRacine != null)
            {
                foreach (var ligne in Program.inventaireRacine)
                {
                    if (ligne.CodeProvisoire != id && ligne.Codedefinitif != id) continue;
                    labelDesignation.Text = ligne.designation;
                    labelMarque.Text = ligne.Marque;
                    labelType.Text = ligne.Type;
                    break;
                }
            }
        }


      
        private void pBLogin_Click(object sender, EventArgs e)
        {

        }

        private void pBHome_Click(object sender, EventArgs e)
        {

        }

        private void pBSuiv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}