namespace projeto2.Feature.Produto.View.Dev
{
    partial class FrmCadastroDeProdutoDev
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Estoque = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Marca = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoDeBarras = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantidadeEmEstoque = new DevExpress.XtraEditors.TextEdit();
            this.txtValorDeVenda = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorDeCompra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMarca = new DevExpress.XtraEditors.LookUpEdit();
            this.btnNovaMarca = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovoGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvarCadastroProduto = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarCadastroProduto = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.marcaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCampos = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDeBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeEmEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCampos)).BeginInit();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "( * ) Obrigatório";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Produto";
            // 
            // Estoque
            // 
            this.Estoque.Location = new System.Drawing.Point(14, 217);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(39, 13);
            this.Estoque.TabIndex = 21;
            this.Estoque.Text = "Estoque";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Grupo";
            // 
            // Marca
            // 
            this.Marca.Location = new System.Drawing.Point(277, 83);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(29, 13);
            this.Marca.TabIndex = 16;
            this.Marca.Text = "Marca";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(14, 146);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTipo.Properties.DropDownRows = 3;
            this.txtTipo.Properties.Items.AddRange(new object[] {
            "Caixa",
            "Peso",
            "Unidade"});
            this.txtTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtTipo.Size = new System.Drawing.Size(252, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(277, 127);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Código de barras";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 100;
            this.txtNome.Size = new System.Drawing.Size(515, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(277, 146);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Properties.MaxLength = 25;
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(252, 20);
            this.txtCodigoDeBarras.TabIndex = 6;
            // 
            // txtQuantidadeEmEstoque
            // 
            this.txtQuantidadeEmEstoque.Location = new System.Drawing.Point(14, 236);
            this.txtQuantidadeEmEstoque.Name = "txtQuantidadeEmEstoque";
            this.txtQuantidadeEmEstoque.Properties.Mask.EditMask = "n0";
            this.txtQuantidadeEmEstoque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidadeEmEstoque.Properties.Mask.SaveLiteral = false;
            this.txtQuantidadeEmEstoque.Properties.MaxLength = 9;
            this.txtQuantidadeEmEstoque.Size = new System.Drawing.Size(252, 20);
            this.txtQuantidadeEmEstoque.TabIndex = 9;
            // 
            // txtValorDeVenda
            // 
            this.txtValorDeVenda.Location = new System.Drawing.Point(277, 191);
            this.txtValorDeVenda.Name = "txtValorDeVenda";
            this.txtValorDeVenda.Properties.DisplayFormat.FormatString = "c2";
            this.txtValorDeVenda.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorDeVenda.Properties.Mask.EditMask = "c2";
            this.txtValorDeVenda.Properties.Mask.IgnoreMaskBlank = false;
            this.txtValorDeVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorDeVenda.Properties.MaxLength = 9;
            this.txtValorDeVenda.Size = new System.Drawing.Size(252, 20);
            this.txtValorDeVenda.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(277, 172);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Venda";
            // 
            // txtValorDeCompra
            // 
            this.txtValorDeCompra.Location = new System.Drawing.Point(14, 191);
            this.txtValorDeCompra.Name = "txtValorDeCompra";
            this.txtValorDeCompra.Properties.DisplayFormat.FormatString = "c2";
            this.txtValorDeCompra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorDeCompra.Properties.Mask.EditMask = "c2";
            this.txtValorDeCompra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorDeCompra.Properties.MaxLength = 9;
            this.txtValorDeCompra.Size = new System.Drawing.Size(252, 20);
            this.txtValorDeCompra.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 172);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Compra";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(14, 281);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Properties.MaxLength = 50;
            this.txtFornecedor.Size = new System.Drawing.Size(515, 20);
            this.txtFornecedor.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 262);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Fornecedor";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(51, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(6, 13);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "*";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(64, 260);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(6, 13);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "*";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(306, 170);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(6, 13);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "*";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(50, 170);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(6, 13);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "*";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(33, 125);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(6, 13);
            this.labelControl13.TabIndex = 26;
            this.labelControl13.Text = "*";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(42, 81);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(6, 13);
            this.labelControl14.TabIndex = 25;
            this.labelControl14.Text = "*";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(14, 102);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Grupo", "Grupo", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtGrupo.Properties.DataSource = this.grupoModelBindingSource;
            this.txtGrupo.Properties.DisplayMember = "Grupo";
            this.txtGrupo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.txtGrupo.Properties.ValueMember = "IdGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(228, 20);
            this.txtGrupo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(277, 102);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMarca.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Marca", "Marca", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtMarca.Properties.DataSource = this.marcaModelBindingSource;
            this.txtMarca.Properties.DisplayMember = "Marca";
            this.txtMarca.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.txtMarca.Properties.ValueMember = "IdMarca";
            this.txtMarca.Size = new System.Drawing.Size(228, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Appearance.BackColor = System.Drawing.Color.White;
            this.btnNovaMarca.Appearance.Options.UseBackColor = true;
            this.btnNovaMarca.ImageOptions.Image = global::projeto2.Properties.Resources.add_16x16;
            this.btnNovaMarca.Location = new System.Drawing.Point(506, 102);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(23, 20);
            this.btnNovaMarca.TabIndex = 4;
            this.btnNovaMarca.Click += new System.EventHandler(this.BtnNovaMarca_Click);
            this.btnNovaMarca.MouseHover += new System.EventHandler(this.BtnNovaMarca_MouseHover);
            // 
            // btnNovoGrupo
            // 
            this.btnNovoGrupo.Appearance.BackColor = System.Drawing.Color.White;
            this.btnNovoGrupo.Appearance.Options.UseBackColor = true;
            this.btnNovoGrupo.ImageOptions.Image = global::projeto2.Properties.Resources.add_16x16;
            this.btnNovoGrupo.Location = new System.Drawing.Point(243, 102);
            this.btnNovoGrupo.Name = "btnNovoGrupo";
            this.btnNovoGrupo.Size = new System.Drawing.Size(23, 20);
            this.btnNovoGrupo.TabIndex = 2;
            this.btnNovoGrupo.Click += new System.EventHandler(this.BtnNovoGrupo_Click);
            this.btnNovoGrupo.MouseHover += new System.EventHandler(this.BtnNovoGrupo_MouseHover);
            // 
            // btnSalvarCadastroProduto
            // 
            this.btnSalvarCadastroProduto.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvarCadastroProduto.Appearance.Options.UseBackColor = true;
            this.btnSalvarCadastroProduto.ImageOptions.Image = global::projeto2.Properties.Resources.apply_32x32;
            this.btnSalvarCadastroProduto.Location = new System.Drawing.Point(150, 315);
            this.btnSalvarCadastroProduto.Name = "btnSalvarCadastroProduto";
            this.btnSalvarCadastroProduto.Size = new System.Drawing.Size(121, 57);
            this.btnSalvarCadastroProduto.TabIndex = 11;
            this.btnSalvarCadastroProduto.Text = "Salvar [Enter]";
            this.btnSalvarCadastroProduto.Click += new System.EventHandler(this.BtnSalvarCadastroProduto_Click);
            // 
            // btnCancelarCadastroProduto
            // 
            this.btnCancelarCadastroProduto.Appearance.BackColor = System.Drawing.Color.White;
            this.btnCancelarCadastroProduto.Appearance.Options.UseBackColor = true;
            this.btnCancelarCadastroProduto.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_32x32;
            this.btnCancelarCadastroProduto.Location = new System.Drawing.Point(275, 315);
            this.btnCancelarCadastroProduto.Name = "btnCancelarCadastroProduto";
            this.btnCancelarCadastroProduto.Size = new System.Drawing.Size(121, 57);
            this.btnCancelarCadastroProduto.TabIndex = 13;
            this.btnCancelarCadastroProduto.Text = "Cancelar [Esc]";
            this.btnCancelarCadastroProduto.Click += new System.EventHandler(this.BtnCancelarCadastroProduto_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditar.Appearance.Options.UseBackColor = true;
            this.btnEditar.ImageOptions.Image = global::projeto2.Properties.Resources.apply_32x32;
            this.btnEditar.Location = new System.Drawing.Point(150, 315);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 57);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Salvar [Enter]";
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // marcaModelBindingSource
            // 
            this.marcaModelBindingSource.DataSource = typeof(projeto2.Feature.Marca.Model.MarcaModel);
            // 
            // grupoModelBindingSource
            // 
            this.grupoModelBindingSource.DataSource = typeof(projeto2.Feature.Grupo.Model.GrupoModel);
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.txtMarca);
            this.pnlCampos.Controls.Add(this.labelControl1);
            this.pnlCampos.Controls.Add(this.txtGrupo);
            this.pnlCampos.Controls.Add(this.btnEditar);
            this.pnlCampos.Controls.Add(this.labelControl14);
            this.pnlCampos.Controls.Add(this.labelControl2);
            this.pnlCampos.Controls.Add(this.labelControl13);
            this.pnlCampos.Controls.Add(this.Estoque);
            this.pnlCampos.Controls.Add(this.labelControl12);
            this.pnlCampos.Controls.Add(this.labelControl4);
            this.pnlCampos.Controls.Add(this.labelControl11);
            this.pnlCampos.Controls.Add(this.Marca);
            this.pnlCampos.Controls.Add(this.labelControl10);
            this.pnlCampos.Controls.Add(this.txtTipo);
            this.pnlCampos.Controls.Add(this.labelControl9);
            this.pnlCampos.Controls.Add(this.labelControl5);
            this.pnlCampos.Controls.Add(this.btnNovaMarca);
            this.pnlCampos.Controls.Add(this.labelControl6);
            this.pnlCampos.Controls.Add(this.btnNovoGrupo);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(this.btnSalvarCadastroProduto);
            this.pnlCampos.Controls.Add(this.txtCodigoDeBarras);
            this.pnlCampos.Controls.Add(this.btnCancelarCadastroProduto);
            this.pnlCampos.Controls.Add(this.txtQuantidadeEmEstoque);
            this.pnlCampos.Controls.Add(this.txtFornecedor);
            this.pnlCampos.Controls.Add(this.labelControl3);
            this.pnlCampos.Controls.Add(this.labelControl8);
            this.pnlCampos.Controls.Add(this.txtValorDeVenda);
            this.pnlCampos.Controls.Add(this.txtValorDeCompra);
            this.pnlCampos.Controls.Add(this.labelControl7);
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampos.Location = new System.Drawing.Point(0, 0);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(543, 385);
            this.pnlCampos.TabIndex = 30;
            // 
            // FrmCadastroDeProdutoDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 385);
            this.Controls.Add(this.pnlCampos);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmCadastroDeProdutoDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.FormCadastroProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroDeProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDeBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeEmEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCampos)).EndInit();
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl Estoque;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl Marca;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit txtTipo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.TextEdit txtCodigoDeBarras;
        private DevExpress.XtraEditors.TextEdit txtQuantidadeEmEstoque;
        private DevExpress.XtraEditors.TextEdit txtValorDeVenda;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtValorDeCompra;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnSalvarCadastroProduto;
        private DevExpress.XtraEditors.SimpleButton btnCancelarCadastroProduto;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnNovoGrupo;
        private DevExpress.XtraEditors.SimpleButton btnNovaMarca;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LookUpEdit txtGrupo;
        private System.Windows.Forms.BindingSource grupoModelBindingSource;
        private DevExpress.XtraEditors.LookUpEdit txtMarca;
        private System.Windows.Forms.BindingSource marcaModelBindingSource;
        private DevExpress.XtraEditors.PanelControl pnlCampos;
    }
}