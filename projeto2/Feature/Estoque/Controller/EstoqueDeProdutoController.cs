using projeto2.Feature.Estoque.View.Dev;
using projeto2.Feature.Estoque.View.WinForms;
using projeto2.Feature.Produto.Controller;
using System.Collections.Generic;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Model;
using projeto2.Interfaces;

namespace projeto2.Feature.Estoque.Controller
{
    public class EstoqueDeProdutoController : IFrmController
    {
        private FrmEstoque _frmEstoqueProdutos;
        private FrmEstoqueDev _frmEstoqueProdutosDev;

        private readonly GrupoController _grupoController;

        public EstoqueDeProdutoController()
        {
            _frmEstoqueProdutos = new FrmEstoque(this);
            _frmEstoqueProdutosDev = new FrmEstoqueDev(this);

            _grupoController = new GrupoController();
        }

        public void AbrirTela()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
            {
                (_frmEstoqueProdutos = new FrmEstoque(this)).ShowDialog();
                _frmEstoqueProdutos.Dispose();
            }
            else
            {
                (_frmEstoqueProdutosDev = new FrmEstoqueDev(this)).ShowDialog();
                _frmEstoqueProdutosDev.Dispose();
            }
        }

        public IList<Produto.Produto> ListarDados(Produto.Produto filtros) =>
            new ProdutoController().ListarDados(filtros);

        public IEnumerable<GrupoModel> ListarGrupos() => _grupoController.ListarGrupos();
    }
}
