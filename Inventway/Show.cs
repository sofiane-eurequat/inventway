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
        private List<InventoryData> m_inventaireRejete;

        public List<InventoryData> inventaireRejete 
        {
            get { return m_inventaireRejete; }
            set { m_inventaireRejete = value; }
        }
        

        public Show()
        {
            InitializeComponent();
        }

        public void setGrid()
        {
            var liste = new List<InventoryData>();
            liste.AddRange(inventaireRejete); 
            liste.AddRange(m_inventoryDatas);
            inventoryGrid.DataSource = liste;
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