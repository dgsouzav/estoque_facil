﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasCompra
    {
        public ModeloParcelasCompra()
        {
            this.ParcelasCompraID = 0;
            this.ParcelasCompraValor = 0;
            //this.ParcelasCompraDataPagamento = DateTime.MinValue;
            this.ParcelasCompraDataVencimento = DateTime.Now;
            this.CompraID = 0;
        }

        private int parcelasCompra_id;
        public int ParcelasCompraID
        {
            get { return this.parcelasCompra_id; }
            set { this.parcelasCompra_id = value; }
        }
        private Double parcelasCompra_valor;
        public Double ParcelasCompraValor
        {
            get { return this.parcelasCompra_valor; }
            set { this.parcelasCompra_valor = value; }
        }
        private DateTime parcelasCompra_dataPagamento;
        public DateTime ParcelasCompraDataPagamento
        {
            get { return this.parcelasCompra_dataPagamento; }
            set { this.parcelasCompra_dataPagamento = value; }
        }
        private DateTime parcelasCompra_dataVencimento;
        public DateTime ParcelasCompraDataVencimento
        {
            get { return this.parcelasCompra_dataVencimento; }
            set { this.parcelasCompra_dataVencimento = value; }
        }
        private int compra_id;
        public int CompraID
        {
            get { return this.compra_id; }
            set { this.compra_id = value; }
        }
    }
}
