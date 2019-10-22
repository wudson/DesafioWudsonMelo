using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;

namespace projeto2.Feature.Cliente.View
{
    public partial class FrmCadastroDeCliente : Form
    {
        private readonly ClienteModel _cliente;

        public FrmCadastroDeCliente(ClienteModel cliente)
        {
            InitializeComponent();
            _cliente = cliente;
        }

        public FrmCadastroDeCliente()
        {
            InitializeComponent();
        }

        private void BtnCancelarCadastroCliente_Click(object sender, EventArgs e) => Close();

        private void BtnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(pnlFormCliente.Controls)) return;
            if (!ValidarSexo()) return;

            var cliente = new ClienteModel
            {
                IdPessoa = int.Parse(txtIdPessoa.Text),
                NomePessoa = txtNome.Text,
                EmailPessoa = txtEmail.Text,
                NascimentoPessoa = DateTime.Parse(txtDataNascimento.Text),
                DataCadastroCliente = DateTime.Now.Date,
                SexoPessoa = RetornarSexoSelecionado(),
                CpfPessoa = txtCpf.Text,
                RgPessoa = txtRg.Text,
                TelefonePessoa = txtTelefone.Text,
                CelularPessoa = txtCelular.Text,
                EstadoPessoa = txtEstado.Text,
                CidadePessoa = txtCidade.Text,
                CepPessoa = txtCep.Text,
                RuaPessoa = txtRua.Text,
                BairroPessoa = txtBairro.Text,
                ComplementoPessoa = txtComplemento.Text,
                NumeroPessoa = int.Parse(txtNumero.Text)
            };

            CadastrarOuAlterar(cliente);
        }

        public bool ValidarCampos(Control.ControlCollection controles)
        {
            if (!(from Control controle in controles from Control item in controle.Controls select item).Any(item =>
                string.IsNullOrWhiteSpace(item.Text))) return true;
            MessageBox.Show(@"Porfavor preencha todos os campos", @"Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;

        }

        private bool ValidarSexo()
        {
            if (rdbFeminino.Checked || rdbMasculino.Checked) return true;
            MessageBox.Show(@"Porfavor preencha todos os campos", @"Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private string RetornarSexoSelecionado()
        {
            return rdbMasculino.Checked ? "M" : "F";
        }

        private void CadastrarOuAlterar(ClienteModel cliente)
        {
            if (cliente.IdPessoa >= 1)
            {
                if (new ClienteController().AlterarDado(cliente))
                    Close();
            }
            else
            {
                if (new ClienteController().CadastrarDado(cliente))
                    Close();
            }
        }

        private void FrmCadastroDeCliente_Load(object sender, EventArgs e)
        {
            if (_cliente == null) return;
            txtIdPessoa.Text = _cliente.IdPessoa.ToString();
            txtNome.Text = _cliente.NomePessoa;
            txtEmail.Text = _cliente.EmailPessoa;
            txtDataNascimento.Text = _cliente.NascimentoPessoa.ToShortDateString();
            txtRg.Text = _cliente.RgPessoa;
            txtCpf.Text = _cliente.CpfPessoa;
            txtTelefone.Text = _cliente.TelefonePessoa;
            txtCelular.Text = _cliente.CelularPessoa;
            txtEstado.Text = _cliente.EstadoPessoa;
            txtCidade.Text = _cliente.CidadePessoa;
            txtCep.Text = _cliente.CepPessoa;
            txtRua.Text = _cliente.RuaPessoa;
            txtBairro.Text = _cliente.BairroPessoa;
            txtComplemento.Text = _cliente.ComplementoPessoa;
            txtNumero.Text = _cliente.NumeroPessoa.ToString();
            if (_cliente.SexoPessoa == "M")
                rdbMasculino.Checked = true;
            else
                rdbFeminino.Checked = true;

        }

        private void FrmCadastroDeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BtnSalvarCadastroCliente_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void TxtEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (txtEstado.SelectedItem.ToString())
            {
                case "São Paulo":
                    txtCidade.Text = string.Empty;
                    txtCidade.Items.Clear();
                    txtCidade.Items.Add("Jales");
                    txtCidade.Items.Add("Urânia");
                    break;
                case "Rio de Janeiro":
                    txtCidade.Text = string.Empty;
                    txtCidade.Items.Clear();
                    txtCidade.Items.Add("Angra dos reis");
                    txtCidade.Items.Add("Rio de Janeiro");
                    break;
            }
        }
    }
}
