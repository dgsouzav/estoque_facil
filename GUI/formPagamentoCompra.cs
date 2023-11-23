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
        public formPagamentoCompra()
        {
            InitializeComponent();
        }

        private void btnLocalizarCompra_Click(object sender, EventArgs e)
        {
            formConsultaCompra f = new formConsultaCompra();
            f.ShowDialog();
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

                BLLParcelasCompra bLLParcelasCompra = new BLLParcelasCompra(cx);
                DataTable tabela = bLLParcelasCompra.Localizar(modelo.CompraID);

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string id = tabela.Rows[i]["produto_id"].ToString();
                    string nome = tabela.Rows[i]["produto_nome"].ToString();
                    string qtde = tabela.Rows[i]["itensCompra_qtde"].ToString();
                    string valor = tabela.Rows[i]["itensCompra_valor"].ToString();

                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itensCompra_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itensCompra_valor"]);

                    String[] k = new String[] { id, nome, qtde, valor, TotalLocal.ToString() };
                    this.dtgvParcelas.Rows.Add(k);
                }
            }
        }
    }
}
