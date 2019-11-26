using DevExpress.XtraEditors;
using projeto2.Feature.Principal.Controller;
using System;
using System.Windows.Forms;
using projeto2.Login;

namespace projeto2.Feature.Principal.View.Dev
{
    public partial class FrmPrincipalDev : XtraForm
    {
        private readonly PrincipalController _principalController;

        public FrmPrincipalDev()
        {
            InitializeComponent();
            _principalController = new PrincipalController();
        }

        private void BtnProdutos_Click(object sender, EventArgs e) => _principalController.AbrirTelaDeProdutos();

        private void BtnClientes_Click(object sender, EventArgs e) => _principalController.AbrirTelaDeClientes();

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show(@"Deseja sair do sistema?", @"Sair", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
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
                case Keys.D5:
                    BtnPromocoes_Click(sender, e);
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

        private void BtnPedidos_Click(object sender, EventArgs e) => _principalController.AbrirTelaDePedidos();

        private void BtnMarcas_Click(object sender, EventArgs e) => _principalController.AbrirTelaDeMarcas();

        private void BtnGrupos_Click(object sender, EventArgs e) => _principalController.AbrirTelaDeGrupos();

        private void BtnEstoque_Click(object sender, EventArgs e) =>
            _principalController.AbrirTelaDeEstoqueDeProdutos();

        private void BtnPromocoes_Click(object sender, EventArgs e) => _principalController.AbrirTelaDePromocoes();
    }
}