using System;
using System.Windows.Forms;
using projeto2.Feature.Cliente.View;
using projeto2.Feature.Estoque.View;
using projeto2.Feature.Grupo.View;
using projeto2.Feature.Marca.View;
using projeto2.Feature.Pedido.View;
using projeto2.Feature.Produto.View;

namespace projeto2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            new FrmProdutos().ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            new FrmClientes().ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Deseja sair do sistema?", @"Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK)) return;
            Hide();
            var login = new FrmEntrar();
            login.Closed += (s, args) => Close();
            login.Show();
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    BtnProdutos_Click(sender, e);
                    break;
                case Keys.D2:
                    BtnClientes_Click(sender, e);
                    break;
                case Keys.D3:
                    BtnPedidos_Click(sender, e);
                    break;
                case Keys.D4:
                    BtnEstoque_Click(sender, e);
                    break;
                case Keys.D6:
                    BtnGrupos_Click(sender, e);
                    break;
                case Keys.D7:
                    BtnMarcas_Click(sender, e);
                    break;
                case Keys.Escape:
                    BtnSair_Click(sender, e);
                    break;
            }
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            new FrmPedidos().ShowDialog();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            new FrmMarcas().ShowDialog();
        }

        private void BtnGrupos_Click(object sender, EventArgs e)
        {
            new FrmGrupos().ShowDialog();
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            new FrmEstoque().ShowDialog();
        }
    }
}