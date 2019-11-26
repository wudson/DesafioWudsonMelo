using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Model;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Grupo.View.Dev
{
    public partial class FrmGruposDev : XtraForm
    {
        private readonly GrupoController _grupoController;
        private readonly GrupoModel _grupoModel;

        public FrmGruposDev(GrupoController controller)
        {
            InitializeComponent();
            _grupoController = controller;
            _grupoModel = new GrupoModel();
        }

        private void FrmGruposDev_Load(object sender, EventArgs e) => ListarGrupos();

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
                case Keys.F4:
                    BtnEditar_Click(sender, e);
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
            _grupoModel.IdGrupo = int.Parse(txtId.Text);
            _grupoController.AlterarOuCadastrarGrupo(_grupoModel);

            ListarGrupos();
        }

        public void ListarGrupos()
        {
            dgvGrupos.DataSource = _grupoController.ListarGrupos();

            txtGrupo.Text = string.Empty;
            txtId.Text = @"0";
            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnExcluirGrupo.Enabled = enabled;
            btnEditar.Enabled = enabled;
        }

        private void BtnExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (btnExcluirGrupo.Enabled == false) return;
            var resultado = XtraMessageBox.Show(@"Deseja excluir essa grupo?", @"grupo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            var idGrupo = Convert.ToInt32(gvGrupos.GetFocusedRowCellValue("IdGrupo"));

            if (_grupoController.ExcluirGrupo(idGrupo))
                ListarGrupos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled == false) return;

            txtId.Text = gvGrupos.GetFocusedRowCellValue("IdGrupo").ToString();
            txtGrupo.Text = gvGrupos.GetFocusedRowCellValue("Grupo").ToString();
        }

        private void GvGrupos_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            ModificarEnabledDosBotoes(true);
        }
    }
}