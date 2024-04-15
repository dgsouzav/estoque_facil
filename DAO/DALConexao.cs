using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;
        private SqlTransaction _transacao;

        public DALConexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }
        // Propriedades de transação
        public SqlTransaction ObjetoTransacao
        {
            get { return this._transacao; }
            set { this._transacao = value; }
        }

        public String StringConexao
        {
            get { return this._stringConexao;  }
            set { this._stringConexao = value;  }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value;}
        }
        // Métodos de transação
        public void IniciarTransacao()
        {
            this._transacao = this._conexao.BeginTransaction();
        }
        public void TerminarTransacao()
        {
            this._transacao.Commit();
        }
        public void CancelarTransacao()
        {
            this._transacao.Rollback();
        }
        // Métodos de conexão
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close(); 
        }
    }
}
