using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Marca.Model;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Marca.View.Dev
{
    public partial class FrmMarcasDev : XtraForm
    {
        private readonly MarcaController _marcaController;
        private readonly MarcaModel _marcaModel;

        public FrmMarcasDev(MarcaController controller)
        {
            InitializeComponent();
            _marcaController = controller;
            _marcaModel = new MarcaModel();
        }

        private void FrmMarcasDev_Load(object sender, EventArgs e)
        {
            ListarMarcas();
            txtMarca.Focus();
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
                case Keys.F4:
                    BtnEditar_Click(sender, e);
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
            _marcaModel.IdMarca = int.Parse(txtId.Text);
            _marcaController.AlterarOuCadastrarMarca(_marcaModel);

            ListarMarcas();
        }

        public void ListarMarcas()
        {
            dgvMarcas.DataSource = _marcaController.ListarMarcas();

            txtMarca.Text = string.Empty;
            txtId.Text = @"0";
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
            var resultado = XtraMessageBox.Show(@"Deseja excluir essa marca?", @"Marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            var idMarca = Convert.ToInt32(gvMarcas.GetFocusedRowCellValue("IdMarca"));

            if (_marcaController.ExcluirMarca(idMarca))
                ListarMarcas();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled == false) return;

            txtId.Text = gvMarcas.GetFocusedRowCellValue("IdMarca").ToString();
            txtMarca.Text = gvMarcas.GetFocusedRowCellValue("Marca").ToString();
        }

        private void GvMarcas_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            ModificarEnabledDosBotoes(true);
        }

        private void DgvMarcas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) txtMarca.Focus();
        }
    }
}
