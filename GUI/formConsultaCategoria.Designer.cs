namespace UI
{
    partial class formConsultaCategoria
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
            btnLocalizar=new Button();
            txtConsultaCategoria=new TextBox();
            lblCategoria=new Label();
            dtgvDados=new DataGridView();
            btnExcluir=new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(592, 61);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 60);
            btnLocalizar.TabIndex=2;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click_1;
            // 
            // txtConsultaCategoria
            // 
            txtConsultaCategoria.Location=new Point(12, 61);
            txtConsultaCategoria.Name="txtConsultaCategoria";
            txtConsultaCategoria.Size=new Size(561, 23);
            txtConsultaCategoria.TabIndex=1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize=true;
            lblCategoria.Location=new Point(12, 43);
            lblCategoria.Name="lblCategoria";
            lblCategoria.Size=new Size(58, 15);
            lblCategoria.TabIndex=2;
            lblCategoria.Text="Categoria";
            // 
            // dtgvDados
            // 
            dtgvDados.AllowUserToAddRows=false;
            dtgvDados.AllowUserToDeleteRows=false;
            dtgvDados.AllowUserToOrderColumns=true;
            dtgvDados.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDados.Location=new Point(12, 90);
            dtgvDados.Name="dtgvDados";
            dtgvDados.ReadOnly=true;
            dtgvDados.RowTemplate.Height=25;
            dtgvDados.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size=new Size(561, 316);
            dtgvDados.TabIndex=4;
            dtgvDados.CellDoubleClick+=dtgvDados_CellDoubleClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(592, 138);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 60);
            btnExcluir.TabIndex=3;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // formConsultaCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(btnExcluir);
            Controls.Add(dtgvDados);
            Controls.Add(lblCategoria);
            Controls.Add(txtConsultaCategoria);
            Controls.Add(btnLocalizar);
            Name="formConsultaCategoria";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Categoria";
            Load+=formConsultaCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLocalizar;
        private TextBox txtConsultaCategoria;
        private Label lblCategoria;
        private DataGridView dtgvDados;
        private Button btnExcluir;
    }
}