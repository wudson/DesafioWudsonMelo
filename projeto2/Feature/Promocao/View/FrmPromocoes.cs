using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPromocoes : Form
    {
        private readonly IList<PromocaoModel> _promocao;

        public FrmPromocoes()
        {
            InitializeComponent();
            _promocao = new List<PromocaoModel>();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var promocao = new FrmCadastroDePromcao().RetornarPromocao();
            if (promocao.Count <= 0) return;
            _promocao.Add(promocao[0]);
            dgvPromocoes.DataSource = null;
            dgvPromocoes.DataSource = _promocao;
            MessageBox.Show(@"Promoção cadastrada com sucesso.");
            MudarCorDoStatus();
        }

        private void MudarCorDoStatus()
        {
            for (var i = 0; i < dgvPromocoes.RowCount; i++)
                dgvPromocoes.Rows[i].Cells["statusPromocao"].Style.ForeColor =
                    dgvPromocoes.Rows[i].Cells["statusPromocao"].Value.ToString().Equals("Ativa")
                        ? Color.Green
                        : Color.Red;
        }
    }
}
