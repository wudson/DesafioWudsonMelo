using System;
using System.Collections.Generic;
using System.Reflection;
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
                e.Value = BindProperty(dgvItensPedido.Rows[e.RowIndex].DataBoundItem, dgvItensPedido.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        public object BindProperty(object propriedade, string propriedadeName)
        {
            var retValue = "";
            if (propriedadeName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propriedadeName.Substring(0, propriedadeName.IndexOf(".", StringComparison.Ordinal));
                arrayProperties = propriedade.GetType().GetProperties();
                foreach (var propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name != leftPropertyName) continue;
                    retValue = (string)BindProperty(
                        propertyInfo.GetValue(propriedade, null),
                        propriedadeName.Substring(propriedadeName.IndexOf(".", StringComparison.Ordinal) + 1));
                    break;
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = propriedade.GetType();
                propertyInfo = propertyType.GetProperty(propriedadeName);
                if (propertyInfo != null) retValue = propertyInfo.GetValue(propriedade, null).ToString();
            }
            return retValue;
        }
    }
}
