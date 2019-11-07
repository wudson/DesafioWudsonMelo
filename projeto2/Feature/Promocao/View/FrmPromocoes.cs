using System;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPromocoes : Form
    {
        public FrmPromocoes()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCadastroDePromcao().ShowDialog();
        }
    }
}
