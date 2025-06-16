using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class MenuRegister : Form
    {
        SQLiteConnection Conn;
        SQLiteDataAdapter dataAdapter;
        DataSet dataSet;
        string strConn = "Data Source=./mydb.sqlite;";

        public MenuRegister()
        {
            InitializeComponent();
        }
        private void Tb_Menu_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 실행할 초기화 코드를 여기에 작성
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SqlCommandInit()
        {
            if (dataAdapter == null)
                dataAdapter = new SQLiteDataAdapter();

            if (Conn == null)
                Conn = new SQLiteConnection(strConn);

            string selectSQL = "SELECT * FROM Tb_Menu";
            dataAdapter.SelectCommand = new SQLiteCommand(selectSQL);

            string insertSQL = "INSERT INTO Tb_Menu(메뉴명, 메뉴이미지, 가격, 구분) VALUES (@메뉴명, @메뉴이미지, @가격, @구분)";
            dataAdapter.InsertCommand = new SQLiteCommand(insertSQL, Conn);
            dataAdapter.InsertCommand.Parameters.Add("@메뉴명", DbType.String, 15, "메뉴");
            dataAdapter.InsertCommand.Parameters.Add("@메뉴이미지", DbType.Binary, -1, "메뉴이미지");
            dataAdapter.InsertCommand.Parameters.Add("@가격", DbType.Int32, 15, "가격");
            dataAdapter.InsertCommand.Parameters.Add("@구분", DbType.String, 15, "구분");
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
            {
                MessageBox.Show("이미지를 넣어주세요");
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void Registration(object sender, EventArgs e)
        {
            byte[] imageBytes = ConvertImageToByteArray(pictureBox1.Image);
            if (imageBytes == null) return;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("메뉴명을 입력하세요");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("가격을 입력하세요");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("등록자를 입력하세요");
                return;
            }

            string category = null;
            if (radioButton1.Checked) category = "주류";
            else if (radioButton2.Checked) category = "안주류";
            else if (radioButton3.Checked) category = "식사메뉴";

            if (category == null)
            {
                MessageBox.Show("메뉴 구분을 클릭하세요");
                return;
            }

            Conn = new SQLiteConnection(strConn);
            Conn.Open();

            string checkQuery = "SELECT * FROM Tb_Menu WHERE 메뉴명 = @메뉴명";
            SQLiteCommand command = new SQLiteCommand(checkQuery, Conn);
            command.Parameters.AddWithValue("@메뉴명", textBox1.Text.Trim());
            SQLiteDataAdapter checkAdapter = new SQLiteDataAdapter(command);
            DataSet ds = new DataSet();
            checkAdapter.Fill(ds, "k");

            if (ds.Tables["k"].Rows.Count > 0)
            {
                MessageBox.Show("이미 등록된 메뉴입니다.");
            }
            else
            {
                SqlCommandInit();

                dataAdapter.InsertCommand.Parameters["@메뉴명"].Value = textBox1.Text;
                dataAdapter.InsertCommand.Parameters["@메뉴이미지"].Value = imageBytes;
                dataAdapter.InsertCommand.Parameters["@가격"].Value = int.Parse(textBox2.Text);
                dataAdapter.InsertCommand.Parameters["@구분"].Value = category;

                dataAdapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("메뉴가 등록됐습니다.");
            }

            Conn.Close();
        }
    }
}
