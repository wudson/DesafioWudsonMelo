﻿namespace projeto2.Feature.Pedido.View
{
    partial class FrmNovoPedido
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
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.btnCancelarCadastroProduto = new System.Windows.Forms.Button();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(6, 39);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(199, 407);
            this.lstProdutos.TabIndex = 0;
            this.lstProdutos.UseTabStops = false;
            this.lstProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstProdutos_MouseDoubleClick);
            // 
            // btnCancelarCadastroProduto
            // 
            this.btnCancelarCadastroProduto.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCadastroProduto.Location = new System.Drawing.Point(440, 406);
            this.btnCancelarCadastroProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarCadastroProduto.Name = "btnCancelarCadastroProduto";
            this.btnCancelarCadastroProduto.Size = new System.Drawing.Size(141, 41);
            this.btnCancelarCadastroProduto.TabIndex = 4;
            this.btnCancelarCadastroProduto.Text = "Cancelar";
            this.btnCancelarCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroProduto.Click += new System.EventHandler(this.BtnCancelarCadastroProduto_Click);
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarPedido.Location = new System.Drawing.Point(290, 406);
            this.btnSalvarPedido.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(141, 41);
            this.btnSalvarPedido.TabIndex = 3;
            this.btnSalvarPedido.Text = "Efetuar pedido";
            this.btnSalvarPedido.UseVisualStyleBackColor = false;
            this.btnSalvarPedido.Click += new System.EventHandler(this.BtnSalvarPedido_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(241, 39);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(377, 20);
            this.txtProduto.TabIndex = 12;
            this.txtProduto.TabStop = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(241, 91);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(142, 20);
            this.txtPreco.TabIndex = 13;
            this.txtPreco.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(389, 91);
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(110, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(502, 88);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(116, 25);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "+ Produto";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade";
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.preco});
            this.dgvPedido.Location = new System.Drawing.Point(211, 127);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(435, 234);
            this.dgvPedido.TabIndex = 9;
            this.dgvPedido.TabStop = false;
            this.dgvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedido_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total a pagar:";
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.Location = new System.Drawing.Point(544, 367);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.ReadOnly = true;
            this.txtTotalPedido.Size = new System.Drawing.Size(102, 20);
            this.txtTotalPedido.TabIndex = 11;
            this.txtTotalPedido.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Escolha o produto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(projeto2.Feature.Produto.Produto);
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 65;
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.preco.HeaderText = "Preço (R$)";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 80;
            // 
            // FrmNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 467);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPedido);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.btnCancelarCadastroProduto);
            this.Controls.Add(this.btnSalvarPedido);
            this.Controls.Add(this.lstProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmNovoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo pedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnCancelarCadastroProduto;
        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    }
}