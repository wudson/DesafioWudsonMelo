using FluentAssertions;
using Moq;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Produto.Dao;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Produto.Controller
{
    public class CadastroDeProdutoControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaCadastrarDadosCorretamente))]
        public void CadastrarDadosCorretamente(projeto2.Feature.Produto.Produto produto,
            bool retornoEsperado)
        {
            var mockProdutoDao = new Mock<ProdutoDao>();
            mockProdutoDao.Setup(m => m.Cadastrar(produto, null)).Returns(retornoEsperado);

            var produtoController = new CadastroDeProdutoController(mockProdutoDao.Object, true);

            var retorno = produtoController.CadastrarDado(produto);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaCadastrarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new projeto2.Feature.Produto.Produto
                        {
                            NomeProduto = "batata",
                            FornecedorProduto = "seu zé"
                        },
                    true
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAlterarDadosCorretamente))]
        public void AlterarDadosCorretamente(projeto2.Feature.Produto.Produto produto,
            bool retornoEsperado)
        {
            var mockProdutoDao = new Mock<ProdutoDao>();
            mockProdutoDao.Setup(m => m.Alterar(produto, null)).Returns(retornoEsperado);

            var produtoController = new CadastroDeProdutoController(mockProdutoDao.Object, true);

            var retorno = produtoController.AlterarDado(produto);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaAlterarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new projeto2.Feature.Produto.Produto
                    {
                        IdProduto = 1,
                        NomeProduto = "batata2",
                        FornecedorProduto = "seu zé"
                    },
                    true
                }
            };
    }
}
