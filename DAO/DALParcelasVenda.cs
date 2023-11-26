﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALParcelasVenda
    {
        private DALConexao conexao;
        public DALParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into parcelasVenda (parcelasVenda_id, parcelasVenda_valor, parcelasVenda_dataVencimento, venda_id) values " +
                    "(@parcelasVenda_id, @parcelasVenda_valor, @parcelasVenda_dataVencimento, @venda_id); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@parcelasVenda_id", modelo.ParcelasVendaID);
                cmd.Parameters.AddWithValue("@parcelasVenda_valor", modelo.ParcelasVendaValor);
                cmd.Parameters.AddWithValue("@venda_id", modelo.VendaID);
                cmd.Parameters.Add("@parcelasDataVencimento", SqlDbType.Date);

                if (modelo.ParcelasVendaDataVencimento == null)
                {
                    cmd.Parameters["@parcelasDataVencimento"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@parcelasDataVencimento"].Value = modelo.ParcelasVendaDataVencimento;
                }

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Alterar(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update parcelasVenda set parcelasVenda_valor = @parcelasVenda_valor, parcelasVenda_dataPagamento = @parcelasVenda_dataPagamento," +
                    " parcelasVenda_dataVencimento = @parcelasVenda_dataVencimento, " +
                    " where parcelasVenda_id = @parcelasVenda_id and venda_id = @venda_id;";
                cmd.Parameters.AddWithValue("@parcelasVenda_id", modelo.ParcelasVendaID);
                cmd.Parameters.AddWithValue("@parcelasVenda_valor", modelo.ParcelasVendaValor);
                cmd.Parameters.AddWithValue("@venda_id", modelo.VendaID);
                cmd.Parameters.Add("@parcelasDataPagamento", SqlDbType.Date);
                cmd.Parameters.Add("@parcelasDataVencimento", SqlDbType.Date);

                if (modelo.ParcelasVendaDataPagamento == null)
                {
                    cmd.Parameters["@parcelasDataPagamento"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@parcelasDataPagamento"].Value = modelo.ParcelasVendaDataPagamento;
                }

                cmd.Parameters["@parcelasDataVencimento"].Value = modelo.ParcelasVendaDataVencimento;

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
               // conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from parcelasVenda where parcelasVenda_id = @parcelasVenda_id and venda_id = @venda_id;";
                cmd.Parameters.AddWithValue("@parcelasVenda_id", modelo.ParcelasVendaID);
                cmd.Parameters.AddWithValue("@venda_id", modelo.VendaID);
                
                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirParcelas(int venda_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from parcelasVenda where venda_id = @venda_id;";
                cmd.Parameters.AddWithValue("@venda_id", venda_id);

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                //conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Localizar(int venda_id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from parcelasVenda where venda_id = "
                + venda_id.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloParcelasVenda CarregaModeloParcelasVenda(int ParcelasVendaID, int VendaID)
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelasVenda where parcelasVenda_id = @parcelasVenda_id and " +
                "venda_id = @venda_id;";
            cmd.Parameters.AddWithValue("@parcelasVenda_id", ParcelasVendaID);
            cmd.Parameters.AddWithValue("@venda_id", VendaID);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ParcelasVendaID = ParcelasVendaID;
                modelo.VendaID = VendaID;
                modelo.ParcelasVendaValor = Convert.ToDouble(registro["parcelasVenda_valor"]);
                modelo.ParcelasVendaDataPagamento = Convert.ToDateTime(registro["parcelasVenda_dataPagamento"]);
                modelo.ParcelasVendaDataVencimento = Convert.ToDateTime(registro["parcelasVenda_dataVencimento"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
