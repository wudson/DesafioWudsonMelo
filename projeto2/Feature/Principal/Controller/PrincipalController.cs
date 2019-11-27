using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Estoque.Controller;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Pedido.Controller;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Promocao.Controller;

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
        private readonly PromocoesController _promocoesController;

        public PrincipalController()
        {
           _produtoController = new ProdutoController();
           _clienteController = new ClienteController();
           _estoqueDeProdutoController = new EstoqueDeProdutoController();
           _marcaController = new MarcaController();
           _grupoController = new GrupoController();
           _pedidoController = new PedidoController();
           _promocoesController = new PromocoesController();
        }

        public void AbrirTelaDeProdutos() => _produtoController.AbrirTela();

        public void AbrirTelaDeClientes() => _clienteController.AbrirTela();

        public void AbrirTelaDeEstoqueDeProdutos() => _estoqueDeProdutoController.AbrirTela();

        public void AbrirTelaDeMarcas() => _marcaController.AbrirTela();

        public void AbrirTelaDeGrupos() => _grupoController.AbrirTela();

        public void AbrirTelaDePedidos() => _pedidoController.AbrirTela();

        public void AbrirTelaDePromocoes() => _promocoesController.AbrirTela();
    }
}
