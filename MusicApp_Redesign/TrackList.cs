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
    public partial class TrackList : Form
    {
        public static string welcome = "", queryTracks = $"", queryString = $"";

        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = new SqlDataAdapter();//адаптер, для выполнения SQL-запросов
        private SqlCommand command = new SqlCommand();//выбор SQL-команд
        DataTable tableMusic = new DataTable(),
            tableID = new DataTable();
        private Database db;

        //для перемещаения формы
        bool dragging = false;//перетаскивается ли форма в данный момент
        Point dragCursorPoint;//текущая позиция курсора
        Point dragFormPoint;//текущая позиция формы
        public TrackList()
        {
            InitializeComponent();
            db = new Database();
        }

        private void TrackList_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
            label_Welcome.Text = welcome;
            command.Connection = sqlConnection;
            command.CommandText = queryTracks;
            adapter.SelectCommand = command;
            adapter.Fill(tableMusic);
            dgv_TrackList.DataSource = tableMusic;
        }

        private void TrackList_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void panel_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;//форма перетаскивается
            dragCursorPoint = Cursor.Position;//позиция курсора
            dragFormPoint = this.Location;//позиция формы
        }

        private void panel_Menu_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;//форма не перетаскивается
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            queryString = $"UPDATE Music_Track SET Auditions_Number = Auditions_Number + 1 WHERE ID_Music_Track = {Convert.ToInt32(tableID.Rows[0][0])}";
            command.CommandText = queryString;
            command.ExecuteNonQuery();
            MessageBox.Show("Композиция прослушана", "Действие выполнено");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            queryString = $"INSERT INTO Connection_T_UP VALUES({Convert.ToInt32(tableID.Rows[0][0])}, {UserData.userID})";
            command.CommandText = queryString;
            command.ExecuteNonQuery();
            MessageBox.Show("Композиция добавлена в ваш список", "Действие выполнено");
        }

        private void dgv_TrackList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button_Listen.Visible = true;
                button_Add.Visible = true;
                button_MakeRating.Visible = true;
                button_RatingPrediction.Visible = true;
                DataGridViewRow row = dgv_TrackList.Rows[e.RowIndex];
                string trackName = row.Cells[0].Value.ToString();
                string trackMusician = row.Cells[1].Value.ToString();
                queryString = $"SELECT ID_Music_Track FROM Music_Track " +
                    $"INNER JOIN Musician ON Musician.ID_Musician = Music_Track.ID_Musician " +
                    $"WHERE Track_Name = '{trackName}' AND Nickname = '{trackMusician}'";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableID);
            }
        }

        private void panel_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)//если форма перетаскивается
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));//разница между стартовой позицией курсора и текущей
                this.Location = Point.Add(dragFormPoint, new Size(dif));//перемещение формы на вычисленную разницу
            }
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            Close();
        }
    }
}
