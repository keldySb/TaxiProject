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
    enum RowState 
    {
        Existed,
        New,
        Deleted,
        Modifield,
        ModifieldNew
    }

    public partial class SettingsForm : Form
    {
        int selectedRow;
        Point LastPoint;
        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CityBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void NumberBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SurnameBox_Enter(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "Фамилия")
            {
                SurnameBox.Text = "";
                SurnameBox.ForeColor = Color.Gray;
            }
        }
        private void SurnameBox_Leave(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "")
            {
                SurnameBox.Text = "Фамилия";
                SurnameBox.ForeColor = Color.Gray;
            }
        }
        private void NumberBox_Enter(object sender, EventArgs e)
        {
            if (NumberBox.Text == "Номер")
            {
                NumberBox.Text = "";
                NumberBox.ForeColor = Color.Black;
            }
        }
        private void NumberBox_Leave(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                NumberBox.Text = "Номер";
                NumberBox.ForeColor = Color.Gray;
            }
        }
        private void CityBox_Enter(object sender, EventArgs e)
        {
            if (CityBox.Text == "Город")
            {
                CityBox.Text = "";
                CityBox.ForeColor = Color.Gray;
            }
        }
        private void CityBox_Leave(object sender, EventArgs e)
        {
            if (CityBox.Text == "")
            {
                CityBox.Text = "Город";
                CityBox.ForeColor = Color.Gray;
            }
        }
        private void YearBox_Leave(object sender, EventArgs e)
        {
            if (YearBox.Text == "")
            {
                YearBox.Text = "Год машины";
                YearBox.ForeColor = Color.Gray;
            }
        }
        private void YearBox_Enter(object sender, EventArgs e)
        {
            if (YearBox.Text == "Год машины")
            {
                YearBox.Text = "";
                YearBox.ForeColor = Color.Black;
            }
        }
        private void NameBox_Enter(object sender, EventArgs e)
        {
            if (NameBox.Text == "Имя")
            {
                NameBox.Text = "";
                NameBox.ForeColor = Color.Gray;
            }
        }
        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.Text = "Имя";
                NameBox.ForeColor = Color.Gray;
            }
        }
        private void IdBox_Enter(object sender, EventArgs e)
        {
            if (IdBox.Text == "ID")
            {
                IdBox.Text = "";
                IdBox.ForeColor = Color.Black;
            }
        }
        private void IdBox_Leave(object sender, EventArgs e)
        {
            if (IdBox.Text == "")
            {
                IdBox.Text = "ID";
                IdBox.ForeColor = Color.Gray;
            }
        }
        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Логин";
                LoginBox.ForeColor = Color.Gray;
            }
        }
        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }
        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {

                PasswordBox.Text = "Пароль";
                PasswordBox.ForeColor = Color.Gray;
            }
        }
        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
            
        }
        private void CarBox_Enter(object sender, EventArgs e)
        {
            if (CarBox.Text == "Номер машины")
            {
                CarBox.Text = "";
                CarBox.ForeColor = Color.Black;
            }
        }
        private void CarBox_Leave(object sender, EventArgs e)
        {
            if (CarBox.Text == "")
            {
                CarBox.Text = "Номер машины";
                CarBox.ForeColor = Color.Gray;
            }
        }
        private void LoginUserBox_Enter(object sender, EventArgs e)
        {
            if (LoginUserBox.Text == "Введите логин")
            {
                LoginUserBox.Text = "";
                LoginUserBox.ForeColor = Color.Black;
            }
        }
        private void LoginUserBox_Leave(object sender, EventArgs e)
        {
            if (LoginUserBox.Text == "")
            {
                LoginUserBox.Text = "Введите логин";
                LoginUserBox.ForeColor = Color.Gray;
            }
        }
        private void PasswordUserBox_Enter(object sender, EventArgs e)
        {
            if (PasswordUserBox.Text == "Введите пароль")
            {
                PasswordUserBox.Text = "";
                PasswordUserBox.ForeColor = Color.Black;
                PasswordUserBox.PasswordChar = '*';
            }
        }
        private void PasswordUserBox_Leave(object sender, EventArgs e)
        {
            if (PasswordUserBox.Text == "")
            {
                PasswordUserBox.Text = "Введите пароль";
                PasswordUserBox.ForeColor = Color.Gray;

            }
        }
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Поиск записей")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = Color.Black;
            }
        }
        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "Поиск записей";
                SearchBox.ForeColor = Color.Gray;
            }
        }
        public SettingsForm()
        {
            InitializeComponent();

            IdBox.Text = "ID"; IdBox.ForeColor = Color.Gray;
            SurnameBox.Text = "Фамилия"; SurnameBox.ForeColor = Color.Gray;
            LoginBox.Text = "Логин"; LoginBox.ForeColor = Color.Gray;
            PasswordBox.Text = "Пароль"; PasswordBox.ForeColor = Color.Gray;
            NumberBox.Text = "Номер"; NumberBox.ForeColor = Color.Gray;
            CityBox.Text = "Город"; CityBox.ForeColor = Color.Gray;
            NameBox.Text = "Имя"; NameBox.ForeColor = Color.Gray;
            LoginUserBox.Text = "Введите логин"; LoginUserBox.ForeColor = Color.Gray;
            PasswordUserBox.Text = "Введите пароль"; PasswordUserBox.ForeColor = Color.Gray;
            SearchBox.Text = "Поиск записей"; SearchBox.ForeColor = Color.Gray;
            YearBox.Text = "Год машины"; YearBox.ForeColor = Color.Gray;
            CarBox.Text = "Номер машины"; CarBox.ForeColor = Color.Gray;


            var ToolTip = new ToolTip();
            ToolTip.SetToolTip(UserData, "База данных клиентов");
            ToolTip.SetToolTip(CarData, "База данных водителей");
            ToolTip.SetToolTip(ClearBox, "Очистка полей");
            ToolTip.SetToolTip(UpdateBox, "Обновление полей");
            ToolTip.SetToolTip(ExitBox, "Выход из программы");
            ToolTip.SetToolTip(orderBox, "База данных заказов");
            ToolTip.SetToolTip(CarsBox, "База данных машин");
        }
        private void CreateColumns()
        {
            if (UserData.Enabled == false)
            {
                dataGridView1.Columns.Add("id", "id");
                dataGridView1.Columns.Add("name", "Имя");
                dataGridView1.Columns.Add("surname", "Фамилия");
                dataGridView1.Columns.Add("login", "Логин");
                dataGridView1.Columns.Add("password", "Пароль");
                dataGridView1.Columns.Add("city", "Город");
                dataGridView1.Columns.Add("number", "Номер");
                dataGridView1.Columns.Add("IsNew", String.Empty);
                dataGridView1.Columns[7].Visible = false;
            }
            if (CarData.Enabled == false)
            {
                dataGridView2.Columns.Add("id", "id");
                dataGridView2.Columns.Add("name", "Имя");
                dataGridView2.Columns.Add("surname", "Фамилия");
                dataGridView2.Columns.Add("login", "Логин");
                dataGridView2.Columns.Add("password", "Пароль");
                dataGridView2.Columns.Add("city", "Город");
                dataGridView2.Columns.Add("number", "Номер");
                dataGridView2.Columns.Add("IsNew", String.Empty);
                dataGridView2.Columns[7].Visible = false;
            }
            if (orderBox.Enabled == false)
            {
                dataGridView3.Columns.Add("id_client", "id заказа");
                dataGridView3.Columns.Add("id_client", "id клиента");
                dataGridView3.Columns.Add("id_driver", "id водителя");
                dataGridView3.Columns.Add("datetime", "дата");
                dataGridView3.Columns.Add("rate", "оценка");
                dataGridView3.Columns.Add("IsNew", String.Empty);
                dataGridView3.Columns[5].Visible = false;
            }
            if (CarsBox.Enabled == false)
            {
                dataGridView4.Columns.Add("id", "id машины");
                dataGridView4.Columns.Add("name", "название машины");
                dataGridView4.Columns.Add("year", "Год машины");
                dataGridView4.Columns.Add("number", "номер машины");
                dataGridView4.Columns.Add("IsNew", String.Empty);
                dataGridView4.Columns[4].Visible = false;
            }
        }
        private void ReadSingleRow(DataGridView dgv, IDataReader record)
        {
            dgv.Rows.Add(record.GetInt64(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt64(6), RowState.ModifieldNew);
        }
        private void ReadSingleRowDriver(DataGridView dgv, IDataReader recordDriver)
        {
            dgv.Rows.Add(recordDriver.GetInt64(0), recordDriver.GetString(1), recordDriver.GetString(2), recordDriver.GetString(3), recordDriver.GetString(4), recordDriver.GetString(5), recordDriver.GetInt64(6), RowState.ModifieldNew);
        }
        private void ReadSingleRowCar(DataGridView dgv, IDataReader recordCar)
        {
            dgv.Rows.Add(recordCar.GetInt32(0), recordCar.GetString(1), recordCar.GetInt32(2), recordCar.GetString(3), RowState.ModifieldNew);
        }
        private void ReadSingleRowOrder(DataGridView dgv, IDataReader recordOrder)
        {
            dgv.Rows.Add(recordOrder.GetInt32(0), recordOrder.GetInt32(1), recordOrder.GetInt32(2), recordOrder.GetDateTime(3), recordOrder.GetInt32(4), RowState.ModifieldNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            DB db = new DB();

            if (UserData.Enabled == false)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users`",db.GetConnection());

                db.OpenConnection();

                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    ReadSingleRow(dgv, reader);
                }
                reader.Close();

                db.CloseConnection();
            }

            if (CarData.Enabled == false)
            {
                MySqlCommand commandDriver = new MySqlCommand("SELECT * FROM `driver`", db.GetConnection());

                db.OpenConnection();

                MySqlDataReader readerDriver = commandDriver.ExecuteReader();

                while (readerDriver.Read())
                {
                    ReadSingleRowDriver(dgv, readerDriver);
                }
                readerDriver.Close();

                db.CloseConnection();
            }

            if (orderBox.Enabled == false)
            {
                MySqlCommand commandOrder = new MySqlCommand("SELECT * FROM `ordertaxi`", db.GetConnection());

                db.OpenConnection();

                MySqlDataReader readerOrder = commandOrder.ExecuteReader();

                while (readerOrder.Read())
                {
                    ReadSingleRowOrder(dgv, readerOrder);
                }
                readerOrder.Close();

                db.CloseConnection();
            }
            if (CarsBox.Enabled == false)
            {
                MySqlCommand commandCars = new MySqlCommand("SELECT * FROM `car`", db.GetConnection());

                db.OpenConnection();

                MySqlDataReader readerCars = commandCars.ExecuteReader();

                while (readerCars.Read())
                {
                    ReadSingleRowCar(dgv, readerCars);
                }
                readerCars.Close();

                db.CloseConnection();
            }
        }
        private void NewListButton_Click(object sender, EventArgs e)
        {
            NewListForm NLF = new NewListForm();
            NLF.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                IdBox.Text = row.Cells[0].Value.ToString(); IdBox.ForeColor = Color.Black;
                NameBox.Text = row.Cells[1].Value.ToString(); NameBox.ForeColor = Color.Black;
                SurnameBox.Text = row.Cells[2].Value.ToString(); SurnameBox.ForeColor = Color.Black;
                LoginBox.Text = row.Cells[3].Value.ToString(); LoginBox.ForeColor = Color.Black;
                PasswordBox.Text = row.Cells[4].Value.ToString(); PasswordBox.ForeColor = Color.Black;
                CityBox.Text = row.Cells[5].Value.ToString(); CityBox.ForeColor = Color.Black;
                NumberBox.Text = row.Cells[6].Value.ToString(); NumberBox.ForeColor = Color.Black;
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                IdBox.Text = row.Cells[0].Value.ToString(); IdBox.ForeColor = Color.Black;
                NameBox.Text = row.Cells[1].Value.ToString(); NameBox.ForeColor = Color.Black;
                SurnameBox.Text = row.Cells[2].Value.ToString(); SurnameBox.ForeColor = Color.Black;
                LoginBox.Text = row.Cells[3].Value.ToString(); LoginBox.ForeColor = Color.Black;
                PasswordBox.Text = row.Cells[4].Value.ToString(); PasswordBox.ForeColor = Color.Black;
                CityBox.Text = row.Cells[5].Value.ToString(); CityBox.ForeColor = Color.Black;
                NumberBox.Text = row.Cells[6].Value.ToString(); NumberBox.ForeColor = Color.Black;
            }
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedRow];

                IdBox.Text = row.Cells[0].Value.ToString(); IdBox.ForeColor = Color.Black;
                NameBox.Text = row.Cells[1].Value.ToString(); NameBox.ForeColor = Color.Black;
                YearBox.Text = row.Cells[2].Value.ToString(); YearBox.ForeColor = Color.Black;
                CarBox.Text = row.Cells[3].Value.ToString(); CarBox.ForeColor = Color.Black;
            }
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            DB db = new DB();

            if (UserData.Enabled == false)
            {
                MySqlCommand commandUsers = new MySqlCommand("SELECT * FROM `users` WHERE CONCAT(id, name, surname, login, password, city, number) LIKE '%" + SearchBox.Text + "%'", db.GetConnection());

                db.OpenConnection();

                MySqlDataReader readerUsers = commandUsers.ExecuteReader();

                while (readerUsers.Read())
                {
                    ReadSingleRow(dgv, readerUsers);
                }
                readerUsers.Close();

                db.CloseConnection();
            }

            if (CarData.Enabled == false)
            {
                MySqlCommand commandDriver = new MySqlCommand("SELECT * FROM `driver` WHERE CONCAT(id, name, surname, login, password, city, number) LIKE '%" + SearchBox.Text + "%'", db.GetConnection());

                db.OpenConnection();

                MySqlDataReader readerDriver = commandDriver.ExecuteReader();

                while (readerDriver.Read())
                {
                    ReadSingleRowDriver(dgv, readerDriver);
                }
                readerDriver.Close();

                db.CloseConnection();
            }

            if (orderBox.Enabled == false)
            {
                MySqlCommand commandOrder = new MySqlCommand("SELECT * FROM `ordertaxi` WHERE CONCAT(id_order,id_client,id_driver,datetime,rate) LIKE '%" + SearchBox.Text + "%'", db.GetConnection());

                db.OpenConnection();

                MySqlDataReader readerOrder = commandOrder.ExecuteReader();

                while (readerOrder.Read())
                {
                    ReadSingleRowOrder(dgv, readerOrder);
                }
                readerOrder.Close();

                db.CloseConnection();
            }

            if (CarsBox.Enabled == false)
            {
                MySqlCommand commandCar = new MySqlCommand("SELECT * FROM `car` WHERE CONCAT(id, name, year, number) LIKE '%" + SearchBox.Text + "%'", db.GetConnection());

                db.OpenConnection();

                MySqlDataReader readerCar = commandCar.ExecuteReader();

                while (readerCar.Read())
                {
                    ReadSingleRowCar(dgv, readerCar);
                }
                readerCar.Close();

                db.CloseConnection();
            }
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (UserData.Enabled == false)
                Search(dataGridView1);
            if (CarData.Enabled == false)
                Search(dataGridView2);
            if (orderBox.Enabled == false)
                Search(dataGridView3);
            if (CarsBox.Enabled == false)
                Search(dataGridView4);
        }
        private void DeleteRow()
        {
            if (UserData.Enabled == false)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows[index].Visible = false;

                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                    return;
                }

                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
            }

            if (CarData.Enabled == false)
            {
                int index = dataGridView2.CurrentCell.RowIndex;

                dataGridView2.Rows[index].Visible = false;

                if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
                    return;
                }


                dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
            }

            if (CarsBox.Enabled == false)
            {
                int index = dataGridView4.CurrentCell.RowIndex;

                dataGridView4.Rows[index].Visible = false;

                if (dataGridView4.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView4.Rows[index].Cells[4].Value = RowState.Deleted;
                    return;
                }

                dataGridView4.Rows[index].Cells[4].Value = RowState.Deleted;
            }
        }
        private  void UpdateList()
        {
            DB db = new DB();

            if (UserData.Enabled == false)
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                        MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `id` = @id", db.GetConnection());
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                        db.OpenConnection();
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Запись успешно удалена, обновите поле");
                        else
                            MessageBox.Show("Не удалось удалить запись, попробуйте снова");
                        db.CloseConnection();
                    }

                    if (rowState == RowState.Modifield)
                    {
                            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                            var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                            var surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
                            var login = dataGridView1.Rows[index].Cells[3].Value.ToString();
                            var password = dataGridView1.Rows[index].Cells[4].Value.ToString();
                            var city = dataGridView1.Rows[index].Cells[5].Value.ToString();
                            var number = dataGridView1.Rows[index].Cells[6].Value.ToString();

                            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `name` = @name, `surname` = @surname, `login` = @login, `password` = @password, `city` = @city, `number` = @number  WHERE `id` = @id", db.GetConnection());
                            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
                            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                            command.Parameters.Add("@number", MySqlDbType.Int64).Value = number;
                            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

                            db.OpenConnection();
                            if (name == "Имя" || name == "" || surname == "Фамилия" || surname == "" || login == "Логин" || login == "" || password == "Пароль" || password == "" || number == "Номер" || number == "" || city == "Город" || city == "")
                            {
                                MessageBox.Show("Вы ввели слишком короткие данные!");
                                RefreshDataGrid(dataGridView1);
                            } 
                            else
                            {
                                if (command.ExecuteNonQuery() == 1)
                                    MessageBox.Show("Запись успешно изменена");
                                else
                                    MessageBox.Show("Не удалось изменить запись");
                            }
                            db.CloseConnection();   
                    }
                }
            }

            if (CarData.Enabled == false)
            {
                for (int index = 0; index < dataGridView2.Rows.Count; index++)
                {
                    var rowStateDriver = (RowState)dataGridView2.Rows[index].Cells[7].Value;

                    if (rowStateDriver == RowState.Existed)
                        continue;

                    if (rowStateDriver == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                        MySqlCommand command = new MySqlCommand("DELETE FROM `driver` WHERE `id` = @id", db.GetConnection());
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                        db.OpenConnection();
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Запись успешно удалена, обновите поле");
                        else
                            MessageBox.Show("Не удалось удалить запись, попробуйте снова");
                        db.CloseConnection();
                    }

                    if (rowStateDriver == RowState.Modifield)
                    {
                        var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                        var name = dataGridView2.Rows[index].Cells[1].Value.ToString();
                        var surname = dataGridView2.Rows[index].Cells[2].Value.ToString();
                        var login = dataGridView2.Rows[index].Cells[3].Value.ToString();
                        var password = dataGridView2.Rows[index].Cells[4].Value.ToString();
                        var city = dataGridView2.Rows[index].Cells[5].Value.ToString();
                        var number = dataGridView2.Rows[index].Cells[6].Value.ToString();

                        MySqlCommand command = new MySqlCommand("UPDATE `driver` SET `name` = @name, `surname` = @surname, `login` = @login, `password` = @password, `city` = @city, `number` = @number  WHERE `id` = @id", db.GetConnection());
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                        command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
                        command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                        command.Parameters.Add("@number", MySqlDbType.Int64).Value = number;
                        command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

                        db.OpenConnection();
                        if (name == "Имя" || name == "" || surname == "Фамилия" || surname == "" || login == "Логин" || login == "" || password == "Пароль" || password == "" || number == "Номер" || number == "" || city == "Город" || city == "")
                        {
                            MessageBox.Show("Вы ввели слишком короткие данные!");
                            RefreshDataGrid(dataGridView2);
                        }
                        else
                        {
                            if (command.ExecuteNonQuery() == 1)
                                MessageBox.Show("Запись успешно изменена");
                            else
                                MessageBox.Show("Не удалось изменить запись");
                        }

                        db.CloseConnection();
                    }
                }
            }

            if (CarsBox.Enabled == false)
            {
                for (int index = 0; index < dataGridView4.Rows.Count; index++)
                {
                    var rowStateCars = (RowState)dataGridView4.Rows[index].Cells[4].Value;

                    if (rowStateCars == RowState.Existed)
                        continue;

                    if (rowStateCars == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView4.Rows[index].Cells[0].Value);
                        MySqlCommand command = new MySqlCommand("DELETE FROM `car` WHERE `id` = @id", db.GetConnection());
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                        db.OpenConnection();
                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Запись успешно удалена, обновите поле");
                        else
                            MessageBox.Show("Не удалось удалить запись, попробуйте снова");
                        db.CloseConnection();
                    }

                    if (rowStateCars == RowState.Modifield)
                    {
                        var id = dataGridView4.Rows[index].Cells[0].Value.ToString();
                        var name = dataGridView4.Rows[index].Cells[1].Value.ToString();
                        var year = dataGridView4.Rows[index].Cells[2].Value.ToString();
                        var number = dataGridView4.Rows[index].Cells[3].Value.ToString();

                        MySqlCommand command = new MySqlCommand("UPDATE `car` SET `name` = @name, `year` = @year, `number` = @number  WHERE `id` = @id", db.GetConnection());
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                        command.Parameters.Add("@year", MySqlDbType.Int64).Value = year;
                        command.Parameters.Add("@number", MySqlDbType.VarChar).Value = number;


                        db.OpenConnection();

                        if (name == "Имя" || name == "" || year == "Год машины" || year == "" || number == "Номер машины" || number == "")
                        {
                            MessageBox.Show("Вы ввели слишком короткие данные!");
                            RefreshDataGrid(dataGridView4);
                        } else
                        {
                            if (command.ExecuteNonQuery() == 1)
                                MessageBox.Show("Запись успешно изменена");
                            else
                                MessageBox.Show("Не удалось изменить запись");
                        }


                        db.CloseConnection();
                    }
                }
            }
        }
        private void DeletedButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearField();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
                UpdateList();
        }
        private void Change()
        {
            if (UserData.Enabled == false)
            {
                var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                var id = IdBox.Text;
                var number = NumberBox.Text;
                var name = NameBox.Text;
                var surname = SurnameBox.Text;
                var login = LoginBox.Text;
                var password = PasswordBox.Text;
                var city = CityBox.Text;

                if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                        dataGridView1.Rows[selectedRowIndex].SetValues(id, name, surname, login, password, city, number);
                        dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modifield;
                }
            }
            if (CarData.Enabled == false)
            {
                var selectedRowIndexDriver = dataGridView2.CurrentCell.RowIndex;

                var id = IdBox.Text;
                var number = NumberBox.Text;
                var name = NameBox.Text;
                var surname = SurnameBox.Text;
                var login = LoginBox.Text;
                var password = PasswordBox.Text;
                var city = CityBox.Text;

                if (dataGridView2.Rows[selectedRowIndexDriver].Cells[0].Value.ToString() != string.Empty)
                {
                        dataGridView2.Rows[selectedRowIndexDriver].SetValues(id, name, surname, login, password, city, number);
                        dataGridView2.Rows[selectedRowIndexDriver].Cells[7].Value = RowState.Modifield;
                }
            }
            if (CarsBox.Enabled == false)
            {
                var selectedRowIndexCar = dataGridView4.CurrentCell.RowIndex;

                var id = IdBox.Text;
                var name = NameBox.Text;
                var year = YearBox.Text;
                var number = CarBox.Text;

                if (dataGridView4.Rows[selectedRowIndexCar].Cells[0].Value.ToString() != string.Empty)
                {
                        dataGridView4.Rows[selectedRowIndexCar].SetValues(id, name, year, number);
                        dataGridView4.Rows[selectedRowIndexCar].Cells[4].Value = RowState.Modifield;
                }
                  else
                     MessageBox.Show("Перестаньте так делать!");
                }
        }
        private void ClearField()
        {
            IdBox.Text = "ID"; IdBox.ForeColor = Color.Gray;
            NameBox.Text = "Имя"; NameBox.ForeColor = Color.Gray;
            SurnameBox.Text = "Фамилия"; SurnameBox.ForeColor = Color.Gray;
            LoginBox.Text = "Логин"; LoginBox.ForeColor = Color.Gray;
            PasswordBox.Text = "Пароль"; PasswordBox.ForeColor = Color.Gray;
            CityBox.Text = "Город"; CityBox.ForeColor = Color.Gray;
            NumberBox.Text = "Номер"; NumberBox.ForeColor = Color.Gray;
            YearBox.Text = "Год машины"; YearBox.ForeColor = Color.Gray;
            CarBox.Text = "Номер машины"; CarBox.ForeColor = Color.Gray;
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Change();
            ClearField();
        }
        private void UpdateBox_Click(object sender, EventArgs e)
        {
            if (UserData.Enabled == false)
                RefreshDataGrid(dataGridView1);
            if (CarData.Enabled == false)
                RefreshDataGrid(dataGridView2);
            if (CarsBox.Enabled == false)
                RefreshDataGrid(dataGridView4);
        }
        private void ClearBox_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
                if (LoginUserBox.Text == "admin" && PasswordUserBox.Text == "admin")
                {
                    MessageBox.Show("Авторизация прошла успешно!");
                    UserData.Visible = true; CarData.Visible = true; orderBox.Visible = true; CarsBox.Visible = true;
                    LoginUserBox.Enabled = false; PasswordUserBox.Enabled = false; ExitLabel.Visible = true; AuthorizationButton.Enabled = false;
                    SearchBox.Enabled = true; ClearBox.Enabled = true; UpdateBox.Enabled = true;
                    TextBoxesPanel.Enabled = true; IdBox.Enabled = false;
                    NewListButton.Enabled = true; DeletedButton.Enabled = true; ChangeButton.Enabled = true; SaveButton.Enabled = true; CoutingButton.Enabled = true;

                    LoginUserBox.Text = "";
                    PasswordUserBox.Text = "";
                }

        }
        private void UserData_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            dataGridView1.Rows.Clear();  
            int count = this.dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)     
            {
                this.dataGridView1.Columns.RemoveAt(0);
            }
            YearBox.Visible = false;
            LoginBox.Visible = true;
            PasswordBox.Visible = true;
            CityBox.Visible = true;
            SurnameBox.Visible = true;
            CarBox.Visible = false;

            UserData.Enabled = false;
            orderBox.Enabled = true;
            CarsBox.Enabled = true;
            CarData.Enabled = true;

            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            CreateColumns();
            RefreshDataGrid(dataGridView1);
            ClearField();
        }
        private void CarData_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            dataGridView2.Rows.Clear();
            int count = this.dataGridView2.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                this.dataGridView2.Columns.RemoveAt(0);
            }
            YearBox.Visible = false;
            LoginBox.Visible = true;
            PasswordBox.Visible = true;
            CityBox.Visible = true;
            SurnameBox.Visible = true;
            CarBox.Visible = false;

            UserData.Enabled = true;
            CarData.Enabled = false;
            orderBox.Enabled = true;
            CarsBox.Enabled = true;

            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            CreateColumns();
            RefreshDataGrid(dataGridView2); 
            ClearField();
        }
        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SettingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void LogoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вышли из аккаунта");
            ClearField();
            UserData.Visible = false; CarData.Visible = false; CarsBox.Visible = false; orderBox.Visible = false;
            LoginUserBox.Enabled = true; PasswordUserBox.Enabled = true; AuthorizationButton.Enabled = true; ExitLabel.Visible = false;
            SearchBox.Enabled = false; ClearBox.Enabled = false; UpdateBox.Enabled = false;
            TextBoxesPanel.Enabled = false;
            NewListButton.Enabled = false; DeletedButton.Enabled = false; ChangeButton.Enabled = false; SaveButton.Enabled = false;

            if (UserData.Enabled == false)
            {
                dataGridView1.Rows.Clear();
                int count = this.dataGridView1.Columns.Count;
                for (int i = 0; i < count; i++)
                {
                    this.dataGridView1.Columns.RemoveAt(0);
                }
                UserData.Enabled = true;
            }

            if (CarData.Enabled == false)
            {
                dataGridView2.Rows.Clear();
                int count = this.dataGridView2.Columns.Count;
                for (int i = 0; i < count; i++)
                {
                    this.dataGridView2.Columns.RemoveAt(0);
                }
                CarData.Enabled = true;
            }
        }
        private void orderBox_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            int count = this.dataGridView3.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                this.dataGridView3.Columns.RemoveAt(0);
            }
            YearBox.Visible = false;
            LoginBox.Visible = true;
            PasswordBox.Visible = true;
            CityBox.Visible = true;
            SurnameBox.Visible = true;
            CarBox.Visible = false;

            UserData.Enabled = true;
            CarData.Enabled = true;
            orderBox.Enabled = false;
            CarsBox.Enabled = true;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.Visible = true;

            CreateColumns();
            RefreshDataGrid(dataGridView3);
            ClearField();
        }
        private void CarsBox_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            int count = this.dataGridView4.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                this.dataGridView4.Columns.RemoveAt(0);
            }
            LoginBox.Visible = false;
            PasswordBox.Visible = false;
            CityBox.Visible = false;
            SurnameBox.Visible = false;
            YearBox.Visible = true;
            CarBox.Visible = true;

            UserData.Enabled = true;
            CarData.Enabled = true;
            orderBox.Enabled = true;
            CarsBox.Enabled = false;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;

            CreateColumns();
            RefreshDataGrid(dataGridView4);
            ClearField();
        }
        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (number == 13)
            {
                e.Handled = true;
            }
        }
        private void Cout()
        {
            if (UserData.Enabled == false)
            {
                MessageBox.Show("Количество клиентов: " + Convert.ToString(dataGridView1.Rows.Count));
            }
            if (CarData.Enabled == false)
            {
                MessageBox.Show("Количество водителей: " + Convert.ToString(dataGridView2.Rows.Count));
            }
            if (orderBox.Enabled == false)
            {
                MessageBox.Show("Количество заказов: " + Convert.ToString(dataGridView3.Rows.Count));
            }
            if (CarsBox.Enabled == false)
            {
                MessageBox.Show("Количество машин: " + Convert.ToString(dataGridView4.Rows.Count));
            }
        }
        private void CoutingButton_Click(object sender, EventArgs e)
        {
            Cout();
        }
    }
}