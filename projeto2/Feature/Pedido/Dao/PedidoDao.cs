using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Model;
using System;
using System.Collections.Generic;

namespace projeto2.Feature.Pedido.Dao
{
    public class PedidoDao
    {
        public virtual bool Cadastrar(PedidoModel pedido, FbCommand cmd)
        {
            const string mSql = @"INSERT into PEDIDO (DATA_PEDIDO, VALOR_TOTAL_PEDIDO, ID_CLIENTE) 
                                    Values(@data, @valorT, @idCli) RETURNING ID_PEDIDO";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@idCli", FbDbType.Integer).Value = pedido.Cliente.IdCliente;
            cmd.Parameters.Add("@data", FbDbType.Date).Value = pedido.DataPedido;
            cmd.Parameters.Add("@valorT", FbDbType.Date).Value = pedido.PrecoTotalPedido;

            pedido.IdPedido = int.Parse(cmd.ExecuteScalar().ToString());

            return CadastrarProdutosDoPedido(pedido, cmd);

        }
        private static bool CadastrarProdutosDoPedido(PedidoModel pedido, FbCommand cmd)
        {
            const string mSql = @"INSERT into ITEM_PEDIDO (ID_PRODUTO, ID_PEDIDO, QUANTIDADE) 
                                    Values(@prod, @pedido, @quant)";
            cmd.CommandText = mSql;

            cmd.Parameters.Add("@prod", FbDbType.Integer);
            cmd.Parameters.Add("@pedido", FbDbType.Integer);
            cmd.Parameters.Add("@quant", FbDbType.Integer);

            foreach (var produto in pedido.Produtos)
            {
                cmd.Parameters["@prod"].Value = produto.IdProduto;
                cmd.Parameters["@pedido"].Value = pedido.IdPedido;
                cmd.Parameters["@quant"].Value = produto.QuantidadeProdutoPedido;
                cmd.ExecuteNonQuery();
            }

            return true;
        }

        public virtual IEnumerable<PedidoModel> Listar(FbCommand cmd)
        {
            const string mSql = @"Select pedido.*, p.* from PEDIDO pedido 
                                INNER JOIN CLIENTE as c ON pedido.ID_CLIENTE = c.ID_CLIENTE
                                INNER JOIN PESSOA as p ON c.ID_PESSOA = p.ID_PESSOA ORDER BY DATA_PEDIDO";

            cmd.CommandText = mSql;

            var dataReader = cmd.ExecuteReader();
            var pedidos = new List<PedidoModel>();
            while (dataReader.Read())
            {
                pedidos.Add(new PedidoModel
                {
                    IdPedido = Convert.ToInt32(dataReader["ID_PEDIDO"]),
                    DataPedido = Convert.ToDateTime(dataReader["DATA_PEDIDO"]),
                    PrecoTotalPedido = Convert.ToDouble(dataReader["VALOR_TOTAL_PEDIDO"]),
                    Cliente = new ClienteModel
                    {
                        IdCliente = Convert.ToInt32(dataReader["ID_CLIENTE"]),
                        NomePessoa = dataReader["NOME_PESSOA"].ToString()
                    }
                });
            }
            return pedidos;
        }

        public virtual IEnumerable<ItemPedidoModel> BuscarProdutosDoPedido(int idPedido, FbCommand cmd)
        {
            const string mSql = @"select ip.*, p.*, pm.VALOR_COM_DESCONTO from ITEM_PEDIDO ip 
                                INNER JOIN PRODUTO as p ON ip.ID_PRODUTO = p.ID_PRODUTO
                                LEFT JOIN ITEM_PROMOCAO as pm ON p.ID_PRODUTO = pm.ID_PRODUTO
                                WHERE ip.ID_PEDIDO = @idPedido";

            cmd.CommandText = mSql;

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
                        TipoProduto = dataReader["TIPO_PRODUTO"].ToString(),
                        ValorComDesconto = Convert.ToDouble(dataReader["VALOR_COM_DESCONTO"] != DBNull.Value
                            ? dataReader["VALOR_COM_DESCONTO"]
                            : dataReader["VALOR_VENDA_PRODUTO"])
                    }
                });
            }
            return itensPedido;
        }
    }
}
