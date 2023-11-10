using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensCompra
    {
        public ModeloItensCompra()
        {
            this.ItensCompraID = 0;
            this.ItensCompraQtde = 0;
            this.ItensCompraValor = 0;
            this.CompraID = 0;
            this.ProdutoID = 0;
        }

        public ModeloItensCompra(int itensCompra_id, double itensCompra_qtde, double itensCompra_valor, int compra_id, int produto_id)
        {
            this.ItensCompraID = itensCompra_id;
            this.ItensCompraQtde = itensCompra_qtde;
            this.ItensCompraValor = itensCompra_valor;
            this.CompraID = compra_id;
            this.ProdutoID = produto_id;
        }

        private int itensCompra_id;
        public int ItensCompraID
        {
            get { return this.itensCompra_id; }
            set { this.itensCompra_id = value; }
        }

        private double itensCompra_qtde;
        public double ItensCompraQtde
        {
            get { return this.itensCompra_qtde; }
            set { this.itensCompra_qtde = value; }
        }

        private double itensCompra_valor;
        public double ItensCompraValor
        {
            get { return this.itensCompra_valor; }
            set { this.itensCompra_valor = value; }
        }

        private int compra_id;
        public int CompraID
        {
            get { return this.compra_id; }
            set { this.compra_id = value; }
        }

        private int produto_id;
        public int ProdutoID
        {
            get { return this.produto_id; }
            set { this.produto_id = value; }
        }
    }
}
