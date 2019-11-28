using FluentAssertions;
using Moq;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Promocao.Controller
{
    public class CadastroDePromocaoControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaCadastrarDadoCorretamente))]
        public void CadastrarDadoCorretamente(PromocaoModel promocao,
            bool retornoEsperado)
        {
            var mockPromocaoDao = new Mock<PromocaoDao>();
            mockPromocaoDao.Setup(m => m.Cadastrar(promocao, null)).Returns(retornoEsperado);

            var promocaoController = new CadastroDePromocaoController(mockPromocaoDao.Object, true);

            var retorno = promocaoController.CadastrarDado(promocao);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaCadastrarDadoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new PromocaoModel
                    {
                        Produtos = new List<projeto2.Feature.Produto.Produto>
                        {
                            new projeto2.Feature.Produto.Produto
                            {
                                NomeProduto = "pão"
                            }
                        }
                    },
                    true
                }
            };
    }
}
