﻿using System.Windows.Forms;

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

        private void BtnSalvarMarca_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text)) return;
            var cod = dgvMarcas.RowCount + 1;
            dgvMarcas.Rows.Add(cod, txtMarca.Text.Trim());
            txtMarca.Text = string.Empty;
            if (dgvMarcas.CurrentRow != null) dgvMarcas.CurrentRow.Selected = false;
            btnExcluirMarca.Enabled = false;
        }

        private void BtnExcluirMarca_Click(object sender, System.EventArgs e)
        {

            if (btnExcluirMarca.Enabled == false) return;
            var resultado = MessageBox.Show(@"Deseja excluir essa marca?", @"Marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;
            btnExcluirMarca.Enabled = false;
            if (dgvMarcas.CurrentRow == null) return;
            dgvMarcas.Rows.Remove(dgvMarcas.CurrentRow);
            if (dgvMarcas.CurrentRow != null) dgvMarcas.CurrentRow.Selected = false;
        }

        private void DgvMarcas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnExcluirMarca.Enabled = true;
        }
    }
}
