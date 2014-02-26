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
    public partial class Articles : Form
    {
        private List<InventoryData> m_inventoryDatas = new List<InventoryData>();
        private List<InventoryData> m_inventoryDatasRjete = new List<InventoryData>();
        private InventoryData m_inventoryData;
        private string remarque = "";
        private String m_location;
        private String m_analytique = "";
        private String m_structure = "";
        private String m_user = "";
        private API scanAPI = null;
        private EventHandler myReadNotifyHandler = null;
        public Articles()
        {
            InitializeComponent();
        }
        public List<InventoryData> inventoryDatas
        {
            get{return m_inventoryDatas ;}
            set{m_inventoryDatas = value;}
        }
        public List<InventoryData> inventoryDatasRejete
        {
            get { return m_inventoryDatasRjete; }
            set { m_inventoryDatasRjete = value; }
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
        public String location
        {
            get { return m_location; }
            set { m_location = value; }
        }
        public InventoryData inventoryData
        {
            get { return m_inventoryData; }
            set { m_inventoryData = value; }
        }

        private void articles_Load(object sender, EventArgs e)
        {
            scanAPI = new API();
            scanAPI.InitReader();
            scanAPI.StartRead(false);
            this.myReadNotifyHandler = new EventHandler(myReader_ReadNotify);
            scanAPI.AttachReadNotify(myReadNotifyHandler);
            List<String> states = new List<String>();
            this.articleBox.Focus();
            states.Add("Bon");
            states.Add("Mauvais");
            this.stateBox.DataSource = states;
        }

        private void back_Click(object sender, EventArgs e)
        {
           // ScanAPI.TermReader();
            scanAPI.StopRead();
            initAll();
            this.Close();
            this.articleBox.Focus();
        }

       /* private void next_Click(object sender, EventArgs e)
        {
            appendInventoryData();
            initAll();
            this.articleBox.Focus();    
        }*/
        private bool articleAlreadyExist(InventoryData inventoryData) {
            return ((this.scannedData.Text == inventoryData.barcode) || (this.articleBox.Text ==inventoryData.barcode ) );
        }
        private bool articleEmpty()
        {
            return ((this.scannedData.Text == "") && (this.articleBox.Text == ""));
        }

        private void appendInventoryData(bool rejete)
        {
            inventoryData = new InventoryData();
 
                if (inventoryDatas.Exists(articleAlreadyExist))
                {
                    MessageBox.Show("l'article a déjà été saisie", "Erreur");
                }
                else if (articleEmpty())
                {
                    MessageBox.Show("veuillez saisir un article", "Erreur");
                }
                else
                {
                    if (this.scannedData.Text != "")
                    { 
                        inventoryData.barcode = this.scannedData.Text;
                        //inventoryData.type_read = "S";
                    }

                    else
                    {
                        inventoryData.barcode = this.articleBox.Text;
                        //inventoryData.type_read = "C";
                    }
                    //inventoryData.date = DateTime.Now;
                    inventoryData.location = location;
                    inventoryData.state = this.stateBox.SelectedItem.ToString();
                    //inventoryData.analytique = Analytique;
                    inventoryData.structure = Structure;
                    inventoryData.agent = User;
                    inventoryData.Remarque = remarque;
                    if (rejete) inventoryDatasRejete.Add(inventoryData);
                    else inventoryDatas.Add(inventoryData);
                }
        }

        private void initAll()
        {
            this.articleBox.Text = "";
            this.scannedData.Text = "";
            this.articleBox.Focus();
        }


        private void articleBox_Key(object sender, EventArgs e)
        {
        }
        private void myReader_ReadNotify(object Sender, EventArgs e)
        {
            // Get ReaderData
            Symbol.Barcode.ReaderData TheReaderData = scanAPI.Reader.GetNextReaderData();

            switch (TheReaderData.Result)
            {
                case Symbol.Results.SUCCESS:

                    // Handle the data from this read & submit the next read.

                        this.scannedData.Text=TheReaderData.Text;
                        scanAPI.StartRead(false);
                        this.stateBox.Focus();
                    break;

                case Symbol.Results.E_SCN_READTIMEOUT:


                    scanAPI.StartRead(false);
                    break;

                case Symbol.Results.CANCELED:

                    break;

                case Symbol.Results.E_SCN_DEVICEFAILURE:

                    scanAPI.StopRead();
                    scanAPI.StartRead(false);
                    break;

                default:

                    string sMsg = "Read Failed\n"
                        + "Result = "
                        + (TheReaderData.Result).ToString();

                    if (TheReaderData.Result == Symbol.Results.E_SCN_READINCOMPATIBLE)
                    {
                        // If the failure is E_SCN_READINCOMPATIBLE, exit the application.
                        MessageBox.Show("AppExitMsg", "Failure");

                        this.Close();
                        return;
                    }

                    break;
            }
        }

        private void pBLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void pBHome_Click_1(object sender, EventArgs e)
        {

        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            // ScanAPI.TermReader();
            scanAPI.StopRead();
            initAll();
            this.Close();
            this.articleBox.Focus();
        }

        private void pBLogin_Click(object sender, EventArgs e)
        {

            string id = "";
            this.Hide();

            if (scannedData.Text!=null && scannedData.Text != "") id = scannedData.Text;
            else
            {
                if (articleBox.Text!=null && articleBox.Text != "") id = articleBox.Text;
            }

            var articleDetail = new ArticleDetail(id);
            

            articleDetail.ShowDialog();


            var status = new Statut();
            status.ShowDialog();
            var rejete = status.rejete;

            var articleRemarque = new RemarquSuppelementaire();
            articleRemarque.ShowDialog();
            remarque = articleRemarque.getRemarque();
            

            appendInventoryData(rejete);

            this.Show();
            initAll();
            this.articleBox.Focus(); 
        }

        private void Articles_Closing(object sender, CancelEventArgs e)
        {

        }
    }
}