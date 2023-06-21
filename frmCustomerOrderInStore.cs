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
    public partial class frmCustomerOrderInStore : Form
    {
        private frmHome homeForm;

        public frmCustomerOrderInStore()
        {
            InitializeComponent();
            homeForm = new frmHome();

        }

        public Panel PanelCO1
        {
            get { return panelCO1; }
        }


        private void frmCustomerOrderInStore_Load(object sender, EventArgs e)
        {

        }



        private void btnCOContinue_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCO1Cancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
