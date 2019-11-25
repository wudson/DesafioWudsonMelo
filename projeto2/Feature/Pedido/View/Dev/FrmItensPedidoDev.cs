using DevExpress.XtraEditors;
using projeto2.Feature.Pedido.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Pedido.View.Dev
{
    public partial class FrmItensPedidoDev : XtraForm
    {
        private readonly IEnumerable<ItemPedidoModel> _produtosPedido;

        public FrmItensPedidoDev(IEnumerable<ItemPedidoModel> produtosPedido)
        {
            InitializeComponent();
            _produtosPedido = produtosPedido;
        }

        private void FrmItensPedido_Load(object sender, EventArgs e) => dgvItensPedido.DataSource = _produtosPedido;

        private void FrmItensPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}