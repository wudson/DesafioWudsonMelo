using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Controller;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using Xunit;

namespace projeto2.Testes.Feature.Pedido.Controller
{
    public class NovoPedidoControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaSalvarPedidoCorretamente))]
        public void SalvarPedidoCorretamente(PedidoModel pedido,
            bool retornoEsperado)
        {
            var mockPedidoDao = new Mock<PedidoDao>();
            mockPedidoDao.Setup(m => m.Cadastrar(pedido, null)).Returns(retornoEsperado);

            var pedidoController = new NovoPedidoController(mockPedidoDao.Object, true);

            var retorno = pedidoController.SalvarPedido(pedido);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaSalvarPedidoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new PedidoModel
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
