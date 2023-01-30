using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary.StoredProcs;
using DataReferenceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.FormAssets;
using DataReferenceLibrary.Models;
using UserInterface.Forms;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab3 : UserControl, ICreateTransactionRequester
    {
        private static UC_Tab3 _instance;

        public static UC_Tab3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab3();
                return _instance;
            }
        }



        public UC_Tab3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                List<spQueryAllShareTransactions> output;
                output = db.spQueryAllShareTransactions();

                PrepareTableLayoutPanel(output);
            }
        }

        private void PrepareTableLayoutPanel(List<spQueryAllShareTransactions> output)
        {

            foreach (spQueryAllShareTransactions TransLine in output)
            {

                CustomPanel newCustomPanel = new CustomPanel();
                newCustomPanel.Width = fpnlShareTransactions.Width;
                newCustomPanel.lblTransNum.Text = 0.ToString();
                newCustomPanel.lblTransType.Text = TransLine.Type.ToString();
                newCustomPanel.lblTransCode.Text = TransLine.ASXCode.ToString();
                newCustomPanel.lblTransCostTotal.Text = TransLine.TotalValue.ToString();

                fpnlShareTransactions.Controls.Add(newCustomPanel);
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            // Call the CreateNewTransactionForm
            CreateNewTransactionForm form = new CreateNewTransactionForm(this);
            form.Show();
        }

        public void CreateTransactionComplete(ShareTransactionModel model)
        {
            throw new NotImplementedException();
        }
    }
}