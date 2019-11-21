namespace projeto2.Feature.Grupo.View.WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupos));
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.idGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalvarGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluirGrupo = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
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
            // btnSalvarGrupo
            // 
            this.btnSalvarGrupo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarGrupo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvarGrupo.Image = global::projeto2.Properties.Resources.plus;
            this.btnSalvarGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvarGrupo.Location = new System.Drawing.Point(346, 1);
            this.btnSalvarGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarGrupo.Name = "btnSalvarGrupo";
            this.btnSalvarGrupo.Size = new System.Drawing.Size(83, 84);
            this.btnSalvarGrupo.TabIndex = 1;
            this.btnSalvarGrupo.Text = "Salvar [ + ]";
            this.btnSalvarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.txtGrupo.MaxLength = 25;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(317, 20);
            this.txtGrupo.TabIndex = 0;
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
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar [ F4 ]";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnExcluirGrupo
            // 
            this.btnExcluirGrupo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExcluirGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirGrupo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirGrupo.Image = global::projeto2.Properties.Resources.garbage;
            this.btnExcluirGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirGrupo.Location = new System.Drawing.Point(528, 1);
            this.btnExcluirGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirGrupo.Name = "btnExcluirGrupo";
            this.btnExcluirGrupo.Size = new System.Drawing.Size(83, 84);
            this.btnExcluirGrupo.TabIndex = 5;
            this.btnExcluirGrupo.Text = " Excluir [Del]";
            this.btnExcluirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirGrupo.UseVisualStyleBackColor = false;
            this.btnExcluirGrupo.Click += new System.EventHandler(this.BtnExcluirGrupo_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(26, 60);
            this.txtId.MaxLength = 25;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(62, 20);
            this.txtId.TabIndex = 6;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // FrmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 291);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluirGrupo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvGrupo);
            this.Controls.Add(this.btnSalvarGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnSalvarGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.BindingSource grupoModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluirGrupo;
        private System.Windows.Forms.TextBox txtId;
    }
}