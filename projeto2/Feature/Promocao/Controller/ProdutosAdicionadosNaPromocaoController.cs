using System.Collections.Generic;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Promocao.Model;
using projeto2.Feature.Promocao.View;
using projeto2.Feature.Promocao.View.Dev;
using projeto2.Feature.Promocao.View.WinForms;

namespace projeto2.Feature.Promocao.Controller
{
    public class ProdutosAdicionadosNaPromocaoController
    {
        private readonly MarcaController _marcaController;
        private readonly GrupoController _grupoController;
        private readonly ProdutoController _produtoController;

        public ProdutosAdicionadosNaPromocaoController()
        {
            _marcaController = new MarcaController();
            _grupoController = new GrupoController();
            _produtoController = new ProdutoController();
        }

        public IList<PromocaoModel> RetornarProdutos(List<Produto.Produto> produtos) =>
            !ClasseComVariaveisGlobais.UsarDev
                ? new FrmProdutosDaPromocaoComDesconto(this).RetornarProdutos(produtos)
                : new FrmSelecionarProdutosParaPromocao(this).RetornarProdutos(produtos);

        public IEnumerable<MarcaModel> ListarMarcas() => _marcaController.ListarMarcas();

        public IEnumerable<GrupoModel> ListarGrupos() => _grupoController.ListarGrupos();

        public IList<Produto.Produto> ListarProdutos(Produto.Produto produto) =>
            _produtoController.ListarDados(produto);
    }
}
