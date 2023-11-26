using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensVenda
    {
        public ModeloItensVenda()
        {
            this.ItensVendaID = 0;
            this.ItensVendaQtde = 0;
            this.ItensVendaValor = 0;
            this.VendaID = 0;
            this.ProdutoID = 0;
        }
        public ModeloItensVenda(int itensVenda_id, Double itensVenda_qtde, Double itensVenda_valor, int venda_id, int produto_id)
        {
            this.ItensVendaID = itensVenda_id;
            this.ItensVendaQtde = itensVenda_qtde;
            this.ItensVendaValor = itensVenda_valor;
            this.VendaID = venda_id;
            this.ProdutoID = produto_id;
        }
        private int itensVenda_id;
        public int ItensVendaID
        {
            get { return this.itensVenda_id; }
            set { this.itensVenda_id = value; }
        }
        private Double itensVenda_qtde;
        public Double ItensVendaQtde
        {
            get { return this.itensVenda_qtde; }
            set { this.itensVenda_qtde = value; }
        }
        private Double itensVenda_valor;
        public Double ItensVendaValor
        {
            get { return this.itensVenda_valor; }
            set { this.itensVenda_valor = value; }
        }
        private int venda_id;
        public int VendaID
        {
            get { return this.venda_id; }
            set { this.venda_id = value; }
        }
        private int produto_id;
        public int ProdutoID
        {
            get { return this.produto_id; }
            set { this.produto_id = value; }
        }
    }
}
