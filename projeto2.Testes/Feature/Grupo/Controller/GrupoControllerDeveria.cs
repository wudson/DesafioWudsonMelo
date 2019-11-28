using FluentAssertions;
using Moq;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Dao;
using projeto2.Feature.Grupo.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace projeto2.Testes.Feature.Grupo.Controller
{
    public class GrupoControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaCadastrarDadosCorretamente))]
        public void CadastrarDadosCorretamente(GrupoModel grupo,
            bool retornoEsperado)
        {
            var mockGrupoDao = new Mock<GrupoDao>();
            mockGrupoDao.Setup(m => m.Cadastrar(grupo, null)).Returns(retornoEsperado);

            var grupoController = new GrupoController(mockGrupoDao.Object, true);

            var retorno = grupoController.CadastrarGrupo(grupo);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaCadastrarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new GrupoModel
                        {
                           Grupo= "doce"
                        },
                    true
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAlterarDadosCorretamente))]
        public void AlterarDadosCorretamente(GrupoModel grupo,
            bool retornoEsperado)
        {
            var mockGrupoDao = new Mock<GrupoDao>();
            mockGrupoDao.Setup(m => m.Alterar(grupo, null)).Returns(retornoEsperado);

            var grupoController = new GrupoController(mockGrupoDao.Object, true);

            var retorno = grupoController.AlterarGrupo(grupo);

            retorno.Should()
                .Be(retornoEsperado);
        }

        public static IEnumerable<object[]> CriarDadosParaAlterarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new GrupoModel
                    {
                        IdGrupo = 1,
                        Grupo = "doce"
                    },
                    true
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaListarDadosCorretamente))]
        public void ListarDadosCorretamente(IEnumerable<GrupoModel> lista)
        {
            var mockGrupoDao = new Mock<GrupoDao>();
            var listaEsperada = lista.ToList();
            mockGrupoDao.Setup(m => m.Listar(null)).Returns(listaEsperada);

            var grupoController = new GrupoController(mockGrupoDao.Object, true);

            var listaRetornada = grupoController.ListarGrupos();

            listaRetornada.Should()
                .BeEquivalentTo(listaEsperada);
        }

        public static IEnumerable<object[]> CriarDadosParaListarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new List<GrupoModel>
                    {
                        new GrupoModel
                        {
                            Grupo = "doce"
                        }
                    }
                }
            };

        [Theory]
        [InlineData(1, true)]
        public void ExcluirDadoCorretamente(int idGrupo, bool retornoEsperado)
        {
            var mockGrupoDao = new Mock<GrupoDao>();
            mockGrupoDao.Setup(m => m.Excluir(idGrupo, null)).Returns(retornoEsperado);

            var grupoController = new GrupoController(mockGrupoDao.Object, true);

            var retorno = grupoController.ExcluirGrupo(idGrupo);

            retorno.Should()
                .Be(retornoEsperado);
        }
    }
}
