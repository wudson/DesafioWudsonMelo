using System.Windows.Forms;
using projeto2.Feature.Produto.Dao;

namespace projeto2.Feature.Pedido.View
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, System.EventArgs e)
        {
            var produtos = new ProdutoDao().Listar();
        }
    }
}
