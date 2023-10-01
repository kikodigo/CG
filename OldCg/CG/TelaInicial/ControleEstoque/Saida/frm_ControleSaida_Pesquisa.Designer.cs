
namespace CG.TelaInicial.ControleEstoque.Saida
{
    partial class frm_ControleSaida_Pesquisa
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_ControleSaida = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.cbx_coluna = new System.Windows.Forms.ComboBox();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControleSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.usuarioToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(974, 27);
            this.menuStrip2.TabIndex = 89;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 23);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.usuarioToolStripMenuItem.Text = "Usuario:";
            // 
            // dgv_ControleSaida
            // 
            this.dgv_ControleSaida.AllowUserToAddRows = false;
            this.dgv_ControleSaida.AllowUserToDeleteRows = false;
            this.dgv_ControleSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ControleSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ControleSaida.Location = new System.Drawing.Point(12, 71);
            this.dgv_ControleSaida.Name = "dgv_ControleSaida";
            this.dgv_ControleSaida.ReadOnly = true;
            this.dgv_ControleSaida.RowHeadersVisible = false;
            this.dgv_ControleSaida.Size = new System.Drawing.Size(950, 598);
            this.dgv_ControleSaida.TabIndex = 197;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(154, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 201;
            this.label2.Text = "Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 200;
            this.label1.Text = "Coluna";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Limpar.Location = new System.Drawing.Point(879, 41);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(83, 22);
            this.btn_Limpar.TabIndex = 198;
            this.btn_Limpar.Text = "Limpar ";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // cbx_coluna
            // 
            this.cbx_coluna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_coluna.FormattingEnabled = true;
            this.cbx_coluna.Items.AddRange(new object[] {
            "CODIGO",
            "CONTRATO",
            "STATUS"});
            this.cbx_coluna.Location = new System.Drawing.Point(12, 43);
            this.cbx_coluna.Name = "cbx_coluna";
            this.cbx_coluna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_coluna.Size = new System.Drawing.Size(139, 21);
            this.cbx_coluna.TabIndex = 199;
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(157, 43);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(716, 20);
            this.txt_referencia.TabIndex = 202;
            // 
            // frm_ControleSaida_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.cbx_coluna);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.dgv_ControleSaida);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frm_ControleSaida_Pesquisa";
            this.Text = "frm_ControleSaida_Pesquisa";
            this.Load += new System.EventHandler(this.frm_ControleSaida_Pesquisa_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControleSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_ControleSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.ComboBox cbx_coluna;
        private System.Windows.Forms.TextBox txt_referencia;
    }
}