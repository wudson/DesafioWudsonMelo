using FluentAssertions;
using Moq;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace projeto2.Testes.Feature.Cliente.Controller
{
    public class ClienteControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaListarDadosCorretamente))]
        public void ListarDadosCorretamente(FiltrosClienteModel filtro,
            IEnumerable<ClienteModel> lista)
        {
            var mockClienteDao = new Mock<ClienteDao>();
            var listaEsperada = lista.ToList();
            mockClienteDao.Setup(m => m.ListarDados(filtro, null)).Returns(listaEsperada);

            var clienteController = new ClienteController(mockClienteDao.Object, true);

            var listaRetornada = clienteController.ListarDados(filtro);

            listaRetornada.Should()
                .BeEquivalentTo(listaEsperada);
        }

        public static IEnumerable<object[]> CriarDadosParaListarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new FiltrosClienteModel(), 
                    new List<ClienteModel>
                    {
                        new ClienteModel
                        {
                            NomePessoa = "jão"
                        }
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaBuscarDadoCorretamente))]
        public void BuscarDadoCorretamente(int idProduto, ClienteModel clienteEsperado)
        {
            var mockClienteDao = new Mock<ClienteDao>();
            mockClienteDao.Setup(m => m.Buscar(idProduto, null)).Returns(clienteEsperado);

            var clienteController = new ClienteController(mockClienteDao.Object, true);

            var clienteRetornado = clienteController.BuscarDado(idProduto);

            clienteRetornado.Should()
                .BeEquivalentTo(clienteEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaBuscarDadoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    1,
                    new ClienteModel()
                        {
                            IdCliente = 1,
                            IdPessoa = 1,
                            NomePessoa = "jão"
                        }
                }
            };

        [Theory]
        [InlineData(1, true)]
        public void ExcluirDadoCorretamente(int idPessoa, bool retornoEsperado)
        {
            var mockClienteDao = new Mock<ClienteDao>();
            mockClienteDao.Setup(m => m.Excluir(idPessoa, null)).Returns(retornoEsperado);

            var clienteController = new ClienteController(mockClienteDao.Object, true);

            var retorno = clienteController.ExcluirDado(idPessoa);

            retorno.Should()
                .Be(retornoEsperado);
        }
    }
}
