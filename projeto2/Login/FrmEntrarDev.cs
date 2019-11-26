﻿using projeto2.Feature.Principal.View.Dev;
using projeto2.Feature.Principal.View.WinForms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace projeto2.Login
{
    public partial class FrmEntrarDev : DevExpress.XtraEditors.XtraForm
    {
        public FrmEntrarDev() => InitializeComponent();

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
                    txtSenha.Focus();
                    iconErroSenha.Visible = true;
                    MessageBox.Show(@"Senha incorreta.", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
                else
                {
                    if (!ClasseComVariaveisGlobais.UsarDev)
                    {
                        Hide();
                        var principal = new FrmPrincipal();
                        principal.Closed += (s, args) => Close();
                        principal.Show();
                    }
                    else
                    {
                        Hide();
                        var principal = new FrmPrincipalDev();
                        principal.Closed += (s, args) => Close();
                        principal.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Usuario não encontrado.", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                iconSucessoUsuario.Visible = false;
                iconErroUsuario.Visible = true;
            }
        }

        private void FrmEntrar_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        [DebuggerStepThrough]
        private void FrmEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    BtnEntrar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if ("adm".Equals(txtUsuario.Text))
            {
                iconErroUsuario.Visible = false;
                iconSucessoUsuario.Visible = true;
            }
            else
            {
                iconSucessoUsuario.Visible = false;
                iconErroUsuario.Visible = true;
            }
        }
    }
}