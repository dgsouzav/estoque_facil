namespace UI
{
    partial class formCompra
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
            panelDados = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnAddProduto = new Button();
            txtValor = new TextBox();
            txtQtde = new TextBox();
            lblValor = new Label();
            lblQtde = new Label();
            lblProdutoNome = new Label();
            lblProdutoID = new Label();
            txtProdutoID = new TextBox();
            btnLocalizarProduto = new Button();
            lblFornecedorNome = new Label();
            btnLocalizarFornecedor = new Button();
            txtFornecedorID = new TextBox();
            lblFornecedorID = new Label();
            dtgvItensCompra = new DataGridView();
            produtoID = new DataGridViewTextBoxColumn();
            produtoNome = new DataGridViewTextBoxColumn();
            produtoQtde = new DataGridViewTextBoxColumn();
            produtoValor = new DataGridViewTextBoxColumn();
            produtoValorTotal = new DataGridViewTextBoxColumn();
            cmbTipoPagamento = new ComboBox();
            txtCompraTotal = new TextBox();
            lblCompraTotal = new Label();
            txtNotaFiscal = new TextBox();
            lblNotaFiscal = new Label();
            txtCompraID = new TextBox();
            lblCompra = new Label();
            lblTipoPagamento = new Label();
            btnAlterar = new Button();
            btnSalvar = new Button();
            btnLocalizar = new Button();
            btnInserir = new Button();
            btnCancelar = new Button();
            panelBotoes = new Panel();
            btnExcluir = new Button();
            panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensCompra).BeginInit();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Controls.Add(label2);
            panelDados.Controls.Add(label1);
            panelDados.Controls.Add(btnAddProduto);
            panelDados.Controls.Add(txtValor);
            panelDados.Controls.Add(txtQtde);
            panelDados.Controls.Add(lblValor);
            panelDados.Controls.Add(lblQtde);
            panelDados.Controls.Add(lblProdutoNome);
            panelDados.Controls.Add(lblProdutoID);
            panelDados.Controls.Add(txtProdutoID);
            panelDados.Controls.Add(btnLocalizarProduto);
            panelDados.Controls.Add(lblFornecedorNome);
            panelDados.Controls.Add(btnLocalizarFornecedor);
            panelDados.Controls.Add(txtFornecedorID);
            panelDados.Controls.Add(lblFornecedorID);
            panelDados.Controls.Add(dtgvItensCompra);
            panelDados.Controls.Add(cmbTipoPagamento);
            panelDados.Controls.Add(txtCompraTotal);
            panelDados.Controls.Add(lblCompraTotal);
            panelDados.Controls.Add(txtNotaFiscal);
            panelDados.Controls.Add(lblNotaFiscal);
            panelDados.Controls.Add(txtCompraID);
            panelDados.Controls.Add(lblCompra);
            panelDados.Controls.Add(lblTipoPagamento);
            panelDados.Location = new Point(9, 12);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(1216, 706);
            panelDados.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(974, 662);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 42;
            label2.Text = "R$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(974, 590);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 41;
            label1.Text = "R$";
            // 
            // btnAddProduto
            // 
            btnAddProduto.Location = new Point(419, 135);
            btnAddProduto.Name = "btnAddProduto";
            btnAddProduto.Size = new Size(97, 24);
            btnAddProduto.TabIndex = 38;
            btnAddProduto.Text = "ADD PRODUTO";
            btnAddProduto.UseVisualStyleBackColor = true;
            btnAddProduto.Click += btnAddProduto_Click;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(1006, 579);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(198, 43);
            txtValor.TabIndex = 37;
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(1005, 502);
            txtQtde.Multiline = true;
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(199, 43);
            txtQtde.TabIndex = 36;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.LightCoral;
            lblValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValor.Location = new Point(1006, 556);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(98, 20);
            lblValor.TabIndex = 35;
            lblValor.Text = "Valor unitário";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.BackColor = Color.LightCoral;
            lblQtde.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQtde.Location = new Point(1006, 479);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(87, 20);
            lblQtde.TabIndex = 34;
            lblQtde.Text = "Quantidade";
            // 
            // lblProdutoNome
            // 
            lblProdutoNome.AutoSize = true;
            lblProdutoNome.Location = new Point(313, 119);
            lblProdutoNome.Name = "lblProdutoNome";
            lblProdutoNome.Size = new Size(215, 15);
            lblProdutoNome.TabIndex = 33;
            lblProdutoNome.Text = "Informe o nome do Produto ou localize";
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize = true;
            lblProdutoID.Location = new Point(6, 119);
            lblProdutoID.Name = "lblProdutoID";
            lblProdutoID.Size = new Size(50, 15);
            lblProdutoID.TabIndex = 32;
            lblProdutoID.Text = "Produto";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(6, 136);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.Size = new Size(301, 23);
            txtProdutoID.TabIndex = 5;
            txtProdutoID.Leave += txtProdutoID_Leave;
            // 
            // btnLocalizarProduto
            // 
            btnLocalizarProduto.Location = new Point(313, 135);
            btnLocalizarProduto.Name = "btnLocalizarProduto";
            btnLocalizarProduto.Size = new Size(100, 24);
            btnLocalizarProduto.TabIndex = 6;
            btnLocalizarProduto.Text = "Localizar";
            btnLocalizarProduto.UseVisualStyleBackColor = true;
            btnLocalizarProduto.Click += btnLocalizarProduto_Click;
            // 
            // lblFornecedorNome
            // 
            lblFornecedorNome.AutoSize = true;
            lblFornecedorNome.Location = new Point(313, 69);
            lblFornecedorNome.Name = "lblFornecedorNome";
            lblFornecedorNome.Size = new Size(232, 15);
            lblFornecedorNome.TabIndex = 29;
            lblFornecedorNome.Text = "Informe o nome do Fornecedor ou localize";
            // 
            // btnLocalizarFornecedor
            // 
            btnLocalizarFornecedor.Location = new Point(313, 87);
            btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            btnLocalizarFornecedor.Size = new Size(100, 24);
            btnLocalizarFornecedor.TabIndex = 4;
            btnLocalizarFornecedor.Text = "Localizar";
            btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            btnLocalizarFornecedor.Click += btnLocalizarFornecedor_Click_1;
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Location = new Point(6, 87);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.Size = new Size(301, 23);
            txtFornecedorID.TabIndex = 3;
            txtFornecedorID.Leave += txtFornecedorID_Leave;
            // 
            // lblFornecedorID
            // 
            lblFornecedorID.AutoSize = true;
            lblFornecedorID.Location = new Point(6, 69);
            lblFornecedorID.Name = "lblFornecedorID";
            lblFornecedorID.Size = new Size(67, 15);
            lblFornecedorID.TabIndex = 26;
            lblFornecedorID.Text = "Fornecedor";
            // 
            // dtgvItensCompra
            // 
            dtgvItensCompra.AllowUserToAddRows = false;
            dtgvItensCompra.AllowUserToDeleteRows = false;
            dtgvItensCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvItensCompra.Columns.AddRange(new DataGridViewColumn[] { produtoID, produtoNome, produtoQtde, produtoValor, produtoValorTotal });
            dtgvItensCompra.Location = new Point(6, 173);
            dtgvItensCompra.Name = "dtgvItensCompra";
            dtgvItensCompra.ReadOnly = true;
            dtgvItensCompra.RowTemplate.Height = 25;
            dtgvItensCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvItensCompra.Size = new Size(955, 519);
            dtgvItensCompra.TabIndex = 22;
            dtgvItensCompra.CellDoubleClick += dtgvItensCompra_CellDoubleClick;
            dtgvItensCompra.CellFormatting += dtgvItensCompra_CellFormatting;
            // 
            // produtoID
            // 
            produtoID.HeaderText = "ID do Produto";
            produtoID.Name = "produtoID";
            produtoID.ReadOnly = true;
            produtoID.Width = 60;
            // 
            // produtoNome
            // 
            produtoNome.HeaderText = "Nome";
            produtoNome.Name = "produtoNome";
            produtoNome.ReadOnly = true;
            produtoNome.Width = 200;
            // 
            // produtoQtde
            // 
            produtoQtde.HeaderText = "Quantidade";
            produtoQtde.Name = "produtoQtde";
            produtoQtde.ReadOnly = true;
            // 
            // produtoValor
            // 
            produtoValor.HeaderText = "Valor unitário";
            produtoValor.Name = "produtoValor";
            produtoValor.ReadOnly = true;
            // 
            // produtoValorTotal
            // 
            produtoValorTotal.HeaderText = "Valor total";
            produtoValorTotal.Name = "produtoValorTotal";
            produtoValorTotal.ReadOnly = true;
            // 
            // cmbTipoPagamento
            // 
            cmbTipoPagamento.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTipoPagamento.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoPagamento.FormattingEnabled = true;
            cmbTipoPagamento.Location = new Point(974, 35);
            cmbTipoPagamento.Name = "cmbTipoPagamento";
            cmbTipoPagamento.Size = new Size(230, 23);
            cmbTipoPagamento.TabIndex = 8;
            // 
            // txtCompraTotal
            // 
            txtCompraTotal.Enabled = false;
            txtCompraTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompraTotal.Location = new Point(1006, 649);
            txtCompraTotal.Multiline = true;
            txtCompraTotal.Name = "txtCompraTotal";
            txtCompraTotal.Size = new Size(198, 43);
            txtCompraTotal.TabIndex = 17;
            // 
            // lblCompraTotal
            // 
            lblCompraTotal.AutoSize = true;
            lblCompraTotal.BackColor = Color.LightCoral;
            lblCompraTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompraTotal.Location = new Point(1006, 625);
            lblCompraTotal.Name = "lblCompraTotal";
            lblCompraTotal.Size = new Size(118, 20);
            lblCompraTotal.TabIndex = 16;
            lblCompraTotal.Text = "Total da compra";
            // 
            // txtNotaFiscal
            // 
            txtNotaFiscal.Location = new Point(136, 31);
            txtNotaFiscal.Name = "txtNotaFiscal";
            txtNotaFiscal.Size = new Size(171, 23);
            txtNotaFiscal.TabIndex = 1;
            txtNotaFiscal.KeyPress += txtNotaFiscal_KeyPress;
            txtNotaFiscal.Leave += txtNotaFiscal_Leave;
            // 
            // lblNotaFiscal
            // 
            lblNotaFiscal.AutoSize = true;
            lblNotaFiscal.Location = new Point(136, 13);
            lblNotaFiscal.Name = "lblNotaFiscal";
            lblNotaFiscal.Size = new Size(63, 15);
            lblNotaFiscal.TabIndex = 6;
            lblNotaFiscal.Text = "Nota fiscal";
            // 
            // txtCompraID
            // 
            txtCompraID.Enabled = false;
            txtCompraID.Location = new Point(6, 31);
            txtCompraID.Name = "txtCompraID";
            txtCompraID.Size = new Size(124, 23);
            txtCompraID.TabIndex = 3;
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.Location = new Point(6, 13);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(108, 15);
            lblCompra.TabIndex = 1;
            lblCompra.Text = "Código da Compra";
            // 
            // lblTipoPagamento
            // 
            lblTipoPagamento.AutoSize = true;
            lblTipoPagamento.Location = new Point(974, 17);
            lblTipoPagamento.Name = "lblTipoPagamento";
            lblTipoPagamento.Size = new Size(110, 15);
            lblTipoPagamento.TabIndex = 0;
            lblTipoPagamento.Text = "Tipo de pagamento";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(24, 263);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(90, 60);
            btnAlterar.TabIndex = 12;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(24, 386);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 60);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(24, 140);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(90, 60);
            btnLocalizar.TabIndex = 11;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(24, 17);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(90, 60);
            btnInserir.TabIndex = 10;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(24, 632);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 60);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "LIMPAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnExcluir);
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Location = new Point(1231, 12);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(136, 706);
            panelBotoes.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(24, 509);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 60);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // formCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name = "formCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra";
            WindowState = FormWindowState.Maximized;
            Load += formCompra_Load;
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensCompra).EndInit();
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelDados;
        private Label lblFornecedorNome;
        private Button btnLocalizarFornecedor;
        private TextBox txtFornecedorID;
        private Label lblFornecedorID;
        private DataGridView dtgvItensCompra;
        private ComboBox cmbTipoPagamento;
        private TextBox txtCompraTotal;
        private Label lblCompraTotal;
        private TextBox txtNotaFiscal;
        private Label lblNotaFiscal;
        private TextBox txtCompraID;
        private Label lblCompra;
        private Label lblTipoPagamento;
        protected Button btnAlterar;
        protected Button btnSalvar;
        protected Button btnLocalizar;
        protected Button btnInserir;
        protected Button btnCancelar;
        protected Panel panelBotoes;
        private Label lblProdutoID;
        private TextBox txtProdutoID;
        private Button btnLocalizarProduto;
        private Label lblProdutoNome;
        private TextBox txtNomeCategoria;
        private Label lblValor;
        private Label lblQtde;
        private TextBox txtValor;
        private TextBox txtQtde;
        private Button btnAddProduto;
        private DataGridViewTextBoxColumn produtoID;
        private DataGridViewTextBoxColumn produtoNome;
        private DataGridViewTextBoxColumn produtoQtde;
        private DataGridViewTextBoxColumn produtoValor;
        private DataGridViewTextBoxColumn produtoValorTotal;
        private Label label2;
        private Label label1;
        protected Button btnExcluir;
    }
}