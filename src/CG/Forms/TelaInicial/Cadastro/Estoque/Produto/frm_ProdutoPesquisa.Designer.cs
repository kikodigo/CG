namespace CG
{
    partial class Frm_ProdutoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProdutoPesquisa));
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.cbx_coluna = new System.Windows.Forms.ComboBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.dgv_ProdutoPesquisa = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueatual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueminimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prcusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutoPesquisa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(157, 49);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(629, 20);
            this.txt_referencia.TabIndex = 6;
            this.txt_referencia.TextChanged += new System.EventHandler(this.Txt_referencia_TextChanged);
            // 
            // cbx_coluna
            // 
            this.cbx_coluna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_coluna.FormattingEnabled = true;
            this.cbx_coluna.Items.AddRange(new object[] {
            "DESCRIÇÃO",
            "CODIGO"});
            this.cbx_coluna.Location = new System.Drawing.Point(12, 49);
            this.cbx_coluna.Name = "cbx_coluna";
            this.cbx_coluna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_coluna.Size = new System.Drawing.Size(139, 21);
            this.cbx_coluna.TabIndex = 2;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Limpar.Location = new System.Drawing.Point(793, 49);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(83, 22);
            this.btn_Limpar.TabIndex = 0;
            this.btn_Limpar.Text = "Limpar ";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.Button1_Click_2);
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
            this.descricao,
            this.classe,
            this.unidade,
            this.estoqueatual,
            this.estoqueminimo,
            this.prcusto,
            this.ca,
            this.ativo});
            this.dgv_ProdutoPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ProdutoPesquisa.Location = new System.Drawing.Point(12, 82);
            this.dgv_ProdutoPesquisa.Name = "dgv_ProdutoPesquisa";
            this.dgv_ProdutoPesquisa.ReadOnly = true;
            this.dgv_ProdutoPesquisa.RowHeadersVisible = false;
            this.dgv_ProdutoPesquisa.Size = new System.Drawing.Size(864, 587);
            this.dgv_ProdutoPesquisa.TabIndex = 3;
            this.dgv_ProdutoPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ProdutoPesquisa_CellDoubleClick);
            // 
            // cod
            // 
            this.cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod.DataPropertyName = "cod";
            this.cod.FillWeight = 50F;
            this.cod.Frozen = true;
            this.cod.HeaderText = "Codigo";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 65;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.Frozen = true;
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 260;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 260;
            // 
            // classe
            // 
            this.classe.DataPropertyName = "classe";
            this.classe.Frozen = true;
            this.classe.HeaderText = "Classe";
            this.classe.MinimumWidth = 70;
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            this.classe.Width = 70;
            // 
            // unidade
            // 
            this.unidade.DataPropertyName = "unidade";
            this.unidade.Frozen = true;
            this.unidade.HeaderText = "Unidade";
            this.unidade.MinimumWidth = 70;
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            this.unidade.Width = 70;
            // 
            // estoqueatual
            // 
            this.estoqueatual.DataPropertyName = "estoqueatual";
            this.estoqueatual.Frozen = true;
            this.estoqueatual.HeaderText = "Est. Atual";
            this.estoqueatual.MinimumWidth = 95;
            this.estoqueatual.Name = "estoqueatual";
            this.estoqueatual.ReadOnly = true;
            this.estoqueatual.Width = 95;
            // 
            // estoqueminimo
            // 
            this.estoqueminimo.DataPropertyName = "estoqueminimo";
            this.estoqueminimo.Frozen = true;
            this.estoqueminimo.HeaderText = "Est. Minimo";
            this.estoqueminimo.MinimumWidth = 95;
            this.estoqueminimo.Name = "estoqueminimo";
            this.estoqueminimo.ReadOnly = true;
            this.estoqueminimo.Width = 95;
            // 
            // prcusto
            // 
            this.prcusto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prcusto.DataPropertyName = "prcusto";
            this.prcusto.Frozen = true;
            this.prcusto.HeaderText = "Pr.Custo";
            this.prcusto.Name = "prcusto";
            this.prcusto.ReadOnly = true;
            this.prcusto.Width = 72;
            // 
            // ca
            // 
            this.ca.DataPropertyName = "ca";
            this.ca.Frozen = true;
            this.ca.HeaderText = "C.A.";
            this.ca.Name = "ca";
            this.ca.ReadOnly = true;
            this.ca.Width = 70;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.Frozen = true;
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coluna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(154, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Referencia";
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(686, 49);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(100, 20);
            this.txt_destino.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 23);
            this.toolStripMenuItem1.Text = "Usuario";
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(790, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 146;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // Frm_ProdutoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(887, 681);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ProdutoPesquisa);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.cbx_coluna);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(903, 720);
            this.MinimumSize = new System.Drawing.Size(903, 720);
            this.Name = "Frm_ProdutoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.Frm_ProdutoPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutoPesquisa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.ComboBox cbx_coluna;
        private System.Windows.Forms.Button btn_Limpar;
    
        private System.Windows.Forms.DataGridView dgv_ProdutoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueatual;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueminimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prcusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lbl_VlPermissao;
    }
}