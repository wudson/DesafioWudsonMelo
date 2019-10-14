using System;
using System.Drawing;
using System.Windows.Forms;
using projeto2.novonomedepois.Produto.Controller;

namespace projeto2.novonomedepois.Produto.View
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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            AtualizarGridDadosProduto();
        }

        private void AtualizarGridDadosProduto()
        {
            
            var produtos = new ProdutoController().BuscarTodosOsDados();

            gridDadosProduto.DataSource = produtos;
            if (gridDadosProduto.CurrentRow != null) gridDadosProduto.CurrentRow.Selected = false;

            DesativarBotoes();
            RenomearCabecalhoDadosProduto();
        }

        private void RenomearCabecalhoDadosProduto()
        {
            gridDadosProduto.Columns[0].HeaderText = @"ID";
            gridDadosProduto.Columns[1].HeaderText = @"Produto";
            gridDadosProduto.Columns[2].HeaderText = @"Fornecedor";
            gridDadosProduto.Columns[3].HeaderText = @"Valor Compra";
            gridDadosProduto.Columns[4].HeaderText = @"Valor Venda";
            gridDadosProduto.Columns[5].HeaderText = @"Grupo";
            gridDadosProduto.Columns[6].HeaderText = @"Marca";
            gridDadosProduto.Columns[7].HeaderText = @"Estoque";
        }

        private void GridDadosProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
            var idProdutoLinhaAtual = int.Parse(gridDadosProduto.Rows[e.RowIndex].Cells[0].Value.ToString());
            var produto = new ProdutoController().BuscarDado(idProdutoLinhaAtual);

            new FrmCadastroDeProduto(produto).ShowDialog();
            AtualizarGridDadosProduto();
        }

        private void GridDadosProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var lbtnEditar = tblBotoes.GetControlFromPosition(2, 0);
            lbtnEditar.Enabled = true;
            lbtnEditar.BackColor = Color.RoyalBlue;

            var lbtnExcluir = tblBotoes.GetControlFromPosition(3, 0);
            lbtnExcluir.Enabled = true;
            lbtnExcluir.BackColor = Color.RoyalBlue;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idProdutoLinhaAtual = int.Parse(gridDadosProduto.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            var produto = new ProdutoController().BuscarDado(idProdutoLinhaAtual);

            new FrmCadastroDeProduto(produto).ShowDialog();
            AtualizarGridDadosProduto();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Deseja excluir esse produto?", @"Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK)) return;

            var idProdutoLinhaAtual = int.Parse(gridDadosProduto.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());

            MessageBox.Show(new ProdutoController().ExcluirDado(idProdutoLinhaAtual)
                ? @"Produto excluido com sucesso!"
                : @"Problemas ao excluir produto!");
            AtualizarGridDadosProduto();
        }

        private void DesativarBotoes()
        {
            var lbtnEditar = tblBotoes.GetControlFromPosition(2, 0);
            lbtnEditar.Enabled = false;
            lbtnEditar.BackColor = Color.LightSteelBlue;

            var lbtnExcluir = tblBotoes.GetControlFromPosition(3, 0);
            lbtnExcluir.Enabled = false;
            lbtnExcluir.BackColor = Color.LightSteelBlue;
        }
    }
}
