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
    public partial class formCadastroUsuario : Form
    {
        // predefinir 3 níveis de acesso: Administrador, Caixa e Vendedor
        // Administrador: acesso total
        // Caixa: acesso a vendas, compras e relatórios
        // Vendedor: acesso a vendas
        // o nível de acesso é definido no cadastro de usuário
        public formCadastroUsuario()
        {
            InitializeComponent();
        }

        private void formCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.cmbNivelAcesso.Items.Add("Administrador");
            this.cmbNivelAcesso.Items.Add("Caixa");
            this.cmbNivelAcesso.Items.Add("Vendedor");
            this.cmbNivelAcesso.SelectedIndex = 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
