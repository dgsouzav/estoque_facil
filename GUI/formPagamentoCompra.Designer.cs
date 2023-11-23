namespace UI
{
    partial class formPagamentoCompra
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
            btnLocalizarCompra=new Button();
            txtID=new TextBox();
            lblD=new Label();
            lblFornecedorNome=new Label();
            lblData=new Label();
            txtValor=new TextBox();
            lblValor=new Label();
            txtFornecedorNome=new TextBox();
            dtpData=new DateTimePicker();
            lblParcelas=new Label();
            dtgvParcelas=new DataGridView();
            btnPagar=new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelas).BeginInit();
            SuspendLayout();
            // 
            // btnLocalizarCompra
            // 
            btnLocalizarCompra.Location=new Point(567, 77);
            btnLocalizarCompra.Name="btnLocalizarCompra";
            btnLocalizarCompra.Size=new Size(205, 24);
            btnLocalizarCompra.TabIndex=0;
            btnLocalizarCompra.Text="Localizar compra";
            btnLocalizarCompra.UseVisualStyleBackColor=true;
            btnLocalizarCompra.Click+=btnLocalizarCompra_Click;
            // 
            // txtID
            // 
            txtID.Enabled=false;
            txtID.Location=new Point(12, 35);
            txtID.Name="txtID";
            txtID.Size=new Size(240, 23);
            txtID.TabIndex=1;
            // 
            // lblD
            // 
            lblD.AutoSize=true;
            lblD.Location=new Point(12, 17);
            lblD.Name="lblD";
            lblD.Size=new Size(18, 15);
            lblD.TabIndex=2;
            lblD.Text="ID";
            // 
            // lblFornecedorNome
            // 
            lblFornecedorNome.AutoSize=true;
            lblFornecedorNome.Location=new Point(258, 61);
            lblFornecedorNome.Name="lblFornecedorNome";
            lblFornecedorNome.Size=new Size(67, 15);
            lblFornecedorNome.TabIndex=4;
            lblFornecedorNome.Text="Fornecedor";
            // 
            // lblData
            // 
            lblData.AutoSize=true;
            lblData.Location=new Point(12, 61);
            lblData.Name="lblData";
            lblData.Size=new Size(31, 15);
            lblData.TabIndex=5;
            lblData.Text="Data";
            // 
            // txtValor
            // 
            txtValor.Enabled=false;
            txtValor.Location=new Point(258, 35);
            txtValor.Name="txtValor";
            txtValor.Size=new Size(100, 23);
            txtValor.TabIndex=7;
            // 
            // lblValor
            // 
            lblValor.AutoSize=true;
            lblValor.Location=new Point(258, 17);
            lblValor.Name="lblValor";
            lblValor.Size=new Size(33, 15);
            lblValor.TabIndex=8;
            lblValor.Text="Valor";
            // 
            // txtFornecedorNome
            // 
            txtFornecedorNome.Enabled=false;
            txtFornecedorNome.Location=new Point(258, 79);
            txtFornecedorNome.Name="txtFornecedorNome";
            txtFornecedorNome.Size=new Size(302, 23);
            txtFornecedorNome.TabIndex=9;
            // 
            // dtpData
            // 
            dtpData.Enabled=false;
            dtpData.Location=new Point(12, 79);
            dtpData.Name="dtpData";
            dtpData.Size=new Size(240, 23);
            dtpData.TabIndex=13;
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize=true;
            lblParcelas.Location=new Point(12, 122);
            lblParcelas.Name="lblParcelas";
            lblParcelas.Size=new Size(50, 15);
            lblParcelas.TabIndex=14;
            lblParcelas.Text="Parcelas";
            // 
            // dtgvParcelas
            // 
            dtgvParcelas.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParcelas.Location=new Point(12, 140);
            dtgvParcelas.Name="dtgvParcelas";
            dtgvParcelas.RowTemplate.Height=25;
            dtgvParcelas.Size=new Size(760, 260);
            dtgvParcelas.TabIndex=15;
            // 
            // btnPagar
            // 
            btnPagar.Enabled=false;
            btnPagar.Location=new Point(12, 406);
            btnPagar.Name="btnPagar";
            btnPagar.Size=new Size(760, 43);
            btnPagar.TabIndex=16;
            btnPagar.Text="Pagar parcela";
            btnPagar.UseVisualStyleBackColor=true;
            // 
            // formPagamentoCompra
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(784, 461);
            Controls.Add(btnPagar);
            Controls.Add(dtgvParcelas);
            Controls.Add(lblParcelas);
            Controls.Add(dtpData);
            Controls.Add(txtFornecedorNome);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblData);
            Controls.Add(lblFornecedorNome);
            Controls.Add(lblD);
            Controls.Add(txtID);
            Controls.Add(btnLocalizarCompra);
            Name="formPagamentoCompra";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Pagamento de Compras";
            ((System.ComponentModel.ISupportInitialize)dtgvParcelas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLocalizarCompra;
        private TextBox txtID;
        private Label lblD;
        private Label lblFornecedorNome;
        private Label lblData;
        private TextBox txtData;
        private TextBox txtValor;
        private Label lblValor;
        private TextBox txtFornecedorNome;
        private DataGridView dataGridView1;
        private Button button2;
        private DateTimePicker dtpData;
        private Label lblParcelas;
        private DataGridView dtgvParcelas;
        private Button btnPagar;
    }
}