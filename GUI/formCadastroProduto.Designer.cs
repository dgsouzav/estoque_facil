namespace UI
{
    partial class formCadastroProduto
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
            btnCancelar = new Button();
            btnInserir = new Button();
            btnLocalizar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            panelDados = new Panel();
            cmbFornecedorID = new ComboBox();
            lblFornecedor = new Label();
            cmbUndMedID = new ComboBox();
            cmbCategoriaID = new ComboBox();
            cmbSubCategoriaID = new ComboBox();
            lblUnidadeMedidaID = new Label();
            lblCategoriaID = new Label();
            lblSubCategoriaID = new Label();
            txtValorPagoProduto = new TextBox();
            txtLoteProduto = new TextBox();
            txtValorVendaProduto = new TextBox();
            lblLoteProduto = new Label();
            lblValorVendaProduto = new Label();
            lblValorPagoProduto = new Label();
            lblDescricaoProduto = new Label();
            txtDescricaoProduto = new TextBox();
            txtProdutoID = new TextBox();
            txtNomeProduto = new TextBox();
            lblProdutoID = new Label();
            lblNomeProduto = new Label();
            txtProdutoValidade = new TextBox();
            ProdutoValidade = new Label();
            panelBotoes.SuspendLayout();
            panelDados.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Location = new Point(633, 17);
            panelBotoes.Margin = new Padding(3, 4, 3, 4);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(135, 524);
            panelBotoes.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(21, 429);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 80);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "LIMPAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(21, 14);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(91, 80);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(21, 115);
            btnLocalizar.Margin = new Padding(3, 4, 3, 4);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(91, 80);
            btnLocalizar.TabIndex = 10;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(21, 328);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 80);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(21, 216);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(91, 80);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtProdutoValidade);
            panelDados.Controls.Add(ProdutoValidade);
            panelDados.Controls.Add(cmbFornecedorID);
            panelDados.Controls.Add(lblFornecedor);
            panelDados.Controls.Add(cmbUndMedID);
            panelDados.Controls.Add(cmbCategoriaID);
            panelDados.Controls.Add(cmbSubCategoriaID);
            panelDados.Controls.Add(lblUnidadeMedidaID);
            panelDados.Controls.Add(lblCategoriaID);
            panelDados.Controls.Add(lblSubCategoriaID);
            panelDados.Controls.Add(txtValorPagoProduto);
            panelDados.Controls.Add(txtLoteProduto);
            panelDados.Controls.Add(txtValorVendaProduto);
            panelDados.Controls.Add(lblLoteProduto);
            panelDados.Controls.Add(lblValorVendaProduto);
            panelDados.Controls.Add(lblValorPagoProduto);
            panelDados.Controls.Add(lblDescricaoProduto);
            panelDados.Controls.Add(txtDescricaoProduto);
            panelDados.Controls.Add(txtProdutoID);
            panelDados.Controls.Add(txtNomeProduto);
            panelDados.Controls.Add(lblProdutoID);
            panelDados.Controls.Add(lblNomeProduto);
            panelDados.Location = new Point(14, 17);
            panelDados.Margin = new Padding(3, 4, 3, 4);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(613, 524);
            panelDados.TabIndex = 2;
            // 
            // cmbFornecedorID
            // 
            cmbFornecedorID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFornecedorID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFornecedorID.FormattingEnabled = true;
            cmbFornecedorID.Location = new Point(323, 265);
            cmbFornecedorID.Margin = new Padding(3, 4, 3, 4);
            cmbFornecedorID.Name = "cmbFornecedorID";
            cmbFornecedorID.Size = new Size(285, 28);
            cmbFornecedorID.TabIndex = 17;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(323, 241);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(84, 20);
            lblFornecedor.TabIndex = 16;
            lblFornecedor.Text = "Fornecedor";
            // 
            // cmbUndMedID
            // 
            cmbUndMedID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbUndMedID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUndMedID.FormattingEnabled = true;
            cmbUndMedID.Location = new Point(323, 40);
            cmbUndMedID.Margin = new Padding(3, 4, 3, 4);
            cmbUndMedID.Name = "cmbUndMedID";
            cmbUndMedID.Size = new Size(285, 28);
            cmbUndMedID.TabIndex = 6;
            // 
            // cmbCategoriaID
            // 
            cmbCategoriaID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCategoriaID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoriaID.FormattingEnabled = true;
            cmbCategoriaID.Location = new Point(323, 115);
            cmbCategoriaID.Margin = new Padding(3, 4, 3, 4);
            cmbCategoriaID.Name = "cmbCategoriaID";
            cmbCategoriaID.Size = new Size(285, 28);
            cmbCategoriaID.TabIndex = 7;
            cmbCategoriaID.SelectedIndexChanged += cmbCategoriaID_SelectedIndexChanged;
            // 
            // cmbSubCategoriaID
            // 
            cmbSubCategoriaID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSubCategoriaID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSubCategoriaID.FormattingEnabled = true;
            cmbSubCategoriaID.Location = new Point(323, 188);
            cmbSubCategoriaID.Margin = new Padding(3, 4, 3, 4);
            cmbSubCategoriaID.Name = "cmbSubCategoriaID";
            cmbSubCategoriaID.Size = new Size(285, 28);
            cmbSubCategoriaID.TabIndex = 8;
            // 
            // lblUnidadeMedidaID
            // 
            lblUnidadeMedidaID.AutoSize = true;
            lblUnidadeMedidaID.Location = new Point(323, 17);
            lblUnidadeMedidaID.Name = "lblUnidadeMedidaID";
            lblUnidadeMedidaID.Size = new Size(141, 20);
            lblUnidadeMedidaID.TabIndex = 14;
            lblUnidadeMedidaID.Text = "Unidade de Medida";
            // 
            // lblCategoriaID
            // 
            lblCategoriaID.AutoSize = true;
            lblCategoriaID.Location = new Point(323, 89);
            lblCategoriaID.Name = "lblCategoriaID";
            lblCategoriaID.Size = new Size(74, 20);
            lblCategoriaID.TabIndex = 13;
            lblCategoriaID.Text = "Categoria";
            // 
            // lblSubCategoriaID
            // 
            lblSubCategoriaID.AutoSize = true;
            lblSubCategoriaID.Location = new Point(323, 164);
            lblSubCategoriaID.Name = "lblSubCategoriaID";
            lblSubCategoriaID.Size = new Size(103, 20);
            lblSubCategoriaID.TabIndex = 12;
            lblSubCategoriaID.Text = "Sub Categoria";
            // 
            // txtValorPagoProduto
            // 
            txtValorPagoProduto.Location = new Point(3, 314);
            txtValorPagoProduto.Margin = new Padding(3, 4, 3, 4);
            txtValorPagoProduto.Name = "txtValorPagoProduto";
            txtValorPagoProduto.Size = new Size(147, 27);
            txtValorPagoProduto.TabIndex = 3;
            txtValorPagoProduto.TextChanged += txtValorPagoProduto_TextChanged;
            txtValorPagoProduto.KeyPress += txtValorPagoProduto_KeyPress;
            txtValorPagoProduto.Leave += txtValorPagoProduto_Leave;
            // 
            // txtLoteProduto
            // 
            txtLoteProduto.Location = new Point(3, 383);
            txtLoteProduto.Margin = new Padding(3, 4, 3, 4);
            txtLoteProduto.Name = "txtLoteProduto";
            txtLoteProduto.Size = new Size(147, 27);
            txtLoteProduto.TabIndex = 4;
            // 
            // txtValorVendaProduto
            // 
            txtValorVendaProduto.Location = new Point(3, 454);
            txtValorVendaProduto.Margin = new Padding(3, 4, 3, 4);
            txtValorVendaProduto.Name = "txtValorVendaProduto";
            txtValorVendaProduto.Size = new Size(147, 27);
            txtValorVendaProduto.TabIndex = 5;
            txtValorVendaProduto.TextChanged += txtValorVendaProduto_TextChanged;
            txtValorVendaProduto.KeyPress += txtValorVendaProduto_KeyPress;
            txtValorVendaProduto.Leave += txtValorVendaProduto_Leave;
            // 
            // lblLoteProduto
            // 
            lblLoteProduto.AutoSize = true;
            lblLoteProduto.Location = new Point(3, 359);
            lblLoteProduto.Name = "lblLoteProduto";
            lblLoteProduto.Size = new Size(117, 20);
            lblLoteProduto.TabIndex = 8;
            lblLoteProduto.Text = "Lote do Produto";
            // 
            // lblValorVendaProduto
            // 
            lblValorVendaProduto.AutoSize = true;
            lblValorVendaProduto.Location = new Point(3, 429);
            lblValorVendaProduto.Name = "lblValorVendaProduto";
            lblValorVendaProduto.Size = new Size(108, 20);
            lblValorVendaProduto.TabIndex = 7;
            lblValorVendaProduto.Text = "Valor de venda";
            // 
            // lblValorPagoProduto
            // 
            lblValorPagoProduto.AutoSize = true;
            lblValorPagoProduto.Location = new Point(3, 289);
            lblValorPagoProduto.Name = "lblValorPagoProduto";
            lblValorPagoProduto.Size = new Size(82, 20);
            lblValorPagoProduto.TabIndex = 6;
            lblValorPagoProduto.Text = "Valor pago";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Location = new Point(3, 164);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(153, 20);
            lblDescricaoProduto.TabIndex = 5;
            lblDescricaoProduto.Text = "Descrição do Produto";
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.Location = new Point(3, 188);
            txtDescricaoProduto.Margin = new Padding(3, 4, 3, 4);
            txtDescricaoProduto.Multiline = true;
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(293, 79);
            txtDescricaoProduto.TabIndex = 2;
            // 
            // txtProdutoID
            // 
            txtProdutoID.Enabled = false;
            txtProdutoID.Location = new Point(3, 41);
            txtProdutoID.Margin = new Padding(3, 4, 3, 4);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.Size = new Size(114, 27);
            txtProdutoID.TabIndex = 3;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(3, 115);
            txtNomeProduto.Margin = new Padding(3, 4, 3, 4);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(293, 27);
            txtNomeProduto.TabIndex = 1;
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize = true;
            lblProdutoID.Location = new Point(3, 17);
            lblProdutoID.Name = "lblProdutoID";
            lblProdutoID.Size = new Size(107, 20);
            lblProdutoID.TabIndex = 1;
            lblProdutoID.Text = "ID do Produto ";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(3, 89);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(129, 20);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // txtProdutoValidade
            // 
            txtProdutoValidade.Location = new Point(161, 314);
            txtProdutoValidade.Margin = new Padding(3, 4, 3, 4);
            txtProdutoValidade.Name = "txtProdutoValidade";
            txtProdutoValidade.Size = new Size(135, 27);
            txtProdutoValidade.TabIndex = 18;
            // 
            // ProdutoValidade
            // 
            ProdutoValidade.AutoSize = true;
            ProdutoValidade.Location = new Point(161, 289);
            ProdutoValidade.Name = "ProdutoValidade";
            ProdutoValidade.Size = new Size(67, 20);
            ProdutoValidade.TabIndex = 19;
            ProdutoValidade.Text = "Validade";
            // 
            // formCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 557);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += formCadastroProduto_Load;
            panelBotoes.ResumeLayout(false);
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelBotoes;
        protected Button btnCancelar;
        protected Button btnInserir;
        protected Button btnLocalizar;
        protected Button btnSalvar;
        protected Button btnAlterar;
        protected Panel panelDados;
        private TextBox txtProdutoID;
        private TextBox txtNomeProduto;
        private Label lblProdutoID;
        private Label lblNomeProduto;
        private Label lblDescricaoProduto;
        private TextBox txtDescricaoProduto;
        private Label lblValorPagoProduto;
        private Label lblLoteProduto;
        private Label lblValorVendaProduto;
        private TextBox txtLoteProduto;
        private TextBox txtValorVendaProduto;
        private Label lblUnidadeMedidaID;
        private Label lblCategoriaID;
        private Label lblSubCategoriaID;
        private ComboBox cmbUndMedID;
        private ComboBox cmbCategoriaID;
        private ComboBox cmbSubCategoriaID;
        private Label lblFornecedor;
        private ComboBox cmbFornecedorID;
        private TextBox txtValorPagoProduto;
        private TextBox txtProdutoValidade;
        private Label ProdutoValidade;
    }
}