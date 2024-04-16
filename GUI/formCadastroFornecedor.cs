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
            // Verifica se o caractere digitado não é um dígito ou a tecla de backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            // Verifica se o comprimento atual do CNPJ corresponde a um ponto, barra ou traço
            if (txtCNPJ.Text.Length >= 18)
            {
                e.Handled = true;
            }

            // Verifica se o caractere digitado não é a tecla de backspace
            if (e.KeyChar != (char)8)
            {
                // Verifica o comprimento atual do CNPJ
                if (txtCNPJ.Text.Length == 2 || txtCNPJ.Text.Length == 6)
                {
                    // Insere um ponto após o bloco correspondente
                    txtCNPJ.Text = txtCNPJ.Text + ".";
                    // Move o cursor para após o ponto
                    txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1;
                }
                else if (txtCNPJ.Text.Length == 10)
                {
                    // Insere uma barra após o bloco correspondente
                    txtCNPJ.Text = txtCNPJ.Text + "/";
                    // Move o cursor para após a barra
                    txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1;
                }
                else if (txtCNPJ.Text.Length == 15)
                {
                    // Insere um traço após o último bloco
                    txtCNPJ.Text = txtCNPJ.Text + "-";
                    // Move o cursor para após o traço
                    txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1;
                }
            }
        }
        private void txtInscricaoEstadual_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um dígito ou a tecla de backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            // Verifica se o comprimento atual da inscrição estadual corresponde a um ponto ou traço
            if (txtInscricaoEstadual.Text.Length >= 18)
            {
                e.Handled = true;
            }

            // Verifica se o caractere digitado não é a tecla de backspace
            if (e.KeyChar != (char)8)
            {
                // Verifica o comprimento atual da inscrição estadual
                if (txtInscricaoEstadual.Text.Length == 3 || txtInscricaoEstadual.Text.Length == 7 || txtInscricaoEstadual.Text.Length == 11)
                {
                    // Insere um ponto após o bloco correspondente
                    txtInscricaoEstadual.Text = txtInscricaoEstadual.Text + ".";
                    // Move o cursor para após o ponto
                    txtInscricaoEstadual.SelectionStart = txtInscricaoEstadual.Text.Length + 1;
                }
                else if (txtInscricaoEstadual.Text.Length == 15)
                {
                    // Insere um traço após o último bloco
                    txtInscricaoEstadual.Text = txtInscricaoEstadual.Text + "-";
                    // Move o cursor para após o traço
                    txtInscricaoEstadual.SelectionStart = txtInscricaoEstadual.Text.Length + 1;
                }
            }
        }
        private void txtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um dígito ou a tecla de backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            // Verifica se o comprimento atual do número de telefone não ultrapassa o limite de 14 caracteres
            if (txtFone.Text.Length >= 14 && e.KeyChar != (char)8)
            {
                e.Handled = true;
                return; // Impede que outros blocos de código sejam executados se o limite for atingido
            }

            // Verifica se o caractere digitado não é a tecla de backspace
            if (e.KeyChar != (char)8)
            {
                // Verifica o comprimento atual do número de telefone
                if (txtFone.Text.Length == 0)
                {
                    // Insere o parêntese aberto no início do número
                    txtFone.Text = "(";
                    // Define o cursor para após o parêntese
                    txtFone.SelectionStart = txtFone.Text.Length + 1;
                }
                else if (txtFone.Text.Length == 3)
                {
                    // Insere o parêntese fechado após o DDD
                    txtFone.Text = txtFone.Text + ")";
                    // Move o cursor para após o parêntese fechado
                    txtFone.SelectionStart = txtFone.Text.Length + 1;
                }
                else if (txtFone.Text.Length == 8)
                {
                    // Insere o traço após os primeiros 4 dígitos do número
                    txtFone.Text = txtFone.Text + "-";
                    // Move o cursor para após o traço
                    txtFone.SelectionStart = txtFone.Text.Length + 1;
                }
            }
        }
        private void txtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEndNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
