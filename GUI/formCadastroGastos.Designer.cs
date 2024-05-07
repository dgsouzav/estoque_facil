namespace UI
{
    partial class formCadastroGastos
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
            txtVendaID = new TextBox();
            lblVenda = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            lblDescricaoProduto = new Label();
            txtDescricao = new TextBox();
            txtNomeProduto = new TextBox();
            lblNome = new Label();
            panelBotoes = new Panel();
            btnLimpar = new Button();
            btnInserir = new Button();
            btnSalvar = new Button();
            panelDados.SuspendLayout();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtVendaID);
            panelDados.Controls.Add(lblVenda);
            panelDados.Controls.Add(txtValor);
            panelDados.Controls.Add(lblValor);
            panelDados.Controls.Add(lblDescricaoProduto);
            panelDados.Controls.Add(txtDescricao);
            panelDados.Controls.Add(txtNomeProduto);
            panelDados.Controls.Add(lblNome);
            panelDados.Location = new Point(12, 13);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(536, 393);
            panelDados.TabIndex = 4;
            // 
            // txtVendaID
            // 
            txtVendaID.Enabled = false;
            txtVendaID.Location = new Point(2, 36);
            txtVendaID.Name = "txtVendaID";
            txtVendaID.Size = new Size(101, 23);
            txtVendaID.TabIndex = 13;
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Location = new Point(3, 18);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(46, 15);
            lblVenda.TabIndex = 12;
            lblVenda.Text = "Código";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(3, 232);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(257, 23);
            txtValor.TabIndex = 7;
            txtValor.KeyPress += txtValor_KeyPress;
            txtValor.Leave += txtValor_Leave;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(3, 213);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Location = new Point(3, 120);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(61, 15);
            lblDescricaoProduto.TabIndex = 5;
            lblDescricaoProduto.Text = "Descrição ";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(3, 138);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(257, 60);
            txtDescricao.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(3, 86);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(257, 23);
            txtNomeProduto.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(3, 67);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome ";
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnLimpar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Location = new Point(554, 13);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(118, 393);
            panelBotoes.TabIndex = 5;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(18, 241);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(80, 60);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(18, 86);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 60);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(18, 165);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 60);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // formCadastroGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(panelDados);
            Controls.Add(panelBotoes);
            Name = "formCadastroGastos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCadastroGastos";
            Load += formCadastroGastos_Load;
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelDados;
        private TextBox txtValor;
        private Label lblValor;
        private Label lblDescricaoProduto;
        private TextBox txtDescricao;
        private TextBox txtNomeProduto;
        private Label lblNome;
        protected Panel panelBotoes;
        protected Button btnLimpar;
        protected Button btnInserir;
        protected Button btnSalvar;
        private TextBox txtVendaID;
        private Label lblVenda;
    }
}