using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CheckListInspecao
{
    public static class Banco
    {
        private static string dbPath = "inspecoes.db";

        public static SQLiteConnection ObterConexao()
        {
            return new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }
        public static void CriarTabelas()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
            using (var conn = ObterConexao())
            {
                conn.Open();

                string sql = @" 
                CREATE TABLE IF NOT EXISTS CCMs(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Localizacao TEXT);

                CREATE TABLE IF NOT EXISTS ItensChecklist(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Descricao TEXT NOT NULL);

                CREATE TABLE IF NOT EXISTS Inspecoes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Data DATE NOT NULL,
                    Tecnico TEXT NOT NULL,
                    Comentarios TEXT, 
                    CcmId TEXT NOT NULL,
                    ItensVerificados TEXT,
                    FOREIGN KEY (CcmId) REFERENCES CCMs(Nome));   

                CREATE TABLE IF NOT EXISTS RespostasChecklist(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    InspecaoId INTEGER NOT NULL,
                    ItemId INTEGER NOT NULL,
                    Resposta TEXT NOT NULL,
                    FOREIGN KEY (InspecaoID) REFERENCES Inspecoes(Id),
                    FOREIGN KEY (ItemId) REFERENCES ItensCheckList(Id));";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }

        public static void InserirDadosIniciais()
        {
            using (var conn = ObterConexao())
            {
                conn.Open();
                var checkCcm = new SQLiteCommand("SELECT COUNT(*) FROM CCMs", conn);
                long countCcm = (long)checkCcm.ExecuteScalar();
                if (countCcm == 0) 
                {
                    string[] ccms = {"CCM 1", "CCM 2", "CCM 3", "CCM 4", "CCM 5", "CCM 6", "CCM 7", "CCM 8", "CCM 9", "CCM 10"};
                    foreach(var ccm in ccms)
                    {
                        var insertCcm = new SQLiteCommand("INSERT INTO CCMs (Nome) VALUES (@nome)", conn);
                        insertCcm.Parameters.AddWithValue("@nome", ccm);
                        insertCcm.ExecuteNonQuery();
                    }
                }

                var checkItens = new SQLiteCommand("SELECT COUNT(*) FROM ItensChecklist", conn);
                long countItens = (long)checkItens.ExecuteScalar();
                if(countItens == 0)
                {
                    string[] itens = {
                        "Preparar documentação de segurança",
                        "Verificar condições de acesso ao CCM",
                        "Inspecionar condições de iluminação",
                        "Verificar sinalização de segurança",
                        "Inspecionar equipamentos de proteção individual (EPIs)",
                        "Verificar tensão de alimentação",
                        "Inspecionar conexões elétricas",
                        "Testar disjuntores",
                        "Verificar aterramento",
                        "Inspecionar cabos e fiações",
                        "Testar dispositivos de proteção",
                        "Verificar temperatura dos equipamentos",
                        "Inspecionar painel de controle",
                        "Testar alarmes e sinalizações",
                        "Conferir aperto das fiações",
                        "Verificar limpeza do ambiente",
                        "Registrar condições gerais do CCM",
                        "Conferir etiquetas de identificação",
                        "Registrar observações adicionais"
                    };
                    foreach (var item in itens)
                    {
                        var insertItens = new SQLiteCommand("INSERT INTO ItensChecklist (Descricao) VALUES (@descricao)", conn);
                        insertItens.Parameters.AddWithValue("@descricao", item);
                        insertItens.ExecuteNonQuery();
                    }
                }

            }
        }
    }
}
