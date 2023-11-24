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
                cmd.Parameters.AddWithValue("@data", modelo.VendaData);
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

    }
}
