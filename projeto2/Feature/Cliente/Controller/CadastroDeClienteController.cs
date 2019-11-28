using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Cliente.View.Dev;
using projeto2.Feature.Cliente.View.WinForms;
using projeto2.Interfaces;
using System;

namespace projeto2.Feature.Cliente.Controller
{
    public class CadastroDeClienteController : IFrmController
    {
        private readonly ClienteDao _dao;
        private FrmCadastroDeCliente _frmCadastroDeCliente;
        private FrmCadastroDeClienteDev _frmCadastroDeClienteDev;
        private readonly bool _teste;

        public CadastroDeClienteController(ClienteDao dao = null, bool teste = false)
        {
            _dao = dao ?? new ClienteDao();
            _teste = teste;
        }

        public void AbrirTela()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
            {
                (_frmCadastroDeCliente = new FrmCadastroDeCliente(this)).ShowDialog();
                _frmCadastroDeCliente.Dispose();
            }
            else
            {
                (_frmCadastroDeClienteDev = new FrmCadastroDeClienteDev(this)).ShowDialog();
                _frmCadastroDeClienteDev.Dispose();
            }
        }

        public void AbrirTelaParaAlterar(ClienteModel cliente)
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
            {
                (_frmCadastroDeCliente = new FrmCadastroDeCliente(this)).RecebeClienteParaAlterar(cliente);
                _frmCadastroDeCliente.Dispose();
            }
            else
            {
                (_frmCadastroDeClienteDev = new FrmCadastroDeClienteDev(this)).RecebeClienteParaAlterar(cliente);
                _frmCadastroDeClienteDev.Dispose();
            }
        }

        public bool AlterarDado(ClienteModel cliente)
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

                if (_dao.Alterar(cliente, cmd))
                {
                    XtraMessageBox.Show(@"Cliente alterado com sucesso.", @"Sucesso");
                    cmd?.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao alterar cliente.");
                cmd?.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao alterar cliente");
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

        public bool CadastrarDado(ClienteModel cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.NomePessoa)) return false;

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

                if (_dao.Cadastrar(cliente, cmd))
                {
                    XtraMessageBox.Show(@"Cliente cadastrado com sucesso.", @"Sucesso");
                    cmd?.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao cadastrar cliente.");
                cmd?.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao cadastrar cliente");
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
    }
}
