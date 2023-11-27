using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALSubCategoria
    {
        private DALConexao conexao;
        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into subCategoria(subCategoria_nome, categoria_id) values (@nome, @categoria_id); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.SubCategoriaNome);
                cmd.Parameters.AddWithValue("@categoria_id", modelo.CategoriaID);

                conexao.Conectar();
                modelo.CategoriaID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subCategoria set subCategoria_nome = @nome, categoria_id = @categoria_id where subCategoria_id = @subCategoria_id;";
                cmd.Parameters.AddWithValue("@nome", modelo.SubCategoriaNome);
                cmd.Parameters.AddWithValue("@categoria_id", modelo.CategoriaID);
                cmd.Parameters.AddWithValue("@subCategoria_id", modelo.SubCategoriaID);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
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
                cmd.CommandText = "delete from subCategoria where subCategoria_id = @id;";
                cmd.Parameters.AddWithValue("@id", id);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sc.subCategoria_id, sc.subCategoria_nome, sc.categoria_id, c.nome_categoria" +
                " from subCategoria sc inner join categoria c on sc.categoria_id = c.categoria_id where subCategoria_nome like '%" +
                valor + "%'", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorCategoria(int categoria)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sc.subCategoria_id, sc.subCategoria_nome, sc.categoria_id, c.nome_categoria" +
                               " from subCategoria sc inner join categoria c on sc.categoria_id = c.categoria_id where sc.categoria_id = " +
                                              categoria.ToString(), conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }
        
        public ModeloSubCategoria CarregaModeloSubCategoria(int id)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao; 
            cmd.CommandText = "select * from subCategoria where subCategoria_id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.SubCategoriaID = Convert.ToInt32(registro["subCategoria_id"]);
                modelo.SubCategoriaNome = Convert.ToString(registro["subCategoria_nome"]);
                modelo.CategoriaID = Convert.ToInt32(registro["categoria_id"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}

