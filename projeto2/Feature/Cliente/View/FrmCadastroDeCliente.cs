using System;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Controller;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Cliente.View
{
    public partial class FrmCadastroDeCliente : Form
    {
        public FrmCadastroDeCliente()
        {
            InitializeComponent();
        }

        private void BtnCancelarCadastroCliente_Click(object sender, EventArgs e) => Close();

        private void BtnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel
            {
                IdPessoa = int.Parse(txtIdPessoa.Text),
                NomePessoa = txtNome.Text,
                EmailPessoa = txtEmail.Text,
                NascimentoPessoa = DateTime.Parse(txtDataCadastro.Text),
                DataCadastroCliente = DateTime.Now.Date,
                SexoPessoa = RetornarSexoSelecionado(),
                CpfPessoa = txtCpf.Text,
                RgPessoa = txtRg.Text,
                TelefonePessoa = txtTelefone.Text
            };

            if (cliente.IdPessoa >= 1)
            {
                MessageBox.Show(new ClienteController().AlterarDado(cliente)
                    ? "Cliente alterado com sucesso"
                    : "Problema ao alterar cliente");

                Close();
            }
            else
            {
                MessageBox.Show(new ClienteController().CadastrarDado(cliente)
                    ? "Cliente cadastrado com sucesso"
                    : "Problema ao cadastrar cliente");

                Close();
                //LimpaCampos(pnlControl.Controls);
            }
        }

        private string RetornarSexoSelecionado()
        {
            return rdbMasculino.Checked ? "M" : "F";
        }
    }
}
