namespace projeto2.Feature.Promocao.View
{
    partial class FrmProdutosDaPromocaoComDesconto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutosDaPromocaoComDesconto));
            this.lstDeProdutos = new System.Windows.Forms.CheckedListBox();
            this.dgvProdutosDaPromocao = new System.Windows.Forms.DataGridView();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompraProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelarPromocao = new System.Windows.Forms.Button();
            this.btnProdutosSelecionados = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rdbGrupo = new System.Windows.Forms.RadioButton();
            this.btnAdicionarProdutosSelecionados = new System.Windows.Forms.Button();
            this.rdbProduto = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDeProdutos
            // 
            this.lstDeProdutos.FormattingEnabled = true;
            this.lstDeProdutos.Location = new System.Drawing.Point(12, 97);
            this.lstDeProdutos.Name = "lstDeProdutos";
            this.lstDeProdutos.Size = new System.Drawing.Size(257, 319);
            this.lstDeProdutos.TabIndex = 9;
            // 
            // dgvProdutosDaPromocao
            // 
            this.dgvProdutosDaPromocao.AllowUserToAddRows = false;
            this.dgvProdutosDaPromocao.AllowUserToDeleteRows = false;
            this.dgvProdutosDaPromocao.AutoGenerateColumns = false;
            this.dgvProdutosDaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosDaPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.ValorCompraProduto,
            this.valorVendaProduto});
            this.dgvProdutosDaPromocao.DataSource = this.produtoBindingSource;
            this.dgvProdutosDaPromocao.Location = new System.Drawing.Point(275, 97);
            this.dgvProdutosDaPromocao.MultiSelect = false;
            this.dgvProdutosDaPromocao.Name = "dgvProdutosDaPromocao";
            this.dgvProdutosDaPromocao.ReadOnly = true;
            this.dgvProdutosDaPromocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosDaPromocao.Size = new System.Drawing.Size(708, 319);
            this.dgvProdutosDaPromocao.TabIndex = 10;
            this.dgvProdutosDaPromocao.TabStop = false;
            this.dgvProdutosDaPromocao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProdutosDaPromocao_CellFormatting);
            this.dgvProdutosDaPromocao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvProdutosDaPromocao_DataBindingComplete);
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ValorCompraProduto
            // 
            this.ValorCompraProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValorCompraProduto.DataPropertyName = "ValorCompraProduto";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ValorCompraProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorCompraProduto.HeaderText = "Preço de compra";
            this.ValorCompraProduto.Name = "ValorCompraProduto";
            this.ValorCompraProduto.ReadOnly = true;
            // 
            // valorVendaProduto
            // 
            this.valorVendaProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorVendaProduto.DataPropertyName = "ValorVendaProduto";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorVendaProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorVendaProduto.HeaderText = "Preço de venda";
            this.valorVendaProduto.Name = "valorVendaProduto";
            this.valorVendaProduto.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // btnCancelarPromocao
            // 
            this.btnCancelarPromocao.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarPromocao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarPromocao.Location = new System.Drawing.Point(842, 419);
            this.btnCancelarPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarPromocao.Name = "btnCancelarPromocao";
            this.btnCancelarPromocao.Size = new System.Drawing.Size(141, 41);
            this.btnCancelarPromocao.TabIndex = 14;
            this.btnCancelarPromocao.Text = "Cancelar";
            this.btnCancelarPromocao.UseVisualStyleBackColor = false;
            // 
            // btnProdutosSelecionados
            // 
            this.btnProdutosSelecionados.BackColor = System.Drawing.Color.DarkGray;
            this.btnProdutosSelecionados.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnProdutosSelecionados.Enabled = false;
            this.btnProdutosSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutosSelecionados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProdutosSelecionados.Location = new System.Drawing.Point(691, 419);
            this.btnProdutosSelecionados.Margin = new System.Windows.Forms.Padding(0);
            this.btnProdutosSelecionados.Name = "btnProdutosSelecionados";
            this.btnProdutosSelecionados.Size = new System.Drawing.Size(141, 41);
            this.btnProdutosSelecionados.TabIndex = 13;
            this.btnProdutosSelecionados.Text = "Ok";
            this.btnProdutosSelecionados.UseVisualStyleBackColor = false;
            this.btnProdutosSelecionados.Click += new System.EventHandler(this.BtnProdutosSelecionados_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(881, 63);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 26);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar produtos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.rdbGrupo);
            this.groupBox3.Controls.Add(this.btnAdicionarProdutosSelecionados);
            this.groupBox3.Controls.Add(this.rdbProduto);
            this.groupBox3.Controls.Add(this.rdbMarca);
            this.groupBox3.Location = new System.Drawing.Point(12, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 89);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 59);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // rdbGrupo
            // 
            this.rdbGrupo.AutoSize = true;
            this.rdbGrupo.Location = new System.Drawing.Point(85, 34);
            this.rdbGrupo.Name = "rdbGrupo";
            this.rdbGrupo.Size = new System.Drawing.Size(54, 17);
            this.rdbGrupo.TabIndex = 7;
            this.rdbGrupo.Text = "Grupo";
            this.rdbGrupo.UseVisualStyleBackColor = true;
            this.rdbGrupo.CheckedChanged += new System.EventHandler(this.RdbGrupo_CheckedChanged);
            // 
            // btnAdicionarProdutosSelecionados
            // 
            this.btnAdicionarProdutosSelecionados.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionarProdutosSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProdutosSelecionados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarProdutosSelecionados.Location = new System.Drawing.Point(259, 56);
            this.btnAdicionarProdutosSelecionados.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarProdutosSelecionados.Name = "btnAdicionarProdutosSelecionados";
            this.btnAdicionarProdutosSelecionados.Size = new System.Drawing.Size(138, 24);
            this.btnAdicionarProdutosSelecionados.TabIndex = 16;
            this.btnAdicionarProdutosSelecionados.Text = "Adicionar selecionados";
            this.btnAdicionarProdutosSelecionados.UseVisualStyleBackColor = false;
            this.btnAdicionarProdutosSelecionados.Click += new System.EventHandler(this.BtnAdicionarProdutosSelecionadosNaPromocao_Click);
            // 
            // rdbProduto
            // 
            this.rdbProduto.AutoSize = true;
            this.rdbProduto.Checked = true;
            this.rdbProduto.Location = new System.Drawing.Point(13, 34);
            this.rdbProduto.Name = "rdbProduto";
            this.rdbProduto.Size = new System.Drawing.Size(62, 17);
            this.rdbProduto.TabIndex = 6;
            this.rdbProduto.TabStop = true;
            this.rdbProduto.Text = "Produto";
            this.rdbProduto.UseVisualStyleBackColor = true;
            this.rdbProduto.CheckedChanged += new System.EventHandler(this.RdbProduto_CheckedChanged);
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Location = new System.Drawing.Point(149, 34);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(55, 17);
            this.rdbMarca.TabIndex = 8;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            this.rdbMarca.CheckedChanged += new System.EventHandler(this.RdbMarca_CheckedChanged);
            // 
            // FrmProdutosDaPromocaoComDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 465);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelarPromocao);
            this.Controls.Add(this.btnProdutosSelecionados);
            this.Controls.Add(this.dgvProdutosDaPromocao);
            this.Controls.Add(this.lstDeProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProdutosDaPromocaoComDesconto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de promoção";
            this.Load += new System.EventHandler(this.FrmProdutosDaPromocaoComDesconto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox lstDeProdutos;
        private System.Windows.Forms.DataGridView dgvProdutosDaPromocao;
        private System.Windows.Forms.Button btnCancelarPromocao;
        private System.Windows.Forms.Button btnProdutosSelecionados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rdbGrupo;
        private System.Windows.Forms.Button btnAdicionarProdutosSelecionados;
        private System.Windows.Forms.RadioButton rdbProduto;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompraProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaProduto;
    }
}