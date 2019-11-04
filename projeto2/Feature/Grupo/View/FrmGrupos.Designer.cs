namespace projeto2.Feature.Grupo.View
{
    partial class FrmGrupos
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
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.idGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluirGrupo = new System.Windows.Forms.Button();
            this.btnSalvarGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.AllowUserToAddRows = false;
            this.dgvGrupo.AllowUserToDeleteRows = false;
            this.dgvGrupo.AllowUserToResizeColumns = false;
            this.dgvGrupo.AllowUserToResizeRows = false;
            this.dgvGrupo.AutoGenerateColumns = false;
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGrupoDataGridViewTextBoxColumn,
            this.grupoDataGridViewTextBoxColumn});
            this.dgvGrupo.DataSource = this.grupoModelBindingSource;
            this.dgvGrupo.Location = new System.Drawing.Point(10, 86);
            this.dgvGrupo.MultiSelect = false;
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.ReadOnly = true;
            this.dgvGrupo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupo.Size = new System.Drawing.Size(600, 195);
            this.dgvGrupo.TabIndex = 3;
            this.dgvGrupo.TabStop = false;
            this.dgvGrupo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvGrupo_CellMouseClick);
            // 
            // idGrupoDataGridViewTextBoxColumn
            // 
            this.idGrupoDataGridViewTextBoxColumn.DataPropertyName = "IdGrupo";
            this.idGrupoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idGrupoDataGridViewTextBoxColumn.Name = "idGrupoDataGridViewTextBoxColumn";
            this.idGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoModelBindingSource
            // 
            this.grupoModelBindingSource.DataSource = typeof(projeto2.Feature.Grupo.Model.GrupoModel);
            // 
            // btnExcluirGrupo
            // 
            this.btnExcluirGrupo.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcluirGrupo.Enabled = false;
            this.btnExcluirGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirGrupo.Location = new System.Drawing.Point(499, 29);
            this.btnExcluirGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirGrupo.Name = "btnExcluirGrupo";
            this.btnExcluirGrupo.Size = new System.Drawing.Size(111, 32);
            this.btnExcluirGrupo.TabIndex = 2;
            this.btnExcluirGrupo.Text = "Deletar";
            this.btnExcluirGrupo.UseVisualStyleBackColor = false;
            this.btnExcluirGrupo.Click += new System.EventHandler(this.BtnExcluirGrupo_Click);
            // 
            // btnSalvarGrupo
            // 
            this.btnSalvarGrupo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarGrupo.Location = new System.Drawing.Point(385, 29);
            this.btnSalvarGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarGrupo.Name = "btnSalvarGrupo";
            this.btnSalvarGrupo.Size = new System.Drawing.Size(111, 32);
            this.btnSalvarGrupo.TabIndex = 1;
            this.btnSalvarGrupo.Text = "Salvar";
            this.btnSalvarGrupo.UseVisualStyleBackColor = false;
            this.btnSalvarGrupo.Click += new System.EventHandler(this.BtnSalvarGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grupo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(25, 34);
            this.txtGrupo.MaxLength = 100;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(335, 20);
            this.txtGrupo.TabIndex = 0;
            // 
            // FrmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 298);
            this.Controls.Add(this.dgvGrupo);
            this.Controls.Add(this.btnExcluirGrupo);
            this.Controls.Add(this.btnSalvarGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.FrmGrupos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGrupos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.Button btnExcluirGrupo;
        private System.Windows.Forms.Button btnSalvarGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.BindingSource grupoModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
    }
}