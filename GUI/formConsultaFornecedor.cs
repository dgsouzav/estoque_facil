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
    public partial class formConsultaFornecedor : Form
    {
        public int id = 0;
        public formConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void formConsultaFornecedor_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dtgvDados.Columns[0].HeaderText = "ID";
            dtgvDados.Columns[0].Width = 60;
            dtgvDados.Columns[1].HeaderText = "Nome";
            dtgvDados.Columns[1].Width = 200;
            dtgvDados.Columns[2].HeaderText = "CNPJ";
            dtgvDados.Columns[2].Width = 100;
            dtgvDados.Columns[3].HeaderText = "IE";
            dtgvDados.Columns[3].Width = 100;
            dtgvDados.Columns[4].HeaderText = "Razão Social";
            dtgvDados.Columns[4].Width = 200;
            dtgvDados.Columns[5].HeaderText = "CEP";
            dtgvDados.Columns[5].Width = 100;
            dtgvDados.Columns[6].HeaderText = "Endereço";
            dtgvDados.Columns[6].Width = 200;
            dtgvDados.Columns[7].HeaderText = "Bairro";
            dtgvDados.Columns[7].Width = 200;
            dtgvDados.Columns[8].HeaderText = "Telefone";
            dtgvDados.Columns[8].Width = 100;
            dtgvDados.Columns[9].HeaderText = "Email";
            dtgvDados.Columns[9].Width = 200;
            dtgvDados.Columns[10].HeaderText = "Cidade";
            dtgvDados.Columns[10].Width = 200;
            dtgvDados.Columns[11].HeaderText = "Estado";
            dtgvDados.Columns[11].Width = 100;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLL.BLLFornecedor bll = new BLL.BLLFornecedor(cx);
            dtgvDados.DataSource = bll.Localizar(txtConsultaFornecedor.Text);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAL.DALConexao cx = new DAL.DALConexao(DAL.DadosDaConexao.StringDeConexao);
                    BLL.BLLFornecedor bll = new BLL.BLLFornecedor(cx);
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
