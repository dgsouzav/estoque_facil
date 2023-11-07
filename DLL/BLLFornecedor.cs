using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFornecedor
    {
        DALConexao conexao;
        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.FornecedorNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            if (modelo.FornecedorRazaoSocial.Trim().Length == 0)
            {
                throw new Exception("A razão social do fornecedor é obrigatória");
            }
            if (modelo.FornecedorInscricaoEstadual.Trim().Length == 0)
            {
                throw new Exception("A inscrição estadual do fornecedor é obrigatória");
            }
            if (modelo.FornecedorCNPJ.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }
            if (modelo.FornecedorCEP.Trim().Length == 0)
            {
                throw new Exception("O CEP do fornecedor é obrigatório");
            }
            if (modelo.FornecedorEndereco.Trim().Length == 0)
            {
                throw new Exception("O endereço do fornecedor é obrigatório");
            }
            if (modelo.FornecedorBairro.Trim().Length == 0)
            {
                throw new Exception("O bairro do fornecedor é obrigatório");
            }
            if (modelo.FornecedorFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do fornecedor é obrigatório");
            }
            if (modelo.FornecedorEmail.Trim().Length == 0)
            {
                throw new Exception("O email do fornecedor é obrigatório");
            }
            if (modelo.FornecedorEndNumero.Trim().Length == 0)
            {
                throw new Exception("O número do endereço do fornecedor é obrigatório");
            }
            if (modelo.FornecedorCidade.Trim().Length == 0)
            {
                throw new Exception("A cidade do fornecedor é obrigatória");
            }
            if (modelo.FornecedorEstado.Trim().Length == 0)
            {
                throw new Exception("O estado do fornecedor é obrigatório");
            }
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.FornecedorID <= 0)
            {
                throw new Exception("O ID do fornecedor é obrigatório");
            }
            if (modelo.FornecedorNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            if (modelo.FornecedorRazaoSocial.Trim().Length == 0)
            {
                throw new Exception("A razão social do fornecedor é obrigatória");
            }
            if (modelo.FornecedorInscricaoEstadual.Trim().Length == 0)
            {
                throw new Exception("A inscrição estadual do fornecedor é obrigatória");
            }
            if (modelo.FornecedorCNPJ.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }
            if (modelo.FornecedorCEP.Trim().Length == 0)
            {
                throw new Exception("O CEP do fornecedor é obrigatório");
            }
            if (modelo.FornecedorEndereco.Trim().Length == 0)
            {
                throw new Exception("O endereço do fornecedor é obrigatório");
            }
            if (modelo.FornecedorBairro.Trim().Length == 0)
            {
                throw new Exception("O bairro do fornecedor é obrigatório");
            }
            if (modelo.FornecedorFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do fornecedor é obrigatório");
            }
            if (modelo.FornecedorEmail.Trim().Length == 0)
            {
                throw new Exception("O email do fornecedor é obrigatório");
            }
            if (modelo.FornecedorEndNumero.Trim().Length == 0)
            {
                throw new Exception("O número do endereço do fornecedor é obrigatório");
            }
            if (modelo.FornecedorCidade.Trim().Length == 0)
            {
                throw new Exception("A cidade do fornecedor é obrigatória");
            }
            if (modelo.FornecedorEstado.Trim().Length == 0)
            {
                throw new Exception("O estado do fornecedor é obrigatório");
            }
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int id)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Excluir(id);
        }
        public DataTable Localizar(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarPorNome(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorNome(valor);
        }
        public DataTable LocalizarPorCNPJ(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorCNPJ(valor);
        }
        public ModeloFornecedor CarregaModeloFornecedor(int id)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(id);
        }
        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(cnpj);
        }
    }
}
