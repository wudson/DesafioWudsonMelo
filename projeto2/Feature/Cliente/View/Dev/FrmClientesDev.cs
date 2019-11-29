using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Cliente.View.Dev
{
    public partial class FrmClientesDev : XtraForm
    {
        private readonly ClienteController _clienteController;

        public FrmClientesDev(ClienteController controller)
        {
            InitializeComponent();
            _clienteController = controller;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            _clienteController.AbrirTelaDeAlterarECadastrarClientes();
            AtualizarGridDadosCliente();
        }

        private void AtualizarGridDadosCliente()
        {
            dgvClientes.DataSource = _clienteController.ListarDados(Filtrar());
            ModificarEnabledDosBotoes(false);
        }

        private FiltrosClienteModel Filtrar() =>
            new FiltrosClienteModel
            {
                NomePessoa = txtNome.Text.Trim(),
                CidadePessoa = txtCidade.Text.Trim(),
                DataInicio = txtDataInicio.Text,
                DataFim = txtDataFim.Text
            };

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnExcluir.Enabled = enabled;
            btnEditar.Enabled = enabled;
        }

        private void FrmClientes_Load(object sender, EventArgs e) => AtualizarGridDadosCliente();

        private void GvClientes_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            ModificarEnabledDosBotoes(true);
        }

        private void BuscarClienteParaAlterar()
        {
            var cliente = _clienteController.BuscarDado(Convert.ToInt32(gvClientes.GetFocusedRowCellValue("IdPessoa")));

            _clienteController.AbrirTelaDeAlterarECadastrarClientes(cliente);
            AtualizarGridDadosCliente();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!btnEditar.Enabled) return;

            BuscarClienteParaAlterar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

            var result = XtraMessageBox.Show(@"Deseja excluir esse cliente?", @"Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK)) return;

            if (_clienteController.ExcluirDado(Convert.ToInt32(gvClientes.GetFocusedRowCellValue("IdPessoa"))))
                AtualizarGridDadosCliente();
        }

        private void FrmClientes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnCadastrar_Click(sender, e);
                    break;
                case Keys.Enter:
                    BtnFiltrar_Click(sender, e);
                    break;
                case Keys.F10:
                    BtnLimpar_Click(sender, e);
                    break;
                case Keys.F4:
                    BtnEditar_Click(sender, e);
                    break;
                case Keys.Delete:
                    BtnExcluir_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e) => AtualizarGridDadosCliente();

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaFiltros();
            BtnFiltrar_Click(sender, e);
        }

        private void LimpaFiltros()
        {
            txtDataInicio.Text = string.Empty;
            txtDataFim.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtNome.Text = string.Empty;
        }

        private void DgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) txtNome.Focus();
        }
    }
}