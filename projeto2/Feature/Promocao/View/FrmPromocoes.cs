using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPromocoes : Form
    {
        private readonly PromocoesController _promocoesController;
        private List<PromocaoModel> _promocoes;

        public FrmPromocoes(PromocoesController controller)
        {
            InitializeComponent();
            _promocoesController = controller;
            _promocoes = new List<PromocaoModel>();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            _promocoesController.AbrirTelaCadastroDePromocao();

            AtualizarGridDePromocoes();
        }

        private void AtualizarGridDePromocoes()
        {
            _promocoes = _promocoesController.ListarDados(Filtrar()).ToList();
            dgvPromocoes.DataSource = _promocoes;
            if (dgvPromocoes.CurrentRow != null) dgvPromocoes.CurrentRow.Selected = false;

            ModificarEnabledDosBotoes(false);
            MudarCorDoStatus();
        }

        private FiltrosPromocaoModel Filtrar()
        {
            if (rdbTodas.Checked) return new FiltrosPromocaoModel();
            return new FiltrosPromocaoModel
            {
                Ativas = rdbAtivas.Checked,
                Inativas = rdbInativas.Checked
            };
        }

        private void ModificarEnabledDosBotoes(bool enabled) => btnEditar.Enabled = enabled;

        private void MudarCorDoStatus()
        {
            for (var i = 0; i < dgvPromocoes.RowCount; i++)
                dgvPromocoes.Rows[i].Cells["statusPromocao"].Style.ForeColor =
                    dgvPromocoes.Rows[i].Cells["statusPromocao"].Value.ToString().Equals("Ativa")
                        ? Color.Green
                        : Color.Red;
        }

        private void FrmPromocoes_Load(object sender, EventArgs e) => AtualizarGridDePromocoes();

        private void DgvPromocoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var promocao = _promocoes
                .Where(p => p.NomePromocao.Equals(dgvPromocoes.CurrentRow?.Cells[0].Value.ToString()))
                .ToList();

            _promocoesController.AbrirTelaProdutosDaPromocao(promocao);
        }

        private void RdbInativas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInativas.Checked)
                AtualizarGridDePromocoes();
        }

        private void RdbAtivas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAtivas.Checked)
                AtualizarGridDePromocoes();
        }

        private void RdbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodas.Checked)
                AtualizarGridDePromocoes();
        }

        private void FrmPromocoes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnAdicionar_Click(sender, e);
                    break;
                case Keys.Escape: 
                    Close();
                    break;
            }
        }
    }
}
