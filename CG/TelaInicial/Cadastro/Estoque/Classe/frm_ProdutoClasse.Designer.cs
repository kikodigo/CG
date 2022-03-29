namespace CG
{
    partial class frm_ProdutoClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProdutoClasse));
            this.txt_Classe = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_classe = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.chx_editar = new System.Windows.Forms.CheckBox();
            this.lbl_ativo = new System.Windows.Forms.Label();
            this.cbx_ativo = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsm_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.cbx_Patrimonio = new System.Windows.Forms.ComboBox();
            this.lbl_patrimonio = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Classe
            // 
            this.txt_Classe.Enabled = false;
            this.txt_Classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Classe.Location = new System.Drawing.Point(87, 90);
            this.txt_Classe.Name = "txt_Classe";
            this.txt_Classe.Size = new System.Drawing.Size(473, 21);
            this.txt_Classe.TabIndex = 31;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(17, 90);
            this.txt_codigo.Multiline = true;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(69, 21);
            this.txt_codigo.TabIndex = 30;
            // 
            // lbl_classe
            // 
            this.lbl_classe.AutoSize = true;
            this.lbl_classe.ForeColor = System.Drawing.Color.Gray;
            this.lbl_classe.Location = new System.Drawing.Point(85, 74);
            this.lbl_classe.Name = "lbl_classe";
            this.lbl_classe.Size = new System.Drawing.Size(38, 13);
            this.lbl_classe.TabIndex = 29;
            this.lbl_classe.Text = "Classe";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_codigo.Location = new System.Drawing.Point(17, 74);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 28;
            this.lbl_codigo.Text = "Codigo";
            // 
            // chx_editar
            // 
            this.chx_editar.AutoSize = true;
            this.chx_editar.Location = new System.Drawing.Point(57, 30);
            this.chx_editar.Name = "chx_editar";
            this.chx_editar.Size = new System.Drawing.Size(66, 17);
            this.chx_editar.TabIndex = 38;
            this.chx_editar.Text = "EDITAR";
            this.chx_editar.UseVisualStyleBackColor = true;
            this.chx_editar.Visible = false;
            // 
            // lbl_ativo
            // 
            this.lbl_ativo.AutoSize = true;
            this.lbl_ativo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ativo.Location = new System.Drawing.Point(642, 74);
            this.lbl_ativo.Name = "lbl_ativo";
            this.lbl_ativo.Size = new System.Drawing.Size(31, 13);
            this.lbl_ativo.TabIndex = 39;
            this.lbl_ativo.Text = "Ativo";
            // 
            // cbx_ativo
            // 
            this.cbx_ativo.FormattingEnabled = true;
            this.cbx_ativo.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.cbx_ativo.Location = new System.Drawing.Point(645, 90);
            this.cbx_ativo.Name = "cbx_ativo";
            this.cbx_ativo.Size = new System.Drawing.Size(73, 21);
            this.cbx_ativo.TabIndex = 40;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_novo,
            this.tsm_editar,
            this.tsm_salvar,
            this.tsm_cancelar,
            this.tsm_anterior,
            this.tsm_proximo,
            this.tsm_pesquisar,
            this.tsm_excluir,
            this.txt_usuario,
            this.Usuario});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(739, 27);
            this.menuStrip2.TabIndex = 42;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsm_novo
            // 
            this.tsm_novo.Name = "tsm_novo";
            this.tsm_novo.Size = new System.Drawing.Size(48, 23);
            this.tsm_novo.Text = "Novo";
            this.tsm_novo.Click += new System.EventHandler(this.Tsm_novo_Click);
            // 
            // tsm_editar
            // 
            this.tsm_editar.Name = "tsm_editar";
            this.tsm_editar.Size = new System.Drawing.Size(49, 23);
            this.tsm_editar.Text = "Editar";
            this.tsm_editar.Click += new System.EventHandler(this.Tsm_editar_Click);
            // 
            // tsm_salvar
            // 
            this.tsm_salvar.Name = "tsm_salvar";
            this.tsm_salvar.Size = new System.Drawing.Size(50, 23);
            this.tsm_salvar.Text = "Salvar";
            this.tsm_salvar.Click += new System.EventHandler(this.Tsm_salvar_Click);
            // 
            // tsm_cancelar
            // 
            this.tsm_cancelar.Name = "tsm_cancelar";
            this.tsm_cancelar.Size = new System.Drawing.Size(65, 23);
            this.tsm_cancelar.Text = "Cancelar";
            this.tsm_cancelar.Click += new System.EventHandler(this.Tsm_cancelar_Click);
            // 
            // tsm_anterior
            // 
            this.tsm_anterior.Name = "tsm_anterior";
            this.tsm_anterior.Size = new System.Drawing.Size(62, 23);
            this.tsm_anterior.Text = "Anterior";
            this.tsm_anterior.Click += new System.EventHandler(this.Tsm_anterior_Click);
            // 
            // tsm_proximo
            // 
            this.tsm_proximo.Name = "tsm_proximo";
            this.tsm_proximo.Size = new System.Drawing.Size(64, 23);
            this.tsm_proximo.Text = "Proximo";
            this.tsm_proximo.Click += new System.EventHandler(this.Tsm_proximo_Click);
            // 
            // tsm_pesquisar
            // 
            this.tsm_pesquisar.Name = "tsm_pesquisar";
            this.tsm_pesquisar.Size = new System.Drawing.Size(65, 23);
            this.tsm_pesquisar.Text = "Pesquisa";
            this.tsm_pesquisar.Click += new System.EventHandler(this.Tsm_pesquisar_Click);
            // 
            // tsm_excluir
            // 
            this.tsm_excluir.Name = "tsm_excluir";
            this.tsm_excluir.Size = new System.Drawing.Size(54, 23);
            this.tsm_excluir.Text = "Excluir";
            this.tsm_excluir.Click += new System.EventHandler(this.Tsm_excluir_Click);
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
            this.lbl_VlPermissao.Location = new System.Drawing.Point(638, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 146;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // cbx_Patrimonio
            // 
            this.cbx_Patrimonio.FormattingEnabled = true;
            this.cbx_Patrimonio.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.cbx_Patrimonio.Location = new System.Drawing.Point(566, 90);
            this.cbx_Patrimonio.Name = "cbx_Patrimonio";
            this.cbx_Patrimonio.Size = new System.Drawing.Size(73, 21);
            this.cbx_Patrimonio.TabIndex = 148;
            // 
            // lbl_patrimonio
            // 
            this.lbl_patrimonio.AutoSize = true;
            this.lbl_patrimonio.ForeColor = System.Drawing.Color.Gray;
            this.lbl_patrimonio.Location = new System.Drawing.Point(563, 74);
            this.lbl_patrimonio.Name = "lbl_patrimonio";
            this.lbl_patrimonio.Size = new System.Drawing.Size(56, 13);
            this.lbl_patrimonio.TabIndex = 147;
            this.lbl_patrimonio.Text = "Patrimônio";
            // 
            // frm_ProdutoClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(739, 154);
            this.Controls.Add(this.cbx_Patrimonio);
            this.Controls.Add(this.lbl_patrimonio);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.cbx_ativo);
            this.Controls.Add(this.lbl_ativo);
            this.Controls.Add(this.chx_editar);
            this.Controls.Add(this.txt_Classe);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_classe);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(755, 193);
            this.MinimumSize = new System.Drawing.Size(755, 193);
            this.Name = "frm_ProdutoClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Classes";
            this.Load += new System.EventHandler(this.Frm_ProdutoClasse_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Classe;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_classe;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.CheckBox chx_editar;
        private System.Windows.Forms.Label lbl_ativo;
        private System.Windows.Forms.ComboBox cbx_ativo;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsm_novo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
        private System.Windows.Forms.ComboBox cbx_Patrimonio;
        private System.Windows.Forms.Label lbl_patrimonio;
    }
}