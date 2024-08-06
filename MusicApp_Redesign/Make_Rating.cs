using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp_Redesign
{
    public partial class Make_Rating : Form
    {
        SqlConnection sqlConnection = null;//переменная, хранящая строку подключения к бд
        SqlDataAdapter adapter = new SqlDataAdapter();//адаптер, для выполнения SQL-запросов
        private SqlCommand command = new SqlCommand();//выбор SQL-команд
        //таблицы для сохранения результатов SQL-запроса
        DataTable tableCheck = new DataTable(),
            tableRatings = new DataTable();
        bool flag = true;
        public static string idTrack = "";
        string queryString, queryStringBuffer;//строка для запросов
        private Database db;

        static string DataTableToCsv(DataTable dataTable)
        {
            StringBuilder csvBuilder = new StringBuilder();

            // Write the column headers
            foreach (DataColumn column in dataTable.Columns)
            {
                csvBuilder.Append(column.ColumnName);
                csvBuilder.Append(";");
            }
            csvBuilder.Length--; // Remove the trailing comma
            csvBuilder.AppendLine();

            // Write the data rows
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    csvBuilder.Append(item.ToString());
                    csvBuilder.Append(";");
                }
                csvBuilder.Length--; // Remove the trailing comma
                csvBuilder.AppendLine();
            }

            return csvBuilder.ToString();
        }

        private void Make_Rating_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(db.stringCon());
            sqlConnection.Open();
            command.Connection = sqlConnection;

            queryString = $"SELECT * FROM Ratings WHERE id_user = {UserData.userID} AND id_track = {Convert.ToInt32(idTrack)}";
            command.CommandText = queryString;
            adapter.SelectCommand = command;
            adapter.Fill(tableCheck);
            if(tableCheck.Rows.Count == 1)
            {
                flag = false;
            }

            
        }

       

        public Make_Rating()
        {
            InitializeComponent();
            db = new Database();
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_MakeRating_Click(object sender, EventArgs e)
        {
            if (textBox_MakeRating.Text == "")
            {
                MessageBox.Show("Заполните поле", "Уведомление");
            }
            else if(Convert.ToInt32(textBox_MakeRating.Text) < 1 || Convert.ToInt32(textBox_MakeRating.Text) > 5)
            {
                MessageBox.Show("Введите число от 1 до 5", "Уведомление");
            }
            else 
            {
                if (flag)
                {
                    queryString = $"INSERT INTO Ratings VALUES({UserData.userID}, {Convert.ToInt32(idTrack)}, {Convert.ToInt32(textBox_MakeRating.Text)})";
                }
                else 
                {
                    queryString = $"UPDATE Ratings SET rating = {Convert.ToInt32(textBox_MakeRating.Text)} WHERE id_user = {UserData.userID} AND id_track = {Convert.ToInt32(idTrack)}";
                }
                command.CommandText = queryString;
                command.ExecuteNonQuery();

                queryString = $"SELECT rating, id_user, id_track FROM Ratings";
                command.CommandText = queryString;
                adapter.SelectCommand = command;
                adapter.Fill(tableRatings);

                string csvContent = DataTableToCsv(tableRatings);
                string filePath = @"Data\ratings.csv";
                File.WriteAllText(filePath, csvContent);

                Close();
            }

           
        }
    }
}
