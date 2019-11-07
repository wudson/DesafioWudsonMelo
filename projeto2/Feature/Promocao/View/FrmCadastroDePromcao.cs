using System;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmCadastroDePromcao : Form
    {
        public FrmCadastroDePromcao()
        {
            InitializeComponent();
        }

        private void BtnSelecionarProdutosDaPromocao_Click(object sender, EventArgs e)
        {
            new FrmProdutosDaPromocaoComDesconto().ShowDialog();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            AplicarDescontoNosProdutosSelecionados();
        }

        private void AplicarDescontoNosProdutosSelecionados()
        {
            for (var i = 0; i < dgvProdutosDaPromocao.RowCount; i++)
                if (rdbValorFixo.Checked)
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) -
                        double.Parse(txtDesconto.Text);
                else
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) -
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) *
                        double.Parse(txtDesconto.Text) / 100;
        }

        private void DgvProdutosDaPromocao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) => 
            AplicarDescontoNosProdutosSelecionados();
    }
}
