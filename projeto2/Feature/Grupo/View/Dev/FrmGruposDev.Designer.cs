namespace projeto2.Feature.Grupo.View.Dev
{
    partial class FrmGruposDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGruposDev));
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluirGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.txtGrupo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvGrupos = new DevExpress.XtraGrid.GridControl();
            this.grupoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvGrupos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(440, 27);
            this.txtId.MaxLength = 25;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(62, 21);
            this.txtId.TabIndex = 21;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditar.Appearance.Options.UseBackColor = true;
            this.btnEditar.ImageOptions.Image = global::projeto2.Properties.Resources.edit_32x321;
            this.btnEditar.Location = new System.Drawing.Point(126, 53);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 57);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar [ F4 ]";
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnExcluirGrupo
            // 
            this.btnExcluirGrupo.Appearance.BackColor = System.Drawing.Color.White;
            this.btnExcluirGrupo.Appearance.Options.UseBackColor = true;
            this.btnExcluirGrupo.ImageOptions.Image = global::projeto2.Properties.Resources.delete_32x32;
            this.btnExcluirGrupo.Location = new System.Drawing.Point(240, 53);
            this.btnExcluirGrupo.Name = "btnExcluirGrupo";
            this.btnExcluirGrupo.Size = new System.Drawing.Size(108, 57);
            this.btnExcluirGrupo.TabIndex = 19;
            this.btnExcluirGrupo.Text = "Excluir [Del]";
            this.btnExcluirGrupo.Click += new System.EventHandler(this.BtnExcluirGrupo_Click);
            // 
            // btnSalvarGrupo
            // 
            this.btnSalvarGrupo.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvarGrupo.Appearance.Options.UseBackColor = true;
            this.btnSalvarGrupo.ImageOptions.Image = global::projeto2.Properties.Resources.add_32x321;
            this.btnSalvarGrupo.Location = new System.Drawing.Point(12, 53);
            this.btnSalvarGrupo.Name = "btnSalvarGrupo";
            this.btnSalvarGrupo.Size = new System.Drawing.Size(108, 57);
            this.btnSalvarGrupo.TabIndex = 18;
            this.btnSalvarGrupo.Text = "Salvar [Enter]";
            this.btnSalvarGrupo.Click += new System.EventHandler(this.BtnSalvarGrupo_Click);
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(12, 27);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(422, 20);
            this.txtGrupo.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.Location = new System.Drawing.Point(12, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 14);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Grupo";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.DataSource = this.grupoModelBindingSource;
            this.dgvGrupos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGrupos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvGrupos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvGrupos.Location = new System.Drawing.Point(0, 120);
            this.dgvGrupos.MainView = this.gvGrupos;
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.dgvGrupos.Size = new System.Drawing.Size(728, 217);
            this.dgvGrupos.TabIndex = 15;
            this.dgvGrupos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGrupos});
            // 
            // grupoModelBindingSource
            // 
            this.grupoModelBindingSource.DataSource = typeof(projeto2.Feature.Grupo.Model.GrupoModel);
            // 
            // gvGrupos
            // 
            this.gvGrupos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvGrupos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGrupo,
            this.colGrupo});
            this.gvGrupos.GridControl = this.dgvGrupos;
            this.gvGrupos.GroupPanelText = " ";
            this.gvGrupos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gvGrupos.Name = "gvGrupos";
            this.gvGrupos.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvGrupos.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvGrupos.OptionsDetail.EnableMasterViewMode = false;
            this.gvGrupos.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvGrupos.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gvGrupos.OptionsPrint.PrintVertLines = false;
            this.gvGrupos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGrupos.OptionsView.ShowIndicator = false;
            this.gvGrupos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvGrupos_FocusedRowChanged);
            // 
            // colIdGrupo
            // 
            this.colIdGrupo.Caption = "Código";
            this.colIdGrupo.FieldName = "IdGrupo";
            this.colIdGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIdGrupo.ImageOptions.Image")));
            this.colIdGrupo.Name = "colIdGrupo";
            this.colIdGrupo.OptionsColumn.AllowEdit = false;
            this.colIdGrupo.OptionsColumn.AllowFocus = false;
            this.colIdGrupo.OptionsFilter.AllowAutoFilter = false;
            this.colIdGrupo.OptionsFilter.AllowFilter = false;
            this.colIdGrupo.Visible = true;
            this.colIdGrupo.VisibleIndex = 0;
            this.colIdGrupo.Width = 86;
            // 
            // colGrupo
            // 
            this.colGrupo.Caption = "Grupo";
            this.colGrupo.FieldName = "Grupo";
            this.colGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGrupo.ImageOptions.Image")));
            this.colGrupo.Name = "colGrupo";
            this.colGrupo.OptionsColumn.AllowEdit = false;
            this.colGrupo.OptionsColumn.AllowFocus = false;
            this.colGrupo.OptionsFilter.AllowAutoFilter = false;
            this.colGrupo.OptionsFilter.AllowFilter = false;
            this.colGrupo.Visible = true;
            this.colGrupo.VisibleIndex = 1;
            this.colGrupo.Width = 225;
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
            // FrmGruposDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 337);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluirGrupo);
            this.Controls.Add(this.btnSalvarGrupo);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvGrupos);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmGruposDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.FrmGruposDev_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGrupos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnExcluirGrupo;
        private DevExpress.XtraEditors.SimpleButton btnSalvarGrupo;
        private DevExpress.XtraEditors.TextEdit txtGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvGrupos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGrupos;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource grupoModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
    }
}