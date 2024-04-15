using Modelo;
using System.Data;
using System.Data.SqlClient;
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
        public void Incluir(ModeloUsuario modelo)
        {
            try
            {
                string senhaCriptografada = modelo.UsuarioSenha; // Já está criptografada
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO usuario(usuario_nome, usuario_senha, usuario_nivelAcesso, usuario_status) VALUES (@nome, @senha, @nivelAcesso, @status)";
                cmd.Parameters.AddWithValue("@nome", modelo.UsuarioNome);
                cmd.Parameters.AddWithValue("@senha", senhaCriptografada); // Utiliza a senha criptografada
                cmd.Parameters.AddWithValue("@nivelAcesso", modelo.UsuarioNivelAcesso);
                cmd.Parameters.AddWithValue("@status", "Ativo"); // Define o status como Ativo

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
                cmd.CommandText = "UPDATE usuario SET usuario_nome = @nome, usuario_senha = @senha, usuario_nivelAcesso = @nivelAcesso WHERE usuario_id = @id";
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
                cmd.CommandText = "UPDATE usuario SET usuario_status = 'Inativo' WHERE usuario_id = @id";
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

        public DataTable Localizar(String id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usuario_id like '%" + id + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public static string CriptografarSenha(string senha)
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
                    if (Convert.ToString(dr["usuario_senha"]) == CriptografarSenha(senha))
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
                modelo.UsuarioSenha = DescriptografarSenha(Convert.ToString(registro["usuario_senha"])); // Descriptografa a senha
                modelo.UsuarioNivelAcesso = Convert.ToString(registro["usuario_nivelAcesso"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        private string DescriptografarSenha(string senhaCriptografada)
        {
            // A chave de criptografia pode ser um valor fixo ou derivada da própria senha.
            // Aqui, por simplicidade, estou usando uma chave fixa.
            string chave = "chave_para_descriptografar";

            try
            {
                // Converte a senha criptografada de hexadecimal para bytes
                byte[] bytesCriptografados = Enumerable.Range(0, senhaCriptografada.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(senhaCriptografada.Substring(x, 2), 16))
                    .ToArray();

                // Cria um objeto de criptografia simétrica
                using (Aes aesAlg = Aes.Create())
                {
                    // Configura a chave e o IV
                    aesAlg.Key = Encoding.UTF8.GetBytes(chave);
                    aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                    // Cria um objeto de descriptografia
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Cria o fluxo de memória para a descriptografia
                    using (MemoryStream msDecrypt = new MemoryStream(bytesCriptografados))
                    {
                        // Cria o fluxo de criptografia para a descriptografia
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            // Cria um leitor para o fluxo de descriptografia
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                // Lê o texto descriptografado do leitor
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch
            {
                // Em caso de erro na descriptografia, retorna a senha criptografada mesmo
                return senhaCriptografada;
            }
        }
    }
}
