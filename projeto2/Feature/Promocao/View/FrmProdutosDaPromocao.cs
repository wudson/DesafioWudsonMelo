using projeto2.Feature.Promocao.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
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

        private void ExibirProdutos()
        {
            dgvItensPromocao.DataSource = _promocao[0].Produtos;
        }

        private void DgvItensPromocao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => 
            e.Value = Propriedade.BuscarPropriedadeComPonto(dgvItensPromocao, e);
    }
}
