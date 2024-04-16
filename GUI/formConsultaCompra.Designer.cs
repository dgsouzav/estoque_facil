namespace UI
{
    partial class formConsultaCompra
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
            dtgvDadosCompra = new DataGridView();
            rbFornecedor = new RadioButton();
            rbData = new RadioButton();
            lblConsultarPelo = new Label();
            rbParcelas = new RadioButton();
            rbCompras = new RadioButton();
            panelRB = new Panel();
            panelFornecedor = new Panel();
            lblNomeFornecedor2 = new Label();
            btnLocalizarFornecedor = new Button();
            txtFornecedorID = new TextBox();
            lblFornecedorID = new Label();
            panelData = new Panel();
            lblDataFinal = new Label();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            lblDataInicial = new Label();
            btnData = new Button();
            tbcDados = new TabControl();
            tabPageCompra = new TabPage();
            tabPageItens = new TabPage();
            dtgvItensCompra = new DataGridView();
            tabPageParcelas = new TabPage();
            dtgvParcelasCompra = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvDadosCompra).BeginInit();
            panelRB.SuspendLayout();
            panelFornecedor.SuspendLayout();
            panelData.SuspendLayout();
            tbcDados.SuspendLayout();
            tabPageCompra.SuspendLayout();
            tabPageItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensCompra).BeginInit();
            tabPageParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasCompra).BeginInit();
            SuspendLayout();
            // 
            // dtgvDadosCompra
            // 
            dtgvDadosCompra.AllowUserToAddRows = false;
            dtgvDadosCompra.AllowUserToDeleteRows = false;
            dtgvDadosCompra.AllowUserToOrderColumns = true;
            dtgvDadosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDadosCompra.Location = new Point(6, 6);
            dtgvDadosCompra.Name = "dtgvDadosCompra";
            dtgvDadosCompra.ReadOnly = true;
            dtgvDadosCompra.RowTemplate.Height = 25;
            dtgvDadosCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDadosCompra.Size = new Size(643, 227);
            dtgvDadosCompra.TabIndex = 12;
            dtgvDadosCompra.CellClick += dtgvDadosCompra_CellClick;
            dtgvDadosCompra.CellDoubleClick += dtgvDadosCompra_CellDoubleClick;
            dtgvDadosCompra.CellFormatting += dtgvDadosCompra_CellFormatting;
            // 
            // rbFornecedor
            // 
            rbFornecedor.AutoSize = true;
            rbFornecedor.Location = new Point(3, 60);
            rbFornecedor.Name = "rbFornecedor";
            rbFornecedor.Size = new Size(85, 19);
            rbFornecedor.TabIndex = 14;
            rbFornecedor.Text = "Fornecedor";
            rbFornecedor.UseVisualStyleBackColor = true;
            rbFornecedor.CheckedChanged += rbCompras_CheckedChanged;
            // 
            // rbData
            // 
            rbData.AutoSize = true;
            rbData.Location = new Point(3, 85);
            rbData.Name = "rbData";
            rbData.Size = new Size(109, 19);
            rbData.TabIndex = 15;
            rbData.Text = "Data da compra";
            rbData.UseVisualStyleBackColor = true;
            rbData.CheckedChanged += rbCompras_CheckedChanged;
            // 
            // lblConsultarPelo
            // 
            lblConsultarPelo.AutoSize = true;
            lblConsultarPelo.Location = new Point(3, 14);
            lblConsultarPelo.Name = "lblConsultarPelo";
            lblConsultarPelo.Size = new Size(87, 15);
            lblConsultarPelo.TabIndex = 16;
            lblConsultarPelo.Text = "Consultar pelo:";
            // 
            // rbParcelas
            // 
            rbParcelas.AutoSize = true;
            rbParcelas.Location = new Point(3, 110);
            rbParcelas.Name = "rbParcelas";
            rbParcelas.Size = new Size(115, 19);
            rbParcelas.TabIndex = 17;
            rbParcelas.Text = "Parcelas a vencer";
            rbParcelas.UseVisualStyleBackColor = true;
            rbParcelas.CheckedChanged += rbCompras_CheckedChanged;
            // 
            // rbCompras
            // 
            rbCompras.AutoSize = true;
            rbCompras.Checked = true;
            rbCompras.Location = new Point(3, 35);
            rbCompras.Name = "rbCompras";
            rbCompras.Size = new Size(104, 19);
            rbCompras.TabIndex = 18;
            rbCompras.TabStop = true;
            rbCompras.Text = "Todas compras";
            rbCompras.UseVisualStyleBackColor = true;
            rbCompras.CheckedChanged += rbCompras_CheckedChanged;
            // 
            // panelRB
            // 
            panelRB.Controls.Add(lblConsultarPelo);
            panelRB.Controls.Add(rbCompras);
            panelRB.Controls.Add(rbFornecedor);
            panelRB.Controls.Add(rbParcelas);
            panelRB.Controls.Add(rbData);
            panelRB.Location = new Point(12, 1);
            panelRB.Name = "panelRB";
            panelRB.Size = new Size(120, 139);
            panelRB.TabIndex = 23;
            // 
            // panelFornecedor
            // 
            panelFornecedor.Controls.Add(lblNomeFornecedor2);
            panelFornecedor.Controls.Add(btnLocalizarFornecedor);
            panelFornecedor.Controls.Add(txtFornecedorID);
            panelFornecedor.Controls.Add(lblFornecedorID);
            panelFornecedor.Location = new Point(138, 9);
            panelFornecedor.Name = "panelFornecedor";
            panelFornecedor.Size = new Size(244, 96);
            panelFornecedor.TabIndex = 24;
            panelFornecedor.Visible = false;
            // 
            // lblNomeFornecedor2
            // 
            lblNomeFornecedor2.AutoSize = true;
            lblNomeFornecedor2.Location = new Point(3, 52);
            lblNomeFornecedor2.Name = "lblNomeFornecedor2";
            lblNomeFornecedor2.Size = new Size(123, 15);
            lblNomeFornecedor2.TabIndex = 4;
            lblNomeFornecedor2.Text = "Nome do Fornecedor:";
            // 
            // btnLocalizarFornecedor
            // 
            btnLocalizarFornecedor.Location = new Point(132, 26);
            btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            btnLocalizarFornecedor.Size = new Size(75, 23);
            btnLocalizarFornecedor.TabIndex = 2;
            btnLocalizarFornecedor.Text = "Localizar";
            btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            btnLocalizarFornecedor.Click += btnLocalizarFornecedor_Click;
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Enabled = false;
            txtFornecedorID.Location = new Point(3, 26);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.Size = new Size(123, 23);
            txtFornecedorID.TabIndex = 1;
            // 
            // lblFornecedorID
            // 
            lblFornecedorID.AutoSize = true;
            lblFornecedorID.Location = new Point(3, 8);
            lblFornecedorID.Name = "lblFornecedorID";
            lblFornecedorID.Size = new Size(98, 15);
            lblFornecedorID.TabIndex = 0;
            lblFornecedorID.Text = "ID do Fornecedor";
            // 
            // panelData
            // 
            panelData.Controls.Add(lblDataFinal);
            panelData.Controls.Add(dtpDataFinal);
            panelData.Controls.Add(dtpDataInicial);
            panelData.Controls.Add(lblDataInicial);
            panelData.Controls.Add(btnData);
            panelData.Location = new Point(388, 9);
            panelData.Name = "panelData";
            panelData.Size = new Size(284, 95);
            panelData.TabIndex = 25;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(6, 47);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(57, 15);
            lblDataFinal.TabIndex = 10;
            lblDataFinal.Text = "Data final";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(6, 65);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(200, 23);
            dtpDataFinal.TabIndex = 9;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(6, 21);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(200, 23);
            dtpDataInicial.TabIndex = 8;
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(3, 4);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(65, 15);
            lblDataInicial.TabIndex = 5;
            lblDataInicial.Text = "Data inicial";
            // 
            // btnData
            // 
            btnData.Location = new Point(206, 21);
            btnData.Name = "btnData";
            btnData.Size = new Size(75, 23);
            btnData.TabIndex = 7;
            btnData.Text = "Localizar";
            btnData.UseVisualStyleBackColor = true;
            btnData.Click += btnData_Click;
            // 
            // tbcDados
            // 
            tbcDados.Controls.Add(tabPageCompra);
            tbcDados.Controls.Add(tabPageItens);
            tbcDados.Controls.Add(tabPageParcelas);
            tbcDados.Location = new Point(12, 146);
            tbcDados.Name = "tbcDados";
            tbcDados.SelectedIndex = 0;
            tbcDados.Size = new Size(660, 267);
            tbcDados.TabIndex = 26;
            // 
            // tabPageCompra
            // 
            tabPageCompra.Controls.Add(dtgvDadosCompra);
            tabPageCompra.Location = new Point(4, 24);
            tabPageCompra.Name = "tabPageCompra";
            tabPageCompra.Padding = new Padding(3);
            tabPageCompra.Size = new Size(652, 239);
            tabPageCompra.TabIndex = 0;
            tabPageCompra.Text = "Compra";
            tabPageCompra.UseVisualStyleBackColor = true;
            // 
            // tabPageItens
            // 
            tabPageItens.Controls.Add(dtgvItensCompra);
            tabPageItens.Location = new Point(4, 24);
            tabPageItens.Name = "tabPageItens";
            tabPageItens.Padding = new Padding(3);
            tabPageItens.Size = new Size(652, 239);
            tabPageItens.TabIndex = 1;
            tabPageItens.Text = "Itens";
            tabPageItens.UseVisualStyleBackColor = true;
            // 
            // dtgvItensCompra
            // 
            dtgvItensCompra.AllowUserToAddRows = false;
            dtgvItensCompra.AllowUserToDeleteRows = false;
            dtgvItensCompra.AllowUserToOrderColumns = true;
            dtgvItensCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvItensCompra.Location = new Point(5, 6);
            dtgvItensCompra.Name = "dtgvItensCompra";
            dtgvItensCompra.ReadOnly = true;
            dtgvItensCompra.RowTemplate.Height = 25;
            dtgvItensCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvItensCompra.Size = new Size(643, 227);
            dtgvItensCompra.TabIndex = 13;
            // 
            // tabPageParcelas
            // 
            tabPageParcelas.Controls.Add(dtgvParcelasCompra);
            tabPageParcelas.Location = new Point(4, 24);
            tabPageParcelas.Name = "tabPageParcelas";
            tabPageParcelas.Padding = new Padding(3);
            tabPageParcelas.Size = new Size(652, 239);
            tabPageParcelas.TabIndex = 2;
            tabPageParcelas.Text = "Parcelas";
            tabPageParcelas.UseVisualStyleBackColor = true;
            // 
            // dtgvParcelasCompra
            // 
            dtgvParcelasCompra.AllowUserToAddRows = false;
            dtgvParcelasCompra.AllowUserToDeleteRows = false;
            dtgvParcelasCompra.AllowUserToOrderColumns = true;
            dtgvParcelasCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParcelasCompra.Location = new Point(5, 6);
            dtgvParcelasCompra.Name = "dtgvParcelasCompra";
            dtgvParcelasCompra.ReadOnly = true;
            dtgvParcelasCompra.RowTemplate.Height = 25;
            dtgvParcelasCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvParcelasCompra.Size = new Size(643, 227);
            dtgvParcelasCompra.TabIndex = 13;
            // 
            // formConsultaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(tbcDados);
            Controls.Add(panelData);
            Controls.Add(panelFornecedor);
            Controls.Add(panelRB);
            Name = "formConsultaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Compra";
            Load += formConsultaCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDadosCompra).EndInit();
            panelRB.ResumeLayout(false);
            panelRB.PerformLayout();
            panelFornecedor.ResumeLayout(false);
            panelFornecedor.PerformLayout();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            tbcDados.ResumeLayout(false);
            tabPageCompra.ResumeLayout(false);
            tabPageItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvItensCompra).EndInit();
            tabPageParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgvDadosCompra;
        private RadioButton rbFornecedor;
        private RadioButton rbData;
        private Label lblConsultarPelo;
        private RadioButton rbParcelas;
        private RadioButton rbCompras;
        private Panel panelRB;
        private Panel panelFornecedor;
        private Button btnLocalizarFornecedor;
        private TextBox txtFornecedorID;
        private Label lblFornecedorID;
        private Label lblNomeFornecedor2;
        private Panel panelData;
        private Label lblDataInicial;
        private Button btnData;
        private DateTimePicker dtpDataInicial;
        private DateTimePicker dtpDataFinal;
        private Label lblDataFinal;
        private TabControl tbcDados;
        private TabPage tabPageCompra;
        private TabPage tabPageItens;
        private TabPage tabPageParcelas;
        private DataGridView dtgvItensCompra;
        private DataGridView dtgvParcelasCompra;
    }
}