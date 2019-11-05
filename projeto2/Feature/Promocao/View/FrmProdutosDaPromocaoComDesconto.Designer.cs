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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbValorFixo = new System.Windows.Forms.RadioButton();
            this.rdbPorcentagem = new System.Windows.Forms.RadioButton();
            this.txtDesconto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbGrupo = new System.Windows.Forms.RadioButton();
            this.rdbProduto = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.lstDeProdutos = new System.Windows.Forms.CheckedListBox();
            this.dgvProdutosDaPromocao = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelarPromocao = new System.Windows.Forms.Button();
            this.btnSalvarPromocao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionarProdutosSelecionadosNaPromocao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompraProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoComDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desconto:";
            // 
            // rdbValorFixo
            // 
            this.rdbValorFixo.AutoSize = true;
            this.rdbValorFixo.Checked = true;
            this.rdbValorFixo.Location = new System.Drawing.Point(12, 38);
            this.rdbValorFixo.Name = "rdbValorFixo";
            this.rdbValorFixo.Size = new System.Drawing.Size(68, 17);
            this.rdbValorFixo.TabIndex = 1;
            this.rdbValorFixo.TabStop = true;
            this.rdbValorFixo.Text = "Valor fixo";
            this.rdbValorFixo.UseVisualStyleBackColor = true;
            // 
            // rdbPorcentagem
            // 
            this.rdbPorcentagem.AutoSize = true;
            this.rdbPorcentagem.Location = new System.Drawing.Point(87, 38);
            this.rdbPorcentagem.Name = "rdbPorcentagem";
            this.rdbPorcentagem.Size = new System.Drawing.Size(88, 17);
            this.rdbPorcentagem.TabIndex = 2;
            this.rdbPorcentagem.Text = "Porcentagem";
            this.rdbPorcentagem.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Hexadecimal = true;
            this.txtDesconto.Location = new System.Drawing.Point(191, 38);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(78, 20);
            this.txtDesconto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecionar:";
            // 
            // rdbGrupo
            // 
            this.rdbGrupo.AutoSize = true;
            this.rdbGrupo.Location = new System.Drawing.Point(87, 29);
            this.rdbGrupo.Name = "rdbGrupo";
            this.rdbGrupo.Size = new System.Drawing.Size(54, 17);
            this.rdbGrupo.TabIndex = 7;
            this.rdbGrupo.Text = "Grupo";
            this.rdbGrupo.UseVisualStyleBackColor = true;
            this.rdbGrupo.CheckedChanged += new System.EventHandler(this.RdbGrupo_CheckedChanged);
            // 
            // rdbProduto
            // 
            this.rdbProduto.AutoSize = true;
            this.rdbProduto.Checked = true;
            this.rdbProduto.Location = new System.Drawing.Point(12, 29);
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
            this.rdbMarca.Location = new System.Drawing.Point(148, 29);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(55, 17);
            this.rdbMarca.TabIndex = 8;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            this.rdbMarca.CheckedChanged += new System.EventHandler(this.RdbMarca_CheckedChanged);
            // 
            // lstDeProdutos
            // 
            this.lstDeProdutos.FormattingEnabled = true;
            this.lstDeProdutos.Location = new System.Drawing.Point(25, 148);
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
            this.valorVendaProduto,
            this.PreçoComDesconto});
            this.dgvProdutosDaPromocao.DataSource = this.produtoBindingSource;
            this.dgvProdutosDaPromocao.Location = new System.Drawing.Point(288, 148);
            this.dgvProdutosDaPromocao.MultiSelect = false;
            this.dgvProdutosDaPromocao.Name = "dgvProdutosDaPromocao";
            this.dgvProdutosDaPromocao.ReadOnly = true;
            this.dgvProdutosDaPromocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosDaPromocao.Size = new System.Drawing.Size(708, 319);
            this.dgvProdutosDaPromocao.TabIndex = 10;
            this.dgvProdutosDaPromocao.TabStop = false;
            this.dgvProdutosDaPromocao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutosDaPromocao_CellDoubleClick);
            this.dgvProdutosDaPromocao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProdutosDaPromocao_CellFormatting);
            this.dgvProdutosDaPromocao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvProdutosDaPromocao_DataBindingComplete);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // btnCancelarPromocao
            // 
            this.btnCancelarPromocao.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarPromocao.Location = new System.Drawing.Point(855, 470);
            this.btnCancelarPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarPromocao.Name = "btnCancelarPromocao";
            this.btnCancelarPromocao.Size = new System.Drawing.Size(141, 41);
            this.btnCancelarPromocao.TabIndex = 14;
            this.btnCancelarPromocao.Text = "Cancelar";
            this.btnCancelarPromocao.UseVisualStyleBackColor = false;
            this.btnCancelarPromocao.Click += new System.EventHandler(this.BtnCancelarPromocao_Click);
            // 
            // btnSalvarPromocao
            // 
            this.btnSalvarPromocao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarPromocao.Location = new System.Drawing.Point(709, 470);
            this.btnSalvarPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarPromocao.Name = "btnSalvarPromocao";
            this.btnSalvarPromocao.Size = new System.Drawing.Size(141, 41);
            this.btnSalvarPromocao.TabIndex = 13;
            this.btnSalvarPromocao.Text = "Proximo";
            this.btnSalvarPromocao.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(894, 114);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 26);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar produtos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnAdicionarProdutosSelecionadosNaPromocao
            // 
            this.btnAdicionarProdutosSelecionadosNaPromocao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProdutosSelecionadosNaPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Location = new System.Drawing.Point(203, 25);
            this.btnAdicionarProdutosSelecionadosNaPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarProdutosSelecionadosNaPromocao.Name = "btnAdicionarProdutosSelecionadosNaPromocao";
            this.btnAdicionarProdutosSelecionadosNaPromocao.Size = new System.Drawing.Size(138, 24);
            this.btnAdicionarProdutosSelecionadosNaPromocao.TabIndex = 16;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Text = "Adicionar selecionados";
            this.btnAdicionarProdutosSelecionadosNaPromocao.UseVisualStyleBackColor = false;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Click += new System.EventHandler(this.BtnAdicionarProdutosSelecionadosNaPromocao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbValorFixo);
            this.groupBox1.Controls.Add(this.rdbPorcentagem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 81);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAplicar.Location = new System.Drawing.Point(276, 36);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(64, 24);
            this.btnAplicar.TabIndex = 17;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbGrupo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAdicionarProdutosSelecionadosNaPromocao);
            this.groupBox2.Controls.Add(this.rdbProduto);
            this.groupBox2.Controls.Add(this.rdbMarca);
            this.groupBox2.Location = new System.Drawing.Point(25, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 56);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(25, 470);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(141, 41);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            this.ValorCompraProduto.Width = 85;
            // 
            // valorVendaProduto
            // 
            this.valorVendaProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorVendaProduto.DataPropertyName = "ValorVendaProduto";
            this.valorVendaProduto.HeaderText = "Preço de venda";
            this.valorVendaProduto.Name = "valorVendaProduto";
            this.valorVendaProduto.ReadOnly = true;
            this.valorVendaProduto.Width = 85;
            // 
            // PreçoComDesconto
            // 
            this.PreçoComDesconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PreçoComDesconto.HeaderText = "Preço com desconto";
            this.PreçoComDesconto.Name = "PreçoComDesconto";
            this.PreçoComDesconto.ReadOnly = true;
            this.PreçoComDesconto.Width = 85;
            // 
            // FrmProdutosDaPromocaoComDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 543);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelarPromocao);
            this.Controls.Add(this.btnSalvarPromocao);
            this.Controls.Add(this.dgvProdutosDaPromocao);
            this.Controls.Add(this.lstDeProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProdutosDaPromocaoComDesconto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de promoção";
            this.Load += new System.EventHandler(this.FrmProdutosDaPromocaoComDesconto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbValorFixo;
        private System.Windows.Forms.RadioButton rdbPorcentagem;
        private System.Windows.Forms.NumericUpDown txtDesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbGrupo;
        private System.Windows.Forms.RadioButton rdbProduto;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.CheckedListBox lstDeProdutos;
        private System.Windows.Forms.DataGridView dgvProdutosDaPromocao;
        private System.Windows.Forms.Button btnCancelarPromocao;
        private System.Windows.Forms.Button btnSalvarPromocao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnAdicionarProdutosSelecionadosNaPromocao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompraProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoComDesconto;
    }
}