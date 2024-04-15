using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class formCadastroUsuario : Form
    {
        public String operacao;
        public formCadastroUsuario()
        {
            InitializeComponent();
        }

        private void formCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.cmbNivelAcesso.Items.Add("Administrador");
            this.cmbNivelAcesso.Items.Add("Gerente");
            this.cmbNivelAcesso.Items.Add("Vendedor");
            this.cmbNivelAcesso.SelectedIndex = 0;
            this.menuBotoes(1);
        }
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
            txtNome.Clear();
            txtSenha.Clear();
            cmbNivelAcesso.SelectedIndex = 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.menuBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            formConsultaUsuario f = new formConsultaUsuario();
            f.ShowDialog();
            if (f.id != 0)
            {
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.id);

                txtUsuarioID.Text = modelo.UsuarioID.ToString();
                txtNome.Text = modelo.UsuarioNome.ToString();

                // Verifica se o valor do modelo.UsuarioNivelAcesso é uma string válida
                string nivelAcesso = modelo.UsuarioNivelAcesso.ToString();
                if (cmbNivelAcesso.Items.Contains(nivelAcesso))
                {
                    cmbNivelAcesso.SelectedItem = nivelAcesso;
                }
                else
                {
                    // Se o valor não for válido, mostra uma mensagem de erro
                    MessageBox.Show("Nível de acesso inválido: " + nivelAcesso);
                    // Limpa o ComboBox
                    cmbNivelAcesso.SelectedIndex = -1;
                }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.menuBotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuarioNome = txtNome.Text.ToUpper();
                modelo.UsuarioSenha = DALUsuario.CriptografarSenha(txtSenha.Text);

                if (cmbNivelAcesso.SelectedItem != null)
                {
                    modelo.UsuarioNivelAcesso = cmbNivelAcesso.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione um nível de acesso.");
                    return;
                }

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.UsuarioID.ToString());
                }
                else
                {
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            this.LimpaTela();
            this.menuBotoes(1);
        }


    }
}
