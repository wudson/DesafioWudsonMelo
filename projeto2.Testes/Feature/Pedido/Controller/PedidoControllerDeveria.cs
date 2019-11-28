using FluentAssertions;
using Moq;
using projeto2.Feature.Pedido.Controller;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace projeto2.Testes.Feature.Pedido.Controller
{
    public class PedidoControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaListarDadosPedidoCorretamente))]
        public void ListarDadosPedidoCorretamente(IEnumerable<PedidoModel> lista)
        {
            var mockPedidoDao = new Mock<PedidoDao>();
            var listaEsperada = lista.ToList();
            mockPedidoDao.Setup(m => m.Listar(null)).Returns(listaEsperada);

            var pedidoController = new PedidoController(mockPedidoDao.Object, true);

            var listaRetornada = pedidoController.BuscarTodosOsDados();

            listaRetornada.Should()
                .BeEquivalentTo(listaEsperada);
        }

        public static IEnumerable<object[]> CriarDadosParaListarDadosPedidoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new List<PedidoModel>
                    {
                        new PedidoModel
                        {
                            DataPedido = new DateTime()
                        }
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaListarProdutosPedidoCorretamente))]
        public void ListarProdutosPedidoCorretamente(int idPedido, IEnumerable<ItemPedidoModel> lista)
        {
            var mockPedidoDao = new Mock<PedidoDao>();
            var listaEsperada = lista.ToList();
            mockPedidoDao.Setup(m => m.BuscarProdutosDoPedido(idPedido, null)).Returns(listaEsperada);

            var pedidoController = new PedidoController(mockPedidoDao.Object, true);

            var listaRetornada = pedidoController.BuscarProdutosPedido(idPedido);

            listaRetornada.Should()
                .BeEquivalentTo(listaEsperada);
        }

        public static IEnumerable<object[]> CriarDadosParaListarProdutosPedidoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    1,
                    new List<ItemPedidoModel>
                    {
                        new ItemPedidoModel
                        {
                            Quantidade = 10
                        }
                    }
                }
            };
    }
}
