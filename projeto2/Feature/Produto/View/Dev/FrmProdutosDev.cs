using DevExpress.XtraEditors;
using projeto2.Feature.Produto.Controller;
using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            _produtoController.AbrirTelaDeAlterarECadastrarProdutos();
            AtualizarGridDadosProduto();
        }

        private void AtualizarGridDadosProduto()
        {
            dgvProdutos.DataSource = _produtoController.ListarDados(new Produto());
            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnExcluir.Enabled = enabled;
            btnEditar.Enabled = enabled;
        }

        private void BuscarProdutoParaAlterar()
        {
            var produto =
                _produtoController.BuscarDado(Convert.ToInt32(gvProdutos.GetFocusedRowCellValue("IdProduto")));

            _produtoController.AbrirTelaDeAlterarECadastrarProdutos(produto);
            AtualizarGridDadosProduto();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!btnEditar.Enabled) return;

            BuscarProdutoParaAlterar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

            var resultado = XtraMessageBox.Show(@"Deseja excluir esse produto?", @"Deletar", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            if (_produtoController.ExcluirDado(Convert.ToInt32(gvProdutos.GetFocusedRowCellValue("IdProduto"))))
                AtualizarGridDadosProduto();
        }

        private void FrmProdutos_Load(object sender, EventArgs e) => AtualizarGridDadosProduto();

        private void FrmProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnCadastrar_Click(sender, e);
                    break;
                case Keys.F4:
                    BtnEditar_Click(sender, e);
                    break;
                case Keys.E:
                    BtnEstoque_Click(sender, e);
                    break;
                case Keys.Delete:
                    BtnExcluir_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void BtnEstoque_Click(object sender, EventArgs e) => _produtoController.AbrirTelaDeEstoqueDeProdutos();

        private void GvProdutos_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            ModificarEnabledDosBotoes(true);
        }
    }
}