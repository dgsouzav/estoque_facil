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
            txtLoteProduto.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.menuBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            formConsultaProduto f = new formConsultaProduto();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLL.BLLProduto bll = new BLL.BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.id);
                txtProdutoID.Text = modelo.ProdutoID.ToString();
                txtNomeProduto.Text = modelo.ProdutoNome;
                txtDescricaoProduto.Text = modelo.ProdutoDescricao;
                txtValorPagoProduto.Text = modelo.ProdutoValorPago.ToString();
                txtValorVendaProduto.Text = modelo.ProdutoValorVenda.ToString();
                txtLoteProduto.Text = modelo.ProdutoLote.ToString();
                cmbUndMedID.SelectedValue = modelo.UndMedID;
                cmbCategoriaID.SelectedValue = modelo.CategoriaID;
                cmbSubCategoriaID.SelectedValue = modelo.SubCategoriaID;

                this.menuBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.menuBotoes(1);
            }
            f.Dispose();
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
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProdutoNome = txtNomeProduto.Text;
                modelo.ProdutoDescricao = txtDescricaoProduto.Text;
                modelo.ProdutoLote = Convert.ToDouble(txtLoteProduto.Text);
                modelo.ProdutoValorPago = Convert.ToDouble(txtValorPagoProduto.Text);
                modelo.ProdutoValorVenda = Convert.ToDouble(txtValorVendaProduto.Text);
                modelo.UndMedID = Convert.ToInt32(cmbUndMedID.SelectedValue);
                modelo.CategoriaID = Convert.ToInt32(cmbCategoriaID.SelectedValue);
                modelo.SubCategoriaID = Convert.ToInt32(cmbSubCategoriaID.SelectedValue);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! \nCódigo: " + modelo.ProdutoID.ToString());
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

            try
            {
                BLLSubCategoria bll2 = new BLLSubCategoria(cx);
                cmbSubCategoriaID.DataSource = bll2.LocalizarPorCategoria((int)cmbCategoriaID.SelectedValue);
                cmbSubCategoriaID.DisplayMember = "subCategoria_nome";
                cmbSubCategoriaID.ValueMember = "subCategoria_id";
            }
            catch
            { }

            BLLUnidadeMedida bll3 = new BLLUnidadeMedida(cx);
            cmbUndMedID.DataSource = bll3.Localizar("");
            cmbUndMedID.DisplayMember = "undmed_nome";
            cmbUndMedID.ValueMember = "undmed_id";
        }

        private void txtValorPagoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPagoProduto.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPagoProduto_Leave(object sender, EventArgs e)
        {
            if (txtValorPagoProduto.Text.Contains(",") == false)
            {
                txtValorPagoProduto.Text += ",00";
            }
            else
            {
                if (txtValorPagoProduto.Text.IndexOf(",") == txtValorPagoProduto.Text.Length-1)
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
                txtValorPagoProduto.Text = "0,00";
            }
        }

        private void txtValorVendaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVendaProduto.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorVendaProduto_Leave(object sender, EventArgs e)
        {
            if (txtValorVendaProduto.Text.Contains(",") == false)
            {
                txtValorVendaProduto.Text += ",00";
            }
            else
            {
                if (txtValorVendaProduto.Text.IndexOf(",") == txtValorVendaProduto.Text.Length - 1)
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
                txtValorVendaProduto.Text = "0,00";
            }
        }

        private void txtQtdeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtLoteProduto.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtQtdeProduto_Leave(object sender, EventArgs e)
        {
            if (txtLoteProduto.Text.Contains(",") == false)
            {
                txtLoteProduto.Text += ",00";
            }
            else
            {
                if (txtLoteProduto.Text.IndexOf(",") == txtLoteProduto.Text.Length - 1)
                {
                    txtLoteProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtLoteProduto.Text);
            }
            catch
            {
                txtLoteProduto.Text = "0,00";
            }
        }

        private void cmbCategoriaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                cmbSubCategoriaID.Text = "";
                BLLSubCategoria bll2 = new BLLSubCategoria(cx);
                cmbSubCategoriaID.DataSource = bll2.LocalizarPorCategoria((int)cmbCategoriaID.SelectedValue);
                cmbSubCategoriaID.DisplayMember = "subCategoria_nome";
                cmbSubCategoriaID.ValueMember = "subCategoria_id";
            }
            catch { }
        }
    }
}
