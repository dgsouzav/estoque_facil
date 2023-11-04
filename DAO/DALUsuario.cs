using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario(usuario_nome, usuario_senha, usuario_tipo, usuario_fone, usuario_email) values (@nome, @senha, @tipo, @fone, @email)";
            cmd.Parameters.AddWithValue("@nome", modelo.UsuarioNome);
            cmd.Parameters.AddWithValue("@senha", modelo.UsuarioSenha);
            cmd.Parameters.AddWithValue("@tipo", modelo.UsuarioTipo);
            cmd.Parameters.AddWithValue("@fone", modelo.UsuarioFone);
            cmd.Parameters.AddWithValue("@email", modelo.UsuarioEmail);

            conexao.Conectar();
            modelo.UsuarioID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set usuario_id = @id, usuario_nome = @nome, usuario_senha = @senha, usuario_tipo = @tipo, usuario_fone = @fone, usuario_email = @email";
            cmd.Parameters.AddWithValue("@id", modelo.UsuarioID);
            cmd.Parameters.AddWithValue("@nome", modelo.UsuarioNome);
            cmd.Parameters.AddWithValue("@senha", modelo.UsuarioSenha);
            cmd.Parameters.AddWithValue("@tipo", modelo.UsuarioTipo);
            cmd.Parameters.AddWithValue("@fone", modelo.UsuarioFone);
            cmd.Parameters.AddWithValue("@email", modelo.UsuarioEmail);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuario where usuario_id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usuario_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloUsuario CarregaModeloUsuario(int id)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usuario_id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuarioID = Convert.ToInt32(registro["usuario_id"]);
                modelo.UsuarioNome = Convert.ToString(registro["usuario_nome"]);
                modelo.UsuarioSenha = Convert.ToString(registro["usuario_senha"]);
                modelo.UsuarioTipo = Convert.ToString(registro["usuario_tipo"]);
                modelo.UsuarioFone = Convert.ToString(registro["usuario_fone"]);
                modelo.UsuarioEmail = Convert.ToString(registro["usuario_email"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
