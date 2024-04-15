using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTipoPagamento
    {
        private DALConexao conexao;
        public BLLTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoPagamento modelo)
        {
            if (modelo.TipoPagamentoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo de pagamento é obrigatório!");
            }
            modelo.TipoPagamentoNome = modelo.TipoPagamentoNome.ToUpper();

            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.TipoPagamentoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo de pagamento é obrigatório!");
            }
            if (modelo.TipoPagamentoID <= 0)
            {
                throw new Exception("O ID do tipo de pagamento é obrigatório!");
            }
            modelo.TipoPagamentoNome = modelo.TipoPagamentoNome.ToUpper();

            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Alterar(modelo); 
        }

        public void Excluir(int id)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Excluir(id);
        }

        public System.Data.DataTable Localizar(String valor)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloTipoPagamento CarregaModeloTipoPagamento(int id)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            return DALobj.CarregaModeloTipoPagamento(id);
        }
    }
}
