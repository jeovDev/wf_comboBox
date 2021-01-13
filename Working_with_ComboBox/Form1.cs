using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_with_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            item1();


           
        }

        private void additem1_Click(object sender, EventArgs e)
        {
            item1Form item1 = new item1Form();
            item1.Show();
            this.Hide();
        }

        private void additem2_Click(object sender, EventArgs e)
        {
            item2form item2 = new item2form();
            item2.Show();
            this.Hide();
        }
        void item1() {

            comboBox load1 = new comboBox();
            load1.item1cmb = item1_combo;
            load1.loaditem1();

        }

    

        private void item1_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox load1 = new comboBox();
            load1.ID = item1_combo.SelectedValue.ToString();
            load1.item2cmb = item2_item;         
            load1.loaditem2();


        
        }
    }
}
