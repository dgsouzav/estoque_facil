using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALVenda
    {
        DALConexao conexao;
        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirGasto(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into venda (venda_gastoNome, venda_data, venda_notaFiscal, venda_total, " +
                    "venda_status, venda_tipoTransacao, venda_descricao) values (@gastoNome, @data, @notaFiscal, @total, " +
                    "@status, @tipoTransacao, @descricao); select @@IDENTITY;";
                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = modelo.VendaData;
                cmd.Parameters.AddWithValue("@notaFiscal", modelo.VendaNotaFiscal);
                cmd.Parameters.AddWithValue("@total", modelo.VendaTotal);
                cmd.Parameters.AddWithValue("@status", modelo.VendaStatus);
                cmd.Parameters.AddWithValue("@tipoTransacao", modelo.VendaTipoTransacao);
                cmd.Parameters.AddWithValue("@descricao", modelo.VendaDescricao);
                cmd.Parameters.AddWithValue("gastoNome", modelo.VendaGastoNome);

                modelo.VendaID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Incluir(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into venda (venda_data, venda_notaFiscal, venda_total, " +
                    "venda_status, tipoPagamento_id, venda_aVista, cliente_id) values (@data, @notaFiscal, @total, " +
                    "@status, @tipoPagamento, @aVista, @cliente); select @@IDENTITY;";
                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = modelo.VendaData;
                cmd.Parameters.AddWithValue("@notaFiscal", modelo.VendaNotaFiscal);
                cmd.Parameters.AddWithValue("@total", modelo.VendaTotal);
                cmd.Parameters.AddWithValue("@status", modelo.VendaStatus);
                cmd.Parameters.AddWithValue("@tipoPagamento", modelo.TipoPagamentoID);
                cmd.Parameters.AddWithValue("@aVista", modelo.VendaAVista);
                if (modelo.ClienteID == 0)
                {
                    cmd.Parameters.AddWithValue("@cliente", DBNull.Value); 
                }
                else
                {
                    cmd.Parameters.AddWithValue("@cliente", modelo.ClienteID);
                }


                modelo.VendaID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public void Alterar(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set venda_data = @data, venda_notaFiscal = @notaFiscal, " +
                    "venda_total = @total, venda_status = @status, " +
                    "tipoPagamento_id = @tipoPagamento, venda_aVista = @aVista, cliente_id = @cliente where venda_id = @id;";
                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = modelo.VendaData;
                cmd.Parameters.AddWithValue("@notaFiscal", modelo.VendaNotaFiscal);
                cmd.Parameters.AddWithValue("@total", modelo.VendaTotal);
                cmd.Parameters.AddWithValue("@status", modelo.VendaStatus);
                cmd.Parameters.AddWithValue("@tipoPagamento", modelo.TipoPagamentoID);
                cmd.Parameters.AddWithValue("@aVista", modelo.VendaAVista);
                cmd.Parameters.AddWithValue("@cliente", modelo.ClienteID);
                cmd.Parameters.AddWithValue("@id", modelo.VendaID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public void Excluir(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from venda where venda_id = @id;";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        // lista por venda
        public DataTable Localizar(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select venda_id, venda_data, venda_notaFiscal, venda_total, " +
                                              "venda_status, tipoPagamento_id, venda_aVista, cliente_id from venda where venda_id = " + id.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // localizar todas as vendas
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select venda_id, venda_data, venda_notaFiscal, venda_total, " +
                                                             "venda_status, tipoPagamento_id, venda_aVista, cliente_id from venda", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from venda where venda_data between @dtInicial and @dtFinal";
            cmd.Parameters.AddWithValue("@dtInicial", dataInicial);
            cmd.Parameters.AddWithValue("@dtFinal", dataFinal);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
        //cancelar venda percorrendo todos os itens da venda e devolvendo ao estoque
        public Boolean CancelarVenda(int id)
        {
            Boolean retorno = true;
            // atualizar o status da venda para cancelada
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();
            try
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set venda_status = 'Cancelada' where venda_id = @id;";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                // incrementar o estoque com os itens da venda cancelada
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select itensVenda_id, produto_id, itensVenda_qtde from itensVenda where venda_id = "
                    + id.ToString(), conexao.StringConexao);
                da.Fill(tabela);

                ModeloProduto produto;
                //DALConexao cxp = new DALConexao(DadosDaConexao.StringDeConexao); 
                //DALProduto dalProduto = new DALProduto(cxp);
                DALProduto dalProduto = new DALProduto(conexao);
                
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["produto_id"]), true);
                    produto.ProdutoLote = produto.ProdutoLote + Convert.ToDouble(tabela.Rows[i]["itensVenda_qtde"]);
                    dalProduto.Alterar(produto, true);
                }
                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch
            { 
                conexao.CancelarTransacao();
                conexao.Desconectar();
                retorno = false;
            }
            return retorno;
        }

        // carregar modelo
        public ModeloVenda CarregaModeloVenda(int id)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from venda where venda_id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.VendaID = Convert.ToInt32(registro["venda_id"]);
                modelo.VendaData = registro["venda_data"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(registro["venda_data"]);
                modelo.VendaNotaFiscal = registro["venda_notaFiscal"] == DBNull.Value ? 0 : Convert.ToInt32(registro["venda_notaFiscal"]);
                modelo.VendaTotal = registro["venda_total"] == DBNull.Value ? 0.0 : Convert.ToDouble(registro["venda_total"]);
                modelo.VendaStatus = registro["venda_status"] == DBNull.Value ? string.Empty : Convert.ToString(registro["venda_status"]);
                modelo.TipoPagamentoID = registro["tipoPagamento_id"] == DBNull.Value ? 0 : Convert.ToInt32(registro["tipoPagamento_id"]);
                modelo.VendaAVista = registro["venda_aVista"] == DBNull.Value ? 0 : Convert.ToInt32(registro["venda_aVista"]);
                modelo.ClienteID = registro["cliente_id"] == DBNull.Value ? 0 : Convert.ToInt32(registro["cliente_id"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }


    }
}
