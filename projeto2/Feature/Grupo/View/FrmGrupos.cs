using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Model;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Grupo.View
{
    public partial class FrmGrupos : Form
    {
        private readonly GrupoController _grupoController;
        private readonly GrupoModel _grupoModel;

        public FrmGrupos(GrupoController controller)
        {
            InitializeComponent();
            _grupoController = controller;
            _grupoModel = new GrupoModel();
        }

        private void FrmGrupos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    BtnSalvarGrupo_Click(sender, e);
                    break;
                case Keys.Delete:
                    BtnExcluirGrupo_Click(sender, e);
                    break;
            }
        }

        private void BtnSalvarGrupo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrupo.Text)) return;

            _grupoModel.Grupo = txtGrupo.Text.Trim();
            _grupoController.CadastrarGrupo(_grupoModel);

            ListarGrupos();
        }

        public void ListarGrupos()
        {
            dgvGrupo.DataSource = _grupoController.ListarGrupos();

            txtGrupo.Text = string.Empty;
            if (dgvGrupo.CurrentRow != null) dgvGrupo.CurrentRow.Selected = false;
            btnExcluirGrupo.Enabled = false;
        }

        private void DgvGrupo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnExcluirGrupo.Enabled = true;
        }

        private void BtnExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (btnExcluirGrupo.Enabled == false) return;
            var resultado = MessageBox.Show(@"Deseja excluir esse grupo?", @"Grupo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            if (dgvGrupo.CurrentRow == null) return;
            var idGrupo = Convert.ToInt32(dgvGrupo.CurrentRow.Cells[0].Value);

            if (_grupoController.ExcluirGrupo(idGrupo))
                ListarGrupos();
        }

        private void FrmGrupos_Load(object sender, EventArgs e) =>
            ListarGrupos();
    }
}
