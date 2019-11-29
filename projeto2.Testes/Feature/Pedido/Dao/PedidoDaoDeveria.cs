using FirebirdSql.Data.FirebirdClient;
using FluentAssertions;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace projeto2.Testes.Feature.Pedido.Dao
{
    public class PedidoDaoDeveria
    {
        [Theory]
        [MemberData(nameof(CriarDadosParaAdicionarParametrosDeCadastroCorretamente))]
        public void AdicionarParametrosDeCadastroCorretamente(PedidoModel pedido)
        {
            var dao = new PedidoDao();
            var retorno = dao.AdicionarParametrosDeCadastro(pedido, new FbCommand());

            retorno.Parameters["@data"].Value.Should().BeEquivalentTo(pedido.DataPedido);
        }

        public static IEnumerable<object[]> CriarDadosParaAdicionarParametrosDeCadastroCorretamente() =>
            new List<object[]>(1)
            {
                new object[]
                {
                    new PedidoModel
                    {
                        DataPedido = DateTime.Now,
                        Cliente = new ClienteModel
                        {
                            IdCliente = 1
                        }
                    }
                }
            };
    }
}
