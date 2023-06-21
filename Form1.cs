using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace BREWPLS_POS_SYSTEM
{
    public partial class frmLogin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection db = new DBConnection();
        SqlDataReader dr;

        public string _pass, _username = "";
        public frmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(db.MyConnection());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private bool IsPasswordValid(string password)
        {
            // Perform password validation here
            // For example, you can enforce the following criteria:
            // - Minimum length
            // - Presence of at least one uppercase letter
            // - Presence of at least one lowercase letter
            // - Presence of at least one digit

            if (password.Length < 8)
            {
                MessageBox.Show("Password should be at least 8 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password should contain at least one digit.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _role = "", _name = "";

            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM Users1 WHERE username = @username AND password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    found = true;
                    _name = dr["name"].ToString();
                    _username = dr["username"].ToString();
                    _pass = dr["password"].ToString();
                    _role = dr["role"].ToString();
                }
                else
                {
                    found = false;
                }

                dr.Close();
                cn.Close();

                if (found == true)
                {
                    if (_role == "Cashier")
                    {
                        MessageBox.Show("     Access Granted!" + "\nWelcome " + _name + "😀", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        this.Hide();
                        
                        frmHome frm = new frmHome();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + "!" + " Access GRANTED", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        this.Hide();
                        // Should be frmHome/frmDashboard
                        frmHome frm = new frmHome();
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password! ACCESS DENIED", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            Application.Exit(); // Exit the application
        }
    }
}




