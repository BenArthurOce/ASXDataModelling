using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class CreateNewTransactionForm : Form
    {

        ICreateTransactionRequester callingForm;

        public CreateNewTransactionForm(ICreateTransactionRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }


        private bool ValidateForm()
        {
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                //callingForm.CreateTransactionComplete(model);
            }
        }
    }





}



/*
namespace UserInterface
{
    public partial class CreateNewTransactionForm : Form
    {
        public CreateNewTransactionForm(UserControlsTab.UC_Tab3 uC_Tab3)
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            ShareTransactionTypeModel model = new ShareTransactionTypeModel();
            //model.Id = new Guid();
            model.Id = Guid.NewGuid();
            model.Type = tbox_TransType.Text;
            model.IsDeleted = false;


            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.CreateTransactionType(model);
            }
        }

        private bool ValidateForm()
        {
            // TODO - Add More to validate form
            bool output = true;
            return output;
        }

    }
}
*/