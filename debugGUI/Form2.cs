using Microsoft.VisualBasic.Logging;
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

namespace debugGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
       
        private void CloseApp(object sender, EventArgs e)
        {
            // when click on button X on the sign in page, a messagebox will pop-up to ask for confirmation
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit this application","Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginUser(object sender, EventArgs e)
        {
            // compare input with DB and call Form1 (dashbord) as a class
            String username, password;
            username = usernameBox.Text;
            password = passwordBox.Text;

            try
            {
                conn.Open();
                String querry = "SELECT * FROM users WHERE name = '"+usernameBox.Text+"' AND password = '"+passwordBox.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
              
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    //username = usernameBox.Text;
                    //password = passwordBox.Text;

                    Form Dashboard = new Form1();
                    Dashboard.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Signin Error", "Invalid credentials");
                    usernameBox.Clear();
                    passwordBox.Clear();

                    usernameBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
