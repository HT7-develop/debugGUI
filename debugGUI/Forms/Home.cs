using debugGUI.Classes;
using FontAwesome.Sharp;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace debugGUI
{
    public partial class Home : Form 
    {

        private IconButton currentButton;
        readonly Color ButtonColor = Color.FromArgb(115, 103, 240);
        private Form activeForm;
       
        public static int adminResult;
        public static int userId;

        dbConnection db = new dbConnection();

        public Home()
        {
            InitializeComponent();
            UserInfo();
            OpenTab(new FormDashboard(), default);
        }

        public void UserInfo()
        {
            
            db.connOpen();
            string UserName = LoginScreen.username; 
            UsernameLabel.Text = UserName;

            // check user role with name entered in login
            //SqlCommand command = new SqlCommand($"SELECT admin,id FROM users WHERE name = '{UserName}'", db);
            dbConnection.sqlComm($"SELECT admin,id FROM users WHERE name = '{UserName}'", db);
            SqlDataReader reader = sqlComm.ExecuteReader();
            adminResult = 0;
           
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    adminResult = Convert.ToInt32(reader[0]);
                    userId = Convert.ToInt32(reader[1]);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            if (adminResult == 1)
            {
                UserRole.Text = "Admin";
                UserRole.BackColor = Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
                UserRole.ForeColor = Color.White;

            }
            else
            {
                UserRole.Text = "Project Member";
                UserRole.BackColor = Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
                UserRole.ForeColor = Color.White;
            }
            // Checkrole function , to hide/display elements on page
            CheckRole(adminResult);
        }

        private void CheckRole(int admin)
        {
            // this function will be called after rendering all elements to check if user 
            // is admin or not, and accordingly will hide/show buttons/tabs 
            if (admin != 1)
            {
                EmployeesButton.Visible = false;
                ProjectsButton.Visible = false;

            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();

                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = ButtonColor;
                    currentButton.ForeColor = Color.Gainsboro;
                    currentButton.Font = new System.Drawing.Font("Arial", 17.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private void OpenTab(Form tab, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = tab;
            tab.TopLevel = false;
            tab.FormBorderStyle = FormBorderStyle.None;
            tab.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(tab);
            this.panelDesktopPane.Tag = tab;
            tab.BringToFront();
            tab.Show();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            OpenTab(new FormDashboard(), sender);
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            OpenTab(new FormProjects(), sender);
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            OpenTab(new FormTasks(), sender);
        }

        private void TeamsButton_Click(object sender, EventArgs e)
        {
            OpenTab(new FormEmployee(), sender);
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
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit this application", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CheckKeyDownForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure you want to exit this application", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (d == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}