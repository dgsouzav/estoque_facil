namespace UI
{
    partial class formCadastro
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
            panelButtons=new Panel();
            btnCancelar=new Button();
            btnInserir=new Button();
            btnLocalizar=new Button();
            btnSalvar=new Button();
            btnAlterar=new Button();
            btnExcluir=new Button();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(636, 537);
            panelDados.TabIndex=1;
            panelDados.Paint+=panelDados_Paint;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnCancelar);
            panelButtons.Controls.Add(btnInserir);
            panelButtons.Controls.Add(btnLocalizar);
            panelButtons.Controls.Add(btnSalvar);
            panelButtons.Controls.Add(btnAlterar);
            panelButtons.Controls.Add(btnExcluir);
            panelButtons.Location=new Point(654, 12);
            panelButtons.Name="panelButtons";
            panelButtons.Size=new Size(118, 537);
            panelButtons.TabIndex=2;
            panelButtons.Paint+=panelButtons_Paint;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(18, 444);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 80);
            btnCancelar.TabIndex=5;
            btnCancelar.Text="CANCELAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(18, 14);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 80);
            btnInserir.TabIndex=0;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(18, 100);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 80);
            btnLocalizar.TabIndex=1;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(18, 358);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 80);
            btnSalvar.TabIndex=4;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(18, 186);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 80);
            btnAlterar.TabIndex=2;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(18, 272);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 80);
            btnExcluir.TabIndex=3;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // formCadastro
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(784, 561);
            Controls.Add(panelButtons);
            Controls.Add(panelDados);
            Name="formCadastro";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro";
            Load+=formCadastro_Load;
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelDados;
        protected Panel panelButtons;
        protected Button btnInserir;
        protected Button btnExcluir;
        protected Button btnAlterar;
        protected Button btnLocalizar;
        protected Button btnCancelar;
        protected Button btnSalvar;
    }
}