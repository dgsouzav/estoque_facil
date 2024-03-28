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
    public partial class formVenda : Form
    {
        public double totalVenda = 0;
        private int numeroNotaFiscal = 0;
        public formVenda()
        {
            InitializeComponent();
        }
        public String operacao;

        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnCancelarVenda.Enabled = false;

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
                btnCancelarVenda.Enabled = true;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            txtVendaID.Clear();
            txtProdutoID.Clear();
            txtNotaFiscal.Clear();
            txtQtde.Clear();
            txtVendaTotal.Text = "0,00";
            txtTroco.Text = "0,00";
            txtValor.Clear();
            dtgvItensVenda.Rows.Clear();
            cmbTipoPagamento.SelectedIndex = 0;
            lblProdutoNome.Text = "Informe o código do produto ou clique em localizar";
            cmbNumeroParcelas.SelectedIndex = 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalVenda = 0;
            this.menuBotoes(2);

            // Verifica se a operação é de inserção e oculta a label lblCaixaLivre
            if (this.operacao == "inserir")
            {
                lblCaixaLivre.Visible = false;
            }
            else
            {
                lblCaixaLivre.Visible = true;
                lblCaixaLivre.BringToFront();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            formConsultaVenda f = new formConsultaVenda();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.id);

                txtVendaID.Text = modelo.VendaID.ToString();
                txtNotaFiscal.Text = modelo.VendaNotaFiscal.ToString();
                dtpDataVenda.Value = modelo.VendaData;
                cmbTipoPagamento.SelectedValue = modelo.TipoPagamentoID;
                cmbNumeroParcelas.Text = modelo.VendaNumeroParcelas.ToString();
                txtVendaTotal.Text = modelo.VendaTotal.ToString();
                if (modelo.VendaAVista == 1)
                {
                    checkBoxVendaAVista.Checked = true;
                }
                else
                {
                    checkBoxVendaAVista.Checked = false;
                }
                this.totalVenda = modelo.VendaTotal;

                BLLItensVenda bLLItensVenda = new BLLItensVenda(cx);
                DataTable tabela = bLLItensVenda.Localizar(modelo.VendaID);

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string id = tabela.Rows[i]["produto_id"].ToString();
                    string nome = tabela.Rows[i]["produto_nome"].ToString();
                    string qtde = tabela.Rows[i]["itensVenda_qtde"].ToString();
                    string valor = tabela.Rows[i]["itensVenda_valor"].ToString();

                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itensVenda_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itensVenda_valor"]);

                    String[] k = new String[] { id, nome, qtde, valor, TotalLocal.ToString() };
                    this.dtgvItensVenda.Rows.Add(k);
                }
                this.menuBotoes(3);


            }
            else
            {
                this.LimpaTela();
                this.menuBotoes(1);
            }
            f.Dispose();
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja realmente cancelar a venda?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                if (bll.CancelarVenda(Convert.ToInt32(txtVendaID.Text)) == true)
                {
                    MessageBox.Show("Venda cancelada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cancelar a venda");
                }
            }
            this.LimpaTela();
            this.menuBotoes(1);

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                numeroNotaFiscal++;
                if (totalVenda <= 0)
                {
                    MessageBox.Show("Informe um produto para continuar");
                    return;
                }

                dtgvParcelasVenda.Rows.Clear();
                int parcelas = Convert.ToInt32(cmbNumeroParcelas.Text);
                Double totalLocal = this.totalVenda;
                Double valorLocal = totalLocal / parcelas;
                DateTime dt = new DateTime();
                dt = dtpDataInicial.Value;
                lbl0000.Text = "" + valorLocal.ToString();

                for (int i = 1; i <= parcelas; i++)
                {
                    String[] k = new String[] { i.ToString(), valorLocal.ToString(), dt.Date.ToString() };
                    this.dtgvParcelasVenda.Rows.Add(k);
                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                }
                panelFinalizaVenda.Visible = true;
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VendaNotaFiscal = numeroNotaFiscal;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.menuBotoes(1);

            lblCaixaLivre.Visible = true;
            lblCaixaLivre.BringToFront();

            // Volta ao início e oculta o lblVendaCancelada quando o botão btnCancelar for pressionado
            lblVendaCancelada.Visible = false;
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
                txtValor.Text = modelo.ProdutoValorVenda.ToString();
                txtQtde.Text = "1";
                lblProdutoNome.Text = modelo.ProdutoNome;
            }
            catch
            {
                txtProdutoID.Clear();
                lblProdutoNome.Text = "Informe o nome do Produto ou localize";
            }
        }
        private Double VerificaQtdeProdutos(int ProdutoID)
        {
            Double QtdeEstoque = 0;
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(ProdutoID);
                QtdeEstoque = modelo.ProdutoLote;
                for (int i = 0; i < dtgvItensVenda.RowCount; i++)
                {
                    if (Convert.ToInt32(dtgvItensVenda.Rows[i].Cells[0].Value) == ProdutoID)
                    {
                        QtdeEstoque = QtdeEstoque - Convert.ToDouble(dtgvItensVenda.Rows[i].Cells[2].Value);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao verificar estoque");
            }
            return QtdeEstoque;
        }
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            Double qtde = 0;
            try
            {
                if ((txtProdutoID.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    if (checkBoxVerificaEstoque.Checked == true)
                    {
                        qtde = VerificaQtdeProdutos(Convert.ToInt32(txtProdutoID.Text));
                        if (qtde < Convert.ToDouble(txtQtde.Text))
                        {
                            MessageBox.Show("Quantidade informada maior que a quantidade em estoque, você possue " + qtde + " unidades em estoque");
                            return;
                        }
                    }
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalVenda = this.totalVenda + TotalLocal;
                    String[] i = new String[] { txtProdutoID.Text, lblProdutoID.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };
                    this.dtgvItensVenda.Rows.Add(i);

                    txtProdutoID.Clear();
                    lblProdutoNome.Text = "Informe o nome do Produto ou localize";
                    txtQtde.Clear();
                    txtValor.Clear();
                    txtVendaTotal.Text = this.totalVenda.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes a quantidade e valor do produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formVenda_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cmbTipoPagamento.DataSource = bll.Localizar("");
            cmbTipoPagamento.DisplayMember = "tipoPagamento_nome";
            cmbTipoPagamento.ValueMember = "tipoPagamento_id";
            cmbNumeroParcelas.SelectedIndex = 0;
            checkBoxVendaAVista.Checked = false;
            lblVendaCancelada.Visible = false;
        }

        private void dtgvItensVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProdutoID.Text = dtgvItensVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblProdutoNome.Text = dtgvItensVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dtgvItensVenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dtgvItensVenda.Rows[e.RowIndex].Cells[3].Value.ToString();

                Double valor = Convert.ToDouble(dtgvItensVenda.Rows[e.RowIndex].Cells[4].Value.ToString());
                this.totalVenda = this.totalVenda - valor;
                dtgvItensVenda.Rows.RemoveAt(e.RowIndex);
                txtVendaTotal.Text = this.totalVenda.ToString();
            }
        }

        private void checkBoxVendaAVista_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVendaAVista.Checked == true)
            {
                cmbNumeroParcelas.SelectedIndex = 0;
                cmbNumeroParcelas.Enabled = false;
            }
            else
            {
                cmbNumeroParcelas.Enabled = true;
            }
        }

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
            panelFinalizaVenda.Visible = false;

            lblVendaCancelada.Visible = true;
            lblVendaCancelada.BringToFront();
        }

        private void btnSalvarPagamento_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                // leitura dos dados
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VendaData = dtpDataVenda.Value;
                modeloVenda.VendaNotaFiscal = Convert.ToInt32(txtNotaFiscal.Text);
                modeloVenda.VendaNumeroParcelas = Convert.ToInt32(cmbNumeroParcelas.Text);
                modeloVenda.VendaStatus = "Ativa";
                modeloVenda.VendaTotal = this.totalVenda;
                modeloVenda.TipoPagamentoID = Convert.ToInt32(cmbTipoPagamento.SelectedValue);
                if (checkBoxVendaAVista.Checked == true)
                {
                    modeloVenda.VendaAVista = 1;
                }
                else
                {
                    modeloVenda.VendaAVista = 0;
                }

                BLLVenda bll = new BLLVenda(cx);

                ModeloItensVenda itens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

                ModeloParcelasVenda parcelas = new ModeloParcelasVenda();
                BLLParcelasVenda bparcelas = new BLLParcelasVenda(cx);

                if (this.operacao == "inserir")
                {
                    // inserir uma Venda
                    bll.Incluir(modeloVenda);
                    for (int i = 0; i < dtgvItensVenda.RowCount; i++)
                    {
                        itens.ItensVendaID = i + 1;
                        itens.VendaID = modeloVenda.VendaID;
                        itens.ProdutoID = Convert.ToInt32(dtgvItensVenda.Rows[i].Cells[0].Value);
                        itens.ItensVendaQtde = Convert.ToInt32(dtgvItensVenda.Rows[i].Cells[2].Value);
                        itens.ItensVendaValor = Convert.ToDouble(dtgvItensVenda.Rows[i].Cells[3].Value);
                        bitens.Incluir(itens);
                        // trigger decrementa quantidade de produtos
                    }

                    // inserir as parcelas
                    for (int i = 0; i < dtgvParcelasVenda.RowCount; i++)
                    {
                        parcelas.ParcelasVendaID = i + 1;
                        parcelas.VendaID = modeloVenda.VendaID;
                        parcelas.ParcelasVendaID = Convert.ToInt32(dtgvParcelasVenda.Rows[i].Cells[0].Value);
                        parcelas.ParcelasVendaValor = Convert.ToDouble(dtgvParcelasVenda.Rows[i].Cells[1].Value);
                        parcelas.ParcelasVendaDataVencimento = Convert.ToDateTime(dtgvParcelasVenda.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(parcelas);
                    }
                    MessageBox.Show("Venda efetuada com sucesso! Código: " + modeloVenda.VendaID.ToString());
                }

                this.LimpaTela();
                panelFinalizaVenda.Visible = false;
                this.menuBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
            // Esconde a label lblCaixaLivre
            lblCaixaLivre.Visible = false;
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorPago.Text, out decimal valorPago))
            {
                // Calcula o troco
                decimal troco = valorPago - (decimal)this.totalVenda;

                if (troco >= 0)
                {
                    // Exiba o troco no TextBox de troco
                    txtTroco.Text = $"R$ {troco:F2}";
                }
                else
                {
                    // Se o valor pago for menor que o total da venda, exiba "Valor Insuficiente"
                    txtTroco.Text = "Valor Insuficiente";
                }
            }
            else
            {
                // Se o valor inserido não for válido, limpe o TextBox de troco
                txtTroco.Text = "";
            }
        }
    }
}
