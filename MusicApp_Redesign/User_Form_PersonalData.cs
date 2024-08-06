using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace MusicApp_Redesign
{
    public partial class User_Form_PersonalData : Form
    {
        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = new SqlDataAdapter();//адаптер, для выполнения SQL-запросов
        private SqlCommand command = new SqlCommand();//выбор SQL-команд
        //таблицы для сохранения результатов SQL-запроса
        DataTable table = new DataTable(),
            tableLogin = new DataTable(),
            tableNickname = new DataTable(),
            tableSubscriptionID = new DataTable(),
            tableTracksInAlbum = new DataTable(),
            tableBufferMusic = new DataTable();
        string queryString;//строка для запросов
        string[] domens = { "@gmail.com", "@mail.ru" };
        private Database db;
        public User_Form_PersonalData()
        {
            InitializeComponent();
            db = new Database();
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

                textBox_User_Email.Text =  "";
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
            if(textBox_User_OldPassword.Text == "" || textBox_User_NewPasswordRep.Text == "" || textBox_User_NewPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else if(textBox_User_OldPassword.Text != UserData.userPassword)
            {
                MessageBox.Show("Старый пароль введен неверно", "Уведомление");
            }
            else if(textBox_User_OldPassword.Text == textBox_User_NewPassword.Text)
            {
                MessageBox.Show("Новый пароль не должен совпадать со старым", "Уведомление");
            }
            else if(textBox_User_NewPassword.Text != textBox_User_NewPasswordRep.Text)
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

        private void button_Subscription_Update_Click(object sender, EventArgs e)
        {
            if (textBox_Subscription_Update.Text == "")
            {
                MessageBox.Show("Заполните поле", "Уведомление");
            }
            else if (!int.TryParse(textBox_Subscription_Update.Text, out int number))
            {
                MessageBox.Show("Введенный срок не является числом", "Уведомление");
            }
            else
            {
                queryString = $"UPDATE Subscription SET Validity_Period = {Convert.ToInt32(textBox_Subscription_Update.Text)}, " +
                    $"Registration_Date = '{DateTime.Now:dd.MM.yyyy}' WHERE ID_User = {UserData.userID}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Подписка обновлена", "Уведомление");
            }
        }

        private void textBox_Filter_Music_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox_Filter_Music.SelectedIndex)
            {
                case 0:
                    (dgv_Music.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{textBox_Filter_Music.Text}%'";
                    break;
                case 1:
                    (dgv_Music.DataSource as DataTable).DefaultView.RowFilter = $"Исполнитель LIKE '%{textBox_Filter_Music.Text}%'";
                    break;
                case 2:
                    (dgv_Music.DataSource as DataTable).DefaultView.RowFilter = $"Жанр LIKE '%{textBox_Filter_Music.Text}%'";
                    break;
            }
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            queryString = $"UPDATE Music_Track SET Auditions_Number = Auditions_Number + 1 WHERE ID_Music_Track = {Convert.ToInt32(tableBufferMusic.Rows[0][7])}";
            command.CommandText = queryString;
            command.ExecuteNonQuery();
            MessageBox.Show("Композиция прослушана", "Действие выполнено");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            queryString = $"DELETE Music_Track WHERE ID_Music_Track = {Convert.ToInt32(tableBufferMusic.Rows[0][7])}";
            command.CommandText = queryString;
            command.ExecuteNonQuery();
            MessageBox.Show("Композиция удалена", "Уведомление");

            tableTracksInAlbum.Clear();
            queryString = $"SELECT Track_Name AS Название, Nickname AS Исполнитель, Genre AS Жанр FROM Music_Track " +
                $"INNER JOIN Musician ON Music_Track.ID_Musician = Musician.ID_Musician " +
                $"INNER JOIN Connection_T_UP ON Connection_T_UP.ID_Music_Track = Music_Track.ID_Music_Track " +
                $"WHERE ID_User_Playlist = {UserData.userID}";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableTracksInAlbum);
            dgv_Music.DataSource = tableTracksInAlbum;

            button_Listen.Visible = false;
            button_Delete.Visible = false;
        }

        private void dgv_Music_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableBufferMusic.Clear();//очистка буфера
            if (e.RowIndex >= 0)
            {
                button_Delete.Visible = true;
                button_Listen.Visible = true;
                DataGridViewRow row = dgv_Music.Rows[e.RowIndex];
                string trackName = row.Cells[0].Value.ToString();
                string trackMusician = row.Cells[1].Value.ToString();
                queryString = $"SELECT Track_Name, Nickname, Genre, Auditions_Number, Duration, Track_Release_Date, Name_Album, ID_Music_Track FROM Music_Track " +
                    $"INNER JOIN Musician ON Musician.ID_Musician = Music_Track.ID_Musician " +
                    $"INNER JOIN Album ON Album.ID_Album = Music_Track.ID_Album WHERE Track_Name = '{trackName}' AND Nickname = '{trackMusician}'";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableBufferMusic);

                label1_Track_Name.Text = tableBufferMusic.Rows[0][0].ToString();
                label1_Track_Musician.Text = tableBufferMusic.Rows[0][1].ToString();
                label1_Track_Genre.Text = tableBufferMusic.Rows[0][2].ToString();
                label1_Track_Auditions.Text = tableBufferMusic.Rows[0][3].ToString();
                label1_Track_Duration.Text = tableBufferMusic.Rows[0][4].ToString();
                label1_Track_ReleaseDate.Text = DateTime.Parse(tableBufferMusic.Rows[0][5].ToString()).ToString("dd.MM.yyy");
                label1_Track_Album.Text = tableBufferMusic.Rows[0][6].ToString();
            }
        }

        private void button_Subscription_UpdateNickname_Click(object sender, EventArgs e)
        {
            if(textBox_Subscription_UpdateNickname.Text == "")
            {
                MessageBox.Show("Заполните поле", "Уведомление");
            }
            else
            {
                tableNickname.Clear();
                queryString = $"SELECT Nickname FROM Musician WHERE Nickname = '{textBox_Subscription_UpdateNickname.Text}'";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableNickname);
                if(tableNickname.Rows.Count != 0)
                {
                    MessageBox.Show("Такой псевдоним уже занят", "Уведомление");
                }
                else
                {
                    queryString = $"UPDATE Musician SET Nickname = '{textBox_Subscription_UpdateNickname.Text}' WHERE ID_Subscription = {UserData.subscriptionID}";
                    command.CommandText = queryString;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Псевдоним изменен", "Уведомление");
                }
            }
        }

        private void button_AddSubscription_Click(object sender, EventArgs e)
        {
            tableNickname.Clear();
            tableSubscriptionID.Clear();
            queryString = $"SELECT Nickname FROM Musician WHERE Nickname = '{textBox_Subscription_Nickname.Text}'";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableNickname);
            if (textBox_Subscription_ValidityDate.Text == "" || textBox_Subscription_Nickname.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else if (!int.TryParse(textBox_Subscription_ValidityDate.Text, out int number))
            {
                MessageBox.Show("Введенный срок не является числом", "Уведомление");
            }
            else if (tableNickname.Rows.Count != 0)
            {
                MessageBox.Show("Такой псевдоним уже занят", "Уведомление");
            }
            else
            {
                queryString = $"INSERT INTO Subscription VALUES('{DateTime.Now:dd.MM.yyyy}', {Convert.ToInt32(textBox_Subscription_ValidityDate.Text)}, {UserData.userID})";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                queryString = $"SELECT ID_Subscription FROM Subscription WHERE ID_User = {UserData.userID}";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableSubscriptionID);

                queryString = $"INSERT INTO Musician VALUES ('{textBox_Subscription_Nickname.Text}', {Convert.ToInt32(tableSubscriptionID.Rows[0][0])})";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Подписка оформлена", "Уведомдение");

                UserData.isAdmin = "Подписчик";

                groupBox_AddSubscription.Visible = false;
                groupBox_Subscription_Update.Visible = true;
                groupBox_Subscription_UpdateNickname.Visible = true;
            }
        }

        private void button_User_LoginChange_Click(object sender, EventArgs e)
        {
            if(textBox_User_Login.Text == "")
            {
                MessageBox.Show("Заполните поле логина", "Уведомление");
            }
            else
            {
                queryString = $"SELECT Login From User_Info WHERE Login = '{textBox_User_Login.Text}' AND ID_User != {Convert.ToInt32(UserData.userID)}";
                command.CommandText = queryString;
                adapter.Fill(tableLogin);
                if(tableLogin.Rows.Count == 0)
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

        private void User_Form_PersonalData_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
            command.Connection = sqlConnection;

            textBox_User_Login.PlaceholderText = UserData.userName;
            textBox_User_Email.PlaceholderText = UserData.userEmail;
            textBox_User_DateOfBirth.Text = UserData.userDateOfBirth;
            textBox_User_Country.PlaceholderText = UserData.userCountry;
            textBox_User_Sex.PlaceholderText = UserData.userSex;

            queryString = $"SELECT Track_Name AS Название, Nickname AS Исполнитель, Genre AS Жанр FROM Music_Track " +
                $"INNER JOIN Musician ON Music_Track.ID_Musician = Musician.ID_Musician " +
                $"INNER JOIN Connection_T_UP ON Connection_T_UP.ID_Music_Track = Music_Track.ID_Music_Track " +
                $"WHERE ID_User_Playlist = {UserData.userID}";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableTracksInAlbum);
            dgv_Music.DataSource = tableTracksInAlbum;

            switch (UserData.isAdmin)
            {
                case ("Обычный"):
                    groupBox_User_Subscrption.Visible = true;
                    label1_User_IdSubscription.Text = "Нет подписки";
                    groupBox_Subscription_UpdateNickname.Visible = false;
                    groupBox_AddSubscription.Visible = true;
                    groupBox_Subscription_Update.Visible = false;
                    break;
                case ("Подписчик"):
                    groupBox_User_Subscrption.Visible = true;
                    queryString = $"SELECT ID_Subscription, Registration_Date, Validity_Period FROM Subscription WHERE ID_User = {Convert.ToInt32(UserData.userID)}";
                    command.CommandText = queryString;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    UserData.subscriptionID = table.Rows[0][0].ToString();
                    UserData.subscriptionRegistrationDate = DateTime.Parse(table.Rows[0][1].ToString()).ToString("dd.MM.yyyy");
                    UserData.subscriptionValidityPeriod = table.Rows[0][2].ToString();

                    label1_User_IdSubscription.Text = UserData.subscriptionID;
                    label1_User_SubscriptionRegistrationDate.Text = UserData.subscriptionRegistrationDate;
                    label1_User_SubscriptionValidityPeriod.Text = UserData.subscriptionValidityPeriod;

                    groupBox_Subscription_UpdateNickname.Visible = true;
                    groupBox_AddSubscription.Visible = false;
                    groupBox_Subscription_Update.Visible = true;
                    break;
            }
        }
    }
}
