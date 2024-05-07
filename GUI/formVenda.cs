using BLL;
using DAL;
using Modelo;
using System.Data;
using Validacoes;
using System.Data.SqlClient;


namespace UI
{
    public partial class formVenda : Form
    {
        public double totalVenda = 0;
        private int numeroNotaFiscal = 0;
        private int ClienteIDSelecionado = 0;
        public String operacao;

        private static DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        BLLTipoPagamento bll = new BLLTipoPagamento(cx);

        public formVenda()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += formVenda_KeyDown;

            txtNotaFiscal.Leave += txtNotaFiscal_Leave;
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
            txtClienteFidelidade.Clear();
            txtValorPago.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalVenda = 0;

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

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja realmente cancelar a venda?", "Aviso", MessageBoxButtons.YesNo);
            this.LimpaTela();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                // leitura dos dados
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VendaData = DateTime.Now;
                modeloVenda.VendaNotaFiscal = Convert.ToInt32(txtNotaFiscal.Text);
                modeloVenda.VendaStatus = "Ativa";
                modeloVenda.VendaTotal = this.totalVenda;
                modeloVenda.TipoPagamentoID = Convert.ToInt32(cmbTipoPagamento.SelectedValue);
                modeloVenda.ClienteID = this.ClienteIDSelecionado;

                BLLVenda bll = new BLLVenda(cx);

                ModeloItensVenda itens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

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

                }

                // mensagem de sucesso
                MessageBox.Show("Venda efetuada: Código " + modeloVenda.VendaID.ToString());

                this.LimpaTela();
                cx.TerminarTransacao();
                cx.Desconectar();

                // Após salvar com sucesso, volta o lblCaixaLivre ao estado inicial
                if (this.operacao == "inserir")
                {
                    lblCaixaLivre.Visible = true;
                    lblCaixaLivre.BringToFront();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
            this.LimpaTela();
            lblCaixaLivre.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnInserir_Click(sender, e);

            lblCaixaLivre.Visible = true;
            lblCaixaLivre.BringToFront();
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
                QtdeEstoque = modelo.ProdutoQtde;
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

                    // Buscar o nome do produto
                    string nomeProduto = lblProdutoNome.Text;

                    String[] i = new String[] { txtProdutoID.Text, nomeProduto, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };
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
            this.Focus();
            cmbTipoPagamento.DataSource = bll.Localizar("");
            cmbTipoPagamento.DisplayMember = "tipoPagamento_nome";
            cmbTipoPagamento.ValueMember = "tipoPagamento_id";

            this.operacao = "inserir";
            this.totalVenda = 0;

            GerarNumeroNotaFiscal();
            txtNotaFiscal.ReadOnly = true;
        }

        private void GerarNumeroNotaFiscal()
        {
            Random random = new Random();
            numeroNotaFiscal = random.Next(100000, 999999);

            txtNotaFiscal.Text = numeroNotaFiscal.ToString();
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

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            lblCaixaLivre.Visible = true;
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorPago.Text, out decimal valorPago))
            {
                decimal troco = valorPago - (decimal)this.totalVenda;

                if (troco >= 0)
                {
                    txtTroco.Text = $"R$ {troco:F2}";
                }
                else
                {
                    txtTroco.Text = "Valor Insuficiente";
                }
            }
            else
            {
                txtTroco.Text = "";
            }
        }

        private void txtClienteFidelidade_TextChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();
            string textoDigitado = txtClienteFidelidade.Text;
            BLLCliente bll = new BLLCliente(cx);
            DataTable cliente = bll.LocalizarPorNome(textoDigitado);

            listBoxClientes.DataSource = null;

            listBoxClientes.DataSource = cliente;
            listBoxClientes.DisplayMember = "cliente_nome";
            listBoxClientes.ValueMember = "cliente_id";
        }


        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                DataRowView clienteSelecionado = listBoxClientes.SelectedItem as DataRowView;
                txtClienteFidelidade.Text = clienteSelecionado["cliente_nome"].ToString();
                int ClienteID = Convert.ToInt32(clienteSelecionado["cliente_id"]);
                this.ClienteIDSelecionado = ClienteID;
            }
        }

        private void formVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btnSalvar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnCancelarVenda_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnCancelar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F9)
            {
                btnCancelarPagamento_Click(sender, e);
            }
        }

        private void txtNotaFiscal_Leave(object sender, EventArgs e)
        {
            // Verifica se o txtNotaFiscal está preenchido
            if (!string.IsNullOrEmpty(txtNotaFiscal.Text))
            {
                // Se estiver preenchido, desativa o lblCaixaLivre
                lblCaixaLivre.Enabled = false;
            }
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {

        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {

        }

        private void txtNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dtgvItensVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgvItensVenda.Columns["produtoValor"].Index ||
                e.ColumnIndex == dtgvItensVenda.Columns["produtoValorTotal"].Index)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }
        }

        private void txtQtde_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtValorPago_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
