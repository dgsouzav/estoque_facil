using BLL;
using DAL;
using Modelo;
using System;
using System.Collections;
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
    public partial class formCompra : Form
    {
        public Double totalCompra = 0;

        public String operacao;

        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLocalizar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }

            if (op == 2)
            {
                panelDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            txtCompraID.Clear();
            txtNotaFiscal.Clear();
            txtFornecedorID.Clear();
            txtProdutoID.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            txtCompraTotal.Clear();
            lblFornecedorNome.Text = "Informe o nome do Fornecedor ou localize";
            lblProdutoNome.Text = "Informe o nome do Produto ou localize";
            dtgvItensCompra.Rows.Clear();
        }
        public formCompra()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.menuBotoes(2);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.menuBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.totalCompra = 0;
            this.menuBotoes(1);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dtgvParcelasCompra.Rows.Clear();
            int parcelas = Convert.ToInt32(cmbNumeroParcelas.Text);
            Double totalLocal = this.totalCompra;
            Double valorLocal = totalLocal / parcelas;
            DateTime dt = new DateTime();
            dt = dtpDataInicial.Value;
            lblCompraTotal.Text = txtCompraTotal.Text;

            for (int i = 1; i <= parcelas; i++)
            {
                String[] k = new String[] { i.ToString(), valorLocal.ToString(), dt.Date.ToString() };
                this.dtgvParcelasCompra.Rows.Add(k);
                if (dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
            }
            panelFinalizaCompra.Visible = true;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            /*formConsultaFornecedor f = new formConsultaFornecedor();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.id);
                txtFornecedorID.Text = modelo.FornecedorID.ToString();
                txtNomeFornecedor.Text = modelo.FornecedorNome;
                txtCNPJ.Text = modelo.FornecedorCNPJ;
                txtInscricaoEstadual.Text = modelo.FornecedorInscricaoEstadual;
                txtRazaoSocial.Text = modelo.FornecedorRazaoSocial;
                txtCEP.Text = modelo.FornecedorCEP;
                txtEnderecoFornecedor.Text = modelo.FornecedorEndereco;
                txtBairro.Text = modelo.FornecedorBairro;
                txtFone.Text = modelo.FornecedorFone;
                txtEmail.Text = modelo.FornecedorEmail;
                txtEndNumero.Text = modelo.FornecedorEndNumero;
                txtCidade.Text = modelo.FornecedorCidade;
                txtEstado.Text = modelo.FornecedorEstado;

                this.menuBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.menuBotoes(1);
            }
            f.Dispose();*/
        }

        private void btnLocalizarFornecedor_Click_1(object sender, EventArgs e)
        {
            formConsultaFornecedor f = new formConsultaFornecedor();
            f.ShowDialog();
            if (f.id != 0)
            {
                txtFornecedorID.Text = f.id.ToString();
                txtFornecedorID_Leave(sender, e);
            }
            else
            {
                this.LimpaTela();
                this.menuBotoes(1);
            }
            f.Dispose();
        }

        private void txtFornecedorID_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtFornecedorID.Text));
                lblFornecedorID.Text = modelo.FornecedorNome;
            }
            catch (Exception ex)
            {
                txtFornecedorID.Clear();
                lblFornecedorNome.Text = "Informe o nome do Fornecedor ou localize";
                MessageBox.Show("Erro ao buscar o Fornecedor: " + ex.Message);
            }
        }

        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            formConsultaProduto f = new formConsultaProduto();
            f.ShowDialog();
            if (f.id != 0)
            {
                txtProdutoID.Text = f.id.ToString();
                txtProdutoID_Leave(sender, e);
            }
            else
            {
                this.LimpaTela();
                this.menuBotoes(1);
            }
            f.Dispose();
        }

        private void txtProdutoID_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProdutoID.Text));
                lblProdutoID.Text = modelo.ProdutoNome;
                txtQtde.Text = "1";
                txtValor.Text = modelo.ProdutoValorPago.ToString();
            }
            catch
            {
                txtProdutoID.Clear();
                lblProdutoNome.Text = "Informe o nome do Produto ou localize";
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if ((txtProdutoID.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
            {
                Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                this.totalCompra = this.totalCompra + TotalLocal;
                String[] i = new String[] { txtProdutoID.Text, lblProdutoID.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };
                this.dtgvItensCompra.Rows.Add(i);

                txtProdutoID.Clear();
                lblProdutoNome.Text = "Informe o nome do Produto ou localize";
                txtQtde.Clear();
                txtValor.Clear();
                txtCompraTotal.Text = this.totalCompra.ToString();
            }
        }

        private void formCompra_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cmbTipoPagamento.DataSource = bll.Localizar("");
            cmbTipoPagamento.DisplayMember = "tipoPagamento_nome";
            cmbTipoPagamento.ValueMember = "tipoPagamento_id";
        }

        private void dtgvItensCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProdutoID.Text = dtgvItensCompra.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblProdutoNome.Text = dtgvItensCompra.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dtgvItensCompra.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dtgvItensCompra.Rows[e.RowIndex].Cells[3].Value.ToString();

                Double valor = Convert.ToDouble(dtgvItensCompra.Rows[e.RowIndex].Cells[4].Value.ToString());
                this.totalCompra = this.totalCompra - valor;
                dtgvItensCompra.Rows.RemoveAt(e.RowIndex);
                txtCompraTotal.Text = this.totalCompra.ToString();
            }
        }

        private void btnSalvarPagamento_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            try
            {
                ModeloCompra modelo = new ModeloCompra();
                modelo.CompraData = dtpDataAtual.Value;
                modelo.CompraNotaFiscal = Convert.ToInt32(txtNotaFiscal.Text);
                modelo.CompraNumeroParcelas = Convert.ToInt32(cmbNumeroParcelas.Text);
                modelo.CompraStatus = "Ativa";
                modelo.CompraTotal = this.totalCompra;
                modelo.FornecedorID = Convert.ToInt32(txtFornecedorID.Text);
                modelo.TipoPagamentoID = Convert.ToInt32(cmbTipoPagamento.SelectedValue);

                ModeloItensCompra itens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    for (int i = 0; i < dtgvItensCompra.RowCount; i++)
                    {
                        itens.ItensCompraID = i + 1;
                        itens.CompraID = modelo.CompraID;
                        itens.ProdutoID = Convert.ToInt32(dtgvItensCompra.Rows[i].Cells[0].Value);
                        itens.ItensCompraQtde = Convert.ToInt32(dtgvItensCompra.Rows[i].Cells[2].Value);
                        itens.ItensCompraValor = Convert.ToDouble(dtgvItensCompra.Rows[i].Cells[3].Value);
                        bitens.Incluir(itens);


                    }


                    MessageBox.Show("Compra efetuada com sucesso! Código: " + modelo.CompraID.ToString());
                }
                else
                {
                    //modelo.CompraID = Convert.ToInt32(txtCompraID.Text);
                    //bll.Alterar(modelo);
                    // MessageBox.Show("Compra alterada com sucesso!");
                }
                this.LimpaTela();
                this.menuBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
            panelFinalizaCompra.Visible = false;
        }
    }
}
