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
    public partial class Setup : Form
    {
        private String m_analytique;
        private String m_codeRegion;
        private String m_user;
        private List<InventoryData> m_inventoryDatas;
        public Setup()
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
            get { return m_analytique; }
            set { m_analytique = value; }
        }
        public String CodeRegion
        {
            get { return m_codeRegion; }
            set { m_codeRegion = value; }
        }
        public String User
        {
            get { return m_user; }
            set { m_user = value; }
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            if(inventoryDatas.Count()>0)
            {
                regionBox.Text = inventoryDatas.First().structure;
               // analytique.Text = inventoryDatas.First().analytique;
                userBox.Text = inventoryDatas.First().agent;
            }
        }

        private void validate_Click(object sender, EventArgs e)
        {
            CodeRegion = regionBox.Text;
            Analytique = analytique.Text;
            User = userBox.Text;
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pBHome_Click(object sender, EventArgs e)
        {

        }

        private void pBHome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pBLogin_Click(object sender, EventArgs e)
        {

        }

        private void pBLogin_Click_1(object sender, EventArgs e)
        {
            CodeRegion = regionBox.Text;
            Analytique = analytique.Text;
            User = userBox.Text;
            this.Hide();
        }


    }
}