using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente() 
        {
            this.cliente_id = 0;
            this.cliente_nome = "";
            this.cliente_cpf = "";
            this.cliente_cep = "";
            this.cliente_endereco = "";
            this.cliente_bairro = "";
            this.cliente_fone = "";
            this.cliente_email = "";
            this.cliente_endNumero = "";
            this.cliente_cidade = "";
            this.cliente_estado = "";
        }
        public ModeloCliente(int id, String nome, String cpf, String tipo, String cep, String endereco, String bairro, String fone, String email, String endNumero, String cidade, String estado)
        {
            this.cliente_id = id;
            this.cliente_nome = nome;
            this.cliente_cpf = cpf;
            this.cliente_cep = cep;
            this.cliente_endereco = endereco;
            this.cliente_bairro = bairro;
            this.cliente_fone = fone;
            this.cliente_email = email;
            this.cliente_endNumero = endNumero;
            this.cliente_cidade = cidade;
            this.cliente_estado = estado;
        }
        private int cliente_id;
        public int ClienteID
        {
            get { return this.cliente_id; }
            set { this.cliente_id = value; }
        }
        private String cliente_nome;
        public String ClienteNome
        {
            get { return this.cliente_nome; }
            set { this.cliente_nome = value; }
        }
        private String cliente_cpf;
        public String ClienteCPF
        {
            get { return this.cliente_cpf; }
            set { this.cliente_cpf = value; }
        }
        private String cliente_cep;
        public String ClienteCEP
        {
            get { return this.cliente_cep; }
            set { this.cliente_cep = value; }
        }
        private String cliente_endereco;
        public String ClienteEndereco
        {
            get { return this.cliente_endereco; }
            set { this.cliente_endereco = value; }
        }
        private String cliente_bairro;
        public String ClienteBairro
        {
            get { return this.cliente_bairro; }
            set { this.cliente_bairro = value; }
        }
        private String cliente_fone;
        public String ClienteFone
        {
            get { return this.cliente_fone; }
            set { this.cliente_fone = value; }
        }
        private String cliente_email;
        public String ClienteEmail
        {
            get { return this.cliente_email; }
            set { this.cliente_email = value; }
        }
        private String cliente_endNumero;
        public String ClienteEndNumero
        {
            get { return this.cliente_endNumero; }
            set { this.cliente_endNumero = value; }
        }
        private String cliente_cidade;
        public String ClienteCidade
        {
            get { return this.cliente_cidade; }
            set { this.cliente_cidade = value; }
        }
        private String cliente_estado;
        public String ClienteEstado
        {
            get { return this.cliente_estado; }
            set { this.cliente_estado = value; }
        }
    }
}
