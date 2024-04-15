using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLParcelasCompra
    {
        private DALConexao conexao;
        public BLLParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasCompra modelo)
        {
            if (modelo.ParcelasCompraID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (modelo.CompraID <= 0)
            {
                throw new Exception("O ID da compra é obrigatório");
            }
            if (modelo.ParcelasCompraValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.ParcelasCompraDataVencimento.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void EfetuaPagamentoParcela(int compra_id, int parcelasCompra_id, DateTime parcelasCompra_dataPagamento)
        {
            if (parcelasCompra_dataPagamento != null)
            {
                DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
                DALobj.EfetuaPagamentoParcela(compra_id, parcelasCompra_id, parcelasCompra_dataPagamento);
            }
            else
            {
                throw new Exception("A data de pagamento é obrigatória");
            }
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.ParcelasCompraID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (modelo.CompraID <= 0)
            {
                throw new Exception("O ID da compra é obrigatório");
            }
            if (modelo.ParcelasCompraValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.ParcelasCompraDataVencimento.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.ParcelasCompraID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (modelo.CompraID <= 0)
            {
                throw new Exception("O ID da compra é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirParcelas(int compra_id)
        {
            if (compra_id <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.ExcluirParcelas(compra_id);
        }
        public DataTable Localizar(int compra_id)
        {
            if (compra_id <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.Localizar(compra_id);
        }
        public ModeloParcelasCompra CarregaModeloParcelasCompra(int CompraID, int ParcelasCompraID)
        {
            if (CompraID <= 0)
            {
                throw new Exception("O ID da parcela é obrigatório");
            }
            if (ParcelasCompraID <= 0)
            {
                throw new Exception("O ID da compra é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.CarregaModeloParcelasCompra(CompraID,ParcelasCompraID);
        }
    }
}
