using FirebirdSql.Data.FirebirdClient;
using FluentAssertions;
using projeto2.Feature.Produto.Dao;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Produto.Dao
{
    public class ProdutoDaoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeCadastroCorretamente))]
        public void AdicionarParametrosDeCadastroCorretamente(projeto2.Feature.Produto.Produto produto)
        {
            var dao = new ProdutoDao();
            var retorno = dao.AdicionarParametrosDeCadastroNoFbCommand(produto, new FbCommand());

            retorno.Parameters["@nome"].Value.Should().BeEquivalentTo(produto.NomeProduto);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeCadastroCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new projeto2.Feature.Produto.Produto
                    {
                        NomeProduto = "batata"
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeEdicaoCorretamente))]
        public void AdicionarParametrosDeEdicaoCorretamente(projeto2.Feature.Produto.Produto produto)
        {
            var dao = new ProdutoDao();
            var retorno = dao.AdicionarParametrosDeEdicaoNoFbCommand(produto, new FbCommand());

            retorno.Parameters["@nome"].Value.Should().BeEquivalentTo(produto.NomeProduto);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeEdicaoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new projeto2.Feature.Produto.Produto
                    {
                        NomeProduto = "batata"
                    }
                }
            };

        [Theory]
        [InlineData(1)]
        public void AdicionarParametrosDeExclusaoCorretamente(int idProduto)
        {
            var dao = new ProdutoDao();
            var retorno = dao.AdicionarParametrosDeExclusaoNoFbCommand(idProduto, new FbCommand());

            retorno.Parameters["@id"].Value.Should().BeEquivalentTo(idProduto);
        }

        [Theory]
        [InlineData(1)]
        public void AdicionarParametrosDeBuscaCorretamente(int idProduto)
        {
            var dao = new ProdutoDao();
            var retorno = dao.AdicionarParametrosDeBuscaNoFbCommand(idProduto, new FbCommand());

            retorno.Parameters["@id"].Value.Should().BeEquivalentTo(idProduto);
        }

        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeListagemCorretamente))]
        public void AdicionarParametrosDeListagemCorretamente(projeto2.Feature.Produto.Produto produto)
        {
            var dao = new ProdutoDao();
            var retorno = dao.AdicionarParametrosDeListagemNoFbCommand(produto, new FbCommand());

            retorno.Parameters["@prod"].Value.Should().BeEquivalentTo($"{produto.NomeProduto}%");
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeListagemCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new projeto2.Feature.Produto.Produto
                    {
                        NomeProduto = "batata"
                    }
                }
            };
    }
}
