namespace debugGUI
{
    partial class FormProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LeftSide = new System.Windows.Forms.Panel();
            this.CreateProject = new System.Windows.Forms.Panel();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.TeamsCombo = new System.Windows.Forms.ComboBox();
            this.StartDateActual = new System.Windows.Forms.Label();
            this.StartDate_Label = new System.Windows.Forms.Label();
            this.EndDateActual = new System.Windows.Forms.Label();
            this.EndDate_Label = new System.Windows.Forms.Label();
            this.TeamCombo_Label = new System.Windows.Forms.Label();
            this.NameActual = new System.Windows.Forms.Label();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.ViewProjects = new System.Windows.Forms.Panel();
            this.Project_top_Label = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Projects = new System.Windows.Forms.Label();
            this.ProjectsDatatable = new System.Windows.Forms.DataGridView();
            this.RightSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.LeftSide.SuspendLayout();
            this.CreateProject.SuspendLayout();
            this.ViewProjects.SuspendLayout();
            this.Project_top_Label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDatatable)).BeginInit();
            this.RightSide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftSide
            // 
            this.LeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.LeftSide.Controls.Add(this.CreateProject);
            this.LeftSide.Controls.Add(this.ViewProjects);
            this.LeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSide.Location = new System.Drawing.Point(0, 0);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(680, 663);
            this.LeftSide.TabIndex = 0;
            // 
            // CreateProject
            // 
            this.CreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.CreateProject.Controls.Add(this.DescriptionText);
            this.CreateProject.Controls.Add(this.TeamsCombo);
            this.CreateProject.Controls.Add(this.StartDateActual);
            this.CreateProject.Controls.Add(this.StartDate_Label);
            this.CreateProject.Controls.Add(this.EndDateActual);
            this.CreateProject.Controls.Add(this.EndDate_Label);
            this.CreateProject.Controls.Add(this.TeamCombo_Label);
            this.CreateProject.Controls.Add(this.NameActual);
            this.CreateProject.Controls.Add(this.Description_Label);
            this.CreateProject.Controls.Add(this.Name_Label);
            this.CreateProject.Controls.Add(this.iconButton3);
            this.CreateProject.Controls.Add(this.iconButton2);
            this.CreateProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateProject.Location = new System.Drawing.Point(0, 346);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(680, 317);
            this.CreateProject.TabIndex = 1;
            // 
            // DescriptionText
            // 
            this.DescriptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.DescriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionText.ForeColor = System.Drawing.Color.White;
            this.DescriptionText.Location = new System.Drawing.Point(303, 56);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(5);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DescriptionText.Size = new System.Drawing.Size(347, 201);
            this.DescriptionText.TabIndex = 30;
            this.DescriptionText.Text = "";
            // 
            // TeamsCombo
            // 
            this.TeamsCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.TeamsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamsCombo.ForeColor = System.Drawing.Color.White;
            this.TeamsCombo.FormattingEnabled = true;
            this.TeamsCombo.Location = new System.Drawing.Point(28, 121);
            this.TeamsCombo.Name = "TeamsCombo";
            this.TeamsCombo.Size = new System.Drawing.Size(235, 23);
            this.TeamsCombo.TabIndex = 0;
            // 
            // StartDateActual
            // 
            this.StartDateActual.AutoSize = true;
            this.StartDateActual.BackColor = System.Drawing.Color.Transparent;
            this.StartDateActual.ForeColor = System.Drawing.Color.White;
            this.StartDateActual.Location = new System.Drawing.Point(28, 210);
            this.StartDateActual.Name = "StartDateActual";
            this.StartDateActual.Size = new System.Drawing.Size(89, 15);
            this.StartDateActual.TabIndex = 29;
            this.StartDateActual.Text = "StartDateActual";
            // 
            // StartDate_Label
            // 
            this.StartDate_Label.AutoSize = true;
            this.StartDate_Label.BackColor = System.Drawing.Color.Transparent;
            this.StartDate_Label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartDate_Label.ForeColor = System.Drawing.Color.White;
            this.StartDate_Label.Location = new System.Drawing.Point(28, 187);
            this.StartDate_Label.Name = "StartDate_Label";
            this.StartDate_Label.Size = new System.Drawing.Size(69, 20);
            this.StartDate_Label.TabIndex = 28;
            this.StartDate_Label.Text = "Start Date";
            // 
            // EndDateActual
            // 
            this.EndDateActual.AutoSize = true;
            this.EndDateActual.BackColor = System.Drawing.Color.Transparent;
            this.EndDateActual.ForeColor = System.Drawing.Color.White;
            this.EndDateActual.Location = new System.Drawing.Point(175, 210);
            this.EndDateActual.Name = "EndDateActual";
            this.EndDateActual.Size = new System.Drawing.Size(85, 15);
            this.EndDateActual.TabIndex = 27;
            this.EndDateActual.Text = "EndDateActual";
            // 
            // EndDate_Label
            // 
            this.EndDate_Label.AutoSize = true;
            this.EndDate_Label.BackColor = System.Drawing.Color.Transparent;
            this.EndDate_Label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndDate_Label.ForeColor = System.Drawing.Color.White;
            this.EndDate_Label.Location = new System.Drawing.Point(175, 187);
            this.EndDate_Label.Name = "EndDate_Label";
            this.EndDate_Label.Size = new System.Drawing.Size(65, 20);
            this.EndDate_Label.TabIndex = 26;
            this.EndDate_Label.Text = "End Date";
            // 
            // TeamCombo_Label
            // 
            this.TeamCombo_Label.AutoSize = true;
            this.TeamCombo_Label.BackColor = System.Drawing.Color.Transparent;
            this.TeamCombo_Label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamCombo_Label.ForeColor = System.Drawing.Color.White;
            this.TeamCombo_Label.Location = new System.Drawing.Point(28, 98);
            this.TeamCombo_Label.Name = "TeamCombo_Label";
            this.TeamCombo_Label.Size = new System.Drawing.Size(43, 20);
            this.TeamCombo_Label.TabIndex = 22;
            this.TeamCombo_Label.Text = "Team";
            // 
            // NameActual
            // 
            this.NameActual.AutoSize = true;
            this.NameActual.BackColor = System.Drawing.Color.Transparent;
            this.NameActual.ForeColor = System.Drawing.Color.White;
            this.NameActual.Location = new System.Drawing.Point(28, 57);
            this.NameActual.Name = "NameActual";
            this.NameActual.Size = new System.Drawing.Size(73, 15);
            this.NameActual.TabIndex = 21;
            this.NameActual.Text = "NameActual";
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.BackColor = System.Drawing.Color.Transparent;
            this.Description_Label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description_Label.ForeColor = System.Drawing.Color.White;
            this.Description_Label.Location = new System.Drawing.Point(303, 24);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(80, 20);
            this.Description_Label.TabIndex = 20;
            this.Description_Label.Text = "Description";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Name_Label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.Location = new System.Drawing.Point(28, 34);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(44, 20);
            this.Name_Label.TabIndex = 19;
            this.Name_Label.Text = "Name";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.IndianRed;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(159, 275);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(106, 30);
            this.iconButton3.TabIndex = 17;
            this.iconButton3.Text = "DELETE";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.DeleteProject);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(33, 275);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(93, 30);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.Text = "EDIT";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // ViewProjects
            // 
            this.ViewProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.ViewProjects.Controls.Add(this.Project_top_Label);
            this.ViewProjects.Controls.Add(this.ProjectsDatatable);
            this.ViewProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewProjects.Location = new System.Drawing.Point(0, 0);
            this.ViewProjects.Name = "ViewProjects";
            this.ViewProjects.Size = new System.Drawing.Size(680, 323);
            this.ViewProjects.TabIndex = 0;
            // 
            // Project_top_Label
            // 
            this.Project_top_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.Project_top_Label.Controls.Add(this.iconPictureBox1);
            this.Project_top_Label.Controls.Add(this.Projects);
            this.Project_top_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Project_top_Label.Location = new System.Drawing.Point(0, 0);
            this.Project_top_Label.Name = "Project_top_Label";
            this.Project_top_Label.Size = new System.Drawing.Size(680, 54);
            this.Project_top_Label.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // Projects
            // 
            this.Projects.AutoSize = true;
            this.Projects.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Projects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Projects.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Projects.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Projects.Location = new System.Drawing.Point(51, 12);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(101, 31);
            this.Projects.TabIndex = 0;
            this.Projects.Text = "Projects";
            this.Projects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectsDatatable
            // 
            this.ProjectsDatatable.AllowUserToAddRows = false;
            this.ProjectsDatatable.AllowUserToDeleteRows = false;
            this.ProjectsDatatable.AllowUserToResizeColumns = false;
            this.ProjectsDatatable.AllowUserToResizeRows = false;
            this.ProjectsDatatable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.ProjectsDatatable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectsDatatable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProjectsDatatable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsDatatable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectsDatatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsDatatable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectsDatatable.EnableHeadersVisualStyles = false;
            this.ProjectsDatatable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.ProjectsDatatable.Location = new System.Drawing.Point(12, 67);
            this.ProjectsDatatable.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectsDatatable.MultiSelect = false;
            this.ProjectsDatatable.Name = "ProjectsDatatable";
            this.ProjectsDatatable.ReadOnly = true;
            this.ProjectsDatatable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsDatatable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectsDatatable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsDatatable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProjectsDatatable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.ProjectsDatatable.RowTemplate.Height = 40;
            this.ProjectsDatatable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectsDatatable.ShowCellErrors = false;
            this.ProjectsDatatable.ShowCellToolTips = false;
            this.ProjectsDatatable.ShowEditingIcon = false;
            this.ProjectsDatatable.ShowRowErrors = false;
            this.ProjectsDatatable.Size = new System.Drawing.Size(651, 241);
            this.ProjectsDatatable.TabIndex = 0;
            this.ProjectsDatatable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectProject);
            // 
            // RightSide
            // 
            this.RightSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.RightSide.Controls.Add(this.panel1);
            this.RightSide.Controls.Add(this.textBox5);
            this.RightSide.Controls.Add(this.textBox4);
            this.RightSide.Controls.Add(this.label18);
            this.RightSide.Controls.Add(this.label17);
            this.RightSide.Controls.Add(this.textBox2);
            this.RightSide.Controls.Add(this.textBox1);
            this.RightSide.Controls.Add(this.label12);
            this.RightSide.Controls.Add(this.label11);
            this.RightSide.Controls.Add(this.DescriptionTextBox);
            this.RightSide.Controls.Add(this.label9);
            this.RightSide.Controls.Add(this.iconButton1);
            this.RightSide.Controls.Add(this.label10);
            this.RightSide.Location = new System.Drawing.Point(701, 0);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(452, 663);
            this.RightSide.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 54);
            this.panel1.TabIndex = 35;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(94, 261);
            this.textBox5.Margin = new System.Windows.Forms.Padding(10);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(339, 16);
            this.textBox5.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(94, 222);
            this.textBox4.Margin = new System.Windows.Forms.Padding(10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(339, 16);
            this.textBox4.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(16, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "End Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Start Date";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(94, 137);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 16);
            this.textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(94, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 16);
            this.textBox1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(35, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Please provide a short description of this project";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionTextBox.Location = new System.Drawing.Point(14, 393);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(420, 210);
            this.DescriptionTextBox.TabIndex = 22;
            this.DescriptionTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Team";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(132, 621);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(179, 30);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.Text = "New Project";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.NewProject);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormProjects
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1153, 663);
            this.Controls.Add(this.RightSide);
            this.Controls.Add(this.LeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProjects";
            this.Text = "FormProjects";
            this.LeftSide.ResumeLayout(false);
            this.CreateProject.ResumeLayout(false);
            this.CreateProject.PerformLayout();
            this.ViewProjects.ResumeLayout(false);
            this.Project_top_Label.ResumeLayout(false);
            this.Project_top_Label.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDatatable)).EndInit();
            this.RightSide.ResumeLayout(false);
            this.RightSide.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LeftSide;
        private Panel CreateProject;
        private Panel ViewProjects;
        private Panel RightSide;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ComboBox TeamsCombo;
        private Label StartDateActual;
        private Label StartDate_Label;
        private Label EndDateActual;
        private Label EndDate_Label;
        private Label TeamCombo_Label;
        private Label NameActual;
        private Label Description_Label;
        private Label Name_Label;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label18;
        private Label label17;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label12;
        private Label label11;
        private RichTextBox DescriptionTextBox;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label10;
        private DataGridView ProjectsDatatable;
        private RichTextBox DescriptionText;
        private Panel Project_top_Label;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label Projects;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label1;
    }
}