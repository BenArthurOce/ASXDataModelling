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
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using System.Windows.Documents;
using System.Windows.Media.Media3D;

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


        public UC_Tab5()
        {
            InitializeComponent();
        }

        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            // Run the File Dialogue and return the files
            OpenFileDialog openFileDialogResults = SelectNotepadFiles();

            if (openFileDialogResults == null)
            {
                return;
            }
            else
            {
                //Check if the File/Row already exists in the DGV
                foreach (string filename in openFileDialogResults.FileNames)
                {
                    bool isExist = DoesRecordAlreadyExistInDGV(filename);
                    if (isExist == true) 
                    { 
                        continue; 
                    }
                    // If it doesnt already exist, add it.
                    if (isExist == false)
                    {
                        OpenFileDialogIntoDGVQueued(filename);
                    }
                }
            }
            btnSubmitFiles.Visible = true;
        }


        private OpenFileDialog SelectNotepadFiles()
        {
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1;
            }
            else
            {
                return null;
            }
        }

        private bool DoesRecordAlreadyExistInDGV(string DocumentFileName)
        {
            return dgvDocumentsQueued.Rows.Cast<DataGridViewRow>()
                                         .Any(row => row.Cells[0].Value.ToString() == DocumentFileName);
        }

        private void OpenFileDialogIntoDGVQueued(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);

            //Read Number of Lines in File
            string[] lines = File.ReadAllLines(filename);

            // Create New Model
            DocumentUploadHistoryModel OneDocument = new DocumentUploadHistoryModel(
                  fileInfo.FullName         //FilePath
                , fileInfo.Name.ToLower()   //FileName
                , DateTime.Now              //DateTimeUploaded
                , fileInfo.Length           //FileSizeBytes
                , lines.Length              //RowsInFile
                );

            // Add to DataGridView
            dgvDocumentsQueued.Rows.Add(OneDocument.FilePath, OneDocument.FileName, OneDocument.DateTimeUploaded, OneDocument.FileSizeBytes, OneDocument.RowsInFile);
        }


        private void btnSubmitFiles_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            for (int i = dgvDocumentsQueued.Rows.Count - 1; i >= 0; i--)
            {
                
                // Create a Datatable from the notepad
                string filePath = dgvDocumentsQueued.Rows[i].Cells[0].Value.ToString();
                dt = CreateDataTableFromNotePad(filePath);

                // Create a Model from the notepad information
                DocumentUploadHistoryModel model = new DocumentUploadHistoryModel(
                      dgvDocumentsQueued.Rows[i].Cells[0].Value.ToString() //FilePath
                    , dgvDocumentsQueued.Rows[i].Cells[1].Value.ToString() //FileName
                    , DateTime.Now                                          //DateTimeUploaded
                    , (long)dgvDocumentsQueued.Rows[i].Cells[3].Value      //FileSizeBytes
                    , (long)dgvDocumentsQueued.Rows[i].Cells[4].Value      //RowsInFile
                    );

                // Attempt to Import the text file
                ImportASingleTextFile(dt, model);

                // Get Index Of DGV Queued
                int index = GetRowIndexOfDGV(model.FilePath);

                //If success, remove old row and place into new row
                //If fail, highlight the relevant index in red
                // TODO - Need error validation

                //Remove old Row
                dgvDocumentsQueued.Rows.RemoveAt(index);

                //Place into new row
                dgvDocumentsImported.Rows.Add(model.FilePath, model.FileName, model.DateTimeUploaded, model.FileSizeBytes, model.RowsInFile);
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


        private int GetRowIndexOfDGV(string LookupValue)
        {
            int rowIndex = -1;

            DataGridViewRow row = dgvDocumentsQueued.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["FilePath"].Value.ToString().Equals(LookupValue))
                .First();

            rowIndex = row.Index;
            return rowIndex;
        }


        private void ImportASingleTextFile(DataTable dt, DocumentUploadHistoryModel model)
        {
            GlobalConfig.Connection.spINSERTDATA_ASXEODPrice(dt);
            GlobalConfig.Connection.spINSERTDATA_DocumentUploadRecord(model);
        }




    }  
}