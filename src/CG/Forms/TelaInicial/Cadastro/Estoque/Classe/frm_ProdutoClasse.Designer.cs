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
            txt_Classe = new TextBox();
            txt_codigo = new TextBox();
            lbl_classe = new Label();
            lbl_codigo = new Label();
            chx_editar = new CheckBox();
            lbl_ativo = new Label();
            cbx_ativo = new ComboBox();
            menuStrip2 = new MenuStrip();
            tsm_novo = new ToolStripMenuItem();
            tsm_editar = new ToolStripMenuItem();
            tsm_salvar = new ToolStripMenuItem();
            tsm_cancelar = new ToolStripMenuItem();
            tsm_anterior = new ToolStripMenuItem();
            tsm_proximo = new ToolStripMenuItem();
            tsm_pesquisar = new ToolStripMenuItem();
            tsm_excluir = new ToolStripMenuItem();
            txt_usuario = new ToolStripTextBox();
            Usuario = new ToolStripMenuItem();
            lbl_VlPermissao = new Label();
            cbx_Patrimonio = new ComboBox();
            lbl_patrimonio = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Classe
            // 
            txt_Classe.Enabled = false;
            txt_Classe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Classe.Location = new Point(122, 138);
            txt_Classe.Margin = new Padding(4, 5, 4, 5);
            txt_Classe.Name = "txt_Classe";
            txt_Classe.Size = new Size(625, 27);
            txt_Classe.TabIndex = 31;
            // 
            // txt_codigo
            // 
            txt_codigo.Enabled = false;
            txt_codigo.Location = new Point(23, 138);
            txt_codigo.Margin = new Padding(4, 5, 4, 5);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(91, 27);
            txt_codigo.TabIndex = 30;
            // 
            // lbl_classe
            // 
            lbl_classe.AutoSize = true;
            lbl_classe.ForeColor = Color.Gray;
            lbl_classe.Location = new Point(119, 114);
            lbl_classe.Margin = new Padding(4, 0, 4, 0);
            lbl_classe.Name = "lbl_classe";
            lbl_classe.Size = new Size(50, 20);
            lbl_classe.TabIndex = 29;
            lbl_classe.Text = "Classe";
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.ForeColor = Color.Gray;
            lbl_codigo.Location = new Point(23, 114);
            lbl_codigo.Margin = new Padding(4, 0, 4, 0);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(58, 20);
            lbl_codigo.TabIndex = 28;
            lbl_codigo.Text = "Codigo";
            // 
            // chx_editar
            // 
            chx_editar.AutoSize = true;
            chx_editar.Location = new Point(76, 46);
            chx_editar.Margin = new Padding(4, 5, 4, 5);
            chx_editar.Name = "chx_editar";
            chx_editar.Size = new Size(80, 24);
            chx_editar.TabIndex = 38;
            chx_editar.Text = "EDITAR";
            chx_editar.UseVisualStyleBackColor = true;
            chx_editar.Visible = false;
            // 
            // lbl_ativo
            // 
            lbl_ativo.AutoSize = true;
            lbl_ativo.ForeColor = Color.Gray;
            lbl_ativo.Location = new Point(862, 113);
            lbl_ativo.Margin = new Padding(4, 0, 4, 0);
            lbl_ativo.Name = "lbl_ativo";
            lbl_ativo.Size = new Size(44, 20);
            lbl_ativo.TabIndex = 39;
            lbl_ativo.Text = "Ativo";
            // 
            // cbx_ativo
            // 
            cbx_ativo.FormattingEnabled = true;
            cbx_ativo.Items.AddRange(new object[] { "SIM", "NAO" });
            cbx_ativo.Location = new Point(866, 137);
            cbx_ativo.Margin = new Padding(4, 5, 4, 5);
            cbx_ativo.Name = "cbx_ativo";
            cbx_ativo.Size = new Size(96, 28);
            cbx_ativo.TabIndex = 40;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { tsm_novo, tsm_editar, tsm_salvar, tsm_cancelar, tsm_anterior, tsm_proximo, tsm_pesquisar, tsm_excluir, txt_usuario, Usuario });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(8, 3, 0, 3);
            menuStrip2.Size = new Size(983, 33);
            menuStrip2.TabIndex = 42;
            menuStrip2.Text = "menuStrip2";
            // 
            // tsm_novo
            // 
            tsm_novo.Name = "tsm_novo";
            tsm_novo.Size = new Size(59, 27);
            tsm_novo.Text = "Novo";
            tsm_novo.Click += Tsm_novo_Click;
            // 
            // tsm_editar
            // 
            tsm_editar.Name = "tsm_editar";
            tsm_editar.Size = new Size(62, 27);
            tsm_editar.Text = "Editar";
            tsm_editar.Click += Tsm_editar_Click;
            // 
            // tsm_salvar
            // 
            tsm_salvar.Name = "tsm_salvar";
            tsm_salvar.Size = new Size(63, 27);
            tsm_salvar.Text = "Salvar";
            tsm_salvar.Click += Tsm_salvar_Click;
            // 
            // tsm_cancelar
            // 
            tsm_cancelar.Name = "tsm_cancelar";
            tsm_cancelar.Size = new Size(80, 27);
            tsm_cancelar.Text = "Cancelar";
            tsm_cancelar.Click += Tsm_cancelar_Click;
            // 
            // tsm_anterior
            // 
            tsm_anterior.Name = "tsm_anterior";
            tsm_anterior.Size = new Size(77, 27);
            tsm_anterior.Text = "Anterior";
            tsm_anterior.Click += Tsm_anterior_Click;
            // 
            // tsm_proximo
            // 
            tsm_proximo.Name = "tsm_proximo";
            tsm_proximo.Size = new Size(78, 27);
            tsm_proximo.Text = "Proximo";
            tsm_proximo.Click += Tsm_proximo_Click;
            // 
            // tsm_pesquisar
            // 
            tsm_pesquisar.Name = "tsm_pesquisar";
            tsm_pesquisar.Size = new Size(79, 27);
            tsm_pesquisar.Text = "Pesquisa";
            tsm_pesquisar.Click += Tsm_pesquisar_Click;
            // 
            // tsm_excluir
            // 
            tsm_excluir.Name = "tsm_excluir";
            tsm_excluir.Size = new Size(66, 27);
            tsm_excluir.Text = "Excluir";
            tsm_excluir.Click += Tsm_excluir_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Alignment = ToolStripItemAlignment.Right;
            txt_usuario.Enabled = false;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(132, 27);
            // 
            // Usuario
            // 
            Usuario.Alignment = ToolStripItemAlignment.Right;
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(73, 27);
            Usuario.Text = "Usuario";
            // 
            // lbl_VlPermissao
            // 
            lbl_VlPermissao.AutoSize = true;
            lbl_VlPermissao.Location = new Point(851, 42);
            lbl_VlPermissao.Margin = new Padding(4, 0, 4, 0);
            lbl_VlPermissao.Name = "lbl_VlPermissao";
            lbl_VlPermissao.Size = new Size(111, 20);
            lbl_VlPermissao.TabIndex = 146;
            lbl_VlPermissao.Text = "lbl_VlPermissao";
            lbl_VlPermissao.Visible = false;
            // 
            // cbx_Patrimonio
            // 
            cbx_Patrimonio.FormattingEnabled = true;
            cbx_Patrimonio.Items.AddRange(new object[] { "SIM", "NAO" });
            cbx_Patrimonio.Location = new Point(761, 137);
            cbx_Patrimonio.Margin = new Padding(4, 5, 4, 5);
            cbx_Patrimonio.Name = "cbx_Patrimonio";
            cbx_Patrimonio.Size = new Size(96, 28);
            cbx_Patrimonio.TabIndex = 148;
            // 
            // lbl_patrimonio
            // 
            lbl_patrimonio.AutoSize = true;
            lbl_patrimonio.ForeColor = Color.Gray;
            lbl_patrimonio.Location = new Point(757, 113);
            lbl_patrimonio.Margin = new Padding(4, 0, 4, 0);
            lbl_patrimonio.Name = "lbl_patrimonio";
            lbl_patrimonio.Size = new Size(81, 20);
            lbl_patrimonio.TabIndex = 147;
            lbl_patrimonio.Text = "Patrimônio";
            // 
            // frm_ProdutoClasse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(983, 225);
            Controls.Add(cbx_Patrimonio);
            Controls.Add(lbl_patrimonio);
            Controls.Add(lbl_VlPermissao);
            Controls.Add(cbx_ativo);
            Controls.Add(lbl_ativo);
            Controls.Add(chx_editar);
            Controls.Add(txt_Classe);
            Controls.Add(txt_codigo);
            Controls.Add(lbl_classe);
            Controls.Add(lbl_codigo);
            Controls.Add(menuStrip2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1001, 272);
            MinimumSize = new Size(1001, 272);
            Name = "frm_ProdutoClasse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Classes";
            Load += Frm_ProdutoClasse_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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