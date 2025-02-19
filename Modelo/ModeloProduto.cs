﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto() 
        {
            this.produto_id = 0;
            this.produto_nome = "";
            this.produto_descricao = "";
            this.produto_valorpago = 0;
            this.valorvenda = 0;
            this.produto_lote = 0;
            this.undmed_id = 0;
            this.categoria_id = 0;
            this.subCategoria_id = 0;
            this.produto_qtde = 0;
            this.fornecedor_id = 0;
            this.produto_validade = DateTime.MinValue;
        }

        public ModeloProduto(int produto_id, String produto_nome, String produto_descricao, 
            Double produto_valorpago, Double produto_valorvenda, Double produto_lote, 
            int undmed_id, int categoria_id, int subCategoria_id, float produto_qtde, int fornecedor_id, DateTime produto_validade)
        {
            this.produto_id = produto_id;
            this.produto_nome = produto_nome;
            this.produto_descricao = produto_descricao;
            this.produto_valorpago = produto_valorpago;
            this.valorvenda = produto_valorvenda;
            this.produto_lote = produto_lote;
            this.undmed_id = undmed_id;
            this.categoria_id = categoria_id;
            this.subCategoria_id = subCategoria_id;
            this.produto_qtde = produto_qtde;
            this.produto_id = fornecedor_id;
            this.produto_validade = produto_validade;
        }

        private int produto_id;
        public int ProdutoID
        {
            get { return this.produto_id; }
            set { this.produto_id = value; }
        }
        private String produto_nome;
        public String ProdutoNome
        {
            get { return this.produto_nome; }
            set { this.produto_nome = value; }
        }
        private String produto_descricao;
        public String ProdutoDescricao
        {
            get { return this.produto_descricao; }
            set { this.produto_descricao = value; }
        }
        private Double produto_valorpago;
        public Double ProdutoValorPago
        {
            get { return this.produto_valorpago; }
            set { this.produto_valorpago = value; }
        }
        private Double valorvenda;
        public Double ProdutoValorVenda
        {
            get { return this.valorvenda; }
            set { this.valorvenda = value; }
        }

        private Double produto_lote;
        public Double ProdutoLote
        {
            get { return this.produto_lote; }
            set { this.produto_lote = value; }
        }
        public float produto_qtde;
        public float ProdutoQtde
        {
            get { return this.produto_qtde; }
            set { this.produto_qtde = value; }
        }

        private int undmed_id;
        public int UndMedID
        {
            get { return this.undmed_id; }
            set { this.undmed_id = value; }
        }

        private int categoria_id;
        public int CategoriaID
        {
            get { return this.categoria_id; }
            set { this.categoria_id = value; }
        }
        private int subCategoria_id;
        public int SubCategoriaID
        {
            get { return this.subCategoria_id; }
            set { this.subCategoria_id = value; }
        }
        private int fornecedor_id;
        public int FornecedorID
        {
            get { return this.fornecedor_id; }
            set { this.fornecedor_id = value; }
        }
        public DateTime produto_validade;
        public DateTime ProdutoValidade
        {
            get { return this.produto_validade; }
            set { this.produto_validade = value; }
        }
    }
}
