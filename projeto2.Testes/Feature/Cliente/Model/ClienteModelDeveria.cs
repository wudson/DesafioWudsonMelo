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

            modelAlvo.Should().BeEquivalentTo(modelBase);
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
    }
}
