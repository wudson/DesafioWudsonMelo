﻿using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Interfaces;

namespace projeto2.Feature.Produto.Dao
{
    public class ProdutoDao : ICrudDao
    {
        public bool Cadastrar(object obj)
        {
            var produto = (Produto) obj;
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"INSERT into PRODUTO (NOME_PRODUTO, GRUPO_PRODUTO, MARCA_PRODUTO, TIPO_PRODUTO, 
                                  QUANTIDADE_ESTOQUE_PRODUTO, VALOR_COMPRA_PRODUTO, VALOR_VENDA_PRODUTO, 
                                  FORNECEDOR_PRODUTO) 
                                  Values(@nome, @grupo, @marca, @tipo, @estoque, @compra, @venda, @fornecedor)";

            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = produto.NomeProduto;
                cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = produto.GrupoProduto;
                cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = produto.MarcaProduto;
                cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = produto.TipoProduto;
                cmd.Parameters.Add("@estoque", FbDbType.Integer).Value = produto.QuantidadeEstoqueProduto;
                cmd.Parameters.Add("@compra", FbDbType.Numeric).Value = produto.ValorCompraProduto;
                cmd.Parameters.Add("@venda", FbDbType.Numeric).Value = produto.ValorVendaProduto;
                cmd.Parameters.Add("@fornecedor", FbDbType.Numeric).Value = produto.FornecedorProduto;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public object Buscar(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "Select * from PRODUTO where ID_PRODUTO = @id";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;

                var dataReader = cmd.ExecuteReader();
                var produto = new Produto();
                while (dataReader.Read())
                {
                    produto.IdProduto = Convert.ToInt32(dataReader["ID_PRODUTO"]);
                    produto.NomeProduto = dataReader["NOME_PRODUTO"].ToString();
                    produto.FornecedorProduto = dataReader["FORNECEDOR_PRODUTO"].ToString();
                    produto.ValorCompraProduto = Convert.ToDouble(dataReader["VALOR_COMPRA_PRODUTO"]);
                    produto.ValorVendaProduto = Convert.ToDouble(dataReader["VALOR_VENDA_PRODUTO"]);
                    produto.GrupoProduto = dataReader["GRUPO_PRODUTO"].ToString();
                    produto.MarcaProduto = dataReader["MARCA_PRODUTO"].ToString();
                    produto.TipoProduto = dataReader["TIPO_PRODUTO"].ToString();
                    produto.QuantidadeEstoqueProduto = Convert.ToInt32(dataReader["QUANTIDADE_ESTOQUE_PRODUTO"]);
                }
                return produto;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Excluir(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "DELETE from PRODUTO Where ID_PRODUTO= @id";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IList<object> Listar()
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"Select * from PRODUTO";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                var dataReader = cmd.ExecuteReader();
                var produtos = new List<object>();
                while (dataReader.Read())
                {
                    produtos.Add(new Produto
                    {
                        IdProduto = Convert.ToInt32(dataReader["ID_PRODUTO"]),
                        NomeProduto = dataReader["NOME_PRODUTO"].ToString(),
                        FornecedorProduto = dataReader["FORNECEDOR_PRODUTO"].ToString(),
                        ValorCompraProduto = Convert.ToDouble(dataReader["VALOR_COMPRA_PRODUTO"]),
                        ValorVendaProduto = Convert.ToDouble(dataReader["VALOR_VENDA_PRODUTO"]),
                        GrupoProduto = dataReader["GRUPO_PRODUTO"].ToString(),
                        MarcaProduto = dataReader["MARCA_PRODUTO"].ToString(),
                        TipoProduto = dataReader["TIPO_PRODUTO"].ToString(),
                        QuantidadeEstoqueProduto = Convert.ToInt32(dataReader["QUANTIDADE_ESTOQUE_PRODUTO"])
                    });
                }
                return produtos;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Alterar(object obj)
        {
            var produto = (Produto) obj;
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"Update PRODUTO set NOME_PRODUTO = @nome, GRUPO_PRODUTO = @grupo, 
                                    MARCA_PRODUTO = @marca, TIPO_PRODUTO = @tipo, QUANTIDADE_ESTOQUE_PRODUTO = @estoque, 
                                    VALOR_COMPRA_PRODUTO = @compra, VALOR_VENDA_PRODUTO = @venda, 
                                    FORNECEDOR_PRODUTO = @fornecedor WHERE ID_PRODUTO = @id";

            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = produto.NomeProduto;
                cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = produto.GrupoProduto;
                cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = produto.MarcaProduto;
                cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = produto.TipoProduto;
                cmd.Parameters.Add("@estoque", FbDbType.Integer).Value = produto.QuantidadeEstoqueProduto;
                cmd.Parameters.Add("@compra", FbDbType.Numeric).Value = produto.ValorCompraProduto;
                cmd.Parameters.Add("@venda", FbDbType.Numeric).Value = produto.ValorVendaProduto;
                cmd.Parameters.Add("@fornecedor", FbDbType.Numeric).Value = produto.FornecedorProduto;
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = produto.IdProduto;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}