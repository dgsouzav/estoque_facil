using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        AUsuario _usuario;

        public FormPrincipal(AUsuario usuario)
        {
            InitializeComponent();
            this._usuario = usuario;
            VendaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formVendaAcesso;
            CategoriaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroCategoriaAcesso;
            FornecedorToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroFornecedorAcesso;
            ProdutoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroProdutoAcesso;
            SubCategoriaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroSubCategoriaAcesso;
            TipoPagamentoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroTipoDePagamentoAcesso;
            UnidadeMedidaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroUnidadeMedidaAcesso;
            UsuarioToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroUsuarioAcesso;
            CompraToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcompraAcesso;
            CategoriaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaCategoriaAcesso;
            FornecedorToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaFornecedorAcesso;
            ProdutoToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaProdutoAcesso;
            SubCategoriaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaSubCategoriaAcesso;
            tIPODEPAGAMENTOToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaTipoDePagamentoAcesso;
            UnidadeMedidaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaUnidadeMedidaAcesso;
            UsuarioToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formconsultaUsuarioAcesso;
            compraToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formConsultaCompraAcesso;
            vendaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formConsultaVendaAcesso;
            relatóriosDeVendaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formRelatorioAcesso;
            pagamentoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formPagamentoAcesso;
            rEcebimentoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formRecebimentoAcesso;

            lblUsuarioAtual.Text = "Usuário logado: " + _usuario.Nome;
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroCategoria f = new formCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void CategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaCategoria f = new formConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void SubCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroSubCategoria f = new formCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void SubCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaSubCategoria f = new formConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void UnidadeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroUnidadeMedida f = new formCadastroUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void UnidadeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaUnidadeMedida f = new formConsultaUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroProduto f = new formCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void ProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaProduto f = new formConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroFornecedor f = new formCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void FornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaFornecedor f = new formConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroUsuario f = new formCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }
        private void UsuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formConsultaUsuario f = new formConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void CompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCompra f = new formCompra();
            f.ShowDialog();
            f.Dispose();
        }
        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaCompra f = new formConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVenda f = new formVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaVenda f = new formConsultaVenda();
            f.ShowDialog();
            f.Dispose();
        }
        private void TipoPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroTipoPagamento f = new formCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void TipoPagamentoToolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            formConsultaTipoPagamento f = new formConsultaTipoPagamento();
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

        private void relatóriosDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorios f = new formRelatorios();
            f.ShowDialog();
            f.Dispose();
        }
        private void SairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

            formLogin f = new formLogin();
            f.Show();
            MessageBox.Show("Você foi desconectado.");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo, " + _usuario.Nome + "!");
        }
    }
}
