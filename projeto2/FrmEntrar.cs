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
            Hide();
            var principal = new FrmPrincipal();
            principal.Closed += (s, args) => Close();
            principal.Show();
        }
    }
}