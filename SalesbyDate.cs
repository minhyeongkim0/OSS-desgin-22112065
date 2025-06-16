using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class SalesbyDate : Form
    {
        SQLiteConnection Conn;
        SQLiteDataAdapter dataAdapter;
        DataSet dataSet;
        string strConn = "Data Source=./mydb.sqlite;"; // SQLite DB 파일 경로

        public SalesbyDate()
        {
            InitializeComponent();
        }

        private void inquiry(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Tb_Orders WHERE event_date = @event_date";
            DateTime selectedDate = dateTimePicker1.Value.Date;

            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, Conn);
            command.Parameters.AddWithValue("@event_date", selectedDate.ToString("yyyy-MM-dd")); // SQLite 날짜 형식

            dataAdapter = new SQLiteDataAdapter(command);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "t");
            DataTable dataTable = dataSet.Tables["t"];

            dataGridView1.DataSource = dataTable;

            Conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Optional: 자동 새로고침 기능 넣을 수도 있음
        }
    }
}
