using DevExpress.XtraEditors;
using projeto2.Feature.Promocao.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View.Dev
{
    public partial class FrmProdutosDaPromocaoDev : XtraForm
    {
        private readonly List<PromocaoModel> _promocao;

        public FrmProdutosDaPromocaoDev(List<PromocaoModel> promocao)
        {
            InitializeComponent();
            _promocao = promocao;
            ExibirProdutos();
        }

        private void ExibirProdutos() => dgvProdutosDaPromocao.DataSource = _promocao[0].Produtos;

        private void FrmProdutosDaPromocao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}