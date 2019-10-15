using System.Data;
using projeto2.Feature.Produto.DAO;

namespace projeto2.Feature.Produto.Controller
{
    public class ProdutoController
    {
        public DataTable BuscarTodosOsDados() => new ProdutoDao().Listar();

        public Produto BuscarDado(int idProduto) => new ProdutoDao().Buscar(idProduto);

        public bool ExcluirDado(int idProduto) => new ProdutoDao().Excluir(idProduto);

        public bool AlterarDado(Produto produto) => new ProdutoDao().Alterar(produto);

        public bool CadastrarDado(Produto produto) => new ProdutoDao().Cadastrar(produto);
    }
}