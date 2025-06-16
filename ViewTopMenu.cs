using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class ViewTopMenu : Form
    {
        string connStr = "Data Source=./mydb.sqlite;"; // DB 경로에 맞게 수정

        public ViewTopMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                string query = @"
                    SELECT 메뉴명, 메뉴이미지, 가격, 구분, 랭크
                    FROM Tb_Menu
                    WHERE 구분 IN ('식사메뉴', '안주류')
                    ORDER BY 랭크 DESC";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // 이미지 컬럼 처리
                if (dataGridView1.Columns.Contains("메뉴이미지"))
                {
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridView1.Columns["메뉴이미지"];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridView1.RowTemplate.Height = 80;
                }
            }
        }
    }
}
