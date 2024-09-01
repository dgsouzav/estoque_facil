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
using static DAL.DALRelatorioUsuario;
using Document = iTextSharp.text.Document;

namespace UI
{
    public partial class formRelatorioUsuario : Form
    {
        string connectionString = DadosDaConexao.StringDeConexao;
        private DALConexao conexao;

        DALRelatorioUsuario dalRelatorioUsuario;
        public formRelatorioUsuario()
        {
            InitializeComponent();
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
        private void formRelatorioUsuario_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
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
            saveDialog.FileName = "RelatorioUsuario.pdf";
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

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            string nomeTabela = "Estoque";
            this.conexao = new DALConexao(connectionString);
            this.dalRelatorioUsuario = new DALRelatorioUsuario(conexao);

            List<UsuarioRelatorio> dadosRelatorio = dalRelatorioUsuario.ObterLinhasUsuario(nomeTabela);

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

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            this.LimpaTela();
        }
    }
}
