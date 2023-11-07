namespace UI
{
    partial class formLogin
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
            lblLogin=new Label();
            lblSenha=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            lbEstoqueFacil=new Label();
            btnEntrar=new Button();
            btnCancelar=new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize=true;
            lblLogin.Location=new Point(63, 104);
            lblLogin.Name="lblLogin";
            lblLogin.Size=new Size(37, 15);
            lblLogin.TabIndex=0;
            lblLogin.Text="Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize=true;
            lblSenha.Location=new Point(63, 154);
            lblSenha.Name="lblSenha";
            lblSenha.Size=new Size(39, 15);
            lblSenha.TabIndex=1;
            lblSenha.Text="Senha";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(63, 122);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(216, 23);
            textBox1.TabIndex=2;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(63, 172);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(216, 23);
            textBox2.TabIndex=3;
            // 
            // lbEstoqueFacil
            // 
            lbEstoqueFacil.AutoSize=true;
            lbEstoqueFacil.Location=new Point(125, 42);
            lbEstoqueFacil.Name="lbEstoqueFacil";
            lbEstoqueFacil.Size=new Size(76, 15);
            lbEstoqueFacil.TabIndex=4;
            lbEstoqueFacil.Text="Estoque Fácil";
            // 
            // btnEntrar
            // 
            btnEntrar.Location=new Point(63, 219);
            btnEntrar.Name="btnEntrar";
            btnEntrar.Size=new Size(90, 23);
            btnEntrar.TabIndex=5;
            btnEntrar.Text="Entrar";
            btnEntrar.UseVisualStyleBackColor=true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(189, 219);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(90, 23);
            btnCancelar.TabIndex=6;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // formLogin
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(354, 331);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(lbEstoqueFacil);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Name="formLogin";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Estoque Fácil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblSenha;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbEstoqueFacil;
        private Button btnEntrar;
        private Button btnCancelar;
    }
}