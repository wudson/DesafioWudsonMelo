namespace projeto2.Feature.Cliente.View
{
    partial class FrmCadastroDeCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.btnCancelarCadastroCliente = new System.Windows.Forms.Button();
            this.btnSalvarCadastroCliente = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.pnlFormCliente = new System.Windows.Forms.Panel();
            this.pnlFormCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(434, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(81, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(306, 255);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 17;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(81, 255);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 16;
            this.lblCpf.Text = "CPF";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(81, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(434, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(81, 170);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(102, 13);
            this.lblDataNascimento.TabIndex = 13;
            this.lblDataNascimento.Text = "Data de nascimento";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(84, 231);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 4;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(176, 231);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 5;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(81, 215);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo";
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.Location = new System.Drawing.Point(84, 44);
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.ReadOnly = true;
            this.txtIdPessoa.Size = new System.Drawing.Size(177, 20);
            this.txtIdPessoa.TabIndex = 10;
            this.txtIdPessoa.Text = "0";
            this.txtIdPessoa.Visible = false;
            // 
            // btnCancelarCadastroCliente
            // 
            this.btnCancelarCadastroCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarCadastroCliente.Location = new System.Drawing.Point(309, 322);
            this.btnCancelarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarCadastroCliente.Name = "btnCancelarCadastroCliente";
            this.btnCancelarCadastroCliente.Size = new System.Drawing.Size(141, 32);
            this.btnCancelarCadastroCliente.TabIndex = 9;
            this.btnCancelarCadastroCliente.Text = "Cancelar";
            this.btnCancelarCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroCliente.Click += new System.EventHandler(this.BtnCancelarCadastroCliente_Click);
            // 
            // btnSalvarCadastroCliente
            // 
            this.btnSalvarCadastroCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarCadastroCliente.Location = new System.Drawing.Point(159, 322);
            this.btnSalvarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarCadastroCliente.Name = "btnSalvarCadastroCliente";
            this.btnSalvarCadastroCliente.Size = new System.Drawing.Size(141, 32);
            this.btnSalvarCadastroCliente.TabIndex = 8;
            this.btnSalvarCadastroCliente.Text = "Salvar";
            this.btnSalvarCadastroCliente.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroCliente.Click += new System.EventHandler(this.BtnSalvarCadastroCliente_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(195, 170);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(198, 186);
            this.txtTelefone.Mask = "00 00000 0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(102, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Checked = false;
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(84, 186);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(108, 20);
            this.txtDataNascimento.TabIndex = 18;
            this.txtDataNascimento.Value = new System.DateTime(2019, 10, 17, 0, 0, 0, 0);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(306, 271);
            this.txtRg.Mask = "000000000";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(212, 20);
            this.txtRg.TabIndex = 19;
            this.txtRg.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(84, 271);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(216, 20);
            this.txtCpf.TabIndex = 20;
            this.txtCpf.ValidatingType = typeof(System.DateTime);
            // 
            // pnlFormCliente
            // 
            this.pnlFormCliente.Controls.Add(this.rdbMasculino);
            this.pnlFormCliente.Controls.Add(this.rdbFeminino);
            this.pnlFormCliente.Controls.Add(this.txtCpf);
            this.pnlFormCliente.Controls.Add(this.txtNome);
            this.pnlFormCliente.Controls.Add(this.txtRg);
            this.pnlFormCliente.Controls.Add(this.lblNome);
            this.pnlFormCliente.Controls.Add(this.txtDataNascimento);
            this.pnlFormCliente.Controls.Add(this.lblRg);
            this.pnlFormCliente.Controls.Add(this.lblTelefone);
            this.pnlFormCliente.Controls.Add(this.lblCpf);
            this.pnlFormCliente.Controls.Add(this.txtTelefone);
            this.pnlFormCliente.Controls.Add(this.txtEmail);
            this.pnlFormCliente.Controls.Add(this.txtIdPessoa);
            this.pnlFormCliente.Controls.Add(this.lblEmail);
            this.pnlFormCliente.Controls.Add(this.btnCancelarCadastroCliente);
            this.pnlFormCliente.Controls.Add(this.lblDataNascimento);
            this.pnlFormCliente.Controls.Add(this.btnSalvarCadastroCliente);
            this.pnlFormCliente.Controls.Add(this.lblSexo);
            this.pnlFormCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlFormCliente.Name = "pnlFormCliente";
            this.pnlFormCliente.Size = new System.Drawing.Size(601, 450);
            this.pnlFormCliente.TabIndex = 21;
            // 
            // FrmCadastroDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.pnlFormCliente);
            this.Name = "FrmCadastroDeCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FrmCadastroDeCliente_Load);
            this.pnlFormCliente.ResumeLayout(false);
            this.pnlFormCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Button btnCancelarCadastroCliente;
        private System.Windows.Forms.Button btnSalvarCadastroCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Panel pnlFormCliente;
    }
}