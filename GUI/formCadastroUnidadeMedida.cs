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
    public partial class formCadastroUnidadeMedida : Form
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
        public void limpaTela()
        {
            txtUnidadeMedidaID.Clear();
            txtNomeUnidadeMedida.Clear();
        }
        public formCadastroUnidadeMedida()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.menuBotoes(2);
        }

        private void formCadastroUnidadeMedida_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            formConsultaUnidadeMedida f = new formConsultaUnidadeMedida();
            f.ShowDialog();
            if (f.id != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(f.id);
                txtUnidadeMedidaID.Text = modelo.UndMedID.ToString();
                txtNomeUnidadeMedida.Text = modelo.UndMedNome;
                this.menuBotoes(3);
            }
            else
            {
                this.limpaTela();
                this.menuBotoes(1);
            }
            f.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.menuBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
                modelo.UndMedNome = txtNomeUnidadeMedida.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! Código: " + modelo.UndMedID.ToString());
                }
                else
                {
                    modelo.UndMedID = Convert.ToInt32(txtUnidadeMedidaID.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                this.limpaTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            this.menuBotoes(1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpaTela();
            this.menuBotoes(1);
        }

        private void txtNomeUnidadeMedida_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int resultado = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                resultado = bll.VerificaUnidadeMedida(txtNomeUnidadeMedida.Text);
                if (resultado > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com esse valor. Deseja alterar o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(resultado);
                        txtUnidadeMedidaID.Text = modelo.UndMedID.ToString();
                        txtNomeUnidadeMedida.Text = modelo.UndMedNome;
                        this.menuBotoes(3);
                    }
                    else
                    {
                        this.limpaTela();
                        this.menuBotoes(1);
                    }
                }
            }
        }

        private void formCadastroUnidadeMedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }
    }
}
