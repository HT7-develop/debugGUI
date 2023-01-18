using debugGUI.classes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace debugGUI
{
    public partial class FormProjects : Form
    {
        SqlDataReader myreader;

        static dbConnection dbConnection = new dbConnection();
        SqlConnection conn = new SqlConnection(dbConnection.ConnectionString);

        private List<AvailabilityModel> projectleden = new List<AvailabilityModel>();
        private List<ProjectSoort> projectsoort = new List<ProjectSoort>();
       
        public int TotalLooptijd;
        public  int TotalGebruikte_uren;


        public FormProjects()
        {
            InitializeComponent();
            //this.projectleden = projectleden;
            //this.projectsoort = projectsoort;
            // pre-fill datatable at init 
            FillProjectsDatatable();

           
        }

        private void FillProjectsDatatable()
        {
            // fill the projects datatable , no role checking on this page as a "project member" cannot access this page 
            String querry = "SELECT * FROM projects";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ProjectsDatatable.DataSource = dt;
            ProjectsDatatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProjectsDatatable.Columns[2].FillWeight = 400;
            conn.Close();

            //populate projectsoort box in new project tab
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT name FROM ProjectSoort", conn);
            SqlDataReader reader = command.ExecuteReader();
            var ProjectSoort = new List<string>();
           
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                ProjectSoort.Add(name);
            }
            ProjectSoortBox.DataSource = ProjectSoort;
            conn.Close();

            // populate users box in the new project tab
            conn.Open();
            SqlCommand command2 = new SqlCommand("SELECT * FROM users", conn);
            SqlDataReader reader2 = command2.ExecuteReader();
            var RaycoUsers = new List<string>();

            while (reader2.Read())
            {
                string name2 = reader2["name"].ToString();
                RaycoUsers.Add(name2);
            }
            HRusersBox.DataSource = RaycoUsers;
            conn.Close();
        }

        private void FillPTasksDatatable(int id)
        {
            conn.Open();
            // fill the project tasks datatable
            String querry = "SELECT * FROM tasks where project_id = '" + id + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ProjectTasksDatatable.DataSource = dt;
            ProjectTasksDatatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProjectTasksDatatable.Columns[2].FillWeight = 400;
            conn.Close();



            //conn.Open();
            //SqlCommand command = new SqlCommand("SELECT name FROM ProjectSoort", conn);
            //SqlDataReader reader = command.ExecuteReader();
            //var ProjectSoort = new List<string>();


            //while (reader.Read())
            //{
            //    string name = reader["name"].ToString();
            //    ProjectSoort.Add(name);
            //}
            //ProjectSoortBox.DataSource = ProjectSoort;
            //conn.Close();
        }


        private void NewProject(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                string naam = NewProjectNameActual.Text;
                string beschrijving = NewProjectDescriptionActual.Text;
                string projectsoort = ProjectSoortBox.Text;
                string assignedUser = HRusersBox.Text;

                // get deeltaken == projectid from Db
                using (conn)
                {
                    // sql command to get the project with the ID passed from SelectProject(function)
                    SqlCommand querryDeeltaak = new SqlCommand("SELECT * FROM deeltaak where projectsoort = '" + projectsoort + "'", conn);
                    SqlDataReader reader = querryDeeltaak.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string titel = (string)reader[1];
                            string description = (string)reader[2];
                            string status = (string)reader[3];
                            int looptijd = (int)reader[4];
                            DeelTaak opvolger_id = (DeelTaak)reader[5];
                            string role = (string)reader[7];
                            //new DeelTaak(titel, description, role, opvolger_id, looptijd, status);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                    conn.Close();
                }

                //loop through results and make new Taak() with results from reader
                // add Deeltaken to Project in the DB 
                try {
                    conn.Open();
                    var insertCommand = new SqlCommand($"INSERT INTO projects (naam, beschrijving, projectsoort, user) VALUES ('{naam}','{beschrijving}','{projectsoort}','{assignedUser}')", conn);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show($"New Project {naam} created Successfully with ProjectSoort: {projectsoort}");
                    conn.Close();
                    FillProjectsDatatable();
                } catch (Exception error)
                {
                    conn.Close();
                    MessageBox.Show(error.Message);
                }
            }
            catch (Exception error)
            {
                conn.Close();
                MessageBox.Show(error.Message);
            }
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            // get id from Project_Id label , filled with FillEditPanel() function
            string id = Convert.ToString(Project_Id.Text);
            string name = NameActual.Text;
            DialogResult d;
            // message box for user to confirm deletion of project in case there was a false click.
            d = MessageBox.Show($"Are you sure you want to delete task {name}", $"Delete Task {id}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                try
                {
                    SqlCommand command = new SqlCommand("DELETE FROM projects WHERE id = '" + id + "'", conn);
                    conn.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    MessageBox.Show("successfully deleted Task from database.", "Task deleted");
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                    FillProjectsDatatable();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void FillEditPanel(int id)
        {
            // this function gets called after SelectProject() and get the the id from that project passed as an parameter.
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
            conn.Open();
            // remove previous text from the edit panel just in case.
            NameActual.Text = "";
            DescriptionActual.Text = "";
            // connection with the DB again 
            using (conn)
            {
                // sql command to get the project with the ID passed from SelectProject(function)
                SqlCommand command = new SqlCommand("SELECT * FROM projects WHERE id = '" + id + "'", conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Project_Id.Text = Convert.ToString(reader[0]);
                        NameActual.Text = (string)reader[1];
                        DescriptionActual.Text = (string)reader[2];
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            conn.Close();
            // call the calculate leadtime function with project id
            LeadTimeCalc(id);
        }

        private void SelectProject(object sender, DataGridViewCellEventArgs e)
        {
            // this is a function for clicking on a cell of the corresponding data table , ignore the click if the index is below 0
            // 0 means the headers , these do not contain info to display and will normally generate an error.
            try
            {
                if (e.RowIndex > 0)
                {
                    int id = Convert.ToInt32(ProjectsDatatable.Rows[e.RowIndex].Cells[0].Value);
                    FillEditPanel(id);
                    FillPTasksDatatable(id);
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message );
            }


        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            // when click ing on the update button, get all values from the textboxes and add these values as new in the DB with the correct project id.
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
            string name = NameActual.Text;
            try
            {
                conn.Open();
                int id = Convert.ToInt32(Project_Id.Text);
                string title = NameActual.Text;
                string beschrijving = DescriptionActual.Text;
                SqlCommand command = new SqlCommand($"UPDATE projects SET naam=@naam, beschrijving = @beschrijving WHERE id = {id}", conn);
                command.Parameters.AddWithValue("@naam", title);
                command.Parameters.AddWithValue("@beschrijving", beschrijving);
                command.ExecuteNonQuery();
                MessageBox.Show($"Project '{name}' Updated Successfully");
                conn.Close();

                FillProjectsDatatable();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void FinishProjectButtonClick(object sender, EventArgs e)
        {
            // get values from the textboxes 
            int id = Convert.ToInt32(Project_Id.Text);
            string naam = NameActual.Text;
            string beschrijving = DescriptionActual.Text;
            // status will be hardcoded to "Finished"
            string status = "Finished";
            // messagebox will popup for user to confirm they want to finish the project or not
            DialogResult d;
            d = MessageBox.Show($"Is this project:'{naam}' finished?", $"Finish:'{naam}'", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (d == DialogResult.Yes)
            {
                try
                {
                    // update the project with status finished when click on the button
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
                    conn.Open();
                    SqlCommand command = new SqlCommand($"UPDATE projects SET naam=@naam, beschrijving = @beschrijving, status = @status WHERE id = {id}", conn);
                    command.Parameters.AddWithValue("@naam", naam);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@beschrijving", beschrijving);
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Project:'{naam}', marked as finished.");
                    conn.Close();

                    FillProjectsDatatable();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void LeadTimeCalc(int id)
        {
            
            SqlConnection conn3 = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");

            conn3.Open();
            using (conn3)
            {
                // get doorlooptijd and from project 
                // There is no checking at this point for tasks that can be done after another
                // (even though that option can be set when creating a new task)
                SqlCommand command2 = new SqlCommand("SELECT MAX(looptijd) FROM tasks WHERE project_id = '" + id + "'", conn3);
              
                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        if (reader2[0] != DBNull.Value)
                        {
                            TotalLooptijd = Convert.ToInt32(reader2[0]);
                        }
                        else
                        {
                            Doorlooptijd_actual.Text = "0";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader2.Close();

                // get gebruikte_uren per task and get the sum.
                SqlCommand command3 = new SqlCommand("SELECT gebruikte_uren FROM tasks WHERE project_id = '" + id + "'", conn3);
                SqlDataReader reader3 = command3.ExecuteReader();

                if (reader3.HasRows)
                {
                    while (reader3.Read())
                    {
                        if (reader3[0] != DBNull.Value)
                        {
                            TotalGebruikte_uren += Convert.ToInt32(reader3[0]);
                        }
                        else
                        {
                            TotalGebruikteUren.Text = "0";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader3.Close();

                Doorlooptijd_actual.Text = Convert.ToString(TotalLooptijd);
                TotalGebruikteUren.Text = Convert.ToString(TotalGebruikte_uren);
            }
            conn3.Close();
        }
    }
}
