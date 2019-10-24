using System;
using System.Collections.Generic;
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
            if (txtGrupo.Text == string.Empty) return;
            var cod = dgvGrupo.RowCount + 1;
            dgvGrupo.Rows.Add(cod, txtGrupo.Text);
            txtGrupo.Text = string.Empty;
            if (dgvGrupo.CurrentRow != null) dgvGrupo.CurrentRow.Selected = false;
        }

        private void DgvGrupo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnExcluirGrupo.Enabled = true;
        }

        private void BtnExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (btnExcluirGrupo.Enabled == false) return;
            btnExcluirGrupo.Enabled = false;
            if (dgvGrupo.CurrentRow == null) return;
            dgvGrupo.Rows.Remove(dgvGrupo.CurrentRow);
            if (dgvGrupo.CurrentRow != null) dgvGrupo.CurrentRow.Selected = false;
        }
    }
}
