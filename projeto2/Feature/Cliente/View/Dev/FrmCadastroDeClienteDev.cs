using DevExpress.XtraEditors;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Cliente.View.Dev
{
    public partial class FrmCadastroDeClienteDev : XtraForm
    {
        private readonly CadastroDeClienteController _cadastroDeClienteController;
        private ClienteModel _cliente;

        public FrmCadastroDeClienteDev(CadastroDeClienteController controller)
        {
            InitializeComponent();
            _cadastroDeClienteController = controller;
            btnEditar.Visible = false;
            btnSalvarCliente.Visible = true;
        }

        public void RecebeClienteParaAlterar(ClienteModel cliente)
        {
            _cliente = cliente;
            btnEditar.Visible = true;
            btnSalvarCliente.Visible = false;

            ShowDialog();
        }

        private void BtnCancelarCadastroCliente_Click(object sender, EventArgs e) => Close();

        private void BtnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios()) return;

            if (_cadastroDeClienteController.CadastrarDado(AtribuirCamposParaModel(0)))
                Close();
        }

        private ClienteModel AtribuirCamposParaModel(int id) =>
            new ClienteModel
            {
                IdPessoa = id,
                NomePessoa = txtNome.Text.Trim(),
                EmailPessoa = txtEmail.Text.Trim(),
                NascimentoPessoa = DateTime.Parse(txtDataNascimento.Text.Trim()),
                DataCadastroCliente = DateTime.Now.Date,
                DataEdicaoCliente = DateTime.Now.Date,
                SexoPessoa = grpSexo.EditValue.ToString(),
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
                MessageBox.Show(@"Campo 'Nome' obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDataNascimento.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Nascimento' obrigatório.");
                txtDataNascimento.Focus();
                return false;
            }

            if ((string) grpSexo.EditValue != "M" && (string) grpSexo.EditValue != "F")
            {
                MessageBox.Show(@"Campo 'Sexo' obrigatório.");
                grpSexo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'CPF' obrigatório.");
                txtCpf.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'E-mail' obrigatório.");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Celular' obrigatório.");
                txtCelular.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCep.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'CEP' obrigatório.");
                txtCep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEstado.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Estado' obrigatório.");
                txtEstado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Cidade' obrigatório.");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRua.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Rua' obrigatório.");
                txtRua.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtNumero.Text.Trim())) return true;
            MessageBox.Show(@"Campo 'Numero' obrigatório.");
            txtNumero.Focus();
            return false;
        }

        private void FrmCadastroDeCliente_Load(object sender, EventArgs e) => CarregarDadosDoCliente();


        private void CarregarDadosDoCliente()
        {
            if (_cliente == null) return;
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
            grpSexo.EditValue = _cliente.SexoPessoa == "M" ? @"M" : @"F";
        }

        private void FrmCadastroDeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    CadastrarOuAlterar(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void CadastrarOuAlterar(object sender, EventArgs e)
        {
            if (btnSalvarCliente.Visible)
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
                    txtCidade.Properties.Items.Clear();
                    txtCidade.Properties.Items.Add("Jales");
                    txtCidade.Properties.Items.Add("Urânia");
                    break;
                case "Rio de Janeiro":
                    txtCidade.Text = string.Empty;
                    txtCidade.Properties.Items.Clear();
                    txtCidade.Properties.Items.Add("Angra dos reis");
                    txtCidade.Properties.Items.Add("Rio de Janeiro");
                    break;
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios()) return;

            if (_cadastroDeClienteController.AlterarDado(AtribuirCamposParaModel(_cliente.IdPessoa)))
                Close();
        }
    }
}