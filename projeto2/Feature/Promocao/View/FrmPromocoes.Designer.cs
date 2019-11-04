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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nomePromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomePromocao,
            this.tipoPromocao,
            this.statusPromocao});
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
            // nomePromocao
            // 
            this.nomePromocao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePromocao.HeaderText = "Nome";
            this.nomePromocao.Name = "nomePromocao";
            this.nomePromocao.ReadOnly = true;
            // 
            // tipoPromocao
            // 
            this.tipoPromocao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipoPromocao.HeaderText = "Tipo";
            this.tipoPromocao.Name = "tipoPromocao";
            this.tipoPromocao.ReadOnly = true;
            this.tipoPromocao.Width = 120;
            // 
            // statusPromocao
            // 
            this.statusPromocao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusPromocao.HeaderText = "Status";
            this.statusPromocao.Name = "statusPromocao";
            this.statusPromocao.ReadOnly = true;
            this.statusPromocao.Width = 120;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPromocao;
    }
}