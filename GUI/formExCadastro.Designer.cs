namespace UI
{
    partial class formExCadastro
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
            label1=new Label();
            label2=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            panelDados.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Controls.Add(textBox2);
            panelDados.Controls.Add(textBox1);
            panelDados.Controls.Add(label2);
            panelDados.Controls.Add(label1);
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(534, 437);
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
            panelButtons.Location=new Point(554, 12);
            panelButtons.Name="panelButtons";
            panelButtons.Size=new Size(118, 437);
            panelButtons.TabIndex=2;
            panelButtons.Paint+=panelButtons_Paint;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(18, 374);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 50);
            btnCancelar.TabIndex=5;
            btnCancelar.Text="CANCELAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(18, 14);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 50);
            btnInserir.TabIndex=0;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(18, 86);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 50);
            btnLocalizar.TabIndex=1;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(18, 302);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 50);
            btnSalvar.TabIndex=4;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(18, 158);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 50);
            btnAlterar.TabIndex=2;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(18, 230);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 50);
            btnExcluir.TabIndex=3;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(0, 32);
            label1.Name="label1";
            label1.Size=new Size(38, 15);
            label1.TabIndex=0;
            label1.Text="label1";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(3, 83);
            label2.Name="label2";
            label2.Size=new Size(38, 15);
            label2.TabIndex=1;
            label2.Text="label2";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(3, 101);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=2;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(3, 50);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(100, 23);
            textBox2.TabIndex=3;
            // 
            // formExCadastro
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 461);
            Controls.Add(panelButtons);
            Controls.Add(panelDados);
            Name="formExCadastro";
            StartPosition=FormStartPosition.CenterScreen;
            Text="ExCadastro";
            Load+=formCadastro_Load;
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
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
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}