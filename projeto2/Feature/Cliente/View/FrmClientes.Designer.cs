namespace projeto2.Feature.Cliente.View
{
    partial class FrmClientes
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
            this.components = new System.ComponentModel.Container();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.tblBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnListar = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.PictureBox();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            this.tblBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomePessoaDataGridViewTextBoxColumn,
            this.emailPessoaDataGridViewTextBoxColumn,
            this.telefonePessoaDataGridViewTextBoxColumn,
            this.dataCadastroClienteDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clienteModelBindingSource;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvClientes.Location = new System.Drawing.Point(0, 75);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClientes.RowTemplate.ReadOnly = true;
            this.dgvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.ShowEditingIcon = false;
            this.dgvClientes.Size = new System.Drawing.Size(703, 375);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellDoubleClick);
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlcontrol.Controls.Add(this.dgvClientes);
            this.pnlcontrol.Controls.Add(this.tblBotoes);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(703, 450);
            this.pnlcontrol.TabIndex = 4;
            // 
            // tblBotoes
            // 
            this.tblBotoes.ColumnCount = 4;
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBotoes.Controls.Add(this.btnExcluir, 3, 0);
            this.tblBotoes.Controls.Add(this.btnEditar, 2, 0);
            this.tblBotoes.Controls.Add(this.btnListar, 1, 0);
            this.tblBotoes.Controls.Add(this.btnCadastrar, 0, 0);
            this.tblBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBotoes.Location = new System.Drawing.Point(0, 0);
            this.tblBotoes.Name = "tblBotoes";
            this.tblBotoes.RowCount = 1;
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBotoes.Size = new System.Drawing.Size(703, 75);
            this.tblBotoes.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::projeto2.Properties.Resources.error;
            this.btnExcluir.Location = new System.Drawing.Point(237, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 69);
            this.btnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::projeto2.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(159, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 69);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnEditar.TabIndex = 7;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Image = global::projeto2.Properties.Resources.clipboard;
            this.btnListar.Location = new System.Drawing.Point(81, 3);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(72, 69);
            this.btnListar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnListar.TabIndex = 5;
            this.btnListar.TabStop = false;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Image = global::projeto2.Properties.Resources.plus;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(72, 69);
            this.btnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Tag = "";
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.FillWeight = 50.76142F;
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "Cod.";
            this.idPessoaDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPessoaDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomePessoaDataGridViewTextBoxColumn
            // 
            this.nomePessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePessoaDataGridViewTextBoxColumn.DataPropertyName = "NomePessoa";
            this.nomePessoaDataGridViewTextBoxColumn.FillWeight = 141.6268F;
            this.nomePessoaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomePessoaDataGridViewTextBoxColumn.Name = "nomePessoaDataGridViewTextBoxColumn";
            this.nomePessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailPessoaDataGridViewTextBoxColumn
            // 
            this.emailPessoaDataGridViewTextBoxColumn.DataPropertyName = "EmailPessoa";
            this.emailPessoaDataGridViewTextBoxColumn.FillWeight = 141.6268F;
            this.emailPessoaDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailPessoaDataGridViewTextBoxColumn.Name = "emailPessoaDataGridViewTextBoxColumn";
            this.emailPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonePessoaDataGridViewTextBoxColumn
            // 
            this.telefonePessoaDataGridViewTextBoxColumn.DataPropertyName = "TelefonePessoa";
            this.telefonePessoaDataGridViewTextBoxColumn.FillWeight = 87.825F;
            this.telefonePessoaDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefonePessoaDataGridViewTextBoxColumn.Name = "telefonePessoaDataGridViewTextBoxColumn";
            this.telefonePessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroClienteDataGridViewTextBoxColumn
            // 
            this.dataCadastroClienteDataGridViewTextBoxColumn.DataPropertyName = "DataCadastroCliente";
            this.dataCadastroClienteDataGridViewTextBoxColumn.FillWeight = 78.16F;
            this.dataCadastroClienteDataGridViewTextBoxColumn.HeaderText = "Cadastro";
            this.dataCadastroClienteDataGridViewTextBoxColumn.Name = "dataCadastroClienteDataGridViewTextBoxColumn";
            this.dataCadastroClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteModelBindingSource
            // 
            this.clienteModelBindingSource.DataSource = typeof(projeto2.Feature.Cliente.Model.ClienteModel);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.pnlcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.tblBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnCadastrar;
        private System.Windows.Forms.PictureBox btnListar;
        private System.Windows.Forms.TableLayoutPanel tblBotoes;
        private System.Windows.Forms.BindingSource clienteModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroClienteDataGridViewTextBoxColumn;
    }
}

