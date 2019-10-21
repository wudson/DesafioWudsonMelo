using System;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Controller;

namespace projeto2.Feature.Cliente.View
{
    public partial class FrmClientes : Form
    {
        private bool _podeModificar;

        public FrmClientes()
        {
            InitializeComponent();
            new ToolTip().SetToolTip(btnExcluir, "Excluir - [Del]");
            new ToolTip().SetToolTip(btnCadastrar, "Adicionar Cliente - [+]");
            new ToolTip().SetToolTip(btnListar, "Atualizar Lista - [F5]");
            new ToolTip().SetToolTip(btnEditar, "Editar - [F4]");
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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            AtualizarGridDadosCliente();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            AtualizarGridDadosCliente();
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarEnabledDosBotoes(true);
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
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
            if(new ClienteController().ExcluirDado(idClienteLinhaAtual))
                AtualizarGridDadosCliente();
        }

        private void FrmClientes_KeyDown(object sender, KeyEventArgs e)
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
                case Keys.Delete:
                    BtnExcluir_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}