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
using Validacoes;

namespace UI
{
    public partial class formCadastroCliente : Form
    {
        public formCadastroCliente()
        {
            InitializeComponent();
        }

        private void formCadastroCliente_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
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
            txtFornecedorID.Clear();
            txtNomeFornecedor.Clear();
            txtCEP.Clear();
            txtEnderecoFornecedor.Clear();
            txtBairro.Clear();
            txtFone.Clear();
            txtEmail.Clear();
            txtEndNumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.menuBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            formConsultaCliente f = new formConsultaCliente();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.id);
                txtFornecedorID.Text = modelo.ClienteID.ToString();
                txtNomeFornecedor.Text = modelo.ClienteNome;
                txtCEP.Text = modelo.ClienteCEP;
                txtEnderecoFornecedor.Text = modelo.ClienteEndereco;
                txtBairro.Text = modelo.ClienteBairro;
                txtFone.Text = modelo.ClienteFone;
                txtEmail.Text = modelo.ClienteEmail;
                txtEndNumero.Text = modelo.ClienteEndNumero;
                txtCidade.Text = modelo.ClienteCidade;
                txtEstado.Text = modelo.ClienteEstado;

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
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = new ModeloCliente();
                modelo.ClienteNome = txtNomeFornecedor.Text;
                modelo.ClienteCEP = txtCEP.Text;
                modelo.ClienteEndereco = txtEnderecoFornecedor.Text;
                modelo.ClienteBairro = txtBairro.Text;
                modelo.ClienteFone = txtFone.Text;
                modelo.ClienteEmail = txtEmail.Text;
                modelo.ClienteEndNumero = txtEndNumero.Text;
                modelo.ClienteCidade = txtCidade.Text;
                modelo.ClienteEstado = txtEstado.Text;

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! Código: " + modelo.ClienteID.ToString());
                }
                else
                {
                    modelo.ClienteID = Convert.ToInt32(txtFornecedorID.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }

                this.LimpaTela();
                this.menuBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cadastro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.menuBotoes(1);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (ValidaCEPCNPJ.verificaCEP(txtCEP.Text) == true)
            {
                txtEnderecoFornecedor.Text = ValidaCEPCNPJ.endereco;
                txtBairro.Text = ValidaCEPCNPJ.bairro;
                txtCidade.Text = ValidaCEPCNPJ.cidade;
                txtEstado.Text = ValidaCEPCNPJ.estado;
            }
            else
            {
                txtEnderecoFornecedor.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
        }

        private void txtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (txtFone.Text.Length >= 14 && e.KeyChar != (char)8)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar != (char)8)
            {
                if (txtFone.Text.Length == 0)
                {
                    txtFone.Text = "(";
                    txtFone.SelectionStart = txtFone.Text.Length + 1;
                }
                else if (txtFone.Text.Length == 3)
                {
                    txtFone.Text = txtFone.Text + ")";
                    txtFone.SelectionStart = txtFone.Text.Length + 1;
                }
                else if (txtFone.Text.Length == 8)
                {
                    txtFone.Text = txtFone.Text + "-";
                    txtFone.SelectionStart = txtFone.Text.Length + 1;
                }
            }
        }
    }
}
