namespace projeto2.Feature.Promocao.View.Dev
{
    partial class FrmSelecionarProdutosParaPromocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarProdutosParaPromocao));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.grpTipoFiltro = new DevExpress.XtraEditors.RadioGroup();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarSelecionados = new DevExpress.XtraEditors.SimpleButton();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProdutosPromocao = new DevExpress.XtraGrid.GridControl();
            this.gvProdutosPromocao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCompraProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorVendaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lstDeProdutos = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipoFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDeProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBuscar);
            this.groupControl1.Controls.Add(this.grpTipoFiltro);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(258, 105);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Burcar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 69);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(233, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // grpTipoFiltro
            // 
            this.grpTipoFiltro.Location = new System.Drawing.Point(5, 30);
            this.grpTipoFiltro.Name = "grpTipoFiltro";
            this.grpTipoFiltro.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grpTipoFiltro.Properties.Appearance.Options.UseBackColor = true;
            this.grpTipoFiltro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grpTipoFiltro.Properties.Columns = 3;
            this.grpTipoFiltro.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Produto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("G", "Grupo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Marca")});
            this.grpTipoFiltro.Properties.EditValueChanged += new System.EventHandler(this.GrpTipoFiltro_Properties_EditValueChanged);
            this.grpTipoFiltro.Size = new System.Drawing.Size(253, 33);
            this.grpTipoFiltro.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.ImageOptions.Image = global::projeto2.Properties.Resources.apply_32x32;
            this.btnSalvar.Location = new System.Drawing.Point(643, 441);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 57);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar [Enter]";
            this.btnSalvar.Click += new System.EventHandler(this.BtnProdutosSelecionados_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x32;
            this.btnCancelar.Location = new System.Drawing.Point(768, 441);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 57);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar [Esc]";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Appearance.Options.UseBackColor = true;
            this.btnLimpar.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x321;
            this.btnLimpar.Location = new System.Drawing.Point(730, 74);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 43);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar produtos [ F10 ]";
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnAdicionarSelecionados
            // 
            this.btnAdicionarSelecionados.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAdicionarSelecionados.Appearance.Options.UseBackColor = true;
            this.btnAdicionarSelecionados.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x321;
            this.btnAdicionarSelecionados.Location = new System.Drawing.Point(276, 74);
            this.btnAdicionarSelecionados.Name = "btnAdicionarSelecionados";
            this.btnAdicionarSelecionados.Size = new System.Drawing.Size(177, 43);
            this.btnAdicionarSelecionados.TabIndex = 14;
            this.btnAdicionarSelecionados.Text = "Adicionar selecionados [ + ]";
            this.btnAdicionarSelecionados.Click += new System.EventHandler(this.BtnAdicionarProdutosSelecionadosNaPromocao_Click);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // dgvProdutosPromocao
            // 
            this.dgvProdutosPromocao.DataSource = this.produtoBindingSource;
            this.dgvProdutosPromocao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvProdutosPromocao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvProdutosPromocao.Location = new System.Drawing.Point(276, 123);
            this.dgvProdutosPromocao.MainView = this.gvProdutosPromocao;
            this.dgvProdutosPromocao.Name = "dgvProdutosPromocao";
            this.dgvProdutosPromocao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvProdutosPromocao.Size = new System.Drawing.Size(625, 312);
            this.dgvProdutosPromocao.TabIndex = 27;
            this.dgvProdutosPromocao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutosPromocao});
            this.dgvProdutosPromocao.DataSourceChanged += new System.EventHandler(this.DgvProdutosPromocao_DataSourceChanged);
            // 
            // gvProdutosPromocao
            // 
            this.gvProdutosPromocao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvProdutosPromocao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomeProduto,
            this.colValorCompraProduto,
            this.colValorVendaProduto});
            this.gvProdutosPromocao.GridControl = this.dgvProdutosPromocao;
            this.gvProdutosPromocao.GroupPanelText = " ";
            this.gvProdutosPromocao.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvProdutosPromocao.Name = "gvProdutosPromocao";
            this.gvProdutosPromocao.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvProdutosPromocao.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvProdutosPromocao.OptionsDetail.EnableMasterViewMode = false;
            this.gvProdutosPromocao.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvProdutosPromocao.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvProdutosPromocao.OptionsPrint.PrintVertLines = false;
            this.gvProdutosPromocao.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvProdutosPromocao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutosPromocao.OptionsView.ShowFooter = true;
            this.gvProdutosPromocao.OptionsView.ShowIndicator = false;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.Caption = "Produto";
            this.colNomeProduto.FieldName = "NomeProduto";
            this.colNomeProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNomeProduto.ImageOptions.Image")));
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.OptionsColumn.AllowEdit = false;
            this.colNomeProduto.OptionsColumn.AllowFocus = false;
            this.colNomeProduto.OptionsFilter.AllowAutoFilter = false;
            this.colNomeProduto.OptionsFilter.AllowFilter = false;
            this.colNomeProduto.Visible = true;
            this.colNomeProduto.VisibleIndex = 0;
            this.colNomeProduto.Width = 393;
            // 
            // colValorCompraProduto
            // 
            this.colValorCompraProduto.Caption = "Compra";
            this.colValorCompraProduto.DisplayFormat.FormatString = "c2";
            this.colValorCompraProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorCompraProduto.FieldName = "ValorCompraProduto";
            this.colValorCompraProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colValorCompraProduto.ImageOptions.Image")));
            this.colValorCompraProduto.Name = "colValorCompraProduto";
            this.colValorCompraProduto.OptionsColumn.AllowEdit = false;
            this.colValorCompraProduto.OptionsColumn.AllowFocus = false;
            this.colValorCompraProduto.OptionsColumn.FixedWidth = true;
            this.colValorCompraProduto.OptionsFilter.AllowAutoFilter = false;
            this.colValorCompraProduto.OptionsFilter.AllowFilter = false;
            this.colValorCompraProduto.Visible = true;
            this.colValorCompraProduto.VisibleIndex = 1;
            this.colValorCompraProduto.Width = 128;
            // 
            // colValorVendaProduto
            // 
            this.colValorVendaProduto.Caption = "Venda";
            this.colValorVendaProduto.DisplayFormat.FormatString = "c2";
            this.colValorVendaProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorVendaProduto.FieldName = "ValorVendaProduto";
            this.colValorVendaProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colValorVendaProduto.ImageOptions.Image")));
            this.colValorVendaProduto.Name = "colValorVendaProduto";
            this.colValorVendaProduto.OptionsColumn.AllowEdit = false;
            this.colValorVendaProduto.OptionsColumn.AllowFocus = false;
            this.colValorVendaProduto.OptionsColumn.FixedWidth = true;
            this.colValorVendaProduto.OptionsFilter.AllowAutoFilter = false;
            this.colValorVendaProduto.OptionsFilter.AllowFilter = false;
            this.colValorVendaProduto.Visible = true;
            this.colValorVendaProduto.VisibleIndex = 2;
            this.colValorVendaProduto.Width = 126;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")});
            this.repositoryItemLookUpEdit1.DisplayMember = "ProductName";
            this.repositoryItemLookUpEdit1.DropDownRows = 10;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 220;
            this.repositoryItemLookUpEdit1.ValueMember = "ProductID";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Mask.EditMask = "c";
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "p";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // lstDeProdutos
            // 
            this.lstDeProdutos.DataSource = this.produtoBindingSource;
            this.lstDeProdutos.DisplayMember = "NomeProduto";
            this.lstDeProdutos.Location = new System.Drawing.Point(12, 123);
            this.lstDeProdutos.Name = "lstDeProdutos";
            this.lstDeProdutos.Size = new System.Drawing.Size(258, 375);
            this.lstDeProdutos.TabIndex = 28;
            this.lstDeProdutos.ValueMember = "IdProduto";
            // 
            // FrmSelecionarProdutosParaPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 510);
            this.Controls.Add(this.lstDeProdutos);
            this.Controls.Add(this.dgvProdutosPromocao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionarSelecionados);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmSelecionarProdutosParaPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar produtos";
            this.Load += new System.EventHandler(this.FrmProdutosDaPromocaoComDesconto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutosDaPromocaoComDesconto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipoFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDeProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup grpTipoFiltro;
        private DevExpress.XtraEditors.TextEdit txtBuscar;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarSelecionados;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraGrid.GridControl dgvProdutosPromocao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutosPromocao;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCompraProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorVendaProduto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.CheckedListBoxControl lstDeProdutos;
    }
}