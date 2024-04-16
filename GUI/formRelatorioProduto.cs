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
using Document = iTextSharp.text.Document;
using static DAL.DALRelatorioProduto;
using static DAL.DALRelatorioVenda;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace UI
{
    public partial class formRelatorioProduto : Form
    {
        string connectionString = DadosDaConexao.StringDeConexao;
        private DALConexao conexao;

        DALRelatorioProduto dalRelatorioProduto;
        public formRelatorioProduto()
        {
            InitializeComponent();
        }

        private void formRelatorioProduto_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
        }
        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnGerarRelatorio.Enabled = false;
            btnLimparTela.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
            }

            if (op == 2)
            {
                panelDados.Enabled = true;
                btnGerarRelatorio.Enabled = true;
                btnLimparTela.Enabled = true;
            }

            if (op == 3)
            {
                btnLimparTela.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            dtgvRelatorios.DataSource = null;
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            this.menuBotoes(2);
        }
        private void btnLimparTela_Click_1(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            this.LimpaTela();
        }
        private void btnExportarRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo PDF|*.pdf";
            saveDialog.Title = "Salvar Relatório";
            saveDialog.FileName = "Relatorio.pdf";
            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                iTextSharp.text.Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dtgvRelatorios.Columns.Count);

                // Adiciona os cabeçalhos
                for (int i = 0; i < dtgvRelatorios.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dtgvRelatorios.Columns[i].HeaderText));
                }

                // Adiciona os dados
                for (int i = 0; i < dtgvRelatorios.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvRelatorios.Columns.Count; j++)
                    {
                        if (dtgvRelatorios[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dtgvRelatorios[j, i].Value.ToString()));
                        }
                    }
                }

                document.Add(table);
                document.Close();
                MessageBox.Show("Relatório exportado com sucesso.");
            }
        }

        private void btnGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            string nomeTabela = "ControleDeEstoque";
            this.conexao = new DALConexao(connectionString);
            this.dalRelatorioProduto = new DALRelatorioProduto(conexao);

            List<ProdutoRelatorio> dadosRelatorio = dalRelatorioProduto.ObterLinhasProduto(nomeTabela);
            if (dadosRelatorio != null)
            {
                dtgvRelatorios.DataSource = dadosRelatorio;
                dtgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Erro ao obter nomes das colunas.");
            }
        }
        private void dtgvRelatorios_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            List<string> colunasParaFormatar = new List<string> { "ValorPago", "ValorVenda" };

            if (colunasParaFormatar.Contains(dtgvRelatorios.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }
        }
    }
}
