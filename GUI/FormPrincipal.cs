using System.Data;
using ScottPlot;
using BLL;
using DAL;
using Modelo;
using Timer = System.Windows.Forms.Timer;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Label = System.Windows.Forms.Label;
using static DAL.DALRelatorioVenda;
using System.Data.SqlClient;
using static DAL.DALRelatorioCompra;
using Microsoft.VisualStudio.Text.Editor;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        AUsuario _usuario;
        private Timer timerVerificarEstoque;
        private Timer timerEsconderBemVindo;
        private DALAbertura dalAbertura;
        private ModeloAbertura abertura;
        private Dictionary<int, string> meses;

        private void TimerVerificarEstoque_Tick(object sender, EventArgs e)
        {
            VerificarEstoqueBaixo();
        }

        private void VerificarEstoqueBaixo()
        {
            BLLProduto bllProduto = new BLLProduto(new DALConexao(DadosDaConexao.StringDeConexao));

            DataTable produtos = bllProduto.LocalizarProdutoFaltante("");
            lblProdutosFaltantes.Text = "";
            foreach (DataRow produto in produtos.Rows)
            {
                string nomeProduto = produto["produto_nome"].ToString();
                float qtde = Convert.ToSingle(produto["produto_qtde"]);
                lblProdutosFaltantes.Text += $"O produto '{nomeProduto}' está com estoque baixo({qtde} unidades)\r\n ";
            }
        }
        private void TimerEsconderBemVindo_Tick(object sender, EventArgs e)
        {
            timerEsconderBemVindo.Stop();
        }

        private void ConfigurarControles()
        {
            lblUsuarioAtual.Text = "Usuário logado: " + _usuario.Nome + " (" + _usuario.NivelAcesso + ")";
            lblUsuarioAtual.AutoSize = true;

            VendaToolStripMenuItem.Enabled = _usuario.NivelAcesso2._formVendaAcesso;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarGraficoVendaEstoque();
            AtualizarGraficoCompra();
            VerificarEstoqueBaixo();
            timerVerificarEstoque.Start();
            vendaToolStripMenuItem1.Enabled = false;
        }
        public FormPrincipal(AUsuario usuario)
        {
            meses = new(){
                { 1 , "Janeiro" },
                { 2, "Fevereiro" },
                { 3, "Março" },
                { 4, "Abril" },
                { 5, "Maio" },
                { 6, "Junho" },
                { 7, "Julho" },
                { 8, "Agosto" },
                { 9, "Setembro" },
                { 10, "Outubro" },
                { 11, "Novembro" },
                { 12, "Dezembro" },
            };
            InitializeComponent();
            this._usuario = usuario;
            VendaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formVendaAcesso;
            cadastroCategoriaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcadastroCategoriaAcesso;
            cadastroFornecedorToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formcadastroFornecedorAcesso;
            cadastroProdutoToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formcadastroProdutoAcesso;
            cadastroSubCategoriaToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formcadastroSubCategoriaAcesso;
            cadastroTipoDePagamentoToolStripMenuItem3.Enabled = usuario.NivelAcesso2._formcadastroTipoDePagamentoAcesso;
            cadastroUnidadeDeMedidaToolStripMenuItem5.Enabled = usuario.NivelAcesso2._formcadastroUnidadeMedidaAcesso;
            cadastroUsuarioToolStripMenuItem4.Enabled = usuario.NivelAcesso2._formcadastroUsuarioAcesso;
            compraToolStripMenuItem.Enabled = usuario.NivelAcesso2._formcompraAcesso;
            consultaCategoriaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaCategoriaAcesso;
            consultaFornecedorToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formconsultaFornecedorAcesso;
            consultaProdutoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formconsultaProdutoAcesso;
            consultaSubCategoriaToolStripMenuItem4.Enabled = usuario.NivelAcesso2._formconsultaSubCategoriaAcesso;
            consultaTipoDePagamentoToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formconsultaTipoDePagamentoAcesso;
            consultaUnidadeDeMedidaToolStripMenuItem5.Enabled = usuario.NivelAcesso2._formconsultaUnidadeMedidaAcesso;
            consultaUsuarioToolStripMenuItem3.Enabled = usuario.NivelAcesso2._formconsultaUsuarioAcesso;
            consultaCompraToolStripMenuItem.Enabled = usuario.NivelAcesso2._formConsultaCompraAcesso;
            vendaToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formConsultaVendaAcesso;
            relatorioCompraToolStripMenuItem.Enabled = usuario.NivelAcesso2._formRelatorioCompraAcesso;
            relatorioFornecedorToolStripMenuItem1.Enabled = usuario.NivelAcesso2._formRelatorioFornecedorAcesso;
            relatorioProdutoToolStripMenuItem.Enabled = usuario.NivelAcesso2._formRelatorioProdutoAcesso;
            relatorioUsuarioToolStripMenuItem2.Enabled = usuario.NivelAcesso2._formRelatorioUsuarioAcesso;
            consultaClienteToolStripMenuItem4.Enabled = usuario.NivelAcesso2._formConsultaClienteAcesso;
            cadastroClienteToolStripMenuItem5.Enabled = usuario.NivelAcesso2._formcadastroClienteAcesso;
            relatorioClienteToolStripMenuItem3.Enabled = usuario.NivelAcesso2._formRelatorioClienteAcesso;
            relatorioVendaToolStripMenuItem.Enabled = usuario.NivelAcesso2._formVendaAcesso;

            this._usuario = usuario;
            ConfigurarControles();
            timerEsconderBemVindo = new Timer();
            timerEsconderBemVindo.Interval = 60000;
            timerEsconderBemVindo.Tick += TimerEsconderBemVindo_Tick;
            timerEsconderBemVindo.Start();

            lblUsuarioAtual.Text = "Usuário logado: " + _usuario.Nome + " (" + _usuario.NivelAcesso + ")";
            lblUsuarioAtual.AutoSize = true;

            lblProdutosFaltantes.AutoSize = true;

            timerVerificarEstoque = new Timer();
            timerVerificarEstoque.Interval = 24 * 60 * 60 * 1000;
            timerVerificarEstoque.Tick += TimerVerificarEstoque_Tick;
            timerVerificarEstoque.Start();
        }

        private void cadastroClienteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            formCadastroCliente f = new formCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaClienteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            formConsultaCliente f = new formConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatórioClienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formRelatorioCliente f = new formRelatorioCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroFornecedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formCadastroFornecedor f = new formCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaFornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaFornecedor f = new formConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatorioFornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formRelatorioFornecedor f = new formRelatorioFornecedor();
            f.ShowDialog();
            f.Dispose();
        }
        private void cadastroProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCadastroProduto f = new formCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultaProduto f = new formConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }
        private void relatórioProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioProduto f = new formRelatorioProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroCategoria f = new formCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultaCategoria f = new formConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroSubCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formCadastroSubCategoria f = new formCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaSubCategoriaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            formConsultaSubCategoria f = new formConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroUnidadeDeMedidaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            formCadastroUnidadeMedida f = new formCadastroUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaUnidadeDeMedidaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            formConsultaUnidadeMedida f = new formConsultaUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroTipoDePagamentoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formCadastroTipoPagamento f = new formCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }
        private void consultaTipoDePagamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formConsultaTipoPagamento f = new formConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroUsuarioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            formCadastroUsuario f = new formCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaUsuarioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formConsultaUsuario f = new formConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatórioUsuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formRelatorioUsuario f = new formRelatorioUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            formVenda f = new formVenda(this);
            f.ShowDialog();
            f.Dispose();
        }
        private void consultaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultaVenda f = new formConsultaVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatórioVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioVenda f = new formRelatorioVenda();
            f.ShowDialog();
            f.Dispose();
        }
        private void SairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Abre o formulário de login ao sair
            formLogin f = new formLogin();
            f.Show();
        }
        private void cadastroCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCompra f = new formCompra(this);
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultaCompra f = new formConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatorioCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioCompra f = new formRelatorioCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroGastos f = new formCadastroGastos();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioGastos f = new formRelatorioGastos();
            f.ShowDialog();
            f.Dispose();
        }
        public string ShowInputDialog(string caption, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 550, // Aumentar a largura para acomodar o texto completo
                Height = 200, // Aumentar a altura para dar mais espaço aos controles
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label()
            {
                Left = 25, // Ajustar a posição para a esquerda
                Top = 20, // Ajustar a posição para cima
                Width = 500, // Ajustar a largura para acomodar o texto completo
                Text = prompt
            };

            TextBox textBox = new TextBox()
            {
                Left = 25, // Ajustar a posição para a esquerda
                Top = 50, // Ajustar a posição para baixo
                Width = 500 // Ajustar a largura para corresponder à largura da Label
            };

            Button confirmation = new Button()
            {
                Text = "Ok",
                Width = 100, // Reduzir ligeiramente a largura para melhorar o layout
                DialogResult = DialogResult.OK
            };

            // Ajustar a posição e a largura do botão para centralizá-lo
            confirmation.Left = (promptForm.Width - confirmation.Width) / 2;
            confirmation.Top = 100; // Ajustar a posição para baixo

            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(textBox);
            promptForm.AcceptButton = confirmation;

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se há um caixa aberto
                DALAbertura dalAbertura = new DALAbertura(new DALConexao(DadosDaConexao.StringDeConexao));
                ModeloAbertura caixaAberto = dalAbertura.VerificarSessao();

                if (caixaAberto != null && caixaAberto.dataInicial != null)
                {
                    MessageBox.Show("Já há um caixa aberto!\nPor favor, feche o caixa atual antes de abrir um novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sair do método sem abrir um novo caixa
                }

                string valorInicialStr = ShowInputDialog("Abertura de Caixa", "Por favor, insira o valor inicial do caixa: ");

                if (!string.IsNullOrEmpty(valorInicialStr))
                {
                    if (decimal.TryParse(valorInicialStr, out decimal valorInicial))
                    {
                        int valorInicialInt = (int)Math.Round(valorInicial);

                        string valorInicialFormatado = valorInicialInt.ToString("C");

                        MessageBox.Show("Valor inicial do caixa: " + valorInicialFormatado, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Inicializar a variável abertura
                        abertura = new ModeloAbertura();
                        abertura.ValorInicial = valorInicialInt;

                        // Inicializar a variável dalAbertura se ainda não estiver inicializada
                        if (dalAbertura == null)
                        {
                            dalAbertura = new DALAbertura(new DALConexao(DadosDaConexao.StringDeConexao));
                        }
                        dalAbertura.IncluirAbertura(abertura);

                        vendaToolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor numérico válido para o valor inicial do caixa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum valor inserido. A abertura do caixa foi cancelada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao abrir o caixa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se há um caixa aberto para fechar
                DALAbertura dalAbertura = new DALAbertura(new DALConexao(DadosDaConexao.StringDeConexao));
                ModeloAbertura caixaAberto = dalAbertura.VerificarSessao();

                if (caixaAberto == null || caixaAberto.dataFinal == null)
                {
                    MessageBox.Show("Não há caixa aberto para fechar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Sair do método sem tentar fechar o caixa
                }

                // Continuar com o restante do código como antes
                var relatorioVenda = new DALRelatorioVenda(new DALConexao(DadosDaConexao.StringDeConexao));
                double totalVendas = relatorioVenda.ObterTotalVendas(caixaAberto.dataInicial, DateTime.Now);

                var relatorioGastos = new DALRelatorioGastos(new DALConexao(DadosDaConexao.StringDeConexao));
                double totalDespesas = relatorioGastos.ObterTotalDespesas(caixaAberto.dataInicial, DateTime.Now);

                decimal valorFinalCaixa = caixaAberto.ValorInicial + (decimal)totalVendas - Math.Abs((decimal)totalDespesas);

                caixaAberto.dataFinal = DateTime.Now;
                caixaAberto.ValorFinal = Convert.ToInt32(valorFinalCaixa);
                dalAbertura.IncluirFechamento(caixaAberto);

                MessageBox.Show($"Caixa fechado com sucesso. Valor final do caixa: {valorFinalCaixa:C}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gerar o cupom fiscal em PDF, passando o nome do usuário atual como parâmetro
                GerarCupomFiscalPDF(caixaAberto.dataInicial, caixaAberto.dataFinal, caixaAberto.ValorInicial, totalVendas, totalDespesas, valorFinalCaixa, _usuario.Nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao fechar o caixa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GerarCupomFiscalPDF(DateTime dataInicial, DateTime dataFinal, decimal valorInicial, double totalVendas, double totalDespesas, decimal valorFinalCaixa, string nomeUsuario)
        {
            // Crie uma instância do SaveFileDialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo PDF|*.pdf";
            saveDialog.Title = "Salvar cupom não fiscal";
            saveDialog.FileName = "Cupom não fiscal.pdf";

            // Exibe o diálogo e verifica se o usuário clicou em "Salvar"
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho do arquivo selecionado pelo usuário
                string caminhoArquivo = saveDialog.FileName;

                // Cria um novo documento PDF
                Document doc = new Document();

                try
                {
                    // Crie um escritor de PDF
                    PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));

                    // Abra o documento para escrever
                    doc.Open();

                    // Adiciona título ao cupom fiscal
                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                    Paragraph title = new Paragraph("Cupom não fiscal", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);
                    doc.Add(Chunk.NEWLINE);

                    // Crie a tabela para as informações do caixa
                    PdfPTable table = new PdfPTable(2); // 2 colunas para os pares chave-valor
                    table.WidthPercentage = 100; // Define a largura da tabela como 100% da página

                    // Adicione os pares chave-valor à tabela
                    AdicionarLinhaTabela(table, "Período de abertura:", dataInicial.ToString("dd/MM/yyyy HH:mm"));
                    AdicionarLinhaTabela(table, "Período de fechamento:", dataFinal.ToString("dd/MM/yyyy HH:mm"));
                    AdicionarLinhaTabela(table, "Valor inicial do caixa:", valorInicial.ToString("C"));
                    AdicionarLinhaTabela(table, "Total de vendas:", totalVendas.ToString("C"));
                    AdicionarLinhaTabela(table, "Total de despesas:", totalDespesas.ToString("C"));
                    AdicionarLinhaTabela(table, "Valor final do caixa:", valorFinalCaixa.ToString("C"));

                    // Adiciona o nome do usuário e seu tipo ao cupom fiscal
                    Paragraph user = new Paragraph($"Usuário: {nomeUsuario} ({_usuario.NivelAcesso})", FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK));
                    user.Alignment = Element.ALIGN_LEFT;
                    doc.Add(user);
                    doc.Add(Chunk.NEWLINE);

                    // Adicione a tabela ao documento
                    doc.Add(table);

                    // Adiciona uma linha para separar o conteúdo do rodapé
                    doc.Add(new Chunk("\n"));

                    // Exiba uma mensagem informando que o PDF foi criado com sucesso
                    MessageBox.Show("Cupom não fiscal gerado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Feche o documento
                    doc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao gerar o cupom não fiscal: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdicionarLinhaTabela(PdfPTable table, string chave, string valor)
        {
            // Estilo da chave
            PdfPCell chaveCell = new PdfPCell(new Phrase(chave, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK)));
            chaveCell.Border = 0; // Remove a borda
            chaveCell.PaddingBottom = 5f; // Espaçamento inferior
            chaveCell.HorizontalAlignment = Element.ALIGN_LEFT; // Alinhamento à esquerda

            // Estilo do valor
            PdfPCell valorCell = new PdfPCell(new Phrase(valor, FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK)));
            valorCell.Border = 0; // Remove a borda
            valorCell.PaddingBottom = 5f; // Espaçamento inferior
            valorCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Alinhamento à direita

            // Adiciona as células à tabela
            table.AddCell(chaveCell);
            table.AddCell(valorCell);
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelatorioFluxoCaixa f = new formRelatorioFluxoCaixa();
            f.ShowDialog();
            f.Dispose();
        }


        List<VendaGrafico> PegarVendasGrafico()
        {
            DALRelatorioVenda conexaoDBvendas = new DALRelatorioVenda(new DALConexao(DadosDaConexao.StringDeConexao));
            var vendas = conexaoDBvendas.ObterGraficoVenda();
            if (vendas == null || vendas.Count == 0)
            {
                return new List<VendaGrafico>();
            }
            return vendas;
        }

        void PegarDadosVenda()
        {
            var vendas = PegarVendasGrafico();

            DateTime[] dataX = vendas.Select(venda => venda.Data).ToArray();
            double[] dataY = vendas.Select(venda => (double)venda.TotalDeVendas).ToArray();

            Dictionary<int, double> data = Enumerable.Range(1, 12)
                .ToDictionary(month => month, month => 0.0);

            for (int i = 0; i < dataX.Length; i++)
            {
                if (data.ContainsKey(dataX[i].Month))
                {
                    data[(int)dataX[i].Month] += dataY[i];
                }
                else
                {
                    data.Add((int)dataX[i].Month, dataY[i]);
                }
            }
            criarGraficoVenda(data);
        }

        private void criarGraficoVenda(Dictionary<int, double> data)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.XLabel("Mês");
            formsPlot1.Plot.YLabel("Valor");
            formsPlot1.Plot.Title("Valores de vendas por mês");
            formsPlot1.Plot.Axes.Bottom.SetTicks(data.Select(d => (double)d.Key).ToArray(), data.Select(d => meses[d.Key]).ToArray());
            formsPlot1.Plot.Add.Scatter(data.Select(d => (double)d.Key).ToArray(), data.Select(d => d.Value).ToArray());
        }

        public void AtualizarGraficoVendaEstoque()
        {
            formsPlot1.Plot.Clear();

            PegarDadosVenda(); // Pega dados da Venda e plota no gráfico.

            formsPlot1.Refresh();
        }

        List<CompraGrafico> PegarComprasGrafico()
        {
            var conexaoDBvendas = new DALRelatorioCompra(new DALConexao(DadosDaConexao.StringDeConexao));
            var compras = conexaoDBvendas.ObterGraficoCompras();
            if (compras == null || compras.Count == 0)
            {
                return new List<CompraGrafico>();
            }
            return compras;
        }


        void PegarDadosCompraX()
        {
            var compras = PegarComprasGrafico();
            DateTime[] dataX = compras.Select(compra => compra.Data).ToArray();
            double[] dataY = compras.Select(compra => (double)compra.TotalDeCompras).ToArray();

            Dictionary<int, double> data = Enumerable.Range(1, 12)
                .ToDictionary(month => month, month => 0.0);

            for (int i = 0; i < dataX.Length; i++)
            {
                if (data.ContainsKey(dataX[i].Month))
                {
                    data[dataX[i].Month] += dataY[i];
                }
                else
                {
                    data.Add(dataX[i].Month, dataY[i]);
                }
            }

            criarGraficoCompra(data);
        }

        private void criarGraficoCompra(Dictionary<int, double> data)
        {
            formsPlot3.Plot.Clear();
            formsPlot3.Plot.XLabel("Mês");
            formsPlot3.Plot.YLabel("Valor");
            formsPlot3.Plot.Title("Valores de compras por mês");
            formsPlot3.Plot.Axes.Bottom.SetTicks(data.Select(d => (double)d.Key).ToArray(), data.Select(d => meses[d.Key]).ToArray());
            formsPlot3.Plot.Add.Scatter(data.Select(d => (double)d.Key).ToArray(), data.Select(d => d.Value).ToArray());
        }

        public void AtualizarGraficoCompra()
        {
            formsPlot3.Plot.Clear();

            PegarDadosCompraX();

            formsPlot3.Refresh();
        }

    }
}
