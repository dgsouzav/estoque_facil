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
            txtNome=new TextBox();
            txtID=new TextBox();
            lblNome=new Label();
            lblID=new Label();
            panelBotoes=new Panel();
            btnCancelar=new Button();
            btnInserir=new Button();
            btnLocalizar=new Button();
            btnSalvar=new Button();
            btnAlterar=new Button();
            btnExcluir=new Button();
            panelDados.SuspendLayout();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtNome);
            panelDados.Controls.Add(txtID);
            panelDados.Controls.Add(lblNome);
            panelDados.Controls.Add(lblID);
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(636, 537);
            panelDados.TabIndex=0;
            // 
            // txtNome
            // 
            txtNome.Location=new Point(3, 99);
            txtNome.Name="txtNome";
            txtNome.Size=new Size(630, 23);
            txtNome.TabIndex=3;
            // 
            // txtID
            // 
            txtID.Enabled=false;
            txtID.Location=new Point(3, 31);
            txtID.Name="txtID";
            txtID.Size=new Size(81, 23);
            txtID.TabIndex=2;
            // 
            // lblNome
            // 
            lblNome.AutoSize=true;
            lblNome.Location=new Point(3, 81);
            lblNome.Name="lblNome";
            lblNome.Size=new Size(43, 15);
            lblNome.TabIndex=1;
            lblNome.Text="Nome:";
            // 
            // lblID
            // 
            lblID.AutoSize=true;
            lblID.Location=new Point(3, 13);
            lblID.Name="lblID";
            lblID.Size=new Size(21, 15);
            lblID.TabIndex=0;
            lblID.Text="ID:";
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Controls.Add(btnExcluir);
            panelBotoes.Location=new Point(654, 12);
            panelBotoes.Name="panelBotoes";
            panelBotoes.Size=new Size(118, 537);
            panelBotoes.TabIndex=1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(19, 443);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 80);
            btnCancelar.TabIndex=11;
            btnCancelar.Text="CANCELAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(19, 13);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 80);
            btnInserir.TabIndex=6;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(19, 99);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 80);
            btnLocalizar.TabIndex=7;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(19, 357);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 80);
            btnSalvar.TabIndex=10;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(19, 185);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 80);
            btnAlterar.TabIndex=8;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(19, 271);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 80);
            btnExcluir.TabIndex=9;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // formCadastroCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(784, 561);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            Name="formCadastroCategoria";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro de Categoria";
            Load+=formCadastroCategoria_Load;
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
        private TextBox txtID;
        private Label lblNome;
        private Label lblID;
        private TextBox txtNome;
    }
}