using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioVenda
    {
        DALConexao conexao;
        public DALRelatorioVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public class VendaRelatorio
        {
            string _data;
            int _numero_de_vendas;
            int _total_de_vendas;
            int _numero_de_parcelas;
            public VendaRelatorio(string data, int numero_de_vendas, int total_de_vendas, int numero_de_parcelas)
            {
                this._data = data;
                this._numero_de_vendas = numero_de_vendas;
                this._total_de_vendas = total_de_vendas;
                this._numero_de_parcelas = numero_de_parcelas;
            }
            public string Data { get { return _data; } }
            public int NumeroDeVendas { get { return _numero_de_vendas; } }
            public int TotalDeVendas { get { return _total_de_vendas; } }
            public int NumeroDeParcelas { get { return _numero_de_parcelas; } }
        }

        public List<VendaRelatorio>? ObterLinhasVenda(string nomeTabela, DateTime dataInicial, DateTime dataFinal)
        {
            List<VendaRelatorio> vendaColunas = new List<VendaRelatorio>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vwrelatoriovendas WHERE data BETWEEN @DataInicial AND @DataFinal;");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    VendaRelatorio venda = new VendaRelatorio(Convert.ToString(dr["data"]), Convert.ToInt32(dr["numero_de_vendas"]),
                        Convert.ToInt32(dr["total_de_vendas"]), Convert.ToInt32(dr["media_de_parcelas"]));
                    vendaColunas.Add(venda);
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
            return vendaColunas;
        }
    }
}
