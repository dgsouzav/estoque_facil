namespace UI
{
    partial class formCadastroUsuario
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
            txtSenha = new TextBox();
            lblSenha = new Label();
            cmbNivelAcesso = new ComboBox();
            lblNivelAcesso = new Label();
            txtNome = new TextBox();
            txtUsuarioID = new TextBox();
            lblNome = new Label();
            lblUsuarioID = new Label();
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
            panelBotoes.Location = new Point(554, 12);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(118, 394);
            panelBotoes.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(19, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 50);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "LIMPAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(19, 13);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 50);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(19, 98);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(80, 50);
            btnLocalizar.TabIndex = 6;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(19, 253);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 50);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(19, 176);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(80, 50);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtSenha);
            panelDados.Controls.Add(lblSenha);
            panelDados.Controls.Add(cmbNivelAcesso);
            panelDados.Controls.Add(lblNivelAcesso);
            panelDados.Controls.Add(txtNome);
            panelDados.Controls.Add(txtUsuarioID);
            panelDados.Controls.Add(lblNome);
            panelDados.Controls.Add(lblUsuarioID);
            panelDados.Location = new Point(12, 12);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(536, 394);
            panelDados.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(3, 151);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(215, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(3, 133);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // cmbNivelAcesso
            // 
            cmbNivelAcesso.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNivelAcesso.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbNivelAcesso.FormattingEnabled = true;
            cmbNivelAcesso.Location = new Point(3, 212);
            cmbNivelAcesso.Name = "cmbNivelAcesso";
            cmbNivelAcesso.Size = new Size(215, 23);
            cmbNivelAcesso.TabIndex = 4;
            // 
            // lblNivelAcesso
            // 
            lblNivelAcesso.AutoSize = true;
            lblNivelAcesso.Location = new Point(3, 194);
            lblNivelAcesso.Name = "lblNivelAcesso";
            lblNivelAcesso.Size = new Size(88, 15);
            lblNivelAcesso.TabIndex = 0;
            lblNivelAcesso.Text = "Nivel de acesso";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(215, 23);
            txtNome.TabIndex = 2;
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Enabled = false;
            txtUsuarioID.Location = new Point(3, 40);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(81, 23);
            txtUsuarioID.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(3, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(215, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome de usuário(o mesmo para Login)";
            // 
            // lblUsuarioID
            // 
            lblUsuarioID.AutoSize = true;
            lblUsuarioID.Location = new Point(3, 22);
            lblUsuarioID.Name = "lblUsuarioID";
            lblUsuarioID.Size = new Size(78, 15);
            lblUsuarioID.TabIndex = 0;
            lblUsuarioID.Text = "ID do Usuário";
            // 
            // formCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name = "formCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            Load += formCadastroUsuario_Load;
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
        private ComboBox cmbNivelAcesso;
        private Label lblNivelAcesso;
        private TextBox txtNome;
        private TextBox txtUsuarioID;
        private Label lblNome;
        private Label lblUsuarioID;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}