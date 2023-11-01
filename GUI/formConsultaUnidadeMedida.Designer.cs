namespace UI
{
    partial class formConsultaUnidadeMedida
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
            lblNomeUnidadeMedida=new Label();
            txtConsultaUnidadeMedida=new TextBox();
            btnLocalizar=new Button();
            btnExcluir=new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
            // 
            // dtgvDados
            // 
            dtgvDados.AllowUserToAddRows=false;
            dtgvDados.AllowUserToDeleteRows=false;
            dtgvDados.AllowUserToOrderColumns=true;
            dtgvDados.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDados.Location=new Point(12, 89);
            dtgvDados.Name="dtgvDados";
            dtgvDados.ReadOnly=true;
            dtgvDados.RowTemplate.Height=25;
            dtgvDados.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size=new Size(561, 317);
            dtgvDados.TabIndex=11;
            dtgvDados.CellDoubleClick+=dtgvDados_CellDoubleClick;
            // 
            // lblNomeUnidadeMedida
            // 
            lblNomeUnidadeMedida.AutoSize=true;
            lblNomeUnidadeMedida.Location=new Point(12, 31);
            lblNomeUnidadeMedida.Name="lblNomeUnidadeMedida";
            lblNomeUnidadeMedida.Size=new Size(162, 15);
            lblNomeUnidadeMedida.TabIndex=10;
            lblNomeUnidadeMedida.Text="Nome da Unidade de Medida";
            // 
            // txtConsultaUnidadeMedida
            // 
            txtConsultaUnidadeMedida.Location=new Point(12, 49);
            txtConsultaUnidadeMedida.Name="txtConsultaUnidadeMedida";
            txtConsultaUnidadeMedida.Size=new Size(561, 23);
            txtConsultaUnidadeMedida.TabIndex=9;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(592, 49);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(80, 60);
            btnLocalizar.TabIndex=8;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location=new Point(592, 124);
            btnExcluir.Name="btnExcluir";
            btnExcluir.Size=new Size(80, 60);
            btnExcluir.TabIndex=12;
            btnExcluir.Text="EXCLUIR";
            btnExcluir.UseVisualStyleBackColor=true;
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // formConsultaUnidadeMedida
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(btnExcluir);
            Controls.Add(dtgvDados);
            Controls.Add(lblNomeUnidadeMedida);
            Controls.Add(txtConsultaUnidadeMedida);
            Controls.Add(btnLocalizar);
            Name="formConsultaUnidadeMedida";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Unidade de Medida";
            Load+=formConsultaUnidadeMedida_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvDados;
        private Label lblNomeUnidadeMedida;
        private TextBox txtConsultaUnidadeMedida;
        private Button btnLocalizar;
        private Button btnExcluir;
    }
}