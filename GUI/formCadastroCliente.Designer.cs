namespace UI
{
    partial class formCadastroCliente
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
            txtCEP = new TextBox();
            txtEstado = new TextBox();
            txtEndNumero = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEmail = new TextBox();
            txtFone = new TextBox();
            txtEnderecoFornecedor = new TextBox();
            lblCidade = new Label();
            lblBairro = new Label();
            lblEndNumero = new Label();
            lblEstado = new Label();
            label13 = new Label();
            lblEmail = new Label();
            lblFone = new Label();
            lblEndereco = new Label();
            txtFornecedorID = new TextBox();
            txtNomeFornecedor = new TextBox();
            lblFornecedorID = new Label();
            label20 = new Label();
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
            panelDados.Controls.Add(txtCEP);
            panelDados.Controls.Add(txtEstado);
            panelDados.Controls.Add(txtEndNumero);
            panelDados.Controls.Add(txtBairro);
            panelDados.Controls.Add(txtCidade);
            panelDados.Controls.Add(txtEmail);
            panelDados.Controls.Add(txtFone);
            panelDados.Controls.Add(txtEnderecoFornecedor);
            panelDados.Controls.Add(lblCidade);
            panelDados.Controls.Add(lblBairro);
            panelDados.Controls.Add(lblEndNumero);
            panelDados.Controls.Add(lblEstado);
            panelDados.Controls.Add(label13);
            panelDados.Controls.Add(lblEmail);
            panelDados.Controls.Add(lblFone);
            panelDados.Controls.Add(lblEndereco);
            panelDados.Controls.Add(txtFornecedorID);
            panelDados.Controls.Add(txtNomeFornecedor);
            panelDados.Controls.Add(lblFornecedorID);
            panelDados.Controls.Add(label20);
            panelDados.Location = new Point(14, 16);
            panelDados.Margin = new Padding(3, 4, 3, 4);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(613, 498);
            panelDados.TabIndex = 4;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(475, 154);
            txtCEP.Margin = new Padding(3, 4, 3, 4);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(134, 26);
            txtCEP.TabIndex = 3;
            txtCEP.Leave += txtCEP_Leave;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(314, 262);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(294, 26);
            txtEstado.TabIndex = 11;
            // 
            // txtEndNumero
            // 
            txtEndNumero.Location = new Point(7, 154);
            txtEndNumero.Margin = new Padding(3, 4, 3, 4);
            txtEndNumero.Name = "txtEndNumero";
            txtEndNumero.Size = new Size(98, 26);
            txtEndNumero.TabIndex = 7;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(314, 206);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(294, 26);
            txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(7, 206);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(294, 26);
            txtCidade.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 325);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(603, 26);
            txtEmail.TabIndex = 12;
            // 
            // txtFone
            // 
            txtFone.Location = new Point(7, 262);
            txtFone.Margin = new Padding(3, 4, 3, 4);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(294, 26);
            txtFone.TabIndex = 10;
            txtFone.KeyPress += txtFone_KeyPress;
            // 
            // txtEnderecoFornecedor
            // 
            txtEnderecoFornecedor.Location = new Point(111, 154);
            txtEnderecoFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            txtEnderecoFornecedor.Size = new Size(357, 26);
            txtEnderecoFornecedor.TabIndex = 6;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(5, 183);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(51, 19);
            lblCidade.TabIndex = 14;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(314, 183);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(45, 19);
            lblBairro.TabIndex = 13;
            lblBairro.Text = "Bairro";
            // 
            // lblEndNumero
            // 
            lblEndNumero.AutoSize = true;
            lblEndNumero.Location = new Point(7, 131);
            lblEndNumero.Name = "lblEndNumero";
            lblEndNumero.Size = new Size(59, 19);
            lblEndNumero.TabIndex = 12;
            lblEndNumero.Text = "Número";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(315, 239);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(50, 19);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(474, 133);
            label13.Name = "label13";
            label13.Size = new Size(33, 19);
            label13.TabIndex = 9;
            label13.Text = "CEP";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 302);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 19);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.Location = new Point(6, 239);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(59, 19);
            lblFone.TabIndex = 7;
            lblFone.Text = "Telefone";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(111, 131);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(177, 19);
            lblEndereco.TabIndex = 6;
            lblEndereco.Text = "Endereço(Rua, Avenida, etc)";
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Enabled = false;
            txtFornecedorID.Location = new Point(6, 39);
            txtFornecedorID.Margin = new Padding(3, 4, 3, 4);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.Size = new Size(114, 26);
            txtFornecedorID.TabIndex = 3;
            // 
            // txtNomeFornecedor
            // 
            txtNomeFornecedor.Location = new Point(6, 95);
            txtNomeFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtNomeFornecedor.Name = "txtNomeFornecedor";
            txtNomeFornecedor.Size = new Size(605, 26);
            txtNomeFornecedor.TabIndex = 1;
            // 
            // lblFornecedorID
            // 
            lblFornecedorID.AutoSize = true;
            lblFornecedorID.Location = new Point(3, 16);
            lblFornecedorID.Name = "lblFornecedorID";
            lblFornecedorID.Size = new Size(69, 19);
            lblFornecedorID.TabIndex = 1;
            lblFornecedorID.Text = "Cliente ID";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(5, 72);
            label20.Name = "label20";
            label20.Size = new Size(112, 19);
            label20.TabIndex = 0;
            label20.Text = "Nome do Cliente";
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Location = new Point(633, 15);
            panelBotoes.Margin = new Padding(3, 4, 3, 4);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(135, 498);
            panelBotoes.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(21, 408);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 76);
            btnCancelar.TabIndex = 17;
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
            btnInserir.TabIndex = 13;
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
            btnLocalizar.TabIndex = 14;
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
            btnSalvar.TabIndex = 16;
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
            btnAlterar.TabIndex = 15;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // formCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 529);
            Controls.Add(panelDados);
            Controls.Add(panelBotoes);
            Name = "formCadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            Load += formCadastroCliente_Load;
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelDados;
        private TextBox txtCEP;
        private TextBox txtEstado;
        private TextBox txtEndNumero;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEmail;
        private TextBox txtFone;
        private TextBox txtEnderecoFornecedor;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblEndNumero;
        private Label lblEstado;
        private Label label13;
        private Label lblEmail;
        private Label lblFone;
        private Label lblEndereco;
        private TextBox txtFornecedorID;
        private TextBox txtNomeFornecedor;
        private Label lblFornecedorID;
        private Label label20;
        protected Panel panelBotoes;
        protected Button btnCancelar;
        protected Button btnInserir;
        protected Button btnLocalizar;
        protected Button btnSalvar;
        protected Button btnAlterar;
    }
}