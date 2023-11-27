namespace UI
{
    partial class formConsultaVenda
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
            tbcDados=new TabControl();
            tabPageVenda=new TabPage();
            dtgvDadosVenda=new DataGridView();
            tabPageItens=new TabPage();
            dtgvItensVenda=new DataGridView();
            tabPageParcelas=new TabPage();
            dtgvParcelasVenda=new DataGridView();
            panelData=new Panel();
            lblDataFinal=new Label();
            dtpDataFinal=new DateTimePicker();
            dtpDataInicial=new DateTimePicker();
            lblDataInicial=new Label();
            btnData=new Button();
            panelRB=new Panel();
            lblConsultarPelo=new Label();
            rbVendas=new RadioButton();
            rbParcelas=new RadioButton();
            rbData=new RadioButton();
            tbcDados.SuspendLayout();
            tabPageVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDadosVenda).BeginInit();
            tabPageItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvItensVenda).BeginInit();
            tabPageParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasVenda).BeginInit();
            panelData.SuspendLayout();
            panelRB.SuspendLayout();
            SuspendLayout();
            // 
            // tbcDados
            // 
            tbcDados.Controls.Add(tabPageVenda);
            tbcDados.Controls.Add(tabPageItens);
            tbcDados.Controls.Add(tabPageParcelas);
            tbcDados.Location=new Point(12, 116);
            tbcDados.Name="tbcDados";
            tbcDados.SelectedIndex=0;
            tbcDados.Size=new Size(660, 299);
            tbcDados.TabIndex=30;
            // 
            // tabPageVenda
            // 
            tabPageVenda.Controls.Add(dtgvDadosVenda);
            tabPageVenda.Location=new Point(4, 24);
            tabPageVenda.Name="tabPageVenda";
            tabPageVenda.Padding=new Padding(3);
            tabPageVenda.Size=new Size(652, 271);
            tabPageVenda.TabIndex=0;
            tabPageVenda.Text="Venda";
            tabPageVenda.UseVisualStyleBackColor=true;
            // 
            // dtgvDadosVenda
            // 
            dtgvDadosVenda.AllowUserToAddRows=false;
            dtgvDadosVenda.AllowUserToDeleteRows=false;
            dtgvDadosVenda.AllowUserToOrderColumns=true;
            dtgvDadosVenda.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDadosVenda.Location=new Point(6, 6);
            dtgvDadosVenda.Name="dtgvDadosVenda";
            dtgvDadosVenda.ReadOnly=true;
            dtgvDadosVenda.RowTemplate.Height=25;
            dtgvDadosVenda.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvDadosVenda.Size=new Size(643, 259);
            dtgvDadosVenda.TabIndex=12;
            dtgvDadosVenda.CellClick+=dtgvDadosVenda_CellClick;
            dtgvDadosVenda.CellDoubleClick+=dtgvDadosVenda_CellDoubleClick;
            // 
            // tabPageItens
            // 
            tabPageItens.Controls.Add(dtgvItensVenda);
            tabPageItens.Location=new Point(4, 24);
            tabPageItens.Name="tabPageItens";
            tabPageItens.Padding=new Padding(3);
            tabPageItens.Size=new Size(652, 271);
            tabPageItens.TabIndex=1;
            tabPageItens.Text="Itens";
            tabPageItens.UseVisualStyleBackColor=true;
            // 
            // dtgvItensVenda
            // 
            dtgvItensVenda.AllowUserToAddRows=false;
            dtgvItensVenda.AllowUserToDeleteRows=false;
            dtgvItensVenda.AllowUserToOrderColumns=true;
            dtgvItensVenda.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvItensVenda.Location=new Point(5, 6);
            dtgvItensVenda.Name="dtgvItensVenda";
            dtgvItensVenda.ReadOnly=true;
            dtgvItensVenda.RowTemplate.Height=25;
            dtgvItensVenda.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvItensVenda.Size=new Size(643, 259);
            dtgvItensVenda.TabIndex=13;
            // 
            // tabPageParcelas
            // 
            tabPageParcelas.Controls.Add(dtgvParcelasVenda);
            tabPageParcelas.Location=new Point(4, 24);
            tabPageParcelas.Name="tabPageParcelas";
            tabPageParcelas.Padding=new Padding(3);
            tabPageParcelas.Size=new Size(652, 271);
            tabPageParcelas.TabIndex=2;
            tabPageParcelas.Text="Parcelas";
            tabPageParcelas.UseVisualStyleBackColor=true;
            // 
            // dtgvParcelasVenda
            // 
            dtgvParcelasVenda.AllowUserToAddRows=false;
            dtgvParcelasVenda.AllowUserToDeleteRows=false;
            dtgvParcelasVenda.AllowUserToOrderColumns=true;
            dtgvParcelasVenda.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParcelasVenda.Location=new Point(5, 6);
            dtgvParcelasVenda.Name="dtgvParcelasVenda";
            dtgvParcelasVenda.ReadOnly=true;
            dtgvParcelasVenda.RowTemplate.Height=25;
            dtgvParcelasVenda.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvParcelasVenda.Size=new Size(643, 259);
            dtgvParcelasVenda.TabIndex=13;
            // 
            // panelData
            // 
            panelData.Controls.Add(lblDataFinal);
            panelData.Controls.Add(dtpDataFinal);
            panelData.Controls.Add(dtpDataInicial);
            panelData.Controls.Add(lblDataInicial);
            panelData.Controls.Add(btnData);
            panelData.Location=new Point(138, 12);
            panelData.Name="panelData";
            panelData.Size=new Size(527, 59);
            panelData.TabIndex=29;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize=true;
            lblDataFinal.Location=new Point(225, 3);
            lblDataFinal.Name="lblDataFinal";
            lblDataFinal.Size=new Size(57, 15);
            lblDataFinal.TabIndex=10;
            lblDataFinal.Text="Data final";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location=new Point(225, 21);
            dtpDataFinal.Name="dtpDataFinal";
            dtpDataFinal.Size=new Size(200, 23);
            dtpDataFinal.TabIndex=9;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location=new Point(6, 21);
            dtpDataInicial.Name="dtpDataInicial";
            dtpDataInicial.Size=new Size(200, 23);
            dtpDataInicial.TabIndex=8;
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize=true;
            lblDataInicial.Location=new Point(3, 4);
            lblDataInicial.Name="lblDataInicial";
            lblDataInicial.Size=new Size(65, 15);
            lblDataInicial.TabIndex=5;
            lblDataInicial.Text="Data inicial";
            // 
            // btnData
            // 
            btnData.Location=new Point(440, 21);
            btnData.Name="btnData";
            btnData.Size=new Size(75, 23);
            btnData.TabIndex=7;
            btnData.Text="Localizar";
            btnData.UseVisualStyleBackColor=true;
            btnData.Click+=btnData_Click;
            // 
            // panelRB
            // 
            panelRB.Controls.Add(lblConsultarPelo);
            panelRB.Controls.Add(rbVendas);
            panelRB.Controls.Add(rbParcelas);
            panelRB.Controls.Add(rbData);
            panelRB.Location=new Point(12, 12);
            panelRB.Name="panelRB";
            panelRB.Size=new Size(120, 98);
            panelRB.TabIndex=27;
            // 
            // lblConsultarPelo
            // 
            lblConsultarPelo.AutoSize=true;
            lblConsultarPelo.Location=new Point(3, 4);
            lblConsultarPelo.Name="lblConsultarPelo";
            lblConsultarPelo.Size=new Size(87, 15);
            lblConsultarPelo.TabIndex=16;
            lblConsultarPelo.Text="Consultar pelo:";
            // 
            // rbVendas
            // 
            rbVendas.AutoSize=true;
            rbVendas.Checked=true;
            rbVendas.Location=new Point(3, 25);
            rbVendas.Name="rbVendas";
            rbVendas.Size=new Size(95, 19);
            rbVendas.TabIndex=18;
            rbVendas.TabStop=true;
            rbVendas.Text="Todas vendas";
            rbVendas.UseVisualStyleBackColor=true;
            rbVendas.CheckedChanged+=rbVendas_CheckedChanged;
            // 
            // rbParcelas
            // 
            rbParcelas.AutoSize=true;
            rbParcelas.Location=new Point(3, 75);
            rbParcelas.Name="rbParcelas";
            rbParcelas.Size=new Size(115, 19);
            rbParcelas.TabIndex=17;
            rbParcelas.Text="Parcelas a vencer";
            rbParcelas.UseVisualStyleBackColor=true;
            rbParcelas.CheckedChanged+=rbVendas_CheckedChanged;
            // 
            // rbData
            // 
            rbData.AutoSize=true;
            rbData.Location=new Point(3, 50);
            rbData.Name="rbData";
            rbData.Size=new Size(100, 19);
            rbData.TabIndex=15;
            rbData.Text="Data da venda";
            rbData.UseVisualStyleBackColor=true;
            rbData.CheckedChanged+=rbVendas_CheckedChanged;
            // 
            // formConsultaVenda
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 418);
            Controls.Add(tbcDados);
            Controls.Add(panelData);
            Controls.Add(panelRB);
            Name="formConsultaVenda";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Venda";
            Load+=formConsultaVenda_Load;
            tbcDados.ResumeLayout(false);
            tabPageVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDadosVenda).EndInit();
            tabPageItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvItensVenda).EndInit();
            tabPageParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvParcelasVenda).EndInit();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            panelRB.ResumeLayout(false);
            panelRB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcDados;
        private TabPage tabPageVenda;
        private DataGridView dtgvDadosVenda;
        private TabPage tabPageItens;
        private DataGridView dtgvItensVenda;
        private TabPage tabPageParcelas;
        private DataGridView dtgvParcelasVenda;
        private Panel panelData;
        private Label lblDataFinal;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private Label lblDataInicial;
        private Button btnData;
        private Panel panelRB;
        private Label lblConsultarPelo;
        private RadioButton rbVendas;
        private RadioButton rbParcelas;
        private RadioButton rbData;
    }
}