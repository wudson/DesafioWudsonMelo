using System;
using System.Collections.Generic;
using projeto2.Feature.Cliente.Model;

namespace projeto2.Feature.Pedido.Model
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public double PrecoTotalPedido { get; set; }
        public ClienteModel Cliente { get; set; }
        public IList<Produto.Produto> Produtos { get; set; }
    }
}
