using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteRelatorio
    {
        int _id;
        string _nome;
        public ClienteRelatorio(int id, string nome)
        {
            this._id = id;
            this._nome = nome;
        }
        public int Id { get {  return _id; } }
        public string Nome { get {  return _nome; } }
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
        public string Data { get {  return _data; } }
        public int NumeroDeCompras { get {  return _numero_de_compras; } }
        public int TotalDeCompras { get {  return _total_de_compras; } }
        public int NumeroDeParcelas { get {  return _numero_de_parcelas; } }
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
            this._numero_de_vendas = numero_de_parcelas;
        }
        public string Data { get { return _data; } }
        public int NumeroDeVendas { get { return _numero_de_vendas; } }
        public int TotalDeVendas { get { return _total_de_vendas; } }
        public int NumeroDeParcelas { get { return _numero_de_parcelas; } }
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

    public class DALRelatorios
    {
        private DALConexao conexao;

        private DALRelatorios() { }
        public DALRelatorios(DALConexao cx)
        {
            this.conexao = cx;
        }

        public List<ClienteRelatorio>? ObterLinhasCliente(string nomeTabela)
        {
            List<ClienteRelatorio> clienteColunas = new List<ClienteRelatorio>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM cliente;");
                cmd.Connection = conexao.ObjetoConexao;
                this.conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClienteRelatorio cliente = new ClienteRelatorio(Convert.ToInt32(dr["cliente_id"]), dr["cliente_nome"].ToString());  
                    clienteColunas.Add(cliente);
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
            return clienteColunas;
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
