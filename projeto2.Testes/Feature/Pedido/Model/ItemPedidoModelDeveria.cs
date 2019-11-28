using FluentAssertions;
using projeto2.Feature.Pedido.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Pedido.Model
{
    public class ItemPedidoModelDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaInstaniarCorretamente))]
        public void TesteModelItensPedido(ItemPedidoModel modelBase)
        {
            var modelAlvo = new ItemPedidoModel
            {
                IdItemPedido = modelBase.IdItemPedido,
                Quantidade = modelBase.Quantidade,
                Pedido = modelBase.Pedido,
                ProdutosPedido = modelBase.ProdutosPedido
            };

            modelAlvo.Should().BeEquivalentTo(modelBase);
        }

        public static IEnumerable<object[]> CriarDadosParaInstaniarCorretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new ItemPedidoModel
                    {
                        IdItemPedido = 1,
                        Quantidade = 50,
                        Pedido = new PedidoModel(),
                        ProdutosPedido = new projeto2.Feature.Produto.Produto
                        {
                            ValorComDesconto = 2
                        }
                    }
                }
            };
    }
}
