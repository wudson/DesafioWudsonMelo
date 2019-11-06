﻿namespace projeto2.Feature.Promocao.View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.promocaoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomePromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomePromocaoDataGridViewTextBoxColumn,
            this.TipoPromocao,
            this.DataInicio,
            this.DataFim,
            this.statusPromocaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.promocaoModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(625, 340);
            this.dataGridView1.TabIndex = 7;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Image = global::projeto2.Properties.Resources.compose;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(109, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar - [ F4 ]";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // promocaoModelBindingSource
            // 
            this.promocaoModelBindingSource.DataSource = typeof(projeto2.Feature.Promocao.Model.PromocaoModel);
            // 
            // nomePromocaoDataGridViewTextBoxColumn
            // 
            this.nomePromocaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePromocaoDataGridViewTextBoxColumn.DataPropertyName = "NomePromocao";
            this.nomePromocaoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomePromocaoDataGridViewTextBoxColumn.Name = "nomePromocaoDataGridViewTextBoxColumn";
            this.nomePromocaoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // statusPromocaoDataGridViewTextBoxColumn
            // 
            this.statusPromocaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusPromocaoDataGridViewTextBoxColumn.DataPropertyName = "StatusPromocao";
            this.statusPromocaoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusPromocaoDataGridViewTextBoxColumn.Name = "statusPromocaoDataGridViewTextBoxColumn";
            this.statusPromocaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusPromocaoDataGridViewTextBoxColumn.Width = 70;
            // 
            // FrmPromocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnAdcionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmPromocoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promoções";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource promocaoModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPromocaoDataGridViewTextBoxColumn;
    }
}