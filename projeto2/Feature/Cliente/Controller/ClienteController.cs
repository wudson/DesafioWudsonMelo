using System.Data;
using projeto2.Feature.Cliente.DAO;
using projeto2.Feature.Cliente.Model;

namespace projeto2.Feature.Cliente.Controller
{
    public class ClienteController
    {
        public DataTable BuscarTodosOsDados() => new ClienteDao().Listar();

        public bool AlterarDado(ClienteModel cliente) => new ClienteDao().Alterar(cliente);

        public bool CadastrarDado(ClienteModel cliente) => new ClienteDao().Cadastrar(cliente);
    }
}