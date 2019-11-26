using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Produto
{
    public class Produto
    {
        public Produto()
        {
            MarcaProduto = new MarcaModel();
            GrupoProduto = new GrupoModel();
        }

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public GrupoModel GrupoProduto { get; set; }
        public MarcaModel MarcaProduto { get; set; }
        public int QuantidadeEstoqueProduto { get; set; }
        public double ValorCompraProduto { get; set; }
        public double ValorVendaProduto { get; set; }
        public double ValorComDesconto { get; set; }
        public string FornecedorProduto { get; set; }
        public int QuantidadeProdutoPedido { get; set; }
        public string TipoProduto { get; set; }
        public string CodigoDeBarras { get; set; }

        public double ValorTotalEstoque =>
            QuantidadeEstoqueProduto * ValorVendaProduto;

        public double ValorTotalProdutoPedido =>
            QuantidadeProdutoPedido * ValorComDesconto;
    }
}
