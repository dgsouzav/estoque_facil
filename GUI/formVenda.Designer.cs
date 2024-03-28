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
            panelFinalizaVenda = new Panel();
            label4 = new Label();
            lbl0000 = new Label();
            txtTroco = new TextBox();
            lblVendaTotal2 = new Label();
            lblTroco = new Label();
            btnCancelarPagamento = new Button();
            btnSalvarPagamento = new Button();
            lblParcelasVenda = new Label();
            lblTraço = new Label();
            lblDadosPagamento = new Label();
            dtgvParcelasVenda = new DataGridView();
            parcelaID = new DataGridViewTextBoxColumn();
            parcelaValorPagamento = new DataGridViewTextBoxColumn();
            parcelaDataVencimento = new DataGridViewTextBoxColumn();
            panelBotoes = new Panel();
            btnCancelarVenda = new Button();
            btnCancelar = new Button();
            btnInserir = new Button();
            btnLocalizar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            panelDados = new Panel();
            lblVendaCancelada = new Label();
            lblCaixaLivre = new Label();
            label3 = new Label();
            txtValorPago = new TextBox();
            lblValorPago = new Label();
            checkBoxVerificaEstoque = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            checkBoxVendaAVista = new CheckBox();
            btnAddProduto = new Button();
            txtValor = new TextBox();
            txtQtde = new TextBox();
            lblValor = new Label();
            lblQtde = new Label();
            lblProdutoNome = new Label();
            lblProdutoID = new Label();
            txtProdutoID = new TextBox();
            btnLocalizarProduto = new Button();
            lblDataInicial = new Label();
            dtgvItensVenda = new DataGridView();
            produtoID = new DataGridViewTextBoxColumn();
            produtoNome = new DataGridViewTextBoxColumn();
            produtoQtde = new DataGridViewTextBoxColumn();
            produtoValor = new DataGridViewTextBoxColumn();
            produtoValorTotal = new DataGridViewTextBoxColumn();
            dtpDataInicial = new DateTimePicker();
            cmbTipoPagamento = new ComboBox();
            cmbNumeroParcelas = new ComboBox();
            dtpDataVenda = new DateTimePicker();
            txtVendaTotal = new TextBox();
            lblVendaTotal = new Label();
            lblDataVenda = new Label();
            txtNotaFiscal = new TextBox();
            lblNotaFiscal = new Label();
            lblNumeroParcelas = new Label();
            txtVendaID = new TextBox();
            lblVenda = new Label();
            lblTipoPagamento = new Label();
            txtClienteFidelidade = new TextBox();
            lblCliente = new Label();
            panelFinalizaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasVenda).BeginInit();
            panelBotoes.SuspendLayout();
            panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensVenda).BeginInit();
            SuspendLayout();
            // 
            // panelFinalizaVenda
            // 
            panelFinalizaVenda.Controls.Add(label4);
            panelFinalizaVenda.Controls.Add(lbl0000);
            panelFinalizaVenda.Controls.Add(txtTroco);
            panelFinalizaVenda.Controls.Add(lblVendaTotal2);
            panelFinalizaVenda.Controls.Add(lblTroco);
            panelFinalizaVenda.Controls.Add(btnCancelarPagamento);
            panelFinalizaVenda.Controls.Add(btnSalvarPagamento);
            panelFinalizaVenda.Controls.Add(lblParcelasVenda);
            panelFinalizaVenda.Controls.Add(lblTraço);
            panelFinalizaVenda.Controls.Add(lblDadosPagamento);
            panelFinalizaVenda.Controls.Add(dtgvParcelasVenda);
            panelFinalizaVenda.Location = new Point(862, 12);
            panelFinalizaVenda.Name = "panelFinalizaVenda";
            panelFinalizaVenda.Size = new Size(844, 731);
            panelFinalizaVenda.TabIndex = 7;
            panelFinalizaVenda.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(647, 639);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 49;
            label4.Text = "R$";
            // 
            // lbl0000
            // 
            lbl0000.AutoSize = true;
            lbl0000.BackColor = Color.FromArgb(255, 128, 128);
            lbl0000.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl0000.Location = new Point(757, 84);
            lbl0000.Name = "lbl0000";
            lbl0000.Size = new Size(35, 15);
            lbl0000.TabIndex = 15;
            lbl0000.Text = "0000";
            // 
            // txtTroco
            // 
            txtTroco.Enabled = false;
            txtTroco.Location = new Point(673, 635);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(152, 23);
            txtTroco.TabIndex = 47;
            // 
            // lblVendaTotal2
            // 
            lblVendaTotal2.AutoSize = true;
            lblVendaTotal2.Location = new Point(649, 84);
            lblVendaTotal2.Name = "lblVendaTotal2";
            lblVendaTotal2.Size = new Size(102, 15);
            lblVendaTotal2.TabIndex = 14;
            lblVendaTotal2.Text = "Total da venda: R$";
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.Red;
            lblTroco.Location = new Point(673, 617);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(36, 15);
            lblTroco.TabIndex = 48;
            lblTroco.Text = "Troco";
            // 
            // btnCancelarPagamento
            // 
            btnCancelarPagamento.Location = new Point(110, 621);
            btnCancelarPagamento.Name = "btnCancelarPagamento";
            btnCancelarPagamento.Size = new Size(105, 33);
            btnCancelarPagamento.TabIndex = 19;
            btnCancelarPagamento.Text = "CANCELAR(F9)";
            btnCancelarPagamento.UseVisualStyleBackColor = true;
            btnCancelarPagamento.Click += btnCancelarPagamento_Click;
            // 
            // btnSalvarPagamento
            // 
            btnSalvarPagamento.Location = new Point(4, 621);
            btnSalvarPagamento.Name = "btnSalvarPagamento";
            btnSalvarPagamento.Size = new Size(100, 33);
            btnSalvarPagamento.TabIndex = 18;
            btnSalvarPagamento.Text = "FINALIZAR(F10)";
            btnSalvarPagamento.UseVisualStyleBackColor = true;
            btnSalvarPagamento.Click += btnSalvarPagamento_Click;
            // 
            // lblParcelasVenda
            // 
            lblParcelasVenda.AutoSize = true;
            lblParcelasVenda.Location = new Point(3, 60);
            lblParcelasVenda.Name = "lblParcelasVenda";
            lblParcelasVenda.Size = new Size(101, 15);
            lblParcelasVenda.TabIndex = 3;
            lblParcelasVenda.Text = "Parcelas da venda";
            // 
            // lblTraço
            // 
            lblTraço.AutoSize = true;
            lblTraço.Location = new Point(3, 34);
            lblTraço.Name = "lblTraço";
            lblTraço.Size = new Size(557, 15);
            lblTraço.TabIndex = 2;
            lblTraço.Text = "______________________________________________________________________________________________________________";
            // 
            // lblDadosPagamento
            // 
            lblDadosPagamento.AutoSize = true;
            lblDadosPagamento.Location = new Point(3, 19);
            lblDadosPagamento.Name = "lblDadosPagamento";
            lblDadosPagamento.Size = new Size(121, 15);
            lblDadosPagamento.TabIndex = 1;
            lblDadosPagamento.Text = "Dados do pagamento";
            // 
            // dtgvParcelasVenda
            // 
            dtgvParcelasVenda.AllowUserToAddRows = false;
            dtgvParcelasVenda.AllowUserToDeleteRows = false;
            dtgvParcelasVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParcelasVenda.Columns.AddRange(new DataGridViewColumn[] { parcelaID, parcelaValorPagamento, parcelaDataVencimento });
            dtgvParcelasVenda.Location = new Point(3, 78);
            dtgvParcelasVenda.Name = "dtgvParcelasVenda";
            dtgvParcelasVenda.ReadOnly = true;
            dtgvParcelasVenda.RowTemplate.Height = 25;
            dtgvParcelasVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvParcelasVenda.Size = new Size(640, 537);
            dtgvParcelasVenda.TabIndex = 0;
            // 
            // parcelaID
            // 
            parcelaID.HeaderText = "ID da parcela";
            parcelaID.Name = "parcelaID";
            parcelaID.ReadOnly = true;
            // 
            // parcelaValorPagamento
            // 
            parcelaValorPagamento.HeaderText = "Valor";
            parcelaValorPagamento.Name = "parcelaValorPagamento";
            parcelaValorPagamento.ReadOnly = true;
            parcelaValorPagamento.Width = 200;
            // 
            // parcelaDataVencimento
            // 
            parcelaDataVencimento.HeaderText = "Data de vencimento";
            parcelaDataVencimento.Name = "parcelaDataVencimento";
            parcelaDataVencimento.ReadOnly = true;
            parcelaDataVencimento.Width = 200;
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelarVenda);
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Location = new Point(12, 633);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(844, 111);
            panelBotoes.TabIndex = 6;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Location = new Point(387, 5);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(90, 28);
            btnCancelarVenda.TabIndex = 16;
            btnCancelarVenda.Text = "CANCELAR";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            btnCancelarVenda.Click += btnCancelarVenda_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(483, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 28);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "LIMPAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(3, 5);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(90, 28);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(99, 5);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(90, 28);
            btnLocalizar.TabIndex = 14;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(291, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 28);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(195, 5);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(90, 28);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Visible = false;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(lblVendaCancelada);
            panelDados.Controls.Add(lblCaixaLivre);
            panelDados.Controls.Add(label3);
            panelDados.Controls.Add(txtValorPago);
            panelDados.Controls.Add(lblValorPago);
            panelDados.Controls.Add(checkBoxVerificaEstoque);
            panelDados.Controls.Add(label2);
            panelDados.Controls.Add(label1);
            panelDados.Controls.Add(checkBoxVendaAVista);
            panelDados.Controls.Add(btnAddProduto);
            panelDados.Controls.Add(txtValor);
            panelDados.Controls.Add(txtQtde);
            panelDados.Controls.Add(lblValor);
            panelDados.Controls.Add(lblQtde);
            panelDados.Controls.Add(lblProdutoNome);
            panelDados.Controls.Add(lblCliente);
            panelDados.Controls.Add(lblProdutoID);
            panelDados.Controls.Add(txtClienteFidelidade);
            panelDados.Controls.Add(txtProdutoID);
            panelDados.Controls.Add(btnLocalizarProduto);
            panelDados.Controls.Add(lblDataInicial);
            panelDados.Controls.Add(dtgvItensVenda);
            panelDados.Controls.Add(dtpDataInicial);
            panelDados.Controls.Add(cmbTipoPagamento);
            panelDados.Controls.Add(cmbNumeroParcelas);
            panelDados.Controls.Add(dtpDataVenda);
            panelDados.Controls.Add(txtVendaTotal);
            panelDados.Controls.Add(lblVendaTotal);
            panelDados.Controls.Add(lblDataVenda);
            panelDados.Controls.Add(txtNotaFiscal);
            panelDados.Controls.Add(lblNotaFiscal);
            panelDados.Controls.Add(lblNumeroParcelas);
            panelDados.Controls.Add(txtVendaID);
            panelDados.Controls.Add(lblVenda);
            panelDados.Controls.Add(lblTipoPagamento);
            panelDados.Location = new Point(12, 12);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(844, 615);
            panelDados.TabIndex = 5;
            // 
            // lblVendaCancelada
            // 
            lblVendaCancelada.AutoSize = true;
            lblVendaCancelada.BackColor = Color.Red;
            lblVendaCancelada.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendaCancelada.ForeColor = Color.Black;
            lblVendaCancelada.Location = new Point(49, 336);
            lblVendaCancelada.Name = "lblVendaCancelada";
            lblVendaCancelada.Size = new Size(465, 65);
            lblVendaCancelada.TabIndex = 48;
            lblVendaCancelada.Text = "VENDA CANCELADA";
            // 
            // lblCaixaLivre
            // 
            lblCaixaLivre.AutoSize = true;
            lblCaixaLivre.BackColor = Color.Lime;
            lblCaixaLivre.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaixaLivre.ForeColor = Color.Black;
            lblCaixaLivre.Location = new Point(138, 268);
            lblCaixaLivre.Name = "lblCaixaLivre";
            lblCaixaLivre.Size = new Size(293, 65);
            lblCaixaLivre.TabIndex = 47;
            lblCaixaLivre.Text = "CAIXA LIVRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(613, 578);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 46;
            label3.Text = "R$";
            // 
            // txtValorPago
            // 
            txtValorPago.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPago.Location = new Point(643, 564);
            txtValorPago.Multiline = true;
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(198, 43);
            txtValorPago.TabIndex = 44;
            txtValorPago.TextChanged += txtValorPago_TextChanged;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.BackColor = Color.Red;
            lblValorPago.Location = new Point(643, 546);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(63, 15);
            lblValorPago.TabIndex = 45;
            lblValorPago.Text = "Valor pago";
            // 
            // checkBoxVerificaEstoque
            // 
            checkBoxVerificaEstoque.AutoSize = true;
            checkBoxVerificaEstoque.Location = new Point(3, 138);
            checkBoxVerificaEstoque.Name = "checkBoxVerificaEstoque";
            checkBoxVerificaEstoque.Size = new Size(263, 19);
            checkBoxVerificaEstoque.TabIndex = 43;
            checkBoxVerificaEstoque.Text = "Verificar quantidade de produtos em estoque";
            checkBoxVerificaEstoque.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(613, 426);
            label2.Name = "label2";
            label2.Size = new Size(29, 21);
            label2.TabIndex = 41;
            label2.Text = "R$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(613, 505);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 40;
            label1.Text = "R$";
            // 
            // checkBoxVendaAVista
            // 
            checkBoxVendaAVista.AutoSize = true;
            checkBoxVendaAVista.Location = new Point(272, 138);
            checkBoxVendaAVista.Name = "checkBoxVendaAVista";
            checkBoxVendaAVista.Size = new Size(94, 19);
            checkBoxVendaAVista.TabIndex = 8;
            checkBoxVendaAVista.Text = "Venda à vista";
            checkBoxVendaAVista.UseVisualStyleBackColor = true;
            checkBoxVendaAVista.CheckedChanged += checkBoxVendaAVista_CheckedChanged;
            // 
            // btnAddProduto
            // 
            btnAddProduto.Location = new Point(316, 95);
            btnAddProduto.Name = "btnAddProduto";
            btnAddProduto.Size = new Size(100, 24);
            btnAddProduto.TabIndex = 7;
            btnAddProduto.Text = "ADD PRODUTO";
            btnAddProduto.UseVisualStyleBackColor = true;
            btnAddProduto.Click += btnAddProduto_Click;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(643, 414);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(198, 43);
            txtValor.TabIndex = 6;
            // 
            // txtQtde
            // 
            txtQtde.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtde.Location = new Point(643, 336);
            txtQtde.Multiline = true;
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(198, 43);
            txtQtde.TabIndex = 5;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.Red;
            lblValor.Location = new Point(643, 395);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(77, 15);
            lblValor.TabIndex = 35;
            lblValor.Text = "Valor unitário";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.Location = new Point(643, 318);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(69, 15);
            lblQtde.TabIndex = 34;
            lblQtde.Text = "Quantidade";
            // 
            // lblProdutoNome
            // 
            lblProdutoNome.AutoSize = true;
            lblProdutoNome.Location = new Point(210, 77);
            lblProdutoNome.Name = "lblProdutoNome";
            lblProdutoNome.Size = new Size(103, 15);
            lblProdutoNome.TabIndex = 33;
            lblProdutoNome.Text = "Nome do Produto";
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize = true;
            lblProdutoID.Location = new Point(2, 77);
            lblProdutoID.Name = "lblProdutoID";
            lblProdutoID.Size = new Size(50, 15);
            lblProdutoID.TabIndex = 32;
            lblProdutoID.Text = "Produto";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(3, 95);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.Size = new Size(202, 23);
            txtProdutoID.TabIndex = 3;
            txtProdutoID.Leave += txtProdutoID_Leave;
            // 
            // btnLocalizarProduto
            // 
            btnLocalizarProduto.Location = new Point(210, 95);
            btnLocalizarProduto.Name = "btnLocalizarProduto";
            btnLocalizarProduto.Size = new Size(100, 24);
            btnLocalizarProduto.TabIndex = 4;
            btnLocalizarProduto.Text = "Localizar";
            btnLocalizarProduto.UseVisualStyleBackColor = true;
            btnLocalizarProduto.Click += btnLocalizarProduto_Click;
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(613, 59);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(145, 15);
            lblDataInicial.TabIndex = 25;
            lblDataInicial.Text = "Data inicial de pagamento";
            // 
            // dtgvItensVenda
            // 
            dtgvItensVenda.AllowUserToAddRows = false;
            dtgvItensVenda.AllowUserToDeleteRows = false;
            dtgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvItensVenda.Columns.AddRange(new DataGridViewColumn[] { produtoID, produtoNome, produtoQtde, produtoValor, produtoValorTotal });
            dtgvItensVenda.Location = new Point(3, 163);
            dtgvItensVenda.Name = "dtgvItensVenda";
            dtgvItensVenda.ReadOnly = true;
            dtgvItensVenda.RowTemplate.Height = 25;
            dtgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvItensVenda.Size = new Size(604, 444);
            dtgvItensVenda.TabIndex = 22;
            dtgvItensVenda.CellDoubleClick += dtgvItensVenda_CellDoubleClick;
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
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(613, 77);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(228, 23);
            dtpDataInicial.TabIndex = 11;
            // 
            // cmbTipoPagamento
            // 
            cmbTipoPagamento.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTipoPagamento.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoPagamento.FormattingEnabled = true;
            cmbTipoPagamento.Location = new Point(643, 225);
            cmbTipoPagamento.Name = "cmbTipoPagamento";
            cmbTipoPagamento.Size = new Size(198, 25);
            cmbTipoPagamento.TabIndex = 10;
            // 
            // cmbNumeroParcelas
            // 
            cmbNumeroParcelas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNumeroParcelas.FormattingEnabled = true;
            cmbNumeroParcelas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbNumeroParcelas.Location = new Point(643, 182);
            cmbNumeroParcelas.Name = "cmbNumeroParcelas";
            cmbNumeroParcelas.Size = new Size(198, 25);
            cmbNumeroParcelas.TabIndex = 9;
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.Location = new Point(613, 27);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(228, 23);
            dtpDataVenda.TabIndex = 2;
            // 
            // txtVendaTotal
            // 
            txtVendaTotal.Enabled = false;
            txtVendaTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtVendaTotal.Location = new Point(643, 495);
            txtVendaTotal.Multiline = true;
            txtVendaTotal.Name = "txtVendaTotal";
            txtVendaTotal.Size = new Size(198, 43);
            txtVendaTotal.TabIndex = 12;
            // 
            // lblVendaTotal
            // 
            lblVendaTotal.AutoSize = true;
            lblVendaTotal.BackColor = Color.Red;
            lblVendaTotal.Location = new Point(643, 477);
            lblVendaTotal.Name = "lblVendaTotal";
            lblVendaTotal.Size = new Size(83, 15);
            lblVendaTotal.TabIndex = 16;
            lblVendaTotal.Text = "Total da Venda";
            // 
            // lblDataVenda
            // 
            lblDataVenda.AutoSize = true;
            lblDataVenda.Location = new Point(613, 9);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(82, 15);
            lblDataVenda.TabIndex = 12;
            lblDataVenda.Text = "Data da venda";
            // 
            // txtNotaFiscal
            // 
            txtNotaFiscal.Location = new Point(210, 30);
            txtNotaFiscal.Name = "txtNotaFiscal";
            txtNotaFiscal.Size = new Size(100, 23);
            txtNotaFiscal.TabIndex = 1;
            // 
            // lblNotaFiscal
            // 
            lblNotaFiscal.AutoSize = true;
            lblNotaFiscal.Location = new Point(210, 12);
            lblNotaFiscal.Name = "lblNotaFiscal";
            lblNotaFiscal.Size = new Size(63, 15);
            lblNotaFiscal.TabIndex = 6;
            lblNotaFiscal.Text = "Nota fiscal";
            // 
            // lblNumeroParcelas
            // 
            lblNumeroParcelas.AutoSize = true;
            lblNumeroParcelas.Location = new Point(643, 164);
            lblNumeroParcelas.Name = "lblNumeroParcelas";
            lblNumeroParcelas.Size = new Size(50, 15);
            lblNumeroParcelas.TabIndex = 4;
            lblNumeroParcelas.Text = "Parcelas";
            // 
            // txtVendaID
            // 
            txtVendaID.Enabled = false;
            txtVendaID.Location = new Point(2, 30);
            txtVendaID.Name = "txtVendaID";
            txtVendaID.Size = new Size(202, 23);
            txtVendaID.TabIndex = 3;
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Location = new Point(3, 12);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(100, 15);
            lblVenda.TabIndex = 1;
            lblVenda.Text = "Código da Venda ";
            // 
            // lblTipoPagamento
            // 
            lblTipoPagamento.AutoSize = true;
            lblTipoPagamento.Location = new Point(643, 207);
            lblTipoPagamento.Name = "lblTipoPagamento";
            lblTipoPagamento.Size = new Size(110, 15);
            lblTipoPagamento.TabIndex = 0;
            lblTipoPagamento.Text = "Tipo de pagamento";
            // 
            // txtClienteFidelidade
            // 
            txtClienteFidelidade.Location = new Point(316, 30);
            txtClienteFidelidade.Name = "txtClienteFidelidade";
            txtClienteFidelidade.Size = new Size(202, 23);
            txtClienteFidelidade.TabIndex = 3;
            txtClienteFidelidade.Leave += txtProdutoID_Leave;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(315, 12);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(101, 15);
            lblCliente.TabIndex = 32;
            lblCliente.Text = "Cliente Fidelidade";
            // 
            // formVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelFinalizaVenda);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name = "formVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda";
            WindowState = FormWindowState.Maximized;
            Load += formVenda_Load;
            panelFinalizaVenda.ResumeLayout(false);
            panelFinalizaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasVenda).EndInit();
            panelBotoes.ResumeLayout(false);
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensVenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFinalizaVenda;
        private Label lbl0000;
        private Label lblVendaTotal2;
        protected Button btnCancelarPagamento;
        protected Button btnSalvarPagamento;
        private Label lblParcelasVenda;
        private Label lblTraço;
        private Label lblDadosPagamento;
        private DataGridView dtgvParcelasVenda;
        private DataGridViewTextBoxColumn parcelaID;
        private DataGridViewTextBoxColumn parcelaValorPagamento;
        private DataGridViewTextBoxColumn parcelaDataVencimento;
        protected Panel panelBotoes;
        protected Button btnCancelarVenda;
        protected Button btnCancelar;
        protected Button btnInserir;
        protected Button btnLocalizar;
        protected Button btnSalvar;
        protected Button btnAlterar;
        protected Panel panelDados;
        private Button btnAddProduto;
        private TextBox txtValor;
        private TextBox txtQtde;
        private Label lblValor;
        private Label lblQtde;
        private Label lblProdutoNome;
        private Label lblProdutoID;
        private TextBox txtProdutoID;
        private Button btnLocalizarProduto;
        private Label lblDataInicial;
        private DataGridView dtgvItensVenda;
        private DataGridViewTextBoxColumn produtoID;
        private DataGridViewTextBoxColumn produtoNome;
        private DataGridViewTextBoxColumn produtoQtde;
        private DataGridViewTextBoxColumn produtoValor;
        private DataGridViewTextBoxColumn produtoValorTotal;
        private DateTimePicker dtpDataInicial;
        private ComboBox cmbTipoPagamento;
        private ComboBox cmbNumeroParcelas;
        private DateTimePicker dtpDataVenda;
        private TextBox txtVendaTotal;
        private Label lblVendaTotal;
        private Label lblDataVenda;
        private TextBox txtNotaFiscal;
        private Label lblNotaFiscal;
        private Label lblNumeroParcelas;
        private TextBox txtVendaID;
        private Label lblVenda;
        private Label lblTipoPagamento;
        private CheckBox checkBoxVendaAVista;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxVerificaEstoque;
        private Label label4;
        private TextBox txtTroco;
        private Label lblTroco;
        private Label label3;
        private TextBox txtValorPago;
        private Label lblValorPago;
        private Label lblCaixaLivre;
        private Label lblVendaCancelada;
        private Label lblCliente;
        private TextBox txtClienteFidelidade;
    }
}