using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class SelectTopMenu : Form
    {
        string connStr = "Data Source=./mydb.sqlite;";

        public SelectTopMenu()
        {
            InitializeComponent();
        }

        private void SelectTopMenu_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                string query = "SELECT 메뉴명, 메뉴이미지, 가격, 구분 FROM Tb_Menu WHERE 구분 IN ('식사메뉴', '안주류')";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // 이미지 셀 설정
                if (dataGridView1.Columns.Contains("메뉴이미지"))
                {
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridView1.Columns["메뉴이미지"];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridView1.RowTemplate.Height = 80;
                }
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("메뉴를 선택하세요.");
                return;
            }

            string selectedMenu = dataGridView1.SelectedRows[0].Cells["메뉴명"].Value.ToString();

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                // 랭크 1 증가
                string updateQuery = "UPDATE Tb_Menu SET 랭크 = 랭크 + 1 WHERE 메뉴명 = @메뉴명";
                SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@메뉴명", selectedMenu);
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("랭크가 1 증가했습니다.");
                }
                else
                {
                    MessageBox.Show("랭크 업데이트 실패");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 선택 셀 동작이 필요하면 여기에 작성
        }
    }
}
