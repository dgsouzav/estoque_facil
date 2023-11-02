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
    public class BLLSubCategoria
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
                throw new Exception("O nome da sub categoria é obrigatório");
            }

            if (modelo.SubCategoriaID < 0)
            {
                throw new Exception("O ID da sub categoria é obrigatório");
            }

            if (modelo.CategoriaID <= 0)
            {
                throw new Exception("O ID da categoria é obrigatório");
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.SubCategoriaID <= 0)
            {
                throw new Exception("O ID da sub categoria é obrigatório");
            }

            if (modelo.SubCategoriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da sub categoria é obrigatório");
            }

            if (modelo.CategoriaID <= 0)
            {
                throw new Exception("O ID da categoria é obrigatório");
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
        public DataTable LocalizarPorCategoria(int categoria)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.LocalizarPorCategoria(categoria);
        }
        public ModeloSubCategoria CarregaModeloSubCategoria(int id)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(id);
        }
        
    }
}
