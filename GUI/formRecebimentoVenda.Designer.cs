namespace UI
{
    partial class formRecebimentoVenda
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
            dtpData = new DateTimePicker();
            lblData = new Label();
            btnReceber = new Button();
            dtgvParcelas = new DataGridView();
            lblParcelas = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            lblD = new Label();
            txtID = new TextBox();
            btnLocalizarVenda = new Button();
            dtpDataRecebimento = new DateTimePicker();
            lblDataRecebimento = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelas).BeginInit();
            SuspendLayout();
            // 
            // dtpData
            // 
            dtpData.Enabled = false;
            dtpData.Location = new Point(12, 76);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(240, 23);
            dtpData.TabIndex = 21;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 58);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 24;
            lblData.Text = "Data";
            // 
            // btnReceber
            // 
            btnReceber.Enabled = false;
            btnReceber.Location = new Point(567, 425);
            btnReceber.Name = "btnReceber";
            btnReceber.Size = new Size(205, 24);
            btnReceber.TabIndex = 27;
            btnReceber.Text = "Receber parcela";
            btnReceber.UseVisualStyleBackColor = true;
            btnReceber.Click += btnReceber_Click_1;
            // 
            // dtgvParcelas
            // 
            dtgvParcelas.AllowUserToAddRows = false;
            dtgvParcelas.AllowUserToDeleteRows = false;
            dtgvParcelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParcelas.Location = new Point(12, 137);
            dtgvParcelas.Name = "dtgvParcelas";
            dtgvParcelas.ReadOnly = true;
            dtgvParcelas.RowTemplate.Height = 25;
            dtgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvParcelas.Size = new Size(760, 261);
            dtgvParcelas.TabIndex = 28;
            dtgvParcelas.CellClick += dtgvParcelas_CellClick;
            dtgvParcelas.CellFormatting += dtgvParcelas_CellFormatting;
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Location = new Point(12, 119);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(50, 15);
            lblParcelas.TabIndex = 30;
            lblParcelas.Text = "Parcelas";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(258, 14);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 29;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(258, 32);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(205, 23);
            txtValor.TabIndex = 19;
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(12, 14);
            lblD.Name = "lblD";
            lblD.Size = new Size(18, 15);
            lblD.TabIndex = 20;
            lblD.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(12, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(240, 23);
            txtID.TabIndex = 18;
            // 
            // btnLocalizarVenda
            // 
            btnLocalizarVenda.Location = new Point(469, 31);
            btnLocalizarVenda.Name = "btnLocalizarVenda";
            btnLocalizarVenda.Size = new Size(205, 24);
            btnLocalizarVenda.TabIndex = 25;
            btnLocalizarVenda.Text = "Localizar venda";
            btnLocalizarVenda.UseVisualStyleBackColor = true;
            btnLocalizarVenda.Click += btnLocalizarVenda_Click;
            // 
            // dtpDataRecebimento
            // 
            dtpDataRecebimento.Location = new Point(12, 429);
            dtpDataRecebimento.Name = "dtpDataRecebimento";
            dtpDataRecebimento.Size = new Size(240, 23);
            dtpDataRecebimento.TabIndex = 31;
            // 
            // lblDataRecebimento
            // 
            lblDataRecebimento.AutoSize = true;
            lblDataRecebimento.Location = new Point(12, 411);
            lblDataRecebimento.Name = "lblDataRecebimento";
            lblDataRecebimento.Size = new Size(112, 15);
            lblDataRecebimento.TabIndex = 32;
            lblDataRecebimento.Text = "Data que irá receber";
            // 
            // formRecebimentoVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(dtpDataRecebimento);
            Controls.Add(lblDataRecebimento);
            Controls.Add(btnReceber);
            Controls.Add(dtgvParcelas);
            Controls.Add(lblParcelas);
            Controls.Add(dtpData);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblData);
            Controls.Add(lblD);
            Controls.Add(txtID);
            Controls.Add(btnLocalizarVenda);
            Name = "formRecebimentoVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recebimento da Venda";
            ((System.ComponentModel.ISupportInitialize)dtgvParcelas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDataRecebimento;
        private Label lblDataRecebimento;
        private Button btnReceber;
        private DataGridView dtgvParcelas;
        private Label lblParcelas;
        private DateTimePicker dtpData;
        private TextBox txtFornecedorNome;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblData;
        private Label lblFornecedorNome;
        private Label lblD;
        private TextBox txtID;
        private Button btnLocalizarVenda;
    }
}