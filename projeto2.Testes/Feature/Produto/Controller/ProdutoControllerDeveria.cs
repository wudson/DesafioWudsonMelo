using FluentAssertions;
using Moq;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Produto.Dao;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Produto.Controller
{
    public class ProdutoControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaListarDadosCorretamente))]
        public void ListarDadosCorretamente(projeto2.Feature.Produto.Produto filtro,
            IList<projeto2.Feature.Produto.Produto> listaEsperada)
        {
            var mockProdutoDao = new Mock<ProdutoDao>();
            mockProdutoDao.Setup(m => m.Listar(filtro, null)).Returns(listaEsperada);

            var produtoController = new ProdutoController(mockProdutoDao.Object, true);

            var listaRetornada = produtoController.ListarDados(filtro);

            listaRetornada.Should()
                .BeEquivalentTo(listaEsperada);
        }

        public static IEnumerable<object[]> CriarDadosParaListarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new projeto2.Feature.Produto.Produto(),
                    new List<projeto2.Feature.Produto.Produto>
                    {
                        new projeto2.Feature.Produto.Produto
                        {
                            NomeProduto = "batata"
                        }
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaBuscarDadoCorretamente))]
        public void BuscarDadoCorretamente(int idProduto, projeto2.Feature.Produto.Produto produtoEsperado)
        {
            var mockProdutoDao = new Mock<ProdutoDao>();
            mockProdutoDao.Setup(m => m.Buscar(idProduto, null)).Returns(produtoEsperado);

            var produtoController = new ProdutoController(mockProdutoDao.Object, true);

            var produtoRetornado = produtoController.BuscarDado(idProduto);

            produtoRetornado.Should()
                .BeEquivalentTo(produtoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaBuscarDadoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    1,
                    new projeto2.Feature.Produto.Produto
                        {
                            IdProduto = 1,
                            NomeProduto = "batata"
                        }
                }
            };

        [Theory]
        [InlineData(1, true)]
        public void ExcluirDadoCorretamente(int idProduto, bool retornoEsperado)
        {
            var mockProdutoDao = new Mock<ProdutoDao>();
            mockProdutoDao.Setup(m => m.Excluir(idProduto, null)).Returns(retornoEsperado);

            var produtoController = new ProdutoController(mockProdutoDao.Object, true);

            var retorno = produtoController.ExcluirDado(idProduto);

            retorno.Should()
                .Be(retornoEsperado);
        }
    }
}
