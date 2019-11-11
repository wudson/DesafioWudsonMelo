using projeto2.Feature.Promocao.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPromocoes : Form
    {
        private readonly PromocoesController _promocoesController;

        public FrmPromocoes()
        {
            InitializeComponent();
            _promocoesController = new PromocoesController();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCadastroDePromcao().ShowDialog();

            AtualizarGridDePromocoes();
            
        }

        private void AtualizarGridDePromocoes()
        {
            dgvPromocoes.DataSource = _promocoesController.ListarDados();
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
    }
}
