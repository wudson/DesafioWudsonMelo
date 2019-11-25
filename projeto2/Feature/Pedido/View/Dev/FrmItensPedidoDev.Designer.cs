namespace projeto2.Feature.Pedido.View.Dev
{
    partial class FrmItensPedidoDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensPedidoDev));
            this.dgvItensPedido = new DevExpress.XtraGrid.GridControl();
            this.itemPedidoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvItensPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItensPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItensPedido
            // 
            this.dgvItensPedido.DataSource = this.itemPedidoModelBindingSource;
            this.dgvItensPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItensPedido.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvItensPedido.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvItensPedido.Location = new System.Drawing.Point(0, 0);
            this.dgvItensPedido.MainView = this.gvItensPedido;
            this.dgvItensPedido.Name = "dgvItensPedido";
            this.dgvItensPedido.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvItensPedido.Size = new System.Drawing.Size(901, 340);
            this.dgvItensPedido.TabIndex = 9;
            this.dgvItensPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItensPedido});
            // 
            // itemPedidoModelBindingSource
            // 
            this.itemPedidoModelBindingSource.DataSource = typeof(projeto2.Feature.Pedido.Model.ItemPedidoModel);
            // 
            // gvItensPedido
            // 
            this.gvItensPedido.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvItensPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantidade,
            this.colIdProduto,
            this.colPrecoTotal,
            this.nomeProduto,
            this.colVenda,
            this.colTipo,
            this.colDesconto});
            this.gvItensPedido.GridControl = this.dgvItensPedido;
            this.gvItensPedido.GroupPanelText = " ";
            this.gvItensPedido.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvItensPedido.Name = "gvItensPedido";
            this.gvItensPedido.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvItensPedido.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvItensPedido.OptionsDetail.EnableMasterViewMode = false;
            this.gvItensPedido.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvItensPedido.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvItensPedido.OptionsPrint.PrintVertLines = false;
            this.gvItensPedido.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvItensPedido.OptionsView.EnableAppearanceEvenRow = true;
            this.gvItensPedido.OptionsView.ShowFooter = true;
            this.gvItensPedido.OptionsView.ShowIndicator = false;
            // 
            // colQuantidade
            // 
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colQuantidade.ImageOptions.Image")));
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.OptionsColumn.AllowEdit = false;
            this.colQuantidade.OptionsColumn.AllowFocus = false;
            this.colQuantidade.OptionsFilter.AllowAutoFilter = false;
            this.colQuantidade.OptionsFilter.AllowFilter = false;
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 5;
            this.colQuantidade.Width = 100;
            // 
            // colIdProduto
            // 
            this.colIdProduto.Caption = "Código";
            this.colIdProduto.FieldName = "ProdutosPedido.IdProduto";
            this.colIdProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIdProduto.ImageOptions.Image")));
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.OptionsColumn.AllowEdit = false;
            this.colIdProduto.OptionsColumn.AllowFocus = false;
            this.colIdProduto.OptionsFilter.AllowAutoFilter = false;
            this.colIdProduto.OptionsFilter.AllowFilter = false;
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 0;
            this.colIdProduto.Width = 77;
            // 
            // colPrecoTotal
            // 
            this.colPrecoTotal.Caption = "Preço Total";
            this.colPrecoTotal.DisplayFormat.FormatString = "c2";
            this.colPrecoTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoTotal.FieldName = "PrecoTotal";
            this.colPrecoTotal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPrecoTotal.ImageOptions.Image")));
            this.colPrecoTotal.Name = "colPrecoTotal";
            this.colPrecoTotal.OptionsColumn.AllowEdit = false;
            this.colPrecoTotal.OptionsColumn.AllowFocus = false;
            this.colPrecoTotal.OptionsColumn.ReadOnly = true;
            this.colPrecoTotal.OptionsFilter.AllowAutoFilter = false;
            this.colPrecoTotal.OptionsFilter.AllowFilter = false;
            this.colPrecoTotal.Visible = true;
            this.colPrecoTotal.VisibleIndex = 6;
            this.colPrecoTotal.Width = 104;
            // 
            // nomeProduto
            // 
            this.nomeProduto.Caption = "Produto";
            this.nomeProduto.FieldName = "ProdutosPedido.NomeProduto";
            this.nomeProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("nomeProduto.ImageOptions.Image")));
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.OptionsColumn.AllowEdit = false;
            this.nomeProduto.OptionsColumn.AllowFocus = false;
            this.nomeProduto.OptionsFilter.AllowAutoFilter = false;
            this.nomeProduto.OptionsFilter.AllowFilter = false;
            this.nomeProduto.Visible = true;
            this.nomeProduto.VisibleIndex = 1;
            this.nomeProduto.Width = 324;
            // 
            // colVenda
            // 
            this.colVenda.Caption = "Preço de Venda";
            this.colVenda.DisplayFormat.FormatString = "c2";
            this.colVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVenda.FieldName = "ProdutosPedido.ValorVendaProduto";
            this.colVenda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colVenda.ImageOptions.Image")));
            this.colVenda.Name = "colVenda";
            this.colVenda.OptionsColumn.AllowEdit = false;
            this.colVenda.OptionsColumn.AllowFocus = false;
            this.colVenda.OptionsFilter.AllowAutoFilter = false;
            this.colVenda.OptionsFilter.AllowFilter = false;
            this.colVenda.Visible = true;
            this.colVenda.VisibleIndex = 3;
            this.colVenda.Width = 91;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "ProdutosPedido.TipoProduto";
            this.colTipo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTipo.ImageOptions.Image")));
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.OptionsColumn.AllowFocus = false;
            this.colTipo.OptionsFilter.AllowAutoFilter = false;
            this.colTipo.OptionsFilter.AllowFilter = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 2;
            this.colTipo.Width = 103;
            // 
            // colDesconto
            // 
            this.colDesconto.Caption = "Preço com desconto";
            this.colDesconto.DisplayFormat.FormatString = "c2";
            this.colDesconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDesconto.FieldName = "ProdutosPedido.ValorComDesconto";
            this.colDesconto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDesconto.ImageOptions.Image")));
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.OptionsColumn.AllowEdit = false;
            this.colDesconto.OptionsColumn.AllowFocus = false;
            this.colDesconto.OptionsFilter.AllowAutoFilter = false;
            this.colDesconto.OptionsFilter.AllowFilter = false;
            this.colDesconto.Visible = true;
            this.colDesconto.VisibleIndex = 4;
            this.colDesconto.Width = 102;
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
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // FrmItensPedidoDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 340);
            this.Controls.Add(this.dgvItensPedido);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmItensPedidoDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItensPedidoDev";
            this.Load += new System.EventHandler(this.FrmItensPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmItensPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItensPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvItensPedido;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItensPedido;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource itemPedidoModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn nomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDesconto;
    }
}