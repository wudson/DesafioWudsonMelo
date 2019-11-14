using projeto2.Feature.Produto.Controller;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Produto.View
{
    public partial class FrmProdutos : Form
    {
        private readonly ProdutoController _produtoController;

        public FrmProdutos(ProdutoController controller)
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
            dgvProduto.DataSource = _produtoController.ListarDados(new Produto());
            if (dgvProduto.CurrentRow != null) dgvProduto.CurrentRow.Selected = false;

            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnExcluir.Enabled = enabled;
            btnEditar.Enabled = enabled;
        }

        private void DgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            BuscarProdutoParaAlterar();
        }

        private void BuscarProdutoParaAlterar()
        {
            var produto =
                _produtoController.BuscarDado(int.Parse(dgvProduto.CurrentRow?.Cells[0].Value.ToString() ?? "-1"));

            _produtoController.AbrirTelaDeAlterarECadastrarProdutos(produto);
            AtualizarGridDadosProduto();
        }

        private void DgvProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ModificarEnabledDosBotoes(true);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!btnEditar.Enabled) return;

            BuscarProdutoParaAlterar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

            var resultado = MessageBox.Show(@"Deseja excluir esse produto?", @"Deletar", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            if(_produtoController.ExcluirDado(int.Parse(dgvProduto.CurrentRow?.Cells[0].Value.ToString() ?? "-1")))
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

        private void DgvProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => 
            e.Value = Propriedade.BuscarPropriedadeComPonto(dgvProduto, e);
    }
}