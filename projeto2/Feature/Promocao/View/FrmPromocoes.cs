using projeto2.Feature.Promocao.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPromocoes : Form
    {
        private readonly PromocoesController _promocoesController;
        private List<PromocaoModel> _promocoes;

        public FrmPromocoes()
        {
            InitializeComponent();
            _promocoesController = new PromocoesController();
            _promocoes = new List<PromocaoModel>();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCadastroDePromcao().ShowDialog();
            
            AtualizarGridDePromocoes();
            
        }

        private void AtualizarGridDePromocoes()
        {
            _promocoes = _promocoesController.ListarDados().ToList();
            dgvPromocoes.DataSource = _promocoes;
            if (dgvPromocoes.CurrentRow != null) dgvPromocoes.CurrentRow.Selected = false;

            ModificarEnabledDosBotoes(false);
            MudarCorDoStatus();
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnEditar.Enabled = enabled;
        }

        private void MudarCorDoStatus()
        {
            for (var i = 0; i < dgvPromocoes.RowCount; i++)
                dgvPromocoes.Rows[i].Cells["statusPromocao"].Style.ForeColor =
                    dgvPromocoes.Rows[i].Cells["statusPromocao"].Value.ToString().Equals("Ativa")
                        ? Color.Green
                        : Color.Red;
        }

        private void FrmPromocoes_Load(object sender, EventArgs e)
        {
            AtualizarGridDePromocoes();
        }

        private void DgvPromocoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var promocao = _promocoes
                .Where(p => p.NomePromocao.Equals(dgvPromocoes.CurrentRow?.Cells[0].Value.ToString()))
                .ToList();

            new FrmProdutosDaPromocao(promocao).ShowDialog();
        }
    }
}
