using System;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Controller;

namespace projeto2.Feature.Cliente.View
{
    public partial class FrmClientes : Form
    {
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

            DesativarBotoes();
        }

        private void DesativarBotoes()
        {
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
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
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
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
            var idClienteLinhaAtual = int.Parse(dgvClientes.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            var cliente = new ClienteController().BuscarDado(idClienteLinhaAtual);

            new FrmCadastroDeCliente(cliente).ShowDialog();
            AtualizarGridDadosCliente();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Deseja excluir esse cliente?", @"Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK)) return;

            var idClienteLinhaAtual = int.Parse(dgvClientes.CurrentRow?.Cells[0].Value.ToString() ?? throw new InvalidOperationException());
            MessageBox.Show(new ClienteController().ExcluirDado(idClienteLinhaAtual)
                ? @"Cliente excluido com sucesso!"
                : @"Problemas ao excluir cliente!");
            AtualizarGridDadosCliente();
        }
    }
}