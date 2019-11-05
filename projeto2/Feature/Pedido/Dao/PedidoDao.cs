﻿using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Pedido.Model;

namespace projeto2.Feature.Pedido.Dao
{
    public class PedidoDao
    {
        public bool Cadastrar(PedidoModel pedido)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"INSERT into PEDIDO (DATA_PEDIDO, VALOR_TOTAL_PEDIDO, ID_CLIENTE) 
                                    Values(@data, @valorT, @idCli) RETURNING ID_PEDIDO";

            var transaction = conn.BeginTransaction();
            var cmd = new FbCommand(mSql, conn, transaction);
            try
            {
                cmd.Parameters.Add("@idCli", FbDbType.Integer).Value = 34;
                cmd.Parameters.Add("@data", FbDbType.Date).Value = pedido.DataPedido;
                cmd.Parameters.Add("@valorT", FbDbType.Date).Value = pedido.PrecoTotalPedido;

                var idPedido = int.Parse(cmd.ExecuteScalar().ToString());

                if (CadastrarProdutosDoPedido(pedido, idPedido, cmd))
                    transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        private static bool CadastrarProdutosDoPedido(PedidoModel pedido, int idPedido, FbCommand cmd)
        {
            const string mSql = @"INSERT into ITEM_PEDIDO (ID_PRODUTO, ID_PEDIDO, QUANTIDADE) 
                                    Values(@prod, @pedido, @quant)";
            cmd.CommandText = mSql;
            try
            {
                cmd.Parameters.Add("@prod", FbDbType.Integer);
                cmd.Parameters.Add("@pedido", FbDbType.Integer);
                cmd.Parameters.Add("@quant", FbDbType.Integer);

                foreach (var produto in pedido.Produtos)
                {
                    cmd.Parameters["@prod"].Value = produto.IdProduto;
                    cmd.Parameters["@pedido"].Value = idPedido;
                    cmd.Parameters["@quant"].Value = 10;
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"erro ao cadastrar produtos do pedido: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<PedidoModel> Listar()
        {
            var conn = Conexao.GetInstancia();
            conn.Open();

            const string mSql = @"Select pedido.*, pessoa.NOME_PESSOA 
                                from PEDIDO pedido, CLIENTE cliente, PESSOA pessoa 
                                where pedido.ID_CLIENTE = cliente.ID_CLIENTE and cliente.ID_PESSOA = pessoa.ID_PESSOA";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                var dataReader = cmd.ExecuteReader();
                var pedidos = new List<PedidoModel>();
                while (dataReader.Read())
                {
                    pedidos.Add(new PedidoModel
                    {
                        IdPedido = Convert.ToInt32(dataReader["ID_PEDIDO"]),
                        DataPedido = Convert.ToDateTime(dataReader["DATA_PEDIDO"]),
                        PrecoTotalPedido = Convert.ToDouble(dataReader["VALOR_TOTAL_PEDIDO"]),
                        IdClientePedido = Convert.ToInt32(dataReader["ID_PESSOA"])
                    });
                }
                return pedidos;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IEnumerable<ItemPedidoModel> BuscarProdutosDoPedido(int idPedido)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"select ip.*, p.* from ITEM_PEDIDO ip, PRODUTO p 
                                where ip.ID_PRODUTO = p.ID_PRODUTO and ip.ID_PEDIDO = @idPedido";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@idPedido", FbDbType.Integer).Value = idPedido;

                var dataReader = cmd.ExecuteReader();
                var itensPedido = new List<ItemPedidoModel>();

                while (dataReader.Read())
                {
                    itensPedido.Add(new ItemPedidoModel
                    {
                        IdItemPedido = Convert.ToInt32(dataReader["ID_ITEM"]),
                        Quantidade = Convert.ToInt32(dataReader["QUANTIDADE"]),
                        ProdutosPedido = new Produto.Produto
                        {
                            IdProduto = Convert.ToInt32(dataReader["ID_PRODUTO"]),
                            NomeProduto = dataReader["NOME_PRODUTO"].ToString(),
                            ValorVendaProduto = Convert.ToDouble(dataReader["VALOR_VENDA_PRODUTO"]),
                            TipoProduto = dataReader["TIPO_PRODUTO"].ToString()
                        }
                    });
                }
                return itensPedido;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
