﻿using DataReferenceLibrary.DataAccess;
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
using System.Globalization;

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
                /*
                CustomRowPanelData customrow = new CustomRowPanelData();
                customrow.Column1Text = DateTime.ParseExact(TransLine.Date.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString();
                customrow.Column2Text = TransLine.Type.ToString();
                customrow.Column3Text = TransLine.ASXCode.ToString();
                customrow.Column4Text = TransLine.Quantity.ToString();
                customrow.Column5Text = TransLine.Quantity.ToString();
                customrow.Column6Text = TransLine.UnitPrice.ToString();
                customrow.Column7Text = TransLine.TotalValue.ToString();

                customrow.DistanceBetweenLabels = 130;
                fpnlShareTransactions.Controls.Add(customrow);
                */

                
                CustomPanel newCustomPanel = new CustomPanel();
                //newCustomPanel.TransNumber.Text = 0.ToString();
                newCustomPanel.lblTransDate.Text = DateTime.ParseExact(TransLine.Date.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString();
                newCustomPanel.lblTransType.Text = TransLine.Type.ToString();
                newCustomPanel.lblTransShareCode.Text = TransLine.ASXCode.ToString();
                newCustomPanel.lblTransQuantity.Text = TransLine.Quantity.ToString();
                newCustomPanel.lblTransUnitPrice.Text = TransLine.UnitPrice.ToString();
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