using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ModeloUnidadeMedida
    {
        public ModeloUnidadeMedida()
        {
            this.undmed_id = 0;
            this.undmed_nome = "";
        }
        public ModeloUnidadeMedida(int undmed_id, String undmed_nome)
        {
            this.undmed_id = undmed_id;
            this.undmed_nome = undmed_nome;
        }

        private int undmed_id;
        public int UndMedID
        {
            get { return this.undmed_id; }
            set { this.undmed_id = value; }
        }
        private String undmed_nome;
        public String UndMedNome
        {
            get { return this.undmed_nome; }
            set { this.undmed_nome = value; }
        }
        
    }
}

