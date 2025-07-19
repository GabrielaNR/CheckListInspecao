using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace CheckListInspecao
{
    public static class Banco
    {
        private static string dbPath = "inspecoes.db";

        public static SQLiteConnection ObterConexao()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                using (var conn = new SQLiteConnection($"Data Source = {dbPath}; Version = 3;"))
                {
                    conn.Open();
                    string sql = @"CREATE TABLE IF NOT EXISTS Inspecao(
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Tecnico TEXT NOT NULL,
                            Data TEXT NOT NULL,
                            Ccm TEXT NOT NULL,
                            ItensVerificados TEXT NOT NULL,
                            Comentarios TEXT
                        )";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
