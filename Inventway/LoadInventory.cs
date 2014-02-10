using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Inventway
{
    public partial class LoadInventory : Form
    {
        private List<InventoryData> m_inventoryDatas = new List<InventoryData>();
        private String m_analytique;
        private String m_structure;
        private String m_user;
        private String m_filename = "";
        public LoadInventory()
        {
            InitializeComponent();
        }
        public String FileName
        {
            get { return m_filename; }
            set { m_filename = value; }
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
        public String Structure
        {
            get { return m_structure; }
            set { m_structure = value; }
        }
        public String User
        {
            get { return m_user; }
            set { m_user = value; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            if (inventoySelectBox.SelectedItem.ToString() == "Nouvelle Inventaire")
            {
                ClearInventoryData();
                DateTime today = DateTime.Now;
                FileName = "My Documents\\inventway\\" +"INVSTR" + today.ToString("dd-MM-yyyy  HH.mm.ss") + ".csv";
            }
            else
            {
                LoadInventoryData(inventoySelectBox.SelectedItem.ToString());
                FileName = inventoySelectBox.SelectedItem.ToString();
            }
            this.Hide();
        }
        private void LoadInventoryData(String file)
        {
            ClearInventoryData();
            
            DateTime today = DateTime.Now;
            if (!Directory.Exists("My Documents\\inventway"))
            {
                Directory.CreateDirectory(@"My Documents\inventway");
            }
            Directory.SetCurrentDirectory(@"My Documents\inventway");
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }

      

            StreamReader srdrFile = new StreamReader(new FileStream(file, FileMode.Open));
            String input = null;
            while ((input = srdrFile.ReadLine()) != null)
            {
                InventoryData InventoryData = new InventoryData();
                int next = 0;
                int current = 0;

               // InventoryData.analytique = input.Substring(current, (next = input.IndexOf("|", current)) - current);
               // current = next + 1;

                InventoryData.structure = input.Substring(current, (next = input.IndexOf(";", current)) - current);
                current = next + 1;
                InventoryData.location = input.Substring(current, (next = input.IndexOf(";", current)) - current);
                current = next + 1;
                InventoryData.barcode = input.Substring(current, (next = input.IndexOf(";", current)) - current);
                current = next + 1;

                InventoryData.state = input.Substring(current, (next = input.IndexOf(";", current)) - current);
                current = next + 1;
                InventoryData.agent = input.Substring(current, input.Length - current);
                //current = next + 1;

                //InventoryData.type_read = input.Substring(current, (next = input.IndexOf("|", current)) - current);
                //current = next + 1;
                //InventoryData.date = DateTime.ParseExact(input.Substring(current, input.Length - current), "dd/MM/yyyy,HH:mm:ss", null);
                inventoryDatas.Add(InventoryData);
            }
            //Analytique = inventoryDatas.First().analytique;
            Structure = inventoryDatas.First().structure;
            User = inventoryDatas.First().structure;

            srdrFile.Close();
        }

        private void ClearInventoryData()
        {
            inventoryDatas.RemoveRange(0, inventoryDatas.Count());
        }

        private void LoadInventory_Load(object sender, EventArgs e)
        {
            List<String> files = new List<String>(Directory.GetFiles(@"My Documents\inventway"));
            files.Insert(0, "Nouvelle Inventaire");
            this.inventoySelectBox.DataSource=files;
        }

        private void pBLogin_Click(object sender, EventArgs e)
        {

        }

        private void pBHome_Click(object sender, EventArgs e)
        {

        }

        private void pBHome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pBLogin_Click_1(object sender, EventArgs e)
        {
            if (inventoySelectBox.SelectedItem.ToString() == "Nouvelle Inventaire")
            {
                ClearInventoryData();
                DateTime today = DateTime.Now;
                FileName = "My Documents\\inventway\\" + "INVSTR" + today.ToString("dd-MM-yyyy  HH.mm.ss") + ".csv";
            }
            else
            {
                LoadInventoryData(inventoySelectBox.SelectedItem.ToString());
                FileName = inventoySelectBox.SelectedItem.ToString();
            }
            this.Hide();
        }
    }
}