namespace projeto2.Feature.Promocao.View
{
    partial class FrmPromocoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromocoes));
            this.dgvPromocoes = new System.Windows.Forms.DataGridView();
            this.TipoPromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.nomePromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promocaoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromocoes
            // 
            this.dgvPromocoes.AllowUserToAddRows = false;
            this.dgvPromocoes.AllowUserToDeleteRows = false;
            this.dgvPromocoes.AutoGenerateColumns = false;
            this.dgvPromocoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomePromocaoDataGridViewTextBoxColumn,
            this.TipoPromocao,
            this.DataInicio,
            this.DataFim,
            this.statusPromocao});
            this.dgvPromocoes.DataSource = this.promocaoModelBindingSource;
            this.dgvPromocoes.Location = new System.Drawing.Point(12, 98);
            this.dgvPromocoes.Name = "dgvPromocoes";
            this.dgvPromocoes.ReadOnly = true;
            this.dgvPromocoes.Size = new System.Drawing.Size(625, 340);
            this.dgvPromocoes.TabIndex = 7;
            // 
            // TipoPromocao
            // 
            this.TipoPromocao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoPromocao.DataPropertyName = "TipoPromocao";
            this.TipoPromocao.HeaderText = "Tipo";
            this.TipoPromocao.Name = "TipoPromocao";
            this.TipoPromocao.ReadOnly = true;
            this.TipoPromocao.Width = 120;
            // 
            // DataInicio
            // 
            this.DataInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataInicio.DataPropertyName = "DataInicio";
            this.DataInicio.HeaderText = "Inicio";
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.ReadOnly = true;
            this.DataInicio.Width = 85;
            // 
            // DataFim
            // 
            this.DataFim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataFim.DataPropertyName = "DataFim";
            this.DataFim.HeaderText = "Fim";
            this.DataFim.Name = "DataFim";
            this.DataFim.ReadOnly = true;
            this.DataFim.Width = 85;
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdcionar.Image = global::projeto2.Properties.Resources.plus;
            this.btnAdcionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdcionar.Location = new System.Drawing.Point(12, 7);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(91, 85);
            this.btnAdcionar.TabIndex = 1;
            this.btnAdcionar.Text = "Adicionar - [ + ]";
            this.btnAdcionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::projeto2.Properties.Resources.compose;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(109, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 85);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar - [ F4 ]";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // nomePromocaoDataGridViewTextBoxColumn
            // 
            this.nomePromocaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePromocaoDataGridViewTextBoxColumn.DataPropertyName = "NomePromocao";
            this.nomePromocaoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomePromocaoDataGridViewTextBoxColumn.Name = "nomePromocaoDataGridViewTextBoxColumn";
            this.nomePromocaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusPromocao
            // 
            this.statusPromocao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusPromocao.DataPropertyName = "StatusPromocao";
            this.statusPromocao.HeaderText = "Status";
            this.statusPromocao.Name = "statusPromocao";
            this.statusPromocao.ReadOnly = true;
            this.statusPromocao.Width = 70;
            // 
            // promocaoModelBindingSource
            // 
            this.promocaoModelBindingSource.DataSource = typeof(projeto2.Feature.Promocao.Model.PromocaoModel);
            // 
            // FrmPromocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnAdcionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvPromocoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmPromocoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promoções";
            this.Load += new System.EventHandler(this.FrmPromocoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.DataGridView dgvPromocoes;
        private System.Windows.Forms.BindingSource promocaoModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPromocao;
    }
}