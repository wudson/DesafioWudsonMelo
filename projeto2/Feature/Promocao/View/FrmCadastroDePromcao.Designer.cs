﻿namespace projeto2.Feature.Promocao.View
{
    partial class FrmCadastroDePromcao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelecionarProdutosDaPromocao = new System.Windows.Forms.Button();
            this.dgvProdutosDaPromocao = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoComDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoDesconto = new System.Windows.Forms.GroupBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbValorFixo = new System.Windows.Forms.RadioButton();
            this.rdbPorcentagem = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvarPromocao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoPromocao = new System.Windows.Forms.ComboBox();
            this.grupoItemGratis = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBrinde = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbCompreMenosLeveMais = new System.Windows.Forms.RadioButton();
            this.rdbItemDeBrinde = new System.Windows.Forms.RadioButton();
            this.dgvProdutosPromocaoItemGratis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.grupoDesconto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            this.grupoItemGratis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocaoItemGratis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarProdutosDaPromocao
            // 
            this.btnSelecionarProdutosDaPromocao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelecionarProdutosDaPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarProdutosDaPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarProdutosDaPromocao.Location = new System.Drawing.Point(636, 85);
            this.btnSelecionarProdutosDaPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelecionarProdutosDaPromocao.Name = "btnSelecionarProdutosDaPromocao";
            this.btnSelecionarProdutosDaPromocao.Size = new System.Drawing.Size(88, 24);
            this.btnSelecionarProdutosDaPromocao.TabIndex = 31;
            this.btnSelecionarProdutosDaPromocao.Text = "Selecionar";
            this.btnSelecionarProdutosDaPromocao.UseVisualStyleBackColor = false;
            this.btnSelecionarProdutosDaPromocao.Click += new System.EventHandler(this.BtnSelecionarProdutosDaPromocao_Click);
            // 
            // dgvProdutosDaPromocao
            // 
            this.dgvProdutosDaPromocao.AllowUserToAddRows = false;
            this.dgvProdutosDaPromocao.AllowUserToDeleteRows = false;
            this.dgvProdutosDaPromocao.AutoGenerateColumns = false;
            this.dgvProdutosDaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosDaPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.nomeProduto,
            this.valorCompraProduto,
            this.valorVendaProduto,
            this.PreçoComDesconto});
            this.dgvProdutosDaPromocao.DataSource = this.produtoBindingSource;
            this.dgvProdutosDaPromocao.Location = new System.Drawing.Point(14, 120);
            this.dgvProdutosDaPromocao.Name = "dgvProdutosDaPromocao";
            this.dgvProdutosDaPromocao.ReadOnly = true;
            this.dgvProdutosDaPromocao.Size = new System.Drawing.Size(710, 294);
            this.dgvProdutosDaPromocao.TabIndex = 34;
            this.dgvProdutosDaPromocao.DataSourceChanged += new System.EventHandler(this.DgvProdutosDaPromocao_DataSourceChanged);
            // 
            // idProduto
            // 
            this.idProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idProduto.DataPropertyName = "IdProduto";
            this.idProduto.HeaderText = "Código";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Width = 85;
            // 
            // nomeProduto
            // 
            this.nomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProduto.DataPropertyName = "NomeProduto";
            this.nomeProduto.HeaderText = "NomeProduto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // valorCompraProduto
            // 
            this.valorCompraProduto.DataPropertyName = "ValorCompraProduto";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorCompraProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorCompraProduto.HeaderText = "Preço de compra";
            this.valorCompraProduto.Name = "valorCompraProduto";
            this.valorCompraProduto.ReadOnly = true;
            // 
            // valorVendaProduto
            // 
            this.valorVendaProduto.DataPropertyName = "ValorVendaProduto";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.valorVendaProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorVendaProduto.HeaderText = "Preço de venda";
            this.valorVendaProduto.Name = "valorVendaProduto";
            this.valorVendaProduto.ReadOnly = true;
            // 
            // PreçoComDesconto
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.PreçoComDesconto.DefaultCellStyle = dataGridViewCellStyle6;
            this.PreçoComDesconto.HeaderText = "Preço com desconto";
            this.PreçoComDesconto.Name = "PreçoComDesconto";
            this.PreçoComDesconto.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // grupoDesconto
            // 
            this.grupoDesconto.Controls.Add(this.btnAplicar);
            this.grupoDesconto.Controls.Add(this.txtDesconto);
            this.grupoDesconto.Controls.Add(this.label5);
            this.grupoDesconto.Controls.Add(this.rdbValorFixo);
            this.grupoDesconto.Controls.Add(this.rdbPorcentagem);
            this.grupoDesconto.Controls.Add(this.label6);
            this.grupoDesconto.Location = new System.Drawing.Point(14, 47);
            this.grupoDesconto.Name = "grupoDesconto";
            this.grupoDesconto.Size = new System.Drawing.Size(491, 67);
            this.grupoDesconto.TabIndex = 33;
            this.grupoDesconto.TabStop = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAplicar.Location = new System.Drawing.Point(280, 38);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(79, 24);
            this.btnAplicar.TabIndex = 17;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(190, 42);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(78, 20);
            this.txtDesconto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Desconto:";
            // 
            // rdbValorFixo
            // 
            this.rdbValorFixo.AutoSize = true;
            this.rdbValorFixo.Checked = true;
            this.rdbValorFixo.Location = new System.Drawing.Point(11, 42);
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
            this.rdbPorcentagem.Location = new System.Drawing.Point(86, 42);
            this.rdbPorcentagem.Name = "rdbPorcentagem";
            this.rdbPorcentagem.Size = new System.Drawing.Size(88, 17);
            this.rdbPorcentagem.TabIndex = 2;
            this.rdbPorcentagem.Text = "Porcentagem";
            this.rdbPorcentagem.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 477);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(491, 20);
            this.txtNome.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome da promoção";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(636, 448);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 36);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvarPromocao
            // 
            this.btnSalvarPromocao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarPromocao.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarPromocao.Location = new System.Drawing.Point(548, 448);
            this.btnSalvarPromocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarPromocao.Name = "btnSalvarPromocao";
            this.btnSalvarPromocao.Size = new System.Drawing.Size(88, 36);
            this.btnSalvarPromocao.TabIndex = 28;
            this.btnSalvarPromocao.Text = "Finalizar";
            this.btnSalvarPromocao.UseVisualStyleBackColor = false;
            this.btnSalvarPromocao.Click += new System.EventHandler(this.BtnSalvarPromocao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data de termino";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFim.Location = new System.Drawing.Point(264, 438);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(241, 20);
            this.txtDataFim.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Data de inicio";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(14, 438);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(241, 20);
            this.txtDataInicio.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tipo da promoção";
            // 
            // txtTipoPromocao
            // 
            this.txtTipoPromocao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoPromocao.FormattingEnabled = true;
            this.txtTipoPromocao.Items.AddRange(new object[] {
            "Desconto",
            "Item gratis"});
            this.txtTipoPromocao.Location = new System.Drawing.Point(14, 24);
            this.txtTipoPromocao.Name = "txtTipoPromocao";
            this.txtTipoPromocao.Size = new System.Drawing.Size(491, 21);
            this.txtTipoPromocao.TabIndex = 22;
            this.txtTipoPromocao.SelectedIndexChanged += new System.EventHandler(this.TxtTipoPromocao_SelectedIndexChanged);
            // 
            // grupoItemGratis
            // 
            this.grupoItemGratis.Controls.Add(this.textBox1);
            this.grupoItemGratis.Controls.Add(this.comboBox1);
            this.grupoItemGratis.Controls.Add(this.btnBrinde);
            this.grupoItemGratis.Controls.Add(this.label7);
            this.grupoItemGratis.Controls.Add(this.rdbCompreMenosLeveMais);
            this.grupoItemGratis.Controls.Add(this.rdbItemDeBrinde);
            this.grupoItemGratis.Location = new System.Drawing.Point(14, 47);
            this.grupoItemGratis.Name = "grupoItemGratis";
            this.grupoItemGratis.Size = new System.Drawing.Size(491, 67);
            this.grupoItemGratis.TabIndex = 35;
            this.grupoItemGratis.TabStop = false;
            this.grupoItemGratis.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // btnBrinde
            // 
            this.btnBrinde.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBrinde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrinde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrinde.Location = new System.Drawing.Point(400, 37);
            this.btnBrinde.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrinde.Name = "btnBrinde";
            this.btnBrinde.Size = new System.Drawing.Size(65, 24);
            this.btnBrinde.TabIndex = 17;
            this.btnBrinde.Text = "Selecionar brinde";
            this.btnBrinde.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 0;
            // 
            // rdbCompreMenosLeveMais
            // 
            this.rdbCompreMenosLeveMais.AutoSize = true;
            this.rdbCompreMenosLeveMais.Checked = true;
            this.rdbCompreMenosLeveMais.Location = new System.Drawing.Point(12, 17);
            this.rdbCompreMenosLeveMais.Name = "rdbCompreMenosLeveMais";
            this.rdbCompreMenosLeveMais.Size = new System.Drawing.Size(145, 17);
            this.rdbCompreMenosLeveMais.TabIndex = 1;
            this.rdbCompreMenosLeveMais.TabStop = true;
            this.rdbCompreMenosLeveMais.Text = "Compre menos, leve mais";
            this.rdbCompreMenosLeveMais.UseVisualStyleBackColor = true;
            // 
            // rdbItemDeBrinde
            // 
            this.rdbItemDeBrinde.AutoSize = true;
            this.rdbItemDeBrinde.Location = new System.Drawing.Point(218, 17);
            this.rdbItemDeBrinde.Name = "rdbItemDeBrinde";
            this.rdbItemDeBrinde.Size = new System.Drawing.Size(92, 17);
            this.rdbItemDeBrinde.TabIndex = 2;
            this.rdbItemDeBrinde.Text = "Item de brinde";
            this.rdbItemDeBrinde.UseVisualStyleBackColor = true;
            // 
            // dgvProdutosPromocaoItemGratis
            // 
            this.dgvProdutosPromocaoItemGratis.AllowUserToAddRows = false;
            this.dgvProdutosPromocaoItemGratis.AllowUserToDeleteRows = false;
            this.dgvProdutosPromocaoItemGratis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosPromocaoItemGratis.Location = new System.Drawing.Point(14, 120);
            this.dgvProdutosPromocaoItemGratis.Name = "dgvProdutosPromocaoItemGratis";
            this.dgvProdutosPromocaoItemGratis.ReadOnly = true;
            this.dgvProdutosPromocaoItemGratis.Size = new System.Drawing.Size(710, 294);
            this.dgvProdutosPromocaoItemGratis.TabIndex = 36;
            this.dgvProdutosPromocaoItemGratis.Visible = false;
            // 
            // FrmCadastroDePromcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 510);
            this.Controls.Add(this.dgvProdutosPromocaoItemGratis);
            this.Controls.Add(this.grupoItemGratis);
            this.Controls.Add(this.btnSelecionarProdutosDaPromocao);
            this.Controls.Add(this.dgvProdutosDaPromocao);
            this.Controls.Add(this.grupoDesconto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvarPromocao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoPromocao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmCadastroDePromcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de promoção";
            this.Load += new System.EventHandler(this.FrmCadastroDePromcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.grupoDesconto.ResumeLayout(false);
            this.grupoDesconto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            this.grupoItemGratis.ResumeLayout(false);
            this.grupoItemGratis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPromocaoItemGratis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionarProdutosDaPromocao;
        private System.Windows.Forms.DataGridView dgvProdutosDaPromocao;
        private System.Windows.Forms.GroupBox grupoDesconto;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.NumericUpDown txtDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbValorFixo;
        private System.Windows.Forms.RadioButton rdbPorcentagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvarPromocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTipoPromocao;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoComDesconto;
        private System.Windows.Forms.GroupBox grupoItemGratis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBrinde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbCompreMenosLeveMais;
        private System.Windows.Forms.RadioButton rdbItemDeBrinde;
        private System.Windows.Forms.DataGridView dgvProdutosPromocaoItemGratis;
    }
}