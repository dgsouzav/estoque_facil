using System;
using Google.Type;
using DateTime = System.DateTime;

namespace Modelo
{
    public class ModeloCompra
    {
        public ModeloCompra()
        {
            this.CompraID = 0;
            this.CompraData = DateTime.Now;
            this.CompraNotaFiscal = 0;
            this.CompraTotal = 0;
            this.CompraStatus = "Ativa";
            this.FornecedorID = 0;
            this.TipoPagamentoID = 0;
        }

        public ModeloCompra(int compra_id, DateTime compra_data, int compra_notaFiscal, 
            double compra_total, String compra_status, int fornecedor_id, int tipoPagamento_id)
        {
            this.CompraID = compra_id;
            this.CompraData = compra_data;
            this.CompraNotaFiscal = compra_notaFiscal;
            this.CompraTotal = compra_total;
            this.CompraStatus = compra_status;
            this.FornecedorID = fornecedor_id;
            this.TipoPagamentoID = tipoPagamento_id;
        }

        private int compra_id;
        public int CompraID
        {
            get { return this.compra_id; }
            set { this.compra_id = value; }
        }

        private DateTime compra_data;
        public DateTime CompraData
        {
            get { return this.compra_data; }
            set { this.compra_data = value; }
        } 

        private int compra_notaFiscal;
        public int CompraNotaFiscal
        {
            get { return this.compra_notaFiscal; }
            set { this.compra_notaFiscal = value; }
        }
        private Double compra_total;
        public Double CompraTotal
        {
            get { return this.compra_total; }
            set { this.compra_total = value; }
        }
        private String compra_status;
        public String CompraStatus
        {
            get { return this.compra_status; }
            set { this.compra_status = value; }
        }
        private int fornecedor_id;
        public int FornecedorID
        {
            get { return this.fornecedor_id; }
            set { this.fornecedor_id = value; }
        }
        private int tipoPagamento_id;
        public int TipoPagamentoID
        {
            get { return this.tipoPagamento_id; }
            set { this.tipoPagamento_id = value; }
        }
    }
}
