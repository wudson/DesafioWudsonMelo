namespace projeto2.Feature.Pedido.View.Dev
{
    partial class FrmNovoPedidoDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoPedidoDev));
            this.dgvProdutos = new DevExpress.XtraGrid.GridControl();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorVendaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorComDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeProdutoPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lstProdutos = new DevExpress.XtraGrid.GridControl();
            this.lsProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProduto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorVendaProduto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorComDesconto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeProdutoPedido1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAdicionarSelecionados = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.grpTipoFiltro = new DevExpress.XtraEditors.RadioGroup();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.clienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipoFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.DataSource = this.produtoBindingSource;
            this.dgvProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvProdutos.Location = new System.Drawing.Point(345, 93);
            this.dgvProdutos.MainView = this.gvProdutos;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit3});
            this.dgvProdutos.Size = new System.Drawing.Size(1018, 425);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutos});
            this.dgvProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvProdutos_KeyDown);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // gvProdutos
            // 
            this.gvProdutos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gvProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto,
            this.colNomeProduto,
            this.colValorVendaProduto,
            this.colValorComDesconto,
            this.colQuantidadeProdutoPedido,
            this.coltotal});
            this.gvProdutos.GridControl = this.dgvProdutos;
            this.gvProdutos.GroupPanelText = " ";
            this.gvProdutos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvProdutos.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvProdutos.OptionsDetail.EnableMasterViewMode = false;
            this.gvProdutos.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvProdutos.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvProdutos.OptionsPrint.PrintVertLines = false;
            this.gvProdutos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutos.OptionsView.ShowFooter = true;
            this.gvProdutos.OptionsView.ShowIndicator = false;
            this.gvProdutos.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GvProdutos_CustomDrawCell);
            // 
            // colIdProduto
            // 
            this.colIdProduto.Caption = "Código";
            this.colIdProduto.FieldName = "IdProduto";
            this.colIdProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIdProduto.ImageOptions.Image")));
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.OptionsColumn.AllowEdit = false;
            this.colIdProduto.OptionsColumn.AllowFocus = false;
            this.colIdProduto.OptionsFilter.AllowAutoFilter = false;
            this.colIdProduto.OptionsFilter.AllowFilter = false;
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 0;
            this.colIdProduto.Width = 87;
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
            this.colNomeProduto.VisibleIndex = 1;
            this.colNomeProduto.Width = 484;
            // 
            // colValorVendaProduto
            // 
            this.colValorVendaProduto.Caption = "Preço";
            this.colValorVendaProduto.DisplayFormat.FormatString = "c2";
            this.colValorVendaProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorVendaProduto.FieldName = "ValorVendaProduto";
            this.colValorVendaProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colValorVendaProduto.ImageOptions.Image")));
            this.colValorVendaProduto.Name = "colValorVendaProduto";
            this.colValorVendaProduto.OptionsColumn.AllowEdit = false;
            this.colValorVendaProduto.OptionsColumn.AllowFocus = false;
            this.colValorVendaProduto.OptionsFilter.AllowAutoFilter = false;
            this.colValorVendaProduto.OptionsFilter.AllowFilter = false;
            this.colValorVendaProduto.Visible = true;
            this.colValorVendaProduto.VisibleIndex = 2;
            this.colValorVendaProduto.Width = 110;
            // 
            // colValorComDesconto
            // 
            this.colValorComDesconto.Caption = "Preço com desconto";
            this.colValorComDesconto.DisplayFormat.FormatString = "c2";
            this.colValorComDesconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorComDesconto.FieldName = "ValorComDesconto";
            this.colValorComDesconto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colValorComDesconto.ImageOptions.Image")));
            this.colValorComDesconto.Name = "colValorComDesconto";
            this.colValorComDesconto.OptionsColumn.AllowEdit = false;
            this.colValorComDesconto.OptionsColumn.AllowFocus = false;
            this.colValorComDesconto.OptionsFilter.AllowAutoFilter = false;
            this.colValorComDesconto.OptionsFilter.AllowFilter = false;
            this.colValorComDesconto.Visible = true;
            this.colValorComDesconto.VisibleIndex = 3;
            this.colValorComDesconto.Width = 110;
            // 
            // colQuantidadeProdutoPedido
            // 
            this.colQuantidadeProdutoPedido.Caption = "Quantidade";
            this.colQuantidadeProdutoPedido.ColumnEdit = this.repositoryItemTextEdit3;
            this.colQuantidadeProdutoPedido.FieldName = "QuantidadeProdutoPedido";
            this.colQuantidadeProdutoPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colQuantidadeProdutoPedido.ImageOptions.Image")));
            this.colQuantidadeProdutoPedido.Name = "colQuantidadeProdutoPedido";
            this.colQuantidadeProdutoPedido.OptionsFilter.AllowAutoFilter = false;
            this.colQuantidadeProdutoPedido.OptionsFilter.AllowFilter = false;
            this.colQuantidadeProdutoPedido.Visible = true;
            this.colQuantidadeProdutoPedido.VisibleIndex = 4;
            this.colQuantidadeProdutoPedido.Width = 104;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit3.Mask.EditMask = "n0";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit3.MaxLength = 5;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total produto";
            this.coltotal.DisplayFormat.FormatString = "c2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "ValorTotalProdutoPedido";
            this.coltotal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("coltotal.ImageOptions.Image")));
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.AllowFocus = false;
            this.coltotal.OptionsFilter.AllowAutoFilter = false;
            this.coltotal.OptionsFilter.AllowFilter = false;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorTotalProdutoPedido", "{0:c2}")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 5;
            this.coltotal.Width = 113;
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
            // lstProdutos
            // 
            this.lstProdutos.DataSource = this.produtoBindingSource;
            this.lstProdutos.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Black;
            this.lstProdutos.EmbeddedNavigator.Appearance.Options.UseBorderColor = true;
            this.lstProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.lstProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.lstProdutos.Location = new System.Drawing.Point(0, 36);
            this.lstProdutos.MainView = this.lsProdutos;
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2,
            this.repositoryItemCalcEdit2,
            this.repositoryItemSpinEdit2,
            this.repositoryItemTextEdit2});
            this.lstProdutos.Size = new System.Drawing.Size(313, 554);
            this.lstProdutos.TabIndex = 0;
            this.lstProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lsProdutos});
            this.lstProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstProdutos_KeyDown);
            // 
            // lsProdutos
            // 
            this.lsProdutos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lsProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto1,
            this.colNomeProduto1,
            this.colValorVendaProduto1,
            this.colValorComDesconto1,
            this.colQuantidadeProdutoPedido1});
            this.lsProdutos.GridControl = this.lstProdutos;
            this.lsProdutos.GroupPanelText = " ";
            this.lsProdutos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.lsProdutos.Name = "lsProdutos";
            this.lsProdutos.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.lsProdutos.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.lsProdutos.OptionsDetail.EnableMasterViewMode = false;
            this.lsProdutos.OptionsPrint.EnableAppearanceEvenRow = true;
            this.lsProdutos.OptionsPrint.PrintSelectedRowsOnly = true;
            this.lsProdutos.OptionsPrint.PrintVertLines = false;
            this.lsProdutos.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.lsProdutos.OptionsSelection.MultiSelect = true;
            this.lsProdutos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.lsProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.lsProdutos.OptionsView.ShowIndicator = false;
            this.lsProdutos.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.LsProdutos_CustomDrawCell);
            // 
            // colIdProduto1
            // 
            this.colIdProduto1.FieldName = "IdProduto";
            this.colIdProduto1.Name = "colIdProduto1";
            // 
            // colNomeProduto1
            // 
            this.colNomeProduto1.Caption = "Produto";
            this.colNomeProduto1.FieldName = "NomeProduto";
            this.colNomeProduto1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNomeProduto1.ImageOptions.Image")));
            this.colNomeProduto1.Name = "colNomeProduto1";
            this.colNomeProduto1.OptionsColumn.AllowEdit = false;
            this.colNomeProduto1.OptionsColumn.AllowFocus = false;
            this.colNomeProduto1.OptionsFilter.AllowAutoFilter = false;
            this.colNomeProduto1.OptionsFilter.AllowFilter = false;
            this.colNomeProduto1.Visible = true;
            this.colNomeProduto1.VisibleIndex = 1;
            // 
            // colValorVendaProduto1
            // 
            this.colValorVendaProduto1.FieldName = "ValorVendaProduto";
            this.colValorVendaProduto1.Name = "colValorVendaProduto1";
            // 
            // colValorComDesconto1
            // 
            this.colValorComDesconto1.FieldName = "ValorComDesconto";
            this.colValorComDesconto1.Name = "colValorComDesconto1";
            // 
            // colQuantidadeProdutoPedido1
            // 
            this.colQuantidadeProdutoPedido1.FieldName = "QuantidadeProdutoPedido";
            this.colQuantidadeProdutoPedido1.Name = "colQuantidadeProdutoPedido1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")});
            this.repositoryItemLookUpEdit2.DisplayMember = "ProductName";
            this.repositoryItemLookUpEdit2.DropDownRows = 10;
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.PopupWidth = 220;
            this.repositoryItemLookUpEdit2.ValueMember = "ProductID";
            // 
            // repositoryItemCalcEdit2
            // 
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit2.Mask.EditMask = "c";
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "p";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.btnAdicionarSelecionados);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.btnLimpar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1363, 108);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnAdicionarSelecionados
            // 
            this.btnAdicionarSelecionados.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAdicionarSelecionados.Appearance.Options.UseBackColor = true;
            this.btnAdicionarSelecionados.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x321;
            this.btnAdicionarSelecionados.Location = new System.Drawing.Point(465, 65);
            this.btnAdicionarSelecionados.Name = "btnAdicionarSelecionados";
            this.btnAdicionarSelecionados.Size = new System.Drawing.Size(177, 43);
            this.btnAdicionarSelecionados.TabIndex = 1;
            this.btnAdicionarSelecionados.Text = "Adicionar selecionados [ + ]";
            this.btnAdicionarSelecionados.Click += new System.EventHandler(this.BtnAdicionarSelecionados_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtBuscar);
            this.groupControl2.Controls.Add(this.grpTipoFiltro);
            this.groupControl2.Location = new System.Drawing.Point(1, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(458, 107);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Burcar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 69);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Properties.MaxLength = 20;
            this.txtBuscar.Size = new System.Drawing.Size(301, 20);
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
            this.grpTipoFiltro.Properties.Columns = 4;
            this.grpTipoFiltro.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Produto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("G", "Grupo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Marca"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Código de Barras")});
            this.grpTipoFiltro.Size = new System.Drawing.Size(408, 33);
            this.grpTipoFiltro.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Appearance.Options.UseBackColor = true;
            this.btnLimpar.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x321;
            this.btnLimpar.Location = new System.Drawing.Point(1171, 65);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 43);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar produtos [ F10 ]";
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.ImageOptions.Image = global::projeto2.Properties.Resources.apply_32x32;
            this.btnSalvar.Location = new System.Drawing.Point(1085, 524);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 57);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar [F5]";
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x32;
            this.btnCancelar.Location = new System.Drawing.Point(1210, 524);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 57);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar [Esc]";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(345, 56);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomePessoa", "Cliente", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtCliente.Properties.DataSource = this.clienteModelBindingSource;
            this.txtCliente.Properties.DisplayMember = "NomePessoa";
            this.txtCliente.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.txtCliente.Properties.ValueMember = "IdCliente";
            this.txtCliente.Size = new System.Drawing.Size(475, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // clienteModelBindingSource
            // 
            this.clienteModelBindingSource.DataSource = typeof(projeto2.Feature.Cliente.Model.ClienteModel);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(345, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 14);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Cliente";
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.lstProdutos);
            this.groupControl3.Controls.Add(this.txtCliente);
            this.groupControl3.Controls.Add(this.dgvProdutos);
            this.groupControl3.Controls.Add(this.btnSalvar);
            this.groupControl3.Controls.Add(this.btnCancelar);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 108);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(1363, 591);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "groupControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 13);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Produtos em promoção";
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl4.Location = new System.Drawing.Point(12, 18);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(13, 12);
            this.groupControl4.TabIndex = 30;
            this.groupControl4.Text = "groupControl4";
            // 
            // FrmNovoPedidoDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 699);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmNovoPedidoDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNovoPedidoDev_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipoFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutos;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.GridControl lstProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView lsProdutos;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtBuscar;
        private DevExpress.XtraEditors.RadioGroup grpTipoFiltro;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarSelecionados;
        private DevExpress.XtraEditors.LookUpEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource clienteModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorVendaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorComDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeProdutoPedido;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProduto1;
        private DevExpress.XtraGrid.Columns.GridColumn colValorVendaProduto1;
        private DevExpress.XtraGrid.Columns.GridColumn colValorComDesconto1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeProdutoPedido1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}