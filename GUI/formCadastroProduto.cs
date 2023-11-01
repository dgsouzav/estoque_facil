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
    public partial class formCadastroProduto : Form
    {
        public formCadastroProduto()
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
            }
        }

        public void LimpaTela()
        {
            txtProdutoID.Clear();
            txtNomeProduto.Clear();
            txtDescricaoProduto.Clear();
            txtValorPagoProduto.Clear();
            txtValorVendaProduto.Clear();
            txtQtdeProduto.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.menuBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            formConsultaProduto f = new formConsultaProduto();
            f.ShowDialog();
            if (f.id != 0)
            {
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.id);
                txtProdutoID.Text = modelo.ProdutoID.ToString();
                txtNomeProduto.Text = modelo.ProdutoNome;
                txtDescricaoProduto.Text = modelo.ProdutoDescricao;
                txtValorPagoProduto.Text = modelo.ProdutoValorPago.ToString();
                txtValorVendaProduto.Text = modelo.ProdutoValorVenda.ToString();
                txtQtdeProduto.Text = modelo.ProdutoQtde.ToString();
                cmbCategoriaID.SelectedValue = modelo.CategoriaID;
                cmbSubCategoriaID.SelectedValue = modelo.SubCategoriaID;
                cmbUndMedID.SelectedValue = modelo.UndMedID;
                //cbFornecedor.SelectedValue = modelo.FornecedorID;
                this.menuBotoes(3);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.menuBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProdutoNome = txtNomeProduto.Text;
                modelo.ProdutoDescricao = txtDescricaoProduto.Text;
                modelo.ProdutoValorPago = Convert.ToDouble(txtValorPagoProduto.Text);
                modelo.ProdutoValorVenda = Convert.ToDouble(txtValorVendaProduto.Text);
                modelo.ProdutoQtde = Convert.ToInt32(txtQtdeProduto.Text);
                modelo.CategoriaID = Convert.ToInt32(cmbCategoriaID.SelectedValue);
                modelo.SubCategoriaID = Convert.ToInt32(cmbSubCategoriaID.SelectedValue);
                modelo.UndMedID = Convert.ToInt32(cmbUndMedID.SelectedValue);
                //modelo.FornecedorID = Convert.ToInt32(cbFornecedor.SelectedValue);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! Código: " + modelo.CategoriaID.ToString());
                }
                else
                {
                    modelo.ProdutoID = Convert.ToInt32(txtProdutoID.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                this.LimpaTela();
                this.menuBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.menuBotoes(1);
        }

        private void formCadastroProduto_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cmbCategoriaID.DataSource = bll.Localizar("");
            cmbCategoriaID.DisplayMember = "nome_categoria";
            cmbCategoriaID.ValueMember = "categoria_id";

            BLLSubCategoria bll2 = new BLLSubCategoria(cx);
            cmbSubCategoriaID.DataSource = bll2.LocalizarPorCategoria((int) cmbCategoriaID.SelectedValue);
            cmbSubCategoriaID.DisplayMember = "subCategoria_nome";
            cmbSubCategoriaID.ValueMember = "subCategoria_id";

            BLLUnidadeMedida bll3 = new BLLUnidadeMedida(cx);
            cmbUndMedID.DataSource = bll3.Localizar("");
            cmbUndMedID.DisplayMember = "undmed_nome";
            cmbUndMedID.ValueMember = "undmed_id";

            //BLLFornecedor bll4 = new BLLFornecedor(cx);
            //cmbFornecedor.DataSource = bll4.Localizar("");
            //cmbFornecedor.DisplayMember = "nome_fornecedor";
            //cmbFornecedor.ValueMember = "fornecedor_id";
        }

        private void txtValorVendaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtValorVendaProduto.Text.Contains(",") || txtValorVendaProduto.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = ',';
                }
            }
        }

        private void txtValorPagoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtValorPagoProduto.Text.Contains(",") || txtValorPagoProduto.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = ',';
                }
            }
        }
        private void txtQtdeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtQtdeProduto.Text.Contains(",") || txtQtdeProduto.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = ',';
                }
            }
        }

        private void txtValorVendaProduto_Leave(object sender, EventArgs e)
        {
            if (txtValorVendaProduto.Text.Contains('.') == false)
            {
                txtValorVendaProduto.Text += ".00";
            }
            else
            {
                if (txtValorVendaProduto.Text.IndexOf('.') == txtValorVendaProduto.Text.Length - 1)
                {
                    txtValorVendaProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVendaProduto.Text);
            }
            catch
            {
                txtValorVendaProduto.Text = "0.00";
            }

        }

        private void txtValorPagoProduto_Leave(object sender, EventArgs e)
        {
            if (txtValorPagoProduto.Text.Contains('.') == false)
            {
                txtValorPagoProduto.Text += ".00";
            }
            else
            {
                if (txtValorPagoProduto.Text.IndexOf('.') == txtValorPagoProduto.Text.Length - 1)
                {
                    txtValorPagoProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPagoProduto.Text);
            }
            catch
            {
                txtValorPagoProduto.Text = "0.00";
            }
        }

        private void txtQtdeProduto_Leave(object sender, EventArgs e)
        {
            if (txtQtdeProduto.Text.Contains('.') == false)
            {
                txtQtdeProduto.Text += ".00";
            }
            else
            {
                if (txtQtdeProduto.Text.IndexOf('.') == txtQtdeProduto.Text.Length - 1)
                {
                    txtQtdeProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtQtdeProduto.Text);
            }
            catch
            {
                txtQtdeProduto.Text = "0.00";
            }
        }


    }
}
