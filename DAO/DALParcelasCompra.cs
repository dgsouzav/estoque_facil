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
    public class DALParcelasCompra
    {
        private DALConexao conexao;
        public DALParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into parcelasCompra (parcelasCompra_id, parcelasCompra_valor, parcelasCompra_dataVencimento, compra_id) values " +
                    "(@parcelasCompra_id, @parcelasCompra_valor, @parcelasCompra_dataVencimento, @compra_id); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@parcelasCompra_id", modelo.ParcelasCompraID);
                cmd.Parameters.AddWithValue("@parcelasCompra_valor", modelo.ParcelasCompraValor);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                cmd.Parameters.Add("@parcelasDataVencimento", SqlDbType.Date);

                if(modelo.ParcelasCompraDataVencimento == null)
                {
                    cmd.Parameters["@parcelasDataVencimento"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@parcelasDataVencimento"].Value = modelo.ParcelasCompraDataVencimento;
                }

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Alterar(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update parcelasCompra set parcelasCompra_valor = @parcelasCompra_valor, parcelasCompra_dataPagamento = @parcelasCompra_dataPagamento," +
                    " parcelasCompra_dataVencimento = @parcelasCompra_dataVencimento, " +
                    " where parcelasCompra_id = @parcelasCompra_id and compra_id = @compra_id;";
                cmd.Parameters.AddWithValue("@parcelasCompra_id", modelo.ParcelasCompraID);
                cmd.Parameters.AddWithValue("@parcelasCompra_valor", modelo.ParcelasCompraValor);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                cmd.Parameters.Add("@parcelasDataPagamento", SqlDbType.Date);
                cmd.Parameters.Add("@parcelasDataVencimento", SqlDbType.Date);

                if(modelo.ParcelasCompraDataPagamento == null)
                {
                    cmd.Parameters["@parcelasDataPagamento"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@parcelasDataPagamento"].Value = modelo.ParcelasCompraDataPagamento;
                }

                cmd.Parameters["@parcelasDataVencimento"].Value = modelo.ParcelasCompraDataVencimento;

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from parcelasCompra where parcelasCompra_id = @parcelasCompra_id and compra_id = @compra_id;";
                cmd.Parameters.AddWithValue("@parcelasCompra_id", modelo.ParcelasCompraID);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
