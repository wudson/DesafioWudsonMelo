using System.Data;

namespace projeto2.Feature.Interfaces
{
    public interface ICrudDao
    {
        bool Cadastrar(Produto.Produto produto);
        Produto.Produto Buscar(int idProduto);
        bool Excluir(int idProduto);
        DataTable Listar();
        bool Alterar(Produto.Produto produto);
    }
}