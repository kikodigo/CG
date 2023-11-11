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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            pnl_header = new Panel();
            pictureBox1 = new PictureBox();
            lbl_headerText = new Label();
            btn_entrar = new Button();
            txt_username = new TextBox();
            txt_senha = new TextBox();
            lbl_erro = new Label();
            lbl_cadastro = new Label();
            pbx_senha = new PictureBox();
            pbx_user = new PictureBox();
            pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_senha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_user).BeginInit();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Anchor = AnchorStyles.None;
            pnl_header.BackColor = Color.Gray;
            pnl_header.Controls.Add(pictureBox1);
            pnl_header.Controls.Add(lbl_headerText);
            pnl_header.ForeColor = SystemColors.ControlText;
            pnl_header.Location = new Point(-10, -3);
            pnl_header.Margin = new Padding(5, 4, 5, 4);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(472, 184);
            pnl_header.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.C_G;
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lbl_headerText
            // 
            lbl_headerText.AutoSize = true;
            lbl_headerText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_headerText.ForeColor = SystemColors.ControlLight;
            lbl_headerText.Location = new Point(175, 79);
            lbl_headerText.Margin = new Padding(5, 0, 5, 0);
            lbl_headerText.Name = "lbl_headerText";
            lbl_headerText.Size = new Size(0, 31);
            lbl_headerText.TabIndex = 12;
            // 
            // btn_entrar
            // 
            btn_entrar.Anchor = AnchorStyles.None;
            btn_entrar.BackColor = Color.FromArgb(64, 67, 73);
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.ForeColor = SystemColors.ControlLightLight;
            btn_entrar.Location = new Point(55, 617);
            btn_entrar.Margin = new Padding(5, 4, 5, 4);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(335, 61);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_ClickAsync;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.None;
            txt_username.BackColor = Color.White;
            txt_username.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = SystemColors.WindowFrame;
            txt_username.Location = new Point(126, 341);
            txt_username.Margin = new Padding(5, 4, 5, 4);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(262, 29);
            txt_username.TabIndex = 1;
            txt_username.Text = "Usuário";
            txt_username.Enter += txt_username_Enter;
            txt_username.KeyPress += Txt_username_KeyPress;
            txt_username.Leave += txt_username_Leave;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.None;
            txt_senha.BackColor = Color.White;
            txt_senha.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.ForeColor = SystemColors.WindowFrame;
            txt_senha.Location = new Point(126, 424);
            txt_senha.Margin = new Padding(2, 3, 2, 3);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(262, 29);
            txt_senha.TabIndex = 2;
            txt_senha.Text = "Senha";
            txt_senha.Enter += txt_senha_Enter;
            txt_senha.KeyPress += Txt_senha_KeyPress;
            txt_senha.Leave += txt_senha_Leave;
            // 
            // lbl_erro
            // 
            lbl_erro.Anchor = AnchorStyles.None;
            lbl_erro.AutoSize = true;
            lbl_erro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_erro.ForeColor = Color.Red;
            lbl_erro.Location = new Point(49, 516);
            lbl_erro.Margin = new Padding(5, 0, 5, 0);
            lbl_erro.Name = "lbl_erro";
            lbl_erro.Size = new Size(0, 25);
            lbl_erro.TabIndex = 11;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.Anchor = AnchorStyles.None;
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cadastro.ForeColor = SystemColors.Control;
            lbl_cadastro.Location = new Point(49, 581);
            lbl_cadastro.Margin = new Padding(5, 0, 5, 0);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(0, 25);
            lbl_cadastro.TabIndex = 12;
            // 
            // pbx_senha
            // 
            pbx_senha.Anchor = AnchorStyles.None;
            pbx_senha.Image = Properties.Resources.lock_symbol;
            pbx_senha.Location = new Point(55, 419);
            pbx_senha.Margin = new Padding(5, 4, 5, 4);
            pbx_senha.Name = "pbx_senha";
            pbx_senha.Size = new Size(43, 43);
            pbx_senha.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_senha.TabIndex = 15;
            pbx_senha.TabStop = false;
            // 
            // pbx_user
            // 
            pbx_user.Anchor = AnchorStyles.None;
            pbx_user.Image = Properties.Resources.black_male_user_symbol;
            pbx_user.Location = new Point(55, 336);
            pbx_user.Margin = new Padding(5, 4, 5, 4);
            pbx_user.Name = "pbx_user";
            pbx_user.Size = new Size(46, 43);
            pbx_user.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_user.TabIndex = 14;
            pbx_user.TabStop = false;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(456, 760);
            Controls.Add(pbx_senha);
            Controls.Add(pbx_user);
            Controls.Add(lbl_cadastro);
            Controls.Add(lbl_erro);
            Controls.Add(pnl_header);
            Controls.Add(btn_entrar);
            Controls.Add(txt_senha);
            Controls.Add(txt_username);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MaximumSize = new Size(474, 807);
            MinimumSize = new Size(474, 807);
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CG - Login";
            FormClosing += frm_login_FormClosing;
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_senha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_user).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnl_header;
        private Button btn_entrar;
        private TextBox txt_username;
        private TextBox txt_senha;
        private Label lbl_erro;
        private Label lbl_cadastro;
        private PictureBox pbx_user;
        private PictureBox pbx_senha;
        private Label lbl_headerText;
        private PictureBox pictureBox1;
    }
}

