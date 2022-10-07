namespace debugGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new FontAwesome.Sharp.IconButton();
            this.ChatButton = new FontAwesome.Sharp.IconButton();
            this.TeamsButton = new FontAwesome.Sharp.IconButton();
            this.TasksButton = new FontAwesome.Sharp.IconButton();
            this.ProjectsButton = new FontAwesome.Sharp.IconButton();
            this.DashboardButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Projects = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.ChatButton);
            this.panel1.Controls.Add(this.TeamsButton);
            this.panel1.Controls.Add(this.TasksButton);
            this.panel1.Controls.Add(this.ProjectsButton);
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SettingsButton, "SettingsButton");
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.SettingsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsButton.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.SettingsButton.IconColor = System.Drawing.Color.White;
            this.SettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // ChatButton
            // 
            this.ChatButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ChatButton, "ChatButton");
            this.ChatButton.FlatAppearance.BorderSize = 0;
            this.ChatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.ChatButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ChatButton.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.ChatButton.IconColor = System.Drawing.Color.White;
            this.ChatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.UseVisualStyleBackColor = false;
            this.ChatButton.Click += new System.EventHandler(this.iconButton5_Click);
            this.ChatButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainButtonsHover);
            // 
            // TeamsButton
            // 
            this.TeamsButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TeamsButton, "TeamsButton");
            this.TeamsButton.FlatAppearance.BorderSize = 0;
            this.TeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.TeamsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.TeamsButton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.TeamsButton.IconColor = System.Drawing.Color.White;
            this.TeamsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TeamsButton.Name = "TeamsButton";
            this.TeamsButton.UseVisualStyleBackColor = false;
            this.TeamsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainButtonsHover);
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
            this.TasksButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainButtonsHover);
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
            this.ProjectsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainButtonsHover);
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
            this.DashboardButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainButtonsHover);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Name = "panel4";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.panel7.Controls.Add(this.Projects);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // Projects
            // 
            resources.ApplyResources(this.Projects, "Projects");
            this.Projects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Projects.Name = "Projects";
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Name = "panel5";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.panel8.Controls.Add(this.label2);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label2.Name = "label2";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Name = "panel6";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.panel9.Controls.Add(this.label3);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private Label Projects;
        private Panel panel5;
        private Panel panel8;
        private Panel panel6;
        private Panel panel9;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton DashboardButton;
        private FontAwesome.Sharp.IconButton ChatButton;
        private FontAwesome.Sharp.IconButton TeamsButton;
        private FontAwesome.Sharp.IconButton TasksButton;
        private FontAwesome.Sharp.IconButton ProjectsButton;
        private FontAwesome.Sharp.IconButton SettingsButton;
    }
}