using projeto2.Feature.Produto;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace projeto2.Testes
{
    public class TestesPromocao
    {
        [Fact]
        public void TesteModelPromocao()
        {
            var promocao = new PromocaoModel
            {
                IdPromocao = 1,
                DataInicio = new DateTime(2019 / 11 / 25),
                DataFim = new DateTime(2019 / 11 / 30),
                NomePromocao = "promocao",
                StatusPromocao = "ativa",
                TipoPromocao = "desconto",
                Produtos = new List<Produto>
                {
                    new Produto()
                }
            };

            Assert.NotNull(promocao.IdPromocao.ToString());
            Assert.NotNull(promocao.DataInicio.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(promocao.DataFim.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(promocao.NomePromocao);
            Assert.NotNull(promocao.StatusPromocao);
            Assert.NotNull(promocao.TipoPromocao);
            Assert.NotNull(promocao.Produtos);
        }

        [Fact]
        public void TesteModelFiltrosPromocao()
        {
            var filtro = new FiltrosPromocaoModel
            {
                Inativas = false,
                Ativas = true
            };

            Assert.False(filtro.Inativas);
            Assert.True(filtro.Ativas);
        }
    }
}
