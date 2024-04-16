using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioProduto
    {
        DALConexao conexao;
        public DALRelatorioProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public class ProdutoRelatorio
        {
            string _nome;
            int _valorpago;
            int _valorvenda;
            int _quantidade;
            public ProdutoRelatorio(string nome, int valorpago, int valorvenda, int quantidade)
            {
                this._nome = nome;
                this._valorpago = valorpago;
                this._valorvenda = valorvenda;
                this._quantidade = quantidade;
            }
            public string Nome { get { return _nome; } }
            public int ValorPago { get { return _valorpago; } }
            public int ValorVenda { get { return _valorvenda; } }
            public int Quantidade { get { return _quantidade; } }
        }

        public List<ProdutoRelatorio>? ObterLinhasProduto(string nomeTabela)
        {
            List<ProdutoRelatorio> produtoColunas = new List<ProdutoRelatorio>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vwproduto;");
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ProdutoRelatorio produto = new ProdutoRelatorio(Convert.ToString(dr["nome"]), Convert.ToInt32(dr["valorpago"]),
                        Convert.ToInt32(dr["valorvenda"]), Convert.ToInt32(dr["quantidade"]));
                    produtoColunas.Add(produto);
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
            return produtoColunas;
        }
    }
}
