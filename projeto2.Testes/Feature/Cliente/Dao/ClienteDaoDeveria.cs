using FirebirdSql.Data.FirebirdClient;
using FluentAssertions;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Cliente.Dao
{
    public class ClienteDaoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeCadastroCorretamente))]
        public void AdicionarParametrosDeCadastroCorretamente(ClienteModel cliente)
        {
            var dao = new ClienteDao();
            var retorno = dao.AdicionarParametrosDeCadastro(cliente, new FbCommand());

            retorno.Parameters["@dataCadastro"].Value.Should().BeEquivalentTo(cliente.DataCadastroCliente);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeCadastroCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new ClienteModel
                    {
                        DataCadastroCliente = DateTime.Now
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeEdicaoCorretamente))]
        public void AdicionarParametrosDeEdicaoCorretamente(ClienteModel cliente)
        {
            var dao = new ClienteDao();
            var retorno = dao.AdicionarParametrosDeEdicao(cliente, new FbCommand());

            retorno.Parameters["@dataEdicao"].Value.Should().BeEquivalentTo(cliente.DataEdicaoCliente);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeEdicaoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new ClienteModel
                    {
                        DataEdicaoCliente = DateTime.Now
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeListagemCorretamente))]
        public void AdicionarParametrosDeListagemCorretamente(FiltrosClienteModel cliente)
        {
            var dao = new ClienteDao();
            var retorno = dao.AdicionarParametrosDeListagem(cliente, new FbCommand());

            retorno.Parameters["@nome"].Value.Should().BeEquivalentTo($"{cliente.NomePessoa}%");
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeListagemCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new FiltrosClienteModel
                    {
                        NomePessoa = "udsu"
                    }
                }
            };
    }
}
