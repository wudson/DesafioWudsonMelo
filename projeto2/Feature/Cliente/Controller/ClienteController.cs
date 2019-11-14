using System;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.View;

namespace projeto2.Feature.Cliente.Controller
{
    public class ClienteController
    {
        private readonly ClienteDao _dao;
        public ClienteModel ClienteModel { get; set; }
        private readonly FrmClientes _frmClientes;

        private readonly CadastroDeClienteController _cadastroDeClienteController;

        public ClienteController()
        {
            ClienteModel = new ClienteModel();
            _dao = new ClienteDao();

            _frmClientes = new FrmClientes(this);

            _cadastroDeClienteController = new CadastroDeClienteController();
        }

        public void AbrirTelaDeClientes() =>
            _frmClientes.ShowDialog();

        public ClienteModel BuscarDado(int idPessoa)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                var cliente = _dao.Buscar(idPessoa, cmd);
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
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new ClienteModel();
        }

        public bool ExcluirDado(int idPessoa)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();

                if (_dao.Excluir(idPessoa, cmd))
                {
                    MessageBox.Show(@"Cliente excluido com sucesso.", @"Sucesso");
                    cmd.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao excluir cliente.");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao excluir cliente");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }

            return false;
        }

        public IEnumerable<ClienteModel> ListarDados(FiltrosClienteModel filtros)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                var clientes = _dao.ListarDados(filtros, cmd).ToList();
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
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new List<ClienteModel>();
        }

        public void AbrirTelaDeAlterarECadastrarClientes(ClienteModel cliente = null)
        {
            if (cliente == null)
                _cadastroDeClienteController.AbrirTela();
            else
                _cadastroDeClienteController.AbrirTelaParaAlterar(cliente);
        }
    }
}