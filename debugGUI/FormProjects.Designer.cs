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
            this.ProjectsDatatable = new System.Windows.Forms.DataGridView();
            this.TopLabel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Projects = new System.Windows.Forms.Label();
            this.DescriptionActual = new System.Windows.Forms.RichTextBox();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.RightSide = new System.Windows.Forms.Panel();
            this.FinishTaskButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Project_Id = new System.Windows.Forms.Label();
            this.NameActual = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewProjectNameActual = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NewProjectDescriptionActual = new System.Windows.Forms.RichTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.LeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDatatable)).BeginInit();
            this.TopLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.RightSide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftSide
            // 
            this.LeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.LeftSide.Controls.Add(this.ProjectsDatatable);
            this.LeftSide.Controls.Add(this.TopLabel);
            this.LeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSide.Location = new System.Drawing.Point(0, 0);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(728, 663);
            this.LeftSide.TabIndex = 0;
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
            this.ProjectsDatatable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsDatatable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectsDatatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsDatatable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectsDatatable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsDatatable.EnableHeadersVisualStyles = false;
            this.ProjectsDatatable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.ProjectsDatatable.Location = new System.Drawing.Point(0, 54);
            this.ProjectsDatatable.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectsDatatable.MultiSelect = false;
            this.ProjectsDatatable.Name = "ProjectsDatatable";
            this.ProjectsDatatable.ReadOnly = true;
            this.ProjectsDatatable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsDatatable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectsDatatable.RowHeadersVisible = false;
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
            this.ProjectsDatatable.RowTemplate.Height = 50;
            this.ProjectsDatatable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProjectsDatatable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectsDatatable.ShowCellErrors = false;
            this.ProjectsDatatable.ShowCellToolTips = false;
            this.ProjectsDatatable.ShowEditingIcon = false;
            this.ProjectsDatatable.ShowRowErrors = false;
            this.ProjectsDatatable.Size = new System.Drawing.Size(728, 609);
            this.ProjectsDatatable.TabIndex = 0;
            this.ProjectsDatatable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectProject);
            // 
            // TopLabel
            // 
            this.TopLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.TopLabel.Controls.Add(this.iconPictureBox1);
            this.TopLabel.Controls.Add(this.Projects);
            this.TopLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLabel.Location = new System.Drawing.Point(0, 0);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(728, 54);
            this.TopLabel.TabIndex = 36;
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
            this.Projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // DescriptionActual
            // 
            this.DescriptionActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.DescriptionActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionActual.ForeColor = System.Drawing.Color.White;
            this.DescriptionActual.Location = new System.Drawing.Point(13, 459);
            this.DescriptionActual.Margin = new System.Windows.Forms.Padding(5);
            this.DescriptionActual.Name = "DescriptionActual";
            this.DescriptionActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DescriptionActual.Size = new System.Drawing.Size(376, 141);
            this.DescriptionActual.TabIndex = 30;
            this.DescriptionActual.Text = "";
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.BackColor = System.Drawing.Color.Transparent;
            this.Description_Label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description_Label.ForeColor = System.Drawing.Color.White;
            this.Description_Label.Location = new System.Drawing.Point(13, 434);
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
            this.Name_Label.Location = new System.Drawing.Point(12, 382);
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
            this.iconButton3.Location = new System.Drawing.Point(148, 621);
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
            this.iconButton2.Location = new System.Drawing.Point(13, 621);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(105, 30);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.Text = "UPDATE";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // RightSide
            // 
            this.RightSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.RightSide.Controls.Add(this.FinishTaskButton);
            this.RightSide.Controls.Add(this.panel3);
            this.RightSide.Controls.Add(this.Project_Id);
            this.RightSide.Controls.Add(this.NameActual);
            this.RightSide.Controls.Add(this.DescriptionActual);
            this.RightSide.Controls.Add(this.panel1);
            this.RightSide.Controls.Add(this.Description_Label);
            this.RightSide.Controls.Add(this.NewProjectNameActual);
            this.RightSide.Controls.Add(this.Name_Label);
            this.RightSide.Controls.Add(this.label12);
            this.RightSide.Controls.Add(this.iconButton3);
            this.RightSide.Controls.Add(this.label11);
            this.RightSide.Controls.Add(this.iconButton2);
            this.RightSide.Controls.Add(this.NewProjectDescriptionActual);
            this.RightSide.Controls.Add(this.iconButton1);
            this.RightSide.Controls.Add(this.label10);
            this.RightSide.Location = new System.Drawing.Point(748, 0);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(405, 663);
            this.RightSide.TabIndex = 1;
            // 
            // FinishTaskButton
            // 
            this.FinishTaskButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FinishTaskButton.FlatAppearance.BorderSize = 0;
            this.FinishTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishTaskButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FinishTaskButton.ForeColor = System.Drawing.Color.White;
            this.FinishTaskButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.FinishTaskButton.IconColor = System.Drawing.Color.White;
            this.FinishTaskButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FinishTaskButton.IconSize = 20;
            this.FinishTaskButton.Location = new System.Drawing.Point(282, 621);
            this.FinishTaskButton.Name = "FinishTaskButton";
            this.FinishTaskButton.Size = new System.Drawing.Size(106, 30);
            this.FinishTaskButton.TabIndex = 44;
            this.FinishTaskButton.Tag = "user_id";
            this.FinishTaskButton.Text = "FINISH";
            this.FinishTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FinishTaskButton.UseVisualStyleBackColor = false;
            this.FinishTaskButton.Click += new System.EventHandler(this.FinishProjectButtonClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(0, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 17);
            this.panel3.TabIndex = 38;
            // 
            // Project_Id
            // 
            this.Project_Id.AutoSize = true;
            this.Project_Id.BackColor = System.Drawing.Color.Transparent;
            this.Project_Id.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Project_Id.Location = new System.Drawing.Point(443, 101);
            this.Project_Id.Name = "Project_Id";
            this.Project_Id.Size = new System.Drawing.Size(0, 15);
            this.Project_Id.TabIndex = 37;
            this.Project_Id.Visible = false;
            // 
            // NameActual
            // 
            this.NameActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NameActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameActual.ForeColor = System.Drawing.Color.White;
            this.NameActual.Location = new System.Drawing.Point(12, 415);
            this.NameActual.Name = "NameActual";
            this.NameActual.Size = new System.Drawing.Size(376, 16);
            this.NameActual.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 54);
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
            // NewProjectNameActual
            // 
            this.NewProjectNameActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NewProjectNameActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewProjectNameActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProjectNameActual.ForeColor = System.Drawing.Color.White;
            this.NewProjectNameActual.Location = new System.Drawing.Point(13, 101);
            this.NewProjectNameActual.Name = "NewProjectNameActual";
            this.NewProjectNameActual.Size = new System.Drawing.Size(376, 16);
            this.NewProjectNameActual.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 149);
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
            this.label11.Location = new System.Drawing.Point(13, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Description";
            // 
            // NewProjectDescriptionActual
            // 
            this.NewProjectDescriptionActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NewProjectDescriptionActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewProjectDescriptionActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewProjectDescriptionActual.ForeColor = System.Drawing.Color.White;
            this.NewProjectDescriptionActual.Location = new System.Drawing.Point(13, 169);
            this.NewProjectDescriptionActual.Margin = new System.Windows.Forms.Padding(5);
            this.NewProjectDescriptionActual.Name = "NewProjectDescriptionActual";
            this.NewProjectDescriptionActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NewProjectDescriptionActual.Size = new System.Drawing.Size(376, 136);
            this.NewProjectDescriptionActual.TabIndex = 22;
            this.NewProjectDescriptionActual.Text = "";
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
            this.iconButton1.Location = new System.Drawing.Point(89, 313);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(232, 30);
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
            this.label10.Location = new System.Drawing.Point(13, 69);
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
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDatatable)).EndInit();
            this.TopLabel.ResumeLayout(false);
            this.TopLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.RightSide.ResumeLayout(false);
            this.RightSide.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LeftSide;
        private Panel RightSide;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label Description_Label;
        private Label Name_Label;
        private TextBox NewProjectNameActual;
        private Label label12;
        private Label label11;
        private RichTextBox NewProjectDescriptionActual;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label10;
        private RichTextBox DescriptionActual;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label1;
        private TextBox NameActual;
        private Label Project_Id;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label Projects;
        private DataGridView ProjectsDatatable;
        private Panel TopLabel;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton FinishTaskButton;
    }
}