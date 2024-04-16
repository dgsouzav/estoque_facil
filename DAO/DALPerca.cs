using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPerca
    {
        public void Incluir(ModeloPerca modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into perca (perca_valor) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CategoriaNome);

            conexao.Conectar();
            modelo.CategoriaID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
    }
}
