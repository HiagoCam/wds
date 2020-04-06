namespace WindowsFormsApp1
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblStatusSenha = new System.Windows.Forms.Label();
            this.lblStatusEmail = new System.Windows.Forms.Label();
            this.lblStatusCredenciais = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxRedonda1 = new WindowsFormsApp1.PictureBoxRedonda();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedonda1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login | Archin Representações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(216, 159);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(179, 20);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(216, 214);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(309, 214);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblStatusSenha
            // 
            this.lblStatusSenha.AutoSize = true;
            this.lblStatusSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusSenha.Location = new System.Drawing.Point(401, 162);
            this.lblStatusSenha.Name = "lblStatusSenha";
            this.lblStatusSenha.Size = new System.Drawing.Size(96, 15);
            this.lblStatusSenha.TabIndex = 8;
            this.lblStatusSenha.Text = "status da senha";
            // 
            // lblStatusEmail
            // 
            this.lblStatusEmail.AutoSize = true;
            this.lblStatusEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusEmail.Location = new System.Drawing.Point(401, 131);
            this.lblStatusEmail.Name = "lblStatusEmail";
            this.lblStatusEmail.Size = new System.Drawing.Size(92, 15);
            this.lblStatusEmail.TabIndex = 9;
            this.lblStatusEmail.Text = "status do email";
            // 
            // lblStatusCredenciais
            // 
            this.lblStatusCredenciais.AutoSize = true;
            this.lblStatusCredenciais.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCredenciais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusCredenciais.Location = new System.Drawing.Point(252, 192);
            this.lblStatusCredenciais.Name = "lblStatusCredenciais";
            this.lblStatusCredenciais.Size = new System.Drawing.Size(71, 15);
            this.lblStatusCredenciais.TabIndex = 10;
            this.lblStatusCredenciais.Text = "credenciais";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxRedonda1
            // 
            this.pictureBoxRedonda1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRedonda1.Image")));
            this.pictureBoxRedonda1.Location = new System.Drawing.Point(12, 94);
            this.pictureBoxRedonda1.Name = "pictureBoxRedonda1";
            this.pictureBoxRedonda1.Size = new System.Drawing.Size(137, 129);
            this.pictureBoxRedonda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRedonda1.TabIndex = 11;
            this.pictureBoxRedonda1.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 327);
            this.Controls.Add(this.pictureBoxRedonda1);
            this.Controls.Add(this.lblStatusCredenciais);
            this.Controls.Add(this.lblStatusEmail);
            this.Controls.Add(this.lblStatusSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Archin Representações";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedonda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblStatusSenha;
        private System.Windows.Forms.Label lblStatusEmail;
        private System.Windows.Forms.Label lblStatusCredenciais;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBoxRedonda pictureBoxRedonda1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

