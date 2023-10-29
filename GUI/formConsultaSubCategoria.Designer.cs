namespace UI
{
    partial class formConsultaSubCategoria
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
            dtgvDados=new DataGridView();
            lblSubCategoria=new Label();
            txtConsultaSubCategoria=new TextBox();
            btnLocalizar=new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
            // 
            // dtgvDados
            // 
            dtgvDados.AllowUserToAddRows=false;
            dtgvDados.AllowUserToDeleteRows=false;
            dtgvDados.AllowUserToOrderColumns=true;
            dtgvDados.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDados.Location=new Point(12, 101);
            dtgvDados.Name="dtgvDados";
            dtgvDados.ReadOnly=true;
            dtgvDados.RowTemplate.Height=25;
            dtgvDados.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size=new Size(660, 348);
            dtgvDados.TabIndex=7;
            dtgvDados.CellDoubleClick+=dtgvDados_CellDoubleClick;
            // 
            // lblSubCategoria
            // 
            lblSubCategoria.AutoSize=true;
            lblSubCategoria.Location=new Point(12, 43);
            lblSubCategoria.Name="lblSubCategoria";
            lblSubCategoria.Size=new Size(78, 15);
            lblSubCategoria.TabIndex=6;
            lblSubCategoria.Text="SubCategoria";
            // 
            // txtConsultaSubCategoria
            // 
            txtConsultaSubCategoria.Location=new Point(12, 61);
            txtConsultaSubCategoria.Name="txtConsultaSubCategoria";
            txtConsultaSubCategoria.Size=new Size(540, 23);
            txtConsultaSubCategoria.TabIndex=5;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(558, 60);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(114, 23);
            btnLocalizar.TabIndex=4;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // formConsultaSubCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 461);
            Controls.Add(dtgvDados);
            Controls.Add(lblSubCategoria);
            Controls.Add(txtConsultaSubCategoria);
            Controls.Add(btnLocalizar);
            Name="formConsultaSubCategoria";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Sub Categoria";
            Load+=formConsultaSubCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvDados;
        private Label lblSubCategoria;
        private TextBox txtConsultaSubCategoria;
        private Button btnLocalizar;
    }
}