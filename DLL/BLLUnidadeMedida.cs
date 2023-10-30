using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUnidadeMedida
    {
        private DALConexao conexao;
        public BLLUnidadeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeMedida modelo)
        {
            if(modelo.UndMedID < 0)
            {
                throw new Exception("O ID da unidade de medida é obrigatório");
            }
            if(modelo.UndMedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloUnidadeMedida modelo)
        {
            if (modelo.UndMedID <= 0)
            {
                throw new Exception("O ID da unidade de medida é obrigatório");
            }
            if (modelo.UndMedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int id)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Excluir(id);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.Localizar(valor);
        }
        public int VerificaUnidadeMedida(String valor)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);        
            return DALobj.VerificaUnidadeMedida(valor);
        }
        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int id)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.CarregaModeloUnidadeMedida(id);
        }
    }
}
