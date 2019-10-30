using System;
using System.Windows.Forms;
using projeto2.Feature.Estoque.View;
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

            var produtos = new ProdutoController().ListarDados(new Produto());
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
            if (e.RowIndex < 0) return;
            var idProdutoLinhaAtual = int.Parse(dgvProduto.Rows[e.RowIndex].Cells[0].Value.ToString());
            var produto = new ProdutoController().BuscarDado(idProdutoLinhaAtual);

            new FrmCadastroDeProduto(produto).ShowDialog();
            AtualizarGridDadosProduto();
        }

        private void DgvProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!btnEditar.Enabled) return;

            var idProdutoLinhaAtual = int.Parse(dgvProduto.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            var produto = new ProdutoController().BuscarDado(idProdutoLinhaAtual);

            new FrmCadastroDeProduto(produto).ShowDialog();
            AtualizarGridDadosProduto();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

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

        private void FrmProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnCadastrar_Click(sender, e);
                    break;
                case Keys.F5:
                    BtnListar_Click(sender, e);
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

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            new FrmEstoque().ShowDialog();
        }

        private void DgvProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvProduto.Rows[e.RowIndex].DataBoundItem != null) && (dgvProduto.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BuscarPropriedade(dgvProduto.Rows[e.RowIndex].DataBoundItem, dgvProduto.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        public object BuscarPropriedade(object propriedade, string nomePropriedade)
        {
            var retValue = "";
            if (nomePropriedade.Contains("."))
            {
                var nomeDaPropriedadeRestante = nomePropriedade.Substring(0, nomePropriedade.IndexOf(".", StringComparison.Ordinal));
                var propriedades = propriedade.GetType().GetProperties();
                foreach (var propertyInfo in propriedades)
                {
                    if (propertyInfo.Name != nomeDaPropriedadeRestante) continue;
                    retValue = (string)BuscarPropriedade(
                        propertyInfo.GetValue(propriedade, null),
                        nomePropriedade.Substring(nomePropriedade.IndexOf(".", StringComparison.Ordinal) + 1));
                    break;
                }
            }
            else
            {
                var tipoDaPropriedade = propriedade.GetType();
                var informacoesDaPropriedade = tipoDaPropriedade.GetProperty(nomePropriedade);
                if (informacoesDaPropriedade != null) retValue = informacoesDaPropriedade.GetValue(propriedade, null).ToString();
            }
            return retValue;
        }
    }
}