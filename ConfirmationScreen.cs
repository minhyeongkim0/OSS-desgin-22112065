using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class ConfirmationScreen: Form
    {
        SQLiteConnection Conn;
        SQLiteCommand command;
        string dbPath = "Data Source=./mydb.sqlite;";// SQLite DB 파일

        public ConfirmationScreen()
        {
            InitializeComponent();
        }

        public void SetDataToGridView(DataTable data)
        {
            dataGridView1.DataSource = data;
        }

        private void Confirmation(object sender, EventArgs e)
        {
            Conn = new SQLiteConnection(dbPath);
            Conn.Open();

            string insertQuery = @"
                INSERT INTO Tb_Orders 
                (메뉴명, 가격, 수량, 합계금액, 접수여부, 수금여부, event_date)
                VALUES (@메뉴명, @가격, @수량, @합계금액, @접수여부, @수금여부, @event_date);
                SELECT last_insert_rowid();
            ";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow || row.Cells["메뉴명"].Value == null) continue;

                string menu = row.Cells["메뉴명"].Value.ToString();
                int price = Convert.ToInt32(row.Cells["가격"].Value);
                int quantity = Convert.ToInt32(row.Cells["수량"].Value);
                int totalprice = price * quantity;
                bool reception = false;
                bool paycheck = false;
                string event_date = DateTime.Now.ToString("yyyy-MM-dd");

                using (command = new SQLiteCommand(insertQuery, Conn))
                {
                    command.Parameters.AddWithValue("@메뉴명", menu);
                    command.Parameters.AddWithValue("@가격", price);
                    command.Parameters.AddWithValue("@수량", quantity);
                    command.Parameters.AddWithValue("@합계금액", totalprice);
                    command.Parameters.AddWithValue("@접수여부", reception);
                    command.Parameters.AddWithValue("@수금여부", paycheck);
                    command.Parameters.AddWithValue("@event_date", event_date);

                    long orderId = (long)command.ExecuteScalar();

                    // 주문번호 사용자에게 보여주기
                    MessageBox.Show($"주문이 완료되었습니다.\n고객 주문번호: {orderId}", "주문 확인");
                }
            }

            Conn.Close();
        }

        private void Table_Num_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 필요 시 구현
        }
    }
}
