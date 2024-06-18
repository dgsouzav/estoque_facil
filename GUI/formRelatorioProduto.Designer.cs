namespace UI
{
    partial class formRelatorioProduto
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
            btnExportarRelatorio = new Button();
            btnLimparTela = new Button();
            btnInserir = new Button();
            btnGerarRelatorio = new Button();
            panelDados = new Panel();
            label1 = new Label();
            dtgvRelatorios = new DataGridView();
            lblDataFinal = new Label();
            lblDataInicial = new Label();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
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
            panelBotoes.Location = new Point(845, 15);
            panelBotoes.Margin = new Padding(3, 4, 3, 4);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(135, 594);
            panelBotoes.TabIndex = 11;
            // 
            // btnExportarRelatorio
            // 
            btnExportarRelatorio.Location = new Point(23, 203);
            btnExportarRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnExportarRelatorio.Name = "btnExportarRelatorio";
            btnExportarRelatorio.Size = new Size(91, 63);
            btnExportarRelatorio.TabIndex = 10;
            btnExportarRelatorio.Text = "EXPORTAR RELATÓRIO";
            btnExportarRelatorio.UseVisualStyleBackColor = true;
            btnExportarRelatorio.Click += btnExportarRelatorio_Click;
            // 
            // btnLimparTela
            // 
            btnLimparTela.Location = new Point(23, 409);
            btnLimparTela.Margin = new Padding(3, 4, 3, 4);
            btnLimparTela.Name = "btnLimparTela";
            btnLimparTela.Size = new Size(91, 63);
            btnLimparTela.TabIndex = 9;
            btnLimparTela.Text = "LIMPAR";
            btnLimparTela.UseVisualStyleBackColor = true;
            btnLimparTela.Click += btnLimparTela_Click_1;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(23, 104);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(91, 63);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click_1;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(23, 303);
            btnGerarRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(91, 63);
            btnGerarRelatorio.TabIndex = 8;
            btnGerarRelatorio.Text = "GERAR RELATÓRIO";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click_1;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(label1);
            panelDados.Controls.Add(dtgvRelatorios);
            panelDados.Controls.Add(lblDataFinal);
            panelDados.Controls.Add(lblDataInicial);
            panelDados.Controls.Add(dtpDataFinal);
            panelDados.Controls.Add(dtpDataInicial);
            panelDados.Location = new Point(10, 15);
            panelDados.Margin = new Padding(3, 4, 3, 4);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(827, 594);
            panelDados.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 127);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 14;
            label1.Text = "Produtos";
            // 
            // dtgvRelatorios
            // 
            dtgvRelatorios.AllowUserToAddRows = false;
            dtgvRelatorios.AllowUserToDeleteRows = false;
            dtgvRelatorios.AllowUserToOrderColumns = true;
            dtgvRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRelatorios.Location = new Point(5, 148);
            dtgvRelatorios.Margin = new Padding(3, 4, 3, 4);
            dtgvRelatorios.Name = "dtgvRelatorios";
            dtgvRelatorios.ReadOnly = true;
            dtgvRelatorios.RowHeadersWidth = 47;
            dtgvRelatorios.RowTemplate.Height = 25;
            dtgvRelatorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRelatorios.Size = new Size(648, 436);
            dtgvRelatorios.TabIndex = 13;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(277, 16);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(67, 19);
            lblDataFinal.TabIndex = 8;
            lblDataFinal.Text = "Data final";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(5, 16);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(75, 19);
            lblDataInicial.TabIndex = 7;
            lblDataInicial.Text = "Data inicial";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(277, 39);
            dtpDataFinal.Margin = new Padding(3, 4, 3, 4);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(265, 26);
            dtpDataFinal.TabIndex = 6;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(5, 39);
            dtpDataInicial.Margin = new Padding(3, 4, 3, 4);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(265, 26);
            dtpDataInicial.TabIndex = 5;
            // 
            // formRelatorioProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 616);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formRelatorioProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorio de Produto";
            Load += formRelatorioProduto_Load;
            panelBotoes.ResumeLayout(false);
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRelatorios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelBotoes;
        protected Button btnExportarRelatorio;
        protected Button btnLimparTela;
        protected Button btnInserir;
        protected Button btnGerarRelatorio;
        protected Panel panelDados;
        private Label label1;
        private Label lblDataFinal;
        private Label lblDataInicial;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private DataGridView dtgvRelatorios;
    }
}