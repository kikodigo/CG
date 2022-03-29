namespace CG
{
    partial class frm_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_config));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerText = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_deletarSenhas = new System.Windows.Forms.Button();
            this.btn_alterarConta = new System.Windows.Forms.Button();
            this.btn_apagarConta = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.pnl_header.Controls.Add(this.lbl_headerText);
            this.pnl_header.Controls.Add(this.btn_voltar);
            this.pnl_header.Location = new System.Drawing.Point(1, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(350, 102);
            this.pnl_header.TabIndex = 25;
            // 
            // lbl_headerText
            // 
            this.lbl_headerText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_headerText.AutoSize = true;
            this.lbl_headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_headerText.Location = new System.Drawing.Point(86, 40);
            this.lbl_headerText.Name = "lbl_headerText";
            this.lbl_headerText.Size = new System.Drawing.Size(169, 29);
            this.lbl_headerText.TabIndex = 25;
            this.lbl_headerText.Text = "Configurações";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Image = global::CG.Properties.Resources.back;
            this.btn_voltar.Location = new System.Drawing.Point(0, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(48, 42);
            this.btn_voltar.TabIndex = 22;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_deletarSenhas
            // 
            this.btn_deletarSenhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_deletarSenhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarSenhas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_deletarSenhas.Location = new System.Drawing.Point(26, 135);
            this.btn_deletarSenhas.Name = "btn_deletarSenhas";
            this.btn_deletarSenhas.Size = new System.Drawing.Size(290, 70);
            this.btn_deletarSenhas.TabIndex = 26;
            this.btn_deletarSenhas.Text = "Deletar todos as senhas guardadas";
            this.btn_deletarSenhas.UseVisualStyleBackColor = false;
            this.btn_deletarSenhas.Click += new System.EventHandler(this.btn_deletarSenhas_Click);
            this.btn_deletarSenhas.MouseLeave += new System.EventHandler(this.btn_deletarSenhas_MouseLeave);
            this.btn_deletarSenhas.MouseHover += new System.EventHandler(this.btn_deletarSenhas_MouseHover);
            // 
            // btn_alterarConta
            // 
            this.btn_alterarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_alterarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarConta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_alterarConta.Location = new System.Drawing.Point(26, 251);
            this.btn_alterarConta.Name = "btn_alterarConta";
            this.btn_alterarConta.Size = new System.Drawing.Size(290, 70);
            this.btn_alterarConta.TabIndex = 27;
            this.btn_alterarConta.Text = "Alterar informações da conta";
            this.btn_alterarConta.UseVisualStyleBackColor = false;
            this.btn_alterarConta.Click += new System.EventHandler(this.btn_alterarConta_Click);
            this.btn_alterarConta.MouseLeave += new System.EventHandler(this.btn_alterarConta_MouseLeave);
            this.btn_alterarConta.MouseHover += new System.EventHandler(this.btn_alterarConta_MouseHover);
            // 
            // btn_apagarConta
            // 
            this.btn_apagarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagarConta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_apagarConta.Location = new System.Drawing.Point(26, 371);
            this.btn_apagarConta.Name = "btn_apagarConta";
            this.btn_apagarConta.Size = new System.Drawing.Size(290, 70);
            this.btn_apagarConta.TabIndex = 28;
            this.btn_apagarConta.Text = "Apagar Conta";
            this.btn_apagarConta.UseVisualStyleBackColor = false;
            this.btn_apagarConta.Click += new System.EventHandler(this.btn_apagarConta_Click);
            this.btn_apagarConta.MouseLeave += new System.EventHandler(this.btn_apagarConta_MouseLeave);
            this.btn_apagarConta.MouseHover += new System.EventHandler(this.btn_apagarConta_MouseHover);
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.btn_apagarConta);
            this.Controls.Add(this.btn_alterarConta);
            this.Controls.Add(this.btn_deletarSenhas);
            this.Controls.Add(this.pnl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerText;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_deletarSenhas;
        private System.Windows.Forms.Button btn_alterarConta;
        private System.Windows.Forms.Button btn_apagarConta;
    }
}