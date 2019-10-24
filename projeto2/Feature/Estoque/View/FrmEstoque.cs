using System;
using System.Windows.Forms;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Estoque.View
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            dgvEstoque.DataSource = new ProdutoController().BuscarTodosOsDados();

            txtGrupo.Items.Add("Grupo1");
            txtGrupo.Items.Add("Grupo2");
            txtGrupo.Items.Add("Grupo3");
            txtTipo.Items.Add("Unidade");
            txtTipo.Items.Add("Caixa");
            txtTipo.Items.Add("Peso");

            CalculaPrecoTotal();
        }

        private void CalculaPrecoTotal()
        {
            for (var i = 0; i < dgvEstoque.Rows.Count; i++)
            {
                var total = Convert.ToDecimal(dgvEstoque.Rows[i].Cells["valorVendaProduto"].Value) * Convert.ToDecimal(dgvEstoque.Rows[i].Cells["quantidadeEstoqueProduto"].Value);
                dgvEstoque.Rows[i].Cells["valorTotal"].Value = total;
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text) && string.IsNullOrWhiteSpace(txtGrupo.Text) && string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                FrmEstoque_Load(sender, e);
                return;
            }
            dgvEstoque.DataSource = new ProdutoController().BuscarDadoComFiltros(txtPesquisa.Text.ToLower(), txtGrupo.Text.ToLower(), txtTipo.Text.ToLower());
            CalculaPrecoTotal();
        }

        private void FrmEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BtnPesquisar_Click(sender,e);
                    break;
                case Keys.Delete:
                    BtnLimpar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtGrupo.Text = string.Empty;
            txtPesquisa.Text = string.Empty;
            txtTipo.Text = string.Empty;
            FrmEstoque_Load(sender, e);
        }
    }
}
