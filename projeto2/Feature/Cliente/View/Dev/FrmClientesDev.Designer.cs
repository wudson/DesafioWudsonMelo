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
            this.dgvClientes = new DevExpress.XtraGrid.GridControl();
            this.clienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicio = new DevExpress.XtraEditors.DateEdit();
            this.txtDataFim = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).BeginInit();
            this.gpcBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.DataSource = this.clienteModelBindingSource;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvClientes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvClientes.Location = new System.Drawing.Point(0, 83);
            this.dgvClientes.MainView = this.gvClientes;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvClientes.Size = new System.Drawing.Size(470, 675);
            this.dgvClientes.TabIndex = 16;
            this.dgvClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // clienteModelBindingSource
            // 
            this.clienteModelBindingSource.DataSource = typeof(projeto2.Feature.Cliente.Model.ClienteModel);
            // 
            // gvClientes
            // 
            this.gvClientes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPessoa,
            this.colNomePessoa,
            this.colEmailPessoa,
            this.colTelefonePessoa,
            this.colCelularPessoa,
            this.colCidadePessoa,
            this.colDataEdicaoCliente,
            this.colDataCadastroCliente});
            this.gvClientes.GridControl = this.dgvClientes;
            this.gvClientes.GroupPanelText = " ";
            this.gvClientes.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvClientes.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvClientes.OptionsDetail.EnableMasterViewMode = false;
            this.gvClientes.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvClientes.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvClientes.OptionsPrint.PrintVertLines = false;
            this.gvClientes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientes.OptionsView.ShowFooter = true;
            this.gvClientes.OptionsView.ShowIndicator = false;
            this.gvClientes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvClientes_FocusedRowChanged);
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
            this.colDataCadastroCliente.OptionsColumn.AllowEdit = false;
            this.colDataCadastroCliente.OptionsColumn.AllowFocus = false;
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
            this.btnSalvar.Click += new System.EventHandler(this.BtnCadastrar_Click);
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
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
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
            this.gpcBotoes.Size = new System.Drawing.Size(761, 83);
            this.gpcBotoes.TabIndex = 17;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnFiltrar);
            this.groupControl1.Controls.Add(this.btnLimpar);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCidade);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNome);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(470, 83);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(291, 675);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Filtros";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.Appearance.Options.UseBackColor = true;
            this.btnFiltrar.ImageOptions.Image = global::projeto2.Properties.Resources.filter_32x32;
            this.btnFiltrar.Location = new System.Drawing.Point(40, 578);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(107, 36);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "Filtrar [Enter]";
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Appearance.Options.UseBackColor = true;
            this.btnLimpar.ImageOptions.Image = global::projeto2.Properties.Resources.clearfilter_32x32;
            this.btnLimpar.Location = new System.Drawing.Point(153, 578);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 36);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar [F10]";
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtDataInicio);
            this.groupControl2.Controls.Add(this.txtDataFim);
            this.groupControl2.Location = new System.Drawing.Point(5, 152);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(281, 117);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Data de cadastro";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Até";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(13, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "De";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.EditValue = null;
            this.txtDataInicio.Location = new System.Drawing.Point(8, 47);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Size = new System.Drawing.Size(262, 20);
            this.txtDataInicio.TabIndex = 3;
            // 
            // txtDataFim
            // 
            this.txtDataFim.EditValue = null;
            this.txtDataFim.Location = new System.Drawing.Point(8, 90);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFim.Size = new System.Drawing.Size(262, 20);
            this.txtDataFim.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(8, 112);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCidade.Properties.Items.AddRange(new object[] {
            "Jales",
            "Urânia",
            "Angra dos Reis",
            "Rio de Janeiro"});
            this.txtCidade.Size = new System.Drawing.Size(262, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
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
            // FrmClientesDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 758);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gpcBotoes);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmClientesDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).EndInit();
            this.gpcBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.DateEdit txtDataInicio;
        private DevExpress.XtraEditors.ComboBoxEdit txtCidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDataFim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}