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
    public class BLLItensVenda
    {
        private DALConexao conexao;
        public BLLItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.ItensVendaQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero.");
            }
            if (modelo.ItensVendaValor <= 0)
            {
                throw new Exception("O valor deve ser maior que zero.");
            }
            if (modelo.VendaID <= 0)
            {
                throw new Exception("O ID da venda deve ser informado.");
            }
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto deve ser informado.");
            }
            if(modelo.ItensVendaID <= 0)
            {
                throw new Exception("O ID do item da venda deve ser informado.");
            }
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.ItensVendaQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero.");
            }
            if (modelo.ItensVendaValor <= 0)
            {
                throw new Exception("O valor deve ser maior que zero.");
            }
            if (modelo.VendaID <= 0)
            {
                throw new Exception("O ID da venda deve ser informado.");
            }
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto deve ser informado.");
            }
            if (modelo.ItensVendaID <= 0)
            {
                throw new Exception("O ID do item da venda deve ser informado.");
            }
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VendaID <= 0)
            {
                throw new Exception("O ID da venda deve ser informado.");
            }
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto deve ser informado.");
            }
            if (modelo.ItensVendaID <= 0)
            {
                throw new Exception("O ID do item da venda deve ser informado.");
            }
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirTodosItens(int vendaID)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.ExcluirTodosItens(vendaID);
        }
        public DataTable Localizar(int vendaID)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            return DALobj.Localizar(vendaID);
        }
        public ModeloItensVenda CarregaModeloItensVenda(int ItensVendaID, int VendaID, int ProdutoID)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            return DALobj.CarregaModeloItensVenda(ItensVendaID, VendaID, ProdutoID);
        }
    }
}
