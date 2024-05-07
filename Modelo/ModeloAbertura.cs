using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloAbertura
    {
        public ModeloAbertura() 
        {
            this.abertura_id = 0;
            this.abertura_dataInicial = DateTime.Now;
            this.abertura_dataFinal = DateTime.Now;
            this.abertura_valorInicial = 0;
            this.abertura_valorFinal = 0;
        }
        public ModeloAbertura(int id, DateTime dataInicial, DateTime dataFinal, int valorInicial, int valorFinal)
        {
            this.abertura_id = id;
            this.abertura_dataInicial = dataInicial;
            this.abertura_dataFinal = dataFinal;
            this.abertura_valorInicial = valorInicial;
            this.abertura_valorFinal = valorFinal;
        }
        private int abertura_id;
        public int AberturaID
        {
            get { return this.abertura_id;}
            set { this.abertura_id = value;}
        }
        private DateTime abertura_dataInicial;
        public DateTime dataInicial
        {
            get { return this.abertura_dataInicial; }
            set { this.abertura_dataInicial = value; }
        }
        private DateTime abertura_dataFinal;
        public DateTime dataFinal
        {
            get { return this.abertura_dataFinal; }
            set { this.abertura_dataFinal = value; }
        }
        private int abertura_valorInicial;
        public int ValorInicial
        {
            get { return this.abertura_valorInicial; }
            set { this.abertura_valorInicial = value; }
        }
        private int abertura_valorFinal;
        public int ValorFinal
        {
            get { return this.abertura_valorFinal; }
            set { this.abertura_valorFinal = value; }
        }
    }
}
