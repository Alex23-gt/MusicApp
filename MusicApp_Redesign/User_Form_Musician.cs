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
    public partial class User_Form_Musician : Form
    {
        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = new SqlDataAdapter();//адаптер, для выполнения SQL-запросов
        private SqlCommand command = new SqlCommand();//выбор SQL-команд
        //таблицы для сохранения результатов SQL-запроса
        DataTable tableMusic = new DataTable(),
            tableAlbum = new DataTable(),
            tableAlbumID = new DataTable(),
            tableNickname = new DataTable(),
            tableSubscription = new DataTable();
        string queryString;//строка для запросов
        private Database db;

        public User_Form_Musician()
        {
            InitializeComponent();
            db = new Database();
        }

        private void User_Form_Musician_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
            command.Connection = sqlConnection;

            queryString = $"SELECT ID_Subscription, Registration_Date, Validity_Period FROM Subscription WHERE ID_User = {Convert.ToInt32(UserData.userID)}";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableSubscription);

            UserData.subscriptionID = tableSubscription.Rows[0][0].ToString();
            UserData.subscriptionRegistrationDate = DateTime.Parse(tableSubscription.Rows[0][1].ToString()).ToString("dd.MM.yyyy");
            UserData.subscriptionValidityPeriod = tableSubscription.Rows[0][2].ToString();

            queryString = $"SELECT ID_Musician, Nickname FROM Musician WHERE ID_Subscription = {Convert.ToInt32(UserData.subscriptionID)}";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableNickname);

            UserData.musicianID = tableNickname.Rows[0][0].ToString();
            UserData.musicianNickname = tableNickname.Rows[0][1].ToString();

            queryString = $"EXEC TracksOfMusician '{UserData.musicianNickname}'";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableMusic);
            dgv_Music.DataSource = tableMusic;

            queryString = $"SELECT Name_Album AS 'Название', Release_Date AS 'Дата выхода', Number_of_Tracks AS 'Количество треков', " +
                $"Total_Time AS 'Длительность' " +
                $"FROM Album WHERE ID_Musician = {UserData.musicianID}";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableAlbum);
            dgv_Album.DataSource = tableAlbum;
        }

        private void User_Form_Musician_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void textBox_Filter_Music_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox_Filter_Music.SelectedIndex)
            {
                case 0:
                    (dgv_Music.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{textBox_Filter_Music.Text}%'";
                    break;
                case 1:
                    (dgv_Music.DataSource as DataTable).DefaultView.RowFilter = $"Жанр LIKE '%{textBox_Filter_Music.Text}%'";
                    break;
            }
        }

        private void button_AddTrack_Click(object sender, EventArgs e)
        {
            if(textBox_Track_Name.Text == "" || textBox_Track_Genre.Text == "" || textBox_Track_Duration.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else
            {
                if(textBox_Track_Album.Text == "")
                {
                    queryString = $"INSERT INTO Music_Track VALUES('{textBox_Track_Name.Text}', '{textBox_Track_Genre.Text}', '{textBox_Track_Duration.Text}', 0, '{DateTime.Now:dd.MM.yyyy}', 4, {UserData.musicianID})";
                    command.CommandText = queryString;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Трек добавлен", "Уведомление");
                }
                else
                {
                    queryString = $"SELECT ID_Album FROM Album WHERE Name_Album = '{textBox_Track_Album.Text}' AND ID_Musician = {UserData.musicianID}";
                    command.CommandText = queryString;
                    adapter.SelectCommand = command;
                    adapter.Fill(tableAlbumID);
                    if(tableAlbumID.Rows.Count == 1)
                    {
                        queryString = $"INSERT INTO Music_Track VALUES('{textBox_Track_Name.Text}', '{textBox_Track_Genre.Text}', '{textBox_Track_Duration.Text}', 0, '{DateTime.Now:dd.MM.yyyy}', {tableAlbumID.Rows[0][0].ToString()}, {UserData.musicianID})";
                        command.CommandText = queryString;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Трек добавлен", "Уведомление");
                    }
                    else
                    {
                        MessageBox.Show("Альбом введен неверно", "Уведомление");
                    }
                }
            }
        }

        private void textBox_Filter_Album_TextChanged(object sender, EventArgs e)
        {
            (dgv_Album.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{textBox_Filter_Album.Text}%'";
        }

        private void button_AddAlbum_Click(object sender, EventArgs e)
        {
            if(textBox_Album_Name.Text == "")
            {
                MessageBox.Show("Заполните поле", "Уведомление");
            }
            else
            {
                queryString = $"INSERT INTO Album(Name_Album, Release_Date, ID_Musician) VALUES('{textBox_Album_Name.Text}', '{DateTime.Now:dd.MM.yyyy}', {UserData.musicianID})";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Альбом добавлен", "Уведомление");
            }
        }
    }
}
