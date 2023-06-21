using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BREWPLS_POS_SYSTEM
{
    public partial class frmCustomerOrder : Form
    {

        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        public Panel PanelCustomerOrder1
        {
            get { return panelCustomerOrder1; }
        }


        private void frmCustomerOrder_Load(object sender, EventArgs e)
        {

        }


        private void picOrderOptionClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the frmCustomerOrder form 

        }


        private void btnCustomerOrderOption1_Click_1(object sender, EventArgs e)
        {
            frmCustomerOrderInStore customerOrderInStoreForm = new frmCustomerOrderInStore();
            customerOrderInStoreForm.ShowDialog();
            this.Hide(); // Hide the frmCustomerOrder form
        }

        private void btnCustomerOrderOption2_Click(object sender, EventArgs e)
        {
            frmCustomerOrderOnline customerOrderOnlineForm = new frmCustomerOrderOnline();
            customerOrderOnlineForm.ShowDialog();
            this.Hide(); // Hide the frmCustomerOrder form
        }
    }

}




