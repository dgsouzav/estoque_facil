using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVenda
    {
        DALConexao conexao;
        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into venda (venda_data, venda_notaFiscal, venda_total, venda_numeroParcelas, " +
                    "venda_status, tipoPagamento_id, venda_aVista) values (@data, @notaFiscal, @total, @numeroParcelas, " +
                    "@status, @tipoPagamento, @aVista); select @@IDENTITY;";
                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = modelo.VendaData;
                cmd.Parameters.AddWithValue("@notaFiscal", modelo.VendaNotaFiscal);
                cmd.Parameters.AddWithValue("@total", modelo.VendaTotal);
                cmd.Parameters.AddWithValue("@numeroParcelas", modelo.VendaNumeroParcelas);
                cmd.Parameters.AddWithValue("@status", modelo.VendaStatus);
                cmd.Parameters.AddWithValue("@tipoPagamento", modelo.TipoPagamentoID);
                cmd.Parameters.AddWithValue("@aVista", modelo.VendaAVista);

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
                    "venda_total = @total, venda_numeroParcelas = @numeroParcelas, venda_status = @status, " +
                    "tipoPagamento_id = @tipoPagamento, venda_aVista = @aVista where venda_id = @id;";
                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = modelo.VendaData;
                cmd.Parameters.AddWithValue("@notaFiscal", modelo.VendaNotaFiscal);
                cmd.Parameters.AddWithValue("@total", modelo.VendaTotal);
                cmd.Parameters.AddWithValue("@numeroParcelas", modelo.VendaNumeroParcelas);
                cmd.Parameters.AddWithValue("@status", modelo.VendaStatus);
                cmd.Parameters.AddWithValue("@tipoPagamento", modelo.TipoPagamentoID);
                cmd.Parameters.AddWithValue("@aVista", modelo.VendaAVista);
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
            SqlDataAdapter da = new SqlDataAdapter("select venda_id, venda_data, venda_notaFiscal, venda_total, venda_numeroParcelas, " +
                                              "venda_status, tipoPagamento_id, venda_aVista from venda where venda_id = " + id.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // localizar todas as vendas
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select venda_id, venda_data, venda_notaFiscal, venda_total, venda_numeroParcelas, " +
                                                             "venda_status, tipoPagamento_id, venda_aVista from venda", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // retorna a quantidade de parcelas nao pagas
        public int QuantidadeParcelasNaoPagas(int venda_id)
        {
            int qtde = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select count(venda_id) from parcelasVenda where venda_id = @id and parcelasVenda_dataPagamento is NULL";
            cmd.Parameters.AddWithValue("@id", venda_id);

            conexao.Conectar();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
            return qtde;
        }

        //quantidade de parcelas em aberto(nao pagas)
        public DataTable LocalizarParcelasNaoPagas()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select distinct v.venda_id, v.venda_data, v.venda_notaFiscal, v.venda_total, v.venda_numeroParcelas, " +
                               "v.venda_status, v.tipoPagamento_id, v.venda_aVista from venda v inner join parcelasVenda p on v.venda_id = p.venda_id where " +
                               "p.parcelasVenda_dataPagamento is NULL", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //localizar por data inicial e final
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
        public bool CancelarVenda(int id)
        {
            bool retorno = true;
            // atualizar o status da venda para cancelada
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();
            try
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set venda_status = 'cancelada' where venda_id = @id;";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                // incrementar o estoque com os itens da venda cancelada
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select itensVenda_id, produto_id, itensVenda_qtde, from itensVenda where venda_id = "
                    + id.ToString(), conexao.StringConexao);
                da.Fill(tabela);

                ModeloProduto produto;

                // percorrer os itens da venda cancelada
                DALProduto dalProduto = new DALProduto(conexao);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["produto_id"]), true);

                    produto.ProdutoQtde = produto.ProdutoQtde + Convert.ToDouble(tabela.Rows[i]["itensVenda_qtde"]);
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
                modelo.VendaData = Convert.ToDateTime(registro["venda_data"]);
                modelo.VendaNotaFiscal = Convert.ToInt32(registro["venda_notaFiscal"]);
                modelo.VendaTotal = Convert.ToDouble(registro["venda_total"]);
                modelo.VendaNumeroParcelas = Convert.ToInt32(registro["venda_numeroParcelas"]);
                modelo.VendaStatus = Convert.ToString(registro["venda_status"]);
                modelo.TipoPagamentoID = Convert.ToInt32(registro["tipoPagamento_id"]);
                modelo.VendaAVista = Convert.ToInt32(registro["venda_aVista"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        
    }
}
