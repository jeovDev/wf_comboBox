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
    public partial class item2form : Form
    {
        public item2form()
        {
            InitializeComponent();
            item1();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

            comboBox item2 = new comboBox();
            item2.item2 = text_item2.Text;
            item2.item1cmb = cmd_item1;
            item2.addItem2();



            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        void item1()
        {

            comboBox load1 = new comboBox();
            load1.item1cmb = cmd_item1;
            load1.loaditem1();

        }

        private void item2form_Load(object sender, EventArgs e)
        {

        }
    }
}
