﻿namespace UI
{
    partial class formConsultaUsuario
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
            btnExcluir = new Button();
            dtgvDados = new DataGridView();
            lblUsuario = new Label();
            txtConsultaUsuario = new TextBox();
            btnLocalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(592, 123);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 60);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "INATIVAR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtgvDados
            // 
            dtgvDados.AllowUserToAddRows = false;
            dtgvDados.AllowUserToDeleteRows = false;
            dtgvDados.AllowUserToOrderColumns = true;
            dtgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDados.Location = new Point(12, 75);
            dtgvDados.Name = "dtgvDados";
            dtgvDados.ReadOnly = true;
            dtgvDados.RowTemplate.Height = 25;
            dtgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size = new Size(561, 316);
            dtgvDados.TabIndex = 9;
            dtgvDados.CellDoubleClick += dtgvDados_CellDoubleClick;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 28);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuário";
            // 
            // txtConsultaUsuario
            // 
            txtConsultaUsuario.Location = new Point(12, 46);
            txtConsultaUsuario.Name = "txtConsultaUsuario";
            txtConsultaUsuario.Size = new Size(561, 23);
            txtConsultaUsuario.TabIndex = 5;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(592, 46);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(80, 60);
            btnLocalizar.TabIndex = 7;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // formConsultaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(btnExcluir);
            Controls.Add(dtgvDados);
            Controls.Add(lblUsuario);
            Controls.Add(txtConsultaUsuario);
            Controls.Add(btnLocalizar);
            Name = "formConsultaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Usuário";
            Load += formConsultaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private DataGridView dtgvDados;
        private Label lblUsuario;
        private TextBox txtConsultaUsuario;
        private Button btnLocalizar;
    }
}