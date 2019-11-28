using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Cliente.View.Dev;
using projeto2.Feature.Cliente.View.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using projeto2.Interfaces;

namespace projeto2.Feature.Cliente.Controller
{
    public class ClienteController : IFrmController
    {
        private readonly ClienteDao _dao;
        private FrmClientes _frmClientes;
        private FrmClientesDev _frmClientesDev;
        private readonly bool _teste;

        private readonly CadastroDeClienteController _cadastroDeClienteController;

        public ClienteController(ClienteDao dao = null, bool teste = false)
        {
            _dao = dao ?? new ClienteDao();
            _teste = teste;

            _frmClientes = new FrmClientes(this);
            _frmClientesDev = new FrmClientesDev(this);

            _cadastroDeClienteController = new CadastroDeClienteController();
        }

        public void AbrirTela()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
            {
                (_frmClientes = new FrmClientes(this)).ShowDialog();
                _frmClientes.Dispose();
            }
            else
            {
                (_frmClientesDev = new FrmClientesDev(this)).ShowDialog();
                _frmClientesDev.Dispose();
            }
        }

        public ClienteModel BuscarDado(int idPessoa)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                if (_teste)
                    cmd = null;
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                }

                var cliente = _dao.Buscar(idPessoa, cmd);
                if (cliente.IdCliente < 1)
                    XtraMessageBox.Show(@"Cliente não encontrado.");
                else
                    return cliente;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao buscar cliente.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao buscar cliente");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd?.Dispose();
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
                if (_teste)
                    cmd = null;
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Transaction = conn.BeginTransaction();
                }

                if (_dao.Excluir(idPessoa, cmd))
                {
                    XtraMessageBox.Show(@"Cliente excluido com sucesso.", @"Sucesso");
                    cmd?.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao excluir cliente.");
                cmd?.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao excluir cliente");
                cmd?.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            finally
            {
                cmd?.Dispose();
                conn.Close();
            }

            return false;
        }

        public IEnumerable<ClienteModel> ListarDados(FiltrosClienteModel filtros)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                if (_teste)
                    cmd = null;
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                }

                var clientes = _dao.ListarDados(filtros, cmd).ToList();
                if (clientes.Count < 1)
                    XtraMessageBox.Show(@"Nenhum cliente foi encontrado.");
                else
                    return clientes;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao listar clientes.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao listar clientes");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd?.Dispose();
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