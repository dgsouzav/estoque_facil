﻿using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CategoriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }


            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CategoriaID <= 0)
            {
                throw new Exception("O ID da categoria é obrigatório");
            }

            if (modelo.CategoriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }


            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(id);
        }

        public DataTable Localizar(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int id)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregaModeloCategoria(id);
        }

    }
}
