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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        public Panel PanelCustomer1
        {
            get { return panelCustomer1; }
        }


        public void SetCustomerVisible(bool visible)
        {
            PanelCustomer1.Visible = visible;

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
