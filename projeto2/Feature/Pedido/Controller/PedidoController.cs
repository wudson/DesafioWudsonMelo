using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Pedido.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projeto2.Feature.Pedido.Controller
{
    public class PedidoController
    {
        private readonly PedidoDao _dao;
        private readonly FrmPedidos _frmPedidos;

        private readonly NovoPedidoController _novoPedidoController;
        private readonly ItensPedidoController _itensPedidoController;

        public PedidoController()
        {
            _dao = new PedidoDao();
            _frmPedidos = new FrmPedidos(this);

            _novoPedidoController = new NovoPedidoController();
            _itensPedidoController = new ItensPedidoController();
        }

        public void AbrirTelaDePedidos() =>
            _frmPedidos.ShowDialog();

        public void AbrirTelaDeNovoPedido() => _novoPedidoController.AbrirTelaDeNovoPedido();

        public void AbrirTelaParaExibirItensDoPedido(IEnumerable<ItemPedidoModel> pedido) =>
            _itensPedidoController.AbrirTelaParaExibirItensDoPedido(pedido);

        public IEnumerable<PedidoModel> BuscarTodosOsDados()
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                var pedidos = _dao.Listar(cmd).ToList();
                if (pedidos.Count < 1)
                    MessageBox.Show(@"Nenhum pedido foi encontrado.");
                else
                    return pedidos;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao listar pedidos.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao listar pedidos");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new List<PedidoModel>();
        }

        public IEnumerable<ItemPedidoModel> BuscarProdutosPedido(int idPedido)
        {

            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                var produtos = _dao.BuscarProdutosDoPedido(idPedido, cmd).ToList();
                if (produtos.Count < 1)
                    MessageBox.Show(@"Nenhum produto foi encontrado nesse pedido.");
                else
                    return produtos;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao buscar itens do pedido.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao buscar itens do pedido");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }

            return new List<ItemPedidoModel>();
        }
    }
}
