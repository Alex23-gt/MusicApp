using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MusicApp_Redesign
{
    public partial class Login_Form : Form
    {
        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = null;//адаптер, для выполнения SQL-запросов
        DataTable table = null;//таблица для сохранения результатов SQL-запроса
        private Database db;

        public Login_Form()
        {
            InitializeComponent();
            db = new Database();
        }

        //кнопка закрытия приложения
        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            Application.Exit();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
        }

        private void button_Registrate_Click(object sender, EventArgs e)
        {
            string login = textBox_NewLogin.Text;//вводимый логин
            string password = textBox_NewPassword.Text;//вводимый пароль
            string repPassword = textBox_NewPasswordRep.Text;

            if (login == "" || password == "" || repPassword == "")
            {
                MessageBox.Show("Заполните все поля для ввода", "Ошибка");//предупреждение при наличии пустых полей
            }
            else if (password == repPassword)//если введенные пароли совпадают
            {
                string queryString = $"SELECT Id_User, Login, Password FROM User_Info WHERE Login = '{login}' AND Password = '{password}'";//проверка на создание повторного пользователя
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                adapter = new SqlDataAdapter();
                table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count != 0)
                {
                    MessageBox.Show("Такой пользователь уже существует", "Ошибка");//предупреждение о том, что логин занят
                }
                else
                {
                    queryString = $"INSERT INTO User_Info(Login, Password, User_Role) VALUES('{login}', '{password}', 'Обычный')";//иначе занесение нового пользователя в бд
                    command = new SqlCommand(queryString, sqlConnection);
                    if (command.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан", "Уведомление");
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт не создан", "Ошибка");//предупреждение об ошибке
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли должны совпадать", "Ошибка");//предупреждение о несовпадении паролей
            }
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            string login = textBox_Login.Text;//вводимый логин
            string password = textBox_Password.Text;//вводимый пароль

            if (login == "" || password == "")
            {
                MessageBox.Show("Заполните все поля для ввода", "Ошибка");//предупреждение при наличии пустых полей
            }
            else
            {
                string queryString = $"SELECT * FROM User_Info WHERE Login = '{login}' AND Password = '{password}'";//поиск пользователя с предполагаемыми данными
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                adapter = new SqlDataAdapter();
                table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)//если такой пользователь найден
                {
                    UserData.userName = login;//сохранение его
                    UserData.userID = table.Rows[0][0].ToString();
                    UserData.userEmail = table.Rows[0][2].ToString();
                    UserData.userCountry = table.Rows[0][3].ToString();
                    UserData.userDateOfBirth = table.Rows[0][4].ToString();
                    UserData.userPassword = table.Rows[0][5].ToString();
                    UserData.isAdmin = table.Rows[0][6].ToString();
                    UserData.userSex = table.Rows[0][7].ToString();

                    switch(UserData.isAdmin)
                    {
                        case ("Администратор"):
                            {
                                Admin_Form Obj = new Admin_Form();
                                Obj.Show();
                                this.Hide();
                                break;
                            }
                        default:
                            {
                                User_Form Obj = new User_Form();
                                Obj.Show();
                                this.Hide();
                                break;
                            }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Неправильный логин пользователя или пароль", "Ошибка");//иначе предупреждение о неправльных вводимых данных
                }
            }
        }

        private void checkBox_Enter_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Enter.Checked)
            {
                textBox_Password.PasswordChar = '*';//скрытие, если отсутствует галочка
            }
            else
            {
                textBox_Password.PasswordChar = '\0';//показ, если стоит галочка
            }
        }

        private void checkBox_Registrate_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Registrate.Checked)
            {
                textBox_NewPassword.PasswordChar = '*';//скрытие, если отсутствует галочка
            }
            else
            {
                textBox_NewPassword.PasswordChar = '\0';//показ, если стоит галочка
            }
        }
    }
}
