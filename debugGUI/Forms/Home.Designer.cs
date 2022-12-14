namespace debugGUI
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.EmployeesButton = new FontAwesome.Sharp.IconButton();
            this.TasksButton = new FontAwesome.Sharp.IconButton();
            this.ProjectsButton = new FontAwesome.Sharp.IconButton();
            this.DashboardButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserRole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.ExitButton);
            this.panelMenu.Controls.Add(this.EmployeesButton);
            this.panelMenu.Controls.Add(this.TasksButton);
            this.panelMenu.Controls.Add(this.ProjectsButton);
            this.panelMenu.Controls.Add(this.DashboardButton);
            this.panelMenu.Controls.Add(this.panel2);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.ExitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.EmployeesButton, "EmployeesButton");
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.EmployeesButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.EmployeesButton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.EmployeesButton.IconColor = System.Drawing.Color.White;
            this.EmployeesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.TeamsButton_Click);
            // 
            // TasksButton
            // 
            this.TasksButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TasksButton, "TasksButton");
            this.TasksButton.FlatAppearance.BorderSize = 0;
            this.TasksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.TasksButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.TasksButton.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.TasksButton.IconColor = System.Drawing.Color.White;
            this.TasksButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TasksButton.Name = "TasksButton";
            this.TasksButton.UseVisualStyleBackColor = false;
            this.TasksButton.Click += new System.EventHandler(this.TasksButton_Click);
            // 
            // ProjectsButton
            // 
            this.ProjectsButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ProjectsButton, "ProjectsButton");
            this.ProjectsButton.FlatAppearance.BorderSize = 0;
            this.ProjectsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.ProjectsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProjectsButton.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.ProjectsButton.IconColor = System.Drawing.Color.White;
            this.ProjectsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProjectsButton.Name = "ProjectsButton";
            this.ProjectsButton.UseVisualStyleBackColor = false;
            this.ProjectsButton.Click += new System.EventHandler(this.ProjectsButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.DashboardButton, "DashboardButton");
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.DashboardButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.DashboardButton.IconColor = System.Drawing.Color.White;
            this.DashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Name = "panel3";
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragForm);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserRole);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.UsernameLabel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // UserRole
            // 
            resources.ApplyResources(this.UserRole, "UserRole");
            this.UserRole.BackColor = System.Drawing.Color.Transparent;
            this.UserRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UserRole.Name = "UserRole";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panelDesktopPane, "panelDesktopPane");
            this.panelDesktopPane.Name = "panelDesktopPane";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyDownForm);
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panel2;
        private Label UsernameLabel;
        private Panel panel3;
        private Label UserRole;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton DashboardButton;
        private FontAwesome.Sharp.IconButton EmployeesButton;
        private FontAwesome.Sharp.IconButton TasksButton;
        private FontAwesome.Sharp.IconButton ProjectsButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private Panel panel1;
        private Panel panelDesktopPane;
    }
}