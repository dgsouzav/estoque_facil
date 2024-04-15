using Modelo;
using System.Data;
using System.Data.SqlClient;

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
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into parcelasCompra (parcelasCompra_id, parcelasCompra_valor, parcelasCompra_dataVencimento, compra_id) values " +
                    "(@parcelasCompra_id, @parcelasCompra_valor, @parcelasCompra_dataVencimento, @compra_id); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@parcelasCompra_id", modelo.ParcelasCompraID);
                cmd.Parameters.AddWithValue("@parcelasCompra_valor", modelo.ParcelasCompraValor);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                cmd.Parameters.Add("@parcelasCompra_dataVencimento", SqlDbType.Date);

                if(modelo.ParcelasCompraDataVencimento == null)
                {
                    cmd.Parameters["@parcelasCompra_dataVencimento"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@parcelasCompra_dataVencimento"].Value = modelo.ParcelasCompraDataVencimento;
                }

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EfetuaPagamentoParcela(int compraID, int parcelasCompraID, DateTime parcelasCompra_dataPagamento)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update parcelasCompra set parcelasCompra_dataPagamento = @dataPagamento " +
                "where parcelasCompra_id = @parcelasCompraid and compra_id = @compraid;";
            cmd.Parameters.AddWithValue("@parcelasCompraid", parcelasCompraID);
            cmd.Parameters.AddWithValue("@compraid", compraID);
            cmd.Parameters.Add("@dataPagamento", SqlDbType.Date);
            cmd.Parameters["@dataPagamento"].Value = parcelasCompra_dataPagamento.Date;

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
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

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
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
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from parcelasCompra where parcelasCompra_id = @parcelasCompra_id and compra_id = @compra_id;";
                cmd.Parameters.AddWithValue("@parcelasCompra_id", modelo.ParcelasCompraID);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                
                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirParcelas(int compra_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from parcelasCompra where compra_id = @compra_id;";
                cmd.Parameters.AddWithValue("@compra_id", compra_id);

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Localizar(int compra_id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from parcelasCompra where compra_id = " 
                + compra_id.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloParcelasCompra CarregaModeloParcelasCompra(int ParcelasCompraID, int CompraID)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelasCompra where parcelasCompra_id = @parcelasCompra_id and " +
                "compra_id = @compra_id;";
            cmd.Parameters.AddWithValue("@parcelasCompra_id", ParcelasCompraID);
            cmd.Parameters.AddWithValue("@compra_id", CompraID);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ParcelasCompraID = ParcelasCompraID;
                modelo.CompraID = CompraID;
                modelo.ParcelasCompraValor = Convert.ToDouble(registro["parcelasCompra_valor"]);
                modelo.ParcelasCompraDataPagamento = Convert.ToDateTime(registro["parcelasCompra_dataPagamento"]);
                modelo.ParcelasCompraDataVencimento = Convert.ToDateTime(registro["parcelasCompra_dataVencimento"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
