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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorDeVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorDeCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroProduto = new System.Windows.Forms.Button();
            this.btnCancelarCadastroProduto = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtGrupo = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEmEstoque = new System.Windows.Forms.TextBox();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(40, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(543, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estoque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor de venda";
            // 
            // txtValorDeVenda
            // 
            this.txtValorDeVenda.Location = new System.Drawing.Point(309, 218);
            this.txtValorDeVenda.Name = "txtValorDeVenda";
            this.txtValorDeVenda.Size = new System.Drawing.Size(274, 20);
            this.txtValorDeVenda.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor de compra";
            // 
            // txtValorDeCompra
            // 
            this.txtValorDeCompra.Location = new System.Drawing.Point(40, 218);
            this.txtValorDeCompra.Name = "txtValorDeCompra";
            this.txtValorDeCompra.Size = new System.Drawing.Size(263, 20);
            this.txtValorDeCompra.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(40, 292);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(543, 20);
            this.txtFornecedor.TabIndex = 14;
            // 
            // btnSalvarCadastroProduto
            // 
            this.btnSalvarCadastroProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarCadastroProduto.Location = new System.Drawing.Point(162, 336);
            this.btnSalvarCadastroProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarCadastroProduto.Name = "btnSalvarCadastroProduto";
            this.btnSalvarCadastroProduto.Size = new System.Drawing.Size(141, 32);
            this.btnSalvarCadastroProduto.TabIndex = 16;
            this.btnSalvarCadastroProduto.Text = "Salvar";
            this.btnSalvarCadastroProduto.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroProduto.Click += new System.EventHandler(this.BtnSalvarCadastroProduto_Click);
            // 
            // btnCancelarCadastroProduto
            // 
            this.btnCancelarCadastroProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarCadastroProduto.Location = new System.Drawing.Point(312, 336);
            this.btnCancelarCadastroProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarCadastroProduto.Name = "btnCancelarCadastroProduto";
            this.btnCancelarCadastroProduto.Size = new System.Drawing.Size(141, 32);
            this.btnCancelarCadastroProduto.TabIndex = 17;
            this.btnCancelarCadastroProduto.Text = "Cancelar";
            this.btnCancelarCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroProduto.Click += new System.EventHandler(this.BtnCancelarCadastroProduto_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtGrupo);
            this.pnlControl.Controls.Add(this.txtMarca);
            this.pnlControl.Controls.Add(this.txtIdProduto);
            this.pnlControl.Controls.Add(this.btnCancelarCadastroProduto);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.btnSalvarCadastroProduto);
            this.pnlControl.Controls.Add(this.txtNome);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.txtFornecedor);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label6);
            this.pnlControl.Controls.Add(this.txtValorDeVenda);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.label7);
            this.pnlControl.Controls.Add(this.txtQuantidadeEmEstoque);
            this.pnlControl.Controls.Add(this.txtValorDeCompra);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(620, 450);
            this.pnlControl.TabIndex = 18;
            // 
            // txtGrupo
            // 
            this.txtGrupo.FormattingEnabled = true;
            this.txtGrupo.Items.AddRange(new object[] {
            "Grupo1",
            "Grupo2",
            "Grupo3"});
            this.txtGrupo.Location = new System.Drawing.Point(40, 140);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(177, 21);
            this.txtGrupo.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.Items.AddRange(new object[] {
            "Marca1",
            "Marca2",
            "Marca3"});
            this.txtMarca.Location = new System.Drawing.Point(223, 140);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(177, 21);
            this.txtMarca.TabIndex = 7;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(40, 12);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(177, 20);
            this.txtIdProduto.TabIndex = 18;
            this.txtIdProduto.Text = "0";
            this.txtIdProduto.Visible = false;
            // 
            // txtQuantidadeEmEstoque
            // 
            this.txtQuantidadeEmEstoque.Location = new System.Drawing.Point(406, 140);
            this.txtQuantidadeEmEstoque.Multiline = true;
            this.txtQuantidadeEmEstoque.Name = "txtQuantidadeEmEstoque";
            this.txtQuantidadeEmEstoque.Size = new System.Drawing.Size(177, 20);
            this.txtQuantidadeEmEstoque.TabIndex = 8;
            // 
            // FrmCadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.pnlControl);
            this.Name = "FrmCadastroDeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormCadastroProdutos_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorDeVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorDeCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnSalvarCadastroProduto;
        private System.Windows.Forms.Button btnCancelarCadastroProduto;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.ComboBox txtMarca;
        private System.Windows.Forms.ComboBox txtGrupo;
        private System.Windows.Forms.TextBox txtQuantidadeEmEstoque;
    }
}