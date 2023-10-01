namespace CG
{
    partial class frm_alterarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alterarConta));
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerText = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.btn_alterarSenha = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_username.Location = new System.Drawing.Point(56, 208);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(126, 18);
            this.lbl_username.TabIndex = 24;
            this.lbl_username.Text = "Nome de usuário:";
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nome.Location = new System.Drawing.Point(59, 160);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(230, 24);
            this.txt_nome.TabIndex = 20;
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_nome.Location = new System.Drawing.Point(56, 139);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome.TabIndex = 23;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_username.Location = new System.Drawing.Point(59, 229);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(230, 24);
            this.txt_username.TabIndex = 21;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.pnl_header.Controls.Add(this.lbl_headerText);
            this.pnl_header.Controls.Add(this.btn_voltar);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(350, 102);
            this.pnl_header.TabIndex = 28;
            // 
            // lbl_headerText
            // 
            this.lbl_headerText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_headerText.AutoSize = true;
            this.lbl_headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_headerText.Location = new System.Drawing.Point(14, 48);
            this.lbl_headerText.Name = "lbl_headerText";
            this.lbl_headerText.Size = new System.Drawing.Size(318, 29);
            this.lbl_headerText.TabIndex = 25;
            this.lbl_headerText.Text = "Alterar Informações da conta";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_voltar.Image = global::CG.Properties.Resources.back;
            this.btn_voltar.Location = new System.Drawing.Point(3, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(48, 42);
            this.btn_voltar.TabIndex = 22;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_alterar.Location = new System.Drawing.Point(59, 323);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(230, 40);
            this.btn_alterar.TabIndex = 29;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_erro
            // 
            this.lbl_erro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(32, 457);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro.TabIndex = 30;
            // 
            // btn_alterarSenha
            // 
            this.btn_alterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_alterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(126)))), ((int)(((byte)(219)))));
            this.btn_alterarSenha.Location = new System.Drawing.Point(59, 369);
            this.btn_alterarSenha.Name = "btn_alterarSenha";
            this.btn_alterarSenha.Size = new System.Drawing.Size(230, 40);
            this.btn_alterarSenha.TabIndex = 31;
            this.btn_alterarSenha.Text = "Alterar Senha...";
            this.btn_alterarSenha.UseVisualStyleBackColor = false;
            this.btn_alterarSenha.Click += new System.EventHandler(this.btn_alterarConta_Click);
            // 
            // frm_alterarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.btn_alterarSenha);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "frm_alterarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.frm_alterarConta_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerText;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Button btn_alterarSenha;
    }
}