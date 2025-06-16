using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class AddOwnerCode : Form
    {
        string strConn = "Data Source=./mydb.sqlite"; // SQLite 연결 문자열

        public AddOwnerCode()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 필요 없으면 비워도 됨
        }
        private void OwnerCodeAdd_Click(object sender, EventArgs e)
        {
            // 입력이 숫자인지 확인
            if (!int.TryParse(textBox1.Text.Trim(), out int inputCode))
            {
                MessageBox.Show("잘못된 양식입니다.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                conn.Open();

                // 중복 코드 여부 확인
                string checkQuery = "SELECT COUNT(*) FROM  Tb_OwnerCode WHERE 암호 = @암호";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@암호", inputCode);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("이미 있는 점주코드입니다.");
                        return;
                    }
                }

                // 새 점주코드 추가
                string insertQuery = "INSERT INTO  Tb_OwnerCode (암호) VALUES (@암호)";
                using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@암호", inputCode);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("추가되었습니다.!");
            }
        }
    }
}
