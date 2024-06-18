namespace UI
{
    partial class formConsultaCliente
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
            txtConsultaFornecedor = new TextBox();
            btnLocalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(677, 126);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(91, 76);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtgvDados
            // 
            dtgvDados.AllowUserToAddRows = false;
            dtgvDados.AllowUserToDeleteRows = false;
            dtgvDados.AllowUserToOrderColumns = true;
            dtgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDados.Location = new Point(14, 83);
            dtgvDados.Margin = new Padding(3, 4, 3, 4);
            dtgvDados.Name = "dtgvDados";
            dtgvDados.ReadOnly = true;
            dtgvDados.RowHeadersWidth = 47;
            dtgvDados.RowTemplate.Height = 25;
            dtgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size = new Size(641, 417);
            dtgvDados.TabIndex = 12;
            dtgvDados.CellDoubleClick += dtgvDados_CellDoubleClick;
            // 
            // txtConsultaFornecedor
            // 
            txtConsultaFornecedor.Location = new Point(15, 40);
            txtConsultaFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtConsultaFornecedor.Name = "txtConsultaFornecedor";
            txtConsultaFornecedor.Size = new Size(640, 26);
            txtConsultaFornecedor.TabIndex = 11;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(677, 29);
            btnLocalizar.Margin = new Padding(3, 4, 3, 4);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(91, 76);
            btnLocalizar.TabIndex = 10;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // formConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 529);
            Controls.Add(btnExcluir);
            Controls.Add(dtgvDados);
            Controls.Add(txtConsultaFornecedor);
            Controls.Add(btnLocalizar);
            Name = "formConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Cliente";
            Load += formConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private DataGridView dtgvDados;
        private TextBox txtConsultaFornecedor;
        private Button btnLocalizar;
    }
}