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
    public class BLLParcelasVenda
    {
        private DALConexao conexao;
        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.ParcelasVendaID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (modelo.VendaID <= 0)
            {
                throw new Exception("O ID da venda é obrigatório");
            }
            if (modelo.ParcelasVendaValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.ParcelasVendaDataVencimento.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.ParcelasVendaID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (modelo.VendaID <= 0)
            {
                throw new Exception("O ID da venda é obrigatório");
            }
            if (modelo.ParcelasVendaValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.ParcelasVendaDataVencimento.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.ParcelasVendaID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (modelo.VendaID <= 0)
            {
                throw new Exception("O ID da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirParcelas(int VendaID)
        {
            if (VendaID <= 0)
            {
                throw new Exception("O ID da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.ExcluirParcelas(VendaID);
        }
        public DataTable Localizar(int VendaID)
        {
            if (VendaID <= 0)
            {
                throw new Exception("O ID da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.Localizar(VendaID);
        }
        public ModeloParcelasVenda CarregaModeloParcelasVenda(int ParcelasVendaID, int VendaID)
        {
            if (ParcelasVendaID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (VendaID <= 0)
            {
                throw new Exception("O ID da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.CarregaModeloParcelasVenda(ParcelasVendaID, VendaID);
        }
    }
}
