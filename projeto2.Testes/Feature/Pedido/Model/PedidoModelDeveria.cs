using FluentAssertions;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Pedido.Model
{
    public class PedidoModelDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaInstaniarCorretamente))]
        public void InstanciarCorretamente(PedidoModel modelBase)
        {
            var modelAlvo = new PedidoModel
            {
                IdPedido = modelBase.IdPedido,
                DataPedido = modelBase.DataPedido,
                PrecoTotalPedido = modelBase.PrecoTotalPedido,
                Cliente = modelBase.Cliente,
                Produtos = modelBase.Produtos
            };

            modelAlvo.Should().BeEquivalentTo(modelBase);
        }

        public static IEnumerable<object[]> CriarDadosParaInstaniarCorretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new PedidoModel
                    {
                        IdPedido = 1,
                        DataPedido = new DateTime(2019 / 11 / 25),
                        PrecoTotalPedido = 800.77,
                        Cliente = new ClienteModel(),
                        Produtos = new List<projeto2.Feature.Produto.Produto>()
                    }
                }
            };
    }
}
