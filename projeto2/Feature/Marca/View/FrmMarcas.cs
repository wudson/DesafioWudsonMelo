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

        public FrmMarcas()
        {
            InitializeComponent();
            _marcaController = new MarcaController();
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

            _marcaModel.Marca = txtMarca.Text.Trim();
            _marcaController.CadastrarMarca(_marcaModel);

            ListarMarcas();
        }

        public void ListarMarcas()
        {
            dgvMarcas.DataSource = _marcaController.ListarMarcas();

            txtMarca.Text = string.Empty;
            if (dgvMarcas.CurrentRow != null) dgvMarcas.CurrentRow.Selected = false;
            btnExcluirMarca.Enabled = false;
        }

        private void BtnExcluirMarca_Click(object sender, EventArgs e)
        {

            if (btnExcluirMarca.Enabled == false) return;
            var resultado = MessageBox.Show(@"Deseja excluir essa marca?", @"Marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            if (dgvMarcas.CurrentRow == null) return;
            var idGrupo = Convert.ToInt32(dgvMarcas.CurrentRow.Cells[0].Value);

            if (new MarcaController().ExcluirMarca(idGrupo))
                ListarMarcas();
        }

        private void DgvMarcas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnExcluirMarca.Enabled = true;
        }

        private void FrmMarcas_Load(object sender, EventArgs e) => ListarMarcas();
    }
}
