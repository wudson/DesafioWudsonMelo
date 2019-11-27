using System;
using System.Collections.Generic;
using System.Globalization;
using FluentAssertions;
using projeto2.Feature.Cliente.Model;
using Xunit;

namespace projeto2.Testes.Feature.Cliente.Model
{
    public class ClienteModelDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaInstaniarCorretamente))]
        public void InstaniarCorretamente(ClienteModel modelBase)
        {
            var modelAlvo = new ClienteModel
            {
                IdCliente = modelBase.IdCliente,
                DataCadastroCliente = modelBase.DataCadastroCliente,
                DataEdicaoCliente = modelBase.DataEdicaoCliente,
                NomePessoa = modelBase.NomePessoa,
                NumeroPessoa = modelBase.NumeroPessoa,
                NascimentoPessoa = modelBase.NascimentoPessoa,
                RuaPessoa = modelBase.RuaPessoa,
                CidadePessoa = modelBase.CidadePessoa,
                CelularPessoa = modelBase.CelularPessoa,
                TelefonePessoa = modelBase.TelefonePessoa,
                CepPessoa = modelBase.CepPessoa,
                ComplementoPessoa = modelBase.ComplementoPessoa,
                CpfPessoa = modelBase.CpfPessoa,
                RgPessoa = modelBase.RgPessoa,
                BairroPessoa = modelBase.BairroPessoa,
                SexoPessoa = modelBase.SexoPessoa,
                EmailPessoa = modelBase.EmailPessoa,
                IdPessoa = modelBase.IdPessoa,
                EstadoPessoa = modelBase.EstadoPessoa
            };

            modelAlvo.IdCliente
                .Should()
                .Be(modelBase.IdCliente, " porque, na model, há uma conta de subtração e adição nessa variável");

            modelAlvo.DataCadastroCliente
                .Should()
                .BeSameDateAs(modelBase.DataCadastroCliente);

            Assert.NotNull(modelAlvo.IdCliente.ToString());
            Assert.NotNull(modelAlvo.DataCadastroCliente.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(modelAlvo.DataEdicaoCliente.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(modelAlvo.NascimentoPessoa.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(modelAlvo.IdPessoa.ToString());
            Assert.NotNull(modelAlvo.NumeroPessoa.ToString());
            Assert.NotNull(modelAlvo.CidadePessoa);
            Assert.NotNull(modelAlvo.CelularPessoa);
            Assert.NotNull(modelAlvo.CepPessoa);
            Assert.NotNull(modelAlvo.TelefonePessoa);
            Assert.NotNull(modelAlvo.NomePessoa);
            Assert.NotNull(modelAlvo.EmailPessoa);
            Assert.NotNull(modelAlvo.EstadoPessoa);
            Assert.NotNull(modelAlvo.BairroPessoa);
            Assert.NotNull(modelAlvo.SexoPessoa);
            Assert.NotNull(modelAlvo.ComplementoPessoa);
            Assert.NotNull(modelAlvo.RuaPessoa);
            Assert.NotNull(modelAlvo.RgPessoa);
            Assert.NotNull(modelAlvo.CpfPessoa);
        }

        public static IEnumerable<object[]> CriarDadosParaInstaniarCorretamente() =>
            new List<object[]>
            {
                new object[]
                {
                    new ClienteModel
                    {
                        IdCliente = 1,
                        DataCadastroCliente = new DateTime(2019 / 11 / 25),
                        DataEdicaoCliente = new DateTime(2019 / 11 / 26),
                        NomePessoa = "wudson",
                        NumeroPessoa = 1020,
                        NascimentoPessoa = new DateTime(1999 / 05 / 29),
                        RuaPessoa = "fortaleza",
                        CidadePessoa = "urânia",
                        CelularPessoa = "17997513622",
                        TelefonePessoa = "36341111",
                        CepPessoa = "15760000",
                        ComplementoPessoa = "fundos",
                        CpfPessoa = "46775217862",
                        RgPessoa = "503293593",
                        BairroPessoa = "centro",
                        SexoPessoa = "M",
                        EmailPessoa = "wudson@gmail.com",
                        IdPessoa = 1,
                        EstadoPessoa = "São Paulo"
                    }
                }
            };

        [Fact]
        public void TesteModelFiltrosCliente()
        {
            var filtro = new FiltrosClienteModel
            {
                DataInicio = "2019 / 11 / 25",
                DataFim = "2019 / 11 / 26"
            };

            Assert.NotNull(filtro.DataInicio);
            Assert.NotNull(filtro.DataFim);
        }
    }
}
