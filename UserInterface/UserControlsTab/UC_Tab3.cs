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

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab3 : UserControl
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
                TableCellPanel myControl = new TableCellPanel();
                myControl.Width = fpnlShareTransactions.Width;

                myControl.lblFooterTransactionNum.Text = 0.ToString();
                myControl.lblFooterASXCode.Text = TransLine.ASXCode.ToString();
                myControl.lblFooterTransactionType.Text = TransLine.Type.ToString();
                myControl.lblFooterTransactionTotal.Text = TransLine.TotalValue.ToString();


                fpnlShareTransactions.Controls.Add(myControl);
            }
        }


    }
}