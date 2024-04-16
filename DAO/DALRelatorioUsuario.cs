using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioUsuario
    {
        DALConexao conexao;
        public DALRelatorioUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public class UsuarioRelatorio
        {
            int _id;
            string _nome;
            string _status;
            string _nivelAcesso;
            public UsuarioRelatorio(int id, string nome, string status, string nivelAcesso)
            {
                this._id = id;
                this._nome = nome;
                this._nivelAcesso = nivelAcesso;
                this._status = status;
            }
            public int Id { get { return _id; } }
            public string Nome { get { return _nome; } }
            public string Status { get { return _status; } }
            public string NivelAcesso { get { return _nivelAcesso; } }
        }
        public List<UsuarioRelatorio>? ObterLinhasUsuario(string nomeTabela)
        {
            List<UsuarioRelatorio> usuarioColunas = new List<UsuarioRelatorio>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM usuario;");
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    UsuarioRelatorio usuario = new UsuarioRelatorio(Convert.ToInt32(dr["usuario_id"]), dr["usuario_nome"].ToString(), dr["usuario_status"].ToString(), dr["usuario_nivelAcesso"].ToString());
                    usuarioColunas.Add(usuario);
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                this.conexao.Desconectar();
            }
            return usuarioColunas;
        }
    }
}
