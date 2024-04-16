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
        public class CompraRelatorio
        {
            string _data;
            int _numero_de_compras;
            int _total_de_compras;
            int _numero_de_parcelas;
            public CompraRelatorio(string data, int numero_de_compras, int total_de_compras, int numero_de_parcelas)
            {
                this._data = data;
                this._numero_de_compras = numero_de_compras;
                this._total_de_compras = total_de_compras;
                this._numero_de_parcelas = numero_de_parcelas;
            }
            public string Data { get { return _data; } }
            public int NumeroDeCompras { get { return _numero_de_compras; } }
            public int TotalDeCompras { get { return _total_de_compras; } }
            public int NumeroDeParcelas { get { return _numero_de_parcelas; } }
        }
        public List<CompraRelatorio>? ObterLinhasCompra(string nomeTabela, DateTime dataInicial, DateTime dataFinal)
        {
            List<CompraRelatorio> compraColunas = new List<CompraRelatorio>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vwrelatoriocompras WHERE data BETWEEN @DataInicial AND @DataFinal;");
                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CompraRelatorio compra = new CompraRelatorio(Convert.ToString(dr["data"]), Convert.ToInt32(dr["numero_de_compras"]),
                        Convert.ToInt32(dr["total_de_compras"]), Convert.ToInt32(dr["media_de_parcelas"]));
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
