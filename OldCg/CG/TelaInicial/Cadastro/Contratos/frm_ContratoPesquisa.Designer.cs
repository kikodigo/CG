namespace CG.Tela_Inicial.Cadastro.Contratos
{
    partial class frm_ContratoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ContratoPesquisa));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.dgv_ContratoPesquisa = new System.Windows.Forms.DataGridView();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.cbx_coluna = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ContratoPesquisa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(128, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coluna";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Limpar.Location = new System.Drawing.Point(783, 56);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(92, 21);
            this.btn_Limpar.TabIndex = 13;
            this.btn_Limpar.Text = "Limpar ";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // txt_destino
            // 
            this.txt_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_destino.Location = new System.Drawing.Point(680, 34);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(100, 21);
            this.txt_destino.TabIndex = 12;
            // 
            // dgv_ContratoPesquisa
            // 
            this.dgv_ContratoPesquisa.AllowUserToAddRows = false;
            this.dgv_ContratoPesquisa.AllowUserToDeleteRows = false;
            this.dgv_ContratoPesquisa.AllowUserToResizeColumns = false;
            this.dgv_ContratoPesquisa.AllowUserToResizeRows = false;
            this.dgv_ContratoPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_ContratoPesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_ContratoPesquisa.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_ContratoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ContratoPesquisa.Location = new System.Drawing.Point(12, 83);
            this.dgv_ContratoPesquisa.Name = "dgv_ContratoPesquisa";
            this.dgv_ContratoPesquisa.ReadOnly = true;
            this.dgv_ContratoPesquisa.RowHeadersVisible = false;
            this.dgv_ContratoPesquisa.Size = new System.Drawing.Size(863, 576);
            this.dgv_ContratoPesquisa.TabIndex = 11;
            this.dgv_ContratoPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ContratoPesquisa_CellDoubleClick);
            // 
            // txt_referencia
            // 
            this.txt_referencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_referencia.Location = new System.Drawing.Point(131, 56);
            this.txt_referencia.MinimumSize = new System.Drawing.Size(650, 21);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(650, 21);
            this.txt_referencia.TabIndex = 10;
            this.txt_referencia.TextChanged += new System.EventHandler(this.txt_referencia_TextChanged);
            // 
            // cbx_coluna
            // 
            this.cbx_coluna.FormattingEnabled = true;
            this.cbx_coluna.Items.AddRange(new object[] {
            "Codigo Contrato",
            "Nome do Contrato",
            "Contato"});
            this.cbx_coluna.Location = new System.Drawing.Point(12, 56);
            this.cbx_coluna.Name = "cbx_coluna";
            this.cbx_coluna.Size = new System.Drawing.Size(118, 21);
            this.cbx_coluna.TabIndex = 9;
            this.cbx_coluna.Text = "Nome do Contrato";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 27);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 23);
            // 
            // Usuario
            // 
            this.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(59, 23);
            this.Usuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 17;
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(806, 29);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 146;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.UseMnemonic = false;
            this.lbl_VlPermissao.Visible = false;
            // 
            // frm_ContratoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(887, 681);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.dgv_ContratoPesquisa);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.cbx_coluna);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(903, 720);
            this.MinimumSize = new System.Drawing.Size(903, 720);
            this.Name = "frm_ContratoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Contrato";
            this.Load += new System.EventHandler(this.frm_ContratoPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ContratoPesquisa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.DataGridView dgv_ContratoPesquisa;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.ComboBox cbx_coluna;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_VlPermissao;
    }
}