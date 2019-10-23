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
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.btnExcluirGrupo = new System.Windows.Forms.Button();
            this.btnSalvarGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.AllowUserToAddRows = false;
            this.dgvGrupo.AllowUserToDeleteRows = false;
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.grupo});
            this.dgvGrupo.Location = new System.Drawing.Point(10, 86);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.ReadOnly = true;
            this.dgvGrupo.Size = new System.Drawing.Size(600, 195);
            this.dgvGrupo.TabIndex = 3;
            this.dgvGrupo.TabStop = false;
            // 
            // btnExcluirGrupo
            // 
            this.btnExcluirGrupo.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcluirGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirGrupo.Location = new System.Drawing.Point(499, 29);
            this.btnExcluirGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirGrupo.Name = "btnExcluirGrupo";
            this.btnExcluirGrupo.Size = new System.Drawing.Size(111, 32);
            this.btnExcluirGrupo.TabIndex = 2;
            this.btnExcluirGrupo.Text = "Deletar";
            this.btnExcluirGrupo.UseVisualStyleBackColor = false;
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
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(335, 20);
            this.txtGrupo.TabIndex = 0;
            // 
            // idMarca
            // 
            this.idMarca.HeaderText = "Cod.";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            // 
            // grupo
            // 
            this.grupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.Button btnExcluirGrupo;
        private System.Windows.Forms.Button btnSalvarGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupo;
    }
}