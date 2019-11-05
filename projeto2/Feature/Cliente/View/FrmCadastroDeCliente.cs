using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Cliente.View
{
    public partial class FrmCadastroDeCliente : Form
    {
        private readonly ClienteController _clienteController;
        private readonly ClienteModel _cliente;
        private int _codigoCliente;

        public FrmCadastroDeCliente(ClienteModel cliente)
        {
            InitializeComponent();
            _clienteController = new ClienteController();
            _cliente = cliente;
            btnAlterar.Visible = true;
            btnSalvarCadastroCliente.Visible = false;
        }

        public FrmCadastroDeCliente()
        {
            InitializeComponent();
            _clienteController = new ClienteController();
            btnAlterar.Visible = false;
            btnSalvarCadastroCliente.Visible = true;
        }

        private void BtnCancelarCadastroCliente_Click(object sender, EventArgs e) => Close();

        private void BtnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios()) return;

            var cliente = AtribuirCamposParaModel();

            if (_clienteController.CadastrarDado(cliente))
                Close();
        }

        private ClienteModel AtribuirCamposParaModel() =>
            new ClienteModel
            {
                IdPessoa = _codigoCliente,
                NomePessoa = txtNome.Text.Trim(),
                EmailPessoa = txtEmail.Text.Trim(),
                NascimentoPessoa = DateTime.Parse(txtDataNascimento.Text.Trim()),
                DataCadastroCliente = DateTime.Now.Date,
                DataEdicaoCliente = DateTime.Now.Date,
                SexoPessoa = RetornarSexoSelecionado(),
                CpfPessoa = txtCpf.Text.Trim(),
                RgPessoa = txtRg.Text.Trim(),
                TelefonePessoa = txtTelefone.Text.Trim(),
                CelularPessoa = txtCelular.Text.Trim(),
                EstadoPessoa = txtEstado.Text.Trim(),
                CidadePessoa = txtCidade.Text.Trim(),
                CepPessoa = txtCep.Text.Trim(),
                RuaPessoa = txtRua.Text.Trim(),
                BairroPessoa = txtBairro.Text.Trim(),
                ComplementoPessoa = txtComplemento.Text.Trim(),
                NumeroPessoa = int.Parse(txtNumero.Text.Trim())
            };

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Nome' obrigatorio.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDataNascimento.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Nascimento' obrigatorio.");
                txtDataNascimento.Focus();
                return false;
            }

            if (!rdbFeminino.Checked && !rdbMasculino.Checked)
            {
                MessageBox.Show(@"Campo 'Sexo' obrigatorio.");
                rdbMasculino.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'CPF' obrigatorio.");
                txtCpf.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'E-mail' obrigatorio.");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Celular' obrigatorio.");
                txtCelular.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCep.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'CEP' obrigatorio.");
                txtCep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEstado.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Estado' obrigatorio.");
                txtEstado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRua.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Rua' obrigatorio.");
                txtRua.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Numero' obrigatorio.");
                txtNumero.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtCidade.Text.Trim())) return true;

            MessageBox.Show(@"Campo 'Cidade' obrigatorio.");
            txtCidade.Focus();
            return false;
        }

        private string RetornarSexoSelecionado() => rdbMasculino.Checked ? "M" : "F";

        private void FrmCadastroDeCliente_Load(object sender, EventArgs e)
        {
            if (_cliente == null) return;
            _codigoCliente = _cliente.IdPessoa;
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
                    CadastrarOuAlterar(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void CadastrarOuAlterar(object sender, EventArgs e)
        {
            if (btnSalvarCadastroCliente.Visible)
                BtnSalvarCadastroCliente_Click(sender, e);
            else
                BtnAlterar_Click(sender, e);
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //if (!ValidarCampos(pnlFormCliente.Controls)) return;
            //if (!ValidarSexo()) return;

            var cliente = AtribuirCamposParaModel();
            if (_clienteController.AlterarDado(cliente))
                Close();
        }
    }
}
