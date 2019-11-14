using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Estoque.Controller;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Principal.Controller
{
    public class PrincipalController
    {
        public void AbrirTelaDeProdutos()
        {
            new ProdutoController().AbrirTelaDeProdutos();
        }

        public void AbrirTelaDeClientes()
        {
            new ClienteController().AbrirTelaDeClientes();
        }

        public void AbrirTelaDeEstoqueDeProdutos()
        {
            new EstoqueDeProdutoController().AbrirTelaDeEstoque();
        }
    }
}
