namespace projeto2.Feature.Marca.View.WinForms
{
    partial class FrmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcas));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.idMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvarMarca = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AutoGenerateColumns = false;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarcaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn});
            this.dgvMarcas.DataSource = this.marcaModelBindingSource;
            this.dgvMarcas.Location = new System.Drawing.Point(10, 86);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(600, 195);
            this.dgvMarcas.TabIndex = 3;
            this.dgvMarcas.TabStop = false;
            this.dgvMarcas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMarcas_CellMouseClick);
            // 
            // idMarcaDataGridViewTextBoxColumn
            // 
            this.idMarcaDataGridViewTextBoxColumn.DataPropertyName = "IdMarca";
            this.idMarcaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idMarcaDataGridViewTextBoxColumn.Name = "idMarcaDataGridViewTextBoxColumn";
            this.idMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaModelBindingSource
            // 
            this.marcaModelBindingSource.DataSource = typeof(projeto2.Feature.Marca.Model.MarcaModel);
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExcluirMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirMarca.Image = global::projeto2.Properties.Resources.garbage;
            this.btnExcluirMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirMarca.Location = new System.Drawing.Point(528, 1);
            this.btnExcluirMarca.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(83, 84);
            this.btnExcluirMarca.TabIndex = 11;
            this.btnExcluirMarca.Text = " Excluir [Del]";
            this.btnExcluirMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirMarca.UseVisualStyleBackColor = false;
            this.btnExcluirMarca.Click += new System.EventHandler(this.BtnExcluirMarca_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Image = global::projeto2.Properties.Resources.compose;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(437, 1);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 84);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar [ F4 ]";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnSalvarMarca
            // 
            this.btnSalvarMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvarMarca.Image = global::projeto2.Properties.Resources.plus;
            this.btnSalvarMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvarMarca.Location = new System.Drawing.Point(346, 1);
            this.btnSalvarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarMarca.Name = "btnSalvarMarca";
            this.btnSalvarMarca.Size = new System.Drawing.Size(83, 84);
            this.btnSalvarMarca.TabIndex = 10;
            this.btnSalvarMarca.Text = "Salvar [ + ]";
            this.btnSalvarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarMarca.UseVisualStyleBackColor = false;
            this.btnSalvarMarca.Click += new System.EventHandler(this.BtnSalvarMarca_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(25, 34);
            this.txtMarca.MaxLength = 25;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(317, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 60);
            this.txtId.MaxLength = 25;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(62, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 290);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluirMarca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvarMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.FrmMarcas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMarcas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.BindingSource marcaModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvarMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtId;
    }
}