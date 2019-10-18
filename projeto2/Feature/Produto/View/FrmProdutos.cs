using System;
using System.Windows.Forms;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Produto.View
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            new FrmCadastroDeProduto().ShowDialog();
            AtualizarGridDadosProduto();
        }

        private void AtualizarGridDadosProduto()
        {

            var produtos = new ProdutoController().BuscarTodosOsDados();
            dgvProduto.DataSource = produtos;
            if (dgvProduto.CurrentRow != null) dgvProduto.CurrentRow.Selected = false;

            DesativarBotoes();
        }

        private void DesativarBotoes()
        {
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            AtualizarGridDadosProduto();
        }

        private void DgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
            var idProdutoLinhaAtual = int.Parse(dgvProduto.Rows[e.RowIndex].Cells[0].Value.ToString());
            var produto = new ProdutoController().BuscarDado(idProdutoLinhaAtual);

            new FrmCadastroDeProduto(produto).ShowDialog();
            AtualizarGridDadosProduto();
        }

        private void DgvProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idProdutoLinhaAtual = int.Parse(dgvProduto.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            var produto = new ProdutoController().BuscarDado(idProdutoLinhaAtual);

            new FrmCadastroDeProduto(produto).ShowDialog();
            AtualizarGridDadosProduto();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(@"Deseja excluir esse produto?", @"Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            var idProdutoLinhaAtual = int.Parse(dgvProduto.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            if(new ProdutoController().ExcluirDado(idProdutoLinhaAtual))
                AtualizarGridDadosProduto();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGridDadosProduto();
        }
    }
}