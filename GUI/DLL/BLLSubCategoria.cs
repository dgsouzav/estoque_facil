using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class BLLSubCategoria
    {
        private DALConexao conexao;

        public BLLSubCategoria (DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.SubCategoriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }

            if (modelo.SubCategoriaID <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.SubCategoriaID <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (modelo.SubCategoriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int id)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Excluir(id);
        }
        public DataTable Localizar(String valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloSubCategoria CarregaModeloSubCategoria(int id)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(id);
        }
    }
}
