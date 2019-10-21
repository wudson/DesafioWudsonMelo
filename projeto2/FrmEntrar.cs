using System;
using System.Windows.Forms;

namespace projeto2
{
    public partial class FrmEntrar : Form
    {
        public FrmEntrar()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var senha = txtSenha.Text;
            if ("adm".Equals(usuario) && "123".Equals(senha))
            {
                Hide();
                var principal = new FrmPrincipal();
                principal.Closed += (s, args) => Close();
                principal.Show();
            }
            else
            {
                MessageBox.Show(@"Usuario ou senha incorretos.");
            }
        }

        private void FrmEntrar_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}