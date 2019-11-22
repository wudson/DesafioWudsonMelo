namespace projeto2.Feature.Pedido.View.Dev
{
    partial class FrmPedidosDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosDev));
            this.dgvPedidos = new DevExpress.XtraGrid.GridControl();
            this.pedidoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoTotalPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gpcBotoes = new DevExpress.XtraEditors.GroupControl();
            this.btnVerProdutos = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).BeginInit();
            this.gpcBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.DataSource = this.pedidoModelBindingSource;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvPedidos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 87);
            this.dgvPedidos.MainView = this.gvPedidos;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvPedidos.Size = new System.Drawing.Size(774, 349);
            this.dgvPedidos.TabIndex = 16;
            this.dgvPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidos});
            // 
            // pedidoModelBindingSource
            // 
            this.pedidoModelBindingSource.DataSource = typeof(projeto2.Feature.Pedido.Model.PedidoModel);
            // 
            // gvPedidos
            // 
            this.gvPedidos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPedido,
            this.colDataPedido,
            this.colPrecoTotalPedido,
            this.colCliente});
            this.gvPedidos.GridControl = this.dgvPedidos;
            this.gvPedidos.GroupPanelText = " ";
            this.gvPedidos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvPedidos.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvPedidos.OptionsDetail.EnableMasterViewMode = false;
            this.gvPedidos.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvPedidos.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvPedidos.OptionsPrint.PrintVertLines = false;
            this.gvPedidos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidos.OptionsView.ShowFooter = true;
            this.gvPedidos.OptionsView.ShowIndicator = false;
            this.gvPedidos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvPedidos_FocusedRowChanged);
            // 
            // colIdPedido
            // 
            this.colIdPedido.Caption = "Código";
            this.colIdPedido.FieldName = "IdPedido";
            this.colIdPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIdPedido.ImageOptions.Image")));
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.OptionsColumn.AllowEdit = false;
            this.colIdPedido.OptionsColumn.AllowFocus = false;
            this.colIdPedido.OptionsColumn.FixedWidth = true;
            this.colIdPedido.OptionsFilter.AllowAutoFilter = false;
            this.colIdPedido.OptionsFilter.AllowFilter = false;
            this.colIdPedido.Visible = true;
            this.colIdPedido.VisibleIndex = 0;
            this.colIdPedido.Width = 65;
            // 
            // colDataPedido
            // 
            this.colDataPedido.Caption = "Data";
            this.colDataPedido.FieldName = "DataPedido";
            this.colDataPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDataPedido.ImageOptions.Image")));
            this.colDataPedido.Name = "colDataPedido";
            this.colDataPedido.OptionsColumn.AllowEdit = false;
            this.colDataPedido.OptionsColumn.AllowFocus = false;
            this.colDataPedido.OptionsColumn.FixedWidth = true;
            this.colDataPedido.OptionsFilter.AllowAutoFilter = false;
            this.colDataPedido.OptionsFilter.AllowFilter = false;
            this.colDataPedido.Visible = true;
            this.colDataPedido.VisibleIndex = 1;
            this.colDataPedido.Width = 123;
            // 
            // colPrecoTotalPedido
            // 
            this.colPrecoTotalPedido.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoTotalPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoTotalPedido.Caption = "Preço Total";
            this.colPrecoTotalPedido.DisplayFormat.FormatString = "c2";
            this.colPrecoTotalPedido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoTotalPedido.FieldName = "PrecoTotalPedido";
            this.colPrecoTotalPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPrecoTotalPedido.ImageOptions.Image")));
            this.colPrecoTotalPedido.Name = "colPrecoTotalPedido";
            this.colPrecoTotalPedido.OptionsColumn.AllowEdit = false;
            this.colPrecoTotalPedido.OptionsColumn.AllowFocus = false;
            this.colPrecoTotalPedido.OptionsColumn.FixedWidth = true;
            this.colPrecoTotalPedido.OptionsFilter.AllowAutoFilter = false;
            this.colPrecoTotalPedido.OptionsFilter.AllowFilter = false;
            this.colPrecoTotalPedido.Visible = true;
            this.colPrecoTotalPedido.VisibleIndex = 2;
            this.colPrecoTotalPedido.Width = 120;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente.NomePessoa";
            this.colCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCliente.ImageOptions.Image")));
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            this.colCliente.OptionsColumn.AllowFocus = false;
            this.colCliente.OptionsColumn.FixedWidth = true;
            this.colCliente.OptionsFilter.AllowAutoFilter = false;
            this.colCliente.OptionsFilter.AllowFilter = false;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 250;
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
            // gpcBotoes
            // 
            this.gpcBotoes.Controls.Add(this.btnVerProdutos);
            this.gpcBotoes.Controls.Add(this.btnSalvar);
            this.gpcBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcBotoes.Location = new System.Drawing.Point(0, 0);
            this.gpcBotoes.Name = "gpcBotoes";
            this.gpcBotoes.ShowCaption = false;
            this.gpcBotoes.Size = new System.Drawing.Size(774, 87);
            this.gpcBotoes.TabIndex = 17;
            // 
            // btnVerProdutos
            // 
            this.btnVerProdutos.Appearance.BackColor = System.Drawing.Color.White;
            this.btnVerProdutos.Appearance.Options.UseBackColor = true;
            this.btnVerProdutos.Enabled = false;
            this.btnVerProdutos.ImageOptions.Image = global::projeto2.Properties.Resources.show_32x32;
            this.btnVerProdutos.Location = new System.Drawing.Point(120, 15);
            this.btnVerProdutos.Name = "btnVerProdutos";
            this.btnVerProdutos.Size = new System.Drawing.Size(129, 57);
            this.btnVerProdutos.TabIndex = 18;
            this.btnVerProdutos.Text = "Ver produtos [ i ]";
            this.btnVerProdutos.Click += new System.EventHandler(this.BtnVerProdutos_Click);
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
            // FrmPedidosDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 436);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.gpcBotoes);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmPedidosDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedidos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).EndInit();
            this.gpcBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.GroupControl gpcBotoes;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.BindingSource pedidoModelBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnVerProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoTotalPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
    }
}