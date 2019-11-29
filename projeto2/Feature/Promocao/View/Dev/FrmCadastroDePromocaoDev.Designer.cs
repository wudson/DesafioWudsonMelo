namespace projeto2.Feature.Promocao.View.Dev
{
    partial class FrmCadastroDePromocaoDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDePromocaoDev));
            this.txtPorcentagem = new DevExpress.XtraEditors.TextEdit();
            this.txtTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDataInicio = new DevExpress.XtraEditors.DateEdit();
            this.txtDataFim = new DevExpress.XtraEditors.DateEdit();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpTipoDesconto = new DevExpress.XtraEditors.RadioGroup();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelecionarProdutos = new DevExpress.XtraEditors.SimpleButton();
            this.grpDesconto = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.dgvProdutosPromocao = new DevExpress.XtraGrid.GridControl();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProdutosPromocao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCompraProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorVendaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grpDadosPromocao = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipoDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDesconto)).BeginInit();
            this.grpDesconto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDadosPromocao)).BeginInit();
            this.grpDadosPromocao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.EditValue = "";
            this.txtPorcentagem.Location = new System.Drawing.Point(17, 73);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Properties.Mask.EditMask = "\\d{1,3}%";
            this.txtPorcentagem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPorcentagem.Properties.Mask.SaveLiteral = false;
            this.txtPorcentagem.Size = new System.Drawing.Size(137, 20);
            this.txtPorcentagem.TabIndex = 0;
            this.txtPorcentagem.Visible = false;
            this.txtPorcentagem.Leave += new System.EventHandler(this.TxtPorcentagem_Leave);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(16, 42);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTipo.Properties.Items.AddRange(new object[] {
            "Desconto"});
            this.txtTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtTipo.Size = new System.Drawing.Size(356, 20);
            this.txtTipo.TabIndex = 1;
            this.txtTipo.SelectedIndexChanged += new System.EventHandler(this.TxtTipo_SelectedIndexChanged);
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.EditValue = null;
            this.txtDataInicio.Location = new System.Drawing.Point(9, 25);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Size = new System.Drawing.Size(142, 20);
            this.txtDataInicio.TabIndex = 2;
            // 
            // txtDataFim
            // 
            this.txtDataFim.EditValue = null;
            this.txtDataFim.Location = new System.Drawing.Point(183, 25);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFim.Size = new System.Drawing.Size(142, 20);
            this.txtDataFim.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 50;
            this.txtNome.Size = new System.Drawing.Size(477, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Tipo";
            // 
            // grpTipoDesconto
            // 
            this.grpTipoDesconto.Location = new System.Drawing.Point(5, 30);
            this.grpTipoDesconto.Name = "grpTipoDesconto";
            this.grpTipoDesconto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grpTipoDesconto.Properties.Appearance.Options.UseBackColor = true;
            this.grpTipoDesconto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grpTipoDesconto.Properties.Columns = 2;
            this.grpTipoDesconto.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Valor fixo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Porcentagem")});
            this.grpTipoDesconto.Size = new System.Drawing.Size(184, 37);
            this.grpTipoDesconto.TabIndex = 18;
            this.grpTipoDesconto.EditValueChanged += new System.EventHandler(this.GrpTipoDesconto_EditValueChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAplicar.Appearance.Options.UseBackColor = true;
            this.btnAplicar.ImageOptions.Image = global::projeto2.Properties.Resources.bosale_16x16;
            this.btnAplicar.Location = new System.Drawing.Point(174, 69);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(86, 27);
            this.btnAplicar.TabIndex = 19;
            this.btnAplicar.Text = "Aplicar [ F7 ]";
            this.btnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // btnSelecionarProdutos
            // 
            this.btnSelecionarProdutos.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSelecionarProdutos.Appearance.Options.UseBackColor = true;
            this.btnSelecionarProdutos.Enabled = false;
            this.btnSelecionarProdutos.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x323;
            this.btnSelecionarProdutos.Location = new System.Drawing.Point(521, 33);
            this.btnSelecionarProdutos.Name = "btnSelecionarProdutos";
            this.btnSelecionarProdutos.Size = new System.Drawing.Size(170, 37);
            this.btnSelecionarProdutos.TabIndex = 16;
            this.btnSelecionarProdutos.Text = "Selecionar produtos [ F9 ]";
            this.btnSelecionarProdutos.Click += new System.EventHandler(this.BtnSelecionarProdutosDaPromocao_Click);
            // 
            // grpDesconto
            // 
            this.grpDesconto.Controls.Add(this.labelControl11);
            this.grpDesconto.Controls.Add(this.labelControl10);
            this.grpDesconto.Controls.Add(this.groupControl4);
            this.grpDesconto.Controls.Add(this.txtValor);
            this.grpDesconto.Controls.Add(this.grpTipoDesconto);
            this.grpDesconto.Controls.Add(this.btnAplicar);
            this.grpDesconto.Controls.Add(this.txtPorcentagem);
            this.grpDesconto.Enabled = false;
            this.grpDesconto.Location = new System.Drawing.Point(16, 77);
            this.grpDesconto.Name = "grpDesconto";
            this.grpDesconto.Size = new System.Drawing.Size(800, 100);
            this.grpDesconto.TabIndex = 20;
            this.grpDesconto.Text = "Desconto";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(524, 76);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(242, 13);
            this.labelControl10.TabIndex = 35;
            this.labelControl10.Text = "Preço com desconto menor que o preço de compra";
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Red;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl4.Location = new System.Drawing.Point(505, 76);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(13, 12);
            this.groupControl4.TabIndex = 34;
            this.groupControl4.Text = "groupControl4";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(17, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.DisplayFormat.FormatString = "c2";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.MaxLength = 7;
            this.txtValor.Size = new System.Drawing.Size(137, 20);
            this.txtValor.TabIndex = 33;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Nome";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Início";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(183, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(16, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Fim";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.ImageOptions.Image = global::projeto2.Properties.Resources.apply_32x32;
            this.btnSalvar.Location = new System.Drawing.Point(570, 495);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 57);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar [F5]";
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarPromocao_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x32;
            this.btnCancelar.Location = new System.Drawing.Point(695, 495);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 57);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar [Esc]";
            // 
            // dgvProdutosPromocao
            // 
            this.dgvProdutosPromocao.DataSource = this.produtoBindingSource;
            this.dgvProdutosPromocao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvProdutosPromocao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvProdutosPromocao.Location = new System.Drawing.Point(0, 183);
            this.dgvProdutosPromocao.MainView = this.gvProdutosPromocao;
            this.dgvProdutosPromocao.Name = "dgvProdutosPromocao";
            this.dgvProdutosPromocao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvProdutosPromocao.Size = new System.Drawing.Size(830, 283);
            this.dgvProdutosPromocao.TabIndex = 26;
            this.dgvProdutosPromocao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutosPromocao});
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // gvProdutosPromocao
            // 
            this.gvProdutosPromocao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvProdutosPromocao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto,
            this.colNomeProduto,
            this.colValorCompraProduto,
            this.colValorVendaProduto,
            this.colDesconto});
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
            this.gvProdutosPromocao.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GvProdutosPromocao_CustomDrawCell);
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
            this.colValorCompraProduto.VisibleIndex = 2;
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
            this.colValorVendaProduto.VisibleIndex = 3;
            this.colValorVendaProduto.Width = 126;
            // 
            // colDesconto
            // 
            this.colDesconto.Caption = "Venda com desconto";
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
            this.colDesconto.VisibleIndex = 4;
            this.colDesconto.Width = 122;
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
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(741, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "( * ) Obrigatório";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(36, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(6, 13);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(33, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(6, 13);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(35, 50);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(6, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "*";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(198, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(6, 13);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "*";
            // 
            // grpDadosPromocao
            // 
            this.grpDadosPromocao.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grpDadosPromocao.Appearance.Options.UseBackColor = true;
            this.grpDadosPromocao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grpDadosPromocao.Controls.Add(this.labelControl3);
            this.grpDadosPromocao.Controls.Add(this.labelControl8);
            this.grpDadosPromocao.Controls.Add(this.txtDataInicio);
            this.grpDadosPromocao.Controls.Add(this.labelControl7);
            this.grpDadosPromocao.Controls.Add(this.txtDataFim);
            this.grpDadosPromocao.Controls.Add(this.labelControl6);
            this.grpDadosPromocao.Controls.Add(this.txtNome);
            this.grpDadosPromocao.Controls.Add(this.labelControl2);
            this.grpDadosPromocao.Controls.Add(this.labelControl4);
            this.grpDadosPromocao.Enabled = false;
            this.grpDadosPromocao.Location = new System.Drawing.Point(0, 469);
            this.grpDadosPromocao.Name = "grpDadosPromocao";
            this.grpDadosPromocao.ShowCaption = false;
            this.grpDadosPromocao.Size = new System.Drawing.Size(564, 93);
            this.grpDadosPromocao.TabIndex = 32;
            this.grpDadosPromocao.Text = "groupControl1";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(64, 3);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(6, 13);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "*";
            // 
            // FrmCadastroDePromocaoDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 566);
            this.Controls.Add(this.grpDadosPromocao);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dgvProdutosPromocao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDesconto);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSelecionarProdutos);
            this.Controls.Add(this.txtTipo);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmCadastroDePromocaoDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de promoção";
            this.Load += new System.EventHandler(this.FrmCadastroDePromocaoDev_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroDePromcao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipoDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDesconto)).EndInit();
            this.grpDesconto.ResumeLayout(false);
            this.grpDesconto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDadosPromocao)).EndInit();
            this.grpDadosPromocao.ResumeLayout(false);
            this.grpDadosPromocao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPorcentagem;
        private DevExpress.XtraEditors.ComboBoxEdit txtTipo;
        private DevExpress.XtraEditors.DateEdit txtDataInicio;
        private DevExpress.XtraEditors.DateEdit txtDataFim;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.SimpleButton btnSelecionarProdutos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup grpTipoDesconto;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.GroupControl grpDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraGrid.GridControl dgvProdutosPromocao;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutosPromocao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCompraProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorVendaProduto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl grpDadosPromocao;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}