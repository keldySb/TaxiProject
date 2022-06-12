using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class NewListForm : Form
    {
        Point LastPoint;
        public NewListForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoginBox.Text = "Введите логин"; LoginBox.ForeColor = Color.Gray;
            NameBox.Text = "Введите имя"; NameBox.ForeColor = Color.Gray;
            SurnameBox.Text = "Введите фамилию"; SurnameBox.ForeColor = Color.Gray;
            CityBox.Text = "Введите город"; CityBox.ForeColor = Color.Gray;
            PasswordBox.Text = "Введите пароль"; PasswordBox.ForeColor = Color.Gray;
            NumberBox.Text = "Введите номер"; NumberBox.ForeColor = Color.Gray;
        }
        private void CreateNewList_Click(object sender, EventArgs e)
        {
            if (UserButtonList.Enabled == false)
            {
                if (LoginBox.Text == "Введите логин" || PasswordBox.Text == "Введите пароль" || NameBox.Text == "Введите имя" || SurnameBox.Text == "Введите фамилию" || NumberBox.Text == "Введите номер" || CityBox.Text == "Введите город")
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    DB db = new DB();
                    db.OpenConnection();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `login`, `password`, `city`, `number`) VALUES (@Name, @Surname, @Login, @Password, @City, @Number)", db.GetConnection());
                    command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginBox.Text;
                    command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameBox.Text;
                    command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = SurnameBox.Text;
                    command.Parameters.Add("@Number", MySqlDbType.Int64).Value = NumberBox.Text;
                    command.Parameters.Add("@City", MySqlDbType.VarChar).Value = CityBox.Text;
                    command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = PasswordBox.Text;

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно создана!"); this.Close();

                    db.CloseConnection();
                }
            }

            if (DriverButtonList.Enabled == false)
            { 
                if (LoginBox.Text == "Введите логин" || PasswordBox.Text == "Введите пароль" || NameBox.Text == "Введите имя" || SurnameBox.Text == "Введите фамилию" || NumberBox.Text == "Введите номер" || CityBox.Text == "Введите город")
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    DB db = new DB();
                    db.OpenConnection();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `driver` (`name`, `surname`, `login`, `password`, `city`, `number`) VALUES (@Name, @Surname, @Login, @Password, @City, @Number)", db.GetConnection());
                    command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginBox.Text;
                    command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameBox.Text;
                    command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = SurnameBox.Text;
                    command.Parameters.Add("@Number", MySqlDbType.Int64).Value = NumberBox.Text;
                    command.Parameters.Add("@City", MySqlDbType.VarChar).Value = CityBox.Text;
                    command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = PasswordBox.Text;

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно создана!"); this.Close();

                    db.CloseConnection();
                }
            }
        
        }
        private void NameBox_Enter(object sender, EventArgs e)
        {
            if (NameBox.Text == "Введите имя")
            {
                NameBox.Text = "";
                NameBox.ForeColor = Color.Black;
            }
        }
        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.Text = "Введите имя";
                NameBox.ForeColor = Color.Gray;
            }
        }
        private void SurnameBox_Enter(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "Введите фамилию")
            {
                SurnameBox.Text = "";
                SurnameBox.ForeColor = Color.Black;
            }
        }
        private void SurnameBox_Leave(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "")
            {
                SurnameBox.Text = "Введите фамилию";
                SurnameBox.ForeColor = Color.Gray;
            }
        }
        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }
        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Введите логин";
                LoginBox.ForeColor = Color.Gray;
            }
        }
        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Введите пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
        }
        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.ForeColor = Color.Gray;
            }
        }
        private void NumberBox_Enter(object sender, EventArgs e)
        {
            if (NumberBox.Text == "Введите номер")
            {
                NumberBox.Text = "";
                NumberBox.ForeColor = Color.Black;
            }
        }
        private void NumberBox_Leave(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                NumberBox.Text = "Введите номер";
                NumberBox.ForeColor = Color.Gray;
            }
        }
        private void CityBox_Enter(object sender, EventArgs e)
        {
            if (CityBox.Text == "Введите город")
            {
                CityBox.Text = "";
                CityBox.ForeColor = Color.Black;
            }
        }
        private void CityBox_Leave(object sender, EventArgs e)
        {
            if (CityBox.Text == "")
            {
                CityBox.Text = "Введите город";
                CityBox.ForeColor = Color.Gray;
            }
        }
        private void DriverButtonList_Click(object sender, EventArgs e)
        {
            TextBoxPanel.Enabled = true;
            DriverButtonList.Enabled = false;
            UserButtonList.Enabled = true;
        }
        private void UserButtonList_Click(object sender, EventArgs e)
        {
            TextBoxPanel.Enabled = true;
            DriverButtonList.Enabled = true;
            UserButtonList.Enabled = false;
        }
        private void NameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void NameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void NewListForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void NewListForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void CloseFormBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
