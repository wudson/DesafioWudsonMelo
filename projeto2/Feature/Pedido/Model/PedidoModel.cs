using System;

namespace projeto2.Feature.Pedido.Model
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public double PrecoTotalPedido { get; set; }
        public int IdClientePedido { get; set; }
    }
}
