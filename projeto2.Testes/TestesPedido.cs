using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Produto;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace projeto2.Testes
{
    public class TestesPedido
    {
        [Fact]
        public void TesteModelPedido()
        {
            var pedido = new PedidoModel
            {
                IdPedido = 1,
                DataPedido = new DateTime(2019 / 11 / 25),
                PrecoTotalPedido = 800.77,
                Cliente = new ClienteModel(),
                Produtos = new List<Produto>()
            };

            Assert.NotNull(pedido.IdPedido.ToString());
            Assert.NotNull(pedido.DataPedido.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(pedido.PrecoTotalPedido.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(pedido.Cliente);
            Assert.NotNull(pedido.Produtos);
        }

        [Fact]
        public void TesteModelItensPedido()
        {
            var itemPedido = new ItemPedidoModel
            {
                IdItemPedido = 1,
                Quantidade = 50,
                Pedido = new PedidoModel(),
                ProdutosPedido = new Produto
                {
                    ValorComDesconto = 2
                }
            };

            Assert.NotNull(itemPedido.IdItemPedido.ToString());
            Assert.NotNull(itemPedido.Quantidade.ToString());
            Assert.NotNull(itemPedido.Pedido);
            Assert.NotNull(itemPedido.ProdutosPedido.ValorComDesconto.ToString(CultureInfo.InvariantCulture));

            Assert.Equal(100, itemPedido.PrecoTotal);
        }
    }
}
