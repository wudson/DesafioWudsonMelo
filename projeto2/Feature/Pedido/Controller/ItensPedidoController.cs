using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Pedido.View.Dev;
using projeto2.Feature.Pedido.View.WinForms;
using System.Collections.Generic;

namespace projeto2.Feature.Pedido.Controller
{
    public class ItensPedidoController
    {
        public void AbrirTelaParaExibirItensDoPedido(IEnumerable<ItemPedidoModel> pedido)
        {
            if(!ClasseComVariaveisGlobais.UsarDev)
                new FrmItensPedido(pedido).ShowDialog();
            else
                new FrmItensPedidoDev(pedido).ShowDialog();
        }
    }
}
