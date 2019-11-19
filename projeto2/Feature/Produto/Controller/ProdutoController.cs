using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Produto.Dao;
using projeto2.Feature.Produto.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Estoque.Controller;
using projeto2.Feature.Produto.View.WinForms;

namespace projeto2.Feature.Produto.Controller
{
    public class ProdutoController
    {
        public Produto ProdutoModel { get; set; }
        private readonly FrmProdutos _frmProdutos;
        private readonly ProdutoDao _dao;

        private readonly CadastroDeProdutoController _cadastroDeProdutoController;
        private readonly EstoqueDeProdutoController _estoqueDeProdutoController;

        public ProdutoController()
        { 
            ProdutoModel = new Produto();
            _dao = new ProdutoDao();

            _frmProdutos = new FrmProdutos(this);

            _cadastroDeProdutoController = new CadastroDeProdutoController();
            _estoqueDeProdutoController = new EstoqueDeProdutoController();
        }

        public void AbrirTelaDeProdutos() =>
            _frmProdutos.ShowDialog();

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
                    MessageBox.Show(@"Nenhum produto foi encontrado.");
                else
                    return produtos;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao filtrar produtos.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao filtrar produtos.");
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
                    MessageBox.Show(@"Produto não encontrado.");
                else
                    return produto;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao buscar produto.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao buscar produto");
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
                    MessageBox.Show(@"Produto excluido com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao excluir produtos.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao excluir produto.", @"Erro");
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