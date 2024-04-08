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
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
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
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            conexao.Desconectar();
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
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from subCategoria where subCategoria_nome like '%" +
                               valor + "%'", conexao.StringConexao);
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
            conexao.Desconectar();
            return modelo;
        }
    }
}

