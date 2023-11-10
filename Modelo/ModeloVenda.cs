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
            this.venda_status = 0;
            this.usuario_id = 0;
            this.tipoPagamento_id = 0;
            this.venda_aVista = 0;
        }
        public ModeloVenda(int id, DateTime data, int notaFiscal, Double total, int numeroParcelas, 
            int status, int usuario_id, int tipoPagamento_id, int aVista)
        {
            this.venda_id = id;
            this.venda_data = data;
            this.venda_notaFiscal = notaFiscal;
            this.venda_total = total;
            this.venda_numeroParcelas = numeroParcelas;
            this.venda_status = status;
            this.usuario_id = usuario_id;
            this.tipoPagamento_id = tipoPagamento_id;
            this.venda_aVista = aVista;
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
        private int venda_status;
        public int VendaStatus
        {
            get { return this.venda_status; }
            set { this.venda_status = value; }
        }
        private int usuario_id;
        public int UsuarioID
        {
            get { return this.usuario_id; }
            set { this.usuario_id = value; }
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
    }
}
