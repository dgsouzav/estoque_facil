using BLL;
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
    public partial class formConsultaTipoPagamento : Form
    {
        public int id = 0;
        public formConsultaTipoPagamento()
        {
            InitializeComponent();
        }

        private void formConsultaTipoPagamento_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dtgvDados.Columns[0].HeaderText = "ID";
            dtgvDados.Columns[0].Width = 60;
            dtgvDados.Columns[1].HeaderText = "Tipo de Pagamento";
            dtgvDados.Columns[1].Width = 557;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            dtgvDados.DataSource = bll.Localizar(txtConsultaTipoPagamento.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                    bll.Excluir(Convert.ToInt32(dtgvDados.Rows[dtgvDados.CurrentRow.Index].Cells[0].Value));
                    MessageBox.Show("Registro excluído com sucesso!");
                    btnLocalizar_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("ERRO: \nO registro está sendo utilizado em outro local.");
            }
        }

        private void dtgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.id = Convert.ToInt32(dtgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
