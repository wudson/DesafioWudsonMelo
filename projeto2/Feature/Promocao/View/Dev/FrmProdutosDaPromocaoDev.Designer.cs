namespace projeto2.Feature.Promocao.View.Dev
{
    partial class FrmProdutosDaPromocaoDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutosDaPromocaoDev));
            this.dgvProdutosDaPromocao = new DevExpress.XtraGrid.GridControl();
            this.gvProdutosDaPromocao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCompraProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorVendaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeEstoqueProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosDaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutosDaPromocao
            // 
            this.dgvProdutosDaPromocao.DataSource = this.produtoBindingSource;
            this.dgvProdutosDaPromocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosDaPromocao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvProdutosDaPromocao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvProdutosDaPromocao.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutosDaPromocao.MainView = this.gvProdutosDaPromocao;
            this.dgvProdutosDaPromocao.Name = "dgvProdutosDaPromocao";
            this.dgvProdutosDaPromocao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvProdutosDaPromocao.Size = new System.Drawing.Size(918, 343);
            this.dgvProdutosDaPromocao.TabIndex = 8;
            this.dgvProdutosDaPromocao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutosDaPromocao});
            // 
            // gvProdutosDaPromocao
            // 
            this.gvProdutosDaPromocao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvProdutosDaPromocao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomeProduto,
            this.colGrupoProduto,
            this.colMarcaProduto,
            this.colValorCompraProduto,
            this.colValorVendaProduto,
            this.colQuantidadeEstoqueProduto,
            this.colDesconto});
            this.gvProdutosDaPromocao.GridControl = this.dgvProdutosDaPromocao;
            this.gvProdutosDaPromocao.GroupPanelText = " ";
            this.gvProdutosDaPromocao.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvProdutosDaPromocao.Name = "gvProdutosDaPromocao";
            this.gvProdutosDaPromocao.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvProdutosDaPromocao.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvProdutosDaPromocao.OptionsDetail.EnableMasterViewMode = false;
            this.gvProdutosDaPromocao.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvProdutosDaPromocao.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvProdutosDaPromocao.OptionsPrint.PrintVertLines = false;
            this.gvProdutosDaPromocao.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvProdutosDaPromocao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutosDaPromocao.OptionsView.ShowFooter = true;
            this.gvProdutosDaPromocao.OptionsView.ShowIndicator = false;
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
            this.colNomeProduto.Width = 207;
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
            this.colGrupoProduto.VisibleIndex = 1;
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
            this.colMarcaProduto.VisibleIndex = 2;
            this.colMarcaProduto.Width = 114;
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
            this.colValorCompraProduto.VisibleIndex = 4;
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
            this.colValorVendaProduto.VisibleIndex = 5;
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
            this.colQuantidadeEstoqueProduto.VisibleIndex = 3;
            this.colQuantidadeEstoqueProduto.Width = 89;
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
            // colDesconto
            // 
            this.colDesconto.Caption = "Venda com Desconto";
            this.colDesconto.DisplayFormat.FormatString = "c2";
            this.colDesconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDesconto.FieldName = "ValorComDesconto";
            this.colDesconto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDesconto.ImageOptions.Image")));
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.OptionsColumn.AllowEdit = false;
            this.colDesconto.OptionsColumn.AllowFocus = false;
            this.colDesconto.OptionsColumn.FixedWidth = true;
            this.colDesconto.OptionsFilter.AllowAutoFilter = false;
            this.colDesconto.OptionsFilter.AllowFilter = false;
            this.colDesconto.Visible = true;
            this.colDesconto.VisibleIndex = 6;
            this.colDesconto.Width = 85;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // FrmProdutosDaPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 343);
            this.Controls.Add(this.dgvProdutosDaPromocao);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmProdutosDaPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos da promoção";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutosDaPromocao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosDaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvProdutosDaPromocao;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutosDaPromocao;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCompraProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorVendaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeEstoqueProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDesconto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}