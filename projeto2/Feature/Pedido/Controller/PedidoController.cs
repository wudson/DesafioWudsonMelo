using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Produto;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Pedido.Controller
{
    public class PedidoController
    {
        private readonly PedidoDao _dao;

        public PedidoController() => _dao = new PedidoDao();

        public bool SalvarPedido(PedidoModel pedido)
        {
            try
            {
                if (_dao.Cadastrar(pedido))
                {
                    MessageBox.Show(@"Pedido efetuado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show(@"Problemas ao efetuar pedido.", @"Erro");
            }

            return false;
        }

        public IEnumerable<PedidoModel> BuscarTodosOsDados()
        {
            try
            {
                return _dao.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Problemas ao listar pedidos. {ex}");
            }
            return new List<PedidoModel>();
        }

        public IEnumerable<ItemPedidoModel> BuscarProdutosPedido(int idPedido)
        {
            try
            {
                return _dao.BuscarProdutosDoPedido(idPedido);
            }
            catch
            {
                MessageBox.Show(@"Problemas ao buscar itens do pedido.");
            }
            return new List<ItemPedidoModel>();
        }

        public bool ExcluirDado(int idProduto)
        {
            throw new NotImplementedException();
        }

        public PedidoModel BuscarDado(int idPedidoLinhaAtual)
        {
            throw new NotImplementedException();
        }

        public IList<Produto.Produto> ListarProdutos(Produto.Produto produto) =>
            new ProdutoController().ListarDados(produto);
    }
}
