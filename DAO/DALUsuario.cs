using Modelo;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void Incluir(ModeloUsuario modelo)
        {
            try
            {
                string senhaCriptografada = CriptografarSenha(modelo.UsuarioSenha);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into usuario(usuario_nome, usuario_senha, usuario_nivelAcesso) values (@nome, @senha, @nivelAcesso)";
                cmd.Parameters.AddWithValue("@nome", modelo.UsuarioNome);
                cmd.Parameters.AddWithValue("@senha", modelo.UsuarioSenha);
                cmd.Parameters.AddWithValue("@nivelAcesso", modelo.UsuarioNivelAcesso);


                conexao.Conectar();
                modelo.UsuarioID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Alterar(ModeloUsuario modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update usuario set usuario_id = @id, usuario_nome = @nome, usuario_senha = @senha, usuario_nivelAcesso = @nivelAcesso";
                cmd.Parameters.AddWithValue("@id", modelo.UsuarioID);
                cmd.Parameters.AddWithValue("@nome", modelo.UsuarioNome);
                cmd.Parameters.AddWithValue("@senha", modelo.UsuarioSenha);
                cmd.Parameters.AddWithValue("@nivelAcesso", modelo.UsuarioNivelAcesso);

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
                cmd.CommandText = "delete from usuario where usuario_id = @id";
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
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usuario_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public string Autenticar(string nome, string senha)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM usuario WHERE usuario_nome = @nome;";
            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                Console.WriteLine(cmd.CommandText);
                conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (Convert.ToString(dr["usuario_senha"]) == senha)
                    {
                        return Convert.ToString(dr["usuario_nivelAcesso"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return "";
            }
            finally
            {
                conexao.Desconectar();
            }

            return "";
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
                modelo.UsuarioNivelAcesso = Convert.ToString(registro["usuario_nivelAcesso"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

    }
}
