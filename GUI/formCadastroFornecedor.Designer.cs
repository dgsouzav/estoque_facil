namespace UI
{
    partial class formCadastroFornecedor
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
            lblCnpjInvalido = new Label();
            txtCEP = new TextBox();
            txtEstado = new TextBox();
            txtCNPJ = new TextBox();
            txtEndNumero = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEmail = new TextBox();
            txtFone = new TextBox();
            txtEnderecoFornecedor = new TextBox();
            txtInscricaoEstadual = new TextBox();
            txtRazaoSocial = new TextBox();
            lblCidade = new Label();
            lblBairro = new Label();
            lblEndNumero = new Label();
            label8 = new Label();
            lblEstado = new Label();
            label13 = new Label();
            lblEmail = new Label();
            lblFone = new Label();
            lblEndereco = new Label();
            label17 = new Label();
            label18 = new Label();
            txtFornecedorID = new TextBox();
            txtNomeFornecedor = new TextBox();
            lblFornecedorID = new Label();
            label20 = new Label();
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
            panelBotoes.Size = new Size(118, 393);
            panelBotoes.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(18, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 60);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "LIMPAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(18, 10);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 60);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(18, 86);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(80, 60);
            btnLocalizar.TabIndex = 14;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(18, 246);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 60);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(18, 162);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(80, 60);
            btnAlterar.TabIndex = 15;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(lblCnpjInvalido);
            panelDados.Controls.Add(txtCEP);
            panelDados.Controls.Add(txtEstado);
            panelDados.Controls.Add(txtCNPJ);
            panelDados.Controls.Add(txtEndNumero);
            panelDados.Controls.Add(txtBairro);
            panelDados.Controls.Add(txtCidade);
            panelDados.Controls.Add(txtEmail);
            panelDados.Controls.Add(txtFone);
            panelDados.Controls.Add(txtEnderecoFornecedor);
            panelDados.Controls.Add(txtInscricaoEstadual);
            panelDados.Controls.Add(txtRazaoSocial);
            panelDados.Controls.Add(lblCidade);
            panelDados.Controls.Add(lblBairro);
            panelDados.Controls.Add(lblEndNumero);
            panelDados.Controls.Add(label8);
            panelDados.Controls.Add(lblEstado);
            panelDados.Controls.Add(label13);
            panelDados.Controls.Add(lblEmail);
            panelDados.Controls.Add(lblFone);
            panelDados.Controls.Add(lblEndereco);
            panelDados.Controls.Add(label17);
            panelDados.Controls.Add(label18);
            panelDados.Controls.Add(txtFornecedorID);
            panelDados.Controls.Add(txtNomeFornecedor);
            panelDados.Controls.Add(lblFornecedorID);
            panelDados.Controls.Add(label20);
            panelDados.Location = new Point(12, 13);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(536, 393);
            panelDados.TabIndex = 2;
            // 
            // lblCnpjInvalido
            // 
            lblCnpjInvalido.AutoSize = true;
            lblCnpjInvalido.ForeColor = Color.Red;
            lblCnpjInvalido.Location = new Point(231, 145);
            lblCnpjInvalido.Name = "lblCnpjInvalido";
            lblCnpjInvalido.Size = new Size(82, 15);
            lblCnpjInvalido.TabIndex = 26;
            lblCnpjInvalido.Text = "CNPJ inválido!";
            lblCnpjInvalido.Visible = false;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(6, 161);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(118, 23);
            txtCEP.TabIndex = 3;
            txtCEP.Leave += txtCEP_Leave;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(275, 295);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(258, 23);
            txtEstado.TabIndex = 11;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(130, 161);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(183, 23);
            txtCNPJ.TabIndex = 4;
            txtCNPJ.KeyPress += txtCNPJ_KeyPress;
            txtCNPJ.Leave += txtCNPJ_Leave;
            // 
            // txtEndNumero
            // 
            txtEndNumero.Location = new Point(448, 207);
            txtEndNumero.Name = "txtEndNumero";
            txtEndNumero.Size = new Size(86, 23);
            txtEndNumero.TabIndex = 7;
            txtEndNumero.KeyPress += txtEndNumero_KeyPress;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(275, 251);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(258, 23);
            txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(6, 251);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(258, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(5, 345);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(528, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtFone
            // 
            txtFone.Location = new Point(6, 295);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(258, 23);
            txtFone.TabIndex = 10;
            txtFone.KeyPress += txtFone_KeyPress;
            // 
            // txtEnderecoFornecedor
            // 
            txtEnderecoFornecedor.Location = new Point(6, 207);
            txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            txtEnderecoFornecedor.Size = new Size(437, 23);
            txtEnderecoFornecedor.TabIndex = 6;
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.Location = new Point(319, 161);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(214, 23);
            txtInscricaoEstadual.TabIndex = 5;
            txtInscricaoEstadual.KeyPress += txtInscricaoEstadual_KeyPress;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(5, 119);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(529, 23);
            txtRazaoSocial.TabIndex = 2;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(4, 233);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 14;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(275, 233);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 13;
            lblBairro.Text = "Bairro";
            // 
            // lblEndNumero
            // 
            lblEndNumero.AutoSize = true;
            lblEndNumero.Location = new Point(448, 190);
            lblEndNumero.Name = "lblEndNumero";
            lblEndNumero.Size = new Size(51, 15);
            lblEndNumero.TabIndex = 12;
            lblEndNumero.Text = "Número";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 145);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 11;
            label8.Text = "CNPJ";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(276, 277);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 144);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 9;
            label13.Text = "CEP";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(5, 327);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.Location = new Point(5, 277);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(51, 15);
            lblFone.TabIndex = 7;
            lblFone.Text = "Telefone";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(6, 189);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(155, 15);
            lblEndereco.TabIndex = 6;
            lblEndereco.Text = "Endereço(Rua, Avenida, etc)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(319, 145);
            label17.Name = "label17";
            label17.Size = new Size(101, 15);
            label17.TabIndex = 5;
            label17.Text = "Inscrição estadual";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 101);
            label18.Name = "label18";
            label18.Size = new Size(175, 15);
            label18.TabIndex = 4;
            label18.Text = "Razão Social(nome da empresa)";
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Enabled = false;
            txtFornecedorID.Location = new Point(5, 31);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.Size = new Size(100, 23);
            txtFornecedorID.TabIndex = 3;
            // 
            // txtNomeFornecedor
            // 
            txtNomeFornecedor.Location = new Point(5, 75);
            txtNomeFornecedor.Name = "txtNomeFornecedor";
            txtNomeFornecedor.Size = new Size(530, 23);
            txtNomeFornecedor.TabIndex = 1;
            txtNomeFornecedor.KeyPress += txtNomeFornecedor_KeyPress;
            // 
            // lblFornecedorID
            // 
            lblFornecedorID.AutoSize = true;
            lblFornecedorID.Location = new Point(3, 13);
            lblFornecedorID.Name = "lblFornecedorID";
            lblFornecedorID.Size = new Size(81, 15);
            lblFornecedorID.TabIndex = 1;
            lblFornecedorID.Text = "Fornecedor ID";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(4, 57);
            label20.Name = "label20";
            label20.Size = new Size(120, 15);
            label20.TabIndex = 0;
            label20.Text = "Nome do Fornecedor";
            // 
            // formCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(panelDados);
            Controls.Add(panelBotoes);
            Name = "formCadastroFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Fornecedor";
            Load += formCadastroFornecedor_Load;
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
        private TextBox txtCEP;
        private TextBox txtEstado;
        private TextBox txtCNPJ;
        private TextBox txtEndNumero;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEmail;
        private TextBox txtFone;
        private TextBox txtEnderecoFornecedor;
        private TextBox txtInscricaoEstadual;
        private TextBox txtRazaoSocial;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblEndNumero;
        private Label label8;
        private Label lblEstado;
        private Label label13;
        private Label lblEmail;
        private Label lblFone;
        private Label lblEndereco;
        private Label label17;
        private Label label18;
        private TextBox txtFornecedorID;
        private TextBox txtNomeFornecedor;
        private Label lblFornecedorID;
        private Label label20;
        private Label lblCnpjInvalido;
    }
}