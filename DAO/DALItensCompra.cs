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
    public class DALItensCompra
    {
        DALConexao conexao;
        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into itensCompra(itensCompra_qtde, itensCompra_valor, compra_id, produto_id) values " +
                    "(@itensCompra_qtde, @itensCompra_valor, @compra_id, @produto_id);";
                cmd.Parameters.AddWithValue("@itensCompra_qtde", modelo.ItensCompraQtde);
                cmd.Parameters.AddWithValue("@itensCompra_valor", modelo.ItensCompraValor);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                cmd.Parameters.AddWithValue("@produto_id", modelo.ProdutoID);

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itensCompra set itensCompra_qtde = @itensCompra_qtde, itensCompra_valor = @itensCompra_valor, " +
                    "where itensCompra_id = @itensCompra_id and compra_id = @compra_id and produto_id = @produto_id;";
                cmd.Parameters.AddWithValue("@itensCompra_id", modelo.ItensCompraID);
                cmd.Parameters.AddWithValue("@itensCompra_qtde", modelo.ItensCompraQtde);
                cmd.Parameters.AddWithValue("@itensCompra_valor", modelo.ItensCompraValor);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                cmd.Parameters.AddWithValue("@produto_id", modelo.ProdutoID);

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itensCompra where where itensCompra_id = @itensCompra_id and compra_id = @compra_id and produto_id = @produto_id;";
                cmd.Parameters.AddWithValue("@itensCompra_id", modelo.ItensCompraID);
                cmd.Parameters.AddWithValue("@compra_id", modelo.CompraID);
                cmd.Parameters.AddWithValue("@produto_id", modelo.ProdutoID);

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ExcluirItens(int compra_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itensCompra where compra_id = @compra_id;";
                cmd.Parameters.AddWithValue("@compra_id", compra_id);
                
                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ModeloItensCompra CarregaModeloItensCompra(int ItensCompraID, int CompraID, int ProdutoID)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itensCompra where where itensCompra_id = @itensCompra_id and compra_id = @compra_id and produto_id = @produto_id;";
            cmd.Parameters.AddWithValue("@itensCompra_id", ItensCompraID);
            cmd.Parameters.AddWithValue("@compra_id", CompraID);
            cmd.Parameters.AddWithValue("@produto_id", ProdutoID);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItensCompraID = ItensCompraID;
                modelo.ItensCompraQtde = Convert.ToDouble(registro["itensCompra_qtde"]);
                modelo.ItensCompraValor = Convert.ToDouble(registro["itensCompra_valor"]);
                modelo.CompraID = CompraID;
                modelo.ProdutoID = ProdutoID;
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
        public DataTable Localizar(int compra_id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select i.compra_id, i.itensCompra_id, i.produto_id, p.produto_nome, i.itensCompra_qtde, i.itensCompra_valor from itensCompra i " +
                "inner join produto p on p.produto_id = i.produto_id where i.compra_id ="
                + compra_id.ToString(), conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }
    }
}
