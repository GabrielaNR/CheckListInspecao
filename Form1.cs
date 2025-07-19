using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CheckListInspecao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var conn = Banco.ObterConexao())
            {
                conn.Open();
                if (cmbCcm.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione um CCM.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string tecnico = txtTecnico.Text;
                DateTime data = dtpData.Value;
                string ccm = cmbCcm.SelectedItem?.ToString();
                string comentarios = txtComentarios.Text;

                List<string> itensVerificados = new List<string>();
                foreach (var item in clbItensVerificados.CheckedItems)
                {
                    itensVerificados.Add(item.ToString());
                }

                string sql = @"INSERT INTO Inspecao (Tecnico, Data, Ccm, ItensVerificados, Comentarios) 
                            VALUES (@Tecnico, @Data, @Ccm, @ItensVerificados, @Comentarios)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Tecnico", tecnico);
                cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Ccm", ccm);
                cmd.Parameters.AddWithValue("@ItensVerificados", string.Join(", ", itensVerificados));
                cmd.Parameters.AddWithValue("@Comentarios", comentarios);

                cmd.ExecuteNonQuery();
            }

 
            MessageBox.Show($"Inspeção salva com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTecnico.Clear();
            cmbCcm.SelectedIndex = -1;
            txtComentarios.Clear();
            for (int i = 0; i < clbItensVerificados.Items.Count; i++)
            {
                clbItensVerificados.SetItemChecked(i, false);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCcm.Items.AddRange(new string[]
            {
                "CCM 1",
                "CCM 2",
                "CCM 3",
                "CCM 4",
                "CCM 5",
                "CCM 6",
                "CCM 7",
                "CCM 8",
                "CCM 9",
                "CCM 10"
            });
            cmbCcm.SelectedIndex = 0; // Seleciona o primeiro item por padrão
        }
    }
}
