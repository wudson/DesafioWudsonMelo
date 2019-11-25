namespace projeto2.Login
{
    partial class FrmEntrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrar));
            this.lblEntrar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.iconErroSenha = new System.Windows.Forms.PictureBox();
            this.iconErroUsuario = new System.Windows.Forms.PictureBox();
            this.iconSucessoUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconErroSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconErroUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSucessoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEntrar.Location = new System.Drawing.Point(115, 25);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(122, 47);
            this.lblEntrar.TabIndex = 4;
            this.lblEntrar.Text = "Login";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(36, 164);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(278, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrar.Location = new System.Drawing.Point(130, 294);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(99, 37);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(36, 230);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(278, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // iconErroSenha
            // 
            this.iconErroSenha.Image = global::projeto2.Properties.Resources.error16x;
            this.iconErroSenha.Location = new System.Drawing.Point(320, 230);
            this.iconErroSenha.Name = "iconErroSenha";
            this.iconErroSenha.Size = new System.Drawing.Size(21, 20);
            this.iconErroSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconErroSenha.TabIndex = 7;
            this.iconErroSenha.TabStop = false;
            this.iconErroSenha.Visible = false;
            this.iconErroSenha.MouseHover += new System.EventHandler(this.IconErroSenha_MouseHover);
            // 
            // iconErroUsuario
            // 
            this.iconErroUsuario.Image = global::projeto2.Properties.Resources.error16x;
            this.iconErroUsuario.Location = new System.Drawing.Point(320, 164);
            this.iconErroUsuario.Name = "iconErroUsuario";
            this.iconErroUsuario.Size = new System.Drawing.Size(21, 20);
            this.iconErroUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconErroUsuario.TabIndex = 7;
            this.iconErroUsuario.TabStop = false;
            this.iconErroUsuario.Visible = false;
            this.iconErroUsuario.MouseHover += new System.EventHandler(this.IconErroUsuario_MouseHover);
            // 
            // iconSucessoUsuario
            // 
            this.iconSucessoUsuario.Image = global::projeto2.Properties.Resources.success;
            this.iconSucessoUsuario.Location = new System.Drawing.Point(320, 164);
            this.iconSucessoUsuario.Name = "iconSucessoUsuario";
            this.iconSucessoUsuario.Size = new System.Drawing.Size(21, 20);
            this.iconSucessoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSucessoUsuario.TabIndex = 7;
            this.iconSucessoUsuario.TabStop = false;
            this.iconSucessoUsuario.Visible = false;
            // 
            // FrmEntrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 392);
            this.Controls.Add(this.iconErroSenha);
            this.Controls.Add(this.iconErroUsuario);
            this.Controls.Add(this.iconSucessoUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmEntrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.FrmEntrar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEntrar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconErroSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconErroUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSucessoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.PictureBox iconSucessoUsuario;
        private System.Windows.Forms.PictureBox iconErroUsuario;
        private System.Windows.Forms.PictureBox iconErroSenha;
    }
}