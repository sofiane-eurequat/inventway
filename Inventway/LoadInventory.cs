using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FileHelpers;

namespace Inventway
{
    public partial class LoadInventory : Form
    {
        private List<InventoryData> m_inventoryDatas = new List<InventoryData>();
        private List<InventoryData> m_inventoryDatasletige = new List<InventoryData>();
        private String m_analytique;
        private String m_structure;
        private String m_user;
        private String m_filename = "";
        private String m_FileName_letige = "";
        public LoadInventory()
        {
            InitializeComponent();
        }
        public String FileName
        {
            get { return m_filename; }
            set { m_filename = value; }
        }

        public String FileName_letige
        {
            get { return m_FileName_letige; }
            set { m_FileName_letige = value; }
        }


        public List<InventoryData> inventoryDatas
        {
            get { return m_inventoryDatas; }
            set { m_inventoryDatas = value; }
        }
        public List<InventoryData> inventoryDatasletige
        {
            get { return m_inventoryDatasletige; }
            set { m_inventoryDatasletige = value; }
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

        /*private void validate_Click(object sender, EventArgs e)
        {
            if (inventoySelectBox.SelectedItem.ToString() == "Nouvelle Inventaire")
            {
                ClearInventoryData();
                DateTime today = DateTime.Now;
                FileName = "My Documents\\inventway\\" +"INVSTR" + today.ToString("dd-MM-yyyy-HH.mm.ss") + ".csv";
            }
            else
            {
                LoadInventoryData(inventoySelectBox.SelectedItem.ToString());
                FileName = inventoySelectBox.SelectedItem.ToString();
            }
            this.Hide();
        }*/
        private void LoadInventoryData(String file)
        {
            ClearInventoryData();
            
            DateTime today = DateTime.Now;
            if (!Directory.Exists("My Documents\\inventway\\"+file))
            {
                Directory.CreateDirectory(@"My Documents\inventway\"+file);
            }
            Directory.SetCurrentDirectory(@"My Documents\inventway\"+file);
            if (!File.Exists(@"My Documents\inventway\" + file + "\\" + file + ".csv"))
            {
                File.Create("My Documents\\inventway\\" + file+"\\"+file+".csv").Close();
            }
                        
            var fichier="My Documents\\inventway\\" + file+"\\"+file+".csv";


            if (!File.Exists(@"My Documents\inventway\" + file + "\\" + "letige" + ".csv"))
            {
                File.Create("My Documents\\inventway\\" + file + "\\" + "letige" + ".csv").Close();
            }

            var fileletige = "My Documents\\inventway\\" + file + "\\" + "letige" + ".csv";






            StreamReader srdrFile = new StreamReader(new FileStream(fichier, FileMode.Open));
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
                srdrFile.Close();


            
                StreamReader srdrFileletige = new StreamReader(new FileStream(fileletige, FileMode.Open));
                String inputletige = null;
                while ((inputletige = srdrFileletige.ReadLine()) != null)
                {
                    InventoryData InventoryData = new InventoryData();
                    int next = 0;
                    int current = 0;

                    // InventoryData.analytique = input.Substring(current, (next = input.IndexOf("|", current)) - current);
                    // current = next + 1;

                    InventoryData.structure = inputletige.Substring(current, (next = inputletige.IndexOf(";", current)) - current);
                    current = next + 1;
                    InventoryData.location = inputletige.Substring(current, (next = inputletige.IndexOf(";", current)) - current);
                    current = next + 1;
                    InventoryData.barcode = inputletige.Substring(current, (next = inputletige.IndexOf(";", current)) - current);
                    current = next + 1;

                    InventoryData.state = inputletige.Substring(current, (next = inputletige.IndexOf(";", current)) - current);
                    current = next + 1;
                    InventoryData.agent = inputletige.Substring(current, inputletige.Length - current);
                    //current = next + 1;

                    //InventoryData.type_read = input.Substring(current, (next = input.IndexOf("|", current)) - current);
                    //current = next + 1;
                    //InventoryData.date = DateTime.ParseExact(input.Substring(current, input.Length - current), "dd/MM/yyyy,HH:mm:ss", null);
                    inventoryDatasletige.Add(InventoryData);


                }
                srdrFileletige.Close();
            
            //Analytique = inventoryDatas.First().analytique;
            if (inventoryDatas.Any())
            {
                Structure = inventoryDatas.First().structure;
                User = inventoryDatas.First().structure;
            }

            
        }

        private void ClearInventoryData()
        {
            inventoryDatas.RemoveRange(0, inventoryDatas.Count());
        }

        private void LoadInventory_Load(object sender, EventArgs e)
        {
            List<String> directories = new List<String>(Directory.GetDirectories(@"My Documents\inventway"));
            List<String> files = new List<String>();
            foreach (string file in directories)
            {
                if(file!=@"My Documents\inventway\inventaireBase")
                files.Add(file.Replace(@"My Documents\inventway\",""));
            }
            files.Insert(0, "Nouvelle Inventaire");
            this.inventoySelectBox.DataSource=files;

            List<String> InventaireBase = new List<String>();
            List<String> FileBase = new List<String>(Directory.GetFiles(@"My Documents\inventway\inventaireBase"));
            foreach (string file in FileBase)
            {
                InventaireBase.Add(file.Replace(@"My Documents\inventway\inventaireBase\", ""));
            }

            InventaireBase.Insert(0, "Aucun");

            CBBase.DataSource = InventaireBase;
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
                FileName = "My Documents\\inventway\\" + today.ToString("dd-MM-yyyy-HH-mm-ss")+ "\\"+ today.ToString("dd-MM-yyyy-HH-mm-ss") + ".csv";
                if (!Directory.Exists("My Documents\\inventway\\" + today.ToString("dd-MM-yyyy-HH-mm-ss")))
                {
                    Directory.CreateDirectory(@"My Documents\inventway\" + today.ToString("dd-MM-yyyy-HH-mm-ss"));
                }
                FileName_letige = "My Documents\\inventway\\" + today.ToString("dd-MM-yyyy-HH-mm-ss") + "\\letige.csv";
            }
            else
            {
                LoadInventoryData(inventoySelectBox.SelectedItem.ToString());
                FileName = "My Documents\\inventway\\" + inventoySelectBox.SelectedItem + "\\" + inventoySelectBox.SelectedItem+".csv";
                FileName_letige = "My Documents\\inventway\\" + inventoySelectBox.SelectedItem + "\\letige.csv";
            }



            if (CBBase.SelectedItem.ToString() != "Aucun")
            {
                Cursor.Current = Cursors.WaitCursor;
                var engine = new FileHelperEngine(typeof (DBInventory));
                Program.inventaireRacine =
                    engine.ReadFile(@"My Documents\inventway\inventaireBase\" + CBBase.SelectedItem) as DBInventory[];
                Cursor.Current = Cursors.Default;
            }
            else
            {
                Program.inventaireRacine = null;
            }

            this.Hide();
        }
    }
}