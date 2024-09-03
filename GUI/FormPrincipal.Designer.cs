namespace UI
{
    partial class FormPrincipal
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
            menuPrincipal = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroClienteToolStripMenuItem5 = new ToolStripMenuItem();
            consultaClienteToolStripMenuItem4 = new ToolStripMenuItem();
            relatorioClienteToolStripMenuItem3 = new ToolStripMenuItem();
            fornedeoresToolStripMenuItem = new ToolStripMenuItem();
            cadastroFornecedorToolStripMenuItem2 = new ToolStripMenuItem();
            consultaFornecedorToolStripMenuItem1 = new ToolStripMenuItem();
            relatorioFornecedorToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            cadastroProdutoToolStripMenuItem1 = new ToolStripMenuItem();
            consultaProdutoToolStripMenuItem = new ToolStripMenuItem();
            relatorioProdutoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            categoriaToolStripMenuItem3 = new ToolStripMenuItem();
            cadastroCategoriaToolStripMenuItem = new ToolStripMenuItem();
            consultaCategoriaToolStripMenuItem1 = new ToolStripMenuItem();
            subcategotiaToolStripMenuItem = new ToolStripMenuItem();
            cadastroSubCategoriaToolStripMenuItem2 = new ToolStripMenuItem();
            consultaSubCategoriaToolStripMenuItem4 = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            unidadeDeMedidaToolStripMenuItem1 = new ToolStripMenuItem();
            cadastroUnidadeDeMedidaToolStripMenuItem5 = new ToolStripMenuItem();
            consultaUnidadeDeMedidaToolStripMenuItem5 = new ToolStripMenuItem();
            tipoDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            cadastroTipoDePagamentoToolStripMenuItem3 = new ToolStripMenuItem();
            consultaTipoDePagamentoToolStripMenuItem2 = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastroUsuarioToolStripMenuItem4 = new ToolStripMenuItem();
            consultaUsuarioToolStripMenuItem3 = new ToolStripMenuItem();
            relatorioUsuarioToolStripMenuItem2 = new ToolStripMenuItem();
            MovimentacoesToolStripMenuItem = new ToolStripMenuItem();
            VendaToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem1 = new ToolStripMenuItem();
            consultaVendaToolStripMenuItem = new ToolStripMenuItem();
            relatorioVendaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            compraToolStripMenuItem = new ToolStripMenuItem();
            cadastroCompraToolStripMenuItem = new ToolStripMenuItem();
            consultaCompraToolStripMenuItem = new ToolStripMenuItem();
            relatorioCompraToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fluxoDeCaixaToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            gastosToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            abrirCaixaToolStripMenuItem = new ToolStripMenuItem();
            fecharCaixaToolStripMenuItem = new ToolStripMenuItem();
            SairToolStripMenuItem1 = new ToolStripMenuItem();
            lblUsuarioAtual = new Label();
            lblProdutosFaltantes = new Label();
            lblBemVindo = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, fornedeoresToolStripMenuItem, produtosToolStripMenuItem, tipoDePagamentoToolStripMenuItem, usuáriosToolStripMenuItem, MovimentacoesToolStripMenuItem, SairToolStripMenuItem1 });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(5, 2, 0, 2);
            menuPrincipal.Size = new Size(1664, 25);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroClienteToolStripMenuItem5, consultaClienteToolStripMenuItem4, relatorioClienteToolStripMenuItem3 });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(59, 21);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroClienteToolStripMenuItem5
            // 
            cadastroClienteToolStripMenuItem5.Name = "cadastroClienteToolStripMenuItem5";
            cadastroClienteToolStripMenuItem5.Size = new Size(129, 22);
            cadastroClienteToolStripMenuItem5.Text = "Cadastro";
            cadastroClienteToolStripMenuItem5.Click += cadastroClienteToolStripMenuItem5_Click;
            // 
            // consultaClienteToolStripMenuItem4
            // 
            consultaClienteToolStripMenuItem4.Name = "consultaClienteToolStripMenuItem4";
            consultaClienteToolStripMenuItem4.Size = new Size(129, 22);
            consultaClienteToolStripMenuItem4.Text = "Consulta";
            consultaClienteToolStripMenuItem4.Click += consultaClienteToolStripMenuItem4_Click;
            // 
            // relatorioClienteToolStripMenuItem3
            // 
            relatorioClienteToolStripMenuItem3.Name = "relatorioClienteToolStripMenuItem3";
            relatorioClienteToolStripMenuItem3.Size = new Size(129, 22);
            relatorioClienteToolStripMenuItem3.Text = "Relatório";
            relatorioClienteToolStripMenuItem3.Click += relatórioClienteToolStripMenuItem3_Click;
            // 
            // fornedeoresToolStripMenuItem
            // 
            fornedeoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroFornecedorToolStripMenuItem2, consultaFornecedorToolStripMenuItem1, relatorioFornecedorToolStripMenuItem1 });
            fornedeoresToolStripMenuItem.Name = "fornedeoresToolStripMenuItem";
            fornedeoresToolStripMenuItem.Size = new Size(100, 21);
            fornedeoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // cadastroFornecedorToolStripMenuItem2
            // 
            cadastroFornecedorToolStripMenuItem2.Name = "cadastroFornecedorToolStripMenuItem2";
            cadastroFornecedorToolStripMenuItem2.Size = new Size(129, 22);
            cadastroFornecedorToolStripMenuItem2.Text = "Cadastro";
            cadastroFornecedorToolStripMenuItem2.Click += cadastroFornecedorToolStripMenuItem2_Click;
            // 
            // consultaFornecedorToolStripMenuItem1
            // 
            consultaFornecedorToolStripMenuItem1.Name = "consultaFornecedorToolStripMenuItem1";
            consultaFornecedorToolStripMenuItem1.Size = new Size(129, 22);
            consultaFornecedorToolStripMenuItem1.Text = "Consulta";
            consultaFornecedorToolStripMenuItem1.Click += consultaFornecedorToolStripMenuItem1_Click;
            // 
            // relatorioFornecedorToolStripMenuItem1
            // 
            relatorioFornecedorToolStripMenuItem1.Name = "relatorioFornecedorToolStripMenuItem1";
            relatorioFornecedorToolStripMenuItem1.Size = new Size(129, 22);
            relatorioFornecedorToolStripMenuItem1.Text = "Relatório";
            relatorioFornecedorToolStripMenuItem1.Click += relatorioFornecedorToolStripMenuItem1_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroProdutoToolStripMenuItem1, consultaProdutoToolStripMenuItem, relatorioProdutoToolStripMenuItem, toolStripSeparator4, categoriaToolStripMenuItem3, subcategotiaToolStripMenuItem, toolStripSeparator7, unidadeDeMedidaToolStripMenuItem1 });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(73, 21);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastroProdutoToolStripMenuItem1
            // 
            cadastroProdutoToolStripMenuItem1.Name = "cadastroProdutoToolStripMenuItem1";
            cadastroProdutoToolStripMenuItem1.Size = new Size(192, 22);
            cadastroProdutoToolStripMenuItem1.Text = "Cadastro";
            cadastroProdutoToolStripMenuItem1.Click += cadastroProdutoToolStripMenuItem1_Click;
            // 
            // consultaProdutoToolStripMenuItem
            // 
            consultaProdutoToolStripMenuItem.Name = "consultaProdutoToolStripMenuItem";
            consultaProdutoToolStripMenuItem.Size = new Size(192, 22);
            consultaProdutoToolStripMenuItem.Text = "Consulta";
            consultaProdutoToolStripMenuItem.Click += consultaProdutoToolStripMenuItem_Click;
            // 
            // relatorioProdutoToolStripMenuItem
            // 
            relatorioProdutoToolStripMenuItem.Name = "relatorioProdutoToolStripMenuItem";
            relatorioProdutoToolStripMenuItem.Size = new Size(192, 22);
            relatorioProdutoToolStripMenuItem.Text = "Relatório";
            relatorioProdutoToolStripMenuItem.Click += relatórioProdutoToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(189, 6);
            // 
            // categoriaToolStripMenuItem3
            // 
            categoriaToolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { cadastroCategoriaToolStripMenuItem, consultaCategoriaToolStripMenuItem1 });
            categoriaToolStripMenuItem3.Name = "categoriaToolStripMenuItem3";
            categoriaToolStripMenuItem3.Size = new Size(192, 22);
            categoriaToolStripMenuItem3.Text = "Categoria";
            // 
            // cadastroCategoriaToolStripMenuItem
            // 
            cadastroCategoriaToolStripMenuItem.Name = "cadastroCategoriaToolStripMenuItem";
            cadastroCategoriaToolStripMenuItem.Size = new Size(129, 22);
            cadastroCategoriaToolStripMenuItem.Text = "Cadastro";
            cadastroCategoriaToolStripMenuItem.Click += cadastroCategoriaToolStripMenuItem_Click;
            // 
            // consultaCategoriaToolStripMenuItem1
            // 
            consultaCategoriaToolStripMenuItem1.Name = "consultaCategoriaToolStripMenuItem1";
            consultaCategoriaToolStripMenuItem1.Size = new Size(129, 22);
            consultaCategoriaToolStripMenuItem1.Text = "Consulta";
            consultaCategoriaToolStripMenuItem1.Click += consultaCategoriaToolStripMenuItem1_Click;
            // 
            // subcategotiaToolStripMenuItem
            // 
            subcategotiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroSubCategoriaToolStripMenuItem2, consultaSubCategoriaToolStripMenuItem4 });
            subcategotiaToolStripMenuItem.Name = "subcategotiaToolStripMenuItem";
            subcategotiaToolStripMenuItem.Size = new Size(192, 22);
            subcategotiaToolStripMenuItem.Text = "Sub-categoria";
            // 
            // cadastroSubCategoriaToolStripMenuItem2
            // 
            cadastroSubCategoriaToolStripMenuItem2.Name = "cadastroSubCategoriaToolStripMenuItem2";
            cadastroSubCategoriaToolStripMenuItem2.Size = new Size(129, 22);
            cadastroSubCategoriaToolStripMenuItem2.Text = "Cadastro";
            cadastroSubCategoriaToolStripMenuItem2.Click += cadastroSubCategoriaToolStripMenuItem2_Click;
            // 
            // consultaSubCategoriaToolStripMenuItem4
            // 
            consultaSubCategoriaToolStripMenuItem4.Name = "consultaSubCategoriaToolStripMenuItem4";
            consultaSubCategoriaToolStripMenuItem4.Size = new Size(129, 22);
            consultaSubCategoriaToolStripMenuItem4.Text = "Consulta";
            consultaSubCategoriaToolStripMenuItem4.Click += consultaSubCategoriaToolStripMenuItem4_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(189, 6);
            // 
            // unidadeDeMedidaToolStripMenuItem1
            // 
            unidadeDeMedidaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cadastroUnidadeDeMedidaToolStripMenuItem5, consultaUnidadeDeMedidaToolStripMenuItem5 });
            unidadeDeMedidaToolStripMenuItem1.Name = "unidadeDeMedidaToolStripMenuItem1";
            unidadeDeMedidaToolStripMenuItem1.Size = new Size(192, 22);
            unidadeDeMedidaToolStripMenuItem1.Text = "Unidade de medida";
            // 
            // cadastroUnidadeDeMedidaToolStripMenuItem5
            // 
            cadastroUnidadeDeMedidaToolStripMenuItem5.Name = "cadastroUnidadeDeMedidaToolStripMenuItem5";
            cadastroUnidadeDeMedidaToolStripMenuItem5.Size = new Size(129, 22);
            cadastroUnidadeDeMedidaToolStripMenuItem5.Text = "Cadastro";
            cadastroUnidadeDeMedidaToolStripMenuItem5.Click += cadastroUnidadeDeMedidaToolStripMenuItem5_Click;
            // 
            // consultaUnidadeDeMedidaToolStripMenuItem5
            // 
            consultaUnidadeDeMedidaToolStripMenuItem5.Name = "consultaUnidadeDeMedidaToolStripMenuItem5";
            consultaUnidadeDeMedidaToolStripMenuItem5.Size = new Size(129, 22);
            consultaUnidadeDeMedidaToolStripMenuItem5.Text = "Consulta";
            consultaUnidadeDeMedidaToolStripMenuItem5.Click += consultaUnidadeDeMedidaToolStripMenuItem5_Click;
            // 
            // tipoDePagamentoToolStripMenuItem
            // 
            tipoDePagamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroTipoDePagamentoToolStripMenuItem3, consultaTipoDePagamentoToolStripMenuItem2 });
            tipoDePagamentoToolStripMenuItem.Name = "tipoDePagamentoToolStripMenuItem";
            tipoDePagamentoToolStripMenuItem.Size = new Size(136, 21);
            tipoDePagamentoToolStripMenuItem.Text = "Tipo de pagamento";
            // 
            // cadastroTipoDePagamentoToolStripMenuItem3
            // 
            cadastroTipoDePagamentoToolStripMenuItem3.Name = "cadastroTipoDePagamentoToolStripMenuItem3";
            cadastroTipoDePagamentoToolStripMenuItem3.Size = new Size(129, 22);
            cadastroTipoDePagamentoToolStripMenuItem3.Text = "Cadastro";
            cadastroTipoDePagamentoToolStripMenuItem3.Click += cadastroTipoDePagamentoToolStripMenuItem3_Click;
            // 
            // consultaTipoDePagamentoToolStripMenuItem2
            // 
            consultaTipoDePagamentoToolStripMenuItem2.Name = "consultaTipoDePagamentoToolStripMenuItem2";
            consultaTipoDePagamentoToolStripMenuItem2.Size = new Size(129, 22);
            consultaTipoDePagamentoToolStripMenuItem2.Text = "Consulta";
            consultaTipoDePagamentoToolStripMenuItem2.Click += consultaTipoDePagamentoToolStripMenuItem2_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroUsuarioToolStripMenuItem4, consultaUsuarioToolStripMenuItem3, relatorioUsuarioToolStripMenuItem2 });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(71, 21);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastroUsuarioToolStripMenuItem4
            // 
            cadastroUsuarioToolStripMenuItem4.Name = "cadastroUsuarioToolStripMenuItem4";
            cadastroUsuarioToolStripMenuItem4.Size = new Size(129, 22);
            cadastroUsuarioToolStripMenuItem4.Text = "Cadastro";
            cadastroUsuarioToolStripMenuItem4.Click += cadastroUsuarioToolStripMenuItem4_Click;
            // 
            // consultaUsuarioToolStripMenuItem3
            // 
            consultaUsuarioToolStripMenuItem3.Name = "consultaUsuarioToolStripMenuItem3";
            consultaUsuarioToolStripMenuItem3.Size = new Size(129, 22);
            consultaUsuarioToolStripMenuItem3.Text = "Consulta";
            consultaUsuarioToolStripMenuItem3.Click += consultaUsuarioToolStripMenuItem3_Click;
            // 
            // relatorioUsuarioToolStripMenuItem2
            // 
            relatorioUsuarioToolStripMenuItem2.Name = "relatorioUsuarioToolStripMenuItem2";
            relatorioUsuarioToolStripMenuItem2.Size = new Size(129, 22);
            relatorioUsuarioToolStripMenuItem2.Text = "Relatório";
            relatorioUsuarioToolStripMenuItem2.Click += relatórioUsuarioToolStripMenuItem2_Click;
            // 
            // MovimentacoesToolStripMenuItem
            // 
            MovimentacoesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { VendaToolStripMenuItem, toolStripSeparator3, compraToolStripMenuItem, toolStripSeparator1, fluxoDeCaixaToolStripMenuItem, toolStripSeparator5, gastosToolStripMenuItem, toolStripSeparator2, abrirCaixaToolStripMenuItem, fecharCaixaToolStripMenuItem });
            MovimentacoesToolStripMenuItem.Name = "MovimentacoesToolStripMenuItem";
            MovimentacoesToolStripMenuItem.Size = new Size(112, 21);
            MovimentacoesToolStripMenuItem.Text = "Movimentações";
            // 
            // VendaToolStripMenuItem
            // 
            VendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendaToolStripMenuItem1, consultaVendaToolStripMenuItem, relatorioVendaToolStripMenuItem });
            VendaToolStripMenuItem.Name = "VendaToolStripMenuItem";
            VendaToolStripMenuItem.Size = new Size(164, 22);
            VendaToolStripMenuItem.Text = "Frente de caixa";
            // 
            // vendaToolStripMenuItem1
            // 
            vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            vendaToolStripMenuItem1.Size = new Size(129, 22);
            vendaToolStripMenuItem1.Text = "Venda";
            vendaToolStripMenuItem1.Click += vendaToolStripMenuItem1_Click_1;
            // 
            // consultaVendaToolStripMenuItem
            // 
            consultaVendaToolStripMenuItem.Name = "consultaVendaToolStripMenuItem";
            consultaVendaToolStripMenuItem.Size = new Size(129, 22);
            consultaVendaToolStripMenuItem.Text = "Consulta";
            consultaVendaToolStripMenuItem.Click += consultaVendaToolStripMenuItem_Click;
            // 
            // relatorioVendaToolStripMenuItem
            // 
            relatorioVendaToolStripMenuItem.Name = "relatorioVendaToolStripMenuItem";
            relatorioVendaToolStripMenuItem.Size = new Size(129, 22);
            relatorioVendaToolStripMenuItem.Text = "Relatório";
            relatorioVendaToolStripMenuItem.Click += relatórioVendaToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(161, 6);
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroCompraToolStripMenuItem, consultaCompraToolStripMenuItem, relatorioCompraToolStripMenuItem });
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(164, 22);
            compraToolStripMenuItem.Text = "Compra";
            // 
            // cadastroCompraToolStripMenuItem
            // 
            cadastroCompraToolStripMenuItem.Name = "cadastroCompraToolStripMenuItem";
            cadastroCompraToolStripMenuItem.Size = new Size(129, 22);
            cadastroCompraToolStripMenuItem.Text = "Cadastro";
            cadastroCompraToolStripMenuItem.Click += cadastroCompraToolStripMenuItem_Click;
            // 
            // consultaCompraToolStripMenuItem
            // 
            consultaCompraToolStripMenuItem.Name = "consultaCompraToolStripMenuItem";
            consultaCompraToolStripMenuItem.Size = new Size(129, 22);
            consultaCompraToolStripMenuItem.Text = "Consulta";
            consultaCompraToolStripMenuItem.Click += consultaCompraToolStripMenuItem_Click;
            // 
            // relatorioCompraToolStripMenuItem
            // 
            relatorioCompraToolStripMenuItem.Name = "relatorioCompraToolStripMenuItem";
            relatorioCompraToolStripMenuItem.Size = new Size(129, 22);
            relatorioCompraToolStripMenuItem.Text = "Relatorio";
            relatorioCompraToolStripMenuItem.Click += relatorioCompraToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(161, 6);
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            fluxoDeCaixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioToolStripMenuItem });
            fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            fluxoDeCaixaToolStripMenuItem.Size = new Size(164, 22);
            fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de Caixa";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(129, 22);
            relatórioToolStripMenuItem.Text = "Relatório";
            relatórioToolStripMenuItem.Click += relatórioToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(161, 6);
            // 
            // gastosToolStripMenuItem
            // 
            gastosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relatorioToolStripMenuItem });
            gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            gastosToolStripMenuItem.Size = new Size(164, 22);
            gastosToolStripMenuItem.Text = "Despesa";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(129, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(129, 22);
            relatorioToolStripMenuItem.Text = "Relatorio";
            relatorioToolStripMenuItem.Click += relatorioToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(161, 6);
            // 
            // abrirCaixaToolStripMenuItem
            // 
            abrirCaixaToolStripMenuItem.Name = "abrirCaixaToolStripMenuItem";
            abrirCaixaToolStripMenuItem.Size = new Size(164, 22);
            abrirCaixaToolStripMenuItem.Text = "Abrir caixa";
            abrirCaixaToolStripMenuItem.Click += abrirCaixaToolStripMenuItem_Click;
            // 
            // fecharCaixaToolStripMenuItem
            // 
            fecharCaixaToolStripMenuItem.Name = "fecharCaixaToolStripMenuItem";
            fecharCaixaToolStripMenuItem.Size = new Size(164, 22);
            fecharCaixaToolStripMenuItem.Text = "Fechar caixa";
            fecharCaixaToolStripMenuItem.Click += fecharCaixaToolStripMenuItem_Click;
            // 
            // SairToolStripMenuItem1
            // 
            SairToolStripMenuItem1.Name = "SairToolStripMenuItem1";
            SairToolStripMenuItem1.Size = new Size(42, 21);
            SairToolStripMenuItem1.Text = "Sair";
            SairToolStripMenuItem1.Click += SairToolStripMenuItem1_Click;
            // 
            // lblUsuarioAtual
            // 
            lblUsuarioAtual.AutoSize = true;
            lblUsuarioAtual.BackColor = Color.FromArgb(192, 255, 192);
            lblUsuarioAtual.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuarioAtual.ForeColor = SystemColors.ControlText;
            lblUsuarioAtual.Location = new Point(10, 679);
            lblUsuarioAtual.Name = "lblUsuarioAtual";
            lblUsuarioAtual.Size = new Size(78, 18);
            lblUsuarioAtual.TabIndex = 11;
            lblUsuarioAtual.Text = "Usuario";
            // 
            // lblProdutosFaltantes
            // 
            lblProdutosFaltantes.AutoSize = true;
            lblProdutosFaltantes.BackColor = Color.FromArgb(255, 128, 128);
            lblProdutosFaltantes.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProdutosFaltantes.ForeColor = SystemColors.ControlText;
            lblProdutosFaltantes.Location = new Point(10, 713);
            lblProdutosFaltantes.Name = "lblProdutosFaltantes";
            lblProdutosFaltantes.Size = new Size(88, 18);
            lblProdutosFaltantes.TabIndex = 12;
            lblProdutosFaltantes.Text = "Produtos";
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.BackColor = Color.Transparent;
            lblBemVindo.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBemVindo.ForeColor = SystemColors.ControlText;
            lblBemVindo.Location = new Point(665, 25);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(0, 20);
            lblBemVindo.TabIndex = 13;
            lblBemVindo.TextAlign = ContentAlignment.TopCenter;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(10, 84);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(867, 296);
            formsPlot1.TabIndex = 14;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1664, 802);
            Controls.Add(formsPlot1);
            Controls.Add(lblBemVindo);
            Controls.Add(lblProdutosFaltantes);
            Controls.Add(lblUsuarioAtual);
            Controls.Add(menuPrincipal);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuPrincipal;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque Fácil";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem MovimentacoesToolStripMenuItem;
        private ToolStripMenuItem VendaToolStripMenuItem;
        private ToolStripMenuItem SairToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private Label lblUsuarioAtual;
        private Label lblProdutosFaltantes;
        private Label lblBemVindo;
        private ToolStripMenuItem fornedeoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem cadastroProdutoToolStripMenuItem1;
        private ToolStripMenuItem consultaProdutoToolStripMenuItem;
        private ToolStripMenuItem relatorioProdutoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem categoriaToolStripMenuItem3;
        private ToolStripMenuItem subcategotiaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem unidadeDeMedidaToolStripMenuItem1;
        private ToolStripMenuItem tipoDePagamentoToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastroClienteToolStripMenuItem5;
        private ToolStripMenuItem consultaClienteToolStripMenuItem4;
        private ToolStripMenuItem relatorioClienteToolStripMenuItem3;
        private ToolStripMenuItem cadastroFornecedorToolStripMenuItem2;
        private ToolStripMenuItem consultaFornecedorToolStripMenuItem1;
        private ToolStripMenuItem relatorioFornecedorToolStripMenuItem1;
        private ToolStripMenuItem cadastroTipoDePagamentoToolStripMenuItem3;
        private ToolStripMenuItem consultaTipoDePagamentoToolStripMenuItem2;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem cadastroUsuarioToolStripMenuItem4;
        private ToolStripMenuItem consultaUsuarioToolStripMenuItem3;
        private ToolStripMenuItem relatorioUsuarioToolStripMenuItem2;
        private ToolStripMenuItem cadastroCategoriaToolStripMenuItem;
        private ToolStripMenuItem consultaCategoriaToolStripMenuItem1;
        private ToolStripMenuItem cadastroSubCategoriaToolStripMenuItem2;
        private ToolStripMenuItem consultaSubCategoriaToolStripMenuItem4;
        private ToolStripMenuItem cadastroUnidadeDeMedidaToolStripMenuItem5;
        private ToolStripMenuItem consultaUnidadeDeMedidaToolStripMenuItem5;
        private ToolStripMenuItem vendaToolStripMenuItem1;
        private ToolStripMenuItem relatorioVendaToolStripMenuItem;
        private ToolStripMenuItem consultaVendaToolStripMenuItem;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem cadastroCompraToolStripMenuItem;
        private ToolStripMenuItem consultaCompraToolStripMenuItem;
        private ToolStripMenuItem relatorioCompraToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem gastosToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem abrirCaixaToolStripMenuItem;
        private ToolStripMenuItem fecharCaixaToolStripMenuItem;
        private ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ScottPlot.WinForms.FormsPlot graficoVenda;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}