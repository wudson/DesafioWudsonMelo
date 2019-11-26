using projeto2.Feature.Cliente.Model;
using System;
using System.Globalization;
using Xunit;

namespace projeto2.Testes
{
    public class TestesCliente
    {
        [Fact]
        public void TesteModelCliente()
        {
            var cliente = new ClienteModel
            {
                IdCliente = 1,
                DataCadastroCliente = new DateTime(2019/11/25),
                DataEdicaoCliente = new DateTime(2019/11/26),
                NomePessoa = "wudson",
                NumeroPessoa = 1020,
                NascimentoPessoa = new DateTime(1999/05/29),
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
            };

            Assert.NotNull(cliente.IdCliente.ToString());
            Assert.NotNull(cliente.DataCadastroCliente.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(cliente.DataEdicaoCliente.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(cliente.NascimentoPessoa.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(cliente.IdPessoa.ToString());
            Assert.NotNull(cliente.NumeroPessoa.ToString());
            Assert.NotNull(cliente.CidadePessoa);
            Assert.NotNull(cliente.CelularPessoa);
            Assert.NotNull(cliente.CepPessoa);
            Assert.NotNull(cliente.TelefonePessoa);
            Assert.NotNull(cliente.NomePessoa);
            Assert.NotNull(cliente.EmailPessoa);
            Assert.NotNull(cliente.EstadoPessoa);
            Assert.NotNull(cliente.BairroPessoa);
            Assert.NotNull(cliente.SexoPessoa);
            Assert.NotNull(cliente.ComplementoPessoa);
            Assert.NotNull(cliente.RuaPessoa);
            Assert.NotNull(cliente.RgPessoa);
            Assert.NotNull(cliente.CpfPessoa);
        }

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
