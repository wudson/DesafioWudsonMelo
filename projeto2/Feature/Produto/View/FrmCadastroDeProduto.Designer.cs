namespace projeto2.Feature.Produto.View
{
    partial class FrmCadastroDeProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDeProduto));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroProduto = new System.Windows.Forms.Button();
            this.btnCancelarCadastroProduto = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnNovoGrupo = new System.Windows.Forms.Button();
            this.btnNovaMarca = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorDeVenda = new System.Windows.Forms.NumericUpDown();
            this.txtValorDeCompra = new System.Windows.Forms.NumericUpDown();
            this.txtQuantidadeEmEstoque = new System.Windows.Forms.NumericUpDown();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeEmEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 53);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(554, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Estoque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Venda (R$)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Compra (R$)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(32, 285);
            this.txtFornecedor.MaxLength = 100;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(554, 20);
            this.txtFornecedor.TabIndex = 8;
            // 
            // btnSalvarCadastroProduto
            // 
            this.btnSalvarCadastroProduto.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarCadastroProduto.Location = new System.Drawing.Point(165, 324);
            this.btnSalvarCadastroProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarCadastroProduto.Name = "btnSalvarCadastroProduto";
            this.btnSalvarCadastroProduto.Size = new System.Drawing.Size(141, 41);
            this.btnSalvarCadastroProduto.TabIndex = 9;
            this.btnSalvarCadastroProduto.Text = "Salvar";
            this.btnSalvarCadastroProduto.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroProduto.Click += new System.EventHandler(this.BtnSalvarCadastroProduto_Click);
            // 
            // btnCancelarCadastroProduto
            // 
            this.btnCancelarCadastroProduto.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCadastroProduto.Location = new System.Drawing.Point(315, 324);
            this.btnCancelarCadastroProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarCadastroProduto.Name = "btnCancelarCadastroProduto";
            this.btnCancelarCadastroProduto.Size = new System.Drawing.Size(141, 41);
            this.btnCancelarCadastroProduto.TabIndex = 11;
            this.btnCancelarCadastroProduto.Text = "Cancelar";
            this.btnCancelarCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroProduto.Click += new System.EventHandler(this.BtnCancelarCadastroProduto_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnNovoGrupo);
            this.pnlControl.Controls.Add(this.btnNovaMarca);
            this.pnlControl.Controls.Add(this.label11);
            this.pnlControl.Controls.Add(this.label17);
            this.pnlControl.Controls.Add(this.txtCodigoDeBarras);
            this.pnlControl.Controls.Add(this.label16);
            this.pnlControl.Controls.Add(this.label15);
            this.pnlControl.Controls.Add(this.label14);
            this.pnlControl.Controls.Add(this.label13);
            this.pnlControl.Controls.Add(this.label12);
            this.pnlControl.Controls.Add(this.label10);
            this.pnlControl.Controls.Add(this.label9);
            this.pnlControl.Controls.Add(this.txtValorDeVenda);
            this.pnlControl.Controls.Add(this.txtValorDeCompra);
            this.pnlControl.Controls.Add(this.txtQuantidadeEmEstoque);
            this.pnlControl.Controls.Add(this.txtTipo);
            this.pnlControl.Controls.Add(this.label8);
            this.pnlControl.Controls.Add(this.txtGrupo);
            this.pnlControl.Controls.Add(this.txtMarca);
            this.pnlControl.Controls.Add(this.btnCancelarCadastroProduto);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.btnSalvarCadastroProduto);
            this.pnlControl.Controls.Add(this.txtNome);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.txtFornecedor);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label6);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.label7);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Controls.Add(this.btnEditar);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(620, 381);
            this.pnlControl.TabIndex = 0;
            // 
            // btnNovoGrupo
            // 
            this.btnNovoGrupo.Image = global::projeto2.Properties.Resources.plus__1_;
            this.btnNovoGrupo.Location = new System.Drawing.Point(281, 140);
            this.btnNovoGrupo.Name = "btnNovoGrupo";
            this.btnNovoGrupo.Size = new System.Drawing.Size(26, 23);
            this.btnNovoGrupo.TabIndex = 30;
            this.btnNovoGrupo.UseVisualStyleBackColor = true;
            this.btnNovoGrupo.Click += new System.EventHandler(this.BtnNovoGrupo_Click);
            this.btnNovoGrupo.MouseHover += new System.EventHandler(this.BtnNovoGrupo_MouseHover);
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Image = global::projeto2.Properties.Resources.plus__1_;
            this.btnNovaMarca.Location = new System.Drawing.Point(560, 140);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(26, 23);
            this.btnNovaMarca.TabIndex = 29;
            this.btnNovaMarca.UseVisualStyleBackColor = true;
            this.btnNovaMarca.Click += new System.EventHandler(this.BtnNovaMarca_Click);
            this.btnNovaMarca.MouseHover += new System.EventHandler(this.BtnNovaMarca_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(126, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(29, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "Código de barras";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(32, 96);
            this.txtCodigoDeBarras.MaxLength = 50;
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(554, 20);
            this.txtCodigoDeBarras.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(66, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(56, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(102, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(373, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(95, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(75, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(29, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "( * ) Obrigatorio";
            // 
            // txtValorDeVenda
            // 
            this.txtValorDeVenda.DecimalPlaces = 2;
            this.txtValorDeVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtValorDeVenda.Location = new System.Drawing.Point(312, 237);
            this.txtValorDeVenda.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.txtValorDeVenda.Name = "txtValorDeVenda";
            this.txtValorDeVenda.Size = new System.Drawing.Size(274, 20);
            this.txtValorDeVenda.TabIndex = 7;
            this.txtValorDeVenda.Enter += new System.EventHandler(this.TxtValorDeVenda_Enter);
            // 
            // txtValorDeCompra
            // 
            this.txtValorDeCompra.DecimalPlaces = 2;
            this.txtValorDeCompra.Location = new System.Drawing.Point(32, 237);
            this.txtValorDeCompra.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.txtValorDeCompra.Name = "txtValorDeCompra";
            this.txtValorDeCompra.Size = new System.Drawing.Size(274, 20);
            this.txtValorDeCompra.TabIndex = 6;
            this.txtValorDeCompra.Enter += new System.EventHandler(this.TxtValorDeCompra_Enter);
            this.txtValorDeCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorDeCompra_KeyPress);
            // 
            // txtQuantidadeEmEstoque
            // 
            this.txtQuantidadeEmEstoque.Location = new System.Drawing.Point(312, 189);
            this.txtQuantidadeEmEstoque.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtQuantidadeEmEstoque.Name = "txtQuantidadeEmEstoque";
            this.txtQuantidadeEmEstoque.Size = new System.Drawing.Size(274, 20);
            this.txtQuantidadeEmEstoque.TabIndex = 5;
            // 
            // txtTipo
            // 
            this.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Unidade",
            "Caixa",
            "Peso"});
            this.txtTipo.Location = new System.Drawing.Point(32, 188);
            this.txtTipo.MaxLength = 100;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(274, 21);
            this.txtTipo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGrupo.FormattingEnabled = true;
            this.txtGrupo.Items.AddRange(new object[] {
            "Grupo1",
            "Grupo2",
            "Grupo3"});
            this.txtGrupo.Location = new System.Drawing.Point(32, 141);
            this.txtGrupo.MaxLength = 100;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(249, 21);
            this.txtGrupo.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.Items.AddRange(new object[] {
            "Marca1",
            "Marca2",
            "Marca3"});
            this.txtMarca.Location = new System.Drawing.Point(312, 141);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(248, 21);
            this.txtMarca.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(166, 324);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(141, 41);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Salvar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmCadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 381);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroDeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.FormCadastroProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroDeProduto_KeyDown);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeEmEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnSalvarCadastroProduto;
        private System.Windows.Forms.Button btnCancelarCadastroProduto;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.ComboBox txtMarca;
        private System.Windows.Forms.ComboBox txtGrupo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtQuantidadeEmEstoque;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtValorDeVenda;
        private System.Windows.Forms.NumericUpDown txtValorDeCompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.Button btnNovoGrupo;
        private System.Windows.Forms.Button btnNovaMarca;
    }
}