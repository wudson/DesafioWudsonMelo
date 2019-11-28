using FluentAssertions;
using projeto2.Feature.Cliente.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Cliente.Model
{
    public class FiltrosClienteModelDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaInstaniarCorretamente))]
        public void InstanciarCorretamente(FiltrosClienteModel modelBase)
        {
            var modelAlvo = new FiltrosClienteModel
            {
                DataInicio = modelBase.DataInicio,
                DataFim = modelBase.DataFim
            };

            modelAlvo.Should().BeEquivalentTo(modelBase);
        }

        public static IEnumerable<object[]> CriarDadosParaInstaniarCorretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new FiltrosClienteModel
                    {
                        DataInicio = "2019 / 11 / 25",
                        DataFim = "2019 / 11 / 26"
                    }
                }
            };
    }
}
