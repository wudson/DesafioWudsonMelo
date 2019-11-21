using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View.Dev
{
    public partial class FrmPromocoesDev : XtraForm
    {
        private readonly PromocoesController _promocoesController;
        private List<PromocaoModel> _promocoes;

        public FrmPromocoesDev(PromocoesController controller)
        {
            InitializeComponent();
            _promocoesController = controller;
            _promocoes = new List<PromocaoModel>();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            _promocoesController.AbrirTelaCadastroDePromocao();

            AtualizarGridDePromocoes();
        }

        private void AtualizarGridDePromocoes()
        {
            _promocoes = _promocoesController.ListarDados(Filtrar()).ToList();
            dgvPromocoes.DataSource = _promocoes;

            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled) => btnVerProdutos.Enabled = enabled;

        private FiltrosPromocaoModel Filtrar()
        {
            switch ((string)grpFiltroPromocao.EditValue)
            {
                case "A":
                    return new FiltrosPromocaoModel
                    {
                        Ativas = true,
                        Inativas = false
                    };
                case "I":
                    return new FiltrosPromocaoModel
                    {
                        Ativas = false,
                        Inativas = true
                    };
                default:
                    return new FiltrosPromocaoModel();
            }
        }

        private void FrmPromocoes_Load(object sender, EventArgs e) => AtualizarGridDePromocoes();

        private void FrmPromocoes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnAdicionar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void GrpFiltroPromocao_Properties_EditValueChanged(object sender, EventArgs e) => 
            AtualizarGridDePromocoes();

        private void GvPromocao_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName != colStatusPromocao.FieldName) return;

            e.Appearance.ForeColor = "Ativa".Equals(e.CellValue) ? Color.Green : Color.Red;
        }

        private void GvPromocao_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            ModificarEnabledDosBotoes(true);
        }

        private void BtnVerProdutos_Click(object sender, EventArgs e)
        {
            var promocao = _promocoes
                    .Where(p => p.NomePromocao.Equals(gvPromocao.GetFocusedRowCellValue("NomePromocao")))
                    .ToList();

            _promocoesController.AbrirTelaProdutosDaPromocao(promocao);
            AtualizarGridDePromocoes();
        }
    }
}