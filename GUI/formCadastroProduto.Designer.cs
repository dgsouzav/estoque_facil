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
            panelBotoes=new Panel();
            btnCancelar=new Button();
            btnInserir=new Button();
            btnLocalizar=new Button();
            btnSalvar=new Button();
            btnAlterar=new Button();
            panelDados=new Panel();
            lblFornecedorID=new Label();
            cmbFornecedorID=new ComboBox();
            cmbUndMedID=new ComboBox();
            cmbCategoriaID=new ComboBox();
            cmbSubCategoriaID=new ComboBox();
            lblUnidadeMedidaID=new Label();
            lblCategoriaID=new Label();
            lblSubCategoriaID=new Label();
            txtValorPagoProduto=new TextBox();
            txtQtdeProduto=new TextBox();
            txtValorVendaProduto=new TextBox();
            lblQtdeProduto=new Label();
            lblValorVendaProduto=new Label();
            lblValorPagoProduto=new Label();
            lblDescricaoProduto=new Label();
            txtDescricaoProduto=new TextBox();
            txtProdutoID=new TextBox();
            txtNomeProduto=new TextBox();
            lblProdutoID=new Label();
            lblNomeProduto=new Label();
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
            panelBotoes.Location=new Point(554, 13);
            panelBotoes.Name="panelBotoes";
            panelBotoes.Size=new Size(118, 393);
            panelBotoes.TabIndex=3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(18, 322);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 60);
            btnCancelar.TabIndex=5;
            btnCancelar.Text="LIMPAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(18, 10);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 60);
            btnInserir.TabIndex=1;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(18, 86);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 60);
            btnLocalizar.TabIndex=2;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(18, 246);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 60);
            btnSalvar.TabIndex=4;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(18, 162);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 60);
            btnAlterar.TabIndex=3;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(lblFornecedorID);
            panelDados.Controls.Add(cmbFornecedorID);
            panelDados.Controls.Add(cmbUndMedID);
            panelDados.Controls.Add(cmbCategoriaID);
            panelDados.Controls.Add(cmbSubCategoriaID);
            panelDados.Controls.Add(lblUnidadeMedidaID);
            panelDados.Controls.Add(lblCategoriaID);
            panelDados.Controls.Add(lblSubCategoriaID);
            panelDados.Controls.Add(txtValorPagoProduto);
            panelDados.Controls.Add(txtQtdeProduto);
            panelDados.Controls.Add(txtValorVendaProduto);
            panelDados.Controls.Add(lblQtdeProduto);
            panelDados.Controls.Add(lblValorVendaProduto);
            panelDados.Controls.Add(lblValorPagoProduto);
            panelDados.Controls.Add(lblDescricaoProduto);
            panelDados.Controls.Add(txtDescricaoProduto);
            panelDados.Controls.Add(txtProdutoID);
            panelDados.Controls.Add(txtNomeProduto);
            panelDados.Controls.Add(lblProdutoID);
            panelDados.Controls.Add(lblNomeProduto);
            panelDados.Location=new Point(12, 13);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(536, 393);
            panelDados.TabIndex=2;
            // 
            // lblFornecedorID
            // 
            lblFornecedorID.AutoSize=true;
            lblFornecedorID.Location=new Point(283, 181);
            lblFornecedorID.Name="lblFornecedorID";
            lblFornecedorID.Size=new Size(67, 15);
            lblFornecedorID.TabIndex=19;
            lblFornecedorID.Text="Fornecedor";
            // 
            // cmbFornecedorID
            // 
            cmbFornecedorID.FormattingEnabled=true;
            cmbFornecedorID.Location=new Point(283, 199);
            cmbFornecedorID.Name="cmbFornecedorID";
            cmbFornecedorID.Size=new Size(250, 23);
            cmbFornecedorID.TabIndex=14;
            cmbFornecedorID.Text="Selecionar";
            // 
            // cmbUndMedID
            // 
            cmbUndMedID.FormattingEnabled=true;
            cmbUndMedID.Location=new Point(283, 30);
            cmbUndMedID.Name="cmbUndMedID";
            cmbUndMedID.Size=new Size(250, 23);
            cmbUndMedID.TabIndex=11;
            cmbUndMedID.Text="Selecionar";
            // 
            // cmbCategoriaID
            // 
            cmbCategoriaID.FormattingEnabled=true;
            cmbCategoriaID.Location=new Point(283, 86);
            cmbCategoriaID.Name="cmbCategoriaID";
            cmbCategoriaID.Size=new Size(250, 23);
            cmbCategoriaID.TabIndex=12;
            cmbCategoriaID.Text="Selecionar";
            // 
            // cmbSubCategoriaID
            // 
            cmbSubCategoriaID.FormattingEnabled=true;
            cmbSubCategoriaID.Location=new Point(283, 141);
            cmbSubCategoriaID.Name="cmbSubCategoriaID";
            cmbSubCategoriaID.Size=new Size(250, 23);
            cmbSubCategoriaID.TabIndex=13;
            cmbSubCategoriaID.Text="Selecionar";
            // 
            // lblUnidadeMedidaID
            // 
            lblUnidadeMedidaID.AutoSize=true;
            lblUnidadeMedidaID.Location=new Point(283, 13);
            lblUnidadeMedidaID.Name="lblUnidadeMedidaID";
            lblUnidadeMedidaID.Size=new Size(110, 15);
            lblUnidadeMedidaID.TabIndex=14;
            lblUnidadeMedidaID.Text="Unidade de Medida";
            // 
            // lblCategoriaID
            // 
            lblCategoriaID.AutoSize=true;
            lblCategoriaID.Location=new Point(283, 67);
            lblCategoriaID.Name="lblCategoriaID";
            lblCategoriaID.Size=new Size(58, 15);
            lblCategoriaID.TabIndex=13;
            lblCategoriaID.Text="Categoria";
            // 
            // lblSubCategoriaID
            // 
            lblSubCategoriaID.AutoSize=true;
            lblSubCategoriaID.Location=new Point(283, 123);
            lblSubCategoriaID.Name="lblSubCategoriaID";
            lblSubCategoriaID.Size=new Size(81, 15);
            lblSubCategoriaID.TabIndex=12;
            lblSubCategoriaID.Text="Sub Categoria";
            // 
            // txtValorPagoProduto
            // 
            txtValorPagoProduto.Location=new Point(3, 235);
            txtValorPagoProduto.Name="txtValorPagoProduto";
            txtValorPagoProduto.Size=new Size(129, 23);
            txtValorPagoProduto.TabIndex=8;
            txtValorPagoProduto.Text="0.00";
            txtValorPagoProduto.KeyPress+=txtValorPagoProduto_KeyPress;
            txtValorPagoProduto.Leave+=txtValorPagoProduto_Leave;
            // 
            // txtQtdeProduto
            // 
            txtQtdeProduto.Location=new Point(3, 287);
            txtQtdeProduto.Name="txtQtdeProduto";
            txtQtdeProduto.Size=new Size(129, 23);
            txtQtdeProduto.TabIndex=9;
            txtQtdeProduto.Text="0.00";
            txtQtdeProduto.KeyPress+=txtQtdeProduto_KeyPress;
            txtQtdeProduto.Leave+=txtQtdeProduto_Leave;
            // 
            // txtValorVendaProduto
            // 
            txtValorVendaProduto.Location=new Point(3, 340);
            txtValorVendaProduto.Name="txtValorVendaProduto";
            txtValorVendaProduto.Size=new Size(129, 23);
            txtValorVendaProduto.TabIndex=10;
            txtValorVendaProduto.Text="0.00";
            txtValorVendaProduto.KeyPress+=txtValorVendaProduto_KeyPress;
            txtValorVendaProduto.Leave+=txtValorVendaProduto_Leave;
            // 
            // lblQtdeProduto
            // 
            lblQtdeProduto.AutoSize=true;
            lblQtdeProduto.Location=new Point(3, 269);
            lblQtdeProduto.Name="lblQtdeProduto";
            lblQtdeProduto.Size=new Size(132, 15);
            lblQtdeProduto.TabIndex=8;
            lblQtdeProduto.Text="Quantidade do Produto";
            // 
            // lblValorVendaProduto
            // 
            lblValorVendaProduto.AutoSize=true;
            lblValorVendaProduto.Location=new Point(3, 322);
            lblValorVendaProduto.Name="lblValorVendaProduto";
            lblValorVendaProduto.Size=new Size(84, 15);
            lblValorVendaProduto.TabIndex=7;
            lblValorVendaProduto.Text="Valor de venda";
            // 
            // lblValorPagoProduto
            // 
            lblValorPagoProduto.AutoSize=true;
            lblValorPagoProduto.Location=new Point(3, 217);
            lblValorPagoProduto.Name="lblValorPagoProduto";
            lblValorPagoProduto.Size=new Size(63, 15);
            lblValorPagoProduto.TabIndex=6;
            lblValorPagoProduto.Text="Valor pago";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.AutoSize=true;
            lblDescricaoProduto.Location=new Point(3, 123);
            lblDescricaoProduto.Name="lblDescricaoProduto";
            lblDescricaoProduto.Size=new Size(121, 15);
            lblDescricaoProduto.TabIndex=5;
            lblDescricaoProduto.Text="Descrição do Produto";
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.Location=new Point(3, 141);
            txtDescricaoProduto.Multiline=true;
            txtDescricaoProduto.Name="txtDescricaoProduto";
            txtDescricaoProduto.Size=new Size(257, 60);
            txtDescricaoProduto.TabIndex=7;
            // 
            // txtProdutoID
            // 
            txtProdutoID.Enabled=false;
            txtProdutoID.Location=new Point(3, 31);
            txtProdutoID.Name="txtProdutoID";
            txtProdutoID.Size=new Size(100, 23);
            txtProdutoID.TabIndex=3;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location=new Point(3, 86);
            txtNomeProduto.Name="txtNomeProduto";
            txtNomeProduto.Size=new Size(257, 23);
            txtNomeProduto.TabIndex=6;
            // 
            // lblProdutoID
            // 
            lblProdutoID.AutoSize=true;
            lblProdutoID.Location=new Point(3, 13);
            lblProdutoID.Name="lblProdutoID";
            lblProdutoID.Size=new Size(84, 15);
            lblProdutoID.TabIndex=1;
            lblProdutoID.Text="ID do Produto ";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize=true;
            lblNomeProduto.Location=new Point(3, 67);
            lblNomeProduto.Name="lblNomeProduto";
            lblNomeProduto.Size=new Size(103, 15);
            lblNomeProduto.TabIndex=0;
            lblNomeProduto.Text="Nome do Produto";
            // 
            // formCadastroProduto
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name="formCadastroProduto";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro de Produto";
            Load+=formCadastroProduto_Load;
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
        private Label lblQtdeProduto;
        private Label lblValorVendaProduto;
        private TextBox txtValorPagoProduto;
        private TextBox txtQtdeProduto;
        private TextBox txtValorVendaProduto;
        private Label lblUnidadeMedidaID;
        private Label lblCategoriaID;
        private Label lblSubCategoriaID;
        private ComboBox cmbUndMedID;
        private ComboBox cmbCategoriaID;
        private ComboBox cmbSubCategoriaID;
        private Label lblFornecedorID;
        private ComboBox cmbFornecedorID;
    }
}