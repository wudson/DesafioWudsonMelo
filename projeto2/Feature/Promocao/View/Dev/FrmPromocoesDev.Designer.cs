namespace projeto2.Feature.Promocao.View.Dev
{
    partial class FrmPromocoesDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromocoesDev));
            this.dgvPromocoes = new DevExpress.XtraGrid.GridControl();
            this.promocaoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPromocao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomePromocao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPromocao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusPromocao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.grpFiltroPromocao = new DevExpress.XtraEditors.RadioGroup();
            this.btnVerProdutos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFiltroPromocao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromocoes
            // 
            this.dgvPromocoes.DataSource = this.promocaoModelBindingSource;
            this.dgvPromocoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPromocoes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvPromocoes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvPromocoes.Location = new System.Drawing.Point(0, 81);
            this.dgvPromocoes.MainView = this.gvPromocao;
            this.dgvPromocoes.Name = "dgvPromocoes";
            this.dgvPromocoes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvPromocoes.Size = new System.Drawing.Size(791, 313);
            this.dgvPromocoes.TabIndex = 6;
            this.dgvPromocoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPromocao});
            // 
            // promocaoModelBindingSource
            // 
            this.promocaoModelBindingSource.DataSource = typeof(projeto2.Feature.Promocao.Model.PromocaoModel);
            // 
            // gvPromocao
            // 
            this.gvPromocao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPromocao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomePromocao,
            this.colTipoPromocao,
            this.colDataInicio,
            this.colDataFim,
            this.colStatusPromocao});
            this.gvPromocao.GridControl = this.dgvPromocoes;
            this.gvPromocao.GroupPanelText = " ";
            this.gvPromocao.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvPromocao.Name = "gvPromocao";
            this.gvPromocao.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvPromocao.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvPromocao.OptionsDetail.EnableMasterViewMode = false;
            this.gvPromocao.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvPromocao.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvPromocao.OptionsPrint.PrintVertLines = false;
            this.gvPromocao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPromocao.OptionsView.ShowIndicator = false;
            this.gvPromocao.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvPromocao_CustomDrawCell);
            this.gvPromocao.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvPromocao_FocusedRowChanged);
            // 
            // colNomePromocao
            // 
            this.colNomePromocao.Caption = "Nome";
            this.colNomePromocao.FieldName = "NomePromocao";
            this.colNomePromocao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNomePromocao.ImageOptions.Image")));
            this.colNomePromocao.Name = "colNomePromocao";
            this.colNomePromocao.OptionsColumn.AllowEdit = false;
            this.colNomePromocao.OptionsColumn.AllowFocus = false;
            this.colNomePromocao.OptionsFilter.AllowAutoFilter = false;
            this.colNomePromocao.OptionsFilter.AllowFilter = false;
            this.colNomePromocao.Visible = true;
            this.colNomePromocao.VisibleIndex = 0;
            this.colNomePromocao.Width = 349;
            // 
            // colTipoPromocao
            // 
            this.colTipoPromocao.Caption = "Tipo";
            this.colTipoPromocao.FieldName = "TipoPromocao";
            this.colTipoPromocao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTipoPromocao.ImageOptions.Image")));
            this.colTipoPromocao.Name = "colTipoPromocao";
            this.colTipoPromocao.OptionsColumn.AllowEdit = false;
            this.colTipoPromocao.OptionsColumn.AllowFocus = false;
            this.colTipoPromocao.OptionsColumn.FixedWidth = true;
            this.colTipoPromocao.OptionsFilter.AllowAutoFilter = false;
            this.colTipoPromocao.OptionsFilter.AllowFilter = false;
            this.colTipoPromocao.Visible = true;
            this.colTipoPromocao.VisibleIndex = 1;
            this.colTipoPromocao.Width = 138;
            // 
            // colDataInicio
            // 
            this.colDataInicio.Caption = "Inicio";
            this.colDataInicio.FieldName = "DataInicio";
            this.colDataInicio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDataInicio.ImageOptions.Image")));
            this.colDataInicio.Name = "colDataInicio";
            this.colDataInicio.OptionsColumn.AllowEdit = false;
            this.colDataInicio.OptionsColumn.AllowFocus = false;
            this.colDataInicio.OptionsColumn.FixedWidth = true;
            this.colDataInicio.OptionsFilter.AllowAutoFilter = false;
            this.colDataInicio.OptionsFilter.AllowFilter = false;
            this.colDataInicio.Visible = true;
            this.colDataInicio.VisibleIndex = 2;
            this.colDataInicio.Width = 113;
            // 
            // colDataFim
            // 
            this.colDataFim.Caption = "Fim";
            this.colDataFim.FieldName = "DataFim";
            this.colDataFim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDataFim.ImageOptions.Image")));
            this.colDataFim.Name = "colDataFim";
            this.colDataFim.OptionsColumn.AllowEdit = false;
            this.colDataFim.OptionsColumn.AllowFocus = false;
            this.colDataFim.OptionsColumn.FixedWidth = true;
            this.colDataFim.OptionsFilter.AllowAutoFilter = false;
            this.colDataFim.OptionsFilter.AllowFilter = false;
            this.colDataFim.Visible = true;
            this.colDataFim.VisibleIndex = 3;
            this.colDataFim.Width = 111;
            // 
            // colStatusPromocao
            // 
            this.colStatusPromocao.Caption = "Status";
            this.colStatusPromocao.FieldName = "StatusPromocao";
            this.colStatusPromocao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colStatusPromocao.ImageOptions.Image")));
            this.colStatusPromocao.Name = "colStatusPromocao";
            this.colStatusPromocao.OptionsColumn.AllowEdit = false;
            this.colStatusPromocao.OptionsColumn.AllowFocus = false;
            this.colStatusPromocao.OptionsColumn.FixedWidth = true;
            this.colStatusPromocao.OptionsFilter.AllowAutoFilter = false;
            this.colStatusPromocao.OptionsFilter.AllowFilter = false;
            this.colStatusPromocao.Visible = true;
            this.colStatusPromocao.VisibleIndex = 4;
            this.colStatusPromocao.Width = 100;
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
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x321;
            this.btnSalvar.Location = new System.Drawing.Point(12, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 57);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Novo [ + ]";
            this.btnSalvar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // grpFiltroPromocao
            // 
            this.grpFiltroPromocao.Location = new System.Drawing.Point(552, 52);
            this.grpFiltroPromocao.Name = "grpFiltroPromocao";
            this.grpFiltroPromocao.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltroPromocao.Properties.Appearance.Options.UseBackColor = true;
            this.grpFiltroPromocao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grpFiltroPromocao.Properties.Columns = 3;
            this.grpFiltroPromocao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Ativas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("I", "Inativas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todas")});
            this.grpFiltroPromocao.Properties.EditValueChanged += new System.EventHandler(this.GrpFiltroPromocao_Properties_EditValueChanged);
            this.grpFiltroPromocao.Size = new System.Drawing.Size(247, 23);
            this.grpFiltroPromocao.TabIndex = 14;
            // 
            // btnVerProdutos
            // 
            this.btnVerProdutos.Appearance.BackColor = System.Drawing.Color.White;
            this.btnVerProdutos.Appearance.Options.UseBackColor = true;
            this.btnVerProdutos.ImageOptions.Image = global::projeto2.Properties.Resources.show_32x32;
            this.btnVerProdutos.Location = new System.Drawing.Point(120, 12);
            this.btnVerProdutos.Name = "btnVerProdutos";
            this.btnVerProdutos.Size = new System.Drawing.Size(129, 57);
            this.btnVerProdutos.TabIndex = 15;
            this.btnVerProdutos.Text = "Ver produtos [ i ]";
            this.btnVerProdutos.Click += new System.EventHandler(this.BtnVerProdutos_Click);
            // 
            // FrmPromocoesDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 394);
            this.Controls.Add(this.btnVerProdutos);
            this.Controls.Add(this.grpFiltroPromocao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvPromocoes);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmPromocoesDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promoções";
            this.Load += new System.EventHandler(this.FrmPromocoes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPromocoes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFiltroPromocao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvPromocoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPromocao;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource promocaoModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNomePromocao;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPromocao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFim;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusPromocao;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.RadioGroup grpFiltroPromocao;
        private DevExpress.XtraEditors.SimpleButton btnVerProdutos;
    }
}