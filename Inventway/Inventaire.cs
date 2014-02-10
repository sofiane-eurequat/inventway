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
    public partial class Inventaire : Form
    {
        private Articles articles;
        private List<InventoryData> m_inventoryDatas;
        private InventoryData m_inventoryData;
        private String m_analytique = "";
        private String m_structure = "";
        private String m_user = "";
        public Inventaire()
        {
            InitializeComponent();
        }
        public List<InventoryData> inventoryDatas
        {
            get { return m_inventoryDatas; }
            set { m_inventoryDatas = value; }
        }
        public String Analytique
        {
            get { return m_structure; }
            set { m_structure = value; }
        }
        public String Structure
        {
            get { return m_analytique; }
            set { m_analytique = value; }
        }
        public String User
        {
            get { return m_user; }
            set { m_user = value; }
        }
        public InventoryData inventoryData
        {
            get { return m_inventoryData; }
            set { m_inventoryData = value; }
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            locationBox.Focus();
            this.Hide();
        }

        private void suivant_Click(object sender, EventArgs e)
        {
        //    if (articles == null)
        //    { 
                articles = new Articles();               
                articles.inventoryDatas = inventoryDatas;
       //     }
            articles.Analytique = Analytique;
            articles.Structure = Structure;
            articles.User = User;
            locationBox.Focus();
            articles.location = locationBox.Text;
            articles.Show();
        }

        private void pBLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void pBHome_Click_1(object sender, EventArgs e)
        {

        }

        private void pBLogin_Click(object sender, EventArgs e)
        {
            //    if (articles == null)
            //    { 
            articles = new Articles();
            articles.inventoryDatas = inventoryDatas;
            //     }
            articles.Analytique = Analytique;
            articles.Structure = Structure;
            articles.User = User;
            locationBox.Focus();
            articles.location = locationBox.Text;
            articles.Show();
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            locationBox.Focus();
            this.Hide();
        }
    }
}