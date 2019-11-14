using System.Collections.Generic;
using projeto2.Feature.Estoque.View;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Estoque.Controller
{
    public class EstoqueDeProdutoController
    {
        private readonly FrmEstoque _frmEstoqueProdutos;

        public EstoqueDeProdutoController() => _frmEstoqueProdutos = new FrmEstoque(this);

        public void AbrirTelaDeEstoque() =>
            _frmEstoqueProdutos.ShowDialog();

        public IList<Produto.Produto> ListarDados(Produto.Produto filtros) =>
            new ProdutoController().ListarDados(filtros);
    }
}
