namespace projeto2.Login
{
    partial class FrmEntrarDev
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.iconErroSenha = new DevExpress.XtraEditors.SimpleButton();
            this.iconErroUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.iconSucessoUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(87, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Login";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(27, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.EditValue = "";
            this.txtSenha.Location = new System.Drawing.Point(27, 196);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.UseSystemPasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(212, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 177);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Senha";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Usuário";
            // 
            // btnEntrar
            // 
            this.btnEntrar.ImageOptions.Image = global::projeto2.Properties.Resources.apply_32x321;
            this.btnEntrar.Location = new System.Drawing.Point(84, 238);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(98, 35);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar [F5]";
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // iconErroSenha
            // 
            this.iconErroSenha.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_16x161;
            this.iconErroSenha.Location = new System.Drawing.Point(243, 196);
            this.iconErroSenha.Name = "iconErroSenha";
            this.iconErroSenha.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.iconErroSenha.Size = new System.Drawing.Size(21, 19);
            this.iconErroSenha.TabIndex = 7;
            this.iconErroSenha.Visible = false;
            // 
            // iconErroUsuario
            // 
            this.iconErroUsuario.ImageOptions.Image = global::projeto2.Properties.Resources.cancel_16x16;
            this.iconErroUsuario.Location = new System.Drawing.Point(243, 124);
            this.iconErroUsuario.Name = "iconErroUsuario";
            this.iconErroUsuario.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.iconErroUsuario.Size = new System.Drawing.Size(21, 19);
            this.iconErroUsuario.TabIndex = 6;
            this.iconErroUsuario.Visible = false;
            // 
            // iconSucessoUsuario
            // 
            this.iconSucessoUsuario.ImageOptions.Image = global::projeto2.Properties.Resources.apply_16x16;
            this.iconSucessoUsuario.Location = new System.Drawing.Point(245, 124);
            this.iconSucessoUsuario.Name = "iconSucessoUsuario";
            this.iconSucessoUsuario.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.iconSucessoUsuario.Size = new System.Drawing.Size(21, 19);
            this.iconSucessoUsuario.TabIndex = 5;
            this.iconSucessoUsuario.Visible = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "The Bezier";
            // 
            // FrmEntrarDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 299);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.iconErroSenha);
            this.Controls.Add(this.iconErroUsuario);
            this.Controls.Add(this.iconSucessoUsuario);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = global::projeto2.Properties.Resources.salesman__2_;
            this.KeyPreview = true;
            this.Name = "FrmEntrarDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.FrmEntrar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEntrar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton iconSucessoUsuario;
        private DevExpress.XtraEditors.SimpleButton iconErroUsuario;
        private DevExpress.XtraEditors.SimpleButton iconErroSenha;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}