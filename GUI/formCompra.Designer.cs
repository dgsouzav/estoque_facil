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
            btnAddProduto = new Button();
            txtValor = new TextBox();
            txtQtde = new TextBox();
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
            panelDados.Controls.Add(btnAddProduto);
            panelDados.Controls.Add(txtValor);
            panelDados.Controls.Add(txtQtde);
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
            panelDados.Location = new Point(10, 16);
            panelDados.Margin = new Padding(3, 4, 3, 4);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(1880, 903);
            panelDados.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1613, 856);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 42;
            label2.Text = "R$";
            // 
            // btnAddProduto
            // 
            btnAddProduto.Location = new Point(479, 180);
            btnAddProduto.Margin = new Padding(3, 4, 3, 4);
            btnAddProduto.Name = "btnAddProduto";
            btnAddProduto.Size = new Size(126, 32);
            btnAddProduto.TabIndex = 38;
            btnAddProduto.Text = "ADD PRODUTO";
            btnAddProduto.UseVisualStyleBackColor = true;
            btnAddProduto.Click += btnAddProduto_Click;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(1650, 622);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(226, 56);
            txtValor.TabIndex = 37;
            txtValor.Visible = false;
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(1649, 736);
            txtQtde.Margin = new Padding(3, 4, 3, 4);
            txtQtde.Multiline = true;
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(227, 56);
            txtQtde.TabIndex = 36;
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.BackColor = Color.LightCoral;
            lblQtde.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQtde.Location = new Point(1650, 705);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(111, 25);
            lblQtde.TabIndex = 34;
            lblQtde.Text = "Quantidade";
            // 
            // lblProdutoNome
            // 
            lblProdutoNome.AutoSize = true;
            lblProdutoNome.Location = new Point(358, 159);
            lblProdutoNome.Name = "lblProdutoNome";
            lblProdutoNome.Size = new Size(271, 20);
            lblProdutoNome.TabIndex = 33;
            lblProdutoNome.Text = "Informe o nome do Produto ou localize";
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize = true;
            lblProdutoID.Location = new Point(7, 159);
            lblProdutoID.Name = "lblProdutoID";
            lblProdutoID.Size = new Size(62, 20);
            lblProdutoID.TabIndex = 32;
            lblProdutoID.Text = "Produto";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(7, 181);
            txtProdutoID.Margin = new Padding(3, 4, 3, 4);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.Size = new Size(343, 27);
            txtProdutoID.TabIndex = 5;
            txtProdutoID.Leave += txtProdutoID_Leave;
            // 
            // btnLocalizarProduto
            // 
            btnLocalizarProduto.Location = new Point(358, 180);
            btnLocalizarProduto.Margin = new Padding(3, 4, 3, 4);
            btnLocalizarProduto.Name = "btnLocalizarProduto";
            btnLocalizarProduto.Size = new Size(114, 32);
            btnLocalizarProduto.TabIndex = 6;
            btnLocalizarProduto.Text = "Localizar";
            btnLocalizarProduto.UseVisualStyleBackColor = true;
            btnLocalizarProduto.Click += btnLocalizarProduto_Click;
            // 
            // lblFornecedorNome
            // 
            lblFornecedorNome.AutoSize = true;
            lblFornecedorNome.Location = new Point(358, 92);
            lblFornecedorNome.Name = "lblFornecedorNome";
            lblFornecedorNome.Size = new Size(293, 20);
            lblFornecedorNome.TabIndex = 29;
            lblFornecedorNome.Text = "Informe o nome do Fornecedor ou localize";
            // 
            // btnLocalizarFornecedor
            // 
            btnLocalizarFornecedor.Location = new Point(358, 116);
            btnLocalizarFornecedor.Margin = new Padding(3, 4, 3, 4);
            btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            btnLocalizarFornecedor.Size = new Size(114, 32);
            btnLocalizarFornecedor.TabIndex = 4;
            btnLocalizarFornecedor.Text = "Localizar";
            btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            btnLocalizarFornecedor.Click += btnLocalizarFornecedor_Click_1;
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Location = new Point(7, 116);
            txtFornecedorID.Margin = new Padding(3, 4, 3, 4);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.Size = new Size(343, 27);
            txtFornecedorID.TabIndex = 3;
            txtFornecedorID.Leave += txtFornecedorID_Leave;
            // 
            // lblFornecedorID
            // 
            lblFornecedorID.AutoSize = true;
            lblFornecedorID.Location = new Point(7, 92);
            lblFornecedorID.Name = "lblFornecedorID";
            lblFornecedorID.Size = new Size(84, 20);
            lblFornecedorID.TabIndex = 26;
            lblFornecedorID.Text = "Fornecedor";
            // 
            // dtgvItensCompra
            // 
            dtgvItensCompra.AllowUserToAddRows = false;
            dtgvItensCompra.AllowUserToDeleteRows = false;
            dtgvItensCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvItensCompra.Columns.AddRange(new DataGridViewColumn[] { produtoID, produtoNome, produtoQtde, produtoValor, produtoValorTotal });
            dtgvItensCompra.Location = new Point(7, 231);
            dtgvItensCompra.Margin = new Padding(3, 4, 3, 4);
            dtgvItensCompra.Name = "dtgvItensCompra";
            dtgvItensCompra.ReadOnly = true;
            dtgvItensCompra.RowHeadersWidth = 51;
            dtgvItensCompra.RowTemplate.Height = 25;
            dtgvItensCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvItensCompra.Size = new Size(1601, 668);
            dtgvItensCompra.TabIndex = 22;
            dtgvItensCompra.CellDoubleClick += dtgvItensCompra_CellDoubleClick;
            dtgvItensCompra.CellFormatting += dtgvItensCompra_CellFormatting;
            // 
            // produtoID
            // 
            produtoID.HeaderText = "ID do Produto";
            produtoID.MinimumWidth = 6;
            produtoID.Name = "produtoID";
            produtoID.ReadOnly = true;
            produtoID.Width = 60;
            // 
            // produtoNome
            // 
            produtoNome.HeaderText = "Nome";
            produtoNome.MinimumWidth = 6;
            produtoNome.Name = "produtoNome";
            produtoNome.ReadOnly = true;
            produtoNome.Width = 200;
            // 
            // produtoQtde
            // 
            produtoQtde.HeaderText = "Quantidade";
            produtoQtde.MinimumWidth = 6;
            produtoQtde.Name = "produtoQtde";
            produtoQtde.ReadOnly = true;
            produtoQtde.Width = 125;
            // 
            // produtoValor
            // 
            produtoValor.HeaderText = "Valor unitário";
            produtoValor.MinimumWidth = 6;
            produtoValor.Name = "produtoValor";
            produtoValor.ReadOnly = true;
            produtoValor.Width = 125;
            // 
            // produtoValorTotal
            // 
            produtoValorTotal.HeaderText = "Valor total";
            produtoValorTotal.MinimumWidth = 6;
            produtoValorTotal.Name = "produtoValorTotal";
            produtoValorTotal.ReadOnly = true;
            produtoValorTotal.Width = 125;
            // 
            // cmbTipoPagamento
            // 
            cmbTipoPagamento.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTipoPagamento.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoPagamento.FormattingEnabled = true;
            cmbTipoPagamento.Location = new Point(1614, 41);
            cmbTipoPagamento.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPagamento.Name = "cmbTipoPagamento";
            cmbTipoPagamento.Size = new Size(262, 28);
            cmbTipoPagamento.TabIndex = 8;
            // 
            // txtCompraTotal
            // 
            txtCompraTotal.Enabled = false;
            txtCompraTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompraTotal.Location = new Point(1650, 838);
            txtCompraTotal.Margin = new Padding(3, 4, 3, 4);
            txtCompraTotal.Multiline = true;
            txtCompraTotal.Name = "txtCompraTotal";
            txtCompraTotal.Size = new Size(226, 56);
            txtCompraTotal.TabIndex = 17;
            // 
            // lblCompraTotal
            // 
            lblCompraTotal.AutoSize = true;
            lblCompraTotal.BackColor = Color.LightCoral;
            lblCompraTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompraTotal.Location = new Point(1650, 806);
            lblCompraTotal.Name = "lblCompraTotal";
            lblCompraTotal.Size = new Size(147, 25);
            lblCompraTotal.TabIndex = 16;
            lblCompraTotal.Text = "Total da compra";
            // 
            // txtNotaFiscal
            // 
            txtNotaFiscal.Location = new Point(155, 41);
            txtNotaFiscal.Margin = new Padding(3, 4, 3, 4);
            txtNotaFiscal.Name = "txtNotaFiscal";
            txtNotaFiscal.Size = new Size(195, 27);
            txtNotaFiscal.TabIndex = 1;
            txtNotaFiscal.KeyPress += txtNotaFiscal_KeyPress;
            txtNotaFiscal.Leave += txtNotaFiscal_Leave;
            // 
            // lblNotaFiscal
            // 
            lblNotaFiscal.AutoSize = true;
            lblNotaFiscal.Location = new Point(155, 17);
            lblNotaFiscal.Name = "lblNotaFiscal";
            lblNotaFiscal.Size = new Size(80, 20);
            lblNotaFiscal.TabIndex = 6;
            lblNotaFiscal.Text = "Nota fiscal";
            // 
            // txtCompraID
            // 
            txtCompraID.Enabled = false;
            txtCompraID.Location = new Point(7, 41);
            txtCompraID.Margin = new Padding(3, 4, 3, 4);
            txtCompraID.Name = "txtCompraID";
            txtCompraID.Size = new Size(141, 27);
            txtCompraID.TabIndex = 3;
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.Location = new Point(7, 17);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(136, 20);
            lblCompra.TabIndex = 1;
            lblCompra.Text = "Código da Compra";
            // 
            // lblTipoPagamento
            // 
            lblTipoPagamento.AutoSize = true;
            lblTipoPagamento.Location = new Point(1614, 17);
            lblTipoPagamento.Name = "lblTipoPagamento";
            lblTipoPagamento.Size = new Size(141, 20);
            lblTipoPagamento.TabIndex = 0;
            lblTipoPagamento.Text = "Tipo de pagamento";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(829, 16);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.RightToLeft = RightToLeft.Yes;
            btnAlterar.Size = new Size(121, 64);
            btnAlterar.TabIndex = 12;
            btnAlterar.TabStop = false;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(938, 16);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.RightToLeft = RightToLeft.Yes;
            btnSalvar.Size = new Size(121, 64);
            btnSalvar.TabIndex = 13;
            btnSalvar.TabStop = false;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(720, 16);
            btnLocalizar.Margin = new Padding(3, 4, 3, 4);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.RightToLeft = RightToLeft.Yes;
            btnLocalizar.Size = new Size(121, 64);
            btnLocalizar.TabIndex = 11;
            btnLocalizar.TabStop = false;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(611, 16);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.RightToLeft = RightToLeft.Yes;
            btnInserir.Size = new Size(121, 64);
            btnInserir.TabIndex = 10;
            btnInserir.TabStop = false;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1156, 16);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.RightToLeft = RightToLeft.Yes;
            btnCancelar.Size = new Size(121, 64);
            btnCancelar.TabIndex = 15;
            btnCancelar.TabStop = false;
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
            panelBotoes.Location = new Point(12, 927);
            panelBotoes.Margin = new Padding(3, 4, 3, 4);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(1878, 93);
            panelBotoes.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(1047, 16);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.RightToLeft = RightToLeft.Yes;
            btnExcluir.Size = new Size(121, 64);
            btnExcluir.TabIndex = 14;
            btnExcluir.TabStop = false;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // formCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Margin = new Padding(3, 4, 3, 4);
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
        protected Button btnExcluir;
    }
}