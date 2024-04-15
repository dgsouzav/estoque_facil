using BLL;
using DAL;
using Modelo;
using System.Text.RegularExpressions;
using Validacoes;

namespace UI
{
    public partial class formCadastroFornecedor : Form
    {
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
            txtCNPJ.Clear();
            txtInscricaoEstadual.Clear();
            txtRazaoSocial.Clear();
            txtCEP.Clear();
            txtEnderecoFornecedor.Clear();
            txtBairro.Clear();
            txtFone.Clear();
            txtEmail.Clear();
            txtEndNumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }
        public formCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.menuBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            formConsultaFornecedor f = new formConsultaFornecedor();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.id);
                txtFornecedorID.Text = modelo.FornecedorID.ToString();
                txtNomeFornecedor.Text = modelo.FornecedorNome;
                txtCNPJ.Text = modelo.FornecedorCNPJ;
                txtInscricaoEstadual.Text = modelo.FornecedorInscricaoEstadual;
                txtRazaoSocial.Text = modelo.FornecedorRazaoSocial;
                txtCEP.Text = modelo.FornecedorCEP;
                txtEnderecoFornecedor.Text = modelo.FornecedorEndereco;
                txtBairro.Text = modelo.FornecedorBairro;
                txtFone.Text = modelo.FornecedorFone;
                txtEmail.Text = modelo.FornecedorEmail;
                txtEndNumero.Text = modelo.FornecedorEndNumero;
                txtCidade.Text = modelo.FornecedorCidade;
                txtEstado.Text = modelo.FornecedorEstado;

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
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.FornecedorNome = txtNomeFornecedor.Text;
                modelo.FornecedorCNPJ = txtCNPJ.Text;
                modelo.FornecedorInscricaoEstadual = txtInscricaoEstadual.Text;
                modelo.FornecedorRazaoSocial = txtRazaoSocial.Text;
                modelo.FornecedorCEP = txtCEP.Text;
                modelo.FornecedorEndereco = txtEnderecoFornecedor.Text;
                modelo.FornecedorBairro = txtBairro.Text;
                modelo.FornecedorFone = txtFone.Text;
                modelo.FornecedorEmail = txtEmail.Text;
                modelo.FornecedorEndNumero = txtEndNumero.Text;
                modelo.FornecedorCidade = txtCidade.Text;
                modelo.FornecedorEstado = txtEstado.Text;

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! Código: " + modelo.FornecedorID.ToString());
                }
                else
                {
                    modelo.FornecedorID = Convert.ToInt32(txtFornecedorID.Text);
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

        private void formCadastroFornecedor_Load(object sender, EventArgs e)
        {
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

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (ValidaCEPCNPJ.verificaCNPJ(txtCNPJ.Text) == true)
            {
                txtRazaoSocial.Text = ValidaCEPCNPJ.razao;
            }
            else
            {
                txtRazaoSocial.Clear();
            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (txtCNPJ.Text.Length == 2 || txtCNPJ.Text.Length == 6 || txtCNPJ.Text.Length == 10 || txtCNPJ.Text.Length == 15)
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)8)
            {
                if (txtCNPJ.Text.Length == 2 || txtCNPJ.Text.Length == 6)
                {
                    txtCNPJ.Text = txtCNPJ.Text + ".";
                    txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1;
                }
                else if (txtCNPJ.Text.Length == 10)
                {
                    txtCNPJ.Text = txtCNPJ.Text + "/";
                    txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1;
                }
                else if (txtCNPJ.Text.Length == 15)
                {
                    txtCNPJ.Text = txtCNPJ.Text + "-";
                    txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1;
                }
            }
        }

        private void txtInscricaoEstadual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (txtInscricaoEstadual.Text.Length == 3 || txtInscricaoEstadual.Text.Length == 7 || txtInscricaoEstadual.Text.Length == 11 || txtInscricaoEstadual.Text.Length == 15)
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)8)
            {
                if (txtInscricaoEstadual.Text.Length == 3 || txtInscricaoEstadual.Text.Length == 7 || txtInscricaoEstadual.Text.Length == 11)
                {
                    txtInscricaoEstadual.Text = txtInscricaoEstadual.Text + ".";
                    txtInscricaoEstadual.SelectionStart = txtInscricaoEstadual.Text.Length + 1;
                }
                else if (txtInscricaoEstadual.Text.Length == 15)
                {
                    txtInscricaoEstadual.Text = txtInscricaoEstadual.Text + "-";
                    txtInscricaoEstadual.SelectionStart = txtInscricaoEstadual.Text.Length + 1;
                }
            }
        }


        private void txtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
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
                else if (txtFone.Text.Length == 9)
                {
                    txtFone.Text = txtFone.Text + "-";
                    txtFone.SelectionStart = txtFone.Text.Length + 1;
                }
                else if (txtFone.Text.Length == 14)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
