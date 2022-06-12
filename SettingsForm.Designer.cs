namespace test
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.NewListButton = new System.Windows.Forms.Button();
            this.DeletedButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ButtonsBoxPanel = new System.Windows.Forms.Panel();
            this.CoutingButton = new System.Windows.Forms.Button();
            this.TextBoxesPanel = new System.Windows.Forms.Panel();
            this.CarBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.UpdateBox = new System.Windows.Forms.PictureBox();
            this.ClearBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.CarsBox = new System.Windows.Forms.PictureBox();
            this.orderBox = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.CarData = new System.Windows.Forms.PictureBox();
            this.UserData = new System.Windows.Forms.PictureBox();
            this.AvtorizationPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.PasswordUserBox = new System.Windows.Forms.TextBox();
            this.LoginUserBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.ChangeBoxLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ButtonsBoxPanel.SuspendLayout();
            this.TextBoxesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            this.AvtorizationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(167, 47);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.MaxLength = 30;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(147, 23);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.Location = new System.Drawing.Point(10, 47);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(147, 23);
            this.SurnameBox.TabIndex = 3;
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
            this.SurnameBox.Enter += new System.EventHandler(this.SurnameBox_Enter);
            this.SurnameBox.Leave += new System.EventHandler(this.SurnameBox_Leave);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberBox.Location = new System.Drawing.Point(167, 11);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(147, 23);
            this.NumberBox.TabIndex = 6;
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.NumberBox.Enter += new System.EventHandler(this.NumberBox_Enter);
            this.NumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            this.NumberBox.Leave += new System.EventHandler(this.NumberBox_Leave);
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityBox.Location = new System.Drawing.Point(10, 117);
            this.CityBox.Margin = new System.Windows.Forms.Padding(2);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(147, 23);
            this.CityBox.TabIndex = 7;
            this.CityBox.TextChanged += new System.EventHandler(this.CityBox_TextChanged);
            this.CityBox.Enter += new System.EventHandler(this.CityBox_Enter);
            this.CityBox.Leave += new System.EventHandler(this.CityBox_Leave);
            // 
            // NewListButton
            // 
            this.NewListButton.Enabled = false;
            this.NewListButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewListButton.Location = new System.Drawing.Point(45, 10);
            this.NewListButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewListButton.Name = "NewListButton";
            this.NewListButton.Size = new System.Drawing.Size(117, 24);
            this.NewListButton.TabIndex = 9;
            this.NewListButton.Text = "Новая запись";
            this.NewListButton.UseVisualStyleBackColor = true;
            this.NewListButton.Click += new System.EventHandler(this.NewListButton_Click);
            // 
            // DeletedButton
            // 
            this.DeletedButton.Enabled = false;
            this.DeletedButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletedButton.Location = new System.Drawing.Point(45, 38);
            this.DeletedButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeletedButton.Name = "DeletedButton";
            this.DeletedButton.Size = new System.Drawing.Size(117, 23);
            this.DeletedButton.TabIndex = 10;
            this.DeletedButton.Text = "Удалить";
            this.DeletedButton.UseVisualStyleBackColor = true;
            this.DeletedButton.Click += new System.EventHandler(this.DeletedButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Enabled = false;
            this.ChangeButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(45, 65);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(117, 24);
            this.ChangeButton.TabIndex = 11;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(45, 93);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ButtonsBoxPanel
            // 
            this.ButtonsBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsBoxPanel.Controls.Add(this.CoutingButton);
            this.ButtonsBoxPanel.Controls.Add(this.DeletedButton);
            this.ButtonsBoxPanel.Controls.Add(this.NewListButton);
            this.ButtonsBoxPanel.Controls.Add(this.SaveButton);
            this.ButtonsBoxPanel.Controls.Add(this.ChangeButton);
            this.ButtonsBoxPanel.Location = new System.Drawing.Point(642, 388);
            this.ButtonsBoxPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsBoxPanel.Name = "ButtonsBoxPanel";
            this.ButtonsBoxPanel.Size = new System.Drawing.Size(209, 159);
            this.ButtonsBoxPanel.TabIndex = 14;
            // 
            // CoutingButton
            // 
            this.CoutingButton.Enabled = false;
            this.CoutingButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoutingButton.Location = new System.Drawing.Point(45, 120);
            this.CoutingButton.Margin = new System.Windows.Forms.Padding(2);
            this.CoutingButton.Name = "CoutingButton";
            this.CoutingButton.Size = new System.Drawing.Size(117, 23);
            this.CoutingButton.TabIndex = 13;
            this.CoutingButton.Text = "Подсчет";
            this.CoutingButton.UseVisualStyleBackColor = true;
            this.CoutingButton.Click += new System.EventHandler(this.CoutingButton_Click);
            // 
            // TextBoxesPanel
            // 
            this.TextBoxesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxesPanel.Controls.Add(this.CarBox);
            this.TextBoxesPanel.Controls.Add(this.YearBox);
            this.TextBoxesPanel.Controls.Add(this.PasswordBox);
            this.TextBoxesPanel.Controls.Add(this.LoginBox);
            this.TextBoxesPanel.Controls.Add(this.CityBox);
            this.TextBoxesPanel.Controls.Add(this.NameBox);
            this.TextBoxesPanel.Controls.Add(this.NumberBox);
            this.TextBoxesPanel.Controls.Add(this.IdBox);
            this.TextBoxesPanel.Controls.Add(this.SurnameBox);
            this.TextBoxesPanel.Enabled = false;
            this.TextBoxesPanel.Location = new System.Drawing.Point(56, 388);
            this.TextBoxesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxesPanel.Name = "TextBoxesPanel";
            this.TextBoxesPanel.Size = new System.Drawing.Size(325, 159);
            this.TextBoxesPanel.TabIndex = 15;
            // 
            // CarBox
            // 
            this.CarBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarBox.Location = new System.Drawing.Point(167, 11);
            this.CarBox.Margin = new System.Windows.Forms.Padding(2);
            this.CarBox.MaxLength = 30;
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(147, 23);
            this.CarBox.TabIndex = 13;
            this.CarBox.Visible = false;
            this.CarBox.Enter += new System.EventHandler(this.CarBox_Enter);
            this.CarBox.Leave += new System.EventHandler(this.CarBox_Leave);
            // 
            // YearBox
            // 
            this.YearBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearBox.Location = new System.Drawing.Point(10, 47);
            this.YearBox.Margin = new System.Windows.Forms.Padding(2);
            this.YearBox.MaxLength = 4;
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(147, 23);
            this.YearBox.TabIndex = 12;
            this.YearBox.Visible = false;
            this.YearBox.Enter += new System.EventHandler(this.YearBox_Enter);
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearBox_KeyPress);
            this.YearBox.Leave += new System.EventHandler(this.YearBox_Leave);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(167, 82);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.MaxLength = 30;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(147, 23);
            this.PasswordBox.TabIndex = 11;
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(10, 82);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBox.MaxLength = 30;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(147, 23);
            this.LoginBox.TabIndex = 10;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdBox.Location = new System.Drawing.Point(10, 11);
            this.IdBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdBox.MaxLength = 11;
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(147, 23);
            this.IdBox.TabIndex = 8;
            this.IdBox.Enter += new System.EventHandler(this.IdBox_Enter);
            this.IdBox.Leave += new System.EventHandler(this.IdBox_Leave);
            // 
            // SearchBox
            // 
            this.SearchBox.Enabled = false;
            this.SearchBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.Location = new System.Drawing.Point(680, 2);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.MaxLength = 30;
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(209, 36);
            this.SearchBox.TabIndex = 16;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // UpdateBox
            // 
            this.UpdateBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBox.Enabled = false;
            this.UpdateBox.Image = ((System.Drawing.Image)(resources.GetObject("UpdateBox.Image")));
            this.UpdateBox.Location = new System.Drawing.Point(597, 2);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(37, 36);
            this.UpdateBox.TabIndex = 18;
            this.UpdateBox.TabStop = false;
            this.UpdateBox.Click += new System.EventHandler(this.UpdateBox_Click);
            // 
            // ClearBox
            // 
            this.ClearBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBox.Enabled = false;
            this.ClearBox.ErrorImage = null;
            this.ClearBox.Image = ((System.Drawing.Image)(resources.GetObject("ClearBox.Image")));
            this.ClearBox.Location = new System.Drawing.Point(555, 2);
            this.ClearBox.Name = "ClearBox";
            this.ClearBox.Size = new System.Drawing.Size(39, 36);
            this.ClearBox.TabIndex = 19;
            this.ClearBox.TabStop = false;
            this.ClearBox.Click += new System.EventHandler(this.ClearBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogoPanel.Controls.Add(this.CarsBox);
            this.LogoPanel.Controls.Add(this.orderBox);
            this.LogoPanel.Controls.Add(this.ExitBox);
            this.LogoPanel.Controls.Add(this.SearchBox);
            this.LogoPanel.Controls.Add(this.CarData);
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.UserData);
            this.LogoPanel.Controls.Add(this.UpdateBox);
            this.LogoPanel.Controls.Add(this.ClearBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(920, 41);
            this.LogoPanel.TabIndex = 21;
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseDown);
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseMove);
            // 
            // CarsBox
            // 
            this.CarsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarsBox.Image = ((System.Drawing.Image)(resources.GetObject("CarsBox.Image")));
            this.CarsBox.Location = new System.Drawing.Point(86, 2);
            this.CarsBox.Name = "CarsBox";
            this.CarsBox.Size = new System.Drawing.Size(38, 39);
            this.CarsBox.TabIndex = 27;
            this.CarsBox.TabStop = false;
            this.CarsBox.Visible = false;
            this.CarsBox.Click += new System.EventHandler(this.CarsBox_Click);
            // 
            // orderBox
            // 
            this.orderBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBox.Image = ((System.Drawing.Image)(resources.GetObject("orderBox.Image")));
            this.orderBox.Location = new System.Drawing.Point(124, 2);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(32, 37);
            this.orderBox.TabIndex = 26;
            this.orderBox.TabStop = false;
            this.orderBox.Visible = false;
            this.orderBox.Click += new System.EventHandler(this.orderBox_Click);
            // 
            // ExitBox
            // 
            this.ExitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(898, 0);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(22, 23);
            this.ExitBox.TabIndex = 25;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // CarData
            // 
            this.CarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarData.Image = ((System.Drawing.Image)(resources.GetObject("CarData.Image")));
            this.CarData.Location = new System.Drawing.Point(45, 2);
            this.CarData.Name = "CarData";
            this.CarData.Size = new System.Drawing.Size(40, 37);
            this.CarData.TabIndex = 24;
            this.CarData.TabStop = false;
            this.CarData.Visible = false;
            this.CarData.Click += new System.EventHandler(this.CarData_Click);
            // 
            // UserData
            // 
            this.UserData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserData.Image = ((System.Drawing.Image)(resources.GetObject("UserData.Image")));
            this.UserData.Location = new System.Drawing.Point(3, 2);
            this.UserData.Name = "UserData";
            this.UserData.Size = new System.Drawing.Size(40, 37);
            this.UserData.TabIndex = 23;
            this.UserData.TabStop = false;
            this.UserData.Visible = false;
            this.UserData.Click += new System.EventHandler(this.UserData_Click);
            // 
            // AvtorizationPanel
            // 
            this.AvtorizationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvtorizationPanel.Controls.Add(this.ExitLabel);
            this.AvtorizationPanel.Controls.Add(this.AuthorizationButton);
            this.AvtorizationPanel.Controls.Add(this.PasswordUserBox);
            this.AvtorizationPanel.Controls.Add(this.LoginUserBox);
            this.AvtorizationPanel.Location = new System.Drawing.Point(404, 388);
            this.AvtorizationPanel.Name = "AvtorizationPanel";
            this.AvtorizationPanel.Size = new System.Drawing.Size(199, 159);
            this.AvtorizationPanel.TabIndex = 22;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Location = new System.Drawing.Point(43, 138);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(103, 13);
            this.ExitLabel.TabIndex = 14;
            this.ExitLabel.Text = "Выйти из аккаунта";
            this.ExitLabel.Visible = false;
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationButton.Location = new System.Drawing.Point(35, 101);
            this.AuthorizationButton.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(117, 31);
            this.AuthorizationButton.TabIndex = 13;
            this.AuthorizationButton.Text = "Авторизация";
            this.AuthorizationButton.UseVisualStyleBackColor = true;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // PasswordUserBox
            // 
            this.PasswordUserBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordUserBox.Location = new System.Drawing.Point(23, 60);
            this.PasswordUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordUserBox.MaxLength = 30;
            this.PasswordUserBox.Name = "PasswordUserBox";
            this.PasswordUserBox.Size = new System.Drawing.Size(147, 23);
            this.PasswordUserBox.TabIndex = 10;
            this.PasswordUserBox.Enter += new System.EventHandler(this.PasswordUserBox_Enter);
            this.PasswordUserBox.Leave += new System.EventHandler(this.PasswordUserBox_Leave);
            // 
            // LoginUserBox
            // 
            this.LoginUserBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUserBox.Location = new System.Drawing.Point(23, 13);
            this.LoginUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginUserBox.MaxLength = 30;
            this.LoginUserBox.Name = "LoginUserBox";
            this.LoginUserBox.Size = new System.Drawing.Size(147, 23);
            this.LoginUserBox.TabIndex = 9;
            this.LoginUserBox.Enter += new System.EventHandler(this.LoginUserBox_Enter);
            this.LoginUserBox.Leave += new System.EventHandler(this.LoginUserBox_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(0, 42);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(920, 329);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLabel.Location = new System.Drawing.Point(650, 375);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(193, 20);
            this.ChangeLabel.TabIndex = 26;
            this.ChangeLabel.Text = "Редактирование записей";
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationLabel.Location = new System.Drawing.Point(451, 376);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(102, 20);
            this.AuthorizationLabel.TabIndex = 14;
            this.AuthorizationLabel.Text = "Авторизация";
            // 
            // ChangeBoxLabel
            // 
            this.ChangeBoxLabel.AutoSize = true;
            this.ChangeBoxLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBoxLabel.Location = new System.Drawing.Point(120, 373);
            this.ChangeBoxLabel.Name = "ChangeBoxLabel";
            this.ChangeBoxLabel.Size = new System.Drawing.Size(192, 22);
            this.ChangeBoxLabel.TabIndex = 27;
            this.ChangeBoxLabel.Text = "Редактирование полей";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.Location = new System.Drawing.Point(-2, 42);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(920, 329);
            this.dataGridView3.TabIndex = 28;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.Location = new System.Drawing.Point(0, 42);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(920, 329);
            this.dataGridView4.TabIndex = 29;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 556);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.ChangeBoxLabel);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.AvtorizationPanel);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.TextBoxesPanel);
            this.Controls.Add(this.ButtonsBoxPanel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование такси";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ButtonsBoxPanel.ResumeLayout(false);
            this.TextBoxesPanel.ResumeLayout(false);
            this.TextBoxesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            this.AvtorizationPanel.ResumeLayout(false);
            this.AvtorizationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Button NewListButton;
        private System.Windows.Forms.Button DeletedButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel ButtonsBoxPanel;
        private System.Windows.Forms.Panel TextBoxesPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox UpdateBox;
        private System.Windows.Forms.PictureBox ClearBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel AvtorizationPanel;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.TextBox PasswordUserBox;
        private System.Windows.Forms.TextBox LoginUserBox;
        private System.Windows.Forms.PictureBox UserData;
        private System.Windows.Forms.PictureBox CarData;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Label ChangeBoxLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox orderBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.PictureBox CarsBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox CarBox;
        private System.Windows.Forms.Button CoutingButton;
    }
}