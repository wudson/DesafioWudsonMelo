using DevExpress.XtraEditors;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

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
        }

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

        //private void DgvPromocoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    var promocao = _promocoes
        //        .Where(p => p.NomePromocao.Equals(dgvPromocoes.CurrentRow?.Cells[0].Value.ToString()))
        //        .ToList();

        //    _promocoesController.AbrirTelaProdutosDaPromocao(promocao);
        //}

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

        private void gvPromocao_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName != colStatusPromocao.FieldName) return;

            e.Appearance.ForeColor = "Ativa".Equals(e.CellValue) ? Color.Green : Color.Red;
        }
    }
}