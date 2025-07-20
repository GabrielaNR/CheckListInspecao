namespace CheckListInspecao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTecnico = new Label();
            txtTecnico = new TextBox();
            lblData = new Label();
            dtpData = new DateTimePicker();
            lblEquipamento = new Label();
            lblItens = new Label();
            clbItensVerificados = new CheckedListBox();
            lblComentarios = new Label();
            txtComentarios = new TextBox();
            btnSalvar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbCcm = new ComboBox();
            dgvInspecoes = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInspecoes).BeginInit();
            SuspendLayout();
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.Location = new Point(3, 0);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(103, 15);
            lblTecnico.TabIndex = 0;
            lblTecnico.Text = "Nome do Técnico:";
            // 
            // txtTecnico
            // 
            txtTecnico.Location = new Point(227, 3);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(534, 23);
            txtTecnico.TabIndex = 1;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(3, 75);
            lblData.Name = "lblData";
            lblData.Size = new Size(103, 15);
            lblData.TabIndex = 2;
            lblData.Text = "Data da Inspeção: ";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(227, 78);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(278, 23);
            dtpData.TabIndex = 3;
            // 
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.Location = new Point(3, 136);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.Size = new Size(111, 15);
            lblEquipamento.TabIndex = 4;
            lblEquipamento.Text = "CCM inspecionado:";
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.Location = new Point(3, 182);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(114, 15);
            lblItens.TabIndex = 6;
            lblItens.Text = "Itens de Verificação: ";
            // 
            // clbItensVerificados
            // 
            clbItensVerificados.ColumnWidth = 200;
            clbItensVerificados.FormattingEnabled = true;
            clbItensVerificados.Items.AddRange(new object[] { "Estado do disjuntor", "Limpeza do painel", "Fixação dos cabos", "Estado dos bornes", "Presença de sinalização", "Verificação de aterramento" });
            clbItensVerificados.Location = new Point(227, 185);
            clbItensVerificados.MultiColumn = true;
            clbItensVerificados.Name = "clbItensVerificados";
            clbItensVerificados.Size = new Size(534, 112);
            clbItensVerificados.TabIndex = 7;
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(3, 322);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(78, 15);
            lblComentarios.TabIndex = 8;
            lblComentarios.Text = "Comentários:";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(227, 325);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(534, 78);
            txtComentarios.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(338, 424);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar Inspeção";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.90071F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.09929F));
            tableLayoutPanel1.Controls.Add(cmbCcm, 1, 2);
            tableLayoutPanel1.Controls.Add(lblTecnico, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTecnico, 1, 0);
            tableLayoutPanel1.Controls.Add(lblData, 0, 1);
            tableLayoutPanel1.Controls.Add(lblEquipamento, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpData, 1, 1);
            tableLayoutPanel1.Controls.Add(lblItens, 0, 3);
            tableLayoutPanel1.Controls.Add(clbItensVerificados, 1, 3);
            tableLayoutPanel1.Controls.Add(lblComentarios, 0, 4);
            tableLayoutPanel1.Controls.Add(txtComentarios, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.1724129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.8275871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.Size = new Size(776, 406);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // cmbCcm
            // 
            cmbCcm.FormattingEnabled = true;
            cmbCcm.Items.AddRange(new object[] { "CCM 1", "CCM 2", "CCM 3", "CCM 4", "CCM 5", "CCM 6", "CCM 7", "CCM 8", "CCM 9", "CCM 10" });
            cmbCcm.Location = new Point(227, 139);
            cmbCcm.Name = "cmbCcm";
            cmbCcm.Size = new Size(121, 23);
            cmbCcm.TabIndex = 12;
            cmbCcm.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvInspecoes
            // 
            dgvInspecoes.AllowUserToAddRows = false;
            dgvInspecoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInspecoes.Location = new Point(15, 463);
            dgvInspecoes.Name = "dgvInspecoes";
            dgvInspecoes.ReadOnly = true;
            dgvInspecoes.Size = new Size(773, 150);
            dgvInspecoes.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(dgvInspecoes);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Inspeção de CCM";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInspecoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTecnico;
        private TextBox txtTecnico;
        private Label lblData;
        private DateTimePicker dtpData;
        private Label lblEquipamento;
        private Label lblItens;
        private CheckedListBox clbItensVerificados;
        private Label lblComentarios;
        private TextBox txtComentarios;
        private Button btnSalvar;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbCcm;
        private DataGridView dgvInspecoes;
    }
}
