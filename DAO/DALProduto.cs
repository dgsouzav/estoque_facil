using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;
        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into produto(produto_nome, produto_descricao, produto_valorpago, produto_valorvenda, " +
                    "produto_qtde, undmed_id, categoria_id, subCategoria_id) values (@nome, @descricao, @valorpago, @valorvenda, " +
                    "@qtde, @undmed, @categoria, @subcategoria); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.ProdutoNome);
                cmd.Parameters.AddWithValue("@descricao", modelo.ProdutoDescricao);
                cmd.Parameters.AddWithValue("@valorpago", modelo.ProdutoValorPago);
                cmd.Parameters.AddWithValue("@valorvenda", modelo.ProdutoValorVenda);
                cmd.Parameters.AddWithValue("@qtde", modelo.ProdutoQtde);
                cmd.Parameters.AddWithValue("@undmed", modelo.UndMedID);
                cmd.Parameters.AddWithValue("@categoria", modelo.CategoriaID);
                cmd.Parameters.AddWithValue("@subcategoria", modelo.SubCategoriaID);

                conexao.Conectar();
                modelo.ProdutoID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update produto set produto_nome = @nome, produto_descricao = @descricao, produto_valorpago = @valorpago, " +
                    "produto_valorvenda = @valorvenda, produto_qtde = @qtde, undmed_id = @undmed, categoria_id = @categoria, " +
                    "subCategoria_id = @subcategoria where produto_id = @id;";
                cmd.Parameters.AddWithValue("@id", modelo.ProdutoID);
                cmd.Parameters.AddWithValue("@nome", modelo.ProdutoNome);
                cmd.Parameters.AddWithValue("@descricao", modelo.ProdutoDescricao);
                cmd.Parameters.AddWithValue("@valorpago", modelo.ProdutoValorPago);
                cmd.Parameters.AddWithValue("@valorvenda", modelo.ProdutoValorVenda);
                cmd.Parameters.AddWithValue("@qtde", modelo.ProdutoQtde);
                cmd.Parameters.AddWithValue("@undmed", modelo.UndMedID);
                cmd.Parameters.AddWithValue("@categoria", modelo.CategoriaID);
                cmd.Parameters.AddWithValue("@subcategoria", modelo.SubCategoriaID);
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
                cmd.CommandText = "delete from produto where produto_id = @id;";
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
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select p.produto_id, p.produto_nome, p.produto_descricao, p.produto_valorpago, " +
                "p.produto_valorvenda, p.produto_qtde, u.undmed_nome, c.nome_categoria, sc.subCategoria_nome " +
                "from produto p " +
                "inner join unidadeMedida u on p.undmed_id = u.undmed_id " +
                "inner join categoria c on p.categoria_id = c.categoria_id " +
                "inner join subCategoria sc on p.subCategoria_id = sc.subcategoria_id " +
                "where p.produto_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int id)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where produto_id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProdutoID = Convert.ToInt32(registro["produto_id"]);
                modelo.ProdutoNome = Convert.ToString(registro["produto_nome"]);
                modelo.ProdutoValorPago = Convert.ToDouble(registro["produto_valorpago"]);
                modelo.ProdutoValorVenda = Convert.ToDouble(registro["produto_valorvenda"]);
                modelo.UndMedID = Convert.ToInt32(registro["undmed_id"]);
                modelo.ProdutoQtde = Convert.ToDouble(registro["produto_qtde"]);
                modelo.CategoriaID = Convert.ToInt32(registro["categoria_id"]);
                modelo.SubCategoriaID = Convert.ToInt32(registro["subCategoria_id"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
