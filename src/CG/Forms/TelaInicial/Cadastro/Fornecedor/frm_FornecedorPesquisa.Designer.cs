﻿namespace CG
{
    partial class frm_FornecedorPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FornecedorPesquisa));
            cbx_coluna = new ComboBox();
            dgv_FornecedorPesquisa = new DataGridView();
            btn_Limpar = new Button();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            txt_Usuario = new ToolStripTextBox();
            Usuario = new ToolStripMenuItem();
            lbl_VlPermissao = new Label();
            txt_Referencia = new TextBox();
            btn_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_FornecedorPesquisa).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbx_coluna
            // 
            cbx_coluna.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_coluna.FormattingEnabled = true;
            cbx_coluna.Items.AddRange(new object[] { "Codigo", "Razão", "Fantasia", "CNPJ / CPF", "E-Mail" });
            cbx_coluna.Location = new Point(15, 62);
            cbx_coluna.Margin = new Padding(4);
            cbx_coluna.Name = "cbx_coluna";
            cbx_coluna.Size = new Size(137, 23);
            cbx_coluna.TabIndex = 0;
            // 
            // dgv_FornecedorPesquisa
            // 
            dgv_FornecedorPesquisa.AccessibleRole = AccessibleRole.None;
            dgv_FornecedorPesquisa.AllowUserToDeleteRows = false;
            dgv_FornecedorPesquisa.AllowUserToResizeColumns = false;
            dgv_FornecedorPesquisa.AllowUserToResizeRows = false;
            dgv_FornecedorPesquisa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dgv_FornecedorPesquisa.BackgroundColor = Color.DimGray;
            dgv_FornecedorPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_FornecedorPesquisa.Location = new Point(15, 107);
            dgv_FornecedorPesquisa.Margin = new Padding(4);
            dgv_FornecedorPesquisa.Name = "dgv_FornecedorPesquisa";
            dgv_FornecedorPesquisa.ReadOnly = true;
            dgv_FornecedorPesquisa.RowHeadersVisible = false;
            dgv_FornecedorPesquisa.RowHeadersWidth = 51;
            dgv_FornecedorPesquisa.Size = new Size(1007, 622);
            dgv_FornecedorPesquisa.TabIndex = 2;
            dgv_FornecedorPesquisa.CellDoubleClick += Dgv_FornecedorPesquisa_CellDoubleClick;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.FromArgb(64, 67, 73);
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.ForeColor = SystemColors.ControlLight;
            btn_Limpar.Location = new Point(919, 62);
            btn_Limpar.Margin = new Padding(4);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(108, 24);
            btn_Limpar.TabIndex = 6;
            btn_Limpar.Text = "Limpar ";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(150, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Referencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(11, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Coluna";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { txt_Usuario, Usuario });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1034, 27);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Alignment = ToolStripItemAlignment.Right;
            txt_Usuario.Enabled = false;
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(116, 23);
            // 
            // Usuario
            // 
            Usuario.Alignment = ToolStripItemAlignment.Right;
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(59, 23);
            Usuario.Text = "Usuario";
            // 
            // lbl_VlPermissao
            // 
            lbl_VlPermissao.AutoSize = true;
            lbl_VlPermissao.Location = new Point(911, 32);
            lbl_VlPermissao.Margin = new Padding(4, 0, 4, 0);
            lbl_VlPermissao.Name = "lbl_VlPermissao";
            lbl_VlPermissao.Size = new Size(89, 15);
            lbl_VlPermissao.TabIndex = 147;
            lbl_VlPermissao.Text = "lbl_VlPermissao";
            lbl_VlPermissao.Visible = false;
            // 
            // txt_Referencia
            // 
            txt_Referencia.Location = new Point(158, 62);
            txt_Referencia.Margin = new Padding(3, 2, 3, 2);
            txt_Referencia.Name = "txt_Referencia";
            txt_Referencia.Size = new Size(641, 23);
            txt_Referencia.TabIndex = 148;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.FromArgb(64, 67, 73);
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.ForeColor = SystemColors.ControlLight;
            btn_Buscar.Location = new Point(804, 62);
            btn_Buscar.Margin = new Padding(4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(108, 24);
            btn_Buscar.TabIndex = 149;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // frm_FornecedorPesquisa
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1034, 747);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_Referencia);
            Controls.Add(lbl_VlPermissao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Limpar);
            Controls.Add(dgv_FornecedorPesquisa);
            Controls.Add(cbx_coluna);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximumSize = new Size(1050, 805);
            MinimumSize = new Size(1050, 760);
            Name = "frm_FornecedorPesquisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisa de Fornecedor";
            Load += Frm_FornecedorPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_FornecedorPesquisa).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_coluna;
        private DataGridView dgv_FornecedorPesquisa;
        private Button btn_Limpar;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripTextBox txt_Usuario;
        private ToolStripMenuItem Usuario;
        private Label lbl_VlPermissao;
        private TextBox txt_Referencia;
        private Button btn_Buscar;
    }
}