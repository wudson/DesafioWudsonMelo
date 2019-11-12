using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;

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
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao efetuar pedido.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao efetuar pedido");
                Console.WriteLine(ex);
            }

            return false;
        }

        public IEnumerable<PedidoModel> BuscarTodosOsDados()
        {
            try
            {
                var pedidos = _dao.Listar().ToList();
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

            return new List<PedidoModel>();
        }

        public IEnumerable<ItemPedidoModel> BuscarProdutosPedido(int idPedido)
        {
            try
            {
                var produtos = _dao.BuscarProdutosDoPedido(idPedido).ToList();
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

        public IList<Produto.Produto> ListarProdutos() =>
            new ProdutoController().ListarDados(new Produto.Produto());

        public IEnumerable<ClienteModel> ListarClientes() => 
            new ClienteController().ListarDados(new FiltrosClienteModel());

        public IEnumerable<PromocaoModel> BuscarPromocoes()
        {
            return new PromocoesController().ListarDados();
        }
    }
}
