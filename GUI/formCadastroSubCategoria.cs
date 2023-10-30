using DAL;
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
    public partial class formCadastroSubCategoria : Form
    {
        public String operacao;
        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
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
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            txtSubCategoriaID.Clear();
            txtNomeSubCategoria.Clear();
        }
        public formCadastroSubCategoria()
        {
            InitializeComponent();
        }

        private void formCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLL.BLLCategoria bll = new BLL.BLLCategoria(cx);
            cmbCategoriaID.DataSource = bll.Localizar("");
            cmbCategoriaID.DisplayMember = "nome_categoria";
            cmbCategoriaID.ValueMember = "categoria_id";
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.menuBotoes(2);
            this.operacao = "inserir";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            formConsultaSubCategoria f = new formConsultaSubCategoria();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLL.BLLSubCategoria bll = new BLL.BLLSubCategoria(cx);
                Modelo.ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.id);
                txtSubCategoriaID.Text = modelo.SubCategoriaID.ToString();
                txtNomeSubCategoria.Text = modelo.SubCategoriaNome;
                cmbCategoriaID.SelectedValue = modelo.CategoriaID;
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
            menuBotoes(2);
            operacao = "alterar";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLL.BLLSubCategoria bll = new BLL.BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtSubCategoriaID.Text));
                    this.LimpaTela();
                    this.menuBotoes(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.menuBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.ModeloSubCategoria modelo = new Modelo.ModeloSubCategoria();
                modelo.SubCategoriaNome = txtNomeSubCategoria.Text;
                modelo.CategoriaID = Convert.ToInt32(cmbCategoriaID.SelectedValue);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLL.BLLSubCategoria bll = new BLL.BLLSubCategoria(cx);

                if (operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! Código: " + modelo.SubCategoriaID.ToString());
                }
                else
                {
                    modelo.SubCategoriaID = Convert.ToInt32(txtSubCategoriaID.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                this.LimpaTela();
                this.menuBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            this.LimpaTela();
        }

        private void formCadastroSubCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }
    }
}
