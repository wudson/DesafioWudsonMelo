﻿namespace projeto2.Feature.Produto.View.Dev
{
    partial class FrmProdutosDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutosDev));
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstoque = new DevExpress.XtraEditors.SimpleButton();
            this.gpcBotoes = new DevExpress.XtraEditors.GroupControl();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gvProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoDeBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fornecedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvProdutos = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).BeginInit();
            this.gpcBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Appearance.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Appearance.Options.UseBackColor = true;
            this.btnExcluir.ImageOptions.Image = global::projeto2.Properties.Resources.delete_32x32;
            this.btnExcluir.Location = new System.Drawing.Point(336, 15);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 57);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir [Del]";
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditar.Appearance.Options.UseBackColor = true;
            this.btnEditar.ImageOptions.Image = global::projeto2.Properties.Resources.edit_32x321;
            this.btnEditar.Location = new System.Drawing.Point(228, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 57);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar [ F4 ]";
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x321;
            this.btnSalvar.Location = new System.Drawing.Point(120, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 57);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Novo [ + ]";
            this.btnSalvar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEstoque.Appearance.Options.UseBackColor = true;
            this.btnEstoque.ImageOptions.Image = global::projeto2.Properties.Resources.boproduct_32x32;
            this.btnEstoque.Location = new System.Drawing.Point(12, 15);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(102, 57);
            this.btnEstoque.TabIndex = 15;
            this.btnEstoque.Text = "Estoque [ E ]";
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // gpcBotoes
            // 
            this.gpcBotoes.Controls.Add(this.btnEstoque);
            this.gpcBotoes.Controls.Add(this.btnSalvar);
            this.gpcBotoes.Controls.Add(this.btnEditar);
            this.gpcBotoes.Controls.Add(this.btnExcluir);
            this.gpcBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcBotoes.Location = new System.Drawing.Point(0, 0);
            this.gpcBotoes.Name = "gpcBotoes";
            this.gpcBotoes.ShowCaption = false;
            this.gpcBotoes.Size = new System.Drawing.Size(861, 87);
            this.gpcBotoes.TabIndex = 15;
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
            // gvProdutos
            // 
            this.gvProdutos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdProduto,
            this.NomeProduto,
            this.CodigoDeBarras,
            this.Fornecedor});
            this.gvProdutos.GridControl = this.dgvProdutos;
            this.gvProdutos.GroupPanelText = " ";
            this.gvProdutos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvProdutos.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvProdutos.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvProdutos.OptionsPrint.PrintVertLines = false;
            this.gvProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutos.OptionsView.ShowFooter = true;
            this.gvProdutos.OptionsView.ShowIndicator = false;
            this.gvProdutos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvProdutos_FocusedRowChanged);
            // 
            // IdProduto
            // 
            this.IdProduto.Caption = "Código";
            this.IdProduto.FieldName = "IdProduto";
            this.IdProduto.ImageOptions.Image = global::projeto2.Properties.Resources.bopermission_16x16;
            this.IdProduto.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.OptionsColumn.AllowEdit = false;
            this.IdProduto.OptionsColumn.AllowFocus = false;
            this.IdProduto.OptionsColumn.FixedWidth = true;
            this.IdProduto.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.IdProduto.OptionsFilter.AllowAutoFilter = false;
            this.IdProduto.OptionsFilter.AllowFilter = false;
            this.IdProduto.Visible = true;
            this.IdProduto.VisibleIndex = 0;
            this.IdProduto.Width = 60;
            // 
            // NomeProduto
            // 
            this.NomeProduto.Caption = "Produto";
            this.NomeProduto.FieldName = "NomeProduto";
            this.NomeProduto.ImageOptions.Image = global::projeto2.Properties.Resources.boproductgroup_16x16;
            this.NomeProduto.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.OptionsColumn.AllowEdit = false;
            this.NomeProduto.OptionsColumn.AllowFocus = false;
            this.NomeProduto.OptionsColumn.AllowMove = false;
            this.NomeProduto.OptionsColumn.FixedWidth = true;
            this.NomeProduto.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.NomeProduto.OptionsFilter.AllowAutoFilter = false;
            this.NomeProduto.OptionsFilter.AllowFilter = false;
            this.NomeProduto.Visible = true;
            this.NomeProduto.VisibleIndex = 1;
            this.NomeProduto.Width = 225;
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.Caption = "Código de barras";
            this.CodigoDeBarras.FieldName = "CodigoDeBarras";
            this.CodigoDeBarras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CodigoDeBarras.ImageOptions.Image")));
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            this.CodigoDeBarras.OptionsColumn.AllowEdit = false;
            this.CodigoDeBarras.OptionsColumn.AllowFocus = false;
            this.CodigoDeBarras.OptionsColumn.FixedWidth = true;
            this.CodigoDeBarras.OptionsFilter.AllowAutoFilter = false;
            this.CodigoDeBarras.OptionsFilter.AllowFilter = false;
            this.CodigoDeBarras.Visible = true;
            this.CodigoDeBarras.VisibleIndex = 2;
            this.CodigoDeBarras.Width = 110;
            // 
            // Fornecedor
            // 
            this.Fornecedor.Caption = "Fornecedor";
            this.Fornecedor.FieldName = "FornecedorProduto";
            this.Fornecedor.ImageOptions.Image = global::projeto2.Properties.Resources.bocustomer_16x16;
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.OptionsColumn.AllowEdit = false;
            this.Fornecedor.OptionsColumn.AllowFocus = false;
            this.Fornecedor.OptionsColumn.FixedWidth = true;
            this.Fornecedor.OptionsFilter.AllowAutoFilter = false;
            this.Fornecedor.OptionsFilter.AllowFilter = false;
            this.Fornecedor.Visible = true;
            this.Fornecedor.VisibleIndex = 3;
            this.Fornecedor.Width = 180;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.DataSource = this.produtoBindingSource;
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
            this.dgvProdutos.Size = new System.Drawing.Size(861, 391);
            this.dgvProdutos.TabIndex = 6;
            this.dgvProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutos});
            // 
            // FrmProdutosDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 478);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.gpcBotoes);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProdutosDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBotoes)).EndInit();
            this.gpcBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnEstoque;
        private DevExpress.XtraEditors.GroupControl gpcBotoes;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn IdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn NomeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoDeBarras;
        private DevExpress.XtraGrid.Columns.GridColumn Fornecedor;
        private DevExpress.XtraGrid.GridControl dgvProdutos;
    }
}