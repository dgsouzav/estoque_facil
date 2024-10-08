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
            public VendaRelatorio(string data, int numero_de_vendas, int total_de_vendas)
            {
                this._data = data;
                this._numero_de_vendas = numero_de_vendas;
                this._total_de_vendas = total_de_vendas;
            }
            public string Data { get { return _data; } }
            public int NumeroDeVendas { get { return _numero_de_vendas; } }
            public int TotalDeVendas { get { return _total_de_vendas; } }
        }

        public class VendaGrafico
        {
            string _data;
            int _numero_de_vendas;
            int _total_de_vendas;
            public VendaGrafico(string data, int numero_de_vendas, int total_de_vendas)
            {
                this._data = data;
                this._numero_de_vendas = numero_de_vendas;
                this._total_de_vendas = total_de_vendas;
            }
            public string Data { get { return _data; } }
            public int NumeroDeVendas { get { return _numero_de_vendas; } }
            public int TotalDeVendas { get { return _total_de_vendas; } }
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
                        Convert.ToInt32(dr["total_de_vendas"]));
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
        public List<VendaGrafico>? ObterGrafico(string nomeTabela)
        {
            List<VendaGrafico> graficoColunas = new List<VendaGrafico>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT data, numero_de_vendas, total_de_vendas FROM vwrelatoriovendas;");
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null) 
                {
                    while (dr.Read())
                    {
                        VendaGrafico grafico = new VendaGrafico(Convert.ToString(dr["data"]), Convert.ToInt32(dr["numero_de_vendas"]),
                            Convert.ToInt32(dr["total_de_vendas"]));
                        graficoColunas.Add(grafico);
                    }
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
            return graficoColunas;
        }
        public double ObterTotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            double totalVendas = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(total_de_vendas) FROM vwrelatoriovendas WHERE data BETWEEN @DataInicial AND @DataFinal;");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                totalVendas = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            finally
            {
                this.conexao.Desconectar();
            }
            return totalVendas;
        }
    }
}
