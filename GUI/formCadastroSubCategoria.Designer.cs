﻿namespace UI
{
    partial class formCadastroSubCategoria
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
            cmbCategoriaID=new ComboBox();
            lblCategoriaNome=new Label();
            txtNomeSubCategoria=new TextBox();
            txtSubCategoriaID=new TextBox();
            lblNomeSubCategoria=new Label();
            lblSubCategoriaID=new Label();
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
            panelBotoes.Location=new Point(554, 12);
            panelBotoes.Name="panelBotoes";
            panelBotoes.Size=new Size(118, 394);
            panelBotoes.TabIndex=3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(19, 332);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(80, 50);
            btnCancelar.TabIndex=7;
            btnCancelar.Text="LIMPAR";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location=new Point(19, 13);
            btnInserir.Name="btnInserir";
            btnInserir.Size=new Size(80, 50);
            btnInserir.TabIndex=3;
            btnInserir.Text="INSERIR";
            btnInserir.UseVisualStyleBackColor=true;
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(19, 98);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 50);
            btnLocalizar.TabIndex=4;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(19, 253);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(80, 50);
            btnSalvar.TabIndex=6;
            btnSalvar.Text="SALVAR";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location=new Point(19, 176);
            btnAlterar.Name="btnAlterar";
            btnAlterar.Size=new Size(80, 50);
            btnAlterar.TabIndex=5;
            btnAlterar.Text="ALTERAR";
            btnAlterar.UseVisualStyleBackColor=true;
            btnAlterar.Click+=btnAlterar_Click;
            // 
            // panelDados
            // 
            panelDados.Controls.Add(cmbCategoriaID);
            panelDados.Controls.Add(lblCategoriaNome);
            panelDados.Controls.Add(txtNomeSubCategoria);
            panelDados.Controls.Add(txtSubCategoriaID);
            panelDados.Controls.Add(lblNomeSubCategoria);
            panelDados.Controls.Add(lblSubCategoriaID);
            panelDados.Location=new Point(12, 12);
            panelDados.Name="panelDados";
            panelDados.Size=new Size(536, 394);
            panelDados.TabIndex=2;
            // 
            // cmbCategoriaID
            // 
            cmbCategoriaID.AutoCompleteMode=AutoCompleteMode.Suggest;
            cmbCategoriaID.AutoCompleteSource=AutoCompleteSource.ListItems;
            cmbCategoriaID.FormattingEnabled=true;
            cmbCategoriaID.Location=new Point(3, 160);
            cmbCategoriaID.Name="cmbCategoriaID";
            cmbCategoriaID.Size=new Size(232, 23);
            cmbCategoriaID.TabIndex=2;
            // 
            // lblCategoriaNome
            // 
            lblCategoriaNome.AutoSize=true;
            lblCategoriaNome.Location=new Point(4, 142);
            lblCategoriaNome.Name="lblCategoriaNome";
            lblCategoriaNome.Size=new Size(110, 15);
            lblCategoriaNome.TabIndex=0;
            lblCategoriaNome.Text="Nome da Categoria";
            // 
            // txtNomeSubCategoria
            // 
            txtNomeSubCategoria.Location=new Point(3, 98);
            txtNomeSubCategoria.Name="txtNomeSubCategoria";
            txtNomeSubCategoria.Size=new Size(515, 23);
            txtNomeSubCategoria.TabIndex=1;
            // 
            // txtSubCategoriaID
            // 
            txtSubCategoriaID.Enabled=false;
            txtSubCategoriaID.Location=new Point(3, 40);
            txtSubCategoriaID.Name="txtSubCategoriaID";
            txtSubCategoriaID.Size=new Size(81, 23);
            txtSubCategoriaID.TabIndex=2;
            // 
            // lblNomeSubCategoria
            // 
            lblNomeSubCategoria.AutoSize=true;
            lblNomeSubCategoria.Location=new Point(3, 80);
            lblNomeSubCategoria.Name="lblNomeSubCategoria";
            lblNomeSubCategoria.Size=new Size(133, 15);
            lblNomeSubCategoria.TabIndex=1;
            lblNomeSubCategoria.Text="Nome da Sub Categoria";
            // 
            // lblSubCategoriaID
            // 
            lblSubCategoriaID.AutoSize=true;
            lblSubCategoriaID.Location=new Point(3, 22);
            lblSubCategoriaID.Name="lblSubCategoriaID";
            lblSubCategoriaID.Size=new Size(111, 15);
            lblSubCategoriaID.TabIndex=0;
            lblSubCategoriaID.Text="ID da Sub Categoria";
            // 
            // formCadastroSubCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(panelBotoes);
            Controls.Add(panelDados);
            KeyPreview=true;
            Name="formCadastroSubCategoria";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro de Sub Categoria";
            Load+=formCadastroSubCategoria_Load;
            KeyDown+=formCadastroSubCategoria_KeyDown;
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
        private Label lblCategoriaNome;
        private TextBox txtNomeSubCategoria;
        private TextBox txtSubCategoriaID;
        private Label lblNomeSubCategoria;
        private Label lblSubCategoriaID;
        private ComboBox cmbCategoriaID;
    }
}