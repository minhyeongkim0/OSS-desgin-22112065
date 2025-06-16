using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Login : Form
    {
        string strConn = "Data Source=./mydb.sqlite;"; // SQLite DB 경로

        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // 텍스트박스에서 입력된 값이 숫자인지 검사
            if (!int.TryParse(textBox1.Text.Trim(), out int inputCode))
            {
                MessageBox.Show("숫자만 입력하세요.");
                return;
            }

            // 0000 입력 시 무조건 통과
            if (inputCode == 0000)
            {
                UnlockOwnerScreen();
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM  Tb_OwnerCode WHERE 암호 = @암호";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@암호", inputCode);

                
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    UnlockOwnerScreen();
                }
                else
                {
                    MessageBox.Show("잘못된 점주 코드입니다.");
                }
            }
        }

        private void UnlockOwnerScreen()
        {
            OwnerScreen ownerScreen = new OwnerScreen();
            ownerScreen.Show();
            this.Hide(); // 또는 this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 필요 시 기능 추가
        }
    }
}
