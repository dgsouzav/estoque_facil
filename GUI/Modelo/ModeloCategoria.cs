using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        public ModeloCategoria()
        {
            this.categoria_id = 0;
            this.categoria_nome = "";
        }

        public ModeloCategoria(int categoria_id, String categoria_nome)
        {
            this.categoria_id = categoria_id;
            this.categoria_nome = categoria_nome;
        }
        private int categoria_id;
        public int CategoriaID
        {
            get { return this.categoria_id; }
            set { this.categoria_id = value; }
        }
        private String categoria_nome;
        public String CategoriaNome
        {
            get { return this.categoria_nome; }
            set { this.categoria_nome = value; }
        }
    }
}
