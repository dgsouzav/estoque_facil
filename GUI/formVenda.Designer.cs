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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVenda));
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
            btnSalvar = new Button();
            panelDados = new Panel();
            listBoxClientes = new ListBox();
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
            lblCliente = new Label();
            lblProdutoID = new Label();
            txtClienteFidelidade = new TextBox();
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
            panelFinalizaVenda.Location = new Point(12, 6);
            panelFinalizaVenda.Name = "panelFinalizaVenda";
            panelFinalizaVenda.Size = new Size(1346, 731);
            panelFinalizaVenda.TabIndex = 7;
            panelFinalizaVenda.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 128);
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1106, 581);
            label4.Name = "label4";
            label4.Size = new Size(41, 32);
            label4.TabIndex = 49;
            label4.Text = "R$";
            // 
            // lbl0000
            // 
            lbl0000.AutoSize = true;
            lbl0000.BackColor = Color.FromArgb(255, 128, 128);
            lbl0000.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl0000.Location = new Point(1268, 457);
            lbl0000.Name = "lbl0000";
            lbl0000.Size = new Size(65, 29);
            lbl0000.TabIndex = 15;
            lbl0000.Text = "0000";
            // 
            // txtTroco
            // 
            txtTroco.Enabled = false;
            txtTroco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTroco.Location = new Point(1153, 569);
            txtTroco.Multiline = true;
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(180, 46);
            txtTroco.TabIndex = 47;
            txtTroco.KeyPress += txtTroco_KeyPress;
            // 
            // lblVendaTotal2
            // 
            lblVendaTotal2.AutoSize = true;
            lblVendaTotal2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendaTotal2.Location = new Point(1095, 461);
            lblVendaTotal2.Name = "lblVendaTotal2";
            lblVendaTotal2.Size = new Size(167, 24);
            lblVendaTotal2.TabIndex = 14;
            lblVendaTotal2.Text = "Total da venda: R$";
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.Red;
            lblTroco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTroco.Location = new Point(1154, 537);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(58, 25);
            lblTroco.TabIndex = 48;
            lblTroco.Text = "Troco";
            // 
            // btnCancelarPagamento
            // 
            btnCancelarPagamento.Location = new Point(6, 623);
            btnCancelarPagamento.Name = "btnCancelarPagamento";
            btnCancelarPagamento.Size = new Size(105, 33);
            btnCancelarPagamento.TabIndex = 19;
            btnCancelarPagamento.Text = "CANCELAR(F9)";
            btnCancelarPagamento.UseVisualStyleBackColor = true;
            btnCancelarPagamento.Click += btnCancelarPagamento_Click;
            // 
            // btnSalvarPagamento
            // 
            btnSalvarPagamento.Location = new Point(117, 623);
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
            lblTraço.Size = new Size(1062, 15);
            lblTraço.TabIndex = 2;
            lblTraço.Text = resources.GetString("lblTraço.Text");
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
            dtgvParcelasVenda.Size = new Size(1066, 537);
            dtgvParcelasVenda.TabIndex = 0;
            dtgvParcelasVenda.CellFormatting += dtgvParcelasVenda_CellFormatting;
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
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Location = new Point(12, 633);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(1346, 111);
            panelBotoes.TabIndex = 6;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Location = new Point(99, 8);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(95, 28);
            btnCancelarVenda.TabIndex = 16;
            btnCancelarVenda.Text = "CANCELAR(F4)";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            btnCancelarVenda.Click += btnCancelarVenda_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(200, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 28);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "LIMPAR(F5)";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(3, 8);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 28);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "SALVAR(F3)";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(listBoxClientes);
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
            panelDados.Size = new Size(1346, 615);
            panelDados.TabIndex = 5;
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(965, 55);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(120, 94);
            listBoxClientes.TabIndex = 49;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            // 
            // lblCaixaLivre
            // 
            lblCaixaLivre.AutoSize = true;
            lblCaixaLivre.BackColor = Color.Lime;
            lblCaixaLivre.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaixaLivre.ForeColor = Color.Black;
            lblCaixaLivre.Location = new Point(565, 5);
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
            label3.Location = new Point(1102, 534);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 46;
            label3.Text = "R$";
            // 
            // txtValorPago
            // 
            txtValorPago.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPago.Location = new Point(1132, 520);
            txtValorPago.Multiline = true;
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(198, 43);
            txtValorPago.TabIndex = 44;
            txtValorPago.TextChanged += txtValorPago_TextChanged;
            txtValorPago.KeyPress += txtValorPago_KeyPress_1;
            txtValorPago.Leave += txtValorPago_Leave;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.BackColor = Color.Red;
            lblValorPago.Location = new Point(1132, 502);
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
            label2.Location = new Point(1102, 382);
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
            label1.Location = new Point(1102, 461);
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
            btnAddProduto.Location = new Point(536, 94);
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
            txtValor.Location = new Point(1132, 370);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(198, 43);
            txtValor.TabIndex = 6;
            // 
            // txtQtde
            // 
            txtQtde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtde.Location = new Point(319, 95);
            txtQtde.Multiline = true;
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(198, 23);
            txtQtde.TabIndex = 5;
            txtQtde.KeyPress += txtQtde_KeyPress_1;
            txtQtde.Leave += txtQtde_Leave;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.Red;
            lblValor.Location = new Point(1132, 351);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(77, 15);
            lblValor.TabIndex = 35;
            lblValor.Text = "Valor unitário";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.Location = new Point(319, 78);
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
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(965, 12);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(101, 15);
            lblCliente.TabIndex = 32;
            lblCliente.Text = "Cliente Fidelidade";
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
            // txtClienteFidelidade
            // 
            txtClienteFidelidade.Location = new Point(965, 30);
            txtClienteFidelidade.Name = "txtClienteFidelidade";
            txtClienteFidelidade.Size = new Size(120, 23);
            txtClienteFidelidade.TabIndex = 3;
            txtClienteFidelidade.TextChanged += txtClienteFidelidade_TextChanged;
            txtClienteFidelidade.Leave += txtProdutoID_Leave;
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
            lblDataInicial.Location = new Point(1132, 174);
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
            dtgvItensVenda.Size = new Size(1093, 444);
            dtgvItensVenda.TabIndex = 22;
            dtgvItensVenda.CellDoubleClick += dtgvItensVenda_CellDoubleClick;
            dtgvItensVenda.CellFormatting += dtgvItensVenda_CellFormatting;
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
            dtpDataInicial.Location = new Point(1132, 192);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(198, 23);
            dtpDataInicial.TabIndex = 11;
            // 
            // cmbTipoPagamento
            // 
            cmbTipoPagamento.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTipoPagamento.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoPagamento.FormattingEnabled = true;
            cmbTipoPagamento.Location = new Point(1132, 73);
            cmbTipoPagamento.Name = "cmbTipoPagamento";
            cmbTipoPagamento.Size = new Size(198, 25);
            cmbTipoPagamento.TabIndex = 10;
            // 
            // cmbNumeroParcelas
            // 
            cmbNumeroParcelas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNumeroParcelas.FormattingEnabled = true;
            cmbNumeroParcelas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbNumeroParcelas.Location = new Point(1132, 30);
            cmbNumeroParcelas.Name = "cmbNumeroParcelas";
            cmbNumeroParcelas.Size = new Size(198, 25);
            cmbNumeroParcelas.TabIndex = 9;
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.Location = new Point(1132, 142);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(198, 23);
            dtpDataVenda.TabIndex = 2;
            // 
            // txtVendaTotal
            // 
            txtVendaTotal.Enabled = false;
            txtVendaTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtVendaTotal.Location = new Point(1132, 451);
            txtVendaTotal.Multiline = true;
            txtVendaTotal.Name = "txtVendaTotal";
            txtVendaTotal.Size = new Size(198, 43);
            txtVendaTotal.TabIndex = 12;
            // 
            // lblVendaTotal
            // 
            lblVendaTotal.AutoSize = true;
            lblVendaTotal.BackColor = Color.Red;
            lblVendaTotal.Location = new Point(1132, 433);
            lblVendaTotal.Name = "lblVendaTotal";
            lblVendaTotal.Size = new Size(83, 15);
            lblVendaTotal.TabIndex = 16;
            lblVendaTotal.Text = "Total da Venda";
            // 
            // lblDataVenda
            // 
            lblDataVenda.AutoSize = true;
            lblDataVenda.Location = new Point(1132, 124);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(82, 15);
            lblDataVenda.TabIndex = 12;
            lblDataVenda.Text = "Data da venda";
            // 
            // txtNotaFiscal
            // 
            txtNotaFiscal.Location = new Point(109, 30);
            txtNotaFiscal.Name = "txtNotaFiscal";
            txtNotaFiscal.Size = new Size(201, 23);
            txtNotaFiscal.TabIndex = 1;
            txtNotaFiscal.KeyPress += txtNotaFiscal_KeyPress;
            txtNotaFiscal.Leave += txtNotaFiscal_Leave;
            // 
            // lblNotaFiscal
            // 
            lblNotaFiscal.AutoSize = true;
            lblNotaFiscal.Location = new Point(109, 12);
            lblNotaFiscal.Name = "lblNotaFiscal";
            lblNotaFiscal.Size = new Size(63, 15);
            lblNotaFiscal.TabIndex = 6;
            lblNotaFiscal.Text = "Nota fiscal";
            // 
            // lblNumeroParcelas
            // 
            lblNumeroParcelas.AutoSize = true;
            lblNumeroParcelas.Location = new Point(1132, 12);
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
            txtVendaID.Size = new Size(101, 23);
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
            lblTipoPagamento.Location = new Point(1132, 55);
            lblTipoPagamento.Name = "lblTipoPagamento";
            lblTipoPagamento.Size = new Size(110, 15);
            lblTipoPagamento.TabIndex = 0;
            lblTipoPagamento.Text = "Tipo de pagamento";
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
            KeyDown += formVenda_KeyDown;
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
        protected Button btnSalvar;
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
        private Label lblCliente;
        private TextBox txtClienteFidelidade;
        private ListBox listBoxClientes;
        protected Button btnCancelarPagamento;
    }
}