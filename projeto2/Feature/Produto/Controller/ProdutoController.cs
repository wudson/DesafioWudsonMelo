using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Produto.Dao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                return _dao.Listar(filtros);
            }
            catch
            {
                MessageBox.Show(@"Problemas ao filtrar produtos");
            }
            return new List<Produto>();
        }

        public Produto BuscarDado(int idProduto) => new ProdutoDao().Buscar(idProduto);

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
            catch
            {
                MessageBox.Show($@"Problemas ao excluir produto.", @"Erro");
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
            catch
            {
                MessageBox.Show($@"Problemas ao alterar produto", @"Erro");
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
            catch (Exception e)
            {
                MessageBox.Show($@"Problemas ao cadastrar produto: {e.Message}", @"Erro");
            }

            return false;
        }

        public IEnumerable<GrupoModel> ListarGrupos() => new GrupoController().ListarGrupos();

        public IEnumerable<MarcaModel> ListarMarcas() => new MarcaController().ListarMarcas();
    }
}