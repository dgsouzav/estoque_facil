using BLL;
using DAL;
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
    public partial class formConsultaVenda : Form
    {
        public int id = 0;
        public formConsultaVenda()
        {
            InitializeComponent();
        }

        private void formConsultaVenda_Load(object sender, EventArgs e)
        {
            rbVendas_CheckedChanged(sender, e);
        }

        private void rbVendas_CheckedChanged(object sender, EventArgs e)
        {
            panelData.Visible = false;
            dtgvDadosVenda.DataSource = null;
            dtgvItensVenda.DataSource = null;
            dtgvParcelasVenda.DataSource = null;

            if (rbVendas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                dtgvDadosVenda.DataSource = bll.Localizar();
                this.CabecalhoDtgvDadosVenda();
            }
            if (rbData.Checked == true)
            {
                panelData.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                dtgvDadosVenda.DataSource = bll.LocalizarParcelasNaoPagas();
                this.CabecalhoDtgvDadosVenda();
            }
        }
        public void CabecalhoDtgvItensVenda()
        {
            try
            {
                dtgvItensVenda.Columns[0].Visible = false;
                dtgvItensVenda.Columns[1].HeaderText = "ID do item";
                dtgvItensVenda.Columns[2].HeaderText = "Quantidade";
                dtgvItensVenda.Columns[3].HeaderText = "Valor";
                dtgvItensVenda.Columns[4].HeaderText = "ID da Venda";
                dtgvItensVenda.Columns[4].Visible = false;
                dtgvItensVenda.Columns[5].HeaderText = "Produto";

                dtgvParcelasVenda.Columns[0].HeaderText = "ID da Venda";
                dtgvParcelasVenda.Columns[1].HeaderText = "Parcela";
                dtgvParcelasVenda.Columns[2].HeaderText = "Valor";
                dtgvParcelasVenda.Columns[3].HeaderText = "Data de Pagamento";
                dtgvParcelasVenda.Columns[4].HeaderText = "Data de Vencimento";
                dtgvParcelasVenda.Columns[0].Visible = false;
            }
            catch { }

        }
        public void CabecalhoDtgvDadosVenda()
        {
            dtgvDadosVenda.Columns[0].HeaderText = "ID da Venda";
            dtgvDadosVenda.Columns[0].Width = 100;
            dtgvDadosVenda.Columns[1].HeaderText = "Data da Venda";
            dtgvDadosVenda.Columns[1].Width = 100;
            dtgvDadosVenda.Columns[2].HeaderText = "Número da Nota Fiscal";
            dtgvDadosVenda.Columns[2].Width = 100;
            dtgvDadosVenda.Columns[3].HeaderText = "Total";
            dtgvDadosVenda.Columns[3].Width = 100;
            dtgvDadosVenda.Columns[4].HeaderText = "Número de Parcelas";
            dtgvDadosVenda.Columns[4].Width = 100;
            dtgvDadosVenda.Columns[5].HeaderText = "Status";
            dtgvDadosVenda.Columns[5].Width = 100;
            dtgvDadosVenda.Columns[6].HeaderText = "Código do tipo de pagamento";
            dtgvDadosVenda.Columns[6].Visible = false;
            dtgvDadosVenda.Columns[7].HeaderText = "Venda a vista";
            dtgvDadosVenda.Columns[7].Visible = false;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DateTime DataInicial = dtpDataInicial.Value;
            DateTime DataFinal = dtpDataFinal.Value;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            dtgvDadosVenda.DataSource = bll.LocalizarPorData(DataInicial, DataFinal);
            this.CabecalhoDtgvDadosVenda();
        }

        private void dtgvDadosVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                BLLItensVenda bllItens = new BLLItensVenda(cx);
                dtgvItensVenda.DataSource = bllItens.Localizar(Convert.ToInt32(dtgvDadosVenda.Rows[e.RowIndex].Cells[0].Value));

                BLLParcelasVenda bllParcelas = new BLLParcelasVenda(cx);
                dtgvParcelasVenda.DataSource = bllParcelas.Localizar(Convert.ToInt32(dtgvDadosVenda.Rows[e.RowIndex].Cells[0].Value));
                CabecalhoDtgvItensVenda();
            }
        }

        private void dtgvDadosVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.id = Convert.ToInt32(dtgvDadosVenda.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
