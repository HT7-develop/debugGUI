using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseApp(object sender, EventArgs e)
        {
            // when click on button X on the sign in page, a messagebox will pop-up to ask for confirmation
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit this application","Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoginUser(object sender, EventArgs e)
        {
            // compare input with DB and call Form1 (dashbord) as a class
        }
    }
}
