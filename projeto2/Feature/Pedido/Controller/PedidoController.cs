using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Dao;
using projeto2.Feature.Pedido.Model;

namespace projeto2.Feature.Pedido.Controller
{
    public class PedidoController
    {
        public bool SalvarPedido(PedidoModel pedido)
        {
            try
            {
                if (new PedidoDao().Cadastrar(pedido))
                {
                    MessageBox.Show(@"Pedido efetuado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show($@"Problemas ao efetuar pedido.", @"Erro");
            }

            return false;
        }
    }
}
