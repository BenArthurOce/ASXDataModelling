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

namespace UserInterface.Forms
{
    public partial class TransactionFilterForm : Form
    {
        public TransactionFilterForm()
        {
            InitializeComponent();
        }

        private void btnFilterAddType_Click(object sender, EventArgs e)
        {
            FilterPanel newFilterPanel = new FilterPanel("AddedType", "AddedType");
            fpnlCurrentFilters.Controls.Add(newFilterPanel);
        }

        private void btnFilterAddCode_Click(object sender, EventArgs e)
        {
            FilterPanel newFilterPanel = new FilterPanel("AddedCode", "AddedCode");
            fpnlCurrentFilters.Controls.Add(newFilterPanel);
        }

        private void btnFilterAddSector_Click(object sender, EventArgs e)
        {
            FilterPanel newFilterPanel = new FilterPanel("AddedSector", "AddedSector");
            fpnlCurrentFilters.Controls.Add(newFilterPanel);
        }

        private void btnFilterAddDate_Click(object sender, EventArgs e)
        {
            FilterPanel newFilterPanel = new FilterPanel("AddedDate", "AddedDate");
            fpnlCurrentFilters.Controls.Add(newFilterPanel);
        }

        private void btnFilterAddAmount_Click(object sender, EventArgs e)
        {
            FilterPanel newFilterPanel = new FilterPanel("AddedAmount", "AddedAmount");
            fpnlCurrentFilters.Controls.Add(newFilterPanel);
        }
    }
}
