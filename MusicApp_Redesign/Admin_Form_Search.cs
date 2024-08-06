using FontAwesome.Sharp;
using System;
using System.Collections;
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
    public partial class Admin_Form_Search : Form
    {
        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = new SqlDataAdapter();//адаптер, для выполнения SQL-запросов
        private SqlCommand command = new SqlCommand();//выбор SQL-команд
        //таблицы для сохранения результатов SQL-запроса
        DataTable tableMusic = new DataTable(),
            tableAlbum = new DataTable(),
            tableMusicAlbum = new DataTable(),
            tableThematicPlaylist = new DataTable(),
            tableMusicThematicPlaylist = new DataTable(),
            tableUsers = new DataTable();
        string selectedIndex;

        private void button_UpdateTrack_Click(object sender, EventArgs e)
        {
            if (textBox_Track_Name.Text == "" || textBox_Track_Genre.Text == "" || textBox_Track_Duration.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else if (selectedIndex != "")
            {
                queryString = $"UPDATE Music_Track SET Track_Name = '{textBox_Track_Name.Text}', Genre = '{textBox_Track_Genre.Text}', Duration = '{textBox_Track_Duration.Text}' where ID_Music_Track = {Convert.ToInt32(selectedIndex)} ";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Информация о треке изменена", "Уведомление");

                tableMusic.Clear();
                textBox_Track_Name.Text = "";
                textBox_Track_Genre.Text = "";
                textBox_Track_Duration.Text = "";
                selectedIndex = "";
                queryString = $"SELECT ID_Music_Track AS 'ID', Track_Name AS 'Название', Genre AS 'Жанр', Duration AS 'Длительность', " +
                $"Nickname AS 'Исполнитель' FROM Music_Track " +
                $"INNER JOIN Musician ON Musician.ID_Musician = Music_Track.ID_Musician";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableMusic);
                dgv_Music.DataSource = tableMusic;
            }
            else
            {
                MessageBox.Show("Для выбора пользователя нажмите на соответствующую ячейку таблицы", "Уведомление");
            }
        }

        private void button_DeleteTrack_Click(object sender, EventArgs e)
        {
            if (textBox_Track_Name.Text == "" || textBox_Track_Genre.Text == "" || textBox_Track_Duration.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else if (selectedIndex != "")
            {
                queryString = $"DELETE Music_Track WHERE ID_Music_Track = {Convert.ToInt32(selectedIndex)}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Трек удален", "Уведомление");

                tableMusic.Clear();
                textBox_Track_Name.Text = "";
                textBox_Track_Genre.Text = "";
                textBox_Track_Duration.Text = "";
                selectedIndex = "";
                queryString = $"SELECT ID_Music_Track AS 'ID', Track_Name AS 'Название', Genre AS 'Жанр', Duration AS 'Длительность', " +
                $"Nickname AS 'Исполнитель' FROM Music_Track " +
                $"INNER JOIN Musician ON Musician.ID_Musician = Music_Track.ID_Musician";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableMusic);
                dgv_Music.DataSource = tableMusic;
            }
            else
            {
                MessageBox.Show("Для выбора пользователя нажмите на соответствующую ячейку таблицы", "Уведомление");
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

        private void dgv_MusicAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_MusicAlbum.Rows[e.RowIndex];

                textBox_AlbumTrackID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgv_Album_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Album.Rows[e.RowIndex];

                textBox_AlbumID.Text = row.Cells[0].Value.ToString();
                textBox_ChangeAlbum_ID.Text = row.Cells[0].Value.ToString();
                textBox_ChangeAlbum_Name.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button_AddInAlbum_Click(object sender, EventArgs e)
        {
            if (textBox_AlbumID.Text == "" || textBox_AlbumTrackID.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else
            {
                queryString = $"UPDATE Music_Track SET ID_Album = {textBox_AlbumID.Text} WHERE ID_Music_Track = {textBox_AlbumTrackID.Text}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Трек добавлен в альбом", "Уведомление");
            }
        }

        private void button_DeleteFromAlbum_Click(object sender, EventArgs e)
        {
            if (textBox_AlbumTrackID.Text == "")
            {
                MessageBox.Show("Заполните поле", "Уведомление");
            }
            else
            {
                queryString = $"UPDATE Music_Track SET ID_Album = 4 WHERE ID_Music_Track = {textBox_AlbumTrackID.Text}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Трек удален из альбома", "Уведомление");
            }
        }

        private void button_ChangeAlbumName_Click(object sender, EventArgs e)
        {
            if(textBox_ChangeAlbum_ID.Text == "" || textBox_ChangeAlbum_Name.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else
            {
                queryString = $"UPDATE Album SET Name_Album = '{textBox_ChangeAlbum_Name.Text}' WHERE ID_Album = {textBox_ChangeAlbum_ID.Text}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Название альбома изменено", "Уведомление");

                tableAlbum.Clear();
                queryString = $"SELECT ID_Album AS 'ID', Name_Album AS Название, Nickname AS Артист FROM Album " +
                $"INNER JOIN Musician ON Album.ID_Musician = Musician.ID_Musician";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableAlbum);
                dgv_Album.DataSource = tableAlbum;
            }
        }

        private void dgv_MusicThematicPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_MusicThematicPlaylist.Rows[e.RowIndex];

                textBox_TrackThematicPlaylistID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgv_ThematicPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ThematicPlaylist.Rows[e.RowIndex];

                textBox_ThematicPlaylistID.Text = row.Cells[0].Value.ToString();
                textBox_ChangeThematicPlaylist_ID.Text = row.Cells[0].Value.ToString();
                textBox_ChangeThematicPlaylist_Name.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button_AddInPlaylist_Click(object sender, EventArgs e)
        {
            if (textBox_ThematicPlaylistID.Text == "" || textBox_TrackThematicPlaylistID.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else
            {
                queryString = $"INSERT INTO Connection_T_TP(ID_Music_Track, ID_Thematic_Playlist) VALUES({textBox_TrackThematicPlaylistID.Text}, {textBox_ThematicPlaylistID.Text})";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Трек добавлен в плейлист", "Уведомление");
            }
        }

        private void button_DeleteFromPlaylist_Click(object sender, EventArgs e)
        {
            if (textBox_ThematicPlaylistID.Text == "" || textBox_TrackThematicPlaylistID.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else
            {
                queryString = $"DELETE Connection_T_TP WHERE ID_Music_Track = {textBox_TrackThematicPlaylistID.Text} AND ID_Thematic_Playlist = {textBox_ThematicPlaylistID.Text}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Трек удален из плейлист", "Уведомление");
            }
        }

        private void button_ChangePlaylistName_Click(object sender, EventArgs e)
        {
            if (textBox_ChangeThematicPlaylist_Name.Text == "" || textBox_ChangeThematicPlaylist_ID.Text == "")
            {
                MessageBox.Show("Заполните поле для имени плейлиста", "Уведомление");
            }
            else
            {
                queryString = $"UPDATE Thematic_Playlist SET Thematic_Playlist_Name = '{textBox_ChangeThematicPlaylist_Name.Text}' WHERE ID_Thematic_Playlist = {textBox_ChangeThematicPlaylist_ID.Text}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Плейлист изменен", "Уведомление");

                tableThematicPlaylist.Clear();
                queryString = $"SELECT ID_Thematic_Playlist AS 'ID', Thematic_Playlist_Name AS Название, Prevailing_Genre AS 'Преобладаемый жанр' FROM Thematic_Playlist";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableThematicPlaylist);
                dgv_ThematicPlaylist.DataSource = tableThematicPlaylist;
            }
        }

        private void button_CreatePlaylist_Click(object sender, EventArgs e)
        {
            if (textBox_ChangeThematicPlaylist_Name.Text == "")
            {
                MessageBox.Show("Заполните поле для имени плейлиста", "Уведомление");
            }
            else
            {
                queryString = $"INSERT INTO Thematic_Playlist(Thematic_Playlist_Name, Prevailing_Genre) VALUES('{textBox_ChangeThematicPlaylist_Name.Text}', 'Random')";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Плейлист создан", "Уведомление");

                tableThematicPlaylist.Clear();
                queryString = $"SELECT ID_Thematic_Playlist AS 'ID', Thematic_Playlist_Name AS Название, Prevailing_Genre AS 'Преобладаемый жанр' FROM Thematic_Playlist";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableThematicPlaylist);
                dgv_ThematicPlaylist.DataSource = tableThematicPlaylist;
            }
        }

        private void textBox_Filter_User_TextChanged(object sender, EventArgs e)
        {
            (dgv_User.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{textBox_Filter_User.Text}%'";
        }

        private void dgv_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_User.Rows[e.RowIndex];

                selectedIndex = row.Cells[0].Value.ToString();
                textBox_User_Name.Text = row.Cells[1].Value.ToString();
                textBox_User_Role.Text = row.Cells[2].Value.ToString();
            }

            button_User_Delete.Visible = true;
            button_User_Update.Visible = true;
        }

        private void button_User_Update_Click(object sender, EventArgs e)
        {
            if (textBox_User_Name.Text == "" || textBox_User_Role.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else if(textBox_User_Role.Text == "Обычный" || textBox_User_Role.Text == "Подписчик" || textBox_User_Role.Text == "Администратор")
            {
                if (selectedIndex != "")
                {
                    queryString = $"UPDATE User_Info SET Login = '{textBox_User_Name.Text}', User_Role = '{textBox_User_Role.Text}' WHERE ID_User = {selectedIndex}";
                    command.CommandText = queryString;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Информация изменена", "Уведомление");

                    tableUsers.Clear();
                    textBox_User_Name.Text = "";
                    textBox_User_Role.Text = "";
                    selectedIndex = "";
                    queryString = $"SELECT ID_User AS 'ID', Login AS 'Имя', User_Role AS 'Роль' FROM User_Info WHERE ID_User != {UserData.userID}";
                    command.CommandText = queryString;
                    adapter.SelectCommand = command;
                    adapter.Fill(tableUsers);
                    dgv_User.DataSource = tableUsers;
                }
                else
                {
                    MessageBox.Show("Для выбора пользователя нажмите на соответствующую ячейку таблицы", "Уведомление");
                }
            }
            else
            {
                MessageBox.Show("Роль указана неверно", "Уведомление");
            }
        }

        private void button_User_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_User_Name.Text == "" || textBox_User_Role.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление");
            }
            else if (selectedIndex != "")
            {
                queryString = $"DELETE User_Playlist WHERE ID_User = {selectedIndex}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                queryString = $"DELETE User_Info WHERE ID_User = {selectedIndex}";
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                MessageBox.Show("Информация изменена", "Уведомление");

                tableUsers.Clear();
                textBox_User_Name.Text = "";
                textBox_User_Role.Text = "";
                selectedIndex = "";
                queryString = $"SELECT ID_User AS 'ID', Login AS 'Имя', User_Role AS 'Роль' FROM User_Info WHERE ID_User != {UserData.userID}";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableUsers);
                dgv_User.DataSource = tableUsers;
            }
            else
            {
                MessageBox.Show("Для выбора пользователя нажмите на соответствующую ячейку таблицы", "Уведомление");
            }
        }

        private void dgv_Music_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Music.Rows[e.RowIndex];

                selectedIndex = row.Cells[0].Value.ToString();
                textBox_Track_Name.Text = row.Cells[1].Value.ToString();
                textBox_Track_Genre.Text = row.Cells[2].Value.ToString();
                textBox_Track_Duration.Text = row.Cells[3].Value.ToString();
            }

            button_DeleteTrack.Visible = true;
            button_UpdateTrack.Visible = true;
        }

        private void Admin_Form_Search_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
            command.Connection = sqlConnection;

            //заполнение таблицы с музыкой
            queryString = $"SELECT ID_Music_Track AS 'ID', Track_Name AS 'Название', Genre AS 'Жанр', Duration AS 'Длительность', " +
                $"Nickname AS 'Исполнитель' FROM Music_Track " +
                $"INNER JOIN Musician ON Musician.ID_Musician = Music_Track.ID_Musician";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableMusic);
            dgv_Music.DataSource = tableMusic;

            //заполнение таблицы альбомов
            queryString = $"SELECT ID_Album AS 'ID', Name_Album AS Название, Nickname AS Артист FROM Album " +
                $"INNER JOIN Musician ON Album.ID_Musician = Musician.ID_Musician";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableAlbum);
            dgv_Album.DataSource = tableAlbum;

            //заполнение таблицы треков для альбомов
            queryString = $"SELECT ID_Music_Track AS 'ID', Track_Name AS 'Название трека', Nickname AS 'Исполнитель' FROM Music_Track " +
                $"INNER JOIN Musician ON Music_Track.ID_Musician = Musician.ID_Musician";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableMusicAlbum);
            dgv_MusicAlbum.DataSource = tableMusicAlbum;

            //заполнение таблицы тематических плейлистов
            queryString = $"SELECT ID_Thematic_Playlist AS 'ID', Thematic_Playlist_Name AS Название, Prevailing_Genre AS 'Преобладаемый жанр' FROM Thematic_Playlist";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableThematicPlaylist);
            dgv_ThematicPlaylist.DataSource = tableThematicPlaylist;

            //заполнение таблицы треков для тематических плейлистов
            queryString = $"SELECT ID_Music_Track AS 'ID', Track_Name AS 'Название трека', Nickname AS 'Исполнитель' FROM Music_Track " +
                $"INNER JOIN Musician ON Music_Track.ID_Musician = Musician.ID_Musician";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableMusicThematicPlaylist);
            dgv_MusicThematicPlaylist.DataSource = tableMusicThematicPlaylist;

            //заполнение таблицы пользователей
            queryString = $"SELECT ID_User AS 'ID', Login AS 'Имя', User_Role AS 'Роль' FROM User_Info WHERE ID_User != {UserData.userID}";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableUsers);
            dgv_User.DataSource = tableUsers;
        }

        string queryString, queryStringBuffer;//строка для запросов
        private Database db;

        public Admin_Form_Search()
        {
            InitializeComponent();
            db = new Database();
        }
    }
}
