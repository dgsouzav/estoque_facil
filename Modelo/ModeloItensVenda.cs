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
        public ModeloItensVenda(int id, Double qtde, Double valor, int vendaID, int produtoID)
        {
            this.ItensVendaID = id;
            this.ItensVendaQtde = qtde;
            this.ItensVendaValor = valor;
            this.VendaID = vendaID;
            this.ProdutoID = produtoID;
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
