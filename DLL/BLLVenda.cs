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
    public class BLLVenda
    {
        private DALConexao conexao;
        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirGasto(ModeloVenda modelo)
        {
            if (modelo.VendaTotal >= 0)
            {
                throw new Exception("O valor do gasto deve ser maior que zero.");
            }
            if (modelo.VendaNotaFiscal <= 0)
            {
                throw new Exception("O número da nota fiscal deve ser maior que zero.");
            }
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.IncluirGasto(modelo);
        }
        public void Incluir(Modelo.ModeloVenda modelo)
        {
            if (modelo.VendaTotal <= 0)
            {
                throw new Exception("O valor da venda deve ser maior que zero.");
            }
            if(modelo.VendaNotaFiscal <= 0)
            {
                throw new Exception("O número da nota fiscal deve ser maior que zero.");
            }
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(Modelo.ModeloVenda modelo)
        {
            if (modelo.VendaTotal <= 0)
            {
                throw new Exception("O valor da venda deve ser maior que zero.");
            }
            if (modelo.VendaNotaFiscal <= 0)
            {
                throw new Exception("O número da nota fiscal deve ser maior que zero.");
            }
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int id)
        {
            if(id <= 0)
            {
                throw new Exception("O ID da venda deve ser maior que zero.");
            }
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Excluir(id);
        }
        public Boolean CancelarVenda(int id)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CancelarVenda(id);
        }

        public DataTable Localizar()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar();
        }
        public DataTable LocalizarPorData(DateTime dataInicial, DateTime dataFinal) 
        {             
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarPorData(dataInicial, dataFinal);
        }
        public ModeloVenda CarregaModeloVenda(int id)
        {
            if (id <= 0)
            {
                throw new Exception("O ID da venda deve ser maior que zero.");
            }
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloVenda(id);
        }
    }
}
