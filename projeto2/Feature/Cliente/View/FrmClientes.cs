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

        private void BtnCadastrar_Click(object sender, System.EventArgs e)
        {
            new FrmCadastroDeCliente().ShowDialog();
            AtualizarGridDadosCliente();
        }

        private void AtualizarGridDadosCliente()
        {
            var clientes = new ClienteController().BuscarTodosOsDados();
            dgvClientes.DataSource = clientes;
            if (dgvClientes.CurrentRow != null) dgvClientes.CurrentRow.Selected = false;
        }
    }
}