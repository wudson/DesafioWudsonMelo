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
                TelefonePessoa = txtTelefone.Text
            };

            CadastrarOuAlterar(cliente);
        }

        private bool ValidarCampos(IEnumerable controles)
        {
            if (!controles.Cast<Control>().Any(item => string.IsNullOrWhiteSpace(item.Text))) return ValidarSexo();
            MessageBox.Show(@"Porfavor preencha todos os campos", @"Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return ValidarSexo();
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
            if(_cliente.SexoPessoa == "M")
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
    }
}
