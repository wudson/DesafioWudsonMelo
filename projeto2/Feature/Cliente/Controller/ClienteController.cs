using System;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

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
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao alterar cliente.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao alterar cliente");
                Console.WriteLine(ex);
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
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar cliente.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar cliente");
                Console.WriteLine(ex);
            }

            return false;
        }

        public ClienteModel BuscarDado(int idPessoa)
        {
            try
            {
                var cliente = _clienteDao.Buscar(idPessoa);
                if (cliente.IdCliente < 1)
                    MessageBox.Show(@"Cliente não encontrado.");
                else
                    return cliente;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao buscar cliente.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao buscar cliente");
                Console.WriteLine(ex);
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
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao excluir cliente.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao excluir cliente");
                Console.WriteLine(ex);
            }

            return false;
        }

        public IEnumerable<ClienteModel> ListarDados(FiltrosClienteModel filtros)
        {
            try
            {
                var clientes = _clienteDao.ListarDados(filtros).ToList();
                if (clientes.Count < 1)
                    MessageBox.Show(@"Nenhum cliente foi encontrado.");
                else
                    return clientes;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao listar clientes.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao listar clientes");
                Console.WriteLine(ex);
            }

            return new List<ClienteModel>();
        }
    }
}