using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;

namespace projeto2.Feature.Cliente.Controller
{
    public class ClienteController
    {
        public IList<ClienteModel> BuscarTodosOsDados() => new ClienteDao().Listar();


        public bool AlterarDado(ClienteModel cliente)
        {
            try
            {
                if (new ClienteDao().Alterar(cliente))
                {
                    MessageBox.Show(@"Cliente alterado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show(@"Problemas ao alterar cliente.", @"Erro");
            }
            return false;
        }

        public bool CadastrarDado(ClienteModel cliente)
        {
            try
            {
                if (new ClienteDao().Cadastrar(cliente))
                {
                    MessageBox.Show(@"Cliente cadastrado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar cliente.", @"Erro");
            }

            return false;
        }

        public ClienteModel BuscarDado(int idPessoa) => new ClienteDao().Buscar(idPessoa);

        public bool ExcluirDado(int idPessoa)
        {
            try
            {
                if (new ClienteDao().Excluir(idPessoa))
                {
                    MessageBox.Show(@"Cliente excluido com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar cliente.", @"Erro");
            }

            return false;
        }

        public IEnumerable<ClienteModel> BuscarDadosComFiltros(FiltrosClienteModel filtros)
        {
            try
            {
                var clientesFiltrados = new ClienteDao().BuscarComFiltros(filtros);
                return clientesFiltrados;
            }
            catch
            {
                MessageBox.Show(@"Problemas ao filtrar clientes");
            }
            return new List<ClienteModel>();
        }
    }
}