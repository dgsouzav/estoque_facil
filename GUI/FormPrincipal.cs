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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
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

        private void tIPODEPAGAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroTipoPagamento f = new formCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void tIPODEPAGAMENTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void SairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // fechar fomulario principal ao clicar em sair e depois abir o formulario de login
            formLogin f = new formLogin();
            f.ShowDialog();
            f.Dispose();
        }

        private void CompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCompra f = new formCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaCompra f = new formConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void TipoPagamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formConsultaTipoPagamento f = new formConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
