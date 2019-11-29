using FirebirdSql.Data.FirebirdClient;
using FluentAssertions;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Promocao.Dao
{
    public class PromocaoDaoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeCadastroCorretamente))]
        public void AdicionarParametrosDeCadastroCorretamente(PromocaoModel promocao)
        {
            var dao = new PromocaoDao();
            var retorno = dao.AdicionarParametrosDeCadastro(promocao, new FbCommand());

            retorno.Parameters["@nome"].Value.Should().BeEquivalentTo(promocao.NomePromocao);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeCadastroCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new PromocaoModel
                    {
                        NomePromocao = "promocao"
                    }
                }
            };
    }
}
