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

    public partial class formConsultaUnidadeMedida : Form
    {
        public int id = 0;
        public formConsultaUnidadeMedida()
        {
            InitializeComponent();
        }

        private void formConsultaUnidadeMedida_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dtgvDados.Columns[0].HeaderText = "ID";
            dtgvDados.Columns[0].Width = 50;
            dtgvDados.Columns[1].HeaderText = "Unidade de Medida";
            dtgvDados.Columns[1].Width = 300;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
            dtgvDados.DataSource = bll.Localizar(txtConsultaUnidadeMedida.Text);
        }
        private void dtgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.id = Convert.ToInt32(dtgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                    bll.Excluir(Convert.ToInt32(dtgvDados.Rows[dtgvDados.SelectedCells[0].RowIndex].Cells[0].Value));
                    MessageBox.Show("Excluido com sucesso!");
                    btnLocalizar_Click(sender, e);

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
