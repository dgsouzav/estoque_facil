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
            txtConsultaFornecedor=new TextBox();
            btnLocalizar=new Button();
            grbConsultarNomeCnpj=new GroupBox();
            rbCnpj=new RadioButton();
            rbNome=new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            grbConsultarNomeCnpj.SuspendLayout();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(592, 104);
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
            dtgvDados.Location=new Point(12, 70);
            dtgvDados.Name="dtgvDados";
            dtgvDados.ReadOnly=true;
            dtgvDados.RowTemplate.Height=25;
            dtgvDados.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size=new Size(561, 329);
            dtgvDados.TabIndex=8;
            dtgvDados.CellDoubleClick+=dtgvDados_CellDoubleClick;
            // 
            // txtConsultaFornecedor
            // 
            txtConsultaFornecedor.Location=new Point(213, 28);
            txtConsultaFornecedor.Name="txtConsultaFornecedor";
            txtConsultaFornecedor.Size=new Size(360, 23);
            txtConsultaFornecedor.TabIndex=6;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(592, 28);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 60);
            btnLocalizar.TabIndex=5;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // grbConsultarNomeCnpj
            // 
            grbConsultarNomeCnpj.Controls.Add(rbCnpj);
            grbConsultarNomeCnpj.Controls.Add(rbNome);
            grbConsultarNomeCnpj.Location=new Point(12, 12);
            grbConsultarNomeCnpj.Name="grbConsultarNomeCnpj";
            grbConsultarNomeCnpj.Size=new Size(198, 52);
            grbConsultarNomeCnpj.TabIndex=10;
            grbConsultarNomeCnpj.TabStop=false;
            grbConsultarNomeCnpj.Text="Escolha um tipo de consulta:";
            // 
            // rbCnpj
            // 
            rbCnpj.AutoSize=true;
            rbCnpj.Checked=true;
            rbCnpj.Location=new Point(98, 20);
            rbCnpj.Name="rbCnpj";
            rbCnpj.Size=new Size(52, 19);
            rbCnpj.TabIndex=1;
            rbCnpj.TabStop=true;
            rbCnpj.Text="CNPJ";
            rbCnpj.UseVisualStyleBackColor=true;
            // 
            // rbNome
            // 
            rbNome.AutoSize=true;
            rbNome.Location=new Point(6, 20);
            rbNome.Name="rbNome";
            rbNome.Size=new Size(58, 19);
            rbNome.TabIndex=0;
            rbNome.Text="Nome";
            rbNome.UseVisualStyleBackColor=true;
            // 
            // formConsultaFornecedor
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(grbConsultarNomeCnpj);
            Controls.Add(btnExcluir);
            Controls.Add(dtgvDados);
            Controls.Add(txtConsultaFornecedor);
            Controls.Add(btnLocalizar);
            Name="formConsultaFornecedor";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Fornecedor";
            Load+=formConsultaFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            grbConsultarNomeCnpj.ResumeLayout(false);
            grbConsultarNomeCnpj.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private DataGridView dtgvDados;
        private TextBox txtConsultaFornecedor;
        private Button btnLocalizar;
        private GroupBox grbConsultarNomeCnpj;
        private RadioButton rbCnpj;
        private RadioButton rbNome;
    }
}