﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(Modelo.ModeloUsuario modelo)
        {
            if (modelo.UsuarioNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }
            if (modelo.UsuarioSenha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário é obrigatória");
            }
            if (modelo.UsuarioTipo.Trim().Length == 0)
            {
                throw new Exception("O tipo do usuário é obrigatório");
            }
            if (modelo.UsuarioFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do usuário é obrigatório");
            }
            if (modelo.UsuarioEmail.Trim().Length == 0)
            {
                throw new Exception("O email do usuário é obrigatório");
            }
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(Modelo.ModeloUsuario modelo)
        {
            if (modelo.UsuarioID <= 0)
            {
                throw new Exception("O ID do usuário é obrigatório");
            }
            if (modelo.UsuarioNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }
            if (modelo.UsuarioSenha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário é obrigatória");
            }
            if (modelo.UsuarioTipo.Trim().Length == 0)
            {
                throw new Exception("O tipo do usuário é obrigatório");
            }
            if (modelo.UsuarioFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do usuário é obrigatório");
            }
            if (modelo.UsuarioEmail.Trim().Length == 0)
            {
                throw new Exception("O email do usuário é obrigatório");
            }
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int id)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Excluir(id);
        }
        public System.Data.DataTable Localizar(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(valor);
        }
        public Modelo.ModeloUsuario CarregaModeloUsuario(int id)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(id);
        }

    }
}
