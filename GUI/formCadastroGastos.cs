using BLL;
using DAL;
using Modelo;
using System.Globalization;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class formCadastroGastos : Form
    {
        private Random random = new Random();
        public String operacao;
        public formCadastroGastos()
        {
            InitializeComponent();
        }
        private void formCadastroGastos_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
        }
        public void LimpaTela()
        {
            txtValor.Clear();
            txtNomeProduto.Clear();
            txtDescricao.Clear();
        }
        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
            }

            if (op == 2)
            {
                panelDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                ModeloVenda modeloVenda = new ModeloVenda();
                txtVendaID.Text = modeloVenda.VendaID.ToString();
                modeloVenda.VendaGastoNome = txtNomeProduto.Text;
                modeloVenda.VendaData = DateTime.Now;
                modeloVenda.VendaNotaFiscal = random.Next(100000, 999999);
                modeloVenda.VendaDescricao = txtDescricao.Text;
                modeloVenda.VendaStatus = "Ativa";

                // Expressão regular para extrair apenas os dígitos e pontos decimais
                string valorTexto = Regex.Replace(txtValor.Text, @"[^\d,.]", "");

                // Converte o texto restante para um número com ponto flutuante (double)
                if (double.TryParse(valorTexto, NumberStyles.Currency, CultureInfo.CurrentCulture, out double valor))
                {
                    modeloVenda.VendaTotal = -1 * valor;
                }
                else
                {
                    throw new Exception("O valor do gasto não é válido.");
                }

                BLLVenda bll = new BLLVenda(cx);

                bll.IncluirGasto(modeloVenda);
                MessageBox.Show("Gasto inserido com sucesso!");

                this.LimpaTela();
                cx.TerminarTransacao();
                cx.Desconectar();
                this.menuBotoes(1);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
            this.LimpaTela();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.menuBotoes(2);
            this.operacao = "inserir";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.menuBotoes(1);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.Text = "0,00";
            }
            else
            {
                if (double.TryParse(txtValor.Text, out double valor))
                {
                    txtValor.Text = valor.ToString("C2");
                }
                else
                {
                    txtValor.Text = "0,00";
                }
            }
        }
    }
}
