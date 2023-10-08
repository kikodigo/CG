namespace CG
{
    partial class frm_ProdutoUnidadePesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProdutoUnidadePesquisa));
            this.dgv_ProdutoPesquisa = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.cbx_coluna = new System.Windows.Forms.ComboBox();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutoPesquisa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ProdutoPesquisa
            // 
            this.dgv_ProdutoPesquisa.AllowUserToAddRows = false;
            this.dgv_ProdutoPesquisa.AllowUserToDeleteRows = false;
            this.dgv_ProdutoPesquisa.AllowUserToResizeColumns = false;
            this.dgv_ProdutoPesquisa.AllowUserToResizeRows = false;
            this.dgv_ProdutoPesquisa.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_ProdutoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProdutoPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.unidade,
            this.Ativo});
            this.dgv_ProdutoPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ProdutoPesquisa.Location = new System.Drawing.Point(12, 73);
            this.dgv_ProdutoPesquisa.Name = "dgv_ProdutoPesquisa";
            this.dgv_ProdutoPesquisa.RowHeadersVisible = false;
            this.dgv_ProdutoPesquisa.Size = new System.Drawing.Size(812, 617);
            this.dgv_ProdutoPesquisa.TabIndex = 15;
            this.dgv_ProdutoPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ProdutoPesquisa_CellContentClick);
            this.dgv_ProdutoPesquisa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ProdutoPesquisa_CellContentDoubleClick);
            this.dgv_ProdutoPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ProdutoPesquisa_CellDoubleClick);
            // 
            // cod
            // 
            this.cod.DataPropertyName = "cod";
            this.cod.FillWeight = 70F;
            this.cod.Frozen = true;
            this.cod.HeaderText = "Codigo";
            this.cod.Name = "cod";
            this.cod.Width = 70;
            // 
            // unidade
            // 
            this.unidade.DataPropertyName = "unidade";
            this.unidade.Frozen = true;
            this.unidade.HeaderText = "Unidade";
            this.unidade.MinimumWidth = 650;
            this.unidade.Name = "unidade";
            this.unidade.Width = 650;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "ativo";
            this.Ativo.Frozen = true;
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpar.Location = new System.Drawing.Point(741, 46);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(83, 22);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // cbx_coluna
            // 
            this.cbx_coluna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_coluna.FormattingEnabled = true;
            this.cbx_coluna.Items.AddRange(new object[] {
            "UNIDADE",
            "CODIGO"});
            this.cbx_coluna.Location = new System.Drawing.Point(12, 46);
            this.cbx_coluna.Name = "cbx_coluna";
            this.cbx_coluna.Size = new System.Drawing.Size(139, 21);
            this.cbx_coluna.TabIndex = 14;
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(157, 47);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(578, 20);
            this.txt_referencia.TabIndex = 13;
            this.txt_referencia.TextChanged += new System.EventHandler(this.Txt_referencia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(154, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Coluna";
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(635, 47);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(100, 20);
            this.txt_destino.TabIndex = 18;
            this.txt_destino.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_usuario.Enabled = false;
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
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(744, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 147;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // frm_ProdutoUnidadePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(837, 681);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.dgv_ProdutoPesquisa);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.cbx_coluna);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(853, 720);
            this.MinimumSize = new System.Drawing.Size(853, 720);
            this.Name = "frm_ProdutoUnidadePesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Unidade";
            this.Load += new System.EventHandler(this.Frm_ProdutoUnidadePesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutoPesquisa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ProdutoPesquisa;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.ComboBox cbx_coluna;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
    }
}