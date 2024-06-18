using BLL;
using DAL;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace UI
{
    public partial class formCompra : Form
    {
        private int numeroNotaFiscal = 0;
        public Double totalCompra = 0;

        public String operacao;

        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;

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
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
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
            int compraid = Convert.ToInt32(txtCompraID.Text);

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll3 = new BLLCompra(cx);

            ModeloCompra modeloCompra = bll3.CarregaModeloCompra(compraid);

            if (modeloCompra.CompraStatus == "Ativa")
            {
                this.operacao = "alterar";
                this.menuBotoes(2);
            }
            else
            {
                MessageBox.Show("Não é possível alterar uma compra cancelada!");
            }

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.totalCompra = 0;
            this.menuBotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                // leitura dos dados
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.CompraData = DateTime.Now;
                modeloCompra.CompraNotaFiscal = Convert.ToInt32(txtNotaFiscal.Text);
                modeloCompra.CompraStatus = "Ativa";
                modeloCompra.CompraTotal = this.totalCompra;
                modeloCompra.FornecedorID = Convert.ToInt32(txtFornecedorID.Text);
                modeloCompra.TipoPagamentoID = Convert.ToInt32(cmbTipoPagamento.SelectedValue);

                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra itens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);


                if (this.operacao == "inserir")
                {
                    // inserir uma compra
                    bll.Incluir(modeloCompra);

                    for (int i = 0; i < dtgvItensCompra.RowCount; i++)
                    {
                        itens.ItensCompraID = i + 1;
                        itens.CompraID = modeloCompra.CompraID;
                        itens.ProdutoID = Convert.ToInt32(dtgvItensCompra.Rows[i].Cells[0].Value);
                        itens.ItensCompraQtde = Convert.ToInt32(dtgvItensCompra.Rows[i].Cells[2].Value);
                        itens.ItensCompraValor = Convert.ToDouble(dtgvItensCompra.Rows[i].Cells[3].Value);
                        bitens.Incluir(itens);
                    }
                    MessageBox.Show("Compra efetuada com sucesso! Código: " + modeloCompra.CompraID.ToString());
                }
                else
                {
                    // alterar uma compra
                    modeloCompra.CompraID = Convert.ToInt32(txtCompraID.Text);
                    bll.Alterar(modeloCompra);

                    // exluir os itens
                    bitens.ExcluirItens(modeloCompra.CompraID);

                    // inserir os itens
                    for (int i = 0; i < dtgvItensCompra.RowCount; i++)
                    {
                        itens.ItensCompraID = i + 1;
                        itens.CompraID = modeloCompra.CompraID;
                        itens.ProdutoID = Convert.ToInt32(dtgvItensCompra.Rows[i].Cells[0].Value);
                        itens.ItensCompraQtde = Convert.ToInt32(dtgvItensCompra.Rows[i].Cells[2].Value);
                        itens.ItensCompraValor = Convert.ToDouble(dtgvItensCompra.Rows[i].Cells[3].Value);
                        bitens.Incluir(itens);
                    }
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                this.LimpaTela();
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
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            formConsultaCompra f = new formConsultaCompra();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.id);

                txtCompraID.Text = modelo.CompraID.ToString();
                txtNotaFiscal.Text = modelo.CompraNotaFiscal.ToString();
                txtFornecedorID.Text = modelo.FornecedorID.ToString();
                txtFornecedorID_Leave(sender, e);
                cmbTipoPagamento.SelectedValue = modelo.TipoPagamentoID;
                txtCompraTotal.Text = modelo.CompraTotal.ToString();

                this.totalCompra = modelo.CompraTotal;

                BLLItensCompra bLLItensCompra = new BLLItensCompra(cx);
                DataTable tabela = bLLItensCompra.Localizar(modelo.CompraID);

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string id = tabela.Rows[i]["produto_id"].ToString();
                    string nome = tabela.Rows[i]["produto_nome"].ToString();
                    string qtde = tabela.Rows[i]["itensCompra_qtde"].ToString();
                    string valor = tabela.Rows[i]["itensCompra_valor"].ToString();

                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itensCompra_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itensCompra_valor"]);

                    String[] k = new String[] { id, nome, qtde, valor, TotalLocal.ToString() };
                    this.dtgvItensCompra.Rows.Add(k);
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
                if (!string.IsNullOrEmpty(txtFornecedorID.Text))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    ModeloFornecedor modelo = bll.CarregaModeloFornecedorPorNome(txtFornecedorID.Text); // Ajustado para buscar por nome
                    txtFornecedorID.Text = modelo.FornecedorID.ToString();
                    lblFornecedorNome.Text = modelo.FornecedorNome;
                }
            }
            catch
            {
                txtFornecedorID.Clear();
                lblFornecedorNome.Text = "Informe o código do fornecedor ou clique em localizar";
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
                if (!string.IsNullOrEmpty(txtProdutoID.Text))
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    ModeloProduto modelo = bll.CarregaModeloProdutoPorNome(txtProdutoID.Text); // Ajustado para buscar por nome
                    txtProdutoID.Text = modelo.ProdutoID.ToString();
                    lblProdutoNome.Text = modelo.ProdutoNome;
                    txtQtde.Text = "1";
                    txtValor.Text = modelo.ProdutoValorVenda.ToString();
                }
            }
            catch
            {
                txtProdutoID.Clear();
                lblProdutoNome.Text = "Informe o nome do Produto ou localize";
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes a quantidade e valor do produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GerarNumeroNotaFiscal()
        {
            Random random = new Random();
            numeroNotaFiscal = random.Next(100000, 999999);

            txtNotaFiscal.Text = numeroNotaFiscal.ToString();
        }

        private void formCompra_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cmbTipoPagamento.DataSource = bll.Localizar("");
            cmbTipoPagamento.DisplayMember = "tipoPagamento_nome";
            cmbTipoPagamento.ValueMember = "tipoPagamento_id";

            dtgvItensCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GerarNumeroNotaFiscal();
            txtNotaFiscal.Text = numeroNotaFiscal.ToString();

            // Configurar autocomplete para txtFornecedorID
            ConfigureAutocomplete(txtFornecedorID, "SELECT fornecedor_id, fornecedor_nome FROM fornecedor");

            // Configurar autocomplete para txtProdutoID
            ConfigureAutocomplete(txtProdutoID, "SELECT produto_id, produto_nome FROM produto");
        }
        private void ConfigureAutocomplete(TextBox textBox, string query)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            LoadAutoCompleteData(autoCompleteCollection, query);

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void LoadAutoCompleteData(AutoCompleteStringCollection autoCompleteCollection, string query)
        {
            string connectionString = DadosDaConexao.StringDeConexao;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    autoCompleteCollection.Add(reader[1].ToString()); // Adiciona o nome do fornecedor ou produto
                }

                reader.Close();
            }
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

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja excluir a compra?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                int compraid = Convert.ToInt32(txtCompraID.Text);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll3 = new BLLCompra(cx);

                bll3.Excluir(compraid);
                this.LimpaTela();
                this.menuBotoes(1);

            }
        }

        private void txtNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNotaFiscal_Leave(object sender, EventArgs e)
        {

        }

        private void dtgvItensCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgvItensCompra.Columns["produtoValor"].Index ||
                e.ColumnIndex == dtgvItensCompra.Columns["produtoValorTotal"].Index)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }
        }

        private void txtCompraTotal_TextChanged(object sender, EventArgs e)
        {
            string valor = txtCompraTotal.Text.Replace("R$", "").Trim();

            if (decimal.TryParse(valor, out decimal valorDecimal))
            {
                txtCompraTotal.Text = valorDecimal.ToString("C2");
            }
        }
    }
}
