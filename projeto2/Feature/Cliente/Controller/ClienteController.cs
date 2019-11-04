using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Cliente.Controller
{
    public class ClienteController
    {
        private readonly ClienteDao _clienteDao;

        public ClienteController()
        {
            _clienteDao = new ClienteDao();
        }

        public bool AlterarDado(ClienteModel cliente)
        {
            try
            {
                if (_clienteDao.Alterar(cliente))
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
            if (string.IsNullOrWhiteSpace(cliente.NomePessoa)) return false;

            try
            {
                if (_clienteDao.Cadastrar(cliente))
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

        public ClienteModel BuscarDado(int idPessoa)
        {
            try
            {
                return _clienteDao.Buscar(idPessoa);
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar cliente.", @"Erro");
            }

            return new ClienteModel();
        }

        public bool ExcluirDado(int idPessoa)
        {
            try
            {
                if (_clienteDao.Excluir(idPessoa))
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

        public IEnumerable<ClienteModel> ListarDados(FiltrosClienteModel filtros)
        {
            try
            {
                return _clienteDao.ListarDados(filtros);
            }
            catch
            {
                MessageBox.Show(@"Problemas ao filtrar clientes");
            }
            return new List<ClienteModel>();
        }
    }
}