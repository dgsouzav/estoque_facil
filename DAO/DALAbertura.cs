using Modelo;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DALAbertura
    {
        DALConexao conexao;
        public DALAbertura(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirAbertura(ModeloAbertura modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into abertura(abertura_dataInicial, abertura_valorInicial) values (@dataInicial, @valorInicial); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@dataInicial", modelo.dataInicial);
                cmd.Parameters.AddWithValue("@valorInicial", modelo.ValorInicial);

                conexao.Conectar();
                modelo.AberturaID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public void IncluirFechamento(ModeloAbertura modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE abertura SET abertura_dataFinal = @dataFinal, abertura_valorFinal = @valorFinal WHERE abertura_id = @id";
                cmd.Parameters.AddWithValue("@dataFinal", modelo.dataFinal);
                cmd.Parameters.AddWithValue("@valorFinal", modelo.ValorFinal);
                cmd.Parameters.AddWithValue("@id", modelo.AberturaID);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public ModeloAbertura VerificarSessao()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM abertura WHERE abertura_dataFinal IS NULL";

                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();


                ModeloAbertura abertura = null;
                if (registro.Read())
                {
                    abertura = new ModeloAbertura();
                    abertura.AberturaID = Convert.ToInt32(registro["abertura_id"]);
                    abertura.dataInicial = Convert.ToDateTime(registro["abertura_dataInicial"]);
                    abertura.ValorInicial = Convert.ToInt32(registro["abertura_valorInicial"]);
                }

                registro.Close();
                conexao.Desconectar();
                return abertura;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

    }
}
