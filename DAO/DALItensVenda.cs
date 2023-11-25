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
    public class DALItensVenda
    {
        DALConexao conexao;
        public DALItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into itensVenda(itensVenda_id, itensVenda_qtde, itensVenda_valor, venda_id, produto_id) values " +
                    "(@itensVenda_id, @itensVenda_qtde, @itensVenda_valor, @venda_id, @produto_id);";
                cmd.Parameters.AddWithValue("@itensVenda_id", modelo.ItensVendaID);
                cmd.Parameters.AddWithValue("@itensVenda_qtde", modelo.ItensVendaQtde);
                cmd.Parameters.AddWithValue("@itensVenda_valor", modelo.ItensVendaValor);
                cmd.Parameters.AddWithValue("@venda_id", modelo.VendaID);
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
        public void Alterar(ModeloItensVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itensVenda set itensVenda_qtde = @itensVenda_qtde, itensVenda_valor = @itensVenda_valor, " +
                    "where itensVenda_id = @itensVenda_id and venda_id = @venda_id and produto_id = @produto_id;";
                cmd.Parameters.AddWithValue("@itensVenda_id", modelo.ItensVendaID);
                cmd.Parameters.AddWithValue("@itensVenda_qtde", modelo.ItensVendaQtde);
                cmd.Parameters.AddWithValue("@itensVenda_valor", modelo.ItensVendaValor);
                cmd.Parameters.AddWithValue("@venda_id", modelo.VendaID);
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
        public void Excluir(ModeloItensVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itensVenda where itensVenda_id = @itensVenda_id and venda_id = @venda_id and produto_id = @produto_id;";
                cmd.Parameters.AddWithValue("@itensVenda_id", modelo.ItensVendaID);
                cmd.Parameters.AddWithValue("@venda_id", modelo.VendaID);
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
        public void ExcluirTodosItens(int venda_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from itensVenda where venda_id = @venda_id;";
                cmd.Parameters.AddWithValue("@venda_id", venda_id);

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Localizar(int venda_id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select i.itensVenda_id, i.itensVenda_qtde, i.itensVenda_valor, i.venda_id, i.produto_id, p.produto_nome " +
                                   "from itensVenda i inner join produto p on i.produto_id = p.produto_id where i.venda_id = " + venda_id.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloItensVenda CarregaModeloItensVenda(int ItensVendaID, int VendaID, int ProdutoID)
        {
            ModeloItensVenda modelo = new ModeloItensVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itensVenda where itensVenda_id = @itensVenda_id and venda_id = @venda_id and produto_id = @produto_id;";
            cmd.Parameters.AddWithValue("@itensVenda_id", ItensVendaID);
            cmd.Parameters.AddWithValue("@venda_id", VendaID);
            cmd.Parameters.AddWithValue("@produto_id", ProdutoID);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItensVendaID = ItensVendaID;
                modelo.ItensVendaQtde = Convert.ToDouble(registro["itensVenda_qtde"]);
                modelo.ItensVendaValor = Convert.ToDouble(registro["itensVenda_valor"]);
                modelo.VendaID = VendaID;
                modelo.ProdutoID = ProdutoID;
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
