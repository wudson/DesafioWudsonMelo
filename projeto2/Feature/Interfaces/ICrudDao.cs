using System.Data;

namespace projeto2.Feature.Interfaces
{
    public interface ICrudDao
    {
        bool Cadastrar(object obj);
        object Buscar(int id);
        bool Excluir(int id);
        DataTable Listar();
        bool Alterar(object obj);
    }
}