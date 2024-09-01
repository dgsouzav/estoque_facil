using DAL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using System.Data.SqlClient;
using static DAL.DALRelatorioFluxoDeCaixa;
using static DAL.DALRelatorioVenda;

namespace UI
{
    public partial class formRelatorioFluxoCaixa : Form
    {
        string connectionString = DadosDaConexao.StringDeConexao;
        private DALConexao conexao;

        DALRelatorioFluxoDeCaixa dalRelatorioFluxoDeCaixa;
        public formRelatorioFluxoCaixa()
        {
            InitializeComponent();
        }

        private void formRelatorioFluxoCaixa_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
        }

        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnGerarRelatorio.Enabled = false;
            btnLimparTela.Enabled = false;
            btnExportarRelatorio.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
            }

            if (op == 2)
            {
                panelDados.Enabled = true;
                btnGerarRelatorio.Enabled = true;
                btnLimparTela.Enabled = true;
                btnExportarRelatorio.Enabled = true;
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.menuBotoes(2);
        }

        private void btnExportarRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo PDF|*.pdf";
            saveDialog.Title = "Salvar Relatório";
            saveDialog.FileName = "RelatorioFluxoCaixa.pdf";
            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
                document.Open();

                // Adiciona título ao relatório
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK); // Correção aqui
                Paragraph title = new Paragraph("Relatório de Fluxo de Caixa", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);
                document.Add(Chunk.NEWLINE);

                PdfPTable table = new PdfPTable(dtgvRelatorios.Columns.Count);

                // Adiciona cabeçalhos da tabela
                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE); // Correção aqui
                PdfPCell headerCell;
                foreach (DataGridViewColumn column in dtgvRelatorios.Columns)
                {
                    headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                    headerCell.BackgroundColor = BaseColor.GRAY;
                    table.AddCell(headerCell);
                }

                // Adiciona os dados da tabela
                iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK); // Correção aqui
                foreach (DataGridViewRow row in dtgvRelatorios.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            table.AddCell(new Phrase(cell.Value.ToString(), cellFont));
                        }
                    }
                }

                document.Add(table);

                // Adiciona o fluxo de caixa total
                double totalFluxoDeCaixa = CalcularSomaColuna(dtgvRelatorios.DataSource as List<FluxoDeCaixaRelatorio>, "fluxo_de_caixa");
                iTextSharp.text.Font dateFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10, BaseColor.GRAY);
                Paragraph totalParagraph = new Paragraph($"Total de fluxo de caixa: {totalFluxoDeCaixa:C2}", dateFont);
                totalParagraph.Alignment = Element.ALIGN_RIGHT;
                document.Add(totalParagraph);

                // Adiciona parágrafo com as datas selecionadas no final do documento
                Paragraph datasSelecionadas = new Paragraph($"Período Selecionado: {dtpDataInicial.Value.ToShortDateString()} - {dtpDataFinal.Value.ToShortDateString()}", dateFont);
                datasSelecionadas.Alignment = Element.ALIGN_RIGHT;
                document.Add(datasSelecionadas);

                document.Close();
                MessageBox.Show("Relatório exportado com sucesso.");
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            string nomeTabela = "Estoque";
            this.conexao = new DALConexao(connectionString);
            this.dalRelatorioFluxoDeCaixa = new DALRelatorioFluxoDeCaixa(conexao);

            DateTime dataInicial = dtpDataInicial.Value.Date;
            DateTime dataFinal = dtpDataFinal.Value.Date;

            try
            {
                List<FluxoDeCaixaRelatorio> dadosRelatorio = dalRelatorioFluxoDeCaixa.ObterLinhasFluxoDeCaixa(nomeTabela, dataInicial, dataFinal);

                if (dadosRelatorio != null && dadosRelatorio.Count > 0)
                {
                    dtgvRelatorios.DataSource = dadosRelatorio;
                    dtgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Não foram encontrados dados para o período selecionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o relatório: " + ex.Message);
            }
        }



        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            this.LimpaTela();
        }

        private void dtgvRelatorios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            List<string> colunasParaFormatar = new List<string> { "FluxoCaixa", "ValorAbertura", "TotalVendas", "TotalCompras" };

            if (colunasParaFormatar.Contains(dtgvRelatorios.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }
        }
        private double CalcularSomaColuna(List<FluxoDeCaixaRelatorio> fluxos, string nomeDaColuna)
        {
            double soma = 0.0;

            foreach (var fluxo in fluxos)
            {
                switch (nomeDaColuna)
                {
                    case "FluxoCaixa":
                        soma += fluxo.FluxoCaixa;
                        break;
                    case "ValorAbertura":
                        soma += fluxo.ValorAbertura;
                        break;
                    case "TotalVendas":
                        soma += fluxo.TotalVendas;
                        break;
                    case "TotalCompras":
                        soma += fluxo.TotalCompras;
                        break;
                }
            }

            return soma;
        }
    }
}
