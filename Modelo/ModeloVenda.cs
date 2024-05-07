using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVenda
    {
        public ModeloVenda()
        {
            this.venda_id = 0;
            this.venda_data = DateTime.Now;
            this.venda_notaFiscal = 0;
            this.venda_total = 0;
            this.venda_numeroParcelas = 0;
            this.venda_status = "Válida";
            this.tipoPagamento_id = 0;
            this.venda_aVista = 1;
            this.cliente_id = 0;
            this.venda_descricao = "";
            this.venda_tipoTransacao = "Gasto";
            this.venda_gastoNome = "";
        }
        public ModeloVenda(int id, DateTime data, int notaFiscal, Double total, int numeroParcelas, 
            String status, int tipoPagamento_id, int aVista, int cliente_id, string venda_descricao, string venda_tipoTransacao,
            string venda_gastoNome)
        {
            this.venda_id = id;
            this.venda_data = data;
            this.venda_notaFiscal = notaFiscal;
            this.venda_total = total;
            this.venda_numeroParcelas = numeroParcelas;
            this.venda_status = status;
            this.tipoPagamento_id = tipoPagamento_id;
            this.venda_aVista = aVista;
            if (cliente_id != 0)
            {
                this.cliente_id = cliente_id;
            }
            this.venda_descricao = venda_descricao;
            this.venda_tipoTransacao = venda_tipoTransacao;
            this.venda_gastoNome = venda_gastoNome;
        }
        private int venda_id;
        public int VendaID
        {
            get { return this.venda_id; }
            set { this.venda_id = value; }
        }
        private DateTime venda_data;
        public DateTime VendaData
        {
            get { return this.venda_data; }
            set { this.venda_data = value; }
        }
        private int venda_notaFiscal;
        public int VendaNotaFiscal
        {
            get { return this.venda_notaFiscal; }
            set { this.venda_notaFiscal = value; }
        }
        private Double venda_total;
        public Double VendaTotal
        {
            get { return this.venda_total; }
            set { this.venda_total = value; }
        }
        private int venda_numeroParcelas;
        public int VendaNumeroParcelas
        {
            get { return this.venda_numeroParcelas; }
            set { this.venda_numeroParcelas = value; }
        }
        private String venda_status;
        public String VendaStatus
        {
            get { return this.venda_status; }
            set { this.venda_status = value; }
        }
        private int tipoPagamento_id;
        public int TipoPagamentoID
        {
            get { return this.tipoPagamento_id; }
            set { this.tipoPagamento_id = value; }
        }
        private int venda_aVista;
        public int VendaAVista
        {
            get { return this.venda_aVista; }
            set { this.venda_aVista = value; }
        }
        private int cliente_id;
        public int ClienteID
        {
            get { return this.cliente_id; }
            set { this.cliente_id = value; }
        }
        private string venda_descricao;
        public string VendaDescricao
        {
            get { return this.venda_descricao; }
            set { this.venda_descricao = value; }
        }
        private string venda_tipoTransacao;
        public string VendaTipoTransacao
        {
            get { return this.venda_tipoTransacao; }
            set { this.venda_tipoTransacao = value; }
        }
        private string venda_gastoNome;
        public string VendaGastoNome
        {
            get { return this.venda_gastoNome; }
            set { this.venda_gastoNome = value; }
        }
    }
}
