using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoPagamento
    {
        public ModeloTipoPagamento()
        {
            this.TipoPagamentoID = 0;
            this.TipoPagamentoNome = "";
        }

        public ModeloTipoPagamento(int tipoPagamento_id, String tipoPagamento_nome)
        {
            this.TipoPagamentoID = tipoPagamento_id;
            this.TipoPagamentoNome = tipoPagamento_nome;
        }

        private int tipoPagamento_id;
        public int TipoPagamentoID
        {
            get { return this.tipoPagamento_id; }
            set { this.tipoPagamento_id = value; }
        }

        private String tipoPagamento_nome;
        public String TipoPagamentoNome
        {
            get { return this.tipoPagamento_nome; }
            set { this.tipoPagamento_nome = value; }
        }
    }
}
