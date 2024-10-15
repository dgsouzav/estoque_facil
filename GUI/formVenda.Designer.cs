namespace UI
{
    partial class formVenda
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
            btnCancelarVenda = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panelDados = new Panel();
            txtTroco = new TextBox();
            lblTroco = new Label();
            listBoxClientes = new ListBox();
            lblCaixaLivre = new Label();
            txtValorPago = new TextBox();
            lblValorPago = new Label();
            checkBoxVerificaEstoque = new CheckBox();
            btnAddProduto = new Button();
            txtValor = new TextBox();
            txtQtde = new TextBox();
            lblQtde = new Label();
            lblProdutoNome = new Label();
            lblCliente = new Label();
            lblProdutoID = new Label();
            txtClienteFidelidade = new TextBox();
            txtProdutoID = new TextBox();
            btnLocalizarProduto = new Button();
            dtgvItensVenda = new DataGridView();
            produtoID = new DataGridViewTextBoxColumn();
            produtoNome = new DataGridViewTextBoxColumn();
            produtoQtde = new DataGridViewTextBoxColumn();
            produtoValor = new DataGridViewTextBoxColumn();
            produtoValorTotal = new DataGridViewTextBoxColumn();
            cmbTipoPagamento = new ComboBox();
            txtVendaTotal = new TextBox();
            lblVendaTotal = new Label();
            txtNotaFiscal = new TextBox();
            lblNotaFiscal = new Label();
            txtVendaID = new TextBox();
            lblVenda = new Label();
            lblTipoPagamento = new Label();
            panelBotoes.SuspendLayout();
            panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensVenda).BeginInit();
            SuspendLayout();
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelarVenda);
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Location = new Point(14, 948);
            panelBotoes.Margin = new Padding(3, 4, 3, 4);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(1876, 72);
            panelBotoes.TabIndex = 6;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Location = new Point(865, 4);
            btnCancelarVenda.Margin = new Padding(3, 4, 3, 4);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(120, 64);
            btnCancelarVenda.TabIndex = 16;
            btnCancelarVenda.Text = "CANCELAR(F4)";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            btnCancelarVenda.Click += btnCancelarVenda_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(992, 4);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 64);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "LIMPAR(F5)";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(737, 4);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(121, 64);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "SALVAR(F3)";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtTroco);
            panelDados.Controls.Add(lblTroco);
            panelDados.Controls.Add(listBoxClientes);
            panelDados.Controls.Add(lblCaixaLivre);
            panelDados.Controls.Add(txtValorPago);
            panelDados.Controls.Add(lblValorPago);
            panelDados.Controls.Add(checkBoxVerificaEstoque);
            panelDados.Controls.Add(btnAddProduto);
            panelDados.Controls.Add(txtValor);
            panelDados.Controls.Add(txtQtde);
            panelDados.Controls.Add(lblQtde);
            panelDados.Controls.Add(lblProdutoNome);
            panelDados.Controls.Add(lblCliente);
            panelDados.Controls.Add(lblProdutoID);
            panelDados.Controls.Add(txtClienteFidelidade);
            panelDados.Controls.Add(txtProdutoID);
            panelDados.Controls.Add(btnLocalizarProduto);
            panelDados.Controls.Add(dtgvItensVenda);
            panelDados.Controls.Add(cmbTipoPagamento);
            panelDados.Controls.Add(txtVendaTotal);
            panelDados.Controls.Add(lblVendaTotal);
            panelDados.Controls.Add(txtNotaFiscal);
            panelDados.Controls.Add(lblNotaFiscal);
            panelDados.Controls.Add(txtVendaID);
            panelDados.Controls.Add(lblVenda);
            panelDados.Controls.Add(lblTipoPagamento);
            panelDados.Location = new Point(14, 16);
            panelDados.Margin = new Padding(3, 4, 3, 4);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(1876, 924);
            panelDados.TabIndex = 5;
            // 
            // txtTroco
            // 
            txtTroco.Enabled = false;
            txtTroco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTroco.Location = new Point(1641, 858);
            txtTroco.Margin = new Padding(3, 4, 3, 4);
            txtTroco.Multiline = true;
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(226, 56);
            txtTroco.TabIndex = 52;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.LightCoral;
            lblTroco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTroco.Location = new Point(1641, 828);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(58, 25);
            lblTroco.TabIndex = 53;
            lblTroco.Text = "Troco";
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 20;
            listBoxClientes.Location = new Point(1641, 145);
            listBoxClientes.Margin = new Padding(3, 4, 3, 4);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(226, 184);
            listBoxClientes.TabIndex = 49;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            // 
            // lblCaixaLivre
            // 
            lblCaixaLivre.AutoSize = true;
            lblCaixaLivre.BackColor = Color.Lime;
            lblCaixaLivre.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaixaLivre.ForeColor = Color.Black;
            lblCaixaLivre.Location = new Point(767, 27);
            lblCaixaLivre.Name = "lblCaixaLivre";
            lblCaixaLivre.Size = new Size(364, 81);
            lblCaixaLivre.TabIndex = 47;
            lblCaixaLivre.Text = "CAIXA LIVRE";
            // 
            // txtValorPago
            // 
            txtValorPago.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPago.Location = new Point(1641, 766);
            txtValorPago.Margin = new Padding(3, 4, 3, 4);
            txtValorPago.Multiline = true;
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(226, 56);
            txtValorPago.TabIndex = 44;
            txtValorPago.TextChanged += txtValorPago_TextChanged;
            txtValorPago.KeyPress += txtValorPago_KeyPress_1;
            txtValorPago.Leave += txtValorPago_Leave;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.BackColor = Color.LightCoral;
            lblValorPago.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorPago.Location = new Point(1641, 736);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(104, 25);
            lblValorPago.TabIndex = 45;
            lblValorPago.Text = "Valor pago";
            // 
            // checkBoxVerificaEstoque
            // 
            checkBoxVerificaEstoque.AutoSize = true;
            checkBoxVerificaEstoque.Location = new Point(3, 184);
            checkBoxVerificaEstoque.Margin = new Padding(3, 4, 3, 4);
            checkBoxVerificaEstoque.Name = "checkBoxVerificaEstoque";
            checkBoxVerificaEstoque.Size = new Size(332, 24);
            checkBoxVerificaEstoque.TabIndex = 43;
            checkBoxVerificaEstoque.Text = "Verificar quantidade de produtos em estoque";
            checkBoxVerificaEstoque.UseVisualStyleBackColor = true;
            // 
            // btnAddProduto
            // 
            btnAddProduto.Enabled = false;
            btnAddProduto.Location = new Point(375, 37);
            btnAddProduto.Margin = new Padding(3, 4, 3, 4);
            btnAddProduto.Name = "btnAddProduto";
            btnAddProduto.Size = new Size(128, 32);
            btnAddProduto.TabIndex = 7;
            btnAddProduto.Text = "ADD PRODUTO";
            btnAddProduto.UseVisualStyleBackColor = true;
            btnAddProduto.Visible = false;
            btnAddProduto.Click += btnAddProduto_Click;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(1641, 491);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(226, 56);
            txtValor.TabIndex = 6;
            txtValor.Visible = false;
            // 
            // txtQtde
            // 
            txtQtde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtde.Location = new Point(375, 127);
            txtQtde.Margin = new Padding(3, 4, 3, 4);
            txtQtde.Multiline = true;
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(114, 32);
            txtQtde.TabIndex = 5;
            txtQtde.KeyPress += txtQtde_KeyPress_1;
            txtQtde.Leave += txtQtde_Leave;
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.BackColor = SystemColors.Control;
            lblQtde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblQtde.Location = new Point(375, 103);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(87, 20);
            lblQtde.TabIndex = 34;
            lblQtde.Text = "Quantidade";
            // 
            // lblProdutoNome
            // 
            lblProdutoNome.AutoSize = true;
            lblProdutoNome.Location = new Point(240, 103);
            lblProdutoNome.Name = "lblProdutoNome";
            lblProdutoNome.Size = new Size(108, 20);
            lblProdutoNome.TabIndex = 33;
            lblProdutoNome.Text = "Nome produto";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(1641, 88);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(129, 20);
            lblCliente.TabIndex = 32;
            lblCliente.Text = "Cliente Fidelidade";
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize = true;
            lblProdutoID.Location = new Point(2, 103);
            lblProdutoID.Name = "lblProdutoID";
            lblProdutoID.Size = new Size(62, 20);
            lblProdutoID.TabIndex = 32;
            lblProdutoID.Text = "Produto";
            // 
            // txtClienteFidelidade
            // 
            txtClienteFidelidade.Location = new Point(1641, 112);
            txtClienteFidelidade.Margin = new Padding(3, 4, 3, 4);
            txtClienteFidelidade.Name = "txtClienteFidelidade";
            txtClienteFidelidade.Size = new Size(226, 27);
            txtClienteFidelidade.TabIndex = 3;
            txtClienteFidelidade.TextChanged += txtClienteFidelidade_TextChanged;
            txtClienteFidelidade.Leave += txtProdutoID_Leave;
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(3, 127);
            txtProdutoID.Margin = new Padding(3, 4, 3, 4);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.Size = new Size(230, 27);
            txtProdutoID.TabIndex = 3;
            txtProdutoID.Leave += txtProdutoID_Leave;
            // 
            // btnLocalizarProduto
            // 
            btnLocalizarProduto.Location = new Point(240, 127);
            btnLocalizarProduto.Margin = new Padding(3, 4, 3, 4);
            btnLocalizarProduto.Name = "btnLocalizarProduto";
            btnLocalizarProduto.Size = new Size(129, 32);
            btnLocalizarProduto.TabIndex = 4;
            btnLocalizarProduto.Text = "Localizar";
            btnLocalizarProduto.UseVisualStyleBackColor = true;
            btnLocalizarProduto.Click += btnLocalizarProduto_Click;
            // 
            // dtgvItensVenda
            // 
            dtgvItensVenda.AllowUserToAddRows = false;
            dtgvItensVenda.AllowUserToDeleteRows = false;
            dtgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvItensVenda.Columns.AddRange(new DataGridViewColumn[] { produtoID, produtoNome, produtoQtde, produtoValor, produtoValorTotal });
            dtgvItensVenda.Location = new Point(3, 217);
            dtgvItensVenda.Margin = new Padding(3, 4, 3, 4);
            dtgvItensVenda.Name = "dtgvItensVenda";
            dtgvItensVenda.ReadOnly = true;
            dtgvItensVenda.RowHeadersWidth = 51;
            dtgvItensVenda.RowTemplate.Height = 25;
            dtgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvItensVenda.Size = new Size(1597, 703);
            dtgvItensVenda.TabIndex = 22;
            dtgvItensVenda.CellDoubleClick += dtgvItensVenda_CellDoubleClick;
            dtgvItensVenda.CellFormatting += dtgvItensVenda_CellFormatting;
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
            cmbTipoPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoPagamento.FormattingEnabled = true;
            cmbTipoPagamento.Location = new Point(1641, 40);
            cmbTipoPagamento.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPagamento.Name = "cmbTipoPagamento";
            cmbTipoPagamento.Size = new Size(226, 29);
            cmbTipoPagamento.TabIndex = 10;
            // 
            // txtVendaTotal
            // 
            txtVendaTotal.Enabled = false;
            txtVendaTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtVendaTotal.Location = new Point(1641, 674);
            txtVendaTotal.Margin = new Padding(3, 4, 3, 4);
            txtVendaTotal.Multiline = true;
            txtVendaTotal.Name = "txtVendaTotal";
            txtVendaTotal.Size = new Size(226, 56);
            txtVendaTotal.TabIndex = 12;
            txtVendaTotal.TextChanged += txtVendaTotal_TextChanged;
            // 
            // lblVendaTotal
            // 
            lblVendaTotal.AutoSize = true;
            lblVendaTotal.BackColor = Color.LightCoral;
            lblVendaTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendaTotal.Location = new Point(1641, 644);
            lblVendaTotal.Name = "lblVendaTotal";
            lblVendaTotal.Size = new Size(136, 25);
            lblVendaTotal.TabIndex = 16;
            lblVendaTotal.Text = "Total da Venda";
            // 
            // txtNotaFiscal
            // 
            txtNotaFiscal.Location = new Point(125, 40);
            txtNotaFiscal.Margin = new Padding(3, 4, 3, 4);
            txtNotaFiscal.Name = "txtNotaFiscal";
            txtNotaFiscal.Size = new Size(229, 27);
            txtNotaFiscal.TabIndex = 1;
            txtNotaFiscal.KeyPress += txtNotaFiscal_KeyPress;
            txtNotaFiscal.Leave += txtNotaFiscal_Leave;
            // 
            // lblNotaFiscal
            // 
            lblNotaFiscal.AutoSize = true;
            lblNotaFiscal.Location = new Point(125, 16);
            lblNotaFiscal.Name = "lblNotaFiscal";
            lblNotaFiscal.Size = new Size(80, 20);
            lblNotaFiscal.TabIndex = 6;
            lblNotaFiscal.Text = "Nota fiscal";
            // 
            // txtVendaID
            // 
            txtVendaID.Enabled = false;
            txtVendaID.Location = new Point(2, 40);
            txtVendaID.Margin = new Padding(3, 4, 3, 4);
            txtVendaID.Name = "txtVendaID";
            txtVendaID.Size = new Size(115, 27);
            txtVendaID.TabIndex = 3;
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Location = new Point(3, 16);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(128, 20);
            lblVenda.TabIndex = 1;
            lblVenda.Text = "Código da Venda ";
            // 
            // lblTipoPagamento
            // 
            lblTipoPagamento.AutoSize = true;
            lblTipoPagamento.Location = new Point(1641, 16);
            lblTipoPagamento.Name = "lblTipoPagamento";
            lblTipoPagamento.Size = new Size(141, 20);
            lblTipoPagamento.TabIndex = 0;
            lblTipoPagamento.Text = "Tipo de pagamento";
            // 
            // formVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda";
            WindowState = FormWindowState.Maximized;
            Load += formVenda_Load;
            KeyDown += formVenda_KeyDown;
            panelBotoes.ResumeLayout(false);
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensVenda).EndInit();
            ResumeLayout(false);
        }

        #endregion
        protected Panel panelBotoes;
        protected Button btnCancelarVenda;
        protected Button btnCancelar;
        protected Button btnSalvar;
        protected Panel panelDados;
        private Button btnAddProduto;
        private TextBox txtValor;
        private TextBox txtQtde;
        private Label lblQtde;
        private Label lblProdutoNome;
        private Label lblProdutoID;
        private TextBox txtProdutoID;
        private Button btnLocalizarProduto;
        private DataGridView dtgvItensVenda;
        private DataGridViewTextBoxColumn produtoID;
        private DataGridViewTextBoxColumn produtoNome;
        private DataGridViewTextBoxColumn produtoQtde;
        private DataGridViewTextBoxColumn produtoValor;
        private DataGridViewTextBoxColumn produtoValorTotal;
        private ComboBox cmbTipoPagamento;
        private TextBox txtVendaTotal;
        private Label lblVendaTotal;
        private TextBox txtNotaFiscal;
        private Label lblNotaFiscal;
        private TextBox txtVendaID;
        private Label lblVenda;
        private Label lblTipoPagamento;
        private CheckBox checkBoxVerificaEstoque;
        private TextBox txtValorPago;
        private Label lblValorPago;
        private Label lblCaixaLivre;
        private Label lblCliente;
        private TextBox txtClienteFidelidade;
        private ListBox listBoxClientes;
        private TextBox txtTroco;
        private Label lblTroco;
    }
}