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
    public partial class FormDashboard : Form
    {
        private HrKoppeling hrKoppeling = new HrKoppeling("http://localhost:8008");

        public FormDashboard()
        {
            InitializeComponent();
            filltasks();
            FillProjects();
            FillWerknemers();
        }
        private void filltasks()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
            conn.Open();
            String querry = "SELECT * FROM tasks";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTasks.DataSource = dt;
            conn.Close();
        }

        private void FillProjects()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
            conn.Open();
            String querry = "SELECT * FROM projects";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvProjects.DataSource = dt;

            var insertCommand = new SqlCommand(
                "INSERT INTO projects (id, beschrijving, naam) " +
                "VALUES (@Id, @Beschrijving, @Naam)", conn);

            insertCommand.Parameters.Add("@Id", SqlDbType.Int);
            insertCommand.Parameters.Add("@Beschrijving", SqlDbType.VarChar, -1);
            insertCommand.Parameters.Add("@Naam", SqlDbType.VarChar, 50);

            sda.InsertCommand = insertCommand;

            conn.Close();
        }

        private void FillWerknemers()
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

            werknemers.DataSource = dt;
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bla(object sender, DataGridViewRowEventArgs e)
        {

        }
    }

}
