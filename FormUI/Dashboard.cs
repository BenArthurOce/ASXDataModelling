using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {

        List<ASXPriceModel> ASXDataList = new List<ASXPriceModel>();



        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            lstbox_ASXDataFound.DataSource = ASXDataList;
            lstbox_ASXDataFound.DisplayMember = "FullInfo";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            ASXDataList = db.GetASXPriceData(tbox_ASXInput.Text);

            UpdateBinding();
        }
    }
}
