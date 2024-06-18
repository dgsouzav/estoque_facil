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
using Document = iTextSharp.text.Document;
using DAL;
using static DAL.DALRelatorioGastos;
using Font = System.Drawing.Font;

namespace UI
{
    public partial class formRelatorioGastos : Form
    {
        string connectionString = DadosDaConexao.StringDeConexao;
        private DALConexao conexao;

        DALRelatorioGastos dalRelatorioGastos;
        public formRelatorioGastos()
        {
            InitializeComponent();
        }
        private void formGastos_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            dtgvRelatorios.CellFormatting += dtgvRelatorios_CellFormatting;
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
            saveDialog.FileName = "Relatorio.pdf";
            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                double total = CalcularSomaColuna(dtgvRelatorios.DataSource as List<GastosRelatorio>, "valor_venda");

                iTextSharp.text.Document document = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
                document.Open();

                // Adiciona título ao relatório
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                Paragraph title = new Paragraph("Relatório de Despesas", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);
                document.Add(Chunk.NEWLINE);

                PdfPTable table = new PdfPTable(dtgvRelatorios.Columns.Count);

                // Adiciona cabeçalhos da tabela
                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                PdfPCell headerCell;
                foreach (DataGridViewColumn column in dtgvRelatorios.Columns)
                {
                    headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                    headerCell.BackgroundColor = BaseColor.GRAY;
                    table.AddCell(headerCell);
                }

                // Adiciona os dados da tabela
                iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
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

                // Adiciona a célula com o total de despesas na última linha, alinhado com a coluna de valores de despesa
                PdfPCell totalCell = new PdfPCell(new Phrase($"Total: {total:C2}", cellFont));
                totalCell.Colspan = dtgvRelatorios.Columns.Count; // Colspan para ocupar todas as colunas
                totalCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Alinhamento à esquerda
                table.AddCell(totalCell);

                document.Add(table);

                // Adiciona parágrafo com as datas selecionadas no final do documento
                iTextSharp.text.Font dateFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10, BaseColor.GRAY);
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
            this.dalRelatorioGastos = new DALRelatorioGastos(conexao);

            DateTime dataInicial = dtpDataInicial.Value.Date;
            DateTime dataFinal = dtpDataFinal.Value.Date;

            List<GastosRelatorio> dadosRelatorio = dalRelatorioGastos.ObterLinhasGastos(nomeTabela, dataInicial, dataFinal);
            if (dadosRelatorio != null)
            {
                dtgvRelatorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dtgvRelatorios.DataSource = dadosRelatorio;
                dtgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                double total = CalcularSomaColuna(dadosRelatorio, "valor_venda");
                lblTotal.Text = $"Total: {total:C2}";
            }
            else
            {
                MessageBox.Show("Erro ao obter nomes das colunas.");
            }
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            this.LimpaTela();
        }

        private void dtgvRelatorios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dtgvRelatorios.Columns[e.ColumnIndex].Name == "venda_total")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }
        }

        private double CalcularSomaColuna(List<GastosRelatorio> gastos, string nomeDaColuna)
        {
            double soma = 0.0;

            foreach (var gasto in gastos)
            {
                switch (nomeDaColuna)
                {
                    case "valor_venda":
                        soma += gasto.Valor; // Considerando que a propriedade Valor armazena o valor da venda
                        break;
                        // Adicione outros casos conforme necessário para outras colunas
                }
            }

            return soma;
        }
    }
}
