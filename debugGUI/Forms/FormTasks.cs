using debugGUI.classes;
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
    public partial class FormTasks : Form
    {
        static dbConnection dbConnection = new dbConnection();
        SqlConnection conn = new SqlConnection(dbConnection.ConnectionString);
        SqlDataReader myreader;
        readonly int admin = Home.adminResult;
        readonly int userId = Home.userId;
        public FormTasks()
        {
            InitializeComponent();
            FillDatatable();
        }

       
        private void FillDatatable()
        {
            conn.Open();
            if (admin == 1)
            {
                // if you are an admin you can see all tasks to view/edit/delete/finish
                String querry = "SELECT * FROM tasks";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TasksDatatable.DataSource = dt;
            } else
            {
                // if you are a project member only tasks assigned
                // to you are available to view/edit/finish
                DeleteTaskButton.Enabled = false;
                DeleteTaskButton.BackColor = Color.Gray;
                String querry = $"SELECT * FROM tasks where werknemer_id = {userId}";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TasksDatatable.DataSource = dt;
            }

            TasksDatatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // add extra width (percentage based) to title and beschrijving
            TasksDatatable.Columns[0].Visible = false;
            TasksDatatable.Columns[1].FillWeight = 300;
            TasksDatatable.Columns[2].FillWeight = 300;
            conn.Close();
        }

        private void FillEditPanel(int id)
        {
            //problem with keeping open the connection (and re-opening) 
            
            try
            {
                conn.Open();
                TitelActual.Text = "";
                BeschrijvingActual.Text = "";
                StatusActual.Text = "";
                DoorLoopTijdActual.Text = "";
                ProjectActual.Text = "";
                GebruikteUrenActual.Text = "";
                WerknemerActual.Text = "";
                Task_Id.Text = "";
                using (conn)
                {
                    // to get project name using task ID
                    //SqlDataReader reader_project = command_project.ExecuteReader();

                    // getting the data form the selected task in the top datagridview
                    SqlCommand command = new SqlCommand("SELECT * FROM tasks WHERE id = '" + id + "'", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TitelActual.Text = (string)reader[1];
                            BeschrijvingActual.Text = (string)reader[2];
                            StatusActual.Text = (string)reader[3];
                            DoorLoopTijdActual.Text = Convert.ToString(reader[4]);
                            ProjectActual.Text = Convert.ToString(reader[6]);
                            GebruikteUrenActual.Text = Convert.ToString(reader[7]);
                            WerknemerActual.Text = Convert.ToString(reader[8]);
                            Task_Id.Text = Convert.ToString(reader[0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                    conn.Close();
                }
               
            }
            catch (Exception e)
            {

                Console.Write($"FormTasks Exception: {e}");
            }

        }

        private void SelectTask(object sender, DataGridViewCellEventArgs e)
        {
            // checking of rowindex does not equel negative number (these are the headers)
            // this solves error of index for filling in the edit fields
            try
            {
                if (e.RowIndex > 0)
                {
                    int id = Convert.ToInt32(TasksDatatable.Rows[e.RowIndex].Cells[0].Value);
                    FillEditPanel(id);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            // function to delete a task , with messagebox to confirm click is not false positive
            string id = Convert.ToString(Task_Id.Text);
            string title = TitelActual.Text;
            DialogResult d;
            d = MessageBox.Show($"Are you sure you want to delete this task {title}", $"Delete Task {id}", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (d == DialogResult.Yes)
            {
                try
                {
                    SqlCommand command = new SqlCommand("DELETE FROM tasks WHERE id = '" + id + "'", conn);
                    conn.Open();
                    myreader = command.ExecuteReader();
                    MessageBox.Show($"successfully deleted Task {title} from database.", "Task deleted");
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                    FillDatatable();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void NewTaskButtonClick(object sender, EventArgs e)
        {
            try
            {
                //when clicking on new task get all the values from the textboxes using the .Text attribute
                conn.Open();
                string naam = NewTaskTitelActual.Text;
                string werknemer = NewTaskEmployeeActual.Text;
                string project = NewTaskProjectActual.Text;
                string doorLoopTijd = NewTaskDLTActual.Text;
                string beschrijving = NewTaskDescriptionActual.Text;
                // insert these new value in DB , ID is auto increment do not need to add this
                var insertCommand = new SqlCommand($"INSERT INTO tasks (title,beschrijving, werknemer_id,project_id,looptijd) VALUES (  '{naam}','{beschrijving}','{werknemer}','{project}','{doorLoopTijd}')", conn);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show($"New Task {naam} created Successfully");
                conn.Close();
                FillDatatable();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void UpdateTaskButtonClick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //get all the values from the textboxes using the .Text attribute that was filled in the edit panel of the form
                int id = Convert.ToInt32(Task_Id.Text);
                string title = TitelActual.Text;
                string beschrijving = BeschrijvingActual.Text;
                string project = ProjectActual.Text;
                string doorloop_tijd = DoorLoopTijdActual.Text;
                string status = StatusActual.Text;
                string gebruikte_uren = GebruikteUrenActual.Text;
                string werknemer = WerknemerActual.Text;

                SqlCommand command = new SqlCommand($"UPDATE tasks SET title=@title, beschrijving = @beschrijving, project_id = @project, looptijd = @doorloop_tijd , werknemer_id = @werknemer , gebruikte_uren = @gebruikte_uren, status = @status WHERE id = {id}", conn);

                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@beschrijving", beschrijving);
                command.Parameters.AddWithValue("@project", project);
                command.Parameters.AddWithValue("@doorloop_tijd", doorloop_tijd);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@gebruikte_uren", gebruikte_uren);
                command.Parameters.AddWithValue("@werknemer", werknemer);
                command.ExecuteNonQuery();
                //message box to confirm success , seems a nice visual hint that operation is done
                MessageBox.Show($"Task {title} Updated Successfully");
                conn.Close();

                FillDatatable();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void FinishTaskButtonClick(object sender, EventArgs e)
        {
            // finish task on button click,
            // also get all value in case user has updated his hours without clicking UPDATE first
            try
            {
                conn.Open();

                int id = Convert.ToInt32(Task_Id.Text);
                string title = TitelActual.Text;
                string status = "Finished";

                string beschrijving = BeschrijvingActual.Text;
                string project = ProjectActual.Text;
                string doorloop_tijd = DoorLoopTijdActual.Text;
                string gebruikte_uren = GebruikteUrenActual.Text;
                string werknemer = WerknemerActual.Text;

                SqlCommand command = new SqlCommand($"UPDATE tasks SET title=@title, beschrijving = @beschrijving, project_id = @project, looptijd = @doorloop_tijd , werknemer_id = @werknemer , gebruikte_uren = @gebruikte_uren, status = @status WHERE id = {id}", conn);

                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@beschrijving", beschrijving);
                command.Parameters.AddWithValue("@project", project);
                command.Parameters.AddWithValue("@doorloop_tijd", doorloop_tijd);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@gebruikte_uren", gebruikte_uren);
                command.Parameters.AddWithValue("@werknemer", werknemer);

                command.ExecuteNonQuery();
                MessageBox.Show($"Task:{title}, marked as finished.");
                conn.Close();

                FillDatatable();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
