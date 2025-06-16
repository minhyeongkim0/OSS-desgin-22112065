using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp19
{
    public partial class PayScreen : Form
    {
        SQLiteConnection Conn;
        SQLiteDataAdapter dataAdapter;
        string strConn = "Data Source=./mydb.sqlite;"; // SQLite DB 파일

        public PayScreen()
        {
            InitializeComponent();
        }

        // 결제 안 된 주문 목록 조회 (OrderID 기준 정렬)
        private void View(object sender, EventArgs e)
        {
            int total = 0;
            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            string query = @"
                SELECT ordernum, 메뉴명, 수량, 가격, 수금여부 
                FROM Tb_Orders 
                WHERE 접수여부 = 1 AND 수금여부 = 0
                ORDER BY ordernum ASC";

            SQLiteCommand command = new SQLiteCommand(query, Conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Orders");
            DataTable dataTable = dataSet.Tables["Orders"];
           // dataTable.Columns.Add("합계금액", typeof(int));

            foreach (DataRow row in dataTable.Rows)
            {
                int price = Convert.ToInt32(row["가격"]);
                int quantity = Convert.ToInt32(row["수량"]);
             //   int totalprice = price* quantity;
               // row["totalprice"] = totalprice;
               // total += totalprice;
            }

            Total_Price.Text = total.ToString();
            dataGridView1.DataSource = dataTable;
            Conn.Close();
        }

        // 선택한 주문들 수금 처리
        private void Pay(object sender, EventArgs e)
        {
            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            string updateQuery = "UPDATE Tb_Orders SET 수금여부 = 1 WHERE ordernum = @ordernum";
            SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, Conn);

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells["ordernum"].Value == null) continue;

                int ordernum = Convert.ToInt32(row.Cells["ordernum"].Value);
                updateCmd.Parameters.Clear();
                updateCmd.Parameters.AddWithValue("@ordernum", ordernum);
                updateCmd.ExecuteNonQuery();
            }

            Conn.Close();
           Pay(sender, e); // 결제 후 목록 새로고침
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalSum = 0;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells["가격"].Value != null && int.TryParse(row.Cells["가격"].Value.ToString(), out int amount))
                {
                    totalSum += amount;
                }
            }

            Total_Price.Text = totalSum.ToString("N0"); // "1,000" 형태로 표시
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 필요 시 구현
        }
    }
}
