using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

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
                cmd.CommandText = "insert into unidadeMedida(undmed_nome) values (@nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.UndMedNome);

                conexao.Conectar();
                modelo.UndMedID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        } 

        public void Alterar(ModeloUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update unidadeMedida set undmed_nome = @nome where undmed_id = @id;";
                cmd.Parameters.AddWithValue("@nome", modelo.UndMedNome);
                cmd.Parameters.AddWithValue("@id", modelo.UndMedID);

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
                cmd.CommandText = "delete from unidadeMedida where undmed_id = @id;";
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
            SqlDataAdapter da = new SqlDataAdapter("select * from unidadeMedida where undmed_nome like '%" + 
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public int VerificaUnidadeMedida(string nomeUnidadeMedida)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select undmed_id from unidadeMedida where undmed_nome = @nome;";
                cmd.Parameters.AddWithValue("@nome", nomeUnidadeMedida);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    resultado = Convert.ToInt32(registro["undmed_id"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return resultado;
        }


        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int id)
        {
            ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from unidadeMedida where undmed_id = @id;";
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
