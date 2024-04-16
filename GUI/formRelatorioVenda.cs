using DAL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.DALRelatorioVenda;
using Document = iTextSharp.text.Document;

namespace UI
{
    public partial class formRelatorioVenda : Form
    {
        string connectionString = DadosDaConexao.StringDeConexao;
        private DALConexao conexao;

        DALRelatorioVenda dalRelatorioVenda;
        public formRelatorioVenda()
        {
            InitializeComponent();
        }

        private void formRelatorioVenda_Load(object sender, EventArgs e)
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
        private void btnGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            string nomeTabela = "ControleDeEstoque";
            this.conexao = new DALConexao(connectionString);
            this.dalRelatorioVenda = new DALRelatorioVenda(conexao);

            DateTime dataInicial = dtpDataInicial.Value.Date;
            DateTime dataFinal = dtpDataFinal.Value.Date;
            List<VendaRelatorio> dadosRelatorio = dalRelatorioVenda.ObterLinhasVenda(nomeTabela, dataInicial, dataFinal);
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

        private void btnExportarRelatorio_Click_1(object sender, EventArgs e)
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
        private void RelatorioVenda(string venda, DateTime dataInicial, DateTime dataFinal)
        {
            List<VendaRelatorio> dadosRelatorio = dalRelatorioVenda.ObterLinhasVenda(venda, dataInicial, dataFinal);

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
            List<string> colunasParaFormatar = new List<string> { "TotalDeVendas" };

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
