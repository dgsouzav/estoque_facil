using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.DALRelatorioGastos;
using static DAL.DALRelatorioVenda;

namespace DAL
{
    public class DALRelatorioFluxoCaixa
    {
        DALConexao conexao;
        public DALRelatorioFluxoCaixa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public class FluxoCaixaRelatorio
        {
            string _data;
            string _total;
            public FluxoCaixaRelatorio(string data, int total)
            {
                this._data = data;
                _total = _total;
            }
            public string Data { get { return _data; } }
            public string Total { get { return _total; } }
        }
        public List<FluxoCaixaRelatorio>? ObterLinhasFluxoCaixa(string nomeTabela, DateTime dataInicial, DateTime dataFinal)
        {
            List<FluxoCaixaRelatorio> fluxocColunas = new List<FluxoCaixaRelatorio>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vwfluxocaixa WHERE data BETWEEN @DataInicial AND @DataFinal;");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    FluxoCaixaRelatorio fluxoc = new FluxoCaixaRelatorio(Convert.ToString(dr["data"]), Convert.ToInt32(dr["total"]));
                    fluxocColunas.Add(fluxoc);
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
            return fluxocColunas;
        }
        public double ObterTotalFluxoCaixa(DateTime dataInicial, DateTime dataFinal)
        {
            double totalFluxoc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(total) FROM vwfluxocaixa WHERE data BETWEEN @DataInicial AND @DataFinal;");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                totalFluxoc = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            finally
            {
                this.conexao.Desconectar();
            }
            return totalFluxoc;
        }
    }
}
