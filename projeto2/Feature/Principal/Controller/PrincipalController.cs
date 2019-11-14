using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Estoque.Controller;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Pedido.Controller;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Principal.Controller
{
    public class PrincipalController
    {
        private readonly ProdutoController _produtoController;
        private readonly ClienteController _clienteController;
        private readonly EstoqueDeProdutoController _estoqueDeProdutoController;
        private readonly MarcaController _marcaController;
        private readonly GrupoController _grupoController;
        private readonly PedidoController _pedidoController;

        public PrincipalController()
        {
           _produtoController = new ProdutoController();
           _clienteController = new ClienteController();
           _estoqueDeProdutoController = new EstoqueDeProdutoController();
           _marcaController = new MarcaController();
           _grupoController = new GrupoController();
           _pedidoController = new PedidoController();
        }

        public void AbrirTelaDeProdutos() => _produtoController.AbrirTelaDeProdutos();

        public void AbrirTelaDeClientes() => _clienteController.AbrirTelaDeClientes();

        public void AbrirTelaDeEstoqueDeProdutos() => _estoqueDeProdutoController.AbrirTelaDeEstoque();

        public void AbrirTelaDeMarcas() => _marcaController.AbrirTelaDeMarcas();

        public void AbrirTelaDeGrupos() => _grupoController.AbrirTelaDeGrupos();

        public void AbrirTelaDePedidos() => _pedidoController.AbrirTelaDePedidos();
    }
}
