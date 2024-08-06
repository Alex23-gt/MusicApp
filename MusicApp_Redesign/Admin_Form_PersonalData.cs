using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp_Redesign
{
    public partial class Admin_Form_PersonalData : Form
    {
        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = new SqlDataAdapter();//адаптер, для выполнения SQL-запросов
        private SqlCommand command = new SqlCommand();//выбор SQL-команд
        //таблицы для сохранения результатов SQL-запроса
        DataTable tableLogin = new DataTable();
        string queryString;//строка для запросов
        string[] domens = { "@gmail.com", "@mail.ru" };
        private Database db;
        public Admin_Form_PersonalData()
        {
            InitializeComponent();
            db = new Database();
        }

        private void checkBox_OldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_OldPassword.Checked)
            {
                textBox_User_OldPassword.PasswordChar = '*';//скрытие, если отсутствует галочка
            }
            else
            {
                textBox_User_OldPassword.PasswordChar = '\0';//показ, если стоит галочка
            }
        }

        private void checkBox_NewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_NewPassword.Checked)
            {
                textBox_User_NewPassword.PasswordChar = '*';//скрытие, если отсутствует галочка
            }
            else
            {
                textBox_User_NewPassword.PasswordChar = '\0';//показ, если стоит галочка
            }
        }

        private void Admin_Form_PersonalData_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
            command.Connection = sqlConnection;

            textBox_User_Login.PlaceholderText = UserData.userName;
            textBox_User_Email.PlaceholderText = UserData.userEmail;
            textBox_User_DateOfBirth.Text = UserData.userDateOfBirth;
            textBox_User_Country.PlaceholderText = UserData.userCountry;
            textBox_User_Sex.PlaceholderText = UserData.userSex;
        }

        private void button_ChangeUserDate_Click(object sender, EventArgs e)
        {
            if (textBox_User_Email.Text == "" || textBox_User_Country.Text == "" || textBox_User_DateOfBirth.Text == "" || textBox_User_Sex.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Уведомление");
            }
            else if (textBox_User_Sex.Text != "Мужской" && textBox_User_Sex.Text != "Женский")
            {
                MessageBox.Show("Пол указан неверно", "Уведомление");
            }
            else if (textBox_User_Email.Text.Contains(domens[0]) || textBox_User_Email.Text.Contains(domens[1]))
            {
                queryString = $"UPDATE User_Info SET Email = '{textBox_User_Email.Text}', " +
                    $"Country = '{textBox_User_Country.Text}', " +
                    $"Date_of_birth = '{textBox_User_DateOfBirth.Text}', Sex = '{textBox_User_Sex.Text}' WHERE ID_User = {Convert.ToInt32(UserData.userID)}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                UserData.userEmail = textBox_User_Email.Text;
                UserData.userSex = textBox_User_Sex.Text;
                UserData.userCountry = textBox_User_Country.Text;
                UserData.userDateOfBirth = textBox_User_DateOfBirth.Text;

                textBox_User_Email.PlaceholderText = textBox_User_Email.Text;
                textBox_User_Sex.PlaceholderText = textBox_User_Sex.Text;
                textBox_User_Country.PlaceholderText = textBox_User_Country.Text;
                textBox_User_DateOfBirth.Text = textBox_User_DateOfBirth.Text;

                MessageBox.Show("Данные изменены", "Уведомление");

                textBox_User_Email.Text = "";
                textBox_User_Sex.Text = "";
                textBox_User_Country.Text = "";
                textBox_User_DateOfBirth.Text = "";
            }
            else
            {
                MessageBox.Show("Почта не содержит допустимого домена", "Уведомление");
            }
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            if (textBox_User_OldPassword.Text == "" || textBox_User_NewPasswordRep.Text == "" || textBox_User_NewPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else if (textBox_User_OldPassword.Text != UserData.userPassword)
            {
                MessageBox.Show("Старый пароль введен неверно", "Уведомление");
            }
            else if (textBox_User_OldPassword.Text == textBox_User_NewPassword.Text)
            {
                MessageBox.Show("Новый пароль не должен совпадать со старым", "Уведомление");
            }
            else if (textBox_User_NewPassword.Text != textBox_User_NewPasswordRep.Text)
            {
                MessageBox.Show("Новый пароль повторно введен не корректно", "Уведомление");
            }
            else
            {
                queryString = $"UPDATE User_Info SET Password = '{textBox_User_NewPassword.Text}' " +
                    $"WHERE ID_User = {Convert.ToInt32(UserData.userID)}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                UserData.userPassword = textBox_User_NewPassword.Text;

                MessageBox.Show("Пароль изменен", "Уведомление");

                textBox_User_OldPassword.Text = "";
                textBox_User_NewPassword.Text = "";
                textBox_User_NewPasswordRep.Text = "";
            }
        }

        private void button_User_LoginChange_Click(object sender, EventArgs e)
        {
            if (textBox_User_Login.Text == "")
            {
                MessageBox.Show("Заполните поле логина", "Уведомление");
            }
            else
            {
                queryString = $"SELECT Login From User_Info WHERE Login = '{textBox_User_Login.Text}' AND ID_User != {Convert.ToInt32(UserData.userID)}";
                command.CommandText = queryString;
                adapter.Fill(tableLogin);
                if (tableLogin.Rows.Count == 0)
                {
                    queryString = $"UPDATE User_Info SET Login = '{textBox_User_Login.Text}' WHERE ID_User = {Convert.ToInt32(UserData.userID)}";
                    command.CommandText = queryString;
                    command.ExecuteNonQuery();

                    UserData.userName = textBox_User_Login.Text;

                    MessageBox.Show("Логин был изменен", "Уведомление");

                    textBox_User_Login.Text = "";
                    textBox_User_Login.PlaceholderText = UserData.userName;
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует", "Уведомление");
                }
            }
        }
    }
}
