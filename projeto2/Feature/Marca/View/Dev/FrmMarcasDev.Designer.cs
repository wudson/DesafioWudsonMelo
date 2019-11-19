namespace projeto2.Feature.Marca.View.Dev
{
    partial class FrmMarcasDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcasDev));
            this.dgvMarcas = new DevExpress.XtraGrid.GridControl();
            this.marcaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMarcas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.btnSalvarMarca = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluirMarca = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.DataSource = this.marcaModelBindingSource;
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMarcas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvMarcas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvMarcas.Location = new System.Drawing.Point(0, 120);
            this.dgvMarcas.MainView = this.gvMarcas;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvMarcas.Size = new System.Drawing.Size(728, 217);
            this.dgvMarcas.TabIndex = 5;
            this.dgvMarcas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMarcas});
            // 
            // marcaModelBindingSource
            // 
            this.marcaModelBindingSource.DataSource = typeof(projeto2.Feature.Marca.Model.MarcaModel);
            // 
            // gvMarcas
            // 
            this.gvMarcas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvMarcas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvMarcas.GridControl = this.dgvMarcas;
            this.gvMarcas.GroupPanelText = " ";
            this.gvMarcas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvMarcas.Name = "gvMarcas";
            this.gvMarcas.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvMarcas.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvMarcas.OptionsDetail.EnableMasterViewMode = false;
            this.gvMarcas.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvMarcas.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvMarcas.OptionsPrint.PrintVertLines = false;
            this.gvMarcas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMarcas.OptionsView.ShowIndicator = false;
            this.gvMarcas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvMarcas_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "IdMarca";
            this.gridColumn1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gridColumn1.ImageOptions.SvgImage")));
            this.gridColumn1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 86;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Marca";
            this.gridColumn2.FieldName = "Marca";
            this.gridColumn2.ImageOptions.Image = global::projeto2.Properties.Resources.star__1_;
            this.gridColumn2.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 225;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.Location = new System.Drawing.Point(12, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 27);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(422, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // btnSalvarMarca
            // 
            this.btnSalvarMarca.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvarMarca.Appearance.Options.UseBackColor = true;
            this.btnSalvarMarca.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x321;
            this.btnSalvarMarca.Location = new System.Drawing.Point(12, 53);
            this.btnSalvarMarca.Name = "btnSalvarMarca";
            this.btnSalvarMarca.Size = new System.Drawing.Size(102, 57);
            this.btnSalvarMarca.TabIndex = 9;
            this.btnSalvarMarca.Text = "Salvar [ + ]";
            this.btnSalvarMarca.Click += new System.EventHandler(this.BtnSalvarMarca_Click);
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.Appearance.BackColor = System.Drawing.Color.White;
            this.btnExcluirMarca.Appearance.Options.UseBackColor = true;
            this.btnExcluirMarca.ImageOptions.Image = global::projeto2.Properties.Resources.delete_32x32;
            this.btnExcluirMarca.Location = new System.Drawing.Point(228, 53);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(102, 57);
            this.btnExcluirMarca.TabIndex = 10;
            this.btnExcluirMarca.Text = "Excluir [Del]";
            this.btnExcluirMarca.Click += new System.EventHandler(this.BtnExcluirMarca_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditar.Appearance.Options.UseBackColor = true;
            this.btnEditar.ImageOptions.Image = global::projeto2.Properties.Resources.edit_32x321;
            this.btnEditar.Location = new System.Drawing.Point(120, 53);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 57);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar [ F4 ]";
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(440, 27);
            this.txtId.MaxLength = 25;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(62, 21);
            this.txtId.TabIndex = 14;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // FrmMarcasDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 337);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluirMarca);
            this.Controls.Add(this.btnSalvarMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvMarcas);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMarcasDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.FrmMarcasDev_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMarcas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvMarcas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMarcas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource marcaModelBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.SimpleButton btnSalvarMarca;
        private DevExpress.XtraEditors.SimpleButton btnExcluirMarca;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private System.Windows.Forms.TextBox txtId;
    }
}