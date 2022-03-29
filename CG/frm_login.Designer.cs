namespace CG
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_headerText = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.pbx_senha = new System.Windows.Forms.PictureBox();
            this.pbx_user = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_header.BackColor = System.Drawing.Color.Gray;
            this.pnl_header.Controls.Add(this.pictureBox1);
            this.pnl_header.Controls.Add(this.lbl_headerText);
            this.pnl_header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_header.Location = new System.Drawing.Point(-8, -2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(354, 120);
            this.pnl_header.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CG.Properties.Resources.C_G;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_headerText
            // 
            this.lbl_headerText.AutoSize = true;
            this.lbl_headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_headerText.Location = new System.Drawing.Point(131, 51);
            this.lbl_headerText.Name = "lbl_headerText";
            this.lbl_headerText.Size = new System.Drawing.Size(0, 25);
            this.lbl_headerText.TabIndex = 12;
            this.lbl_headerText.Click += new System.EventHandler(this.Lbl_headerText_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_entrar.Location = new System.Drawing.Point(41, 401);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(251, 40);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_username.Location = new System.Drawing.Point(94, 222);
            this.txt_username.MaximumSize = new System.Drawing.Size(198, 21);
            this.txt_username.MinimumSize = new System.Drawing.Size(198, 21);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(198, 24);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Usuário";
            this.txt_username.TextChanged += new System.EventHandler(this.Txt_username_TextChanged);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_username_KeyPress);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha.BackColor = System.Drawing.Color.White;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_senha.Location = new System.Drawing.Point(94, 276);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(2);
            this.txt_senha.MaximumSize = new System.Drawing.Size(198, 21);
            this.txt_senha.MinimumSize = new System.Drawing.Size(198, 21);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(198, 24);
            this.txt_senha.TabIndex = 2;
            this.txt_senha.Text = "Senha";
            this.txt_senha.TextChanged += new System.EventHandler(this.Txt_senha_TextChanged);
            this.txt_senha.Enter += new System.EventHandler(this.txt_senha_Enter);
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_senha_KeyPress);
            this.txt_senha.Leave += new System.EventHandler(this.txt_senha_Leave);
            // 
            // lbl_erro
            // 
            this.lbl_erro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(37, 335);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro.TabIndex = 11;
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cadastro.AutoSize = true;
            this.lbl_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cadastro.Location = new System.Drawing.Point(37, 378);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(0, 20);
            this.lbl_cadastro.TabIndex = 12;
            // 
            // pbx_senha
            // 
            this.pbx_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_senha.Image = global::CG.Properties.Resources.lock_symbol_for_interface;
            this.pbx_senha.Location = new System.Drawing.Point(41, 272);
            this.pbx_senha.Name = "pbx_senha";
            this.pbx_senha.Size = new System.Drawing.Size(33, 28);
            this.pbx_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_senha.TabIndex = 15;
            this.pbx_senha.TabStop = false;
            // 
            // pbx_user
            // 
            this.pbx_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_user.Image = global::CG.Properties.Resources.black_male_user_symbol;
            this.pbx_user.Location = new System.Drawing.Point(41, 218);
            this.pbx_user.Name = "pbx_user";
            this.pbx_user.Size = new System.Drawing.Size(34, 28);
            this.pbx_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_user.TabIndex = 14;
            this.pbx_user.TabStop = false;
            this.pbx_user.Click += new System.EventHandler(this.pbx_user_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.pbx_senha);
            this.Controls.Add(this.pbx_user);
            this.Controls.Add(this.lbl_cadastro);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_username);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CG - Login";
            this.Load += new System.EventHandler(this.Frm_login_Load_1);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Label lbl_cadastro;
        private System.Windows.Forms.PictureBox pbx_user;
        private System.Windows.Forms.PictureBox pbx_senha;
        private System.Windows.Forms.Label lbl_headerText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

