using DAL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static DAL.DALRelatorioVenda;
using Document = iTextSharp.text.Document;
using System.Data.SqlClient;

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

        private void btnExportarRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo PDF|*.pdf";
            saveDialog.Title = "Salvar Relatório";
            saveDialog.FileName = "Relatorio.pdf";
            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document(); // Correção aqui
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
                document.Open();

                // Adiciona título ao relatório
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK); // Correção aqui
                Paragraph title = new Paragraph("Relatório de Vendas", titleFont);
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

                // Adiciona a soma do valor_venda
                double total = CalcularSomaColuna(dtgvRelatorios.DataSource as List<VendaRelatorio>, "total_de_vendas");
                // Corrigido para declaração após o uso
                iTextSharp.text.Font dateFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10, BaseColor.GRAY); // Correção aqui
                Paragraph totalParagraph = new Paragraph($"Total de vendas: {total:C2}", dateFont);
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
        private double CalcularSomaColuna(List<DALRelatorioVenda.VendaRelatorio> vendas, string nomeDaColuna)
        {
            double soma = 0.0;

            foreach (var venda in vendas)
            {
                switch (nomeDaColuna)
                {
                    case "total_de_vendas":
                        soma += venda.TotalDeVendas; // Correção aqui
                        break;
                        // Adicione outros casos conforme necessário para outras colunas
                }
            }

            return soma;
        }

        
    }
}
