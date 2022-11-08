using hrtool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugGUI
{
    public partial class FormEmployee : Form
    {
        // change "koppeling" to desired address
        private HrKoppeling hrKoppeling = new HrKoppeling("http://localhost:8008");
        // change connection string to match yours
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
        SqlDataReader myreader;

        public FormEmployee()
        {
            InitializeComponent();
            FillHREmployeeDatatable();
            FillRaycoEmployeeDatatable();
        }

        private void FillHREmployeeDatatable()
        {
            var dt = new DataTable();
            var colId = new DataColumn("id");
            var colNaam = new DataColumn("naam");
            dt.Columns.Add(colId);
            dt.Columns.Add(colNaam);

            foreach (var (id, naam) in hrKoppeling.WerknemerIndex())
            {
                var werknemer = new Werknemer(int.Parse(id), naam);
                var row = dt.NewRow();
                row["id"] = werknemer.Id;
                row["naam"] = werknemer.Naam;
                dt.Rows.Add(row);
            }

            EmployeeHRDataTable.DataSource = dt;
            EmployeeHRDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeHRDataTable.Columns[1].FillWeight = 400;
            conn.Close();
        }

        private void FillHRBeschikbaarDatatable(int selectId, string selectName)
        {

            // HR_beschikbaarheid_FT
            var dt = new DataTable();
            var colId = new DataColumn("Beschikbaarheid p/dag");
            var colNaam = new DataColumn("Naam");
            dt.Columns.Add(colId);
            dt.Columns.Add(colNaam);

            // get werknemerId on click from row 0 in EmployeeHRDataTable
            int werknemerId = selectId;
            // jaar and weeknr wordt niet gebruikt in de code
            foreach (int id in hrKoppeling.Beschikbaarheid(werknemerId, 2022, 20))
            {
                // TODO: dont think we need Werknemer class for this???
                var werknemer = new Werknemer(id, selectName);
                var row = dt.NewRow();
                row["Naam"] = werknemer.Naam;
                row["Beschikbaarheid p/dag"] = werknemer.Id + "Hours";
                dt.Rows.Add(row);
            }

            HR_beschikbaarheid_FT.DataSource = dt;
            HR_beschikbaarheid_FT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HR_beschikbaarheid_FT.Columns[1].FillWeight = 150;
            conn.Close();
        }

        private void FillRaycoEmployeeDatatable()
        {
            conn.Open();
            String querry = "SELECT id, name, admin FROM users";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeRaycoTable.DataSource = dt;
            EmployeeRaycoTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeRaycoTable.Columns[1].FillWeight = 300;

            conn.Close();
        }

        private void SelectHREmployee(object sender, DataGridViewCellEventArgs e)
        {
            // checking of rowindex does not equel negative number (these are the headers)
            // this solves error of index for filling in the edit fields
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(EmployeeHRDataTable.Rows[e.RowIndex].Cells[0].Value);
                string name = Convert.ToString(EmployeeHRDataTable.Rows[e.RowIndex].Cells[1].Value);
                Console.WriteLine($"Id and Name from HR table: {id} + {name}");
                FillHRBeschikbaarDatatable(id,name);
            }
        }
        private void SelectRaycoEmployee(object sender, DataGridViewCellEventArgs e)
        {
            // checking of rowindex does not equel negative number (these are the headers)
            // this solves error of index for filling in the edit fields
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(EmployeeRaycoTable.Rows[e.RowIndex].Cells[0].Value);
                //string name = Convert.ToString(EmployeeHRDataTable.Rows[e.RowIndex].Cells[1].Value);
                Console.WriteLine($"Id and Name from Rayco users table: {id}");
                FillEditPanel(id);
            }
        }
        private void FillEditPanel(int id)
        {
            //problem with keeping open the connection (and re-opening) 
            SqlConnection conn2 = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
            conn2.Open();
            Employee_ID.Text = "";
            NameActual.Text = "";
            PasswordActual.Text = "";
            NewEmployeeAdminActual.Checked = false;
            try
            {
                using (conn2)
                {
                    // to get project name using task ID
                    //SqlCommand command_project = new SqlCommand("SELECT * FROM tasks WHERE id = '" + id + "'", conn2);
                    //SqlDataReader reader_project = command_project.ExecuteReader();

                    // getting the data form the selected task in the top datagridview
                    SqlCommand command = new SqlCommand("SELECT * FROM users WHERE id = '" + id + "'", conn2);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Employee_ID.Text = reader[0].ToString();
                            NameActual.Text = (string)reader[1];
                            PasswordActual.Text = (string)reader[2];
                            if (Convert.ToString(reader[3]) == "1")
                            {
                                AdminActual.Checked = true;
                            } else
                            {
                                AdminActual.Checked = false;
                            }
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                }
                conn2.Close();
            }
            catch (Exception e)
            {

                Console.Write($"{e}");
            }

        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string naam = NewEmployeeNameActual.Text;
                string? pass = NewEmployeePasswordActual.Text; ;
                bool a = NewEmployeeAdminActual.Checked;
                int admin;
                if (a == true)
                {
                    admin = 1;
                } else
                {
                    admin = 0;
                }

                var insertCommand = new SqlCommand($"INSERT INTO users (name,password,admin) VALUES (  '{naam}','{pass}','{admin}')", conn);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show($"New Employee {naam} created Successfully");
                conn.Close();
                FillRaycoEmployeeDatatable();

                naam = "";
                pass = "";
                a = false;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(Employee_ID.Text);
            string name = NameActual.Text;
            DialogResult d;
            d = MessageBox.Show($"Are you sure you want to delete this User:'{name}'", $"Delete User With ID:'{id}'", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (d == DialogResult.Yes)
            {
                try
                {
                    SqlCommand command = new SqlCommand("DELETE FROM users WHERE id = '" + id + "'", conn);
                    conn.Open();
                    myreader = command.ExecuteReader();
                    MessageBox.Show($"successfully deleted User:{name} from database.", "User deleted");
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                    FillRaycoEmployeeDatatable();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");

            try
            {
                conn2.Open();

                int id = Convert.ToInt32(Employee_ID.Text);
                string naam = NameActual.Text;
                string password = PasswordActual.Text;
                bool a = AdminActual.Checked;
                int admin;
                if (a == true)
                {
                    admin = 1;
                }
                else
                {
                    admin = 0;
                }


                SqlCommand command = new SqlCommand($"UPDATE users SET name=@naam, password = @password, admin = @admin WHERE id = {id}", conn2);

                command.Parameters.AddWithValue("@naam", naam);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@admin", admin);

                command.ExecuteNonQuery();
                MessageBox.Show($"User:{naam} Updated Successfully");
                conn.Close();

                FillRaycoEmployeeDatatable();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
