using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Model;

namespace projeto2.Feature.Pedido.View
{
    public partial class FrmItensPedido : Form
    {
        private readonly IEnumerable<ItemPedidoModel> _produtosPedido;

        public FrmItensPedido(IEnumerable<ItemPedidoModel> produtosPedido)
        {
            InitializeComponent();
            _produtosPedido = produtosPedido;
        }

        public FrmItensPedido()
        {
            InitializeComponent();
        }

        private void FrmItensPedido_Load(object sender, EventArgs e)
        {
            dgvItensPedido.DataSource = _produtosPedido;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmItensPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BtnOk_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void DgvItensPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvItensPedido.Rows[e.RowIndex].DataBoundItem != null) && (dgvItensPedido.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = new Propriedade().BuscarPropriedade(dgvItensPedido.Rows[e.RowIndex].DataBoundItem, dgvItensPedido.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
    }
}
