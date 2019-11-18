namespace projeto2.Feature.Principal.View
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnPromocoes = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPromocoes
            // 
            this.btnPromocoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPromocoes.FlatAppearance.BorderSize = 0;
            this.btnPromocoes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPromocoes.Image = global::projeto2.Properties.Resources.price_tag;
            this.btnPromocoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPromocoes.Location = new System.Drawing.Point(12, 118);
            this.btnPromocoes.Name = "btnPromocoes";
            this.btnPromocoes.Size = new System.Drawing.Size(130, 90);
            this.btnPromocoes.TabIndex = 4;
            this.btnPromocoes.Text = "Promoções - [ 5 ]";
            this.btnPromocoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPromocoes.UseVisualStyleBackColor = false;
            this.btnPromocoes.Click += new System.EventHandler(this.BtnPromocoes_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEstoque.Image = global::projeto2.Properties.Resources.package;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstoque.Location = new System.Drawing.Point(457, 12);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(130, 90);
            this.btnEstoque.TabIndex = 3;
            this.btnEstoque.Text = "Estoque - [ 4 ]";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMarcas.Image = global::projeto2.Properties.Resources.star;
            this.btnMarcas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcas.Location = new System.Drawing.Point(308, 118);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(130, 90);
            this.btnMarcas.TabIndex = 6;
            this.btnMarcas.Text = "Marcas - [ 7 ]";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGrupos.FlatAppearance.BorderSize = 0;
            this.btnGrupos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGrupos.Image = global::projeto2.Properties.Resources.data_collection;
            this.btnGrupos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrupos.Location = new System.Drawing.Point(160, 118);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(130, 90);
            this.btnGrupos.TabIndex = 5;
            this.btnGrupos.Text = "Grupos - [ 6 ]";
            this.btnGrupos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrupos.UseVisualStyleBackColor = false;
            this.btnGrupos.Click += new System.EventHandler(this.BtnGrupos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPedidos.Image = global::projeto2.Properties.Resources.shopping_bag;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidos.Location = new System.Drawing.Point(308, 12);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(130, 90);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos - [ 3 ]";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSair.Image = global::projeto2.Properties.Resources.logout;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(457, 118);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 90);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair - [ Esc ]";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClientes.Image = global::projeto2.Properties.Resources.teamwork;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(160, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(130, 90);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes - [ 2 ]";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnProdutos.Image = global::projeto2.Properties.Resources.barcode;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutos.Location = new System.Drawing.Point(12, 12);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(130, 90);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Produtos - [ 1 ]";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 331);
            this.Controls.Add(this.btnPromocoes);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnGrupos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnGrupos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnPromocoes;
    }
}