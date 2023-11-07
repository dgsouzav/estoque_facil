namespace UI
{
    partial class formConsultaFornecedor
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
            btnExcluir=new Button();
            dtgvDados=new DataGridView();
            lblFornecedor=new Label();
            txtConsultaFornecedor=new TextBox();
            btnLocalizar=new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(592, 131);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 60);
            btnExcluir.TabIndex=9;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // dtgvDados
            // 
            dtgvDados.AllowUserToAddRows=false;
            dtgvDados.AllowUserToDeleteRows=false;
            dtgvDados.AllowUserToOrderColumns=true;
            dtgvDados.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDados.Location=new Point(12, 83);
            dtgvDados.Name="dtgvDados";
            dtgvDados.ReadOnly=true;
            dtgvDados.RowTemplate.Height=25;
            dtgvDados.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size=new Size(561, 316);
            dtgvDados.TabIndex=8;
            dtgvDados.CellDoubleClick+=dtgvDados_CellDoubleClick;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize=true;
            lblFornecedor.Location=new Point(12, 36);
            lblFornecedor.Name="lblFornecedor";
            lblFornecedor.Size=new Size(67, 15);
            lblFornecedor.TabIndex=7;
            lblFornecedor.Text="Fornecedor";
            // 
            // txtConsultaFornecedor
            // 
            txtConsultaFornecedor.Location=new Point(12, 54);
            txtConsultaFornecedor.Name="txtConsultaFornecedor";
            txtConsultaFornecedor.Size=new Size(561, 23);
            txtConsultaFornecedor.TabIndex=6;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(592, 54);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 60);
            btnLocalizar.TabIndex=5;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // formConsultaFornecedor
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(btnExcluir);
            Controls.Add(dtgvDados);
            Controls.Add(lblFornecedor);
            Controls.Add(txtConsultaFornecedor);
            Controls.Add(btnLocalizar);
            Name="formConsultaFornecedor";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Fornecedor";
            Load+=formConsultaFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private DataGridView dtgvDados;
        private Label lblFornecedor;
        private TextBox txtConsultaFornecedor;
        private Button btnLocalizar;
    }
}