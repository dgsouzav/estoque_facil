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
            panelDados = new Panel();
            txtCategoriaID = new TextBox();
            txtNomeCategoria = new TextBox();
            lblCategoriaID = new Label();
            lblNomeCategoria = new Label();
            panelBotoes = new Panel();
            btnCancelar = new Button();
            btnInserir = new Button();
            btnLocalizar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
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
            panelDados.Location = new Point(12, 12);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(536, 393);
            panelDados.TabIndex = 0;
            // 
            // txtCategoriaID
            // 
            txtCategoriaID.Enabled = false;
            txtCategoriaID.Location = new Point(3, 31);
            txtCategoriaID.Name = "txtCategoriaID";
            txtCategoriaID.Size = new Size(100, 23);
            txtCategoriaID.TabIndex = 3;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(3, 95);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(530, 23);
            txtNomeCategoria.TabIndex = 1;
            txtNomeCategoria.KeyPress += txtNomeCategoria_KeyPress;
            // 
            // lblCategoriaID
            // 
            lblCategoriaID.AutoSize = true;
            lblCategoriaID.Location = new Point(3, 13);
            lblCategoriaID.Name = "lblCategoriaID";
            lblCategoriaID.Size = new Size(72, 15);
            lblCategoriaID.TabIndex = 1;
            lblCategoriaID.Text = "Categoria ID";
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.Location = new Point(3, 77);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(110, 15);
            lblNomeCategoria.TabIndex = 0;
            lblNomeCategoria.Text = "Nome da Categoria";
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Location = new Point(554, 12);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(118, 393);
            panelBotoes.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(18, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 60);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "LIMPAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(18, 10);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 60);
            btnInserir.TabIndex = 2;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(18, 86);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(80, 60);
            btnLocalizar.TabIndex = 3;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(18, 246);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 60);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(18, 162);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(80, 60);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // formCadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            KeyPreview = true;
            Name = "formCadastroCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Categoria";
            Load += formCadastroCategoria_Load;
            KeyDown += formCadastroCategoria_KeyDown;
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
        protected Panel panelDados;
        protected Panel panelBotoes;
        private TextBox txtCategoriaID;
        private TextBox txtNomeCategoria;
        private Label lblCategoriaID;
        private Label lblNomeCategoria;
    }
}