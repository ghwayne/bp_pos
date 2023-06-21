using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREWPLS_POS_SYSTEM
{
    internal class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-URDDVLJ\SQLEXPRESS01;Initial Catalog=DB_BREW_PLS_POS;Integrated Security=True";
            return con;
        }
    }
}
