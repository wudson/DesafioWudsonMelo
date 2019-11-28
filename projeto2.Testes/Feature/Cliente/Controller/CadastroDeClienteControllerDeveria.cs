using FluentAssertions;
using Moq;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Cliente.Controller
{
    public class CadastroDeClienteControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaCadastrarDadosCorretamente))]
        public void CadastrarDadosCorretamente(ClienteModel cliente,
            bool retornoEsperado)
        {
            var mockClienteDao = new Mock<ClienteDao>();
            mockClienteDao.Setup(m => m.Cadastrar(cliente, null)).Returns(retornoEsperado);

            var clienteController = new CadastroDeClienteController(mockClienteDao.Object, true);

            var retorno = clienteController.CadastrarDado(cliente);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaCadastrarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new ClienteModel
                        {
                            NomePessoa= "jão"
                        },
                    true
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAlterarDadosCorretamente))]
        public void AlterarDadosCorretamente(ClienteModel cliente,
            bool retornoEsperado)
        {
            var mockClienteDao = new Mock<ClienteDao>();
            mockClienteDao.Setup(m => m.Alterar(cliente, null)).Returns(retornoEsperado);

            var clienteController = new CadastroDeClienteController(mockClienteDao.Object, true);

            var retorno = clienteController.AlterarDado(cliente);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaAlterarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new ClienteModel
                    {
                        IdPessoa = 1,
                        IdCliente = 1,
                        NomePessoa = "jão"
                    },
                    true
                }
            };
    }
}
