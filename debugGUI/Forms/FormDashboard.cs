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

namespace debugGUI
{
    public partial class FormDashboard : Form
    {
        private HrKoppeling hrKoppeling = new HrKoppeling("http://localhost:8008");
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");

        public FormDashboard()
        {
            InitializeComponent();
            Filltasks();
            FillProjects();
            FillRaycoEmployeeDatatable();
        }
        // function to fill tasks datatable with no filters for role
        private void Filltasks()
        {
            conn.Open();
            String querry = "SELECT TOP(10) title , beschrijving , status , looptijd , gebruikte_uren FROM tasks";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTasks.DataSource = dt;
            // custom settings to hide id column and make name column larger/have more weight
            dgvTasks.Columns[0].Visible = false;
            dgvTasks.Columns[1].FillWeight = 400;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            conn.Close();

        }
        // function to fill projects datatable with no filters for role
        private void FillProjects()
        {
            conn.Open();
            String querry = "SELECT * FROM projects";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProjects.DataSource = dt;
            // custom settings to hide id column and make name column larger/have more weight
            dgvProjects.Columns[0].Visible = false;
            dgvProjects.Columns[2].FillWeight = 400;
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();

        }

        private void FillRaycoEmployeeDatatable()
        {
            conn.Open();
            String querry = "SELECT id, name, admin FROM users";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeRaycoDatatable.DataSource = dt;
            EmployeeRaycoDatatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeRaycoDatatable.Columns[1].FillWeight = 300;

            conn.Close();
        }
    }

}
