using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Pedido.View.Dev;
using projeto2.Feature.Pedido.View.WinForms;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace projeto2.Feature.Pedido.Controller
{
    public class NovoPedidoController
    {
        private readonly PedidoDao _dao;
        private FrmNovoPedido _frmNovoPedido;
        private FrmNovoPedidoDev _frmNovoPedidoDev;

        public NovoPedidoController()
        {
            _dao = new PedidoDao();
            _frmNovoPedido = new FrmNovoPedido(this);
            _frmNovoPedidoDev = new FrmNovoPedidoDev(this);
        }

        public void AbrirTelaDeNovoPedido()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
            {
                (_frmNovoPedido = new FrmNovoPedido(this)).ShowDialog();
                _frmNovoPedido.Dispose();
            }
            else
            {
                (_frmNovoPedidoDev = new FrmNovoPedidoDev(this)).ShowDialog();
                _frmNovoPedidoDev.Dispose();
            }
        }

        public bool SalvarPedido(PedidoModel pedido)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();

                if (_dao.Cadastrar(pedido, cmd))
                {
                    MessageBox.Show(@"Pedido efetuado com sucesso.", @"Sucesso");
                    cmd.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao efetuar pedido.");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao efetuar pedido");
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

        public IList<Produto.Produto> ListarProdutos() =>
            new ProdutoController().ListarDados(new Produto.Produto());

        public IEnumerable<ClienteModel> ListarClientes() =>
            new ClienteController().ListarDados(new FiltrosClienteModel());

        public IEnumerable<PromocaoModel> BuscarPromocoesAtivas(FiltrosPromocaoModel filtros)
        {
            return new PromocoesController().ListarDados(filtros);
        }
    }
}
