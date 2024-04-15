using DAL;
using Modelo;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Validacoes;

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
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.FornecedorEmail))
            {
                throw new Exception("Digite um email válido.");
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
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.FornecedorEmail))
            {
                throw new Exception("Digite um email válido.");
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
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from fornecedor where fornecedor_nome like '%" +
                               valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorNome(String valor)
        {
            return Localizar(valor);
        }
        public DataTable LocalizarPorCNPJ(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from fornecedor where fornecedor_cnpj like '%" +
                                              valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
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
