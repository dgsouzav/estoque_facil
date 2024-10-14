using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            DateTime _data;
            int _total_de_vendas;

            public VendaGrafico(DateTime data, int total_de_vendas)
            {
                this._data = data;
                this._total_de_vendas = total_de_vendas;
            }

            public DateTime Data { get { return _data; } }
            public int TotalDeVendas { get { return _total_de_vendas; } }
        }

        public List<VendaGrafico>? ObterGrafico()
        {
            List<VendaGrafico> graficoColunas = new List<VendaGrafico>();

            try
            {
                //SqlCommand cmd = new SqlCommand("SELECT SUM(total_de_vendas) AS TotalDeVendas, data FROM vwrelatoriovendas GROUP BY data");

                SqlCommand cmd = new SqlCommand("SELECT SUM(total_de_vendas) AS TotalDeVendas, CAST(data AS DATE) AS Data FROM vwrelatoriovendas GROUP BY CAST(data AS DATE)");


                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        // Verifique se 'TotalDeVendas' é nulo e trate isso corretamente
                        int totalDeVendas = dr["TotalDeVendas"] != DBNull.Value ? Convert.ToInt32(dr["TotalDeVendas"]) : 0;

                        // Converta a data para DateTime
                        DateTime data = Convert.ToDateTime(dr["data"]);

                        // Crie o objeto VendaGrafico e adicione à lista
                        VendaGrafico grafico = new VendaGrafico(data, totalDeVendas);
                        graficoColunas.Add(grafico);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter os dados do gráfico de vendas: " + ex.Message);
                return null;
            }
            finally
            {
                this.conexao.Desconectar();
            }
            return graficoColunas;
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
