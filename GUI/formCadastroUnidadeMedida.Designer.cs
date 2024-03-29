﻿namespace UI
{
    partial class formCadastroUnidadeMedida
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
            txtNomeUnidadeMedida=new TextBox();
            txtUnidadeMedidaID=new TextBox();
            lblNomeUnidadeMedida=new Label();
            lblUnidadeMedidaID=new Label();
            panelBotoes=new Panel();
            btnCancelar=new Button();
            btnInserir=new Button();
            btnLocalizar=new Button();
            btnSalvar=new Button();
            btnAlterar=new Button();
            panelDados.SuspendLayout();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelDados
            // 
            panelDados.Controls.Add(txtNomeUnidadeMedida);
            panelDados.Controls.Add(txtUnidadeMedidaID);
            panelDados.Controls.Add(lblNomeUnidadeMedida);
            panelDados.Controls.Add(lblUnidadeMedidaID);
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(536, 394);
            panelDados.TabIndex=2;
            // 
            // txtNomeUnidadeMedida
            // 
            txtNomeUnidadeMedida.Location=new Point(3, 99);
            txtNomeUnidadeMedida.Name="txtNomeUnidadeMedida";
            txtNomeUnidadeMedida.Size=new Size(530, 23);
            txtNomeUnidadeMedida.TabIndex=1;
            txtNomeUnidadeMedida.Leave+=txtNomeUnidadeMedida_Leave;
            // 
            // txtUnidadeMedidaID
            // 
            txtUnidadeMedidaID.Enabled=false;
            txtUnidadeMedidaID.Location=new Point(3, 46);
            txtUnidadeMedidaID.Name="txtUnidadeMedidaID";
            txtUnidadeMedidaID.Size=new Size(81, 23);
            txtUnidadeMedidaID.TabIndex=2;
            // 
            // lblNomeUnidadeMedida
            // 
            lblNomeUnidadeMedida.AutoSize=true;
            lblNomeUnidadeMedida.Location=new Point(3, 81);
            lblNomeUnidadeMedida.Name="lblNomeUnidadeMedida";
            lblNomeUnidadeMedida.Size=new Size(162, 15);
            lblNomeUnidadeMedida.TabIndex=1;
            lblNomeUnidadeMedida.Text="Nome da Unidade de Medida";
            // 
            // lblUnidadeMedidaID
            // 
            lblUnidadeMedidaID.AutoSize=true;
            lblUnidadeMedidaID.Location=new Point(3, 28);
            lblUnidadeMedidaID.Name="lblUnidadeMedidaID";
            lblUnidadeMedidaID.Size=new Size(140, 15);
            lblUnidadeMedidaID.TabIndex=0;
            lblUnidadeMedidaID.Text="ID da Unidade de Medida";
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnCancelar);
            panelBotoes.Controls.Add(btnInserir);
            panelBotoes.Controls.Add(btnLocalizar);
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnAlterar);
            panelBotoes.Location=new Point(554, 12);
            panelBotoes.Name="panelBotoes";
            panelBotoes.Size=new Size(118, 394);
            panelBotoes.TabIndex=3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(20, 316);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 50);
            btnCancelar.TabIndex=6;
            btnCancelar.Text="LIMPAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(20, 19);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 50);
            btnInserir.TabIndex=2;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(20, 95);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 50);
            btnLocalizar.TabIndex=3;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(20, 244);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 50);
            btnSalvar.TabIndex=5;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(20, 171);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 50);
            btnAlterar.TabIndex=4;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // formCadastroUnidadeMedida
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(panelDados);
            Controls.Add(panelBotoes);
            KeyPreview=true;
            Name="formCadastroUnidadeMedida";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro de Unidade de Medida";
            Load+=formCadastroUnidadeMedida_Load;
            KeyDown+=formCadastroUnidadeMedida_KeyDown;
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelDados;
        private TextBox txtNomeUnidadeMedida;
        private TextBox txtUnidadeMedidaID;
        private Label lblNomeUnidadeMedida;
        private Label lblUnidadeMedidaID;
        protected Panel panelBotoes;
        protected Button btnCancelar;
        protected Button btnInserir;
        protected Button btnLocalizar;
        protected Button btnSalvar;
        protected Button btnAlterar;
    }
}