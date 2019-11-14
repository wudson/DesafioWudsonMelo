using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Cliente.View;

namespace projeto2.Feature.Cliente.Controller
{
    public class CadastroDeClienteController
    {
        private readonly ClienteDao _dao;
        private FrmCadastroDeCliente _frmCadastroDeCliente;

        public CadastroDeClienteController()
        {
            _dao = new ClienteDao();
        }

        public void AbrirTela()
        {
            (_frmCadastroDeCliente = new FrmCadastroDeCliente(this)).ShowDialog();
            _frmCadastroDeCliente.Dispose();
        }

        public void AbrirTelaParaAlterar(ClienteModel cliente)
        {
            (_frmCadastroDeCliente = new FrmCadastroDeCliente(this)).RecebeProdutoParaAlterar(cliente);
            _frmCadastroDeCliente.Dispose();
        }

        public bool AlterarDado(ClienteModel cliente)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();

                if (_dao.Alterar(cliente, cmd))
                {
                    MessageBox.Show(@"Cliente alterado com sucesso.", @"Sucesso");
                    cmd.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao alterar cliente.");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao alterar cliente");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return false;
        }

        public bool CadastrarDado(ClienteModel cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.NomePessoa)) return false;

            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();

                if (_dao.Cadastrar(cliente, cmd))
                {
                    MessageBox.Show(@"Cliente cadastrado com sucesso.", @"Sucesso");
                    cmd.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar cliente.");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar cliente");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return false;
        }
    }
}
