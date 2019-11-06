using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Produto.Dao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace projeto2.Feature.Produto.Controller
{
    public class ProdutoController
    {
        private readonly ProdutoDao _dao;

        public ProdutoController() => _dao = new ProdutoDao();

        public IList<Produto> ListarDados(Produto filtros)
        {
            try
            {
                var produtos = _dao.Listar(filtros);
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

            return new List<Produto>();
        }

        public Produto BuscarDado(int idProduto)
        {
            try
            {
                var produto = _dao.Buscar(idProduto);
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
            return new Produto();
        }

        public bool ExcluirDado(int idProduto)
        {
            try
            {
                if (_dao.Excluir(idProduto))
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

            return false;
        }

        public bool AlterarDado(Produto produto)
        {
            try
            {
                if (_dao.Alterar(produto))
                {
                    MessageBox.Show(@"Produto alterado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao alterar produto.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao alterar produto", @"Erro");
                Console.WriteLine(ex);
            }

            return false;
        }

        public bool CadastrarDado(Produto produto)
        {
            try
            {
                if (_dao.Cadastrar(produto))
                {
                    MessageBox.Show(@"Produto cadastrado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar produto.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar produto.", @"Erro");
                Console.WriteLine(ex);
            }

            return false;
        }

        public IEnumerable<GrupoModel> ListarGrupos() => new GrupoController().ListarGrupos();

        public IEnumerable<MarcaModel> ListarMarcas() => new MarcaController().ListarMarcas();
    }
}