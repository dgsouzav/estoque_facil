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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{

    public partial class formLogin : Form
    {
        FormPrincipal painel;
        public formLogin()
        {
            InitializeComponent();
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 14;
        }

        public void LimpaTela()
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtLogin.Text;
            string senha = txtSenha.Text;

            DALConexao dALConexao = new DALConexao(DadosDaConexao.StringDeConexao);
            DALUsuario dALUsuario = new DALUsuario(dALConexao);

            string acesso = dALUsuario.Autenticar(nome, senha).Normalize().ToUpper();

            if (!string.IsNullOrEmpty(acesso))
            {
                AUsuario? usuario;
                switch (acesso)
                {
                    case "VENDEDOR":
                        usuario = new Vendedor(nome, acesso);
                        break;
                    case "GERENTE":
                        usuario = new Gerente(nome, acesso);
                        break;
                    case "ADMINISTRADOR":
                        usuario = new Administrador(nome, acesso);
                        break;
                    default:
                        MessageBox.Show("Nível de acesso inválido");
                        return;
                }

                FormPrincipal formPrincipal = new FormPrincipal(usuario);
                formPrincipal.ShowDialog();
                this.LimpaTela();
            }
            else
            {
                MessageBox.Show("Acesso negado. Verifique seu nome de usuário e senha.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
