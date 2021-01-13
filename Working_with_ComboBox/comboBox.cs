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
    class comboBox
    {
        public string item1 { get; set; }
        public string item2 { get; set; }
        
        public string ID { get; set; }
        public ComboBox item1cmb { get; set; }
        public ComboBox item2cmb { get; set; }

        public void addItem() {

            MySqlConnection conn = Utilities.connect();
            if (conn.State == System.Data.ConnectionState.Closed) return;

            String sql = "INSERT INTO item1_tbl(item1)VALUES(?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("item1",this.item1);
            cmd.ExecuteNonQuery();
            MessageBox.Show(item1 +  " successfully added!");
            cmd.Dispose();
            conn.Close();
        
        }

        public void addItem2()
        {

            MySqlConnection conn = Utilities.connect();
            if (conn.State == System.Data.ConnectionState.Closed) return;

            String sql = "INSERT INTO item2_tbl(item1_id, item2)VALUES(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("item1_id", this.item1cmb.SelectedValue);
            cmd.Parameters.AddWithValue("item2", this.item2);
            cmd.ExecuteNonQuery();
            MessageBox.Show(item2 + " successfully added!");
            cmd.Dispose();
            conn.Close();

        }

        public void loaditem1() {

            MySqlConnection conn = Utilities.connect();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            try
            {
                DataSet ds = new DataSet();
                String sql = "SELECT * FROM item1_tbl";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
               
                da.Fill(ds);
                da.Dispose();
                cmd.Dispose();
                conn.Close();

                this.item1cmb.DataSource = ds.Tables[0];
                this.item1cmb.ValueMember = "id";
                this.item1cmb.DisplayMember = "item1";
                this.item1cmb.SelectedItem = -1;
            }
            catch (Exception) { }
           
        }

        public void loaditem2()
        {

            MySqlConnection conn = Utilities.connect();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            try
            {
                DataSet ds = new DataSet();
                String sql = "SELECT * FROM item2_tbl WHERE item1_id = ?";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("item1_id", this.ID);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(ds);
                da.Dispose();
                cmd.Dispose();
                conn.Close();

                this.item2cmb.DataSource = ds.Tables[0];
                this.item2cmb.ValueMember = "id";
                this.item2cmb.DisplayMember = "item2";
                this.item2cmb.SelectedItem = -1;
            }
            catch (Exception) { }

        }

    }
}
