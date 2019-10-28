using System;
using System.Windows.Forms;
using projeto2.Feature.Grupo.Controller;

namespace projeto2.Feature.Grupo.View
{
    public partial class FrmGrupos : Form
    {
        public FrmGrupos()
        {
            InitializeComponent();
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
            var novoGrupo = txtGrupo.Text.Trim();
            new GrupoController().CadastrarGrupo(novoGrupo);

            ListarGrupos();
        }

        public void ListarGrupos()
        {
            var grupos = new GrupoController().ListarGrupos();
            dgvGrupo.DataSource = grupos;

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

            if (new GrupoController().ExcluirGrupo(idGrupo))
                ListarGrupos();
        }

        private void FrmGrupos_Load(object sender, EventArgs e)
        {
            ListarGrupos();
        }
    }
}
