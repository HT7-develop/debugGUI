using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;



namespace debugGUI
{
    public partial class Form1 : Form
    {

        private IconButton currentButton;
        readonly Color ButtonColor =  Color.FromArgb(115, 103, 240);


        public Form1()
        {
            InitializeComponent();

            filltasks();


        }

         

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
               
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = ButtonColor;
                    currentButton.ForeColor = Color.Gainsboro;
                    currentButton.Font = new System.Drawing.Font("Arial", 17.75F, System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(40, 48, 70);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void TeamsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void fillTeams()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            String querry = "SELECT * FROM teams";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        private void fillProjects()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            String querry = "SELECT * FROM projects";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }


        // imports for dragging the form without border
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // function to move form on top panel
        private void dragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
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
        private void CloseApp(object sender, EventArgs e)
        {
            // when click on button X on the sign in page, a messagebox will pop-up to ask for confirmation
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit this application", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CheckKeyDownForm(object sender, KeyPressEventArgs e)
        {
            
                DialogResult d;
                d = MessageBox.Show("Are you sure you want to exit this application", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    Application.Exit();
                }
          
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit this application", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}