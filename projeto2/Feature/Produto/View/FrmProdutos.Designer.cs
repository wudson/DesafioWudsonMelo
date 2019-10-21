namespace projeto2.Feature.Produto.View
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.tblBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnListar = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.PictureBox();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            this.tblBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
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
            this.grupoProdutoDataGridViewTextBoxColumn,
            this.marcaProdutoDataGridViewTextBoxColumn,
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn,
            this.valorCompraProdutoDataGridViewTextBoxColumn,
            this.valorVendaProdutoDataGridViewTextBoxColumn,
            this.fornecedorProdutoDataGridViewTextBoxColumn});
            this.dgvProduto.DataSource = this.produtoBindingSource;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvProduto.Location = new System.Drawing.Point(0, 75);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProduto.RowTemplate.ReadOnly = true;
            this.dgvProduto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(703, 375);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduto_CellDoubleClick);
            this.dgvProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProduto_CellMouseClick);
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlcontrol.Controls.Add(this.dgvProduto);
            this.pnlcontrol.Controls.Add(this.tblBotoes);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(703, 450);
            this.pnlcontrol.TabIndex = 4;
            // 
            // tblBotoes
            // 
            this.tblBotoes.ColumnCount = 4;
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.Controls.Add(this.btnExcluir, 3, 0);
            this.tblBotoes.Controls.Add(this.btnEditar, 2, 0);
            this.tblBotoes.Controls.Add(this.btnListar, 1, 0);
            this.tblBotoes.Controls.Add(this.btnCadastrar, 0, 0);
            this.tblBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBotoes.Location = new System.Drawing.Point(0, 0);
            this.tblBotoes.Name = "tblBotoes";
            this.tblBotoes.RowCount = 1;
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBotoes.Size = new System.Drawing.Size(703, 75);
            this.tblBotoes.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::projeto2.Properties.Resources.error;
            this.btnExcluir.Location = new System.Drawing.Point(237, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 69);
            this.btnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::projeto2.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(159, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 69);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnEditar.TabIndex = 7;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Image = global::projeto2.Properties.Resources.clipboard;
            this.btnListar.Location = new System.Drawing.Point(81, 3);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(72, 69);
            this.btnListar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnListar.TabIndex = 5;
            this.btnListar.TabStop = false;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Image = global::projeto2.Properties.Resources.plus;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(72, 69);
            this.btnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.FillWeight = 81.21828F;
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoProdutoDataGridViewTextBoxColumn
            // 
            this.grupoProdutoDataGridViewTextBoxColumn.DataPropertyName = "GrupoProduto";
            this.grupoProdutoDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.grupoProdutoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoProdutoDataGridViewTextBoxColumn.Name = "grupoProdutoDataGridViewTextBoxColumn";
            this.grupoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaProdutoDataGridViewTextBoxColumn
            // 
            this.marcaProdutoDataGridViewTextBoxColumn.DataPropertyName = "MarcaProduto";
            this.marcaProdutoDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.marcaProdutoDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaProdutoDataGridViewTextBoxColumn.Name = "marcaProdutoDataGridViewTextBoxColumn";
            this.marcaProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeEstoqueProdutoDataGridViewTextBoxColumn
            // 
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeEstoqueProduto";
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn.Name = "quantidadeEstoqueProdutoDataGridViewTextBoxColumn";
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeEstoqueProdutoDataGridViewTextBoxColumn.Width = 60;
            // 
            // valorCompraProdutoDataGridViewTextBoxColumn
            // 
            this.valorCompraProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorCompraProdutoDataGridViewTextBoxColumn.DataPropertyName = "ValorCompraProduto";
            this.valorCompraProdutoDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.valorCompraProdutoDataGridViewTextBoxColumn.HeaderText = "Compra (R$)";
            this.valorCompraProdutoDataGridViewTextBoxColumn.Name = "valorCompraProdutoDataGridViewTextBoxColumn";
            this.valorCompraProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorCompraProdutoDataGridViewTextBoxColumn.Width = 80;
            // 
            // valorVendaProdutoDataGridViewTextBoxColumn
            // 
            this.valorVendaProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorVendaProdutoDataGridViewTextBoxColumn.DataPropertyName = "ValorVendaProduto";
            this.valorVendaProdutoDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.valorVendaProdutoDataGridViewTextBoxColumn.HeaderText = "Venda (R$)";
            this.valorVendaProdutoDataGridViewTextBoxColumn.Name = "valorVendaProdutoDataGridViewTextBoxColumn";
            this.valorVendaProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorVendaProdutoDataGridViewTextBoxColumn.Width = 80;
            // 
            // fornecedorProdutoDataGridViewTextBoxColumn
            // 
            this.fornecedorProdutoDataGridViewTextBoxColumn.DataPropertyName = "FornecedorProduto";
            this.fornecedorProdutoDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.fornecedorProdutoDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorProdutoDataGridViewTextBoxColumn.Name = "fornecedorProdutoDataGridViewTextBoxColumn";
            this.fornecedorProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.pnlcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProdutos";
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.tblBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnCadastrar;
        private System.Windows.Forms.PictureBox btnListar;
        private System.Windows.Forms.TableLayoutPanel tblBotoes;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoqueProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorProdutoDataGridViewTextBoxColumn;
    }
}

