using System.Collections.Generic;
using projeto2.Feature.Estoque.View;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Estoque.Controller
{
    public class EstoqueDeProdutoController
    {
        private FrmEstoque _frmEstoqueProdutos;

        public EstoqueDeProdutoController() => _frmEstoqueProdutos = new FrmEstoque(this);

        public void AbrirTelaDeEstoque()
        {
            (_frmEstoqueProdutos = new FrmEstoque(this)).ShowDialog();
            _frmEstoqueProdutos.Dispose();
        }

        public IList<Produto.Produto> ListarDados(Produto.Produto filtros) =>
            new ProdutoController().ListarDados(filtros);
    }
}
