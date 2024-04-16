using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioFornecedor
    {
        DALConexao conexao;
        public DALRelatorioFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public class FornecedorRelatorio
        {
            int _id;
            string _nome;
            string _razaoSocial;
            public FornecedorRelatorio(int id, string nome, string razaoSocial)
            {
                this._id = id;
                this._nome = nome;
                this._razaoSocial = razaoSocial;
            }
            public int Id { get { return _id; } }
            public string Nome { get { return _nome; } }
            public string RazaoSocial { get { return _razaoSocial; } }
        }
        public List<FornecedorRelatorio>? ObterLinhasFornecedor(string nomeTabela)
        {
            List<FornecedorRelatorio> fornecedorColunas = new List<FornecedorRelatorio>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fornecedor;");
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    FornecedorRelatorio fornecedor = new FornecedorRelatorio(Convert.ToInt32(dr["fornecedor_id"]), dr["fornecedor_nome"].ToString(), dr["fornecedor_razaoSocial"].ToString());
                    fornecedorColunas.Add(fornecedor);
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
            return fornecedorColunas;
        }
    }
}
