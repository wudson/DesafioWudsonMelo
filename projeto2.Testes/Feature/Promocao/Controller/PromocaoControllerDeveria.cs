using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;
using Xunit;

namespace projeto2.Testes.Feature.Promocao.Controller
{
    public class PromocaoControllerDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaListarDadosCorretamente))]
        public void ListarDadosCorretamente(IEnumerable<PromocaoModel> lista, FiltrosPromocaoModel filtro)
        {
            var mockPromocaoDao = new Mock<PromocaoDao>();
            var listaEsperada = lista.ToList();
            mockPromocaoDao.Setup(m => m.Listar(null, filtro)).Returns(listaEsperada);

            var promocaoController = new PromocoesController(mockPromocaoDao.Object, true);

            var listaRetornada = promocaoController.ListarDados(filtro);

            listaRetornada.Should()
                .BeEquivalentTo(listaEsperada);
        }

        public static IEnumerable<object[]> CriarDadosParaListarDadosCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new List<PromocaoModel>
                    {
                        new PromocaoModel
                        {
                            NomePromocao = "promocao"
                        }
                    },
                    new FiltrosPromocaoModel()
                }
            };
    }
}
