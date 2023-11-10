using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasVenda
    {
        public ModeloParcelasVenda()
        {
            this.ParcelasVendaID = 0;
            this.ParcelasVendaValor = 0;
            this.ParcelasVendaDataPagamento = DateTime.Now;
            this.ParcelasVendaDataVencimento = DateTime.Now;
            this.VendaID = 0;
        }
        public ModeloParcelasVenda(int parcelasVenda_id, Double parcelasVenda_valor, DateTime parcelasVenda_dataPagamento,
            DateTime parcelasVenda_dataVencimento, int venda_id)
        {
            this.ParcelasVendaID = parcelasVenda_id;
            this.ParcelasVendaValor = parcelasVenda_valor;
            this.ParcelasVendaDataPagamento = parcelasVenda_dataPagamento;
            this.ParcelasVendaDataVencimento = parcelasVenda_dataVencimento;
            this.VendaID = venda_id;
        }

        private int parcelasVenda_id;
        public int ParcelasVendaID
        {
            get { return this.parcelasVenda_id; }
            set { this.parcelasVenda_id = value; }
        }
        private Double parcelasVenda_valor;
        public Double ParcelasVendaValor
        {
            get { return this.parcelasVenda_valor; }
            set { this.parcelasVenda_valor = value; }
        }
        private DateTime parcelasVenda_dataPagamento;
        public DateTime ParcelasVendaDataPagamento
        {
            get { return this.parcelasVenda_dataPagamento; }
            set { this.parcelasVenda_dataPagamento = value; }
        }
        private DateTime parcelasVenda_dataVencimento;
        public DateTime ParcelasVendaDataVencimento
        {
            get { return this.parcelasVenda_dataVencimento; }
            set { this.parcelasVenda_dataVencimento = value; }
        }
        private int venda_id;
        public int VendaID
        {
            get { return this.venda_id; }
            set { this.venda_id = value; }
        }
    }
}
