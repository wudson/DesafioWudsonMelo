using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Cliente.View
{
    public partial class FrmClientes : Form
    {
        private readonly ClienteController _clienteController;

        public FrmClientes(ClienteController controller)
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
            if (dgvClientes.CurrentRow != null) dgvClientes.CurrentRow.Selected = false;

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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            txtCidade.Items.Clear();
            txtCidade.Items.Add("Jales");
            txtCidade.Items.Add("Urânia");
            txtCidade.Items.Add("Angra dos reis");
            txtCidade.Items.Add("Rio de Janeiro");
            AtualizarGridDadosCliente();
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ModificarEnabledDosBotoes(true);
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            BuscarClienteParaAlterar();
        }

        private void BuscarClienteParaAlterar()
        {
            var cliente = _clienteController.BuscarDado(int.Parse(dgvClientes.CurrentRow?.Cells[0].Value.ToString() ?? "-1"));

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

            var result = MessageBox.Show(@"Deseja excluir esse cliente?", @"Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK)) return;

            if (_clienteController.ExcluirDado(int.Parse(dgvClientes.CurrentRow?.Cells[0].Value.ToString() ?? "-1")))
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
                case Keys.R:
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

        private void TxtDataInicio_ValueChanged(object sender, EventArgs e)
        {
            if (txtDataInicio.Text == @" ")
                txtDataInicio.Format = DateTimePickerFormat.Short;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtDataInicio.Format = DateTimePickerFormat.Custom;
            txtDataInicio.CustomFormat = @" ";
            txtDataFim.Format = DateTimePickerFormat.Custom;
            txtDataFim.CustomFormat = @" ";
            txtCidade.Text = string.Empty;
            txtNome.Text = string.Empty;
            BtnFiltrar_Click(sender, e);
        }

        private void TxtDataFim_ValueChanged(object sender, EventArgs e)
        {
            if (txtDataFim.Text == @" ")
                txtDataFim.Format = DateTimePickerFormat.Short;
        }
    }
}