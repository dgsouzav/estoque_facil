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
            panelDados=new Panel();
            panelFinalizaCompra=new Panel();
            lbl0000=new Label();
            lblCompraTotal2=new Label();
            btnCancelarPagamento=new Button();
            btnSalvarPagamento=new Button();
            lblParcelasCompra=new Label();
            lblTraço=new Label();
            lblDadosPagamento=new Label();
            dtgvParcelasCompra=new DataGridView();
            parcelaID=new DataGridViewTextBoxColumn();
            parcelaValorPagamento=new DataGridViewTextBoxColumn();
            parcelaDataVencimento=new DataGridViewTextBoxColumn();
            btnAddProduto=new Button();
            txtValor=new TextBox();
            txtQtde=new TextBox();
            lblValor=new Label();
            lblQtde=new Label();
            lblProdutoNome=new Label();
            lblProdutoID=new Label();
            txtProdutoID=new TextBox();
            btnLocalizarProduto=new Button();
            lblFornecedorNome=new Label();
            btnLocalizarFornecedor=new Button();
            txtFornecedorID=new TextBox();
            lblFornecedorID=new Label();
            lblDataInicial=new Label();
            dtgvItensCompra=new DataGridView();
            produtoID=new DataGridViewTextBoxColumn();
            produtoNome=new DataGridViewTextBoxColumn();
            produtoQtde=new DataGridViewTextBoxColumn();
            produtoValor=new DataGridViewTextBoxColumn();
            produtoValorTotal=new DataGridViewTextBoxColumn();
            dtpDataInicial=new DateTimePicker();
            cmbTipoPagamento=new ComboBox();
            cmbNumeroParcelas=new ComboBox();
            dtpDataAtual=new DateTimePicker();
            txtCompraTotal=new TextBox();
            lblCompraTotal=new Label();
            lblDataCompra=new Label();
            txtNotaFiscal=new TextBox();
            lblNotaFiscal=new Label();
            lblNumeroParcelas=new Label();
            txtCompraID=new TextBox();
            lblCompra=new Label();
            lblTipoPagamento=new Label();
            btnAlterar=new Button();
            btnSalvar=new Button();
            btnLocalizar=new Button();
            btnInserir=new Button();
            btnCancelar=new Button();
            panelBotoes=new Panel();
            btnExcluir=new Button();
            panelDados.SuspendLayout();
            panelFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvItensCompra).BeginInit();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
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
            panelDados.Controls.Add(lblDataInicial);
            panelDados.Controls.Add(dtgvItensCompra);
            panelDados.Controls.Add(dtpDataInicial);
            panelDados.Controls.Add(cmbTipoPagamento);
            panelDados.Controls.Add(cmbNumeroParcelas);
            panelDados.Controls.Add(dtpDataAtual);
            panelDados.Controls.Add(txtCompraTotal);
            panelDados.Controls.Add(lblCompraTotal);
            panelDados.Controls.Add(lblDataCompra);
            panelDados.Controls.Add(txtNotaFiscal);
            panelDados.Controls.Add(lblNotaFiscal);
            panelDados.Controls.Add(lblNumeroParcelas);
            panelDados.Controls.Add(txtCompraID);
            panelDados.Controls.Add(lblCompra);
            panelDados.Controls.Add(lblTipoPagamento);
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(536, 436);
            panelDados.TabIndex=2;
            // 
            // panelFinalizaCompra
            // 
            panelFinalizaCompra.Controls.Add(lbl0000);
            panelFinalizaCompra.Controls.Add(lblCompraTotal2);
            panelFinalizaCompra.Controls.Add(btnCancelarPagamento);
            panelFinalizaCompra.Controls.Add(btnSalvarPagamento);
            panelFinalizaCompra.Controls.Add(lblParcelasCompra);
            panelFinalizaCompra.Controls.Add(lblTraço);
            panelFinalizaCompra.Controls.Add(lblDadosPagamento);
            panelFinalizaCompra.Controls.Add(dtgvParcelasCompra);
            panelFinalizaCompra.Location=new Point(678, 13);
            panelFinalizaCompra.Name="panelFinalizaCompra";
            panelFinalizaCompra.Size=new Size(533, 437);
            panelFinalizaCompra.TabIndex=4;
            panelFinalizaCompra.Visible=false;
            // 
            // lbl0000
            // 
            lbl0000.AutoSize=true;
            lbl0000.BackColor=Color.Red;
            lbl0000.Location=new Point(409, 389);
            lbl0000.Name="lbl0000";
            lbl0000.Size=new Size(31, 15);
            lbl0000.TabIndex=15;
            lbl0000.Text="0000";
            // 
            // lblCompraTotal2
            // 
            lblCompraTotal2.AutoSize=true;
            lblCompraTotal2.Location=new Point(311, 389);
            lblCompraTotal2.Name="lblCompraTotal2";
            lblCompraTotal2.Size=new Size(92, 15);
            lblCompraTotal2.TabIndex=14;
            lblCompraTotal2.Text="Total da compra";
            // 
            // btnCancelarPagamento
            // 
            btnCancelarPagamento.Location=new Point(444, 158);
            btnCancelarPagamento.Name="btnCancelarPagamento";
            btnCancelarPagamento.Size=new Size(80, 60);
            btnCancelarPagamento.TabIndex=13;
            btnCancelarPagamento.Text="CANCELAR";
            btnCancelarPagamento.UseVisualStyleBackColor=true;
            btnCancelarPagamento.Click+=btnCancelarPagamento_Click;
            // 
            // btnSalvarPagamento
            // 
            btnSalvarPagamento.Location=new Point(444, 88);
            btnSalvarPagamento.Name="btnSalvarPagamento";
            btnSalvarPagamento.Size=new Size(80, 60);
            btnSalvarPagamento.TabIndex=12;
            btnSalvarPagamento.Text="SALVAR";
            btnSalvarPagamento.UseVisualStyleBackColor=true;
            btnSalvarPagamento.Click+=btnSalvarPagamento_Click;
            // 
            // lblParcelasCompra
            // 
            lblParcelasCompra.AutoSize=true;
            lblParcelasCompra.Location=new Point(3, 60);
            lblParcelasCompra.Name="lblParcelasCompra";
            lblParcelasCompra.Size=new Size(110, 15);
            lblParcelasCompra.TabIndex=3;
            lblParcelasCompra.Text="Parcelas da compra";
            // 
            // lblTraço
            // 
            lblTraço.AutoSize=true;
            lblTraço.Location=new Point(3, 34);
            lblTraço.Name="lblTraço";
            lblTraço.Size=new Size(437, 15);
            lblTraço.TabIndex=2;
            lblTraço.Text="______________________________________________________________________________________";
            // 
            // lblDadosPagamento
            // 
            lblDadosPagamento.AutoSize=true;
            lblDadosPagamento.Location=new Point(3, 19);
            lblDadosPagamento.Name="lblDadosPagamento";
            lblDadosPagamento.Size=new Size(121, 15);
            lblDadosPagamento.TabIndex=1;
            lblDadosPagamento.Text="Dados do pagamento";
            // 
            // dtgvParcelasCompra
            // 
            dtgvParcelasCompra.AllowUserToAddRows=false;
            dtgvParcelasCompra.AllowUserToDeleteRows=false;
            dtgvParcelasCompra.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParcelasCompra.Columns.AddRange(new DataGridViewColumn[] { parcelaID, parcelaValorPagamento, parcelaDataVencimento });
            dtgvParcelasCompra.Location=new Point(3, 85);
            dtgvParcelasCompra.Name="dtgvParcelasCompra";
            dtgvParcelasCompra.ReadOnly=true;
            dtgvParcelasCompra.RowTemplate.Height=25;
            dtgvParcelasCompra.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvParcelasCompra.Size=new Size(437, 301);
            dtgvParcelasCompra.TabIndex=0;
            // 
            // parcelaID
            // 
            parcelaID.HeaderText="ID da parcela";
            parcelaID.Name="parcelaID";
            parcelaID.ReadOnly=true;
            // 
            // parcelaValorPagamento
            // 
            parcelaValorPagamento.HeaderText="Valor";
            parcelaValorPagamento.Name="parcelaValorPagamento";
            parcelaValorPagamento.ReadOnly=true;
            parcelaValorPagamento.Width=200;
            // 
            // parcelaDataVencimento
            // 
            parcelaDataVencimento.HeaderText="Data de vencimento";
            parcelaDataVencimento.Name="parcelaDataVencimento";
            parcelaDataVencimento.ReadOnly=true;
            parcelaDataVencimento.Width=200;
            // 
            // btnAddProduto
            // 
            btnAddProduto.Location=new Point(285, 118);
            btnAddProduto.Name="btnAddProduto";
            btnAddProduto.Size=new Size(27, 24);
            btnAddProduto.TabIndex=38;
            btnAddProduto.Text="+";
            btnAddProduto.UseVisualStyleBackColor=true;
            btnAddProduto.Click+=btnAddProduto_Click;
            // 
            // txtValor
            // 
            txtValor.Location=new Point(179, 171);
            txtValor.Name="txtValor";
            txtValor.Size=new Size(166, 23);
            txtValor.TabIndex=37;
            // 
            // txtQtde
            // 
            txtQtde.Location=new Point(6, 171);
            txtQtde.Name="txtQtde";
            txtQtde.Size=new Size(167, 23);
            txtQtde.TabIndex=36;
            // 
            // lblValor
            // 
            lblValor.AutoSize=true;
            lblValor.Location=new Point(179, 153);
            lblValor.Name="lblValor";
            lblValor.Size=new Size(77, 15);
            lblValor.TabIndex=35;
            lblValor.Text="Valor unitário";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize=true;
            lblQtde.Location=new Point(6, 153);
            lblQtde.Name="lblQtde";
            lblQtde.Size=new Size(69, 15);
            lblQtde.TabIndex=34;
            lblQtde.Text="Quantidade";
            // 
            // lblProdutoNome
            // 
            lblProdutoNome.AutoSize=true;
            lblProdutoNome.Location=new Point(179, 102);
            lblProdutoNome.Name="lblProdutoNome";
            lblProdutoNome.Size=new Size(215, 15);
            lblProdutoNome.TabIndex=33;
            lblProdutoNome.Text="Informe o nome do Produto ou localize";
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize=true;
            lblProdutoID.Location=new Point(6, 101);
            lblProdutoID.Name="lblProdutoID";
            lblProdutoID.Size=new Size(50, 15);
            lblProdutoID.TabIndex=32;
            lblProdutoID.Text="Produto";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location=new Point(6, 119);
            txtProdutoID.Name="txtProdutoID";
            txtProdutoID.Size=new Size(167, 23);
            txtProdutoID.TabIndex=31;
            txtProdutoID.Leave+=txtProdutoID_Leave;
            // 
            // btnLocalizarProduto
            // 
            btnLocalizarProduto.Location=new Point(179, 118);
            btnLocalizarProduto.Name="btnLocalizarProduto";
            btnLocalizarProduto.Size=new Size(100, 24);
            btnLocalizarProduto.TabIndex=30;
            btnLocalizarProduto.Text="Localizar";
            btnLocalizarProduto.UseVisualStyleBackColor=true;
            btnLocalizarProduto.Click+=btnLocalizarProduto_Click;
            // 
            // lblFornecedorNome
            // 
            lblFornecedorNome.AutoSize=true;
            lblFornecedorNome.Location=new Point(179, 57);
            lblFornecedorNome.Name="lblFornecedorNome";
            lblFornecedorNome.Size=new Size(232, 15);
            lblFornecedorNome.TabIndex=29;
            lblFornecedorNome.Text="Informe o nome do Fornecedor ou localize";
            // 
            // btnLocalizarFornecedor
            // 
            btnLocalizarFornecedor.Location=new Point(179, 75);
            btnLocalizarFornecedor.Name="btnLocalizarFornecedor";
            btnLocalizarFornecedor.Size=new Size(100, 24);
            btnLocalizarFornecedor.TabIndex=28;
            btnLocalizarFornecedor.Text="Localizar";
            btnLocalizarFornecedor.UseVisualStyleBackColor=true;
            btnLocalizarFornecedor.Click+=btnLocalizarFornecedor_Click_1;
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Location=new Point(6, 75);
            txtFornecedorID.Name="txtFornecedorID";
            txtFornecedorID.Size=new Size(167, 23);
            txtFornecedorID.TabIndex=27;
            txtFornecedorID.Leave+=txtFornecedorID_Leave;
            // 
            // lblFornecedorID
            // 
            lblFornecedorID.AutoSize=true;
            lblFornecedorID.Location=new Point(6, 57);
            lblFornecedorID.Name="lblFornecedorID";
            lblFornecedorID.Size=new Size(67, 15);
            lblFornecedorID.TabIndex=26;
            lblFornecedorID.Text="Fornecedor";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize=true;
            lblDataInicial.Location=new Point(179, 383);
            lblDataInicial.Name="lblDataInicial";
            lblDataInicial.Size=new Size(145, 15);
            lblDataInicial.TabIndex=25;
            lblDataInicial.Text="Data inicial de pagamento";
            // 
            // dtgvItensCompra
            // 
            dtgvItensCompra.AllowUserToAddRows=false;
            dtgvItensCompra.AllowUserToDeleteRows=false;
            dtgvItensCompra.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvItensCompra.Columns.AddRange(new DataGridViewColumn[] { produtoID, produtoNome, produtoQtde, produtoValor, produtoValorTotal });
            dtgvItensCompra.Location=new Point(6, 200);
            dtgvItensCompra.Name="dtgvItensCompra";
            dtgvItensCompra.ReadOnly=true;
            dtgvItensCompra.RowTemplate.Height=25;
            dtgvItensCompra.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvItensCompra.Size=new Size(527, 130);
            dtgvItensCompra.TabIndex=22;
            dtgvItensCompra.CellDoubleClick+=dtgvItensCompra_CellDoubleClick;
            // 
            // produtoID
            // 
            produtoID.HeaderText="ID do Produto";
            produtoID.Name="produtoID";
            produtoID.ReadOnly=true;
            produtoID.Width=60;
            // 
            // produtoNome
            // 
            produtoNome.HeaderText="Nome";
            produtoNome.Name="produtoNome";
            produtoNome.ReadOnly=true;
            produtoNome.Width=200;
            // 
            // produtoQtde
            // 
            produtoQtde.HeaderText="Quantidade";
            produtoQtde.Name="produtoQtde";
            produtoQtde.ReadOnly=true;
            // 
            // produtoValor
            // 
            produtoValor.HeaderText="Valor unitário";
            produtoValor.Name="produtoValor";
            produtoValor.ReadOnly=true;
            // 
            // produtoValorTotal
            // 
            produtoValorTotal.HeaderText="Valor total";
            produtoValorTotal.Name="produtoValorTotal";
            produtoValorTotal.ReadOnly=true;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location=new Point(179, 401);
            dtpDataInicial.Name="dtpDataInicial";
            dtpDataInicial.Size=new Size(248, 23);
            dtpDataInicial.TabIndex=21;
            // 
            // cmbTipoPagamento
            // 
            cmbTipoPagamento.AutoCompleteMode=AutoCompleteMode.Suggest;
            cmbTipoPagamento.AutoCompleteSource=AutoCompleteSource.ListItems;
            cmbTipoPagamento.FormattingEnabled=true;
            cmbTipoPagamento.Location=new Point(6, 351);
            cmbTipoPagamento.Name="cmbTipoPagamento";
            cmbTipoPagamento.Size=new Size(167, 23);
            cmbTipoPagamento.TabIndex=20;
            // 
            // cmbNumeroParcelas
            // 
            cmbNumeroParcelas.FormattingEnabled=true;
            cmbNumeroParcelas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbNumeroParcelas.Location=new Point(6, 401);
            cmbNumeroParcelas.Name="cmbNumeroParcelas";
            cmbNumeroParcelas.Size=new Size(167, 23);
            cmbNumeroParcelas.TabIndex=19;
            // 
            // dtpDataAtual
            // 
            dtpDataAtual.Location=new Point(281, 31);
            dtpDataAtual.Name="dtpDataAtual";
            dtpDataAtual.Size=new Size(252, 23);
            dtpDataAtual.TabIndex=18;
            // 
            // txtCompraTotal
            // 
            txtCompraTotal.Location=new Point(433, 401);
            txtCompraTotal.Name="txtCompraTotal";
            txtCompraTotal.Size=new Size(100, 23);
            txtCompraTotal.TabIndex=17;
            // 
            // lblCompraTotal
            // 
            lblCompraTotal.AutoSize=true;
            lblCompraTotal.Location=new Point(432, 383);
            lblCompraTotal.Name="lblCompraTotal";
            lblCompraTotal.Size=new Size(92, 15);
            lblCompraTotal.TabIndex=16;
            lblCompraTotal.Text="Total da compra";
            // 
            // lblDataCompra
            // 
            lblDataCompra.AutoSize=true;
            lblDataCompra.Location=new Point(281, 13);
            lblDataCompra.Name="lblDataCompra";
            lblDataCompra.Size=new Size(91, 15);
            lblDataCompra.TabIndex=12;
            lblDataCompra.Text="Data da compra";
            // 
            // txtNotaFiscal
            // 
            txtNotaFiscal.Location=new Point(104, 30);
            txtNotaFiscal.Name="txtNotaFiscal";
            txtNotaFiscal.Size=new Size(171, 23);
            txtNotaFiscal.TabIndex=7;
            // 
            // lblNotaFiscal
            // 
            lblNotaFiscal.AutoSize=true;
            lblNotaFiscal.Location=new Point(81, 13);
            lblNotaFiscal.Name="lblNotaFiscal";
            lblNotaFiscal.Size=new Size(63, 15);
            lblNotaFiscal.TabIndex=6;
            lblNotaFiscal.Text="Nota fiscal";
            // 
            // lblNumeroParcelas
            // 
            lblNumeroParcelas.AutoSize=true;
            lblNumeroParcelas.Location=new Point(6, 383);
            lblNumeroParcelas.Name="lblNumeroParcelas";
            lblNumeroParcelas.Size=new Size(113, 15);
            lblNumeroParcelas.TabIndex=4;
            lblNumeroParcelas.Text="Número de parcelas";
            // 
            // txtCompraID
            // 
            txtCompraID.Enabled=false;
            txtCompraID.Location=new Point(6, 31);
            txtCompraID.Name="txtCompraID";
            txtCompraID.Size=new Size(92, 23);
            txtCompraID.TabIndex=3;
            // 
            // lblCompra
            // 
            lblCompra.AutoSize=true;
            lblCompra.Location=new Point(6, 13);
            lblCompra.Name="lblCompra";
            lblCompra.Size=new Size(64, 15);
            lblCompra.TabIndex=1;
            lblCompra.Text="Compra ID";
            // 
            // lblTipoPagamento
            // 
            lblTipoPagamento.AutoSize=true;
            lblTipoPagamento.Location=new Point(6, 333);
            lblTipoPagamento.Name="lblTipoPagamento";
            lblTipoPagamento.Size=new Size(110, 15);
            lblTipoPagamento.TabIndex=0;
            lblTipoPagamento.Text="Tipo de pagamento";
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(19, 154);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 60);
            btnAlterar.TabIndex=8;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(19, 289);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 60);
            btnSalvar.TabIndex=10;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(19, 84);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 60);
            btnLocalizar.TabIndex=7;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(19, 14);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 60);
            btnInserir.TabIndex=6;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(19, 355);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 60);
            btnCancelar.TabIndex=11;
            btnCancelar.Text="LIMPAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnExcluir);
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Location=new Point(554, 13);
            panelBotoes.Name="panelBotoes";
            panelBotoes.Size=new Size(118, 436);
            panelBotoes.TabIndex=3;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(19, 220);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 60);
            btnExcluir.TabIndex=12;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // formCompra
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1195, 461);
            Controls.Add(panelFinalizaCompra);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name="formCompra";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Compra";
            Load+=formCompra_Load;
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            panelFinalizaCompra.ResumeLayout(false);
            panelFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasCompra).EndInit();
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
        private Label lblDataInicial;
        private DataGridView dtgvItensCompra;
        private DateTimePicker dtpDataInicial;
        private ComboBox cmbTipoPagamento;
        private ComboBox cmbNumeroParcelas;
        private DateTimePicker dtpDataAtual;
        private TextBox txtCompraTotal;
        private Label lblCompraTotal;
        private Label lblDataCompra;
        private TextBox txtNotaFiscal;
        private Label lblNotaFiscal;
        private Label lblNumeroParcelas;
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
        protected Button btnExcluir;
        private Panel panelFinalizaCompra;
        private Label lblParcelasCompra;
        private Label lblTraço;
        private Label lblDadosPagamento;
        private DataGridView dtgvParcelasCompra;
        protected Button btnCancelarPagamento;
        protected Button btnSalvarPagamento;
        private Label lbl0000;
        private Label lblCompraTotal2;
        private DataGridViewTextBoxColumn parcelaID;
        private DataGridViewTextBoxColumn parcelaValorPagamento;
        private DataGridViewTextBoxColumn parcelaDataVencimento;
    }
}