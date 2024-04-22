using System.Data;
using BLL;
using DAL;
using Timer = System.Windows.Forms.Timer;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        AUsuario _usuario;
        private Timer timerVerificarEstoque;
        private Timer timerEsconderBemVindo;
        private void TimerVerificarEstoque_Tick(object sender, EventArgs e)
        {
            VerificarEstoqueBaixo();
        }



        private void VerificarEstoqueBaixo()
        {
            BLLProduto bllProduto = new BLLProduto(new DALConexao(DadosDaConexao.StringDeConexao));

            DataTable produtos = bllProduto.LocalizarProdutoFaltante("");
            lblProdutosFaltantes.Text = "";
            foreach (DataRow produto in produtos.Rows)
            {
                string nomeProduto = produto["produto_nome"].ToString();
                float qtde = Convert.ToSingle(produto["produto_qtde"]);
                lblProdutosFaltantes.Text += $"O produto '{nomeProduto}' está com estoque baixo ({qtde} unidades).";
            }
        }
        private void TimerEsconderBemVindo_Tick(object sender, EventArgs e)
        {
            lblBemVindo.Text = "";
            timerEsconderBemVindo.Stop();
        }

        private void ConfigurarControles()
        {
            lblBemVindo.Text = "Bem-vindo, " + _usuario.Nome + "!";
            lblUsuarioAtual.Text = "Usuário logado: " + _usuario.Nome + " (" + _usuario.NivelAcesso + ")";
            lblUsuarioAtual.AutoSize = true;

            VendaToolStripMenuItem.Enabled = _usuario.NivelAcesso2._formVendaAcesso;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            VerificarEstoqueBaixo();
            timerVerificarEstoque.Start();
        }
        public FormPrincipal(AUsuario usuario)
        {
            InitializeComponent();
            this._usuario = usuario;
            VendaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formVendaAcesso;
            cadastroCategoriaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroCategoriaAcesso;
            cadastroFornecedorToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formcadastroFornecedorAcesso;
            cadastroProdutoToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formcadastroProdutoAcesso;
            cadastroSubCategoriaToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formcadastroSubCategoriaAcesso;
            cadastroTipoDePagamentoToolStripMenuItem3.Enabled = usuario.NivelAcesso2._formcadastroTipoDePagamentoAcesso;
            cadastroUnidadeDeMedidaToolStripMenuItem5.Enabled = usuario.NivelAcesso2._formcadastroUnidadeMedidaAcesso;
            cadastroUsuarioToolStripMenuItem4.Enabled = usuario.NivelAcesso2._formcadastroUsuarioAcesso;
            compraToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcompraAcesso;
            consultaCategoriaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaCategoriaAcesso;
            consultaFornecedorToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaFornecedorAcesso;
            consultaProdutoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formconsultaProdutoAcesso;
            consultaSubCategoriaToolStripMenuItem4.Enabled = usuario.NivelAcesso2._formconsultaSubCategoriaAcesso;
            consultaTipoDePagamentoToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formconsultaTipoDePagamentoAcesso;
            consultaUnidadeDeMedidaToolStripMenuItem5.Enabled = usuario.NivelAcesso2._formconsultaUnidadeMedidaAcesso;
            consultaUsuarioToolStripMenuItem3.Enabled = usuario.NivelAcesso2._formconsultaUsuarioAcesso;
            consultaCompraToolStripMenuItem.Enabled = usuario.NivelAcesso2._formConsultaCompraAcesso;
            vendaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formConsultaVendaAcesso;
            pagamentoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formPagamentoAcesso;
            rEcebimentoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formRecebimentoAcesso;
            relatorioCompraToolStripMenuItem.Enabled = usuario.NivelAcesso2._formRelatorioCompraAcesso;
            relatorioFornecedorToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formRelatorioFornecedorAcesso;
            relatorioProdutoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formRelatorioProdutoAcesso;
            relatorioUsuarioToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formRelatorioUsuarioAcesso;
            consultaClienteToolStripMenuItem4.Enabled = usuario.NivelAcesso2._formConsultaClienteAcesso;
            cadastroClienteToolStripMenuItem5.Enabled = usuario.NivelAcesso2._formcadastroClienteAcesso;
            relatorioClienteToolStripMenuItem3.Enabled = usuario.NivelAcesso2._formRelatorioClienteAcesso;
            relatorioVendaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formVendaAcesso;

            this._usuario = usuario;
            ConfigurarControles();
            timerEsconderBemVindo = new Timer();
            timerEsconderBemVindo.Interval = 60000;
            timerEsconderBemVindo.Tick += TimerEsconderBemVindo_Tick;
            timerEsconderBemVindo.Start();

            lblUsuarioAtual.Text = "Usuário logado: " + _usuario.Nome + " (" + _usuario.NivelAcesso + ")";
            lblUsuarioAtual.AutoSize = true;

            lblProdutosFaltantes.AutoSize = true;

            timerVerificarEstoque = new Timer();
            timerVerificarEstoque.Interval = 24 * 60 * 60 * 1000;
            timerVerificarEstoque.Tick += TimerVerificarEstoque_Tick;
            timerVerificarEstoque.Start();

        }


        private void cadastroClienteToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void consultaClienteToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void relatórioClienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formRelatorioCliente f = new formRelatorioCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroFornecedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formCadastroFornecedor f = new formCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaFornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaFornecedor f = new formConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatorioFornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formRelatorioFornecedor f = new formRelatorioFornecedor();
            f.ShowDialog();
            f.Dispose();
        }
        private void cadastroProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCadastroProduto f = new formCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultaProduto f = new formConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }
        private void relatórioProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioProduto f = new formRelatorioProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroCategoria f = new formCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaCategoria f = new formConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroSubCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formCadastroSubCategoria f = new formCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaSubCategoriaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            formConsultaSubCategoria f = new formConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroUnidadeDeMedidaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            formCadastroUnidadeMedida f = new formCadastroUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaUnidadeDeMedidaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            formConsultaUnidadeMedida f = new formConsultaUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroTipoDePagamentoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formCadastroTipoPagamento f = new formCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }
        private void consultaTipoDePagamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formConsultaTipoPagamento f = new formConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroUsuarioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            formCadastroUsuario f = new formCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaUsuarioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formConsultaUsuario f = new formConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatórioUsuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formRelatorioUsuario f = new formRelatorioUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            formVenda f = new formVenda();
            f.ShowDialog();
            f.Dispose();
        }
        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVenda f = new formVenda();
            f.ShowDialog();
            f.Dispose();
        }
        private void consultaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultaVenda f = new formConsultaVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatórioVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioVenda f = new formRelatorioVenda();
            f.ShowDialog();
            f.Dispose();
        }
        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPagamentoCompra f = new formPagamentoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void rEcebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRecebimentoVenda f = new formRecebimentoVenda();
            f.ShowDialog();
            f.Dispose();
        }
        private void SairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Abre o formulário de login ao sair
            formLogin f = new formLogin();
            f.Show();
        }
        private void cadastroCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCompra f = new formCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultaCompra f = new formConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatorioCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioCompra f = new formRelatorioCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroGastos f = new formCadastroGastos();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioGastos f = new formRelatorioGastos();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
