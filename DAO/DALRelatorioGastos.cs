﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioGastos
    {
        DALConexao conexao;
        public DALRelatorioGastos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public class GastosRelatorio
        {
            string nome;
            string _descricao;
            int _valor;
            public GastosRelatorio(string nome, string descricao, int valor)
            {
                this.nome = nome;
                this._descricao = descricao;
                this._valor = valor;
            }
            public string Nome { get { return nome; } }
            public string Descricao { get { return _descricao; } }
            public int Valor { get { return _valor; } }
        }

        public List<GastosRelatorio>? ObterLinhasGastos(string nomeTabela, DateTime dataInicial, DateTime dataFinal)
        {
            List<GastosRelatorio> gastosColunas = new List<GastosRelatorio>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM venda WHERE venda_data BETWEEN @DataInicial AND @DataFinal AND venda_tipoTransacao = 'Gasto';");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    GastosRelatorio gastos = new GastosRelatorio(
                        Convert.ToString(dr["venda_gastoNome"]),
                        Convert.ToString(dr["venda_descricao"]),
                        Convert.ToInt32(dr["venda_total"])
                    );
                    gastosColunas.Add(gastos);
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
            return gastosColunas;
        }
        public double ObterTotalDespesas(DateTime dataInicial, DateTime dataFinal)
        {
            double totalDespesas = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(venda_total) FROM venda WHERE venda_data BETWEEN @DataInicial AND @DataFinal AND venda_tipoTransacao = 'Gasto';");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                totalDespesas = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            finally
            {
                this.conexao.Desconectar();
            }
            return totalDespesas;
        }

    }
}
