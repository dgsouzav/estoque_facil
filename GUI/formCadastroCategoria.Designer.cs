namespace UI
{
    partial class formCadastroCategoria
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
            panelBotoes=new Panel();
            btnCancelar=new Button();
            btnInserir=new Button();
            btnLocalizar=new Button();
            btnSalvar=new Button();
            btnAlterar=new Button();
            btnExcluir=new Button();
            lblNomeCategoria=new Label();
            lblCategoriaID=new Label();
            txtNomeCategoria=new TextBox();
            txtCategoriaID=new TextBox();
            panelDados.SuspendLayout();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtCategoriaID);
            panelDados.Controls.Add(txtNomeCategoria);
            panelDados.Controls.Add(lblCategoriaID);
            panelDados.Controls.Add(lblNomeCategoria);
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(536, 437);
            panelDados.TabIndex=0;
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Controls.Add(btnExcluir);
            panelBotoes.Location=new Point(554, 12);
            panelBotoes.Name="panelBotoes";
            panelBotoes.Size=new Size(118, 437);
            panelBotoes.TabIndex=1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(19, 384);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 50);
            btnCancelar.TabIndex=11;
            btnCancelar.Text="CANCELAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(19, 4);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 50);
            btnInserir.TabIndex=6;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(19, 80);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 50);
            btnLocalizar.TabIndex=7;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(19, 308);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 50);
            btnSalvar.TabIndex=10;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(19, 156);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 50);
            btnAlterar.TabIndex=8;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(19, 232);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 50);
            btnExcluir.TabIndex=9;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize=true;
            lblNomeCategoria.Location=new Point(3, 77);
            lblNomeCategoria.Name="lblNomeCategoria";
            lblNomeCategoria.Size=new Size(110, 15);
            lblNomeCategoria.TabIndex=0;
            lblNomeCategoria.Text="Nome da Categoria";
            // 
            // lblCategoriaID
            // 
            lblCategoriaID.AutoSize=true;
            lblCategoriaID.Location=new Point(3, 13);
            lblCategoriaID.Name="lblCategoriaID";
            lblCategoriaID.Size=new Size(72, 15);
            lblCategoriaID.TabIndex=1;
            lblCategoriaID.Text="Categoria ID";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location=new Point(3, 95);
            txtNomeCategoria.Name="txtNomeCategoria";
            txtNomeCategoria.Size=new Size(530, 23);
            txtNomeCategoria.TabIndex=2;
            // 
            // txtCategoriaID
            // 
            txtCategoriaID.Location=new Point(3, 31);
            txtCategoriaID.Name="txtCategoriaID";
            txtCategoriaID.Size=new Size(100, 23);
            txtCategoriaID.TabIndex=3;
            // 
            // formCadastroCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 461);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            KeyPreview=true;
            Name="formCadastroCategoria";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro de Categoria";
            Load+=formCadastroCategoria_Load;
            KeyDown+=formCadastroCategoria_KeyDown;
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        protected Button btnCancelar;
        protected Button btnInserir;
        protected Button btnLocalizar;
        protected Button btnSalvar;
        protected Button btnAlterar;
        protected Button btnExcluir;
        protected Panel panelDados;
        protected Panel panelBotoes;
        private TextBox txtCategoriaID;
        private TextBox txtNomeCategoria;
        private Label lblCategoriaID;
        private Label lblNomeCategoria;
    }
}