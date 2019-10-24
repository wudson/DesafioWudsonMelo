using System;
using System.Windows.Forms;

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
                    BtnSalvarGrupo_Click(sender,e);
                    break;
                case Keys.Delete:
                    BtnExcluirGrupo_Click(sender,e);
                    break;
            }
        }

        private void BtnSalvarGrupo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrupo.Text)) return;
            var cod = dgvGrupo.RowCount + 1;
            dgvGrupo.Rows.Add(cod, txtGrupo.Text);
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
            btnExcluirGrupo.Enabled = false;
            if (dgvGrupo.CurrentRow == null) return;
            dgvGrupo.Rows.Remove(dgvGrupo.CurrentRow);
            if (dgvGrupo.CurrentRow != null) dgvGrupo.CurrentRow.Selected = false;
        }
    }
}
