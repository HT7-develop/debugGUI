using FontAwesome.Sharp;

namespace debugGUI
{
    public partial class Form1 : Form
    {

        private IconButton currentButton;
        readonly Color ButtonColor =  Color.FromArgb(115, 103, 240);


        public Form1()
        {
            InitializeComponent();
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
    }
}