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
    public class BLLProduto
    {
        DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProduto modelo)
        {
            if (modelo.ProdutoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            if (modelo.ProdutoDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }
            if (modelo.ProdutoValorPago <= 0)
            {
                throw new Exception("O valor de compra do produto é obrigatório");
            }
            if (modelo.ProdutoValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }
            if (modelo.ProdutoLote <= 0)
            {
                throw new Exception("O lote do produto é obrigatória");
            }
            if (modelo.UndMedID <= 0)
            {
                throw new Exception("A unidade de medida do produto é obrigatória");
            }
            if (modelo.CategoriaID <= 0)
            {
                throw new Exception("A categoria do produto é obrigatória");
            }
            if (modelo.SubCategoriaID <= 0)
            {
                throw new Exception("A subcategoria do produto é obrigatória");
            }
            if (modelo.FornecedorID <= 0)
            {
                throw new Exception("O Fornecedor do produto é obrigatóri0");
            }
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto é obrigatório");
            }
            if (modelo.ProdutoNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            if (modelo.ProdutoDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }
            if (modelo.ProdutoValorPago <= 0)
            {
                throw new Exception("O valor de compra do produto é obrigatório");
            }
            if (modelo.ProdutoValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }
            if (modelo.ProdutoLote <= 0)
            {
                throw new Exception("O lote do produto é obrigatória");
            }
            if (modelo.UndMedID <= 0)
            {
                throw new Exception("A unidade de medida do produto é obrigatória");
            }
            if (modelo.CategoriaID <= 0)
            {
                throw new Exception("A categoria do produto é obrigatória");
            }
            if (modelo.SubCategoriaID <= 0)
            {
                throw new Exception("A subcategoria do produto é obrigatória");
            }
            if (modelo.FornecedorID <= 0)
            {
                throw new Exception("O Fornecedor do produto é obrigatóri0");
            }
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(modelo);
        }
        public void Alterar(ModeloProduto obj, Boolean transacao)
        {
            if (obj.ProdutoID <= 0)
            {
                throw new Exception("O ID do produto é obrigatório");
            }
            if (obj.ProdutoLote <= 0)
            {
                throw new Exception("O lote do produto é obrigatória");
            }
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(obj, transacao);
        }
        public ModeloProduto CarregaModeloProduto(int id, Boolean transacao)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(id, transacao);
        }
        public void Excluir(int id)
        {
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Excluir(id);
        }
        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloProduto CarregaModeloProduto(int id)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(id);
        }
        public DataTable LocalizarProdutoFaltante(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.LocalizarProdutoFaltante(valor);
        }
    }
}
