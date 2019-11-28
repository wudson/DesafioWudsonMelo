using FirebirdSql.Data.FirebirdClient;
using FluentAssertions;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pessoa.Dao;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Pessoa.Dao
{
    public class PessoaDaoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeCadastroCorretamente))]
        public void AdicionarParametrosDeCadastroCorretamente(ClienteModel pessoa)
        {
            var dao = new PessoaDao();
            var retorno = dao.AdicionarParametrosDeCadastro(pessoa, new FbCommand());

            retorno.Parameters["@nome"].Value.Should().BeEquivalentTo(pessoa.NomePessoa);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeCadastroCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new ClienteModel
                    {
                        NomePessoa = "Wudson"
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeEdicaoCorretamente))]
        public void AdicionarParametrosDeEdicaoCorretamente(ClienteModel pessoa)
        {
            var dao = new PessoaDao();
            var retorno = dao.AdicionarParametrosDeEdicao(pessoa, new FbCommand());

            retorno.Parameters["@nome"].Value.Should().BeEquivalentTo(pessoa.NomePessoa);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeEdicaoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new ClienteModel
                    {
                        NomePessoa = "Wudson"
                    }
                }
            };
    }
}
