namespace UI
{
    partial class formRelatorioCliente
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
            dtgvRelatorios = new DataGridView();
            lblDataFinal = new Label();
            lblDataInicial = new Label();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            label1 = new Label();
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
            panelBotoes.Location = new Point(828, 12);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(118, 469);
            panelBotoes.TabIndex = 11;
            // 
            // btnExportarRelatorio
            // 
            btnExportarRelatorio.Location = new Point(20, 160);
            btnExportarRelatorio.Name = "btnExportarRelatorio";
            btnExportarRelatorio.Size = new Size(80, 50);
            btnExportarRelatorio.TabIndex = 10;
            btnExportarRelatorio.Text = "EXPORTAR RELATÓRIO";
            btnExportarRelatorio.UseVisualStyleBackColor = true;
            btnExportarRelatorio.Click += btnExportarRelatorio_Click_1;
            // 
            // btnLimparTela
            // 
            btnLimparTela.Location = new Point(20, 323);
            btnLimparTela.Name = "btnLimparTela";
            btnLimparTela.Size = new Size(80, 50);
            btnLimparTela.TabIndex = 9;
            btnLimparTela.Text = "LIMPAR";
            btnLimparTela.UseVisualStyleBackColor = true;
            btnLimparTela.Click += btnLimparTela_Click_1;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(20, 82);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 50);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click_1;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(20, 239);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(80, 50);
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
            panelDados.Location = new Point(9, 12);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(813, 469);
            panelDados.TabIndex = 10;
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
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(4, 64);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(57, 15);
            lblDataFinal.TabIndex = 8;
            lblDataFinal.Text = "Data final";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(4, 13);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(65, 15);
            lblDataInicial.TabIndex = 7;
            lblDataInicial.Text = "Data inicial";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(4, 82);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(232, 23);
            dtpDataFinal.TabIndex = 6;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(4, 31);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(232, 23);
            dtpDataInicial.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 15;
            label1.Text = "Clientes";
            // 
            // formRelatorioCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 486);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name = "formRelatorioCliente";
            Text = "formRelatorioCliente";
            Load += formRelatorioCliente_Load;
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
        private DataGridView dtgvRelatorios;
        private Label lblDataFinal;
        private Label lblDataInicial;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private Label label1;
    }
}