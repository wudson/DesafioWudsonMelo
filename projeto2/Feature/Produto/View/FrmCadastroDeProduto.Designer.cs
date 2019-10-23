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
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEmEstoque = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(554, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estoque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Venda (R$)";
            // 
            // txtValorDeVenda
            // 
            this.txtValorDeVenda.Location = new System.Drawing.Point(312, 198);
            this.txtValorDeVenda.Name = "txtValorDeVenda";
            this.txtValorDeVenda.Size = new System.Drawing.Size(274, 20);
            this.txtValorDeVenda.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Compra (R$)";
            // 
            // txtValorDeCompra
            // 
            this.txtValorDeCompra.Location = new System.Drawing.Point(32, 198);
            this.txtValorDeCompra.Name = "txtValorDeCompra";
            this.txtValorDeCompra.Size = new System.Drawing.Size(274, 20);
            this.txtValorDeCompra.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(32, 246);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(554, 20);
            this.txtFornecedor.TabIndex = 7;
            // 
            // btnSalvarCadastroProduto
            // 
            this.btnSalvarCadastroProduto.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarCadastroProduto.Location = new System.Drawing.Point(165, 285);
            this.btnSalvarCadastroProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarCadastroProduto.Name = "btnSalvarCadastroProduto";
            this.btnSalvarCadastroProduto.Size = new System.Drawing.Size(141, 41);
            this.btnSalvarCadastroProduto.TabIndex = 8;
            this.btnSalvarCadastroProduto.Text = "Salvar";
            this.btnSalvarCadastroProduto.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroProduto.Click += new System.EventHandler(this.BtnSalvarCadastroProduto_Click);
            // 
            // btnCancelarCadastroProduto
            // 
            this.btnCancelarCadastroProduto.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCadastroProduto.Location = new System.Drawing.Point(315, 285);
            this.btnCancelarCadastroProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarCadastroProduto.Name = "btnCancelarCadastroProduto";
            this.btnCancelarCadastroProduto.Size = new System.Drawing.Size(141, 41);
            this.btnCancelarCadastroProduto.TabIndex = 10;
            this.btnCancelarCadastroProduto.Text = "Cancelar";
            this.btnCancelarCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroProduto.Click += new System.EventHandler(this.BtnCancelarCadastroProduto_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtTipo);
            this.pnlControl.Controls.Add(this.label8);
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
            this.pnlControl.Controls.Add(this.btnEditar);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(620, 352);
            this.pnlControl.TabIndex = 0;
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Unidade",
            "Caixa",
            "Peso"});
            this.txtTipo.Location = new System.Drawing.Point(32, 149);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(274, 21);
            this.txtTipo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tipo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.FormattingEnabled = true;
            this.txtGrupo.Items.AddRange(new object[] {
            "Grupo1",
            "Grupo2",
            "Grupo3"});
            this.txtGrupo.Location = new System.Drawing.Point(32, 100);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(274, 21);
            this.txtGrupo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.Items.AddRange(new object[] {
            "Marca1",
            "Marca2",
            "Marca3"});
            this.txtMarca.Location = new System.Drawing.Point(312, 100);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(274, 21);
            this.txtMarca.TabIndex = 2;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(220, 29);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(177, 20);
            this.txtIdProduto.TabIndex = 19;
            this.txtIdProduto.Text = "0";
            this.txtIdProduto.Visible = false;
            // 
            // txtQuantidadeEmEstoque
            // 
            this.txtQuantidadeEmEstoque.Location = new System.Drawing.Point(312, 150);
            this.txtQuantidadeEmEstoque.Name = "txtQuantidadeEmEstoque";
            this.txtQuantidadeEmEstoque.Size = new System.Drawing.Size(274, 20);
            this.txtQuantidadeEmEstoque.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(166, 285);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(141, 41);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Salvar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmCadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 352);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroDeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormCadastroProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroDeProduto_KeyDown);
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Label label8;
    }
}