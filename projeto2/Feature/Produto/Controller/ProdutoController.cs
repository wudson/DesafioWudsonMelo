using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Estoque.Controller;
using projeto2.Feature.Produto.Dao;
using projeto2.Feature.Produto.View.Dev;
using projeto2.Feature.Produto.View.WinForms;
using System;
using System.Collections.Generic;

namespace projeto2.Feature.Produto.Controller
{
    public class ProdutoController
    {
        private readonly FrmProdutos _frmProdutos;
        private readonly FrmProdutosDev _frmProdutosDev;
        private readonly ProdutoDao _dao;

        private readonly CadastroDeProdutoController _cadastroDeProdutoController;
        private readonly EstoqueDeProdutoController _estoqueDeProdutoController;

        public ProdutoController()
        { 
            _dao = new ProdutoDao();

            _frmProdutos = new FrmProdutos(this);
            _frmProdutosDev = new FrmProdutosDev(this);

            _cadastroDeProdutoController = new CadastroDeProdutoController();
            _estoqueDeProdutoController = new EstoqueDeProdutoController();
        }

        public void AbrirTelaDeProdutos()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
                _frmProdutos.ShowDialog();
            else
                _frmProdutosDev.ShowDialog();
        }

        public void AbrirTelaDeEstoqueDeProdutos() => _estoqueDeProdutoController.AbrirTelaDeEstoque();

        public IList<Produto> ListarDados(Produto filtros)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                var produtos = _dao.Listar(filtros, cmd);
                if (produtos.Count < 1)
                    XtraMessageBox.Show(@"Nenhum produto foi encontrado.");
                else
                    return produtos;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao filtrar produtos.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao filtrar produtos.");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new List<Produto>();
        }

        public Produto BuscarDado(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                var produto = _dao.Buscar(idProduto, cmd);
                if (produto.IdProduto < 1)
                    XtraMessageBox.Show(@"Produto não encontrado.");
                else
                    return produto;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao buscar produto.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao buscar produto");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return new Produto();
        }

        public bool ExcluirDado(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                if (_dao.Excluir(idProduto, cmd))
                {
                    XtraMessageBox.Show(@"Produto excluido com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao excluir produtos.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao excluir produto.", @"Erro");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return false;
        }

        public void AbrirTelaDeAlterarECadastrarProdutos(Produto produto = null)
        {
            if (produto == null)
                _cadastroDeProdutoController.AbrirTela();
            else
                _cadastroDeProdutoController.AbrirTelaParaAlterar(produto);
        }
    }
}