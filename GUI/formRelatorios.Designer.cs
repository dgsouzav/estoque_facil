namespace UI
{
    partial class formRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBotoes = new Panel();
            btnLimparTela = new Button();
            btnInserir = new Button();
            btnGerarRelatorio = new Button();
            panelDados = new Panel();
            dtgvRelatorios = new DataGridView();
            lblDataFinal = new Label();
            lblDataInicial = new Label();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            cmbTipoRelatorio = new ComboBox();
            lblOpcao = new Label();
            btnExportarRelatorio = new Button();
            panelBotoes.SuspendLayout();
            panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRelatorios).BeginInit();
            SuspendLayout();
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnExportarRelatorio);
            panelBotoes.Controls.Add(btnLimparTela);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnGerarRelatorio);
            panelBotoes.Location = new Point(831, 12);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(118, 469);
            panelBotoes.TabIndex = 7;
            // 
            // btnLimparTela
            // 
            btnLimparTela.Location = new Point(21, 272);
            btnLimparTela.Name = "btnLimparTela";
            btnLimparTela.Size = new Size(80, 50);
            btnLimparTela.TabIndex = 9;
            btnLimparTela.Text = "LIMPAR";
            btnLimparTela.UseVisualStyleBackColor = true;
            btnLimparTela.Click += btnLimparTela_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(21, 31);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 50);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(21, 188);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(80, 50);
            btnGerarRelatorio.TabIndex = 8;
            btnGerarRelatorio.Text = "GERAR RELATÓRIO";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(dtgvRelatorios);
            panelDados.Controls.Add(lblDataFinal);
            panelDados.Controls.Add(lblDataInicial);
            panelDados.Controls.Add(dtpDataFinal);
            panelDados.Controls.Add(dtpDataInicial);
            panelDados.Controls.Add(cmbTipoRelatorio);
            panelDados.Controls.Add(lblOpcao);
            panelDados.Location = new Point(12, 12);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(813, 469);
            panelDados.TabIndex = 6;
            // 
            // dtgvRelatorios
            // 
            dtgvRelatorios.AllowUserToAddRows = false;
            dtgvRelatorios.AllowUserToDeleteRows = false;
            dtgvRelatorios.AllowUserToOrderColumns = true;
            dtgvRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRelatorios.Location = new Point(241, 31);
            dtgvRelatorios.Name = "dtgvRelatorios";
            dtgvRelatorios.ReadOnly = true;
            dtgvRelatorios.RowTemplate.Height = 25;
            dtgvRelatorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRelatorios.Size = new Size(567, 435);
            dtgvRelatorios.TabIndex = 13;
            dtgvRelatorios.CellFormatting += dtgvRelatorios_CellFormatting;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(3, 118);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(57, 15);
            lblDataFinal.TabIndex = 8;
            lblDataFinal.Text = "Data final";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(3, 67);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(65, 15);
            lblDataInicial.TabIndex = 7;
            lblDataInicial.Text = "Data inicial";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(3, 136);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(232, 23);
            dtpDataFinal.TabIndex = 6;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(3, 85);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(232, 23);
            dtpDataInicial.TabIndex = 5;
            // 
            // cmbTipoRelatorio
            // 
            cmbTipoRelatorio.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTipoRelatorio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoRelatorio.FormattingEnabled = true;
            cmbTipoRelatorio.Items.AddRange(new object[] { "Relatório de compra", "Relatório de clientes", "Relatório de venda", "Relatório de produto" });
            cmbTipoRelatorio.Location = new Point(3, 31);
            cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            cmbTipoRelatorio.Size = new Size(232, 23);
            cmbTipoRelatorio.TabIndex = 4;
            // 
            // lblOpcao
            // 
            lblOpcao.AutoSize = true;
            lblOpcao.Location = new Point(3, 13);
            lblOpcao.Name = "lblOpcao";
            lblOpcao.Size = new Size(97, 15);
            lblOpcao.TabIndex = 0;
            lblOpcao.Text = "Selecionar opção";
            // 
            // btnExportarRelatorio
            // 
            btnExportarRelatorio.Location = new Point(21, 109);
            btnExportarRelatorio.Name = "btnExportarRelatorio";
            btnExportarRelatorio.Size = new Size(80, 50);
            btnExportarRelatorio.TabIndex = 10;
            btnExportarRelatorio.Text = "EXPORTAR RELATÓRIO";
            btnExportarRelatorio.UseVisualStyleBackColor = true;
            // 
            // formRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 484);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name = "formRelatorios";
            Text = "Relatorios";
            Load += formRelatorios_Load;
            panelBotoes.ResumeLayout(false);
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRelatorios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelBotoes;
        protected Button btnLimparTela;
        protected Button btnInserir;
        protected Button btnLocalizar;
        protected Button btnGerarRelatorio;
        protected Button btnAlterar;
        protected Panel panelDados;
        private ComboBox cmbTipoRelatorio;
        private Label lblOpcao;
        private Label lblDataFinal;
        private Label lblDataInicial;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private DataGridView dtgvRelatorios;
        protected Button btnExportarRelatorio;
    }
}