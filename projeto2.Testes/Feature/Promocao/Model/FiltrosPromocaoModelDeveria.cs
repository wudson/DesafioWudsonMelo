using FluentAssertions;
using projeto2.Feature.Promocao.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Promocao.Model
{
    public class FiltrosPromocaoModelDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaInstaniarCorretamente))]
        public void InstanciarCorretamente(FiltrosPromocaoModel modelBase)
        {
            var modelAlvo = new FiltrosPromocaoModel
            {
                Inativas = modelBase.Inativas,
                Ativas = modelBase.Ativas
            };

            modelAlvo.Should().BeEquivalentTo(modelBase);
        }

        public static IEnumerable<object[]> CriarDadosParaInstaniarCorretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new FiltrosPromocaoModel
                    {
                        Inativas = false,
                        Ativas = true
                    }
                },

                new object[]
                {
                new FiltrosPromocaoModel
                {
                Inativas = true,
                Ativas = false
            }
    }
            };
    }
}
