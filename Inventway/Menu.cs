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
    public partial class Menu : Form
    {
        private List<InventoryData> inventoryDatas = new List<InventoryData>();
        private List<InventoryData> inventoryDatasRejete = new List<InventoryData>();
        private String m_analytique ="";
        private String m_structure ="";
        private String m_user = "";
        private String m_FileName ="";
        private String m_FileName_letige = "";
        private bool saved = false;

        private Inventaire inventaire;
        private Show showInventaire;
        private Setup setupForm;
        private LoadInventory loadInventory;
        public Menu()
        {
            InitializeComponent();
        }
        public String FileName
        {
            get { return m_FileName; }
            set { m_FileName = value; }
        }
        public String FileName_letige
        {
            get { return m_FileName_letige; }
            set { m_FileName_letige = value; }
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

        private void Inventaire_Click(object sender, EventArgs e)
        {
            inventory();
            
        }

        private void inventory()
        {
            saved = false;
            if (inventaire == null)
            {
                inventaire = new Inventaire();
                // inventaire.inventoryDatas = inventoryDatas;
            }


            inventaire.inventoryDatas = inventoryDatas;
            inventaire.inventoryDatasRejete = inventoryDatasRejete;


            if (setupForm != null)
            {
                inventaire.Analytique = setupForm.Analytique;
                inventaire.Structure = setupForm.CodeRegion;
                inventaire.User = setupForm.User;
            }
            else
            {
                inventaire.Analytique = loadInventory.Analytique;
                inventaire.Structure = loadInventory.Structure;
                inventaire.User = loadInventory.User;
            }
            inventaire.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!saved)
                ExitDialog();
            else
                Application.Exit();
        }

        private void ExitDialog()
        {

            switch (MessageBox.Show("Vous allez quitter Inventaway.Voulez vous sauvegarder ?", "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                case  DialogResult.Cancel:
                    break;

                case  DialogResult.No: 
                Application.Exit();
                break;

                case    DialogResult.Yes:
                saveToFile();
                Application.Exit();
                break;

                default  :
                break;
            }

         //   exitDialog = new ExitDialog();
         //   exitDialog.inventoryDatas = inventoryDatas;
         //   exitDialog.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            loadInventoryFile();

        }

        private void loadInventoryFile()
        {
            //          if (loadInventory == null)
            //          {
            loadInventory = new LoadInventory();
            //          }
            loadInventory.Analytique = Analytique;
            loadInventory.Structure = Structure;
            loadInventory.User = User;

            loadInventory.inventoryDatas = inventoryDatas;
            loadInventory.inventoryDatasletige = inventoryDatasRejete;
            loadInventory.FileName = FileName;
            loadInventory.FileName_letige = FileName_letige;
            loadInventory.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void saveToFile()
        {
            saved = true;
            DateTime today = DateTime.Today;
            FileName = loadInventory.FileName;
            FileName_letige = loadInventory.FileName_letige;
            String file = today.ToString("dd-MM-yyyy-HH-mm-ss") + ".csv";
            if (!Directory.Exists("My Documents\\inventway"))
            {
                Directory.CreateDirectory(@"My Documents\inventway");
            }
            Directory.SetCurrentDirectory(@"My Documents\inventway");
            if (!File.Exists( FileName))
            {
                File.Create(FileName).Close();
            }

            if (!File.Exists(FileName_letige))
            {
                File.Create(FileName_letige).Close();
            }


            StreamWriter strmWriter = new StreamWriter(new FileStream(FileName, FileMode.Truncate));
            foreach (InventoryData inventoryData in inventoryDatas)
            {
                var info = inventoryData.toString();
                strmWriter.Write(info);
            }
            strmWriter.Close();


            StreamWriter strmWriterLetige = new StreamWriter(new FileStream(FileName_letige, FileMode.Truncate));
            foreach (InventoryData inventoryData in inventoryDatasRejete)
            {
                var info = inventoryData.toString();
                strmWriterLetige.Write(info);
            }
            strmWriterLetige.Close();



            MessageBox.Show("Inventaire sauvegardé !");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            showInventoryData();             
        }

        private void showInventoryData()
        {
            showInventaire = new Show();
            showInventaire.inventoryDatas = inventoryDatas;
            showInventaire.inventaireRejete = inventoryDatasRejete;
            showInventaire.setGrid();
            showInventaire.Show();
        }

        private void setup_Click(object sender, EventArgs e)
        {
            setupInventory();
        }

        private void setupInventory()
        {
            if (setupForm == null)
            {
                setupForm = new Setup();
                setupForm.Analytique = Analytique;
                setupForm.CodeRegion = Structure;
                setupForm.User = User;
            }
            setupForm.inventoryDatas = inventoryDatas;
            setupForm.Show();
        }

  

        private void pBInfoSetting_Click_1(object sender, EventArgs e)
        {
            setupInventory();
        }

        private void pBLogin_Click(object sender, EventArgs e)
        {

        }

        private void pBLogin_Click_1(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void pBQuitter_Click(object sender, EventArgs e)
        {

        }

        private void pBQuitter_Click_1(object sender, EventArgs e)
        {

            if (!saved)
                ExitDialog();
            else
                Application.Exit();
        }

        private void pBNlleCmd_Click(object sender, EventArgs e)
        {

        }

        private void pBUpdate_Click(object sender, EventArgs e)
        {

        }

        private void pBUpdate_Click_1(object sender, EventArgs e)
        {

            saveToFile();
        }

        private void pBNlleCmd_Click_1(object sender, EventArgs e)
        {
            inventory();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadInventoryFile();
        }

        private void pBPrivilege_Click(object sender, EventArgs e)
        {

        }

        private void pBPrivilege_Click_1(object sender, EventArgs e)
        {
            showInventoryData(); 
        }
    }
}