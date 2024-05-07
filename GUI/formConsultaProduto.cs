using BLL;
using DAL;

namespace UI
{
    public partial class formConsultaProduto : Form
    {
        public int id = 0;
        public formConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(dtgvDados.Rows[dtgvDados.CurrentRow.Index].Cells[0].Value));
                    MessageBox.Show("Registro excluído com sucesso!");
                    btnLocalizar_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro \nO registro está sendo utilizado em outro local.");
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dtgvDados.DataSource = bll.Localizar(txtConsultaProduto.Text);
        }

        private void dtgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.id = Convert.ToInt32(dtgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void formConsultaProduto_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dtgvDados.Columns[0].HeaderText = "Código do produto";
            dtgvDados.Columns[0].Width = 50;
            dtgvDados.Columns[1].HeaderText = "Nome do produto";
            dtgvDados.Columns[1].Width = 60;
            dtgvDados.Columns[2].HeaderText = "Descrição do produto";
            dtgvDados.Columns[2].Width = 100;
            dtgvDados.Columns[3].HeaderText = "Valor pago";
            dtgvDados.Columns[3].Width = 50;
            dtgvDados.Columns[4].HeaderText = "Valor de venda";
            dtgvDados.Columns[4].Width = 50;
            dtgvDados.Columns[5].HeaderText = "Lote";
            dtgvDados.Columns[5].Width = 80;
            dtgvDados.Columns[6].HeaderText = "Quantidade";
            dtgvDados.Columns[6].Width = 50;
            dtgvDados.Columns[7].HeaderText = "Unidade de medida";
            dtgvDados.Columns[7].Width = 100;
            dtgvDados.Columns[8].HeaderText = "Categoria";
            dtgvDados.Columns[8].Width = 100;
            dtgvDados.Columns[9].HeaderText = "Subcategoria";
            dtgvDados.Columns[9].Width = 100;
            dtgvDados.Columns[9].HeaderText = "Fornecedor";
            dtgvDados.Columns[9].Width = 100;
        }

        private void dtgvDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvDados.Columns["produto_valorPago"].Index || e.ColumnIndex == dtgvDados.Columns["produto_valorVenda"].Index)
                {
                    if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                    {
                        e.Value = valor.ToString("C2");
                    }
                }
            }
        }
    }
}
