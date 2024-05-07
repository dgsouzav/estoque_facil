using System.Data;
using BLL;
using DAL;
using Modelo;
using Timer = System.Windows.Forms.Timer;
using static DAL.DALRelatorioVenda;
using static DAL.DALRelatorioGastos;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        AUsuario _usuario;
        private Timer timerVerificarEstoque;
        private Timer timerEsconderBemVindo;
        private DALAbertura dalAbertura;
        private ModeloAbertura abertura;

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
                lblProdutosFaltantes.Text += $"O produto '{nomeProduto}' está com estoque baixo ({qtde} unidades).";
            }
        }
        private void TimerEsconderBemVindo_Tick(object sender, EventArgs e)
        {
            lblBemVindo.Text = "";
            timerEsconderBemVindo.Stop();
        }

        private void ConfigurarControles()
        {
            lblBemVindo.Text = "Bem-vindo, " + _usuario.Nome + "!";
            lblUsuarioAtual.Text = "Usuário logado: " + _usuario.Nome + " (" + _usuario.NivelAcesso + ")";
            lblUsuarioAtual.AutoSize = true;

            VendaToolStripMenuItem.Enabled = _usuario.NivelAcesso2._formVendaAcesso;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            VerificarEstoqueBaixo();
            timerVerificarEstoque.Start();
            vendaToolStripMenuItem1.Enabled = false;
        }
        public FormPrincipal(AUsuario usuario)
        {
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

        }

        private void consultaClienteToolStripMenuItem4_Click(object sender, EventArgs e)
        {

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
            formVenda f = new formVenda();
            f.ShowDialog();
            f.Dispose();
        }
        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVenda f = new formVenda();
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
            formCompra f = new formCompra();
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
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { promptForm.Close(); };
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(textBox);
            promptForm.AcceptButton = confirmation;

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar se já há um caixa aberto sem valor ou data final inserida
            if (abertura != null && abertura.dataFinal == null && abertura.ValorFinal == null)
            {
                MessageBox.Show("Já há um caixa aberto sem valor ou data final inserida. Por favor, feche o caixa atual antes de abrir um novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sair do método sem abrir um novo caixa
            }

            string valorInicialStr = ShowInputDialog("Abertura de Caixa", "Por favor, insira o valor inicial do caixa:");

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

        private void fecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se há uma abertura de caixa ativa
                DALAbertura dalAbertura = new DALAbertura(new DALConexao(DadosDaConexao.StringDeConexao));

                // Verificar a sessão usando o método VerificarSessao de dalAbertura
                ModeloAbertura abertura = dalAbertura.VerificarSessao();

                if (abertura != null)
                {
                    // Continuar com o restante do código como antes
                    var relatorioVenda = new DALRelatorioVenda(new DALConexao(DadosDaConexao.StringDeConexao));
                    double totalVendas = relatorioVenda.ObterTotalVendas(abertura.dataInicial, DateTime.Now);

                    var relatorioGastos = new DALRelatorioGastos(new DALConexao(DadosDaConexao.StringDeConexao));
                    double totalDespesas = relatorioGastos.ObterTotalDespesas(abertura.dataInicial, DateTime.Now);

                    decimal valorFinalCaixa = abertura.ValorInicial + (decimal)totalVendas - Math.Abs((decimal)totalDespesas);

                    abertura.dataFinal = DateTime.Now;
                    abertura.ValorFinal = Convert.ToInt32(valorFinalCaixa);
                    dalAbertura.IncluirFechamento(abertura);

                    MessageBox.Show($"Caixa fechado com sucesso. Valor final do caixa: {valorFinalCaixa:C}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gerar o cupom fiscal em PDF, passando o nome do usuário atual como parâmetro
                    GerarCupomFiscalPDF(abertura.dataInicial, abertura.dataFinal, abertura.ValorInicial, totalVendas, totalDespesas, valorFinalCaixa, _usuario.Nome);

                }
                else
                {
                    MessageBox.Show("Não há caixa aberto para fechar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            saveDialog.Title = "Salvar Cupom Fiscal";

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
                    Paragraph title = new Paragraph("Cupom Fiscal", titleFont);
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
                    MessageBox.Show("Cupom fiscal gerado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Feche o documento
                    doc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao gerar o cupom fiscal: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
