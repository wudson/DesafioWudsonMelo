namespace projeto2.Feature.Cliente.View.Dev
{
    partial class FrmClientesDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesDev));
            this.dgvProdutos = new DevExpress.XtraGrid.GridControl();
            this.clienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomePessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailPessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonePessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelularPessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCidadePessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataEdicaoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCadastroCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.gpcBotoes = new DevExpress.XtraEditors.GroupControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).BeginInit();
            this.gpcBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.DataSource = this.clienteModelBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 87);
            this.dgvProdutos.MainView = this.gvProdutos;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvProdutos.Size = new System.Drawing.Size(761, 347);
            this.dgvProdutos.TabIndex = 16;
            this.dgvProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutos});
            // 
            // clienteModelBindingSource
            // 
            this.clienteModelBindingSource.DataSource = typeof(projeto2.Feature.Cliente.Model.ClienteModel);
            // 
            // gvProdutos
            // 
            this.gvProdutos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPessoa,
            this.colNomePessoa,
            this.colEmailPessoa,
            this.colTelefonePessoa,
            this.colCelularPessoa,
            this.colCidadePessoa,
            this.colDataEdicaoCliente,
            this.colDataCadastroCliente});
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
            this.gvProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutos.OptionsView.ShowFooter = true;
            this.gvProdutos.OptionsView.ShowIndicator = false;
            // 
            // colIdPessoa
            // 
            this.colIdPessoa.Caption = "Código";
            this.colIdPessoa.FieldName = "IdPessoa";
            this.colIdPessoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIdPessoa.ImageOptions.Image")));
            this.colIdPessoa.Name = "colIdPessoa";
            this.colIdPessoa.OptionsColumn.AllowEdit = false;
            this.colIdPessoa.OptionsColumn.AllowFocus = false;
            this.colIdPessoa.OptionsColumn.FixedWidth = true;
            this.colIdPessoa.OptionsFilter.AllowAutoFilter = false;
            this.colIdPessoa.OptionsFilter.AllowFilter = false;
            this.colIdPessoa.Visible = true;
            this.colIdPessoa.VisibleIndex = 0;
            this.colIdPessoa.Width = 67;
            // 
            // colNomePessoa
            // 
            this.colNomePessoa.Caption = "Nome";
            this.colNomePessoa.FieldName = "NomePessoa";
            this.colNomePessoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNomePessoa.ImageOptions.Image")));
            this.colNomePessoa.Name = "colNomePessoa";
            this.colNomePessoa.OptionsColumn.AllowEdit = false;
            this.colNomePessoa.OptionsColumn.AllowFocus = false;
            this.colNomePessoa.OptionsFilter.AllowAutoFilter = false;
            this.colNomePessoa.OptionsFilter.AllowFilter = false;
            this.colNomePessoa.Visible = true;
            this.colNomePessoa.VisibleIndex = 1;
            this.colNomePessoa.Width = 20;
            // 
            // colEmailPessoa
            // 
            this.colEmailPessoa.Caption = "Email";
            this.colEmailPessoa.FieldName = "EmailPessoa";
            this.colEmailPessoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colEmailPessoa.ImageOptions.Image")));
            this.colEmailPessoa.Name = "colEmailPessoa";
            this.colEmailPessoa.OptionsColumn.AllowEdit = false;
            this.colEmailPessoa.OptionsColumn.AllowFocus = false;
            this.colEmailPessoa.OptionsFilter.AllowAutoFilter = false;
            this.colEmailPessoa.OptionsFilter.AllowFilter = false;
            this.colEmailPessoa.Visible = true;
            this.colEmailPessoa.VisibleIndex = 2;
            this.colEmailPessoa.Width = 20;
            // 
            // colTelefonePessoa
            // 
            this.colTelefonePessoa.Caption = "Telefone";
            this.colTelefonePessoa.FieldName = "TelefonePessoa";
            this.colTelefonePessoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTelefonePessoa.ImageOptions.Image")));
            this.colTelefonePessoa.Name = "colTelefonePessoa";
            this.colTelefonePessoa.OptionsColumn.AllowEdit = false;
            this.colTelefonePessoa.OptionsColumn.AllowFocus = false;
            this.colTelefonePessoa.OptionsColumn.FixedWidth = true;
            this.colTelefonePessoa.OptionsFilter.AllowAutoFilter = false;
            this.colTelefonePessoa.OptionsFilter.AllowFilter = false;
            this.colTelefonePessoa.Visible = true;
            this.colTelefonePessoa.VisibleIndex = 3;
            this.colTelefonePessoa.Width = 85;
            // 
            // colCelularPessoa
            // 
            this.colCelularPessoa.Caption = "Celular";
            this.colCelularPessoa.FieldName = "CelularPessoa";
            this.colCelularPessoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCelularPessoa.ImageOptions.Image")));
            this.colCelularPessoa.Name = "colCelularPessoa";
            this.colCelularPessoa.OptionsColumn.AllowEdit = false;
            this.colCelularPessoa.OptionsColumn.AllowFocus = false;
            this.colCelularPessoa.OptionsColumn.FixedWidth = true;
            this.colCelularPessoa.OptionsFilter.AllowAutoFilter = false;
            this.colCelularPessoa.OptionsFilter.AllowFilter = false;
            this.colCelularPessoa.Visible = true;
            this.colCelularPessoa.VisibleIndex = 4;
            this.colCelularPessoa.Width = 85;
            // 
            // colCidadePessoa
            // 
            this.colCidadePessoa.Caption = "Cidade";
            this.colCidadePessoa.FieldName = "CidadePessoa";
            this.colCidadePessoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCidadePessoa.ImageOptions.Image")));
            this.colCidadePessoa.Name = "colCidadePessoa";
            this.colCidadePessoa.OptionsColumn.AllowEdit = false;
            this.colCidadePessoa.OptionsColumn.AllowFocus = false;
            this.colCidadePessoa.OptionsColumn.FixedWidth = true;
            this.colCidadePessoa.OptionsFilter.AllowAutoFilter = false;
            this.colCidadePessoa.OptionsFilter.AllowFilter = false;
            this.colCidadePessoa.Visible = true;
            this.colCidadePessoa.VisibleIndex = 5;
            this.colCidadePessoa.Width = 112;
            // 
            // colDataEdicaoCliente
            // 
            this.colDataEdicaoCliente.Caption = "Ultima alteração";
            this.colDataEdicaoCliente.FieldName = "DataEdicaoCliente";
            this.colDataEdicaoCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDataEdicaoCliente.ImageOptions.Image")));
            this.colDataEdicaoCliente.Name = "colDataEdicaoCliente";
            this.colDataEdicaoCliente.OptionsColumn.AllowEdit = false;
            this.colDataEdicaoCliente.OptionsColumn.AllowFocus = false;
            this.colDataEdicaoCliente.OptionsColumn.FixedWidth = true;
            this.colDataEdicaoCliente.OptionsFilter.AllowAutoFilter = false;
            this.colDataEdicaoCliente.OptionsFilter.AllowFilter = false;
            this.colDataEdicaoCliente.Visible = true;
            this.colDataEdicaoCliente.VisibleIndex = 6;
            this.colDataEdicaoCliente.Width = 110;
            // 
            // colDataCadastroCliente
            // 
            this.colDataCadastroCliente.Caption = "Cadastro";
            this.colDataCadastroCliente.FieldName = "DataCadastroCliente";
            this.colDataCadastroCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDataCadastroCliente.ImageOptions.Image")));
            this.colDataCadastroCliente.Name = "colDataCadastroCliente";
            this.colDataCadastroCliente.OptionsColumn.AllowMove = false;
            this.colDataCadastroCliente.OptionsColumn.AllowShowHide = false;
            this.colDataCadastroCliente.OptionsColumn.AllowSize = false;
            this.colDataCadastroCliente.OptionsColumn.FixedWidth = true;
            this.colDataCadastroCliente.OptionsFilter.AllowAutoFilter = false;
            this.colDataCadastroCliente.OptionsFilter.AllowFilter = false;
            this.colDataCadastroCliente.Visible = true;
            this.colDataCadastroCliente.VisibleIndex = 7;
            this.colDataCadastroCliente.Width = 90;
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
            this.btnSalvar.Location = new System.Drawing.Point(12, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 57);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Novo [ + ]";
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditar.Appearance.Options.UseBackColor = true;
            this.btnEditar.ImageOptions.Image = global::projeto2.Properties.Resources.edit_32x321;
            this.btnEditar.Location = new System.Drawing.Point(120, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 57);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar [ F4 ]";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Appearance.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Appearance.Options.UseBackColor = true;
            this.btnExcluir.ImageOptions.Image = global::projeto2.Properties.Resources.delete_32x32;
            this.btnExcluir.Location = new System.Drawing.Point(228, 15);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 57);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir [Del]";
            // 
            // gpcBotoes
            // 
            this.gpcBotoes.Controls.Add(this.btnSalvar);
            this.gpcBotoes.Controls.Add(this.btnEditar);
            this.gpcBotoes.Controls.Add(this.btnExcluir);
            this.gpcBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcBotoes.Location = new System.Drawing.Point(0, 0);
            this.gpcBotoes.Name = "gpcBotoes";
            this.gpcBotoes.ShowCaption = false;
            this.gpcBotoes.Size = new System.Drawing.Size(761, 87);
            this.gpcBotoes.TabIndex = 17;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // FrmClientesDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 434);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.gpcBotoes);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmClientesDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).EndInit();
            this.gpcBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutos;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.GroupControl gpcBotoes;
        private System.Windows.Forms.BindingSource clienteModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCadastroCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDataEdicaoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPessoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNomePessoa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailPessoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonePessoa;
        private DevExpress.XtraGrid.Columns.GridColumn colCelularPessoa;
        private DevExpress.XtraGrid.Columns.GridColumn colCidadePessoa;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
    }
}