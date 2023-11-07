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
            this.usuario_nivelAcesso = "";
            
        }
        public ModeloUsuario(int usuario_id, String usuario_nome, String usuario_senha, String usuario_nivelAcesso )
        {
            this.usuario_id = usuario_id;
            this.usuario_nome = usuario_nome;
            this.usuario_senha = usuario_senha;
            this.usuario_nivelAcesso = usuario_nivelAcesso;
            
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
        private String usuario_nivelAcesso;
        public String UsuarioNivelAcesso
        {
            get { return this.usuario_nivelAcesso; }
            set { this.usuario_nivelAcesso = value; }
        }
        
    }
}
