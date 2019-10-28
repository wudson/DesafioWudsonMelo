using System;
using System.Windows.Forms;
using projeto2.Feature.Marca.Controller;

namespace projeto2.Feature.Marca.View
{
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
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
            var novaMarca = txtMarca.Text.Trim();
            new MarcaController().CadastrarMarca(novaMarca);

            ListarMarcas();
        }

        public void ListarMarcas()
        {
            var grupos = new MarcaController().ListarMarcas();
            dgvMarcas.DataSource = grupos;

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

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            ListarMarcas();
        }
    }
}
