using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DALRelatorioFluxoDeCaixa
    {
        private DALConexao conexao;

        public DALRelatorioFluxoDeCaixa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public class FluxoDeCaixaRelatorio
        {
            public DateTime DataInicial { get; }
            public DateTime DataFinal { get; }
            public double ValorAbertura { get; }
            public double TotalVendas { get; }
            public double TotalCompras { get; }
            public double FluxoCaixa { get; }

            public FluxoDeCaixaRelatorio(DateTime dataInicial, DateTime dataFinal, double valorAbertura, double totalVendas, double totalCompras, double fluxoCaixa)
            {
                this.DataInicial = dataInicial;
                this.DataFinal = dataFinal;
                this.ValorAbertura = valorAbertura;
                this.TotalVendas = totalVendas;
                this.TotalCompras = totalCompras;
                this.FluxoCaixa = fluxoCaixa;
            }
        }

        public List<FluxoDeCaixaRelatorio> ObterLinhasFluxoDeCaixa(string nomeTabela, DateTime dataInicial, DateTime dataFinal)
        {
            List<FluxoDeCaixaRelatorio> fluxos = new List<FluxoDeCaixaRelatorio>();

            try
            {
                string query = "SELECT * FROM vwfluxodecaixa WHERE data_inicial >= @DataInicial AND data_final <= @DataFinal;";

                SqlCommand cmd = new SqlCommand(query, conexao.ObjetoConexao);
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    FluxoDeCaixaRelatorio fluxo = new FluxoDeCaixaRelatorio(
                        Convert.ToDateTime(dr["data_inicial"]),
                        Convert.ToDateTime(dr["data_final"]),
                        Convert.ToDouble(dr["valor_fechamento"]),
                        Convert.ToDouble(dr["total_vendas"]),
                        Convert.ToDouble(dr["total_compras"]),
                        Convert.ToDouble(dr["fluxo_de_caixa"])
                    );
                    fluxos.Add(fluxo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter linhas de fluxo de caixa: " + ex.Message);
                return null;
            }
            finally
            {
                conexao.Desconectar();
            }
            return fluxos;
        }



        public double ObterTotalFluxoCaixa(DateTime dataInicial, DateTime dataFinal)
        {
            double totalFluxoCaixa = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(fluxo_de_caixa) FROM vwfluxodecaixa WHERE data_inicial >= @DataInicial AND data_final <= @DataFinal;", conexao.ObjetoConexao);
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                conexao.Conectar();
                totalFluxoCaixa = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            finally
            {
                conexao.Desconectar();
            }
            return totalFluxoCaixa;
        }
    }
}
