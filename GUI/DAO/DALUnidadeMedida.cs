using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using BLL;
using System.Data;

namespace DAL
{
    public class DALUnidadeMedida
    {
        private DALConexao conexao;
        public DALUnidadeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into undmedida(undmed_nome) values (@nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.UndMedNome);
                conexao.Conectar();
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

        public void Alterar(ModeloUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update undmedida set undmed_nome = @nome where undmed_id = @codigo;";
                cmd.Parameters.AddWithValue("@nome", modelo.UndMedNome);
                cmd.Parameters.AddWithValue("@codigo", modelo.UndMedID);
                conexao.Conectar();
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

        public void Excluir(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from undmedida where undmed_id = @id;";
                cmd.Parameters.AddWithValue("@id", id);
                conexao.Conectar();
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
            SqlDataAdapter da = new SqlDataAdapter("select * from undmedida where undmed_nome like '%" + 
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int id)
        {
            ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from undmedida where undmed_id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UndMedID = Convert.ToInt32(registro["undmed_id"]);
                modelo.UndMedNome = Convert.ToString(registro["undmed_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
