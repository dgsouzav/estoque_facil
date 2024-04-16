using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioCliente
    {
        DALConexao conexao;
        public DALRelatorioCliente(DALConexao cx)
        {
            this.conexao = cx;
        }
        public class ClienteRelatorio
        {
            int _id;
            string _nome;
            public ClienteRelatorio(int id, string nome)
            {
                this._id = id;
                this._nome = nome;
            }
            public int Id { get { return _id; } }
            public string Nome { get { return _nome; } }
        }
        public List<ClienteRelatorio>? ObterLinhasCliente(string nomeTabela)
        {
            List<ClienteRelatorio> clienteColunas = new List<ClienteRelatorio>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM cliente;");
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClienteRelatorio cliente = new ClienteRelatorio(Convert.ToInt32(dr["cliente_id"]), dr["cliente_nome"].ToString());
                    clienteColunas.Add(cliente);
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
            return clienteColunas;
        }
    }
}
