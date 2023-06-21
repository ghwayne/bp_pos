// frmHome
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BREWPLS_POS_SYSTEM
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            // Create an instance of the ToolTip control
            ToolTip tooltip = new ToolTip();

            // Set the tooltip text for the button
            tooltip.SetToolTip(btnLogout, "Logout");
            tooltip.SetToolTip(btnHome, "Home");
            tooltip.SetToolTip(btnDashboard, "Dashboard");
            tooltip.SetToolTip(btnCategory, "Manage Category");
            tooltip.SetToolTip(btnProduct, "Manage Product");
            tooltip.SetToolTip(btnStaff, "Manage Staff");
            tooltip.SetToolTip(btnStock, "Manage Stock");
            tooltip.SetToolTip(btnCustomer, "Manage Customer");
            tooltip.SetToolTip(btnPOS, "POS");
            tooltip.SetToolTip(btnDelivery, "Delivery");
            tooltip.SetToolTip(btnReport, "Reports");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Close();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

            frmDashboard frm = new frmDashboard();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            frm.Show();



            /*panelCategoryContainer.Visible = false;
            panelStockContainer.Visible = false;
            panelPOSContainer.Visible = false;
            panelStaffContainer.Visible = false;
            panelProductContainer.Visible = false;
            panelCustomerContainer.Visible = false;
            panelDeliveryContainer.Visible = false;
            panelReportsContainer.Visible = false;

            if (dashboardForm == null)
            {
                dashboardForm = new frmDashboard();
                dashboardForm.TopLevel = false;
                dashboardForm.FormBorderStyle = FormBorderStyle.None;
                dashboardForm.Dock = DockStyle.Fill;

                panelDashboardContainer.Controls.Add(dashboardForm.PanelDashboard1);
                panelDashboardContainer.Controls.Add(dashboardForm.PanelDashboard2);
            }

            dashboardForm.SetDashboardVisible(true);
            panelDashboardContainer.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            btnHomeOrderNow.Visible = false;

            dashboardForm.BringToFront();*/
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            // Create an instance of frmCategory
            frmCategory frm = new frmCategory();

            // Set the necessary properties
            frm.TopLevel = false;
            

            // Hide the controls in panelHome
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            // Set the parent of frmCategory as panelHome and show it
            panelHome.Controls.Add(frm);
            frm.Show();



        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            frm.Show();
            
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            frm.Show();
           
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            frm.Show();
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            frm.Show();
        
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            frmDelivery frm = new frmDelivery();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            frm.Show();
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            lblHome1.Hide();
            lblHome2.Hide();
            btnHome1.Hide();

            frm.Show();
           
        }

        private void btnHomeOrderNow_Click(object sender, EventArgs e)
        {
            frmCustomerOrder customerOrderForm = new frmCustomerOrder();
            customerOrderForm.ShowDialog();

            // The code below will execute once the frmCustomerOrder form is closed

            // Show the frmHome form again
            frmHome frm = new frmHome();
            frm.Show();

        }

    }
}





