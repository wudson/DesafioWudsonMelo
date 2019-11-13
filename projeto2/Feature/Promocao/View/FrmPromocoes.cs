﻿using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPromocoes : Form
    {
        private readonly PromocoesController _promocoesController;
        private List<PromocaoModel> _promocoes;

        public FrmPromocoes()
        {
            InitializeComponent();
            _promocoesController = new PromocoesController();
            _promocoes = new List<PromocaoModel>();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCadastroDePromcao().ShowDialog();

            AtualizarGridDePromocoes();
        }

        private void AtualizarGridDePromocoes()
        {
            var filtros = Filtrar();

            _promocoes = _promocoesController.ListarDados(filtros).ToList();
            dgvPromocoes.DataSource = _promocoes;
            if (dgvPromocoes.CurrentRow != null) dgvPromocoes.CurrentRow.Selected = false;

            ModificarEnabledDosBotoes(false);
            MudarCorDoStatus();
        }

        private FiltrosPromocaoModel Filtrar()
        {
            if (rdbTodas.Checked) return new FiltrosPromocaoModel();
            return new FiltrosPromocaoModel
            {
                Ativas = rdbAtivas.Checked,
                Inativas = rdbInativas.Checked
            };
        }

        private void ModificarEnabledDosBotoes(bool enabled) => btnEditar.Enabled = enabled;

        private void MudarCorDoStatus()
        {
            for (var i = 0; i < dgvPromocoes.RowCount; i++)
                dgvPromocoes.Rows[i].Cells["statusPromocao"].Style.ForeColor =
                    dgvPromocoes.Rows[i].Cells["statusPromocao"].Value.ToString().Equals("Ativa")
                        ? Color.Green
                        : Color.Red;
        }

        private void FrmPromocoes_Load(object sender, EventArgs e) => AtualizarGridDePromocoes();

        private void DgvPromocoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var promocao = _promocoes
                .Where(p => p.NomePromocao.Equals(dgvPromocoes.CurrentRow?.Cells[0].Value.ToString()))
                .ToList();

            new FrmProdutosDaPromocao(promocao).ShowDialog();
        }

        private void RdbInativas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInativas.Checked)
                AtualizarGridDePromocoes();
        }

        private void RdbAtivas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAtivas.Checked)
                AtualizarGridDePromocoes();
        }

        private void RdbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodas.Checked)
                AtualizarGridDePromocoes();
        }
    }
}
