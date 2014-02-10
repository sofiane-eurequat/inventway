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
    public partial class Show : Form
    {
        private List<InventoryData> m_inventoryDatas;

        public List<InventoryData> inventoryDatas
        {
            get { return m_inventoryDatas; }
            set { m_inventoryDatas = value; }
        }
        public Show()
        {
            InitializeComponent();
        }

        public void setGrid() 
        {
            inventoryGrid.DataSource = m_inventoryDatas;
        }

        private void invontoryGrid_CurrentCellChanged(object sender, EventArgs e)
        {
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBQuitter_Click(object sender, EventArgs e)
        {

        }

        private void pBQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}