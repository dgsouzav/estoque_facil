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
    public partial class formConsultaCompra : Form
    {
        public int id = 0;
        public formConsultaCompra()
        {
            InitializeComponent();
        }

        private void formConsultaCompra_Load(object sender, EventArgs e)
        {
            rbCompras_CheckedChanged(sender, e);
        }
        public void CabecalhoDtgvDadosCompra()
        {
            dtgvDadosCompra.Columns[0].HeaderText = "Código da Compra";
            dtgvDadosCompra.Columns[0].Width = 100;
            dtgvDadosCompra.Columns[1].HeaderText = "Data da Compra";
            dtgvDadosCompra.Columns[1].Width = 100;
            dtgvDadosCompra.Columns[2].HeaderText = "Número da Nota Fiscal";
            dtgvDadosCompra.Columns[2].Width = 100;
            dtgvDadosCompra.Columns[3].HeaderText = "Fornecedor";
            dtgvDadosCompra.Columns[3].Width = 100;
            dtgvDadosCompra.Columns[4].HeaderText = "Número de Parcelas";
            dtgvDadosCompra.Columns[4].Visible = false;
            dtgvDadosCompra.Columns[5].HeaderText = "Status";
            dtgvDadosCompra.Columns[5].Visible = false;
            dtgvDadosCompra.Columns[6].HeaderText = "Código do Fornecedor";
            dtgvDadosCompra.Columns[6].Visible = false;
            dtgvDadosCompra.Columns[7].HeaderText = "Código do tipo de pagamento";
            dtgvDadosCompra.Columns[7].Visible = false;
            dtgvDadosCompra.Columns[8].HeaderText = "Total";
            dtgvDadosCompra.Columns[8].Width = 100;
        }
        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            formConsultaFornecedor f = new formConsultaFornecedor();
            f.ShowDialog();
            if (f.id != 0)
            {
                txtFornecedorID.Text = f.id.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.id);
                lblNomeFornecedor2.Text = "Nome do Fornecedor: " + modelo.FornecedorNome;
                BLLCompra bll2 = new BLLCompra(cx);
                dtgvDadosCompra.DataSource = bll2.Localizar(f.id);
                f.Dispose();
                this.CabecalhoDtgvDadosCompra();
            }
            else
            {
                txtFornecedorID.Text = "";
                lblNomeFornecedor2.Text = "Nome do Fornecedor";
            }
            f.Dispose();
        }

        private void rbCompras_CheckedChanged(object sender, EventArgs e)
        {
            panelFornecedor.Visible = false;
            panelData.Visible = false;
            dtgvDadosCompra.DataSource = null;
            dtgvItensCompra.DataSource = null;
            dtgvParcelasCompra.DataSource = null;

            if (rbCompras.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                dtgvDadosCompra.DataSource = bll.Localizar("");
                this.CabecalhoDtgvDadosCompra();
            }
            if (rbFornecedor.Checked == true)
            {
                panelFornecedor.Visible = true;
            }
            if (rbData.Checked == true)
            {
                panelData.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                dtgvDadosCompra.DataSource = bll.LocalizarParcelasNaoPagas();
                this.CabecalhoDtgvDadosCompra();
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DateTime DataInicial = dtpDataInicial.Value;
            DateTime DataFinal = dtpDataFinal.Value;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dtgvDadosCompra.DataSource = bll.Localizar(DataInicial, DataFinal);
            this.CabecalhoDtgvDadosCompra();
        }
        public void CabecalhoDtgvItensCompra()
        {
            try
            {
                dtgvItensCompra.Columns[0].Visible = false;
                dtgvItensCompra.Columns[1].HeaderText = "ID do item";
                dtgvItensCompra.Columns[2].HeaderText = "ID do produto";
                dtgvItensCompra.Columns[3].HeaderText = "Nome do produto";
                dtgvItensCompra.Columns[4].HeaderText = "Quantidade";
                dtgvItensCompra.Columns[5].HeaderText = "Valor";

                dtgvParcelasCompra.Columns[0].HeaderText = "Parcela";
                dtgvParcelasCompra.Columns[1].HeaderText = "Valor";
                dtgvParcelasCompra.Columns[2].HeaderText = "Data de Pagamento";
                dtgvParcelasCompra.Columns[3].HeaderText = "Data de Vencimento";
                dtgvParcelasCompra.Columns[4].Visible = false;
            }
            catch { }

        }
        private void dtgvDadosCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                BLLItensCompra bllItens = new BLLItensCompra(cx);
                dtgvItensCompra.DataSource = bllItens.Localizar(Convert.ToInt32(dtgvDadosCompra.Rows[e.RowIndex].Cells[0].Value));

                CabecalhoDtgvItensCompra();
            }
        }

        private void dtgvDadosCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.id = Convert.ToInt32(dtgvDadosCompra.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void dtgvDadosCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvDadosCompra.Columns["compra_total"].Index)
                {
                    if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                    {
                        e.Value = valor.ToString("C2");
                    }
                }
            }
        }
    }
}
