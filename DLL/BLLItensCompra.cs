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
    public class BLLItensCompra
    {
        private DALConexao conexao;
        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            if(modelo.ItensCompraID <= 0)
            {
                throw new Exception("O ID do item da compra deve ser informado.");
            }
            if (modelo.ItensCompraQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero.");
            }
            if (modelo.ItensCompraValor <= 0)
            {
                throw new Exception("O valor deve ser maior que zero.");
            }
            if (modelo.CompraID <= 0)
            {
                throw new Exception("O ID da compra deve ser informado.");
            }
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto deve ser informado.");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.ItensCompraID <= 0)
            {
                throw new Exception("O ID do item da compra deve ser informado.");
            }
            if (modelo.ItensCompraQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero.");
            }
            if (modelo.ItensCompraValor <= 0)
            {
                throw new Exception("O valor deve ser maior que zero.");
            }
            if (modelo.CompraID <= 0)
            {
                throw new Exception("O ID da compra deve ser informado.");
            }
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto deve ser informado.");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.ItensCompraID <= 0)
            {
                throw new Exception("O ID do item da compra deve ser informado.");
            }
            if (modelo.CompraID <= 0)
            {
                throw new Exception("O ID da compra deve ser informado.");
            }
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto deve ser informado.");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirItens(int compra_id)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.ExcluirItens(compra_id);
        }
        public DataTable Localizar(int compra_id)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.Localizar(compra_id);
        }
        public ModeloItensCompra CarregaModeloItensCompra(int ItensCompraID, int CompraID, int ProdutoID)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(ItensCompraID, CompraID, ProdutoID);
        }
    }
}
