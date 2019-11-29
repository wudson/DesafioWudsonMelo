namespace projeto2.Feature.Estoque.View.Dev
{
    partial class FrmEstoqueDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueDev));
            this.IdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvEstoque = new DevExpress.XtraGrid.GridControl();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCompraProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorVendaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeEstoqueProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorTotalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.grupoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // IdProduto
            // 
            this.IdProduto.Caption = "Código";
            this.IdProduto.FieldName = "IdProduto";
            this.IdProduto.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.OptionsColumn.AllowEdit = false;
            this.IdProduto.OptionsColumn.AllowFocus = false;
            this.IdProduto.OptionsColumn.FixedWidth = true;
            this.IdProduto.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.IdProduto.OptionsFilter.AllowAutoFilter = false;
            this.IdProduto.OptionsFilter.AllowFilter = false;
            this.IdProduto.Width = 60;
            // 
            // NomeProduto
            // 
            this.NomeProduto.Caption = "Produto";
            this.NomeProduto.FieldName = "NomeProduto";
            this.NomeProduto.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.OptionsColumn.AllowEdit = false;
            this.NomeProduto.OptionsColumn.AllowFocus = false;
            this.NomeProduto.OptionsColumn.AllowMove = false;
            this.NomeProduto.OptionsColumn.FixedWidth = true;
            this.NomeProduto.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.NomeProduto.OptionsFilter.AllowAutoFilter = false;
            this.NomeProduto.OptionsFilter.AllowFilter = false;
            this.NomeProduto.Width = 225;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.DataSource = this.produtoBindingSource;
            this.dgvEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoque.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvEstoque.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 0);
            this.dgvEstoque.MainView = this.gvEstoque;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvEstoque.Size = new System.Drawing.Size(556, 758);
            this.dgvEstoque.TabIndex = 0;
            this.dgvEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEstoque});
            this.dgvEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvEstoque_KeyDown);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // gvEstoque
            // 
            this.gvEstoque.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto,
            this.colNomeProduto,
            this.colGrupoProduto,
            this.colMarcaProduto,
            this.colTipoProduto,
            this.colValorCompraProduto,
            this.colValorVendaProduto,
            this.colQuantidadeEstoqueProduto,
            this.colValorTotalEstoque});
            this.gvEstoque.GridControl = this.dgvEstoque;
            this.gvEstoque.GroupPanelText = " ";
            this.gvEstoque.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvEstoque.Name = "gvEstoque";
            this.gvEstoque.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvEstoque.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvEstoque.OptionsDetail.EnableMasterViewMode = false;
            this.gvEstoque.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvEstoque.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvEstoque.OptionsPrint.PrintVertLines = false;
            this.gvEstoque.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEstoque.OptionsView.ShowFooter = true;
            this.gvEstoque.OptionsView.ShowIndicator = false;
            // 
            // colIdProduto
            // 
            this.colIdProduto.Caption = "Código";
            this.colIdProduto.FieldName = "IdProduto";
            this.colIdProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIdProduto.ImageOptions.Image")));
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.OptionsColumn.AllowEdit = false;
            this.colIdProduto.OptionsColumn.AllowFocus = false;
            this.colIdProduto.OptionsColumn.FixedWidth = true;
            this.colIdProduto.OptionsFilter.AllowAutoFilter = false;
            this.colIdProduto.OptionsFilter.AllowFilter = false;
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 0;
            this.colIdProduto.Width = 65;
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
            this.colNomeProduto.Width = 149;
            // 
            // colGrupoProduto
            // 
            this.colGrupoProduto.Caption = "Grupo";
            this.colGrupoProduto.FieldName = "GrupoProduto.Grupo";
            this.colGrupoProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGrupoProduto.ImageOptions.Image")));
            this.colGrupoProduto.Name = "colGrupoProduto";
            this.colGrupoProduto.OptionsColumn.AllowEdit = false;
            this.colGrupoProduto.OptionsColumn.AllowFocus = false;
            this.colGrupoProduto.OptionsColumn.FixedWidth = true;
            this.colGrupoProduto.OptionsFilter.AllowAutoFilter = false;
            this.colGrupoProduto.OptionsFilter.AllowFilter = false;
            this.colGrupoProduto.Visible = true;
            this.colGrupoProduto.VisibleIndex = 2;
            this.colGrupoProduto.Width = 119;
            // 
            // colMarcaProduto
            // 
            this.colMarcaProduto.Caption = "Marca";
            this.colMarcaProduto.FieldName = "MarcaProduto.Marca";
            this.colMarcaProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMarcaProduto.ImageOptions.Image")));
            this.colMarcaProduto.Name = "colMarcaProduto";
            this.colMarcaProduto.OptionsColumn.AllowEdit = false;
            this.colMarcaProduto.OptionsColumn.AllowFocus = false;
            this.colMarcaProduto.OptionsColumn.FixedWidth = true;
            this.colMarcaProduto.OptionsFilter.AllowAutoFilter = false;
            this.colMarcaProduto.OptionsFilter.AllowFilter = false;
            this.colMarcaProduto.Visible = true;
            this.colMarcaProduto.VisibleIndex = 3;
            this.colMarcaProduto.Width = 114;
            // 
            // colTipoProduto
            // 
            this.colTipoProduto.Caption = "Tipo";
            this.colTipoProduto.FieldName = "TipoProduto";
            this.colTipoProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTipoProduto.ImageOptions.Image")));
            this.colTipoProduto.Name = "colTipoProduto";
            this.colTipoProduto.OptionsColumn.AllowEdit = false;
            this.colTipoProduto.OptionsColumn.AllowFocus = false;
            this.colTipoProduto.OptionsColumn.FixedWidth = true;
            this.colTipoProduto.OptionsFilter.AllowAutoFilter = false;
            this.colTipoProduto.OptionsFilter.AllowFilter = false;
            this.colTipoProduto.Visible = true;
            this.colTipoProduto.VisibleIndex = 4;
            this.colTipoProduto.Width = 65;
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
            this.colValorCompraProduto.VisibleIndex = 6;
            this.colValorCompraProduto.Width = 85;
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
            this.colValorVendaProduto.VisibleIndex = 7;
            this.colValorVendaProduto.Width = 84;
            // 
            // colQuantidadeEstoqueProduto
            // 
            this.colQuantidadeEstoqueProduto.Caption = "Quantidade";
            this.colQuantidadeEstoqueProduto.FieldName = "QuantidadeEstoqueProduto";
            this.colQuantidadeEstoqueProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colQuantidadeEstoqueProduto.ImageOptions.Image")));
            this.colQuantidadeEstoqueProduto.Name = "colQuantidadeEstoqueProduto";
            this.colQuantidadeEstoqueProduto.OptionsColumn.AllowEdit = false;
            this.colQuantidadeEstoqueProduto.OptionsColumn.AllowFocus = false;
            this.colQuantidadeEstoqueProduto.OptionsColumn.FixedWidth = true;
            this.colQuantidadeEstoqueProduto.OptionsFilter.AllowAutoFilter = false;
            this.colQuantidadeEstoqueProduto.OptionsFilter.AllowFilter = false;
            this.colQuantidadeEstoqueProduto.Visible = true;
            this.colQuantidadeEstoqueProduto.VisibleIndex = 5;
            this.colQuantidadeEstoqueProduto.Width = 89;
            // 
            // colValorTotalEstoque
            // 
            this.colValorTotalEstoque.Caption = "Total";
            this.colValorTotalEstoque.DisplayFormat.FormatString = "c2";
            this.colValorTotalEstoque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorTotalEstoque.FieldName = "ValorTotalEstoque";
            this.colValorTotalEstoque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colValorTotalEstoque.ImageOptions.Image")));
            this.colValorTotalEstoque.Name = "colValorTotalEstoque";
            this.colValorTotalEstoque.OptionsColumn.AllowEdit = false;
            this.colValorTotalEstoque.OptionsColumn.AllowFocus = false;
            this.colValorTotalEstoque.OptionsColumn.FixedWidth = true;
            this.colValorTotalEstoque.OptionsColumn.ReadOnly = true;
            this.colValorTotalEstoque.OptionsFilter.AllowAutoFilter = false;
            this.colValorTotalEstoque.OptionsFilter.AllowFilter = false;
            this.colValorTotalEstoque.Visible = true;
            this.colValorTotalEstoque.VisibleIndex = 8;
            this.colValorTotalEstoque.Width = 80;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtGrupo);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtTipo);
            this.groupControl1.Controls.Add(this.btnFiltrar);
            this.groupControl1.Controls.Add(this.btnLimpar);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNome);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(556, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(291, 758);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Filtros";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(8, 112);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Grupo", "Grupo", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtGrupo.Properties.DataSource = this.grupoModelBindingSource;
            this.txtGrupo.Properties.DisplayMember = "Grupo";
            this.txtGrupo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.txtGrupo.Properties.ValueMember = "IdGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(262, 20);
            this.txtGrupo.TabIndex = 1;
            // 
            // grupoModelBindingSource
            // 
            this.grupoModelBindingSource.DataSource = typeof(projeto2.Feature.Grupo.Model.GrupoModel);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 146);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(8, 165);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTipo.Properties.Items.AddRange(new object[] {
            "Caixa",
            "Peso",
            "Unidade"});
            this.txtTipo.Size = new System.Drawing.Size(262, 20);
            this.txtTipo.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.Appearance.Options.UseBackColor = true;
            this.btnFiltrar.ImageOptions.Image = global::projeto2.Properties.Resources.filter_32x32;
            this.btnFiltrar.Location = new System.Drawing.Point(40, 660);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(107, 36);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar [Enter]";
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Appearance.Options.UseBackColor = true;
            this.btnLimpar.ImageOptions.Image = global::projeto2.Properties.Resources.clearfilter_32x32;
            this.btnLimpar.Location = new System.Drawing.Point(153, 660);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 36);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar [F10]";
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Grupo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 100;
            this.txtNome.Size = new System.Drawing.Size(262, 20);
            this.txtNome.TabIndex = 0;
            // 
            // FrmEstoqueDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 758);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmEstoqueDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn IdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn NomeProduto;
        private DevExpress.XtraGrid.GridControl dgvEstoque;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCompraProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorVendaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeEstoqueProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorTotalEstoque;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.LookUpEdit txtGrupo;
        private System.Windows.Forms.BindingSource grupoModelBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit txtTipo;
    }
}