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
    public class DALCompra
    {
        private DALConexao conexao;

        //arredondamento de valores

        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into compra(compra_data, compra_notaFiscal, compra_total, " +
                    "compra_numeroParcelas, compra_status, fornecedor_id, tipoPagamento_id) values " +
                    "(@data, @notaFiscal, @total, @numeroParcelas, @status, @fornecedor, @tipoPagamento); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = modelo.CompraData;
                cmd.Parameters.AddWithValue("@notaFiscal", modelo.CompraNotaFiscal);
                cmd.Parameters.AddWithValue("@total", modelo.CompraTotal);
                cmd.Parameters.AddWithValue("@numeroParcelas", modelo.CompraNumeroParcelas);
                cmd.Parameters.AddWithValue("@status", modelo.CompraStatus);
                cmd.Parameters.AddWithValue("@fornecedor", modelo.FornecedorID);
                cmd.Parameters.AddWithValue("@tipoPagamento", modelo.TipoPagamentoID);

                conexao.Conectar();
                modelo.CompraID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void Alterar(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update compra set compra_data = @data, compra_notaFiscal = @notaFiscal, compra_total = @total," +
                    " compra_numeroParcelas = @numeroParcelas, compra_status = @status, fornecedor_id = @fornecedor, " +
                    "tipoPagamento_id = @tipoPagamento where compra_id = @id;";
                cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = modelo.CompraData;
                cmd.Parameters.AddWithValue("@notaFiscal", modelo.CompraNotaFiscal);
                cmd.Parameters.AddWithValue("@total", modelo.CompraTotal);
                cmd.Parameters.AddWithValue("@numeroParcelas", modelo.CompraNumeroParcelas);
                cmd.Parameters.AddWithValue("@status", modelo.CompraStatus);
                cmd.Parameters.AddWithValue("@fornecedor", modelo.FornecedorID);
                cmd.Parameters.AddWithValue("@tipoPagamento", modelo.TipoPagamentoID);
                cmd.Parameters.AddWithValue("@id", modelo.CompraID);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from compra where compra_id = @id;";
                cmd.Parameters.AddWithValue("@id", id);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // lista por compra
        public DataTable Localizar(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.compra_id, c.compra_data, c.compra_notaFiscal, f.fornecedor_nome, c.compra_numeroParcelas, " +
                 "c.compra_status, c.fornecedor_id, c.tipoPagamento_id, c.compra_total " +
                 "from compra c inner join fornecedor f on c.fornecedor_id = f.fornecedor_id where " +
                 "c.fornecedor_id = " + id.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        // lista pelo nome do fornecedor
        public DataTable Localizar(string nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.compra_id, c.compra_data, c.compra_notaFiscal, f.fornecedor_nome, c.compra_numeroParcelas, " +
                 "c.compra_status, c.fornecedor_id, c.tipoPagamento_id, c.compra_total " +
                 "from compra c inner join fornecedor f on c.fornecedor_id = f.fornecedor_id where " +
                "f.fornecedor_nome like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        // lista por data inicial e final
        public DataTable Localizar(DateTime DataInicial, DateTime DataFinal)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select c.compra_id, c.compra_data, c.compra_notaFiscal, f.fornecedor_nome, c.compra_numeroParcelas, " +
                 "c.compra_status, c.fornecedor_id, c.tipoPagamento_id, c.compra_total " +
                 "from compra c inner join fornecedor f on c.fornecedor_id = f.fornecedor_id where " +
                 "c.compra_data between @dataInicial and @dataFinal";
            cmd.Parameters.Add("@dataInicial", SqlDbType.DateTime);
            cmd.Parameters["@dataInicial"].Value = DataInicial;
            cmd.Parameters.AddWithValue("@dataFinal", SqlDbType.DateTime);
            cmd.Parameters["@dataFinal"].Value = DataFinal;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
        // lista todas compras
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.compra_id, c.compra_data, c.compra_notaFiscal, f.fornecedor_nome, c.compra_numeroParcelas, " +
                 "c.compra_status, c.fornecedor_id, c.tipoPagamento_id, c.compra_total " +
                 "from compra c inner join fornecedor f on c.fornecedor_id = f.fornecedor_id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        // localizar pelas parcelas nao pagas
        public DataTable LocalizarParcelasNaoPagas()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select distinct c.compra_id, c.compra_data, c.compra_notaFiscal, f.fornecedor_nome, c.compra_numeroParcelas, " +
                "c.compra_status, c.fornecedor_id, c.tipoPagamento_id, c.compra_total from compra c inner join fornecedor f on " +
                "c.fornecedor_id = f.fornecedor_id inner join parcelasCompra p on c.compra_id = p.compra_id where p.parcelasCompra_dataPagamento is NULL", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloCompra CarregaModeloCompra(int id)
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from compra where compra_id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CompraID = Convert.ToInt32(registro["compra_id"]);
                modelo.CompraData = Convert.ToDateTime(registro["compra_data"]);
                modelo.CompraNotaFiscal = Convert.ToInt32(registro["compra_notaFiscal"]);
                modelo.CompraTotal = Convert.ToDouble(registro["compra_total"]);
                modelo.CompraNumeroParcelas = Convert.ToInt32(registro["compra_numeroParcelas"]);
                modelo.CompraStatus = Convert.ToString(registro["compra_status"]);
                modelo.FornecedorID = Convert.ToInt32(registro["fornecedor_id"]);
                modelo.TipoPagamentoID = Convert.ToInt32(registro["tipoPagamento_id"]);
            }
            conexao.Desconectar();
            return modelo;
        }
            
    }
}
