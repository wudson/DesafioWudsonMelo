namespace projeto2.Feature.Promocao.View
{
    partial class FrmPeriodoPromocao
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
            this.txtTipoPromocao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTipoPromocao
            // 
            this.txtTipoPromocao.FormattingEnabled = true;
            this.txtTipoPromocao.Items.AddRange(new object[] {
            "Desconto",
            "Item gratis"});
            this.txtTipoPromocao.Location = new System.Drawing.Point(75, 105);
            this.txtTipoPromocao.Name = "txtTipoPromocao";
            this.txtTipoPromocao.Size = new System.Drawing.Size(491, 21);
            this.txtTipoPromocao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo da promoção";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(75, 180);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(241, 20);
            this.txtDataInicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de termino";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFim.Location = new System.Drawing.Point(325, 180);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(241, 20);
            this.txtDataFim.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(325, 311);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 41);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarCadastroProduto_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Location = new System.Drawing.Point(181, 311);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(0);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(141, 41);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // FrmPeriodoPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoPromocao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPeriodoPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de promoção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtTipoPromocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataFim;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProximo;
    }
}