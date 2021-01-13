using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Working_with_ComboBox
{
    class Utilities
    {
        public static MySqlConnection connect() {

            MySqlConnection conn = new MySqlConnection();
            String strConn = "server=localhost;";
            strConn += "user=root;";
            strConn += "database=comboboxDB;";
            strConn += "sslmode=none;";

            conn.ConnectionString = strConn;
            conn.Open();

            return conn;
        
        }
    }
}
