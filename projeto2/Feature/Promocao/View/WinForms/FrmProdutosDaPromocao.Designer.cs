namespace projeto2.Feature.Promocao.View.WinForms
{
    partial class FrmProdutosDaPromocao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutosDaPromocao));
            this.dgvItensPromocao = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorComDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItensPromocao
            // 
            this.dgvItensPromocao.AllowUserToAddRows = false;
            this.dgvItensPromocao.AllowUserToDeleteRows = false;
            this.dgvItensPromocao.AllowUserToResizeColumns = false;
            this.dgvItensPromocao.AllowUserToResizeRows = false;
            this.dgvItensPromocao.AutoGenerateColumns = false;
            this.dgvItensPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.GrupoProduto,
            this.MarcaProduto,
            this.tipoProdutoDataGridViewTextBoxColumn,
            this.valorCompraProdutoDataGridViewTextBoxColumn,
            this.valorVendaProdutoDataGridViewTextBoxColumn,
            this.valorComDescontoDataGridViewTextBoxColumn});
            this.dgvItensPromocao.DataSource = this.produtoBindingSource;
            this.dgvItensPromocao.Location = new System.Drawing.Point(12, 12);
            this.dgvItensPromocao.Name = "dgvItensPromocao";
            this.dgvItensPromocao.ReadOnly = true;
            this.dgvItensPromocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensPromocao.Size = new System.Drawing.Size(878, 275);
            this.dgvItensPromocao.TabIndex = 1;
            this.dgvItensPromocao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvItensPromocao_CellFormatting);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 55;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GrupoProduto
            // 
            this.GrupoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GrupoProduto.DataPropertyName = "GrupoProduto.Grupo";
            this.GrupoProduto.HeaderText = "GrupoProduto";
            this.GrupoProduto.Name = "GrupoProduto";
            this.GrupoProduto.ReadOnly = true;
            this.GrupoProduto.Width = 120;
            // 
            // MarcaProduto
            // 
            this.MarcaProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MarcaProduto.DataPropertyName = "MarcaProduto.Marca";
            this.MarcaProduto.HeaderText = "MarcaProduto";
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.ReadOnly = true;
            this.MarcaProduto.Width = 120;
            // 
            // tipoProdutoDataGridViewTextBoxColumn
            // 
            this.tipoProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipoProdutoDataGridViewTextBoxColumn.DataPropertyName = "TipoProduto";
            this.tipoProdutoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoProdutoDataGridViewTextBoxColumn.Name = "tipoProdutoDataGridViewTextBoxColumn";
            this.tipoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProdutoDataGridViewTextBoxColumn.Width = 70;
            // 
            // valorCompraProdutoDataGridViewTextBoxColumn
            // 
            this.valorCompraProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorCompraProdutoDataGridViewTextBoxColumn.DataPropertyName = "ValorCompraProduto";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valorCompraProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorCompraProdutoDataGridViewTextBoxColumn.HeaderText = "Preço de compra";
            this.valorCompraProdutoDataGridViewTextBoxColumn.Name = "valorCompraProdutoDataGridViewTextBoxColumn";
            this.valorCompraProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorCompraProdutoDataGridViewTextBoxColumn.Width = 75;
            // 
            // valorVendaProdutoDataGridViewTextBoxColumn
            // 
            this.valorVendaProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorVendaProdutoDataGridViewTextBoxColumn.DataPropertyName = "ValorVendaProduto";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorVendaProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorVendaProdutoDataGridViewTextBoxColumn.HeaderText = "Preço de venda";
            this.valorVendaProdutoDataGridViewTextBoxColumn.Name = "valorVendaProdutoDataGridViewTextBoxColumn";
            this.valorVendaProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorVendaProdutoDataGridViewTextBoxColumn.Width = 75;
            // 
            // valorComDescontoDataGridViewTextBoxColumn
            // 
            this.valorComDescontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorComDescontoDataGridViewTextBoxColumn.DataPropertyName = "ValorComDesconto";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorComDescontoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorComDescontoDataGridViewTextBoxColumn.HeaderText = "Preço com desconto";
            this.valorComDescontoDataGridViewTextBoxColumn.Name = "valorComDescontoDataGridViewTextBoxColumn";
            this.valorComDescontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorComDescontoDataGridViewTextBoxColumn.Width = 75;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(785, 293);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 33);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmProdutosDaPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 334);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvItensPromocao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProdutosDaPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProdutosDaPromocao";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutosDaPromocao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItensPromocao;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorComDescontoDataGridViewTextBoxColumn;
    }
}