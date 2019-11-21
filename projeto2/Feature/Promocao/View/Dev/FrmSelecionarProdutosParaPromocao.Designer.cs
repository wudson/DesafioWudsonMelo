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
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarCadastroProduto = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(258, 105);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Burcar";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(5, 30);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 3;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Produto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("G", "Grupo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Marca")});
            this.radioGroup1.Size = new System.Drawing.Size(253, 33);
            this.radioGroup1.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(11, 69);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(233, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditar.Appearance.Options.UseBackColor = true;
            this.btnEditar.ImageOptions.Image = global::projeto2.Properties.Resources.apply_32x32;
            this.btnEditar.Location = new System.Drawing.Point(643, 441);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 57);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Salvar [Enter]";
            this.btnEditar.Visible = false;
            // 
            // btnCancelarCadastroProduto
            // 
            this.btnCancelarCadastroProduto.Appearance.BackColor = System.Drawing.Color.White;
            this.btnCancelarCadastroProduto.Appearance.Options.UseBackColor = true;
            this.btnCancelarCadastroProduto.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x32;
            this.btnCancelarCadastroProduto.Location = new System.Drawing.Point(768, 441);
            this.btnCancelarCadastroProduto.Name = "btnCancelarCadastroProduto";
            this.btnCancelarCadastroProduto.Size = new System.Drawing.Size(121, 57);
            this.btnCancelarCadastroProduto.TabIndex = 19;
            this.btnCancelarCadastroProduto.Text = "Cancelar [Esc]";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x321;
            this.simpleButton1.Location = new System.Drawing.Point(730, 74);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 43);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Limpar produtos [ F10 ]";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x321;
            this.btnSalvar.Location = new System.Drawing.Point(276, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(177, 43);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Adicionar selecionados [ + ]";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.produtoBindingSource;
            this.listBoxControl1.DisplayMember = "CodigoDeBarras";
            this.listBoxControl1.Location = new System.Drawing.Point(12, 123);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(258, 375);
            this.listBoxControl1.TabIndex = 20;
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
            // FrmSelecionarProdutosParaPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 510);
            this.Controls.Add(this.dgvProdutosPromocao);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelarCadastroProduto);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmSelecionarProdutosParaPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar produtos";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnCancelarCadastroProduto;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
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
    }
}