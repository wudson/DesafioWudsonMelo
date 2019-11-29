using FirebirdSql.Data.FirebirdClient;
using FluentAssertions;
using projeto2.Feature.Marca.Dao;
using projeto2.Feature.Marca.Model;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Marca.Dao
{
    public class MarcaDaoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeCadastroCorretamente))]
        public void AdicionarParametrosDeCadastroCorretamente(MarcaModel marca)
        {
            var dao = new MarcaDao();
            var retorno = dao.AdicionarParametrosDeCadastro(marca, new FbCommand());

            retorno.Parameters["@marca"].Value.Should().BeEquivalentTo(marca.Marca);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeCadastroCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new MarcaModel
                    {
                        Marca = "marca"
                    }
                }
            };

        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeEdicaoCorretamente))]
        public void AdicionarParametrosDeEdicaoCorretamente(MarcaModel marca)
        {
            var dao = new MarcaDao();
            var retorno = dao.AdicionarParametrosDeEdicao(marca, new FbCommand());

            retorno.Parameters["@marca"].Value.Should().BeEquivalentTo(marca.Marca);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeEdicaoCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new MarcaModel
                    {
                        Marca = "marca"
                    }
                }
            };

        [Theory]
        [InlineData(1)]
        public void AdicionarParametrosDeExclusaoCorretamente(int idMarca)
        {
            var dao = new MarcaDao();
            var retorno = dao.AdicionarParametrosDeExclusao(idMarca, new FbCommand());

            retorno.Parameters["@id"].Value.Should().BeEquivalentTo(idMarca);
        }
    }
}
