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
    public class BLLCompra
    {
        private DALConexao conexao;

        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            if (modelo.CompraData == DateTime.Now)
            {
                  throw new Exception("A data da compra deve ser igual a data atual.");
            }
            if (modelo.CompraTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser maior que zero.");
            }
            if(modelo.CompraNumeroParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que zero.");
            }
            if (modelo.FornecedorID <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }
            if (modelo.TipoPagamentoID <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.CompraID <= 0)
            {
                throw new Exception("O código da compra é obrigatório.");
            }
            if (modelo.CompraData == DateTime.Now)
            {
                throw new Exception("A data da compra deve ser igual a data atual.");
            }
            if (modelo.CompraTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser maior que zero.");
            }
            if (modelo.CompraNumeroParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que zero.");
            }
            if (modelo.FornecedorID <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }
            if (modelo.TipoPagamentoID <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int id)
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(id);
        }
        public DataTable Localizar(int id)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(id);
        }
        public DataTable Localizar(string nome)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(nome);
        }
        public DataTable Localizar(DateTime dataInicial, DateTime dataFinal)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(dataInicial, dataFinal);
        }
        public DataTable Localizar()
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar();
        }
        public DataTable LocalizarParcelasNaoPagas()
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.LocalizarParcelasNaoPagas();
        }
        public int QuantidadeParcelasNaoPagas(int compra_id)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.QuantidadeParcelasNaoPagas(compra_id);
        }
        public ModeloCompra CarregaModeloCompra(int id)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.CarregaModeloCompra(id);
        }
    }
}
