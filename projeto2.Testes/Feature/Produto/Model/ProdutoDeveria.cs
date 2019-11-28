using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Produto.Model
{
    public class ProdutoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaInstaniarCorretamente))]
        public void InstanciarCorretamente(projeto2.Feature.Produto.Produto modelBase)
        {
            var modelAlvo = new projeto2.Feature.Produto.Produto
            {
                IdProduto = modelBase.IdProduto,
                NomeProduto = modelBase.NomeProduto,
                CodigoDeBarras = modelBase.CodigoDeBarras,
                GrupoProduto = modelBase.GrupoProduto,
                MarcaProduto = modelBase.MarcaProduto,
                QuantidadeEstoqueProduto = modelBase.QuantidadeEstoqueProduto,
                ValorCompraProduto = modelBase.ValorCompraProduto,
                ValorVendaProduto = modelBase.ValorVendaProduto,
                ValorComDesconto = modelBase.ValorComDesconto,
                QuantidadeProdutoPedido = modelBase.QuantidadeProdutoPedido,
                FornecedorProduto = modelBase.FornecedorProduto,
                TipoProduto = modelBase.TipoProduto
            };

            modelAlvo.Should().BeEquivalentTo(modelBase);
        }

        public static IEnumerable<object[]> CriarDadosParaInstaniarCorretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new projeto2.Feature.Produto.Produto
                    {
                        IdProduto = 1,
                        NomeProduto = "produto",
                        CodigoDeBarras = "123456789",
                        GrupoProduto =
                        {
                            Grupo = "grupo",
                            IdGrupo = 1
                        },
                        MarcaProduto =
                        {
                            Marca = "marca",
                            IdMarca = 1
                        },
                        QuantidadeEstoqueProduto = 100,
                        ValorCompraProduto = 5.33,
                        ValorVendaProduto = 12.00,
                        ValorComDesconto = 8.55,
                        QuantidadeProdutoPedido = 5,
                        FornecedorProduto = "fornecedor",
                        TipoProduto = "caixa"
                    }
                }
            };
    }
}
