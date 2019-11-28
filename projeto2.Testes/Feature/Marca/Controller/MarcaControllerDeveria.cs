using FluentAssertions;
using Moq;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Marca.Dao;
using projeto2.Feature.Marca.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace projeto2.Testes.Feature.Marca.Controller
{
    public class MarcaControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaCadastrarDadosCorretamente))]
        public void CadastrarDadosCorretamente(MarcaModel marca,
            bool retornoEsperado)
        {
            var mockMarcaDao = new Mock<MarcaDao>();
            mockMarcaDao.Setup(m => m.Cadastrar(marca, null)).Returns(retornoEsperado);

            var marcaController = new MarcaController(mockMarcaDao.Object, true);

            var retorno = marcaController.CadastrarMarca(marca);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaCadastrarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new MarcaModel
                        {
                           Marca= "doce"
                        },
                    true
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAlterarDadosCorretamente))]
        public void AlterarDadosCorretamente(MarcaModel marca,
            bool retornoEsperado)
        {
            var mockMarcaDao = new Mock<MarcaDao>();
            mockMarcaDao.Setup(m => m.Alterar(marca, null)).Returns(retornoEsperado);

            var marcaController = new MarcaController(mockMarcaDao.Object, true);

            var retorno = marcaController.AlterarMarca(marca);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaAlterarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new MarcaModel
                    {
                        IdMarca = 1,
                        Marca = "doce"
                    },
                    true
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaListarDadosCorretamente))]
        public void ListarDadosCorretamente(IEnumerable<MarcaModel> lista)
        {
            var mockMarcaDao = new Mock<MarcaDao>();
            var listaEsperada = lista.ToList();
            mockMarcaDao.Setup(m => m.Listar(null)).Returns(listaEsperada);

            var marcaController = new MarcaController(mockMarcaDao.Object, true);

            var listaRetornada = marcaController.ListarMarcas();

            listaRetornada.Should()
                .BeEquivalentTo(listaEsperada);
        }

        public static IEnumerable<object[]> CriarDadosParaListarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new List<MarcaModel>
                    {
                        new MarcaModel
                        {
                            Marca = "doce"
                        }
                    }
                }
            };

        [Theory]
        [InlineData(1, true)]
        public void ExcluirDadoCorretamente(int idMarca, bool retornoEsperado)
        {
            var mockMarcaDao = new Mock<MarcaDao>();
            mockMarcaDao.Setup(m => m.Excluir(idMarca, null)).Returns(retornoEsperado);

            var marcaController = new MarcaController(mockMarcaDao.Object, true);

            var retorno = marcaController.ExcluirMarca(idMarca);

            retorno.Should()
                .Be(retornoEsperado);
        }
    }
}
