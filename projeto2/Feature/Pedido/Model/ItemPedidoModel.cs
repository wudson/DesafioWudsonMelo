namespace projeto2.Feature.Pedido.Model
{
    public class ItemPedidoModel
    {
        public int IdItemPedido { get; set; }
        public int Quantidade { get; set; }
        public PedidoModel Pedido { get; set; }
        public Produto.Produto ProdutosPedido { get; set; }

        public double PrecoTotal =>
            Quantidade * ProdutosPedido.ValorComDesconto;
    }
}