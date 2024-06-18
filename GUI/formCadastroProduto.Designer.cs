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
            panelBotoes.Location = new Point(633, 16);
            panelBotoes.Margin = new Padding(3, 4, 3, 4);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(135, 498);
            panelBotoes.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(21, 408);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 76);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "LIMPAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(21, 13);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(91, 76);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(21, 109);
            btnLocalizar.Margin = new Padding(3, 4, 3, 4);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(91, 76);
            btnLocalizar.TabIndex = 10;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(21, 312);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 76);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(21, 205);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(91, 76);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // panelDados
            // 
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
            panelDados.Location = new Point(14, 16);
            panelDados.Margin = new Padding(3, 4, 3, 4);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(613, 498);
            panelDados.TabIndex = 2;
            // 
            // cmbFornecedorID
            // 
            cmbFornecedorID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFornecedorID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFornecedorID.FormattingEnabled = true;
            cmbFornecedorID.Location = new Point(323, 252);
            cmbFornecedorID.Margin = new Padding(3, 4, 3, 4);
            cmbFornecedorID.Name = "cmbFornecedorID";
            cmbFornecedorID.Size = new Size(285, 27);
            cmbFornecedorID.TabIndex = 17;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(323, 229);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(78, 19);
            lblFornecedor.TabIndex = 16;
            lblFornecedor.Text = "Fornecedor";
            // 
            // cmbUndMedID
            // 
            cmbUndMedID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbUndMedID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUndMedID.FormattingEnabled = true;
            cmbUndMedID.Location = new Point(323, 38);
            cmbUndMedID.Margin = new Padding(3, 4, 3, 4);
            cmbUndMedID.Name = "cmbUndMedID";
            cmbUndMedID.Size = new Size(285, 27);
            cmbUndMedID.TabIndex = 6;
            // 
            // cmbCategoriaID
            // 
            cmbCategoriaID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCategoriaID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoriaID.FormattingEnabled = true;
            cmbCategoriaID.Location = new Point(323, 109);
            cmbCategoriaID.Margin = new Padding(3, 4, 3, 4);
            cmbCategoriaID.Name = "cmbCategoriaID";
            cmbCategoriaID.Size = new Size(285, 27);
            cmbCategoriaID.TabIndex = 7;
            cmbCategoriaID.SelectedIndexChanged += cmbCategoriaID_SelectedIndexChanged;
            // 
            // cmbSubCategoriaID
            // 
            cmbSubCategoriaID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSubCategoriaID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSubCategoriaID.FormattingEnabled = true;
            cmbSubCategoriaID.Location = new Point(323, 179);
            cmbSubCategoriaID.Margin = new Padding(3, 4, 3, 4);
            cmbSubCategoriaID.Name = "cmbSubCategoriaID";
            cmbSubCategoriaID.Size = new Size(285, 27);
            cmbSubCategoriaID.TabIndex = 8;
            // 
            // lblUnidadeMedidaID
            // 
            lblUnidadeMedidaID.AutoSize = true;
            lblUnidadeMedidaID.Location = new Point(323, 16);
            lblUnidadeMedidaID.Name = "lblUnidadeMedidaID";
            lblUnidadeMedidaID.Size = new Size(129, 19);
            lblUnidadeMedidaID.TabIndex = 14;
            lblUnidadeMedidaID.Text = "Unidade de Medida";
            // 
            // lblCategoriaID
            // 
            lblCategoriaID.AutoSize = true;
            lblCategoriaID.Location = new Point(323, 85);
            lblCategoriaID.Name = "lblCategoriaID";
            lblCategoriaID.Size = new Size(68, 19);
            lblCategoriaID.TabIndex = 13;
            lblCategoriaID.Text = "Categoria";
            // 
            // lblSubCategoriaID
            // 
            lblSubCategoriaID.AutoSize = true;
            lblSubCategoriaID.Location = new Point(323, 156);
            lblSubCategoriaID.Name = "lblSubCategoriaID";
            lblSubCategoriaID.Size = new Size(95, 19);
            lblSubCategoriaID.TabIndex = 12;
            lblSubCategoriaID.Text = "Sub Categoria";
            // 
            // txtValorPagoProduto
            // 
            txtValorPagoProduto.Location = new Point(3, 298);
            txtValorPagoProduto.Margin = new Padding(3, 4, 3, 4);
            txtValorPagoProduto.Name = "txtValorPagoProduto";
            txtValorPagoProduto.Size = new Size(147, 26);
            txtValorPagoProduto.TabIndex = 3;
            txtValorPagoProduto.TextChanged += txtValorPagoProduto_TextChanged;
            txtValorPagoProduto.KeyPress += txtValorPagoProduto_KeyPress;
            txtValorPagoProduto.Leave += txtValorPagoProduto_Leave;
            // 
            // txtLoteProduto
            // 
            txtLoteProduto.Location = new Point(3, 364);
            txtLoteProduto.Margin = new Padding(3, 4, 3, 4);
            txtLoteProduto.Name = "txtLoteProduto";
            txtLoteProduto.Size = new Size(147, 26);
            txtLoteProduto.TabIndex = 4;
            // 
            // txtValorVendaProduto
            // 
            txtValorVendaProduto.Location = new Point(3, 431);
            txtValorVendaProduto.Margin = new Padding(3, 4, 3, 4);
            txtValorVendaProduto.Name = "txtValorVendaProduto";
            txtValorVendaProduto.Size = new Size(147, 26);
            txtValorVendaProduto.TabIndex = 5;
            txtValorVendaProduto.TextChanged += txtValorVendaProduto_TextChanged;
            txtValorVendaProduto.KeyPress += txtValorVendaProduto_KeyPress;
            txtValorVendaProduto.Leave += txtValorVendaProduto_Leave;
            // 
            // lblLoteProduto
            // 
            lblLoteProduto.AutoSize = true;
            lblLoteProduto.Location = new Point(3, 341);
            lblLoteProduto.Name = "lblLoteProduto";
            lblLoteProduto.Size = new Size(110, 19);
            lblLoteProduto.TabIndex = 8;
            lblLoteProduto.Text = "Lote do Produto";
            // 
            // lblValorVendaProduto
            // 
            lblValorVendaProduto.AutoSize = true;
            lblValorVendaProduto.Location = new Point(3, 408);
            lblValorVendaProduto.Name = "lblValorVendaProduto";
            lblValorVendaProduto.Size = new Size(100, 19);
            lblValorVendaProduto.TabIndex = 7;
            lblValorVendaProduto.Text = "Valor de venda";
            // 
            // lblValorPagoProduto
            // 
            lblValorPagoProduto.AutoSize = true;
            lblValorPagoProduto.Location = new Point(3, 275);
            lblValorPagoProduto.Name = "lblValorPagoProduto";
            lblValorPagoProduto.Size = new Size(75, 19);
            lblValorPagoProduto.TabIndex = 6;
            lblValorPagoProduto.Text = "Valor pago";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Location = new Point(3, 156);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(141, 19);
            lblDescricaoProduto.TabIndex = 5;
            lblDescricaoProduto.Text = "Descrição do Produto";
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.Location = new Point(3, 179);
            txtDescricaoProduto.Margin = new Padding(3, 4, 3, 4);
            txtDescricaoProduto.Multiline = true;
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(293, 75);
            txtDescricaoProduto.TabIndex = 2;
            // 
            // txtProdutoID
            // 
            txtProdutoID.Enabled = false;
            txtProdutoID.Location = new Point(3, 39);
            txtProdutoID.Margin = new Padding(3, 4, 3, 4);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.Size = new Size(114, 26);
            txtProdutoID.TabIndex = 3;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(3, 109);
            txtNomeProduto.Margin = new Padding(3, 4, 3, 4);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(293, 26);
            txtNomeProduto.TabIndex = 1;
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize = true;
            lblProdutoID.Location = new Point(3, 16);
            lblProdutoID.Name = "lblProdutoID";
            lblProdutoID.Size = new Size(101, 19);
            lblProdutoID.TabIndex = 1;
            lblProdutoID.Text = "ID do Produto ";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(3, 85);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(120, 19);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // formCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 529);
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
    }
}