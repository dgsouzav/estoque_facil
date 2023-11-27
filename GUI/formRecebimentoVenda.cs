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
    public partial class formRecebimentoVenda : Form
    {
        public int ParcelasVendaID = 0;
        public formRecebimentoVenda()
        {
            InitializeComponent();
        }

        private void btnLocalizarVenda_Click(object sender, EventArgs e)
        {
            formConsultaVenda f = new formConsultaVenda();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.id);

                txtID.Text = modelo.VendaID.ToString();
                dtpData.Value = modelo.VendaData;

                txtValor.Text = modelo.VendaTotal.ToString();

                BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                dtgvParcelas.DataSource = bllp.Localizar(modelo.VendaID);

                dtgvParcelas.Columns[0].HeaderText = "ID da Venda";
                dtgvParcelas.Columns[1].HeaderText = "Parcela";
                dtgvParcelas.Columns[2].HeaderText = "Valor";
                dtgvParcelas.Columns[3].HeaderText = "Data de Pagamento";
                dtgvParcelas.Columns[4].HeaderText = "Data de Vencimento";
                dtgvParcelas.Columns[0].Visible = false;
            }
        }

        private void dtgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnReceber.Enabled = false;
            this.ParcelasVendaID = 0;
            if (e.RowIndex >= 0 && dtgvParcelas.Rows[e.RowIndex].Cells[3].Value.ToString() == "")
            {
                btnReceber.Enabled = true;
                this.ParcelasVendaID = Convert.ToInt32(dtgvParcelas.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void btnReceber_Click_1(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                int vendaID = Convert.ToInt32(txtID.Text);
                DateTime data = dtpDataRecebimento.Value;

                bllp.EfetuaRecebimentoParcela(vendaID, this.ParcelasVendaID, data);

                BLLParcelasVenda bllp2 = new BLLParcelasVenda(cx);
                dtgvParcelas.DataSource = bllp.Localizar(vendaID);
                btnReceber.Enabled = false;

                dtgvParcelas.Columns[0].HeaderText = "ID da Venda";
                dtgvParcelas.Columns[1].HeaderText = "Parcela";
                dtgvParcelas.Columns[2].HeaderText = "Valor";
                dtgvParcelas.Columns[3].HeaderText = "Data de Pagamento";
                dtgvParcelas.Columns[4].HeaderText = "Data de Vencimento";
                dtgvParcelas.Columns[0].Visible = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
