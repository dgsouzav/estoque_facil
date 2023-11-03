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
    public partial class formCadastroTipoPagamento : Form
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
            txtTipoPagamentoID.Clear();
            txtNomeTipoPagamento.Clear();
        }
        public formCadastroTipoPagamento()
        {
            InitializeComponent();
        }

        private void formCadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.menuBotoes(2);
            this.operacao = "inserir";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            formConsultaTipoPagamento f = new formConsultaTipoPagamento();
            f.ShowDialog();
            if (f.id != 0)
            {
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                ModeloTipoPagamento modelo = bll.CarregaModeloTipoPagamento(f.id);
                txtTipoPagamentoID.Text = modelo.TipoPagamentoID.ToString();
                txtNomeTipoPagamento.Text = modelo.TipoPagamentoNome;
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
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                ModeloTipoPagamento modelo = new ModeloTipoPagamento();
                modelo.TipoPagamentoNome = txtNomeTipoPagamento.Text;

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.TipoPagamentoID.ToString());
                }
                else
                {
                    modelo.TipoPagamentoID = Convert.ToInt32(txtTipoPagamentoID.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
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
            this.LimpaTela();
            this.menuBotoes(1);
        }

        private void formCadastroTipoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }
    }
}
