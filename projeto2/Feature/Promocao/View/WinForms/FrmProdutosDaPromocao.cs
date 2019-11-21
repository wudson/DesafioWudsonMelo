using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View.WinForms
{
    public partial class FrmProdutosDaPromocao : Form
    {
        private readonly List<PromocaoModel> _promocao;

        public FrmProdutosDaPromocao(List<PromocaoModel> promocao)
        {
            InitializeComponent();
            _promocao = promocao;
            ExibirProdutos();
        }

        private void ExibirProdutos() => dgvItensPromocao.DataSource = _promocao[0].Produtos;

        private void DgvItensPromocao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => 
            e.Value = Propriedade.BuscarPropriedadeComPonto(dgvItensPromocao, e);

        private void BtnOk_Click(object sender, EventArgs e) => Close();

        private void FrmProdutosDaPromocao_KeyDown(object sender, KeyEventArgs e)
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
    }
}
