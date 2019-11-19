using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Produto.View.Dev
{
    public partial class FrmProdutosDev : XtraForm
    {
        private readonly ProdutoController _produtoController;

        public FrmProdutosDev(ProdutoController controller)
        {
            InitializeComponent();
            _produtoController = controller;
        }

        private void AtualizarGridDadosProduto()
        {
            dgvProdutos.DataSource = _produtoController.ListarDados(new Produto());
        }

        private void FrmProdutosDev_Load(object sender, EventArgs e) => AtualizarGridDadosProduto();
    }
}