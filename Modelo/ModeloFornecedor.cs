using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.fornecedor_id = 0;
            this.fornecedor_nome = "";
            this.fornecedor_razaoSocial = ""; 
            this.fornecedor_inscricaoEstadual = "";
            this.fornecedor_cnpj = "";
            this.fornecedor_cep = "";
            this.fornecedor_endereco = "";
            this.fornecedor_bairro = "";
            this.fornecedor_fone = "";
            this.fornecedor_email = "";
            this.fornecedor_endNumero = "";
            this.fornecedor_cidade = "";
            this.fornecedor_estado = "";
        }

        public ModeloFornecedor(int id, String nome, String razaoSocial, 
            String inscricaoEstadual, String cnpj, String cep, String endereco, 
            String bairro, String fone, String email, String endNumero, String cidade, 
            String estado)
        {
            this.fornecedor_id = id;
            this.fornecedor_nome = nome;
            this.fornecedor_razaoSocial = razaoSocial;
            this.fornecedor_inscricaoEstadual = inscricaoEstadual;
            this.fornecedor_cnpj = cnpj;
            this.fornecedor_cep = cep;
            this.fornecedor_endereco = endereco;
            this.fornecedor_bairro = bairro;
            this.fornecedor_fone = fone;
            this.fornecedor_email = email;
            this.fornecedor_endNumero = endNumero;
            this.fornecedor_cidade = cidade;
            this.fornecedor_estado = estado;
        }

        private int fornecedor_id;
        public int FornecedorID
        {
            get { return this.fornecedor_id; }
            set { this.fornecedor_id = value; }
        }
        private String fornecedor_nome;
        public String FornecedorNome
        {
            get { return this.fornecedor_nome; }
            set { this.fornecedor_nome = value; }
        }
        private String fornecedor_razaoSocial;
        public String FornecedorRazaoSocial
        {
            get { return this.fornecedor_razaoSocial; }
            set { this.fornecedor_razaoSocial = value; }
        }
        private String fornecedor_inscricaoEstadual;
        public String FornecedorInscricaoEstadual
        {
            get { return this.fornecedor_inscricaoEstadual; }
            set { this.fornecedor_inscricaoEstadual = value; }
        }
        private String fornecedor_cnpj;
        public String FornecedorCNPJ
        {
            get { return this.fornecedor_cnpj; }
            set { this.fornecedor_cnpj = value; }
        }
        private String fornecedor_cep;
        public String FornecedorCEP
        {
            get { return this.fornecedor_cep; }
            set { this.fornecedor_cep = value; }
        }
        private String fornecedor_endereco;
        public String FornecedorEndereco
        {
            get { return this.fornecedor_endereco; }
            set { this.fornecedor_endereco = value; }
        }
        private String fornecedor_bairro;
        public String FornecedorBairro
        {
            get { return this.fornecedor_bairro; }
            set { this.fornecedor_bairro = value; }
        }
        private String fornecedor_fone;
        public String FornecedorFone
        {
            get { return this.fornecedor_fone; }
            set { this.fornecedor_fone = value; }
        }

        private String fornecedor_email;
        public String FornecedorEmail
        {
            get { return this.fornecedor_email; }
            set { this.fornecedor_email = value; }
        }
        private String fornecedor_endNumero;
        public String FornecedorEndNumero
        {
            get { return this.fornecedor_endNumero; }
            set { this.fornecedor_endNumero = value; }
        }
        private String fornecedor_cidade;
        public String FornecedorCidade
        {
            get { return this.fornecedor_cidade; }
            set { this.fornecedor_cidade = value; }
        }
        private String fornecedor_estado;
        public String FornecedorEstado
        {
            get { return this.fornecedor_estado; }
            set { this.fornecedor_estado = value; }
        }
    }
}
