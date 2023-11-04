using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFornecedor
    {
        private DALConexao conexao;
        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into fornecedor(fornecedor_nome, fornecedor_razaoSocial, fornecedor_inscricaoEstadual, fornecedor_cnpj, fornecedor_cep, " +
                "fornecedor_endereco, fornecedor_bairro, fornecedor_fone, fornecedor_email, fornecedor_endNumero, fornecedor_cidade, fornecedor_estado) values " +
                "(@nome, @razaoSocial, @inscricaoEstadual,@cnpj, @cep, @endereco, @bairro, @fone, @email, @endNumero, @cidade, @estado)";
            cmd.Parameters.AddWithValue("@nome", modelo.FornecedorNome);
            cmd.Parameters.AddWithValue("@razaoSocial", modelo.FornecedorRazaoSocial);
            cmd.Parameters.AddWithValue("@inscricaoEstadual", modelo.FornecedorInscricaoEstadual);
            cmd.Parameters.AddWithValue("@cnpj", modelo.FornecedorCNPJ);
            cmd.Parameters.AddWithValue("@cep", modelo.FornecedorCEP);
            cmd.Parameters.AddWithValue("@endereco", modelo.FornecedorEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.FornecedorBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.FornecedorFone);
            cmd.Parameters.AddWithValue("@email", modelo.FornecedorEmail);
            cmd.Parameters.AddWithValue("@endNumero", modelo.FornecedorEndNumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.FornecedorCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.FornecedorEstado);

            conexao.Conectar();
            modelo.FornecedorID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "update fornecedor set fornecedor_nome = @nome, fornecedor_razaoSocial = @razaoSocial, fornecedor_inscricaoEstadual = @inscricaoEstadual, " +
                "fornecedor_cnpj = @cnpj, fornecedor_cep = @cep, fornecedor_endereco = @endereco, fornecedor_bairro = @bairro, fornecedor_fone = @fone, " +
                "fornecedor_email = @email";
            cmd.Parameters.AddWithValue("@id", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@nome", modelo.FornecedorNome);
            cmd.Parameters.AddWithValue("@razaoSocial", modelo.FornecedorRazaoSocial);
            cmd.Parameters.AddWithValue("@inscricaoEstadual", modelo.FornecedorInscricaoEstadual);
            cmd.Parameters.AddWithValue("@cnpj", modelo.FornecedorCNPJ);
            cmd.Parameters.AddWithValue("@cep", modelo.FornecedorCEP);
            cmd.Parameters.AddWithValue("@endereco", modelo.FornecedorEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.FornecedorBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.FornecedorFone);
            cmd.Parameters.AddWithValue("@endNumero", modelo.FornecedorEndNumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.FornecedorCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.FornecedorEstado);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "delete from fornecedor where fornecedor_id = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(string valor) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where fornecedor_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorNome(string valor)
        {
            return Localizar(valor);
        }
        public DataTable LocalizarPorCNPJ(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where fornecedor_cnpj like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloFornecedor CarregaModeloFornecedorID(int id)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "select * from fornecedor where fornecedor_id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FornecedorID = Convert.ToInt32(registro["fornecedor_id"]);
                modelo.FornecedorNome = Convert.ToString(registro["fornecedor_nome"]);
                modelo.FornecedorRazaoSocial = Convert.ToString(registro["fornecedor_razaoSocial"]);
                modelo.FornecedorInscricaoEstadual = Convert.ToString(registro["fornecedor_inscricaoEstadual"]);
                modelo.FornecedorCNPJ = Convert.ToString(registro["fornecedor_cnpj"]);
                modelo.FornecedorCEP = Convert.ToString(registro["fornecedor_cep"]);
                modelo.FornecedorEndereco = Convert.ToString(registro["fornecedor_endereco"]);
                modelo.FornecedorBairro = Convert.ToString(registro["fornecedor_bairro"]);
                modelo.FornecedorFone = Convert.ToString(registro["fornecedor_fone"]);
                modelo.FornecedorEmail = Convert.ToString(registro["fornecedor_email"]);
                modelo.FornecedorEndNumero = Convert.ToString(registro["fornecedor_endNumero"]);
                modelo.FornecedorCidade = Convert.ToString(registro["fornecedor_cidade"]);
                modelo.FornecedorEstado = Convert.ToString(registro["fornecedor_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloFornecedor CarregaModeloFornecedorCNPJ(string cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "select * from fornecedor where fornecedor_cnpj = @cnpj";
            cmd.Parameters.AddWithValue("@cnpj", cnpj);

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FornecedorID = Convert.ToInt32(registro["fornecedor_id"]);
                modelo.FornecedorNome = Convert.ToString(registro["fornecedor_nome"]);
                modelo.FornecedorRazaoSocial = Convert.ToString(registro["fornecedor_razaoSocial"]);
                modelo.FornecedorInscricaoEstadual = Convert.ToString(registro["fornecedor_inscricaoEstadual"]);
                modelo.FornecedorCNPJ = Convert.ToString(registro["fornecedor_cnpj"]);
                modelo.FornecedorCEP = Convert.ToString(registro["fornecedor_cep"]);
                modelo.FornecedorEndereco = Convert.ToString(registro["fornecedor_endereco"]);
                modelo.FornecedorBairro = Convert.ToString(registro["fornecedor_bairro"]);
                modelo.FornecedorFone = Convert.ToString(registro["fornecedor_fone"]);
                modelo.FornecedorEmail = Convert.ToString(registro["fornecedor_email"]);
                modelo.FornecedorEndNumero = Convert.ToString(registro["fornecedor_endNumero"]);
                modelo.FornecedorCidade = Convert.ToString(registro["fornecedor_cidade"]);
                modelo.FornecedorEstado = Convert.ToString(registro["fornecedor_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
