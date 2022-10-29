using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;
namespace debugGUI
{
    public partial class Form1 : Form
    {

        private IconButton currentButton;
        readonly Color ButtonColor =  Color.FromArgb(115, 103, 240);
        private Form activeForm;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");

        public Form1()
        {
           
            InitializeComponent();
            UserInfo();

        }

        public void UserInfo()
        {
            // need username fro login 
            UsernameLabel.Text = Form2.username;
           // role = ;
        }

        private void GetShortStats()
        {
            // function to display the stats inside the topbar that is always visible as quick way to see vital info
           
            String pro = "SELECT * FROM projects";
            String tms = "SELECT * FROM teams";
            String tsk = "SELECT * FROM tasks";

            SqlDataAdapter projects = new SqlDataAdapter(pro, conn);
            SqlDataAdapter teams = new SqlDataAdapter(tms, conn);
            SqlDataAdapter tasks = new SqlDataAdapter(tsk, conn);
          
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
            OpenTab(new FormTeams(), sender);
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

    // function for opening childform 
    
}