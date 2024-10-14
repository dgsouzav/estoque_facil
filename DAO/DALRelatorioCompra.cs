using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioCompra
    {
        DALConexao conexao;
        public DALRelatorioCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public class CompraGrafico
        {
            DateTime _data;
            int _total_de_compras;

            public CompraGrafico(DateTime data, int total_de_compras)
            {
                this._data = data;
                this._total_de_compras = total_de_compras;
            }

            public DateTime Data { get { return _data; } }
            public int TotalDeCompras { get { return _total_de_compras; } }
        }

        public List<CompraGrafico>? ObterGraficoCompras()
        {
            List<CompraGrafico> graficoColunas = new List<CompraGrafico>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(total_de_compras) AS TotalDeCompras, CAST(data AS DATE) AS Data FROM vwrelatoriocompras GROUP BY CAST(data AS DATE)");

                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        int totalDeCompras = dr["TotalDeCompras"] != DBNull.Value ? Convert.ToInt32(dr["TotalDeCompras"]) : 0;

                        DateTime data = Convert.ToDateTime(dr["data"]);

                        CompraGrafico grafico = new CompraGrafico(data, totalDeCompras);
                        graficoColunas.Add(grafico);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter os dados do gráfico de compras: " + ex.Message);
                return null;
            }
            finally
            {
                this.conexao.Desconectar();
            }
            return graficoColunas;
        }
        public class CompraRelatorio
        {
            string _data;
            int _numero_de_compras;
            int _total_de_compras;
            public CompraRelatorio(string data, int numero_de_compras, int total_de_compras)
            {
                this._data = data;
                this._numero_de_compras = numero_de_compras;
                this._total_de_compras = total_de_compras;
            }
            public string Data { get { return _data; } }
            public int NumeroDeCompras { get { return _numero_de_compras; } }
            public int TotalDeCompras { get { return _total_de_compras; } }
        }
        public List<CompraRelatorio>? ObterLinhasCompra(string nomeTabela, DateTime dataInicial, DateTime dataFinal)
        {
            List<CompraRelatorio> compraColunas = new List<CompraRelatorio>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vwrelatoriocompras WHERE data >= @DataInicial AND data <= @DataFinal;");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CompraRelatorio compra = new CompraRelatorio(Convert.ToString(dr["data"]), Convert.ToInt32(dr["numero_de_compras"]),
                        Convert.ToInt32(dr["total_de_compras"]));
                    compraColunas.Add(compra);
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
            return compraColunas;
        }
    }
   
}
