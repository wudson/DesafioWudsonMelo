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
            if ("adm".Equals(usuario))
            {
                iconErroUsuario.Visible = false;
                iconSucessoUsuario.Visible = true;

                if (!"123".Equals(senha))
                {
                    iconErroSenha.Visible = true;
                    MessageBox.Show(@"Senha incorreta.", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
                else
                {
                    Hide();
                    var principal = new FrmPrincipal();
                    principal.Closed += (s, args) => Close();
                    principal.Show();
                }
            }
            else
            {
                MessageBox.Show(@"Usuario não existe.", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                iconSucessoUsuario.Visible = false;
                iconErroUsuario.Visible = true;
            }
        }

        private void FrmEntrar_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void FrmEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BtnEntrar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}