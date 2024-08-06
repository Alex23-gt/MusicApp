using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace MusicApp_Redesign
{
    public partial class User_Form_Search : Form
    {
        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = new SqlDataAdapter();//адаптер, для выполнения SQL-запросов
        private SqlCommand command = new SqlCommand();//выбор SQL-команд
        //таблицы для сохранения результатов SQL-запроса
        DataTable tableMusic = new DataTable(), 
            tableAlbum = new DataTable(), 
            tableMusician = new DataTable(),
            tableThematicPlaylist = new DataTable(),
            tableUserPlaylist = new DataTable(),
            tableBufferMusic = new DataTable(),
            tableBufferAlbum = new DataTable(),
            tableBufferMusician = new DataTable(),
            tableBufferThematicPlaylist = new DataTable(),
            tableBufferUserPlaylist = new DataTable();
        string queryString;//строка для запросов
        private Database db;
        private Rating rc;
        public User_Form_Search()
        {
            InitializeComponent();
            db = new Database();
            rc = new Rating();
        }

        private void User_Form_Search_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
            command.Connection = sqlConnection;

            //заполнение таблицы с музыкой
            queryString = $"SELECT Track_Name AS Название, Nickname AS Исполнитель, Genre AS Жанр FROM Music_Track " +
                $"INNER JOIN Musician ON Music_Track.ID_Musician = Musician.ID_Musician";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableMusic);
            dgv_Music.DataSource = tableMusic;

            //заполнение таблицы альбомов
            queryString = $"SELECT Name_Album AS Название, Nickname AS Артист FROM Album " +
                $"INNER JOIN Musician ON Album.ID_Musician = Musician.ID_Musician";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableAlbum);
            dgv_Album.DataSource = tableAlbum;

            //заполнение таблицы исполнителей
            queryString = $"SELECT Nickname AS Исполнитель FROM Musician";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableMusician);
            dgv_Musician.DataSource = tableMusician;

            //заполнение таблицы тематических плейлистов
            queryString = $"SELECT Thematic_Playlist_Name AS Название, Prevailing_Genre AS 'Преобладаемый жанр' FROM Thematic_Playlist";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableThematicPlaylist);
            dgv_ThematicPlaylist.DataSource = tableThematicPlaylist;

            //заполнение таблицы пользовательских плейлистов
            queryString = $"SELECT Login AS Пользователь FROM User_Playlist " +
                $"INNER JOIN User_Info ON User_Info.ID_User = User_Playlist.ID_User " +
                $"WHERE ID_User_Playlist != {UserData.userID} AND Number_Of_Tracks IS NOT NULL";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableUserPlaylist);
            dgv_UserPlaylist.DataSource = tableUserPlaylist;
        }

        private void dgv_ThematicPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableBufferThematicPlaylist.Clear();//очистка буфера
            if (e.RowIndex >= 0)
            {
                label_ThematicPlaylistInfo.Visible = true;
                DataGridViewRow row = dgv_ThematicPlaylist.Rows[e.RowIndex];
                string thematicName = row.Cells[0].Value.ToString();
                string thematicGenre = row.Cells[1].Value.ToString();
                queryString = $"SELECT Thematic_Playlist_Name, Prevailing_Genre, Number_Of_Tracks, Total_Time, ID_Thematic_Playlist FROM Thematic_Playlist " +
                    $"WHERE Thematic_Playlist_Name = '{thematicName}' AND Prevailing_Genre = '{thematicGenre}'";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableBufferThematicPlaylist);

                label1_ThematicPlaylist_Name.Text = tableBufferThematicPlaylist.Rows[0][0].ToString();
                label1_ThematicPlaylist_Genre.Text = tableBufferThematicPlaylist.Rows[0][1].ToString();
                label1_ThematicPlaylist_NumberOfTracks.Text = tableBufferThematicPlaylist.Rows[0][2].ToString();
                label1_ThematicPlaylist_TotalTime.Text = tableBufferThematicPlaylist.Rows[0][3].ToString();
            }
        }

        private void textBox_Filter_ThematicPlaylist_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox_Filter_ThematicPlaylist.SelectedIndex)
            {
                case 0:
                    (dgv_ThematicPlaylist.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{textBox_Filter_ThematicPlaylist.Text}%'";
                    break;
                case 1:
                    (dgv_ThematicPlaylist.DataSource as DataTable).DefaultView.RowFilter = $"Преобладаемый жанр LIKE '%{textBox_Filter_ThematicPlaylist.Text}%'";
                    break;
            }
        }

        private void textBox_Filter_UserPlaylist_TextChanged(object sender, EventArgs e)
        {
            (dgv_UserPlaylist.DataSource as DataTable).DefaultView.RowFilter = $"Пользователь LIKE '%{textBox_Filter_UserPlaylist.Text}%'";
        }

        private void dgv_UserPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableBufferUserPlaylist.Clear();//очистка буфера
            if (e.RowIndex >= 0)
            {
                label_UserPlaylistInfo.Visible = true;
                DataGridViewRow row = dgv_UserPlaylist.Rows[e.RowIndex];
                string userPlaylistName = row.Cells[0].Value.ToString();
                queryString = $"SELECT Login, Prevailing_Genre, Number_Of_Tracks, Total_Time FROM User_Playlist " +
                    $"INNER JOIN User_Info ON User_Playlist.ID_User = User_Info.ID_User " +
                    $"WHERE Login = '{userPlaylistName}'";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableBufferUserPlaylist);

                label1_UserPlaylist_Name.Text = tableBufferUserPlaylist.Rows[0][0].ToString();
                label1_UserPlaylist_Genre.Text = tableBufferUserPlaylist.Rows[0][1].ToString();
                label1_UserPlaylist_NumberOfTracks.Text = tableBufferUserPlaylist.Rows[0][2].ToString();
                label1_UserPlaylist_TotalTime.Text = tableBufferUserPlaylist.Rows[0][3].ToString();
            }
        }

        private void dgv_Album_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TrackList.queryTracks = $"EXEC TracksInAlbum '{tableBufferAlbum.Rows[0][0]}'";
            TrackList.welcome = $"Треки в альбоме {tableBufferAlbum.Rows[0][0]}";
            TrackList Obj = new TrackList();
            Obj.ShowDialog();
        }

        private void dgv_Musician_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TrackList.queryTracks = $"EXEC TracksOfMusician '{tableBufferMusician.Rows[0][0]}'";
            TrackList.welcome = $"Треки исполнителя {tableBufferMusician.Rows[0][0]}";
            TrackList Obj = new TrackList();
            Obj.ShowDialog();
        }

        private void dgv_ThematicPlaylist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TrackList.queryTracks = $"EXEC TracksInThematicPlaylist '{tableBufferThematicPlaylist.Rows[0][0]}'";
            TrackList.welcome = $"Треки в плейлисте {tableBufferThematicPlaylist.Rows[0][0]}";
            TrackList Obj = new TrackList();
            Obj.ShowDialog();
        }

        private void button_MakeRating_Click(object sender, EventArgs e)
        {
            Make_Rating.idTrack = tableBufferMusic.Rows[0][7].ToString();
            Make_Rating Obj = new Make_Rating();
            Obj.ShowDialog();
        }

        private void button_RatingPrediction_Click(object sender, EventArgs e)
        {
            var mlContext = new MLContext();

            (IDataView trainingDataView, IDataView testDataView) = rc.LoadData(mlContext);
            ITransformer model = rc.BuildAndTrainModel(mlContext, trainingDataView);
            rc.EvaluateModel(mlContext, testDataView, model);
            MessageBox.Show(rc.UseModelForSinglePrediction(mlContext, model, float.Parse(UserData.userID), float.Parse(tableBufferMusic.Rows[0][7].ToString())));
        }

        private void dgv_UserPlaylist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TrackList.queryTracks = $"EXEC TracksInUserPlaylist '{tableBufferUserPlaylist.Rows[0][0]}'";
            TrackList.welcome = $"Треки в плейлисте пользователя {tableBufferUserPlaylist.Rows[0][0]}";
            TrackList Obj = new TrackList();
            Obj.ShowDialog();
        }

        //фильтрация треков
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

        private void textBox_Filter_Musician_TextChanged(object sender, EventArgs e)
        {
            (dgv_Musician.DataSource as DataTable).DefaultView.RowFilter = $"Исполнитель LIKE '%{textBox_Filter_Musician.Text}%'";
        }

        private void dgv_Musician_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableBufferMusician.Clear();//очистка буфера
            if (e.RowIndex >= 0)
            {
                label_MusicianInfo.Visible = true;
                DataGridViewRow row = dgv_Musician.Rows[e.RowIndex];
                string musicianName = row.Cells[0].Value.ToString();
                queryString = $"SELECT Nickname, Country, Date_of_birth, Sex FROM Musician " +
                    $"INNER JOIN Subscription ON Subscription.ID_Subscription = Musician.ID_Subscription " +
                    $"INNER JOIN User_Info ON Subscription.ID_User = User_Info.ID_User " +
                    $"WHERE Nickname = '{musicianName}'";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableBufferMusician);

                label1_Musician_Nickname.Text = tableBufferMusician.Rows[0][0].ToString();
                label1_Musician_Country.Text = tableBufferMusician.Rows[0][1].ToString();
                label1_Musician_DateOfBirth.Text = DateTime.Parse(tableBufferMusician.Rows[0][2].ToString()).ToString("dd.MM.yyy");
                label1_Musician_Sex.Text = tableBufferMusician.Rows[0][3].ToString();
            }
        }

        private void dgv_Album_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableBufferAlbum.Clear();//очистка буфера
            if (e.RowIndex >= 0)
            {
                label_AlbumInfo.Visible = true;
                DataGridViewRow row = dgv_Album.Rows[e.RowIndex];
                string albumName = row.Cells[0].Value.ToString();
                string albumMusician = row.Cells[1].Value.ToString();
                queryString = $"SELECT Name_Album, Nickname, Release_Date, Number_of_Tracks, Total_Time, ID_Album FROM Album " +
                    $"INNER JOIN Musician ON Album.ID_Musician = Musician.ID_Musician " +
                    $"WHERE Name_Album = '{albumName}' AND Nickname = '{albumMusician}'";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableBufferAlbum);

                label1_Album_Name.Text = tableBufferAlbum.Rows[0][0].ToString();
                label1_Album_Musician.Text = tableBufferAlbum.Rows[0][1].ToString();
                label1_Album_ReleaseDate.Text = DateTime.Parse(tableBufferAlbum.Rows[0][2].ToString()).ToString("dd.MM.yyy");
                label1_Album_NumberOfTracks.Text = tableBufferAlbum.Rows[0][3].ToString();
                label1_Album_TotalTime.Text = tableBufferAlbum.Rows[0][4].ToString();
            }
        }

        //вывод информации о треке при нажании на ячейку
        private void dgv_Music_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableBufferMusic.Clear();//очистка буфера
            if (e.RowIndex >= 0)
            {
                button_Add.Visible = true;
                button_Listen.Visible = true;
                button_MakeRating.Visible = true;
                button_RatingPrediction.Visible = true;
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
        private void button_Add_Click(object sender, EventArgs e)
        {
            queryString = $"INSERT INTO Connection_T_UP VALUES({Convert.ToInt32(tableBufferMusic.Rows[0][7])}, {UserData.userID})";
            command.CommandText = queryString;
            command.ExecuteNonQuery();
            MessageBox.Show("Композиция добавлена в ваш список", "Действие выполнено");
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            queryString = $"UPDATE Music_Track SET Auditions_Number = Auditions_Number + 1 WHERE ID_Music_Track = {Convert.ToInt32(tableBufferMusic.Rows[0][7])}";
            command.CommandText = queryString;
            command.ExecuteNonQuery();
            MessageBox.Show("Композиция прослушана", "Действие выполнено");
        }

        private void textBox_Filter_Album_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox_Filter_Album.SelectedIndex)
            {
                case 0:
                    (dgv_Album.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{textBox_Filter_Album.Text}%'";
                    break;
                case 1:
                    (dgv_Album.DataSource as DataTable).DefaultView.RowFilter = $"Артист LIKE '%{textBox_Filter_Album.Text}%'";
                    break;
            }
        }
        private void User_Form_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
