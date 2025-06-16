using System;
using System.Data.SQLite;

namespace WindowsFormsApp19
{
    public class DatabaseInitializer
    {
        private static string dbPath = "Data Source=./mydb.sqlite;";

        public static void InitializeDatabase()
        {
            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();

                var commands = new[]
                {
                    // Tb_Menu 테이블
                    @"CREATE TABLE IF NOT EXISTS Tb_Menu (
                        메뉴명 TEXT PRIMARY KEY,
                        메뉴이미지 BLOB,
                        가격 INTEGER NOT NULL,
                        구분 TEXT NOT NULL,
                        랭크 INTEGER DEFAULT 0
                    );",

                    // Tb_Orders 테이블
                    @"CREATE TABLE IF NOT EXISTS Tb_Orders (
                        ordernum INTEGER PRIMARY KEY AUTOINCREMENT,
                        메뉴명 TEXT NOT NULL,
                        가격 INTEGER NOT NULL,                   
                        수량 INTEGER NOT NULL,
                        합계금액 INTEGER NOT NULL,
                        접수여부 BOOLEAN DEFAULT 0,
                        수금여부 BOOLEAN DEFAULT 0,
                        event_date TEXT,            
                        FOREIGN KEY (메뉴명) REFERENCES Tb_Menu(메뉴명)
                    );",

                    // Tb_OwnerCode 테이블
              @"CREATE TABLE IF NOT EXISTS Tb_OwnerCode (
                       암호 INTEGER PRIMARY KEY
                         );"
                  };

                foreach (var cmdText in commands)
                {
                    using (var cmd = new SQLiteCommand(cmdText, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
        }
    }
}
