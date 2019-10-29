using System;
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
            catch (Exception ex)
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
    }
}
