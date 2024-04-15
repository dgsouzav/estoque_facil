using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCliente
    {
        private DALConexao conexao;
        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = "insert into cliente(cliente_nome, cliente_cpf, cliente_cep, cliente_endereco, cliente_bairro, cliente_fone, cliente_email, cliente_endNumero, cliente_cidade, cliente_estado) values " +
                    "(@nome, @cep, @endereco, @bairro, @fone, @email, @endNumero, @cidade, @estado)";
                cmd.Parameters.AddWithValue("@nome", modelo.ClienteNome);
                cmd.Parameters.AddWithValue("@cpf", modelo.ClienteCPF);
                cmd.Parameters.AddWithValue("@cep", modelo.ClienteCEP);
                cmd.Parameters.AddWithValue("@endereco", modelo.ClienteEndereco);
                cmd.Parameters.AddWithValue("@bairro", modelo.ClienteBairro);
                cmd.Parameters.AddWithValue("@fone", modelo.ClienteFone);
                cmd.Parameters.AddWithValue("@email", modelo.ClienteEmail);
                cmd.Parameters.AddWithValue("@endNumero", modelo.ClienteEndNumero);
                cmd.Parameters.AddWithValue("@cidade", modelo.ClienteCidade);
                cmd.Parameters.AddWithValue("@estado", modelo.ClienteEstado);

                conexao.Conectar();
                modelo.ClienteID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public void Alterar(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = "update cliente set cliente_nome = @nome, cliente_cpf = @cpf, cliente_cep = @cep, cliente_endereco = @endereco, cliente_bairro = @bairro, cliente_fone = @fone, " +
                    "cliente_email = @email, cliente_endNumero = @endNumero, cliente_cidade = @cidade, cliente_estado = @estado where cliente_id = @id";
                cmd.Parameters.AddWithValue("@id", modelo.ClienteID);
                cmd.Parameters.AddWithValue("@nome", modelo.ClienteNome);
                cmd.Parameters.AddWithValue("@cpf", modelo.ClienteCPF);
                cmd.Parameters.AddWithValue("@cep", modelo.ClienteCEP);
                cmd.Parameters.AddWithValue("@endereco", modelo.ClienteEndereco);
                cmd.Parameters.AddWithValue("@bairro", modelo.ClienteBairro);
                cmd.Parameters.AddWithValue("@fone", modelo.ClienteFone);
                cmd.Parameters.AddWithValue("@email", modelo.ClienteEmail);
                cmd.Parameters.AddWithValue("@endNumero", modelo.ClienteEndNumero);
                cmd.Parameters.AddWithValue("@cidade", modelo.ClienteCidade);
                cmd.Parameters.AddWithValue("@estado", modelo.ClienteEstado);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public void Excluir(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = "delete from cliente where cliente_id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from cliente where cliente_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorNome(string valor)
        {
            return Localizar(valor);
        }
        public ModeloCliente CarregaModeloCliente(int id)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cliente_id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ClienteID = Convert.ToInt32(registro["cliente_id"]);
                modelo.ClienteNome = Convert.ToString(registro["cliente_nome"]);
                modelo.ClienteCPF = Convert.ToString(registro["cliente_cpf"]);
                modelo.ClienteCEP = Convert.ToString(registro["cliente_cep"]);
                modelo.ClienteEndereco = Convert.ToString(registro["cliente_endereco"]);
                modelo.ClienteBairro = Convert.ToString(registro["cliente_bairro"]);
                modelo.ClienteFone = Convert.ToString(registro["cliente_fone"]);
                modelo.ClienteEmail = Convert.ToString(registro["cliente_email"]);
                modelo.ClienteEndNumero = Convert.ToString(registro["cliente_endNumero"]);
                modelo.ClienteCidade = Convert.ToString(registro["cliente_cidade"]);
                modelo.ClienteEstado = Convert.ToString(registro["cliente_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloCliente CarregaModeloCliente(string cpf) 
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cliente_cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ClienteID = Convert.ToInt32(registro["cliente_id"]);
                modelo.ClienteNome = Convert.ToString(registro["cliente_nome"]);
                modelo.ClienteCPF = Convert.ToString(registro["cliente_cpf"]);
                modelo.ClienteCEP = Convert.ToString(registro["cliente_cep"]);
                modelo.ClienteEndereco = Convert.ToString(registro["cliente_endereco"]);
                modelo.ClienteBairro = Convert.ToString(registro["cliente_bairro"]);
                modelo.ClienteFone = Convert.ToString(registro["cliente_fone"]);
                modelo.ClienteEmail = Convert.ToString(registro["cliente_email"]);
                modelo.ClienteEndNumero = Convert.ToString(registro["cliente_endNumero"]);
                modelo.ClienteCidade = Convert.ToString(registro["cliente_cidade"]);
                modelo.ClienteEstado = Convert.ToString(registro["cliente_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
