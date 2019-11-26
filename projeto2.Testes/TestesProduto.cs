using System.Globalization;
using projeto2.Feature.Produto;
using Xunit;

namespace projeto2.Testes
{
    public class TestesProduto
    {
        [Fact]
        public void TesteModelProduto()
        {
            var produto = new Produto
            {
                IdProduto = 1,
                NomeProduto = "produto",
                CodigoDeBarras = "123456789",
                GrupoProduto =
                {
                    Grupo = "grupo",
                    IdGrupo = 1
                },
                MarcaProduto =
                {
                    Marca = "marca",
                    IdMarca = 1
                },
                QuantidadeEstoqueProduto = 100,
                ValorCompraProduto = 5.33,
                ValorVendaProduto = 12.00,
                ValorComDesconto = 8.55,
                QuantidadeProdutoPedido = 5,
                FornecedorProduto = "fornecedor",
                TipoProduto = "caixa"
            };

            Assert.NotNull(produto.IdProduto.ToString());
            Assert.NotNull(produto.NomeProduto);
            Assert.NotNull(produto.FornecedorProduto);
            Assert.NotNull(produto.TipoProduto);
            Assert.NotNull(produto.CodigoDeBarras);
            Assert.NotNull(produto.ValorComDesconto.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(produto.ValorCompraProduto.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(produto.ValorTotalEstoque.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(produto.ValorTotalProdutoPedido.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture));
            Assert.NotNull(produto.MarcaProduto.IdMarca.ToString());
            Assert.NotNull(produto.MarcaProduto.Marca);
            Assert.NotNull(produto.GrupoProduto.IdGrupo.ToString());
            Assert.NotNull(produto.GrupoProduto.Grupo);
            Assert.NotNull(produto.QuantidadeProdutoPedido.ToString());
            Assert.NotNull(produto.QuantidadeEstoqueProduto.ToString());
        }
    }
}
