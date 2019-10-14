namespace projeto2
{
    partial class FormProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tblBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.gridDadosProduto = new System.Windows.Forms.DataGridView();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.tblBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDadosProduto)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 57);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(525, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(178, 57);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // tblBotoes
            // 
            this.tblBotoes.ColumnCount = 4;
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.Controls.Add(this.btnEditar, 0, 0);
            this.tblBotoes.Controls.Add(this.btnListar, 0, 0);
            this.tblBotoes.Controls.Add(this.btnExcluir, 1, 0);
            this.tblBotoes.Controls.Add(this.btnCadastrar, 0, 0);
            this.tblBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBotoes.Location = new System.Drawing.Point(0, 0);
            this.tblBotoes.Name = "tblBotoes";
            this.tblBotoes.RowCount = 1;
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBotoes.Size = new System.Drawing.Size(703, 57);
            this.tblBotoes.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Location = new System.Drawing.Point(350, 0);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 57);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListar.Location = new System.Drawing.Point(175, 0);
            this.btnListar.Margin = new System.Windows.Forms.Padding(0);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(175, 57);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // gridDadosProduto
            // 
            this.gridDadosProduto.AllowUserToAddRows = false;
            this.gridDadosProduto.AllowUserToDeleteRows = false;
            this.gridDadosProduto.AllowUserToResizeColumns = false;
            this.gridDadosProduto.AllowUserToResizeRows = false;
            this.gridDadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDadosProduto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridDadosProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDadosProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDadosProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDadosProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridDadosProduto.Location = new System.Drawing.Point(0, 0);
            this.gridDadosProduto.Name = "gridDadosProduto";
            this.gridDadosProduto.ReadOnly = true;
            this.gridDadosProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridDadosProduto.RowTemplate.ReadOnly = true;
            this.gridDadosProduto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDadosProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDadosProduto.Size = new System.Drawing.Size(703, 393);
            this.gridDadosProduto.TabIndex = 3;
            this.gridDadosProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDadosProduto_CellDoubleClick);
            this.gridDadosProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridDadosProduto_CellMouseClick);
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.Controls.Add(this.gridDadosProduto);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 57);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(703, 393);
            this.pnlcontrol.TabIndex = 4;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.pnlcontrol);
            this.Controls.Add(this.tblBotoes);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tblBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDadosProduto)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TableLayoutPanel tblBotoes;
        private System.Windows.Forms.DataGridView gridDadosProduto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel pnlcontrol;
    }
}

