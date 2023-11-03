namespace UI
{
    partial class formCadastroTipoPagamento
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
            txtTipoPagamentoID=new TextBox();
            txtNomeTipoPagamento=new TextBox();
            lblTipoPagamentoID=new Label();
            lblNomeTipoPagamento=new Label();
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
            btnCancelar.TabIndex=11;
            btnCancelar.Text="LIMPAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(18, 10);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 60);
            btnInserir.TabIndex=6;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(18, 86);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 60);
            btnLocalizar.TabIndex=7;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(18, 246);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 60);
            btnSalvar.TabIndex=10;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(18, 162);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 60);
            btnAlterar.TabIndex=8;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtTipoPagamentoID);
            panelDados.Controls.Add(txtNomeTipoPagamento);
            panelDados.Controls.Add(lblTipoPagamentoID);
            panelDados.Controls.Add(lblNomeTipoPagamento);
            panelDados.Location=new Point(12, 13);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(536, 393);
            panelDados.TabIndex=2;
            // 
            // txtTipoPagamentoID
            // 
            txtTipoPagamentoID.Enabled=false;
            txtTipoPagamentoID.Location=new Point(3, 31);
            txtTipoPagamentoID.Name="txtTipoPagamentoID";
            txtTipoPagamentoID.Size=new Size(100, 23);
            txtTipoPagamentoID.TabIndex=3;
            // 
            // txtNomeTipoPagamento
            // 
            txtNomeTipoPagamento.Location=new Point(3, 95);
            txtNomeTipoPagamento.Name="txtNomeTipoPagamento";
            txtNomeTipoPagamento.Size=new Size(530, 23);
            txtNomeTipoPagamento.TabIndex=2;
            // 
            // lblTipoPagamentoID
            // 
            lblTipoPagamentoID.AutoSize=true;
            lblTipoPagamentoID.Location=new Point(3, 13);
            lblTipoPagamentoID.Name="lblTipoPagamentoID";
            lblTipoPagamentoID.Size=new Size(124, 15);
            lblTipoPagamentoID.TabIndex=1;
            lblTipoPagamentoID.Text="Tipo de Pagamento ID";
            // 
            // lblNomeTipoPagamento
            // 
            lblNomeTipoPagamento.AutoSize=true;
            lblNomeTipoPagamento.Location=new Point(3, 77);
            lblNomeTipoPagamento.Name="lblNomeTipoPagamento";
            lblNomeTipoPagamento.Size=new Size(163, 15);
            lblNomeTipoPagamento.TabIndex=0;
            lblNomeTipoPagamento.Text="Nome do Tipo de Pagamento";
            // 
            // formCadastroTipoPagamento
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name="formCadastroTipoPagamento";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro Tipo de Pagamento";
            Load+=formCadastroTipoPagamento_Load;
            KeyDown+=formCadastroTipoPagamento_KeyDown;
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
        private TextBox txtTipoPagamentoID;
        private TextBox txtNomeTipoPagamento;
        private Label lblTipoPagamentoID;
        private Label lblNomeTipoPagamento;
    }
}