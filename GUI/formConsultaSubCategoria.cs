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
    public partial class formConsultaSubCategoria : Form
    {
        public int id = 0;
        public formConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void formConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dtgvDados.Columns[0].HeaderText = "ID da Sub Categoria";
            dtgvDados.Columns[0].Width = 100;
            dtgvDados.Columns[1].HeaderText = "Nome da Sub Categoria";
            dtgvDados.Columns[1].Width = 200;
            dtgvDados.Columns[2].HeaderText = "ID da Categoria";
            dtgvDados.Columns[2].Width = 100;
            dtgvDados.Columns[3].HeaderText = "Nome da Categoria";
            dtgvDados.Columns[3].Width = 100;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DAL.DALConexao cx = new DAL.DALConexao(DadosDaConexao.StringDeConexao);
            BLL.BLLSubCategoria bll = new BLL.BLLSubCategoria(cx);
            dtgvDados.DataSource = bll.Localizar(txtConsultaSubCategoria.Text);
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
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
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
    }
}
