using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;
        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        //public void Incluir(ModeloProduto modelo)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexao.ObjetoConexao;
        //    cmd.CommandText = 

        //}
    }
}
