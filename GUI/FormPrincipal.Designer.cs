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
            menuPrincipal=new MenuStrip();
            CadastroToolStripMenuItem=new ToolStripMenuItem();
            CategoriaToolStripMenuItem=new ToolStripMenuItem();
            SubCategoriaToolStripMenuItem=new ToolStripMenuItem();
            UnidadeMedidaToolStripMenuItem=new ToolStripMenuItem();
            ProdutoToolStripMenuItem=new ToolStripMenuItem();
            toolStripSeparator1=new ToolStripSeparator();
            ClienteToolStripMenuItem=new ToolStripMenuItem();
            FornecedorToolStripMenuItem=new ToolStripMenuItem();
            UsuarioToolStripMenuItem=new ToolStripMenuItem();
            ConsultasToolStripMenuItem=new ToolStripMenuItem();
            MovimentacoesToolStripMenuItem=new ToolStripMenuItem();
            RelatoriosToolStripMenuItem=new ToolStripMenuItem();
            SairToolStripMenuItem=new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { CadastroToolStripMenuItem, ConsultasToolStripMenuItem, MovimentacoesToolStripMenuItem, RelatoriosToolStripMenuItem, SairToolStripMenuItem });
            menuPrincipal.Location=new Point(0, 0);
            menuPrincipal.Name="menuPrincipal";
            menuPrincipal.Size=new Size(784, 24);
            menuPrincipal.TabIndex=0;
            menuPrincipal.Text="menuStrip1";
            // 
            // CadastroToolStripMenuItem
            // 
            CadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CategoriaToolStripMenuItem, SubCategoriaToolStripMenuItem, UnidadeMedidaToolStripMenuItem, ProdutoToolStripMenuItem, toolStripSeparator1, ClienteToolStripMenuItem, FornecedorToolStripMenuItem, UsuarioToolStripMenuItem });
            CadastroToolStripMenuItem.Name="CadastroToolStripMenuItem";
            CadastroToolStripMenuItem.Size=new Size(85, 20);
            CadastroToolStripMenuItem.Text="CADASTROS";
            CadastroToolStripMenuItem.Click+=CadastroToolStripMenuItem_Click;
            // 
            // CategoriaToolStripMenuItem
            // 
            CategoriaToolStripMenuItem.Name="CategoriaToolStripMenuItem";
            CategoriaToolStripMenuItem.Size=new Size(188, 22);
            CategoriaToolStripMenuItem.Text="CATEGORIA";
            CategoriaToolStripMenuItem.Click+=CategoriaToolStripMenuItem_Click;
            // 
            // SubCategoriaToolStripMenuItem
            // 
            SubCategoriaToolStripMenuItem.Name="SubCategoriaToolStripMenuItem";
            SubCategoriaToolStripMenuItem.Size=new Size(188, 22);
            SubCategoriaToolStripMenuItem.Text="SUBCATEGORIA";
            // 
            // UnidadeMedidaToolStripMenuItem
            // 
            UnidadeMedidaToolStripMenuItem.Name="UnidadeMedidaToolStripMenuItem";
            UnidadeMedidaToolStripMenuItem.Size=new Size(188, 22);
            UnidadeMedidaToolStripMenuItem.Text="UNIDADE DE MEDIDA";
            // 
            // ProdutoToolStripMenuItem
            // 
            ProdutoToolStripMenuItem.Name="ProdutoToolStripMenuItem";
            ProdutoToolStripMenuItem.Size=new Size(188, 22);
            ProdutoToolStripMenuItem.Text="PRODUTO";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name="toolStripSeparator1";
            toolStripSeparator1.Size=new Size(185, 6);
            // 
            // ClienteToolStripMenuItem
            // 
            ClienteToolStripMenuItem.Name="ClienteToolStripMenuItem";
            ClienteToolStripMenuItem.Size=new Size(188, 22);
            ClienteToolStripMenuItem.Text="CLIENTE";
            // 
            // FornecedorToolStripMenuItem
            // 
            FornecedorToolStripMenuItem.Name="FornecedorToolStripMenuItem";
            FornecedorToolStripMenuItem.Size=new Size(188, 22);
            FornecedorToolStripMenuItem.Text="FORNECEDOR";
            // 
            // UsuarioToolStripMenuItem
            // 
            UsuarioToolStripMenuItem.Name="UsuarioToolStripMenuItem";
            UsuarioToolStripMenuItem.Size=new Size(188, 22);
            UsuarioToolStripMenuItem.Text="USUÁRIO";
            // 
            // ConsultasToolStripMenuItem
            // 
            ConsultasToolStripMenuItem.Name="ConsultasToolStripMenuItem";
            ConsultasToolStripMenuItem.Size=new Size(83, 20);
            ConsultasToolStripMenuItem.Text="CONSULTAS";
            // 
            // MovimentacoesToolStripMenuItem
            // 
            MovimentacoesToolStripMenuItem.Name="MovimentacoesToolStripMenuItem";
            MovimentacoesToolStripMenuItem.Size=new Size(117, 20);
            MovimentacoesToolStripMenuItem.Text="MOVIMENTAÇÕES";
            // 
            // RelatoriosToolStripMenuItem
            // 
            RelatoriosToolStripMenuItem.Name="RelatoriosToolStripMenuItem";
            RelatoriosToolStripMenuItem.Size=new Size(84, 20);
            RelatoriosToolStripMenuItem.Text="RELATÓRIOS";
            // 
            // SairToolStripMenuItem
            // 
            SairToolStripMenuItem.Name="SairToolStripMenuItem";
            SairToolStripMenuItem.Size=new Size(43, 20);
            SairToolStripMenuItem.Text="SAIR";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(784, 561);
            Controls.Add(menuPrincipal);
            MainMenuStrip=menuPrincipal;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Estoque Fácil";
            Load+=FormPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem CadastroToolStripMenuItem;
        private ToolStripMenuItem ConsultasToolStripMenuItem;
        private ToolStripMenuItem MovimentacoesToolStripMenuItem;
        private ToolStripMenuItem RelatoriosToolStripMenuItem;
        private ToolStripMenuItem CategoriaToolStripMenuItem;
        private ToolStripMenuItem SubCategoriaToolStripMenuItem;
        private ToolStripMenuItem UnidadeMedidaToolStripMenuItem;
        private ToolStripMenuItem ProdutoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ClienteToolStripMenuItem;
        private ToolStripMenuItem FornecedorToolStripMenuItem;
        private ToolStripMenuItem UsuarioToolStripMenuItem;
        private ToolStripMenuItem SairToolStripMenuItem;
    }
}