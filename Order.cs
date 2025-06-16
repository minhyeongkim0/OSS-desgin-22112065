using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // SQLite 사용
using System.IO;
using System.IdentityModel.Tokens;

namespace WindowsFormsApp19
{
    public partial class Order : Form
    {
        SQLiteConnection Conn;
        SQLiteDataAdapter dataAdapter;
        DataSet dataSet;
        string strConn = "Data Source=./mydb.sqlite;"; // SQLite 파일명

        public Order()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DrinkButton(object sender, EventArgs e)
        {
            string drink= "주류";
            string query = "SELECT * FROM Tb_Menu WHERE 구분 = @구분";

            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, Conn);
            command.Parameters.AddWithValue("@구분", drink.Trim());

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "t");
            DataTable dataTable = dataSet.Tables["t"];
            dataTable.Columns.Add("수량", typeof(int));
            foreach (DataRow row in dataTable.Rows)
            {
                row["수량"] = 1;
            }

            dataGridView1.DataSource = dataSet.Tables["t"];
            Conn.Close();
        }

        private void dataGridView_SizeChanged(object sender, EventArgs e)
        {
            AdjustColumnWidth();
        }

        private void AdjustColumnWidth()
        {
            int rowCount = dataGridView1.RowCount;

            if (rowCount < 10)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton(object sender, EventArgs e)
        {
            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("메뉴명");
            dataTable2.Columns.Add("가격");
            dataTable2.Columns.Add("수량");

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string menu = row.Cells["메뉴명"].Value.ToString();
                int price = Convert.ToInt32(row.Cells["가격"].Value);
                int quantity = Convert.ToInt32(row.Cells["수량"].Value);

                dataTable2.Rows.Add(menu, price, quantity);
            }

           ConfirmationScreen orderConfirmaion = new ConfirmationScreen();
            orderConfirmaion.SetDataToGridView(dataTable2);
            orderConfirmaion.Show();
        }

        private void SnacksButton(object sender, EventArgs e)
        {
            string Snacks = "안주류";
            string query = "SELECT * FROM Tb_Menu WHERE 구분 = @구분";

            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, Conn);
            command.Parameters.AddWithValue("@구분", Snacks.Trim());

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "t");
            DataTable dataTable = dataSet.Tables["t"];
            dataTable.Columns.Add("수량", typeof(int));
            foreach (DataRow row in dataTable.Rows)
            {
                row["수량"] = 1;
            }

            dataGridView1.DataSource = dataSet.Tables["t"];
            Conn.Close();
        }

        private void MealButton(object sender, EventArgs e)
        {
            string meal= "식사메뉴";
            string query = "SELECT * FROM Tb_Menu WHERE 구분 = @구분";

            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, Conn);
            command.Parameters.AddWithValue("@구분", meal.Trim());

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "t");
            DataTable dataTable = dataSet.Tables["t"];
            dataTable.Columns.Add("수량", typeof(int));
            foreach (DataRow row in dataTable.Rows)
            {
                row["수량"] = 1;
            }

            dataGridView1.DataSource = dataSet.Tables["t"];
            Conn.Close();
        }
    }
}
