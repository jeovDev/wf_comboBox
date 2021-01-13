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
    public partial class item1Form : Form
    {
        public item1Form()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            comboBox save = new comboBox();
            save.item1 = text_item1.Text;
            save.addItem();


            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void item1Form_Load(object sender, EventArgs e)
        {

        }
    }
}
