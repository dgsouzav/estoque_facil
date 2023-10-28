using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()
        {
            this.subcategoria_id = 0;
            this.subcategoria_nome = "";
            this.categoria_id = 0;
        }

        public ModeloSubCategoria(int subcategoria_id, String subcategoria_nome, int categoria_id)
        {
            this.subcategoria_id = subcategoria_id;
            this.subcategoria_nome = subcategoria_nome;
            this.categoria_id = categoria_id;
        }

        private int subcategoria_id;
        public int SubCategoriaID
        {
            get { return this.subcategoria_id; }
            set { this.subcategoria_id = value; }
        }
        private String subcategoria_nome;
        public String SubCategoriaNome
        {
            get { return this.subcategoria_nome; }
            set { this.subcategoria_nome = value; }
        }
        private int categoria_id;
        public int CategoriaID
        {
            get { return this.categoria_id; }
            set { this.categoria_id = value; }
        }
    }
}
