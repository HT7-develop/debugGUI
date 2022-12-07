namespace debugGUI
{
    partial class FormTasks
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LeftSide = new System.Windows.Forms.Panel();
            this.TasksDatatable = new System.Windows.Forms.DataGridView();
            this.CreateBottom = new System.Windows.Forms.Panel();
            this.FinishTaskButton = new FontAwesome.Sharp.IconButton();
            this.ProjectActual = new System.Windows.Forms.RichTextBox();
            this.TitelActual = new System.Windows.Forms.RichTextBox();
            this.GebruikteUrenActual = new System.Windows.Forms.RichTextBox();
            this.DoorLoopTijdActual = new System.Windows.Forms.RichTextBox();
            this.Task_Id = new System.Windows.Forms.Label();
            this.StatusActual = new System.Windows.Forms.RichTextBox();
            this.WerknemerActual = new System.Windows.Forms.RichTextBox();
            this.WerknemerLabek = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BeschrijvingActual = new System.Windows.Forms.RichTextBox();
            this.DeleteTaskButton = new FontAwesome.Sharp.IconButton();
            this.DoorLoopTijd = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.RightSide = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Employee_label = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.NewTaskDLTActual = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.NewTaskProjectActual = new System.Windows.Forms.TextBox();
            this.NewTaskEmployeeActual = new System.Windows.Forms.TextBox();
            this.NewTaskTitelActual = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NewTaskDescriptionActual = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDatatable)).BeginInit();
            this.CreateBottom.SuspendLayout();
            this.RightSide.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.iconButton1.Location = new System.Drawing.Point(116, 614);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(153, 30);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Nieuwe Taak";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.NewTaskButtonClick);
            // 
            // LeftSide
            // 
            this.LeftSide.Controls.Add(this.TasksDatatable);
            this.LeftSide.Controls.Add(this.CreateBottom);
            this.LeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSide.Location = new System.Drawing.Point(0, 0);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(733, 663);
            this.LeftSide.TabIndex = 1;
            // 
            // TasksDatatable
            // 
            this.TasksDatatable.AllowUserToAddRows = false;
            this.TasksDatatable.AllowUserToDeleteRows = false;
            this.TasksDatatable.AllowUserToResizeColumns = false;
            this.TasksDatatable.AllowUserToResizeRows = false;
            this.TasksDatatable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.TasksDatatable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksDatatable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TasksDatatable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDatatable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TasksDatatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDatatable.DefaultCellStyle = dataGridViewCellStyle2;
            this.TasksDatatable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TasksDatatable.Location = new System.Drawing.Point(0, 0);
            this.TasksDatatable.Margin = new System.Windows.Forms.Padding(10);
            this.TasksDatatable.MultiSelect = false;
            this.TasksDatatable.Name = "TasksDatatable";
            this.TasksDatatable.ReadOnly = true;
            this.TasksDatatable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TasksDatatable.RowHeadersVisible = false;
            this.TasksDatatable.RowHeadersWidth = 51;
            this.TasksDatatable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksDatatable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TasksDatatable.RowTemplate.Height = 50;
            this.TasksDatatable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TasksDatatable.ShowCellErrors = false;
            this.TasksDatatable.ShowCellToolTips = false;
            this.TasksDatatable.ShowEditingIcon = false;
            this.TasksDatatable.ShowRowErrors = false;
            this.TasksDatatable.Size = new System.Drawing.Size(733, 324);
            this.TasksDatatable.TabIndex = 0;
            this.TasksDatatable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectTask);
            // 
            // CreateBottom
            // 
            this.CreateBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.CreateBottom.Controls.Add(this.FinishTaskButton);
            this.CreateBottom.Controls.Add(this.ProjectActual);
            this.CreateBottom.Controls.Add(this.TitelActual);
            this.CreateBottom.Controls.Add(this.GebruikteUrenActual);
            this.CreateBottom.Controls.Add(this.DoorLoopTijdActual);
            this.CreateBottom.Controls.Add(this.Task_Id);
            this.CreateBottom.Controls.Add(this.StatusActual);
            this.CreateBottom.Controls.Add(this.WerknemerActual);
            this.CreateBottom.Controls.Add(this.WerknemerLabek);
            this.CreateBottom.Controls.Add(this.label4);
            this.CreateBottom.Controls.Add(this.BeschrijvingActual);
            this.CreateBottom.Controls.Add(this.DeleteTaskButton);
            this.CreateBottom.Controls.Add(this.DoorLoopTijd);
            this.CreateBottom.Controls.Add(this.label14);
            this.CreateBottom.Controls.Add(this.label7);
            this.CreateBottom.Controls.Add(this.label2);
            this.CreateBottom.Controls.Add(this.label1);
            this.CreateBottom.Controls.Add(this.iconButton2);
            this.CreateBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateBottom.Location = new System.Drawing.Point(0, 345);
            this.CreateBottom.Name = "CreateBottom";
            this.CreateBottom.Padding = new System.Windows.Forms.Padding(20);
            this.CreateBottom.Size = new System.Drawing.Size(733, 318);
            this.CreateBottom.TabIndex = 3;
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
            this.FinishTaskButton.Location = new System.Drawing.Point(267, 269);
            this.FinishTaskButton.Name = "FinishTaskButton";
            this.FinishTaskButton.Size = new System.Drawing.Size(106, 30);
            this.FinishTaskButton.TabIndex = 43;
            this.FinishTaskButton.Tag = "user_id";
            this.FinishTaskButton.Text = "FINISH";
            this.FinishTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FinishTaskButton.UseVisualStyleBackColor = false;
            this.FinishTaskButton.Click += new System.EventHandler(this.FinishTaskButtonClick);
            // 
            // ProjectActual
            // 
            this.ProjectActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.ProjectActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectActual.ForeColor = System.Drawing.Color.White;
            this.ProjectActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProjectActual.Location = new System.Drawing.Point(20, 122);
            this.ProjectActual.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectActual.MaxLength = 25;
            this.ProjectActual.Name = "ProjectActual";
            this.ProjectActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ProjectActual.Size = new System.Drawing.Size(110, 21);
            this.ProjectActual.TabIndex = 42;
            this.ProjectActual.Text = "";
            // 
            // TitelActual
            // 
            this.TitelActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.TitelActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitelActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitelActual.ForeColor = System.Drawing.Color.White;
            this.TitelActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TitelActual.Location = new System.Drawing.Point(23, 65);
            this.TitelActual.Margin = new System.Windows.Forms.Padding(0);
            this.TitelActual.MaxLength = 25;
            this.TitelActual.Name = "TitelActual";
            this.TitelActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TitelActual.Size = new System.Drawing.Size(237, 21);
            this.TitelActual.TabIndex = 41;
            this.TitelActual.Text = "";
            // 
            // GebruikteUrenActual
            // 
            this.GebruikteUrenActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.GebruikteUrenActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GebruikteUrenActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GebruikteUrenActual.ForeColor = System.Drawing.Color.White;
            this.GebruikteUrenActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GebruikteUrenActual.Location = new System.Drawing.Point(146, 175);
            this.GebruikteUrenActual.Margin = new System.Windows.Forms.Padding(0);
            this.GebruikteUrenActual.MaxLength = 25;
            this.GebruikteUrenActual.Name = "GebruikteUrenActual";
            this.GebruikteUrenActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.GebruikteUrenActual.Size = new System.Drawing.Size(110, 21);
            this.GebruikteUrenActual.TabIndex = 40;
            this.GebruikteUrenActual.Text = "";
            // 
            // DoorLoopTijdActual
            // 
            this.DoorLoopTijdActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.DoorLoopTijdActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoorLoopTijdActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoorLoopTijdActual.ForeColor = System.Drawing.Color.White;
            this.DoorLoopTijdActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DoorLoopTijdActual.Location = new System.Drawing.Point(19, 176);
            this.DoorLoopTijdActual.Margin = new System.Windows.Forms.Padding(0);
            this.DoorLoopTijdActual.MaxLength = 25;
            this.DoorLoopTijdActual.Name = "DoorLoopTijdActual";
            this.DoorLoopTijdActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DoorLoopTijdActual.Size = new System.Drawing.Size(110, 21);
            this.DoorLoopTijdActual.TabIndex = 39;
            this.DoorLoopTijdActual.Text = "";
            // 
            // Task_Id
            // 
            this.Task_Id.AutoSize = true;
            this.Task_Id.BackColor = System.Drawing.Color.Transparent;
            this.Task_Id.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Task_Id.ForeColor = System.Drawing.Color.White;
            this.Task_Id.Location = new System.Drawing.Point(249, 232);
            this.Task_Id.Name = "Task_Id";
            this.Task_Id.Size = new System.Drawing.Size(0, 20);
            this.Task_Id.TabIndex = 37;
            this.Task_Id.Visible = false;
            // 
            // StatusActual
            // 
            this.StatusActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.StatusActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusActual.ForeColor = System.Drawing.Color.White;
            this.StatusActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StatusActual.Location = new System.Drawing.Point(147, 122);
            this.StatusActual.Margin = new System.Windows.Forms.Padding(0);
            this.StatusActual.MaxLength = 25;
            this.StatusActual.Name = "StatusActual";
            this.StatusActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.StatusActual.Size = new System.Drawing.Size(110, 21);
            this.StatusActual.TabIndex = 36;
            this.StatusActual.Text = "";
            // 
            // WerknemerActual
            // 
            this.WerknemerActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.WerknemerActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WerknemerActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WerknemerActual.ForeColor = System.Drawing.Color.White;
            this.WerknemerActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WerknemerActual.Location = new System.Drawing.Point(20, 232);
            this.WerknemerActual.Margin = new System.Windows.Forms.Padding(0);
            this.WerknemerActual.MaxLength = 25;
            this.WerknemerActual.Name = "WerknemerActual";
            this.WerknemerActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.WerknemerActual.Size = new System.Drawing.Size(110, 21);
            this.WerknemerActual.TabIndex = 38;
            this.WerknemerActual.Text = "";
            // 
            // WerknemerLabek
            // 
            this.WerknemerLabek.AutoSize = true;
            this.WerknemerLabek.BackColor = System.Drawing.Color.Transparent;
            this.WerknemerLabek.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WerknemerLabek.ForeColor = System.Drawing.Color.White;
            this.WerknemerLabek.Location = new System.Drawing.Point(20, 206);
            this.WerknemerLabek.Name = "WerknemerLabek";
            this.WerknemerLabek.Size = new System.Drawing.Size(78, 20);
            this.WerknemerLabek.TabIndex = 34;
            this.WerknemerLabek.Text = "Werknemer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(151, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Status";
            // 
            // BeschrijvingActual
            // 
            this.BeschrijvingActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.BeschrijvingActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeschrijvingActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BeschrijvingActual.ForeColor = System.Drawing.Color.White;
            this.BeschrijvingActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BeschrijvingActual.Location = new System.Drawing.Point(293, 52);
            this.BeschrijvingActual.Margin = new System.Windows.Forms.Padding(5);
            this.BeschrijvingActual.Name = "BeschrijvingActual";
            this.BeschrijvingActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BeschrijvingActual.Size = new System.Drawing.Size(415, 201);
            this.BeschrijvingActual.TabIndex = 31;
            this.BeschrijvingActual.Text = "";
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteTaskButton.FlatAppearance.BorderSize = 0;
            this.DeleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTaskButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteTaskButton.ForeColor = System.Drawing.Color.White;
            this.DeleteTaskButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteTaskButton.IconColor = System.Drawing.Color.White;
            this.DeleteTaskButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteTaskButton.IconSize = 20;
            this.DeleteTaskButton.Location = new System.Drawing.Point(146, 269);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(106, 30);
            this.DeleteTaskButton.TabIndex = 15;
            this.DeleteTaskButton.Tag = "user_id";
            this.DeleteTaskButton.Text = "DELETE";
            this.DeleteTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteTaskButton.UseVisualStyleBackColor = false;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTask);
            // 
            // DoorLoopTijd
            // 
            this.DoorLoopTijd.AutoSize = true;
            this.DoorLoopTijd.BackColor = System.Drawing.Color.Transparent;
            this.DoorLoopTijd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoorLoopTijd.ForeColor = System.Drawing.Color.White;
            this.DoorLoopTijd.Location = new System.Drawing.Point(20, 148);
            this.DoorLoopTijd.Name = "DoorLoopTijd";
            this.DoorLoopTijd.Size = new System.Drawing.Size(95, 20);
            this.DoorLoopTijd.TabIndex = 13;
            this.DoorLoopTijd.Text = "DoorLoopTijd";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(147, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Gebruikte Uren";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Beschrijving";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titel";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(23, 269);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(108, 30);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "UPDATE";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.UpdateTaskButtonClick);
            // 
            // RightSide
            // 
            this.RightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.RightSide.Controls.Add(this.textBox1);
            this.RightSide.Controls.Add(this.label3);
            this.RightSide.Controls.Add(this.panel9);
            this.RightSide.Controls.Add(this.NewTaskDLTActual);
            this.RightSide.Controls.Add(this.label17);
            this.RightSide.Controls.Add(this.NewTaskProjectActual);
            this.RightSide.Controls.Add(this.NewTaskEmployeeActual);
            this.RightSide.Controls.Add(this.NewTaskTitelActual);
            this.RightSide.Controls.Add(this.label12);
            this.RightSide.Controls.Add(this.label11);
            this.RightSide.Controls.Add(this.label8);
            this.RightSide.Controls.Add(this.NewTaskDescriptionActual);
            this.RightSide.Controls.Add(this.label9);
            this.RightSide.Controls.Add(this.iconButton1);
            this.RightSide.Controls.Add(this.label10);
            this.RightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSide.Location = new System.Drawing.Point(756, 0);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(397, 663);
            this.RightSide.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(20, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 16);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Project";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.panel9.Controls.Add(this.Employee_label);
            this.panel9.Controls.Add(this.iconPictureBox3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(397, 53);
            this.panel9.TabIndex = 21;
            // 
            // Employee_label
            // 
            this.Employee_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Employee_label.AutoSize = true;
            this.Employee_label.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Employee_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Employee_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Employee_label.Location = new System.Drawing.Point(52, 9);
            this.Employee_label.Name = "Employee_label";
            this.Employee_label.Size = new System.Drawing.Size(147, 31);
            this.Employee_label.TabIndex = 2;
            this.Employee_label.Text = "Nieuwe Taak";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(14, 9);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 2;
            this.iconPictureBox3.TabStop = false;
            // 
            // NewTaskDLTActual
            // 
            this.NewTaskDLTActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NewTaskDLTActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTaskDLTActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTaskDLTActual.ForeColor = System.Drawing.Color.White;
            this.NewTaskDLTActual.Location = new System.Drawing.Point(20, 306);
            this.NewTaskDLTActual.Margin = new System.Windows.Forms.Padding(10);
            this.NewTaskDLTActual.Name = "NewTaskDLTActual";
            this.NewTaskDLTActual.Size = new System.Drawing.Size(348, 16);
            this.NewTaskDLTActual.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(20, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "DoorLoopTijd";
            // 
            // NewTaskProjectActual
            // 
            this.NewTaskProjectActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NewTaskProjectActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTaskProjectActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTaskProjectActual.ForeColor = System.Drawing.Color.White;
            this.NewTaskProjectActual.Location = new System.Drawing.Point(18, 193);
            this.NewTaskProjectActual.Margin = new System.Windows.Forms.Padding(10);
            this.NewTaskProjectActual.Name = "NewTaskProjectActual";
            this.NewTaskProjectActual.Size = new System.Drawing.Size(348, 16);
            this.NewTaskProjectActual.TabIndex = 16;
            // 
            // NewTaskEmployeeActual
            // 
            this.NewTaskEmployeeActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NewTaskEmployeeActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTaskEmployeeActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTaskEmployeeActual.ForeColor = System.Drawing.Color.White;
            this.NewTaskEmployeeActual.Location = new System.Drawing.Point(18, 135);
            this.NewTaskEmployeeActual.Margin = new System.Windows.Forms.Padding(10);
            this.NewTaskEmployeeActual.Name = "NewTaskEmployeeActual";
            this.NewTaskEmployeeActual.Size = new System.Drawing.Size(348, 16);
            this.NewTaskEmployeeActual.TabIndex = 15;
            // 
            // NewTaskTitelActual
            // 
            this.NewTaskTitelActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NewTaskTitelActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTaskTitelActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTaskTitelActual.ForeColor = System.Drawing.Color.White;
            this.NewTaskTitelActual.Location = new System.Drawing.Point(19, 90);
            this.NewTaskTitelActual.Name = "NewTaskTitelActual";
            this.NewTaskTitelActual.Size = new System.Drawing.Size(348, 16);
            this.NewTaskTitelActual.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(18, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Please provide a description for this task";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Beschrijving";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Project";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewTaskDescriptionActual
            // 
            this.NewTaskDescriptionActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.NewTaskDescriptionActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTaskDescriptionActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewTaskDescriptionActual.ForeColor = System.Drawing.Color.White;
            this.NewTaskDescriptionActual.Location = new System.Drawing.Point(18, 388);
            this.NewTaskDescriptionActual.Margin = new System.Windows.Forms.Padding(5);
            this.NewTaskDescriptionActual.Name = "NewTaskDescriptionActual";
            this.NewTaskDescriptionActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NewTaskDescriptionActual.Size = new System.Drawing.Size(349, 210);
            this.NewTaskDescriptionActual.TabIndex = 1;
            this.NewTaskDescriptionActual.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Werknemer";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Titel";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormTasks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1153, 663);
            this.Controls.Add(this.RightSide);
            this.Controls.Add(this.LeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTasks";
            this.Text = "FormTasks";
            this.LeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TasksDatatable)).EndInit();
            this.CreateBottom.ResumeLayout(false);
            this.CreateBottom.PerformLayout();
            this.RightSide.ResumeLayout(false);
            this.RightSide.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel LeftSide;
        private DataGridView TasksDatatable;
        private Panel RightSide;
        private Label label12;
        private Label label11;
        private Label label8;
        private RichTextBox NewTaskDescriptionActual;
        private Label label9;
        private Label label10;
        private TextBox NewTaskProjectActual;
        private TextBox NewTaskEmployeeActual;
        private TextBox NewTaskTitelActual;
        private TextBox NewTaskDLTActual;
        private Label label17;
        private Panel CreateBottom;
        private FontAwesome.Sharp.IconButton DeleteTaskButton;
        private Label DoorLoopTijd;
        private Label label14;
        private Label label7;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private RichTextBox BeschrijvingActual;
        private Label label4;
        private Label WerknemerLabek;
        private Label Task_Id;
        private RichTextBox ProjectActual;
        private RichTextBox TitelActual;
        private RichTextBox GebruikteUrenActual;
        private RichTextBox DoorLoopTijdActual;
        private RichTextBox StatusActual;
        private RichTextBox WerknemerActual;
        private Panel panel9;
        private Label Employee_label;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconButton FinishTaskButton;
        private TextBox textBox1;
        private Label label3;
    }
}