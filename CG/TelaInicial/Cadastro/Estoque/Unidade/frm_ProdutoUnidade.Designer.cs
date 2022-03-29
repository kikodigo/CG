namespace CG
{
    partial class frm_ProdutoUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProdutoUnidade));
            this.txt_unidade = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chx_editar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_ativo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_unidade
            // 
            this.txt_unidade.Enabled = false;
            this.txt_unidade.Location = new System.Drawing.Point(97, 79);
            this.txt_unidade.Multiline = true;
            this.txt_unidade.Name = "txt_unidade";
            this.txt_unidade.Size = new System.Drawing.Size(553, 21);
            this.txt_unidade.TabIndex = 43;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(15, 79);
            this.txt_codigo.Multiline = true;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(81, 21);
            this.txt_codigo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(94, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Unidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo";
            // 
            // chx_editar
            // 
            this.chx_editar.AutoSize = true;
            this.chx_editar.Enabled = false;
            this.chx_editar.Location = new System.Drawing.Point(672, 43);
            this.chx_editar.Name = "chx_editar";
            this.chx_editar.Size = new System.Drawing.Size(52, 17);
            this.chx_editar.TabIndex = 52;
            this.chx_editar.Text = "editar";
            this.chx_editar.UseVisualStyleBackColor = true;
            this.chx_editar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(649, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ativo";
            // 
            // cbx_ativo
            // 
            this.cbx_ativo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbx_ativo.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cbx_ativo.Location = new System.Drawing.Point(651, 79);
            this.cbx_ativo.Name = "cbx_ativo";
            this.cbx_ativo.Size = new System.Drawing.Size(73, 21);
            this.cbx_ativo.TabIndex = 54;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_novo,
            this.tsm_editar,
            this.tsm_salvar,
            this.tsm_cancelar,
            this.tsm_anterior,
            this.tsm_proximo,
            this.tsm_pesquisa,
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 27);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
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
            // tsm_pesquisa
            // 
            this.tsm_pesquisa.Name = "tsm_pesquisa";
            this.tsm_pesquisa.Size = new System.Drawing.Size(65, 23);
            this.tsm_pesquisa.Text = "Pesquisa";
            this.tsm_pesquisa.Click += new System.EventHandler(this.Tsm_pesquisa_Click);
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
            this.lbl_VlPermissao.Location = new System.Drawing.Point(649, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 147;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // frm_ProdutoUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(739, 137);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.cbx_ativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chx_editar);
            this.Controls.Add(this.txt_unidade);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(755, 176);
            this.MinimumSize = new System.Drawing.Size(755, 176);
            this.Name = "frm_ProdutoUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Unidade";
            this.Load += new System.EventHandler(this.Frm_ProdutoUnidade_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_unidade;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chx_editar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_ativo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_novo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisa;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
    }
}