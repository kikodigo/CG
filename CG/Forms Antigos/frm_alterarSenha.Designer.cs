namespace CG
{
    partial class frm_alterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alterarSenha));
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_confirmar = new System.Windows.Forms.Label();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerText = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_alterar.Location = new System.Drawing.Point(59, 297);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(230, 40);
            this.btn_alterar.TabIndex = 34;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_confirmar
            // 
            this.lbl_confirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_confirmar.AutoSize = true;
            this.lbl_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_confirmar.Location = new System.Drawing.Point(56, 229);
            this.lbl_confirmar.Name = "lbl_confirmar";
            this.lbl_confirmar.Size = new System.Drawing.Size(158, 18);
            this.lbl_confirmar.TabIndex = 33;
            this.lbl_confirmar.Text = "Confirmar nova senha:";
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_confirmar.Location = new System.Drawing.Point(59, 250);
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.Size = new System.Drawing.Size(230, 24);
            this.txt_confirmar.TabIndex = 32;
            // 
            // lbl_senha
            // 
            this.lbl_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_senha.Location = new System.Drawing.Point(56, 164);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(91, 18);
            this.lbl_senha.TabIndex = 31;
            this.lbl_senha.Text = "Nova senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_senha.Location = new System.Drawing.Point(59, 185);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(230, 24);
            this.txt_senha.TabIndex = 30;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.pnl_header.Controls.Add(this.lbl_headerText);
            this.pnl_header.Controls.Add(this.btn_voltar);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(350, 102);
            this.pnl_header.TabIndex = 35;
            // 
            // lbl_headerText
            // 
            this.lbl_headerText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_headerText.AutoSize = true;
            this.lbl_headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_headerText.Location = new System.Drawing.Point(98, 45);
            this.lbl_headerText.Name = "lbl_headerText";
            this.lbl_headerText.Size = new System.Drawing.Size(158, 29);
            this.lbl_headerText.TabIndex = 25;
            this.lbl_headerText.Text = "Alterar Senha";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_voltar.Image = global::CG.Properties.Resources.back;
            this.btn_voltar.Location = new System.Drawing.Point(3, 0);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(48, 42);
            this.btn_voltar.TabIndex = 22;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_alterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.lbl_confirmar);
            this.Controls.Add(this.txt_confirmar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_senha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_alterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_confirmar;
        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerText;
        private System.Windows.Forms.Button btn_voltar;
    }
}