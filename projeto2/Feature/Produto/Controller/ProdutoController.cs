using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Produto.Dao;

namespace projeto2.Feature.Produto.Controller
{
    public class ProdutoController
    {
        public IList<object> BuscarTodosOsDados() => new ProdutoDao().Listar();

        public Produto BuscarDado(int idProduto) => (Produto) new ProdutoDao().Buscar(idProduto);

        public bool ExcluirDado(int idProduto)
        {
            try
            {
                if (new ProdutoDao().Excluir(idProduto))
                {
                    MessageBox.Show(@"Produto excluido com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Problemas ao excluir produto: {e.Message}", @"Erro");
            }

            return false;
        }

        public bool AlterarDado(Produto produto)
        {
            try
            {
                if (new ProdutoDao().Alterar(produto))
                {
                    MessageBox.Show(@"Produto alterado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Problemas ao alterar produto: {e.Message}", @"Erro");
            }

            return false;
        }

        public bool CadastrarDado(Produto produto)
        {
            try
            {
                if (new ProdutoDao().Cadastrar(produto))
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

        public bool Cadastrar(Produto produto) => CadastrarDado(produto);

        public bool Alterar(Produto produto) => AlterarDado(produto);
    }
}