
namespace CG.TelaInicial.Cadastro.Estoque.Produto_por_Posto
{
    partial class frm_ProdutoPostoClasse
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
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_Classes = new System.Windows.Forms.ComboBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dgv_EstoClassePosto = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EstoClassePosto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(9, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Classes";
            // 
            // cbx_Classes
            // 
            this.cbx_Classes.FormattingEnabled = true;
            this.cbx_Classes.Location = new System.Drawing.Point(12, 49);
            this.cbx_Classes.Name = "cbx_Classes";
            this.cbx_Classes.Size = new System.Drawing.Size(290, 21);
            this.cbx_Classes.TabIndex = 62;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Inserir.FlatAppearance.BorderSize = 0;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Inserir.Location = new System.Drawing.Point(12, 86);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(141, 33);
            this.btn_Inserir.TabIndex = 60;
            this.btn_Inserir.Text = "Inserir Item";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Excluir.Location = new System.Drawing.Point(158, 86);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(144, 33);
            this.btn_Excluir.TabIndex = 61;
            this.btn_Excluir.Text = "Excluir Item";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // dgv_EstoClassePosto
            // 
            this.dgv_EstoClassePosto.AllowUserToAddRows = false;
            this.dgv_EstoClassePosto.AllowUserToDeleteRows = false;
            this.dgv_EstoClassePosto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EstoClassePosto.Location = new System.Drawing.Point(12, 125);
            this.dgv_EstoClassePosto.Name = "dgv_EstoClassePosto";
            this.dgv_EstoClassePosto.RowHeadersVisible = false;
            this.dgv_EstoClassePosto.Size = new System.Drawing.Size(290, 289);
            this.dgv_EstoClassePosto.TabIndex = 59;
            this.dgv_EstoClassePosto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_EstoClassePosto_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 27);
            this.menuStrip1.TabIndex = 64;
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
            this.Usuario.Size = new System.Drawing.Size(62, 23);
            this.Usuario.Text = "Usuário:";
            // 
            // frm_ProdutoPostoClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(314, 426);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbx_Classes);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.dgv_EstoClassePosto);
            this.Name = "frm_ProdutoPostoClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ProdutoPostoClasse";
            this.Load += new System.EventHandler(this.frm_ProdutoPostoClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EstoClassePosto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_Classes;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView dgv_EstoClassePosto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
    }
}