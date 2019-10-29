using System;
using System.Collections.Generic;

namespace projeto2.Feature.Pedido.Model
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public double PrecoTotalPedido { get; set; }
        public int IdClientePedido { get; set; }
        public IList<Produto.Produto> Produtos { get; set; }
    }
}
