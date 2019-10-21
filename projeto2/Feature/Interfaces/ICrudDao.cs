using System.Collections.Generic;

namespace projeto2.Feature.Interfaces
{
    public interface ICrudDao
    {
        bool Cadastrar(object obj);
        object Buscar(int id);
        bool Excluir(int id);
        IList<object> Listar();
        bool Alterar(object obj);
    }
}