using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        DALConexao conexao;
        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.ClienteNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            if (modelo.ClienteCPF.Trim().Length == 0)
            {
                throw new Exception("O CPF do cliente é obrigatório");
            }
            if (modelo.ClienteCEP.Trim().Length == 0)
            {
                throw new Exception("O CEP do cliente é obrigatório");
            }
            if (modelo.ClienteEndereco.Trim().Length == 0)
            {
                throw new Exception("O endereço do cliente é obrigatório");
            }
            if (modelo.ClienteBairro.Trim().Length == 0)
            {
                throw new Exception("O bairro do cliente é obrigatório");
            }
            if (modelo.ClienteFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }
            if (modelo.ClienteEmail.Trim().Length == 0)
            {
                throw new Exception("O email do cliente é obrigatório");
            }
            if (modelo.ClienteEndNumero.Trim().Length == 0)
            {
                throw new Exception("O número do endereço do cliente é obrigatório");
            }
            if(modelo.ClienteCidade.Trim().Length == 0)
            {
                throw new Exception("A cidade do cliente é obrigatória");
            }
            if(modelo.ClienteEstado.Trim().Length == 0)
            {
                throw new Exception("O estado do cliente é obrigatório");
            }
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ClienteEmail))
            {
                throw new Exception("Digite um email válido.");
            }
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.ClienteID <= 0)
            {
                throw new Exception("O ID do cliente é obrigatório");
            }
            if (modelo.ClienteNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            if (modelo.ClienteCPF.Trim().Length == 0)
            {
                throw new Exception("O CPF do cliente é obrigatório");
            }
            if (modelo.ClienteCEP.Trim().Length == 0)
            {
                throw new Exception("O CEP do cliente é obrigatório");
            }
            if (modelo.ClienteEndereco.Trim().Length == 0)
            {
                throw new Exception("O endereço do cliente é obrigatório");
            }
            if (modelo.ClienteBairro.Trim().Length == 0)
            {
                throw new Exception("O bairro do cliente é obrigatório");
            }
            if (modelo.ClienteFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }
            if (modelo.ClienteEmail.Trim().Length == 0)
            {
                throw new Exception("O email do cliente é obrigatório");
            }
            if (modelo.ClienteEndNumero.Trim().Length == 0)
            {
                throw new Exception("O número do endereço do cliente é obrigatório");
            }
            if (modelo.ClienteCidade.Trim().Length == 0)
            {
                throw new Exception("A cidade do cliente é obrigatória");
            }
            if (modelo.ClienteEstado.Trim().Length == 0)
            {
                throw new Exception("O estado do cliente é obrigatório");
            }
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ClienteEmail))
            {
                throw new Exception("Digite um email válido.");
            }
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int id)
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(id);
        }
        public System.Data.DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarPorNome(string valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarPorNome(valor);
        }
        public ModeloCliente CarregaModeloCliente(int id)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(id);
        }
        public ModeloCliente CarregaModeloCliente(string cpf)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(cpf);
        }
    }
}
