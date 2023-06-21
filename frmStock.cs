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
    public partial class frmStock : Form
    {
        public Panel panelCategoryContainer;
        public frmStock()
        {
            InitializeComponent();
            dataGridViewStock1.Dock = DockStyle.None;
            dataGridViewStock2.Dock = DockStyle.None;
        }


        private void frmStock_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewStock1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
