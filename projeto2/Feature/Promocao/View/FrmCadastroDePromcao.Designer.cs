namespace projeto2.Feature.Promocao.View
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
            this.btnSelecionarProdutosDaPromocao = new System.Windows.Forms.Button();
            this.dgvProdutosDaPromocao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbValorFixo = new System.Windows.Forms.RadioButton();
            this.rdbPorcentagem = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoPromocao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarProdutosDaPromocao
            // 
            this.btnSelecionarProdutosDaPromocao.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelecionarProdutosDaPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarProdutosDaPromocao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarProdutosDaPromocao.Location = new System.Drawing.Point(687, 110);
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
            this.dgvProdutosDaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosDaPromocao.Location = new System.Drawing.Point(65, 145);
            this.dgvProdutosDaPromocao.Name = "dgvProdutosDaPromocao";
            this.dgvProdutosDaPromocao.Size = new System.Drawing.Size(710, 294);
            this.dgvProdutosDaPromocao.TabIndex = 34;
            this.dgvProdutosDaPromocao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvProdutosDaPromocao_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdbValorFixo);
            this.groupBox1.Controls.Add(this.rdbPorcentagem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(65, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 67);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
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
            this.txtDesconto.Hexadecimal = true;
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
            this.txtNome.Location = new System.Drawing.Point(65, 518);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(491, 20);
            this.txtNome.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(62, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome da promoção";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(687, 489);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 36);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Location = new System.Drawing.Point(599, 489);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(0);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(88, 36);
            this.btnProximo.TabIndex = 28;
            this.btnProximo.Text = "Finalizar";
            this.btnProximo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data de termino";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFim.Location = new System.Drawing.Point(315, 479);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(241, 20);
            this.txtDataFim.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Data de inicio";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(65, 479);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(241, 20);
            this.txtDataInicio.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tipo da promoção";
            // 
            // txtTipoPromocao
            // 
            this.txtTipoPromocao.FormattingEnabled = true;
            this.txtTipoPromocao.Items.AddRange(new object[] {
            "Desconto",
            "Item gratis"});
            this.txtTipoPromocao.Location = new System.Drawing.Point(65, 34);
            this.txtTipoPromocao.Name = "txtTipoPromocao";
            this.txtTipoPromocao.Size = new System.Drawing.Size(491, 21);
            this.txtTipoPromocao.TabIndex = 22;
            // 
            // FrmCadastroDePromcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 559);
            this.Controls.Add(this.btnSelecionarProdutosDaPromocao);
            this.Controls.Add(this.dgvProdutosDaPromocao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoPromocao);
            this.Name = "FrmCadastroDePromcao";
            this.Text = "Cadastro de promoção";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosDaPromocao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionarProdutosDaPromocao;
        private System.Windows.Forms.DataGridView dgvProdutosDaPromocao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.NumericUpDown txtDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbValorFixo;
        private System.Windows.Forms.RadioButton rdbPorcentagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTipoPromocao;
    }
}