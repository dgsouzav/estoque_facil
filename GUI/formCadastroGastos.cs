using BLL;
using DAL;
using Modelo;

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
            cmbNumeroParcelas.SelectedIndex = -1;
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
                modeloVenda.VendaNumeroParcelas = Convert.ToInt32(cmbNumeroParcelas.Text);
                modeloVenda.VendaDescricao = txtDescricao.Text;
                modeloVenda.VendaStatus = "Ativa";

                // Convertendo o valor para negativo antes de atribuir à propriedade VendaTotal
                modeloVenda.VendaTotal = -1 * Convert.ToInt32(txtValor.Text);

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
    }
}
