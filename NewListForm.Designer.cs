namespace test
{
    partial class NewListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewListForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.CreateNewList = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UserButtonList = new System.Windows.Forms.Button();
            this.DriverButtonList = new System.Windows.Forms.Button();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.CloseFormBox = new System.Windows.Forms.PictureBox();
            this.TextBoxPanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(17, 12);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.MaxLength = 30;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(133, 23);
            this.NameBox.TabIndex = 0;
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(17, 56);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBox.MaxLength = 30;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(133, 23);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberBox.Location = new System.Drawing.Point(17, 101);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumberBox.MaxLength = 11;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(133, 23);
            this.NumberBox.TabIndex = 2;
            this.NumberBox.Enter += new System.EventHandler(this.NumberBox_Enter);
            this.NumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            this.NumberBox.Leave += new System.EventHandler(this.NumberBox_Leave);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.Location = new System.Drawing.Point(214, 12);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameBox.MaxLength = 30;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(133, 23);
            this.SurnameBox.TabIndex = 3;
            this.SurnameBox.Enter += new System.EventHandler(this.SurnameBox_Enter);
            this.SurnameBox.Leave += new System.EventHandler(this.SurnameBox_Leave);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(214, 56);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.MaxLength = 30;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(133, 23);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityBox.Location = new System.Drawing.Point(214, 101);
            this.CityBox.Margin = new System.Windows.Forms.Padding(2);
            this.CityBox.MaxLength = 30;
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(133, 23);
            this.CityBox.TabIndex = 5;
            this.CityBox.Enter += new System.EventHandler(this.CityBox_Enter);
            this.CityBox.Leave += new System.EventHandler(this.CityBox_Leave);
            // 
            // CreateNewList
            // 
            this.CreateNewList.Location = new System.Drawing.Point(245, 227);
            this.CreateNewList.Margin = new System.Windows.Forms.Padding(2);
            this.CreateNewList.Name = "CreateNewList";
            this.CreateNewList.Size = new System.Drawing.Size(100, 32);
            this.CreateNewList.TabIndex = 6;
            this.CreateNewList.Text = "Создать";
            this.CreateNewList.UseVisualStyleBackColor = true;
            this.CreateNewList.Click += new System.EventHandler(this.CreateNewList_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(600, 61);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Создание записи";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseDown);
            this.NameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseMove);
            // 
            // UserButtonList
            // 
            this.UserButtonList.Location = new System.Drawing.Point(309, 265);
            this.UserButtonList.Name = "UserButtonList";
            this.UserButtonList.Size = new System.Drawing.Size(94, 23);
            this.UserButtonList.TabIndex = 13;
            this.UserButtonList.Text = "Для клиентов";
            this.UserButtonList.UseVisualStyleBackColor = true;
            this.UserButtonList.Click += new System.EventHandler(this.UserButtonList_Click);
            // 
            // DriverButtonList
            // 
            this.DriverButtonList.Location = new System.Drawing.Point(185, 264);
            this.DriverButtonList.Name = "DriverButtonList";
            this.DriverButtonList.Size = new System.Drawing.Size(94, 23);
            this.DriverButtonList.TabIndex = 14;
            this.DriverButtonList.Text = "Для водителей";
            this.DriverButtonList.UseVisualStyleBackColor = true;
            this.DriverButtonList.Click += new System.EventHandler(this.DriverButtonList_Click);
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.Controls.Add(this.PasswordBox);
            this.TextBoxPanel.Controls.Add(this.NameBox);
            this.TextBoxPanel.Controls.Add(this.LoginBox);
            this.TextBoxPanel.Controls.Add(this.NumberBox);
            this.TextBoxPanel.Controls.Add(this.SurnameBox);
            this.TextBoxPanel.Controls.Add(this.CityBox);
            this.TextBoxPanel.Enabled = false;
            this.TextBoxPanel.Location = new System.Drawing.Point(113, 67);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Size = new System.Drawing.Size(365, 145);
            this.TextBoxPanel.TabIndex = 15;
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NamePanel.Controls.Add(this.CloseFormBox);
            this.NamePanel.Controls.Add(this.NameLabel);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(600, 61);
            this.NamePanel.TabIndex = 16;
            // 
            // CloseFormBox
            // 
            this.CloseFormBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseFormBox.Image = ((System.Drawing.Image)(resources.GetObject("CloseFormBox.Image")));
            this.CloseFormBox.Location = new System.Drawing.Point(580, 0);
            this.CloseFormBox.Name = "CloseFormBox";
            this.CloseFormBox.Size = new System.Drawing.Size(22, 23);
            this.CloseFormBox.TabIndex = 8;
            this.CloseFormBox.TabStop = false;
            this.CloseFormBox.Click += new System.EventHandler(this.CloseFormBox_Click);
            // 
            // NewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 319);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.TextBoxPanel);
            this.Controls.Add(this.DriverButtonList);
            this.Controls.Add(this.UserButtonList);
            this.Controls.Add(this.CreateNewList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewListForm";
            this.Text = "NewListForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewListForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewListForm_MouseMove);
            this.TextBoxPanel.ResumeLayout(false);
            this.TextBoxPanel.PerformLayout();
            this.NamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Button CreateNewList;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button UserButtonList;
        private System.Windows.Forms.Button DriverButtonList;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.PictureBox CloseFormBox;
    }
}