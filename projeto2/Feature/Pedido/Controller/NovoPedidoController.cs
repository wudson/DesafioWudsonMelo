using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Pedido.View;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Pedido.Controller
{
    public class NovoPedidoController
    {
        private readonly PedidoDao _dao;
        private readonly FrmNovoPedido _frmNovoPedido;

        public NovoPedidoController()
        {
            _dao = new PedidoDao();
            _frmNovoPedido = new FrmNovoPedido(this);
        }

        public void AbrirTelaDeNovoPedido() => _frmNovoPedido.ShowDialog();

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

        public IList<Produto.Produto> ListarProdutos() =>
            new ProdutoController().ListarDados(new Produto.Produto());

        public IEnumerable<ClienteModel> ListarClientes() =>
            new ClienteController().ListarDados(new FiltrosClienteModel());

        public IEnumerable<PromocaoModel> BuscarPromocoesAtivas(FiltrosPromocaoModel filtros)
        {
            return new PromocoesController().ListarDados(filtros);
        }
    }
}
