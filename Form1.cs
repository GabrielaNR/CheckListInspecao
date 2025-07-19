using System;
using System.Collections.Generic;
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
            string tecnico = txtTecnico.Text;
            DateTime data = dtpData.Value;
            string ccm = cmbCcm.SelectedItem?.ToString();
            string comentarios = txtComentarios.Text;

            List<string> itensVerificados = new List<string>();
            foreach (var item in clbItensVerificados.CheckedItems)
            {
                itensVerificados.Add(item.ToString());
            }

            Inspecao novaInspecao = new Inspecao
            {
                Tecnico = tecnico,
                Data = data,
                Ccm = ccm,
                ItensVerificados = itensVerificados,
                Comentarios = comentarios
            };

            string nomeArquivo = $"Inspecao_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
            File.WriteAllText(nomeArquivo, novaInspecao.ToString());

            MessageBox.Show($"Inspeção salva com sucesso em {nomeArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTecnico.Clear();
            
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
