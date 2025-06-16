using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class OrderReceptionScreen : Form
    {
        SQLiteConnection Conn;
        SQLiteDataAdapter dataAdapter;
        DataSet dataSet;
        string strConn = "Data Source=./mydb.sqlite;";

        public OrderReceptionScreen()
        {
            InitializeComponent();
        }

        private void Tb_Reception_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void LoadPendingOrders()
        {
            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            string query = "SELECT ordernum, 메뉴명, 가격, 수량, 접수여부, 수금여부, event_date FROM Tb_Orders WHERE 접수여부 = 0";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, Conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "PendingOrders");

            dataGridView1.DataSource = ds.Tables["PendingOrders"];
            Conn.Close();
        }

        private void Reception(object sender, EventArgs e)
        {
            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells["ordernum"].Value == null)
                    continue;

                int ordernum = Convert.ToInt32(row.Cells["ordernum"].Value);

                string updateQuery = "UPDATE Tb_Orders SET 접수여부 = 1 WHERE ordernum = @ordernum";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, Conn))
                {
                    cmd.Parameters.AddWithValue("@ordernum", ordernum);
                    cmd.ExecuteNonQuery();
                }
            }

            Conn.Close();

            //MessageBox.Show("선택된 주문이 접수 처리되었습니다.");
            LoadPendingOrders(); // 다시 조회
        }
    }
}
