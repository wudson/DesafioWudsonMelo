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
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.btnCancelarCadastroCliente = new System.Windows.Forms.Button();
            this.btnSalvarCadastroCliente = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(434, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(79, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(304, 257);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 3;
            this.lblRg.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(307, 273);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(209, 20);
            this.txtRg.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(79, 257);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(82, 273);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(216, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(79, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(434, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(82, 188);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(147, 20);
            this.txtDataCadastro.TabIndex = 16;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(79, 172);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(102, 13);
            this.lblDataNascimento.TabIndex = 17;
            this.lblDataNascimento.Text = "Data de nascimento";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(82, 233);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 18;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(174, 233);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 19;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(79, 217);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 20;
            this.lblSexo.Text = "Sexo";
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.Location = new System.Drawing.Point(82, 46);
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.ReadOnly = true;
            this.txtIdPessoa.Size = new System.Drawing.Size(177, 20);
            this.txtIdPessoa.TabIndex = 23;
            this.txtIdPessoa.Text = "0";
            this.txtIdPessoa.Visible = false;
            // 
            // btnCancelarCadastroCliente
            // 
            this.btnCancelarCadastroCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarCadastroCliente.Location = new System.Drawing.Point(307, 324);
            this.btnCancelarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarCadastroCliente.Name = "btnCancelarCadastroCliente";
            this.btnCancelarCadastroCliente.Size = new System.Drawing.Size(141, 32);
            this.btnCancelarCadastroCliente.TabIndex = 22;
            this.btnCancelarCadastroCliente.Text = "Cancelar";
            this.btnCancelarCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroCliente.Click += new System.EventHandler(this.BtnCancelarCadastroCliente_Click);
            // 
            // btnSalvarCadastroCliente
            // 
            this.btnSalvarCadastroCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarCadastroCliente.Location = new System.Drawing.Point(157, 324);
            this.btnSalvarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarCadastroCliente.Name = "btnSalvarCadastroCliente";
            this.btnSalvarCadastroCliente.Size = new System.Drawing.Size(141, 32);
            this.btnSalvarCadastroCliente.TabIndex = 21;
            this.btnSalvarCadastroCliente.Text = "Salvar";
            this.btnSalvarCadastroCliente.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroCliente.Click += new System.EventHandler(this.BtnSalvarCadastroCliente_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(251, 172);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 25;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(254, 188);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 20);
            this.txtTelefone.TabIndex = 24;
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCadastroDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtIdPessoa);
            this.Controls.Add(this.btnCancelarCadastroCliente);
            this.Controls.Add(this.btnSalvarCadastroCliente);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmCadastroDeCliente";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Button btnCancelarCadastroCliente;
        private System.Windows.Forms.Button btnSalvarCadastroCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}