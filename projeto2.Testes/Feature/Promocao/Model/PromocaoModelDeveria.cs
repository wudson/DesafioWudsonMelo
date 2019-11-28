using FluentAssertions;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Promocao.Model
{
    public class PromocaoModelDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaInstaniarCorretamente))]
        public void InstanciarCorretamente(PromocaoModel modelBase)
        {
            var modelAlvo = new PromocaoModel
            {
                IdPromocao = modelBase.IdPromocao,
                DataInicio = modelBase.DataInicio,
                DataFim = modelBase.DataFim,
                NomePromocao = modelBase.NomePromocao,
                StatusPromocao = modelBase.StatusPromocao,
                TipoPromocao = modelBase.TipoPromocao,
                Produtos = modelBase.Produtos
            };

            modelAlvo.Should().BeEquivalentTo(modelBase);
        }

        public static IEnumerable<object[]> CriarDadosParaInstaniarCorretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new PromocaoModel
                    {
                        IdPromocao = 1,
                        DataInicio = new DateTime(2019 / 11 / 25),
                        DataFim = new DateTime(2019 / 11 / 30),
                        NomePromocao = "promocao",
                        StatusPromocao = "ativa",
                        TipoPromocao = "desconto",
                        Produtos = new List<projeto2.Feature.Produto.Produto>
                        {
                            new projeto2.Feature.Produto.Produto()
                        }
                    }
                }
            };
    }
}
