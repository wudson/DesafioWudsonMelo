using projeto2.Models;
using System;
using System.Windows.Forms;

namespace projeto2
{
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
        }


        private void BtnSalvarCadastroProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                NomeProduto = nomeProduto.Text,
                MarcaProduto = marcaProduto.Text,
                GrupoProduto = grupoProduto.Text,
                FornecedorProduto = fornecedorProduto.Text,
                QuantidadeEstoqueProduto = int.Parse(estoqueProduto.Text),
                ValorCompraProduto = double.Parse(compraProduto.Text),
                ValorVendaProduto = double.Parse(vendaProduto.Text)
            };

            MessageBox.Show(produto.Cadastrar(produto)
                ? "Produto cadastrado com sucesso"
                : "Problema ao cadastrar Produto");

            LimpaCampos(pnlControl.Controls);
        }

        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
