using System;
using System.Windows.Forms;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Marca.View
{
    public partial class FrmMarcas : Form
    {
        private readonly MarcaController _marcaController;
        private readonly MarcaModel _marcaModel;

        public FrmMarcas(MarcaController controller)
        {
            InitializeComponent();
            _marcaController = controller;
            _marcaModel = new MarcaModel();
        }

        private void FrmMarcas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    BtnSalvarMarca_Click(sender, e);
                    break;
                case Keys.Delete:
                    BtnExcluirMarca_Click(sender, e);
                    break;
            }
        }

        private void BtnSalvarMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text)) return;

            if (int.Parse(txtId.Text) > 0)
            {
                _marcaModel.Marca = txtMarca.Text.Trim();
                _marcaModel.IdMarca = int.Parse(txtId.Text);
                _marcaController.AlterarMarca(_marcaModel);
            }
            else
            {
                _marcaModel.Marca = txtMarca.Text.Trim();
                _marcaController.CadastrarMarca(_marcaModel);
            }

            ListarMarcas();
        }

        public void ListarMarcas()
        {
            dgvMarcas.DataSource = _marcaController.ListarMarcas();

            txtMarca.Text = string.Empty;
            txtId.Text = @"0";
            if (dgvMarcas.CurrentRow != null) dgvMarcas.CurrentRow.Selected = false;
            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnExcluirMarca.Enabled = enabled;
            btnEditar.Enabled = enabled;
        }

        private void BtnExcluirMarca_Click(object sender, EventArgs e)
        {

            if (btnExcluirMarca.Enabled == false) return;
            var resultado = MessageBox.Show(@"Deseja excluir essa marca?", @"Marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            if (dgvMarcas.CurrentRow == null) return;
            var idGrupo = Convert.ToInt32(dgvMarcas.CurrentRow.Cells[0].Value);

            if (_marcaController.ExcluirMarca(idGrupo))
                ListarMarcas();
        }

        private void DgvMarcas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ModificarEnabledDosBotoes(true);
        }

        private void FrmMarcas_Load(object sender, EventArgs e) => ListarMarcas();

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled == false) return;

            txtMarca.Text = dgvMarcas.CurrentRow?.Cells[1].Value.ToString();
            txtId.Text = dgvMarcas.CurrentRow?.Cells[0].Value.ToString();
        }
    }
}
