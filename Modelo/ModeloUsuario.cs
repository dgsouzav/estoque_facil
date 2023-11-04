using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.usuario_id = 0;
            this.usuario_nome = "";
            this.usuario_senha = "";
            this.usuario_tipo = "";
            this.usuario_fone = "";
            this.usuario_email = "";
        }
        public ModeloUsuario(int usuario_id, String usuario_nome, String usuario_senha, String usuario_tipo, String usuario_fone, String usuario_email)
        {
            this.usuario_id = usuario_id;
            this.usuario_nome = usuario_nome;
            this.usuario_senha = usuario_senha;
            this.usuario_tipo = usuario_tipo;
            this.usuario_fone = usuario_fone;
            this.usuario_email = usuario_email;
        }
        private int usuario_id;
        public int UsuarioID
        {
            get { return this.usuario_id; }
            set { this.usuario_id = value; }
        }
        private String usuario_nome;
        public String UsuarioNome
        {
            get { return this.usuario_nome; }
            set { this.usuario_nome = value; }
        }
        private String usuario_senha;
        public String UsuarioSenha
        {
            get { return this.usuario_senha; }
            set { this.usuario_senha = value; }
        }
        private String usuario_tipo;
        public String UsuarioTipo
        {
            get { return this.usuario_tipo; }
            set { this.usuario_tipo = value; }
        }
        private String usuario_fone;
        public String UsuarioFone
        {
            get { return this.usuario_fone; }
            set { this.usuario_fone = value; }
        }
        private String usuario_email;
        public String UsuarioEmail
        {
            get { return this.usuario_email; }
            set { this.usuario_email = value; }
        }
    }
}
