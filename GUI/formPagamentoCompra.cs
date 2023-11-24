using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class formPagamentoCompra : Form
    {
        public int ParcelasCompraID = 0;
        public formPagamentoCompra()
        {
            InitializeComponent();
        }

        private void btnLocalizarCompra_Click(object sender, EventArgs e)
        {
            formConsultaCompra f = new formConsultaCompra();
            f.ShowDialog();
            btnPagar.Enabled = false;
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.id);

                txtID.Text = modelo.CompraID.ToString();
                dtpData.Value = modelo.CompraData;

                BLLFornecedor bllf = new BLLFornecedor(cx);
                ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(modelo.FornecedorID);
                txtFornecedorNome.Text = modelof.FornecedorNome;

                txtValor.Text = modelo.CompraTotal.ToString();

                BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                dtgvParcelas.DataSource = bllp.Localizar(modelo.CompraID);

                dtgvParcelas.Columns[0].HeaderText = "ID da Parcela";
                dtgvParcelas.Columns[1].HeaderText = "Valor";
                dtgvParcelas.Columns[2].HeaderText = "Data de Pagamento";
                dtgvParcelas.Columns[3].HeaderText = "Data de Vencimento";
                dtgvParcelas.Columns[4].Visible = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                int compraID = Convert.ToInt32(txtID.Text);
                DateTime data = dtpDataPagamento.Value;
                
                bllp.EfetuaPagamentoParcela(compraID, this.ParcelasCompraID, data);

                BLLParcelasCompra bllp2 = new BLLParcelasCompra(cx);
                dtgvParcelas.DataSource = bllp.Localizar(compraID);
                btnPagar.Enabled = false;

                dtgvParcelas.Columns[0].HeaderText = "ID da Parcela";
                dtgvParcelas.Columns[1].HeaderText = "Valor";
                dtgvParcelas.Columns[2].HeaderText = "Data de Pagamento";
                dtgvParcelas.Columns[3].HeaderText = "Data de Vencimento";
                dtgvParcelas.Columns[4].Visible = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void dtgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPagar.Enabled = false;
            this.ParcelasCompraID = 0;
            if (e.RowIndex >= 0 && dtgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btnPagar.Enabled = true;
                this.ParcelasCompraID = Convert.ToInt32(dtgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
