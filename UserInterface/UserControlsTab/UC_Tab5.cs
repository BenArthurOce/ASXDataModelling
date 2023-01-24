using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary;
using DataReferenceLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab5 : UserControl
    {
        private static UC_Tab5 _instance;

        public static UC_Tab5 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab5();
                return _instance;
            }
        }

        private List<DocumentUploadHistoryModel> ListDocumentModelsToAdd = new List<DocumentUploadHistoryModel>();



        public UC_Tab5()
        {
            InitializeComponent();
        }


        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            PopulateDataTable();
        }




        private void PopulateDataTable()
        {
            List<DocumentUploadHistoryModel> ListDocumentModelsToAdd2 = new List<DocumentUploadHistoryModel>();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\vboxuser\Desktop\ASXHistoricalPrices",
                Title = "Browse Text Files",
                Multiselect = true,

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            // Create a Model for each file created and store in list
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog1.FileNames;
                foreach (string fileName in fileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    DocumentUploadHistoryModel OneDocument = new DocumentUploadHistoryModel();

                    // Document Properties
                    OneDocument.FilePath = fileInfo.FullName;
                    OneDocument.FileName = fileInfo.FullName;
                    OneDocument.DateTimeUploaded = DateTime.Now;
                    OneDocument.FileSizeBytes = fileInfo.Length;

                    // Number of Rows in File
                    string[] lines = File.ReadAllLines(fileName);
                    OneDocument.RowsInFile = lines.Length;

                    // Add to list
                    ListDocumentModelsToAdd.Add(OneDocument);
                }

                // Put each model into the dt row
                foreach (DocumentUploadHistoryModel SingleDocument in ListDocumentModelsToAdd)
                {
                    dgvDocumentsQueued.Rows.Add(SingleDocument.FilePath, SingleDocument.FileName, SingleDocument.DateTimeUploaded, SingleDocument.FileSizeBytes, SingleDocument.RowsInFile);
                }
            }
        }


        private DataTable CreateDataTableFromNotePad(string filePath)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[7]
            {
                new DataColumn("ASXCode", typeof(string)),
                new DataColumn("ASXDate",typeof(int)),
                new DataColumn("PriceOpen",typeof(decimal)),
                new DataColumn("PriceHigh",typeof(decimal)),
                new DataColumn("PriceLow",typeof(decimal)),
                new DataColumn("PriceClose",typeof(decimal)),
                new DataColumn("VolumeTraded",typeof(int)),
            });

            // read through each line
            foreach (string textLine in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrEmpty(textLine) || textLine.Contains("Date")) { continue; }
                //MessageBox.Show(row.ToString());
                else
                {
                    dt.Rows.Add();
                    int i = 0;
                    foreach (string cell in textLine.Split(','))
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell;
                        i++;
                    }
                }
            }
            return dt;
        }

        private void btnSubmitFiles_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDocumentsQueued.Rows)
            {
                string filePath = row.Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                dt = CreateDataTableFromNotePad(filePath);
                ImportASingleTextFile(dt);
                //AddEntryToDocumentTable();
            }
        }


        private void ImportASingleTextFile(DataTable dt)
        {
            foreach (IDataConnection db in GlobalConfig.Connections)
                db.spINSERT_NotepadFile(dt);
        }


        private void AddEntryToDocumentTable()
        {

            DataTable dt = new DataTable();
            dt = (DataTable)dgvDocumentsQueued.DataSource;

            string connectionString = "Data Source = BENSQLTRAININGM;Initial Catalog=BENASXDATABASE;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                {
                    //Set the database table name
                    sqlBulkCopy.DestinationTableName = "[dbo].[DocumentUploadHistory]";
                    // sqlBulkCopy.DestinationTableName = "[dbo].[ASXSharePrices3]";
                    con.Open();
                    sqlBulkCopy.WriteToServer(dt);
                    con.Close();
                }
            }
        }





    }  
}