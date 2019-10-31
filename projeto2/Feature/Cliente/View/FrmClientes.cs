using System;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;

namespace projeto2.Feature.Cliente.View
{
    public partial class FrmClientes : Form
    {
        private bool _podeModificar;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            new FrmCadastroDeCliente().ShowDialog();
            AtualizarGridDadosCliente();
        }

        private void AtualizarGridDadosCliente()
        {
            var clientes = new ClienteController().BuscarTodosOsDados();
            dgvClientes.DataSource = clientes;
            if (dgvClientes.CurrentRow != null) dgvClientes.CurrentRow.Selected = false;
            _podeModificar = true;
            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            if (!_podeModificar) return;

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
            var idClienteLinhaAtual = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            var cliente = new ClienteController().BuscarDado(idClienteLinhaAtual);

            new FrmCadastroDeCliente(cliente).ShowDialog();
            AtualizarGridDadosCliente();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!btnEditar.Enabled) return;

            var idClienteLinhaAtual = int.Parse(dgvClientes.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            var cliente = new ClienteController().BuscarDado(idClienteLinhaAtual);

            new FrmCadastroDeCliente(cliente).ShowDialog();
            AtualizarGridDadosCliente();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

            var result = MessageBox.Show(@"Deseja excluir esse cliente?", @"Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK)) return;

            var idClienteLinhaAtual = int.Parse(dgvClientes.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            if (new ClienteController().ExcluirDado(idClienteLinhaAtual))
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

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) && string.IsNullOrWhiteSpace(txtCidade.Text) &&
                string.IsNullOrWhiteSpace(txtDataInicio.Text) && string.IsNullOrWhiteSpace(txtDataFim.Text))
            {
                FrmClientes_Load(sender, e);
                return;
            }

            var filtros = Filtrar();
            dgvClientes.DataSource = new ClienteController().BuscarDadosComFiltros(filtros);
        }

        private FiltrosClienteModel Filtrar() =>
            new FiltrosClienteModel
            {
                NomePessoa = txtNome.Text.Trim(),
                CidadePessoa = txtCidade.Text.Trim(),
                DataInicio = txtDataInicio.Text,
                DataFim = txtDataFim.Text
            };

        private void TxtDataInicio_ValueChanged(object sender, EventArgs e)
        {
            if (txtDataInicio.Text == @" ")
            {
                txtDataInicio.Format = DateTimePickerFormat.Short;
            }
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
            {
                txtDataFim.Format = DateTimePickerFormat.Short;
            }
        }
    }
}