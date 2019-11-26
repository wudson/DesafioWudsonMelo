namespace projeto2.Feature.Principal.View.Dev
{
    partial class FrmPrincipalDev
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
            this.btnProdutos = new DevExpress.XtraEditors.SimpleButton();
            this.btnClientes = new DevExpress.XtraEditors.SimpleButton();
            this.btnPedidos = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstoque = new DevExpress.XtraEditors.SimpleButton();
            this.btnMarcas = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrupos = new DevExpress.XtraEditors.SimpleButton();
            this.btnPromocoes = new DevExpress.XtraEditors.SimpleButton();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnProdutos
            // 
            this.btnProdutos.ImageOptions.Image = global::projeto2.Properties.Resources.barcode;
            this.btnProdutos.Location = new System.Drawing.Point(12, 12);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(175, 78);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Produtos [ 1 ]";
            this.btnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.ImageOptions.Image = global::projeto2.Properties.Resources.star;
            this.btnClientes.Location = new System.Drawing.Point(12, 180);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(175, 78);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "Marcas [ 7 ]";
            this.btnClientes.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.ImageOptions.Image = global::projeto2.Properties.Resources.connection;
            this.btnPedidos.Location = new System.Drawing.Point(433, 96);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(175, 78);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Grupos [ 6 ]";
            this.btnPedidos.Click += new System.EventHandler(this.BtnGrupos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.ImageOptions.Image = global::projeto2.Properties.Resources.price_tag;
            this.btnEstoque.Location = new System.Drawing.Point(223, 96);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(175, 78);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Promoções [ 5 ]";
            this.btnEstoque.Click += new System.EventHandler(this.BtnPromocoes_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.ImageOptions.Image = global::projeto2.Properties.Resources.package;
            this.btnMarcas.Location = new System.Drawing.Point(12, 96);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(175, 78);
            this.btnMarcas.TabIndex = 3;
            this.btnMarcas.Text = "Estoque [ 4 ] ";
            this.btnMarcas.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.ImageOptions.Image = global::projeto2.Properties.Resources.shopping_cart;
            this.btnGrupos.Location = new System.Drawing.Point(433, 12);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(175, 78);
            this.btnGrupos.TabIndex = 2;
            this.btnGrupos.Text = "Pedidos [ 3 ]";
            this.btnGrupos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // btnPromocoes
            // 
            this.btnPromocoes.ImageOptions.Image = global::projeto2.Properties.Resources.teamwork;
            this.btnPromocoes.Location = new System.Drawing.Point(223, 12);
            this.btnPromocoes.Name = "btnPromocoes";
            this.btnPromocoes.Size = new System.Drawing.Size(175, 78);
            this.btnPromocoes.TabIndex = 1;
            this.btnPromocoes.Text = "Clientes [ 2 ]";
            this.btnPromocoes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnSair
            // 
            this.btnSair.ImageOptions.Image = global::projeto2.Properties.Resources.logout;
            this.btnSair.Location = new System.Drawing.Point(223, 180);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(175, 78);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair [ Esc ]";
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmPrincipalDev
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 342);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPromocoes);
            this.Controls.Add(this.btnGrupos);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProdutos);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmPrincipalDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnProdutos;
        private DevExpress.XtraEditors.SimpleButton btnClientes;
        private DevExpress.XtraEditors.SimpleButton btnPedidos;
        private DevExpress.XtraEditors.SimpleButton btnEstoque;
        private DevExpress.XtraEditors.SimpleButton btnMarcas;
        private DevExpress.XtraEditors.SimpleButton btnGrupos;
        private DevExpress.XtraEditors.SimpleButton btnPromocoes;
        private DevExpress.XtraEditors.SimpleButton btnSair;
    }
}