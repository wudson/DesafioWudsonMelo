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
            try
            {
                if (_dao.Alterar(cliente))
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
                if (_dao.Cadastrar(cliente))
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
    }
}
