using FirebirdSql.Data.FirebirdClient;
using FluentAssertions;
using projeto2.Feature.Grupo.Dao;
using projeto2.Feature.Grupo.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Grupo.Dao
{
    public class GrupoDaoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeCadastroCorretamente))]
        public void AdicionarParametrosDeCadastroCorretamente(GrupoModel grupo)
        {
            var dao = new GrupoDao();
            var retorno = dao.AdicionarParametrosDeCadastro(grupo, new FbCommand());

            retorno.Parameters["@grupo"].Value.Should().BeEquivalentTo(grupo.Grupo);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeCadastroCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new GrupoModel
                    {
                        Grupo = "grupo"
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeEdicaoCorretamente))]
        public void AdicionarParametrosDeEdicaoCorretamente(GrupoModel grupo)
        {
            var dao = new GrupoDao();
            var retorno = dao.AdicionarParametrosDeEdicao(grupo, new FbCommand());

            retorno.Parameters["@grupo"].Value.Should().BeEquivalentTo(grupo.Grupo);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeEdicaoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new GrupoModel
                    {
                        Grupo = "grupo"
                    }
                }
            };

        [Theory]
        [InlineData(1)]
        public void AdicionarParametrosDeExclusaoCorretamente(int idGrupo)
        {
            var dao = new GrupoDao();
            var retorno = dao.AdicionarParametrosDeExclusao(idGrupo, new FbCommand());

            retorno.Parameters["@id"].Value.Should().BeEquivalentTo(idGrupo);
        }
    }
}
