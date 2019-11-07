using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPromocoes : Form
    {
        private IList<PromocaoModel> _promocao;

        public FrmPromocoes()
        {
            InitializeComponent();
            _promocao = new List<PromocaoModel>();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            _promocao = new FrmCadastroDePromcao().RetornarPromocao();
            if (_promocao.Count <= 0) return;
            dgvPromocoes.DataSource = _promocao;
            MessageBox.Show(@"Promoção cadastrada com sucesso.");
        }
    }
}
