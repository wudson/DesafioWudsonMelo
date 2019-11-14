using System.Collections.Generic;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Pedido.View;

namespace projeto2.Feature.Pedido.Controller
{
    public class ItensPedidoController
    {
        public void AbrirTelaParaExibirItensDoPedido(IEnumerable<ItemPedidoModel> pedido) => 
            new FrmItensPedido(pedido).ShowDialog();
    }
}
