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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace debugGUI
{
    public partial class FormProjects : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
        public FormProjects()
        {
            InitializeComponent();
            FillProjectsDatatable();
        }

        private void FillProjectsDatatable()
        {
            String querry = "SELECT * FROM projects";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ProjectsDatatable.DataSource = dt;
            ProjectsDatatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void NewProject(object sender, EventArgs e)
        {
            // all vars defined here
            //int Id = id;
            //string Beschrijving = beschrijving;
            //string Naam = naam;
            //new ProjectSoort(Id,Beschrijving,Naam);
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            // get id from selection datatable -> ProjectsDatatable and Delete project from the DB
        }

        private void EditProject(int id)
        {
            conn.Open();
            NameActual.Text = "";
            DescriptionText.Text = "";
                using (conn)
                {
                    SqlCommand command = new SqlCommand("SELECT naam, beschrijving FROM projects WHERE id = '" + id + "'", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}, {1}",
                                reader[0], reader[1]));
                            NameActual.Text = (string)reader[0];
                            DescriptionText.Text = (string)reader[1];
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                }
                conn.Close();
        }

        private void selectProject(object sender, DataGridViewCellEventArgs e)
        {
            
            // get the row index of the cell clicked
            // var rowIndex = e.RowIndex;
            // specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
            int id = Convert.ToInt32(ProjectsDatatable.Rows[e.RowIndex].Cells[0].Value);
         
           
            EditProject(id);
           
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            // get id from selection datatable -> ProjectsDatatable and save all the fields in the DB
        }
    }
}
