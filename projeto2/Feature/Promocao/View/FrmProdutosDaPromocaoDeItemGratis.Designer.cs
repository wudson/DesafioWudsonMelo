namespace projeto2.Feature.Promocao.View
{
    partial class FrmProdutosDaPromocaoDeItemGratis
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdbGrupo = new System.Windows.Forms.RadioButton();
            this.btnAdicionarProdutosSelecionadosNaPromocao = new System.Windows.Forms.Button();
            this.rdbProduto = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBrinde = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbValorFixo = new System.Windows.Forms.RadioButton();
            this.rdbPorcentagem = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelarPromocao = new System.Windows.Forms.Button();
            this.btnSalvarPromocao = new System.Windows.Forms.Button();
            this.dgvProdutosDaPromocao = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompraProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstDeProdutos = new System.Windows.Forms.CheckedListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(25, 537);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(141, 41);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.rdbGrupo);
            this.groupBox2.Controls.Add(this.btnAdicionarProdutosSelecionadosNaPromocao);
            this.groupBox2.Controls.Add(this.rdbProduto);
            this.groupBox2.Controls.Add(this.rdbMarca);
            this.groupBox2.Location = new System.Drawing.Point(25, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buscar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(194, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 21;
            // 
            // rdbGrupo
            // 
            this.rdbGrupo.AutoSize = true;
            this.rdbGrupo.Location = new System.Drawing.Point(85, 44);
            this.rdbGrupo.Name = "rdbGrupo";
            this.rdbGrupo.Size = new System.Drawing.Size(54, 17);
            this.rdbGrupo.TabIndex = 7;
            this.rdbGrupo.Text = "Grupo";
            this.rdbGrupo.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProdutosSelecionadosNaPromocao
            // 
            this.btnAdicionarProdutosSelecionadosNaPromocao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProdutosSelecionadosNaPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Location = new System.Drawing.Point(259, 71);
            this.btnAdicionarProdutosSelecionadosNaPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarProdutosSelecionadosNaPromocao.Name = "btnAdicionarProdutosSelecionadosNaPromocao";
            this.btnAdicionarProdutosSelecionadosNaPromocao.Size = new System.Drawing.Size(138, 24);
            this.btnAdicionarProdutosSelecionadosNaPromocao.TabIndex = 16;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Text = "Adicionar selecionados";
            this.btnAdicionarProdutosSelecionadosNaPromocao.UseVisualStyleBackColor = false;
            this.btnAdicionarProdutosSelecionadosNaPromocao.Click += new System.EventHandler(this.btnAdicionarProdutosSelecionadosNaPromocao_Click);
            // 
            // rdbProduto
            // 
            this.rdbProduto.AutoSize = true;
            this.rdbProduto.Checked = true;
            this.rdbProduto.Location = new System.Drawing.Point(13, 44);
            this.rdbProduto.Name = "rdbProduto";
            this.rdbProduto.Size = new System.Drawing.Size(62, 17);
            this.rdbProduto.TabIndex = 6;
            this.rdbProduto.TabStop = true;
            this.rdbProduto.Text = "Produto";
            this.rdbProduto.UseVisualStyleBackColor = true;
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Location = new System.Drawing.Point(149, 44);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(55, 17);
            this.rdbMarca.TabIndex = 8;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnBrinde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbValorFixo);
            this.groupBox1.Controls.Add(this.rdbPorcentagem);
            this.groupBox1.Location = new System.Drawing.Point(25, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 99);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // btnBrinde
            // 
            this.btnBrinde.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBrinde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrinde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrinde.Location = new System.Drawing.Point(400, 58);
            this.btnBrinde.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrinde.Name = "btnBrinde";
            this.btnBrinde.Size = new System.Drawing.Size(99, 24);
            this.btnBrinde.TabIndex = 17;
            this.btnBrinde.Text = "Selecionar brinde";
            this.btnBrinde.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promoção:";
            // 
            // rdbValorFixo
            // 
            this.rdbValorFixo.AutoSize = true;
            this.rdbValorFixo.Checked = true;
            this.rdbValorFixo.Location = new System.Drawing.Point(12, 38);
            this.rdbValorFixo.Name = "rdbValorFixo";
            this.rdbValorFixo.Size = new System.Drawing.Size(145, 17);
            this.rdbValorFixo.TabIndex = 1;
            this.rdbValorFixo.TabStop = true;
            this.rdbValorFixo.Text = "Compre menos, leve mais";
            this.rdbValorFixo.UseVisualStyleBackColor = true;
            // 
            // rdbPorcentagem
            // 
            this.rdbPorcentagem.AutoSize = true;
            this.rdbPorcentagem.Location = new System.Drawing.Point(218, 38);
            this.rdbPorcentagem.Name = "rdbPorcentagem";
            this.rdbPorcentagem.Size = new System.Drawing.Size(92, 17);
            this.rdbPorcentagem.TabIndex = 2;
            this.rdbPorcentagem.Text = "Item de brinde";
            this.rdbPorcentagem.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(890, 179);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 26);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar produtos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPromocao
            // 
            this.btnCancelarPromocao.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarPromocao.Location = new System.Drawing.Point(855, 537);
            this.btnCancelarPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarPromocao.Name = "btnCancelarPromocao";
            this.btnCancelarPromocao.Size = new System.Drawing.Size(141, 41);
            this.btnCancelarPromocao.TabIndex = 23;
            this.btnCancelarPromocao.Text = "Cancelar";
            this.btnCancelarPromocao.UseVisualStyleBackColor = false;
            // 
            // btnSalvarPromocao
            // 
            this.btnSalvarPromocao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarPromocao.Location = new System.Drawing.Point(709, 537);
            this.btnSalvarPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarPromocao.Name = "btnSalvarPromocao";
            this.btnSalvarPromocao.Size = new System.Drawing.Size(141, 41);
            this.btnSalvarPromocao.TabIndex = 22;
            this.btnSalvarPromocao.Text = "Salvar";
            this.btnSalvarPromocao.UseVisualStyleBackColor = false;
            // 
            // dgvProdutosDaPromocao
            // 
            this.dgvProdutosDaPromocao.AllowUserToAddRows = false;
            this.dgvProdutosDaPromocao.AllowUserToDeleteRows = false;
            this.dgvProdutosDaPromocao.AutoGenerateColumns = false;
            this.dgvProdutosDaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosDaPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.ValorCompraProduto,
            this.ValorVendaProduto});
            this.dgvProdutosDaPromocao.DataSource = this.produtoBindingSource;
            this.dgvProdutosDaPromocao.Location = new System.Drawing.Point(288, 211);
            this.dgvProdutosDaPromocao.MultiSelect = false;
            this.dgvProdutosDaPromocao.Name = "dgvProdutosDaPromocao";
            this.dgvProdutosDaPromocao.ReadOnly = true;
            this.dgvProdutosDaPromocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosDaPromocao.Size = new System.Drawing.Size(708, 319);
            this.dgvProdutosDaPromocao.TabIndex = 21;
            this.dgvProdutosDaPromocao.TabStop = false;
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Brinde";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ValorCompraProduto
            // 
            this.ValorCompraProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValorCompraProduto.DataPropertyName = "ValorCompraProduto";
            this.ValorCompraProduto.HeaderText = "Custo de compra do brinde";
            this.ValorCompraProduto.Name = "ValorCompraProduto";
            this.ValorCompraProduto.ReadOnly = true;
            this.ValorCompraProduto.Width = 85;
            // 
            // ValorVendaProduto
            // 
            this.ValorVendaProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValorVendaProduto.DataPropertyName = "ValorVendaProduto";
            this.ValorVendaProduto.HeaderText = "Preço de venda do brinde";
            this.ValorVendaProduto.Name = "ValorVendaProduto";
            this.ValorVendaProduto.ReadOnly = true;
            this.ValorVendaProduto.Width = 85;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // lstDeProdutos
            // 
            this.lstDeProdutos.FormattingEnabled = true;
            this.lstDeProdutos.Location = new System.Drawing.Point(25, 211);
            this.lstDeProdutos.Name = "lstDeProdutos";
            this.lstDeProdutos.Size = new System.Drawing.Size(257, 319);
            this.lstDeProdutos.TabIndex = 20;
            // 
            // FrmProdutosDaPromocaoDeItemGratis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 593);
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
            this.Name = "FrmProdutosDaPromocaoDeItemGratis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de promoção";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbGrupo;
        private System.Windows.Forms.Button btnAdicionarProdutosSelecionadosNaPromocao;
        private System.Windows.Forms.RadioButton rdbProduto;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrinde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbValorFixo;
        private System.Windows.Forms.RadioButton rdbPorcentagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelarPromocao;
        private System.Windows.Forms.Button btnSalvarPromocao;
        private System.Windows.Forms.DataGridView dgvProdutosDaPromocao;
        private System.Windows.Forms.CheckedListBox lstDeProdutos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompraProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVendaProduto;
    }
}