namespace projeto2.Feature.Produto.View.WinForms
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.tblBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            this.tblBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.CodigoDeBarras,
            this.fornecedorProdutoDataGridViewTextBoxColumn});
            this.dgvProduto.DataSource = this.produtoBindingSource;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvProduto.Location = new System.Drawing.Point(0, 92);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProduto.RowTemplate.ReadOnly = true;
            this.dgvProduto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(758, 358);
            this.dgvProduto.TabIndex = 1;
            this.dgvProduto.TabStop = false;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduto_CellDoubleClick);
            this.dgvProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProduto_CellFormatting);
            this.dgvProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProduto_CellMouseClick);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Nº";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodigoDeBarras.DataPropertyName = "CodigoDeBarras";
            this.CodigoDeBarras.HeaderText = "Código de barras";
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            this.CodigoDeBarras.ReadOnly = true;
            this.CodigoDeBarras.Width = 150;
            // 
            // fornecedorProdutoDataGridViewTextBoxColumn
            // 
            this.fornecedorProdutoDataGridViewTextBoxColumn.DataPropertyName = "FornecedorProduto";
            this.fornecedorProdutoDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorProdutoDataGridViewTextBoxColumn.Name = "fornecedorProdutoDataGridViewTextBoxColumn";
            this.fornecedorProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlcontrol.Controls.Add(this.dgvProduto);
            this.pnlcontrol.Controls.Add(this.tblBotoes);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(758, 450);
            this.pnlcontrol.TabIndex = 4;
            // 
            // tblBotoes
            // 
            this.tblBotoes.ColumnCount = 5;
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.Controls.Add(this.btnExcluir, 4, 0);
            this.tblBotoes.Controls.Add(this.btnEditar, 3, 0);
            this.tblBotoes.Controls.Add(this.btnCadastrar, 1, 0);
            this.tblBotoes.Controls.Add(this.btnEstoque, 0, 0);
            this.tblBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBotoes.Location = new System.Drawing.Point(0, 0);
            this.tblBotoes.Name = "tblBotoes";
            this.tblBotoes.RowCount = 1;
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBotoes.Size = new System.Drawing.Size(758, 92);
            this.tblBotoes.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExcluir.Image = global::projeto2.Properties.Resources.garbage;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(294, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 85);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir - [ Del ]";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditar.Image = global::projeto2.Properties.Resources.compose;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(197, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 85);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar - [ F4 ]";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCadastrar.Image = global::projeto2.Properties.Resources.plus;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(100, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 85);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Adicionar - [ + ]";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEstoque.Image = global::projeto2.Properties.Resources.package;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstoque.Location = new System.Drawing.Point(3, 3);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(91, 85);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque - [ E ]";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GrupoProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 738;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GrupoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 369;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MarcaProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 369;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GrupoProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 369;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MarcaProduto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 369;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.pnlcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProdutos";
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.tblBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.TableLayoutPanel tblBotoes;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorProdutoDataGridViewTextBoxColumn;
    }
}

