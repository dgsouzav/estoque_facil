using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
                    "produto_lote, undmed_id, categoria_id, subCategoria_id, fornecedor_id, produto_qtde) values (@nome, @descricao, @valorpago, @valorvenda, " +
                    "@lote, @undmed, @categoria, @subcategoria, @fornecedor, @qtde); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.ProdutoNome);
                cmd.Parameters.AddWithValue("@descricao", modelo.ProdutoDescricao);
                cmd.Parameters.AddWithValue("@valorpago", modelo.ProdutoValorPago);
                cmd.Parameters.AddWithValue("@valorvenda", modelo.ProdutoValorVenda);
                cmd.Parameters.AddWithValue("@lote", modelo.ProdutoLote);
                cmd.Parameters.AddWithValue("@undmed", modelo.UndMedID);
                cmd.Parameters.AddWithValue("@categoria", modelo.CategoriaID);
                cmd.Parameters.AddWithValue("@subcategoria", modelo.SubCategoriaID);
                cmd.Parameters.AddWithValue("@fornecedor", modelo.FornecedorID);
                cmd.Parameters.AddWithValue("@qtde", modelo.ProdutoQtde);

                conexao.Conectar();
                modelo.ProdutoID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ModeloProduto obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update produto set produto_nome = (@nome), produto_descricao = (@descricao), produto_valorpago = (@valorpago), " +
                    "produto_valorvenda = (@valorvenda), produto_lote = (@lote), undmed_id = (@undmed), categoria_id = (@categoria), " +
                    "subCategoria_id = (@subcategoria),  fornecedor_id = (@fornecedor) where produto_id = (@id);";
                cmd.Parameters.AddWithValue("@id", obj.ProdutoID);
                cmd.Parameters.AddWithValue("@nome", obj.ProdutoNome);
                cmd.Parameters.AddWithValue("@descricao", obj.ProdutoDescricao);
                cmd.Parameters.AddWithValue("@valorpago", obj.ProdutoValorPago);
                cmd.Parameters.AddWithValue("@valorvenda", obj.ProdutoValorVenda);
                cmd.Parameters.AddWithValue("@lote", obj.ProdutoLote);
                cmd.Parameters.AddWithValue("@undmed", obj.UndMedID);
                cmd.Parameters.AddWithValue("@categoria", obj.CategoriaID);
                cmd.Parameters.AddWithValue("@subcategoria", obj.SubCategoriaID);
                cmd.Parameters.AddWithValue("@fornecedor", obj.FornecedorID);
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
                "p.produto_valorvenda, p.produto_lote, p.produto_qtde, u.undmed_nome, c.nome_categoria, sc.subCategoria_nome, f.fornecedor_nome from produto p " +
                "inner join unidadeMedida u on p.undmed_id = u.undmed_id " +
                "inner join categoria c on p.categoria_id = c.categoria_id " +
                "inner join subCategoria sc on p.subCategoria_id = sc.subcategoria_id " +
                "inner join fornecedor f on p.fornecedor_id = f.fornecedor_id " +
                "where p.produto_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarProdutoFaltante(String valor)
        {
            DataTable tabela = new DataTable();
            string query = "SELECT p.produto_id, p.produto_nome, p.produto_qtde FROM produto p WHERE p.produto_qtde < 100;";

            SqlDataAdapter da = new SqlDataAdapter(query, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public void Alterar(ModeloProduto obj, Boolean transacao)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update produto set produto_nome = @nome, produto_descricao = @descricao, produto_valorpago = @valorpago, " +
                "produto_valorvenda = @valorvenda, produto_lote = @lote, undmed_id = @undmedid, categoria_id = @categoriaid, " +
                "subCategoria_id = @subcategoriaid where produto_id = @id;";
            cmd.Parameters.AddWithValue("@nome", obj.ProdutoNome);
            cmd.Parameters.AddWithValue("@descricao", obj.ProdutoDescricao);
            cmd.Parameters.AddWithValue("@valorpago", obj.ProdutoValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", obj.ProdutoValorVenda);
            cmd.Parameters.AddWithValue("@lote", obj.ProdutoLote);
            cmd.Parameters.AddWithValue("@undmedid", obj.UndMedID);
            cmd.Parameters.AddWithValue("@categoriaid", obj.CategoriaID);
            cmd.Parameters.AddWithValue("@subcategoriaid", obj.SubCategoriaID);
            cmd.Parameters.AddWithValue("@id", obj.ProdutoID);

            cmd.Transaction = conexao.ObjetoTransacao;

            if (transacao)
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
        }
        public ModeloProduto CarregaModeloProduto(int id, Boolean transacao)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where produto_id = " + id.ToString();
            cmd.Parameters.AddWithValue("@id", id);
            if (transacao == false)
            {
                conexao.Conectar();
            }
            else
            {
                cmd.Transaction = conexao.ObjetoTransacao;
            }

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProdutoID = Convert.ToInt32(registro["produto_id"]);
                modelo.ProdutoNome = Convert.ToString(registro["produto_nome"]);
                modelo.ProdutoDescricao = Convert.ToString(registro["produto_descricao"]);
                modelo.ProdutoValorPago = Convert.ToDouble(registro["produto_valorpago"]);
                modelo.ProdutoValorVenda = Convert.ToDouble(registro["produto_valorvenda"]);
                modelo.ProdutoLote = Convert.ToDouble(registro["produto_lote"]);
                modelo.ProdutoQtde = Convert.ToInt32(registro["produto_qtde"]);
                modelo.UndMedID = Convert.ToInt32(registro["undmed_id"]);
                modelo.CategoriaID = Convert.ToInt32(registro["categoria_id"]);
                modelo.SubCategoriaID = Convert.ToInt32(registro["subCategoria_id"]);
                modelo.FornecedorID = Convert.ToInt32(registro["fornecedor_id"]);
            }
            registro.Close();
            if (transacao == false)
            {
                conexao.Desconectar();
            }
            return modelo;
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
                modelo.ProdutoLote = Convert.ToDouble(registro["produto_lote"]);
                modelo.ProdutoQtde = Convert.ToInt32(registro["produto_qtde"]);
                modelo.CategoriaID = Convert.ToInt32(registro["categoria_id"]);
                modelo.SubCategoriaID = Convert.ToInt32(registro["subCategoria_id"]);
                modelo.FornecedorID = Convert.ToInt32(registro["fornecedor_id"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
