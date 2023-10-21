namespace CG
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
            txt_referencia = new TextBox();
            dgv_FornecedorPesquisa = new DataGridView();
            COD = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Tel1 = new DataGridViewTextBoxColumn();
            Tel2 = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            txt_destino = new TextBox();
            btn_Limpar = new Button();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            txt_usuario = new ToolStripTextBox();
            Usuario = new ToolStripMenuItem();
            lbl_VlPermissao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_FornecedorPesquisa).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbx_coluna
            // 
            cbx_coluna.FormattingEnabled = true;
            cbx_coluna.Items.AddRange(new object[] { "Codigo", "Nome", "CNPJ / CPF", "E-Mail" });
            cbx_coluna.Location = new Point(17, 86);
            cbx_coluna.Margin = new Padding(4, 5, 4, 5);
            cbx_coluna.Name = "cbx_coluna";
            cbx_coluna.Size = new Size(156, 28);
            cbx_coluna.TabIndex = 0;
            // 
            // txt_referencia
            // 
            txt_referencia.BorderStyle = BorderStyle.FixedSingle;
            txt_referencia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_referencia.Location = new Point(176, 86);
            txt_referencia.Margin = new Padding(4, 5, 4, 5);
            txt_referencia.MinimumSize = new Size(866, 21);
            txt_referencia.Name = "txt_referencia";
            txt_referencia.Size = new Size(866, 24);
            txt_referencia.TabIndex = 1;
            txt_referencia.TextChanged += Txt_referencia_TextChanged;
            // 
            // dgv_FornecedorPesquisa
            // 
            dgv_FornecedorPesquisa.AllowUserToAddRows = false;
            dgv_FornecedorPesquisa.AllowUserToDeleteRows = false;
            dgv_FornecedorPesquisa.AllowUserToResizeColumns = false;
            dgv_FornecedorPesquisa.AllowUserToResizeRows = false;
            dgv_FornecedorPesquisa.BackgroundColor = Color.DimGray;
            dgv_FornecedorPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_FornecedorPesquisa.Columns.AddRange(new DataGridViewColumn[] { COD, Nome, Tel1, Tel2, cnpj, email });
            dgv_FornecedorPesquisa.Location = new Point(17, 143);
            dgv_FornecedorPesquisa.Margin = new Padding(4, 5, 4, 5);
            dgv_FornecedorPesquisa.Name = "dgv_FornecedorPesquisa";
            dgv_FornecedorPesquisa.ReadOnly = true;
            dgv_FornecedorPesquisa.RowHeadersVisible = false;
            dgv_FornecedorPesquisa.RowHeadersWidth = 51;
            dgv_FornecedorPesquisa.Size = new Size(1151, 878);
            dgv_FornecedorPesquisa.TabIndex = 2;
            dgv_FornecedorPesquisa.CellContentClick += Dgv_FornecedorPesquisa_CellContentClick;
            dgv_FornecedorPesquisa.CellDoubleClick += Dgv_FornecedorPesquisa_CellDoubleClick;
            // 
            // COD
            // 
            COD.DataPropertyName = "cod";
            COD.HeaderText = "Codigo";
            COD.MinimumWidth = 6;
            COD.Name = "COD";
            COD.ReadOnly = true;
            COD.Width = 80;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 180;
            // 
            // Tel1
            // 
            Tel1.DataPropertyName = "tel1";
            Tel1.HeaderText = "Telefone 1";
            Tel1.MinimumWidth = 6;
            Tel1.Name = "Tel1";
            Tel1.ReadOnly = true;
            Tel1.Width = 105;
            // 
            // Tel2
            // 
            Tel2.DataPropertyName = "tel1";
            Tel2.HeaderText = "Telefone 2";
            Tel2.MinimumWidth = 6;
            Tel2.Name = "Tel2";
            Tel2.ReadOnly = true;
            Tel2.Width = 105;
            // 
            // cnpj
            // 
            cnpj.DataPropertyName = "doc";
            cnpj.HeaderText = "CNPJ / CPF";
            cnpj.MinimumWidth = 6;
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            cnpj.Width = 175;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "E-Mail";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 195;
            // 
            // txt_destino
            // 
            txt_destino.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_destino.Location = new Point(909, 86);
            txt_destino.Margin = new Padding(4, 5, 4, 5);
            txt_destino.Name = "txt_destino";
            txt_destino.Size = new Size(132, 24);
            txt_destino.TabIndex = 3;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.FromArgb(64, 67, 73);
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.ForeColor = SystemColors.ControlLight;
            btn_Limpar.Location = new Point(1045, 86);
            btn_Limpar.Margin = new Padding(4, 5, 4, 5);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(123, 32);
            btn_Limpar.TabIndex = 6;
            btn_Limpar.Text = "Limpar ";
            btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(172, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "Referencia";
            label2.Click += Label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(13, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Coluna";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { txt_usuario, Usuario });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1180, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            lbl_VlPermissao.Location = new Point(1041, 42);
            lbl_VlPermissao.Margin = new Padding(4, 0, 4, 0);
            lbl_VlPermissao.Name = "lbl_VlPermissao";
            lbl_VlPermissao.Size = new Size(111, 20);
            lbl_VlPermissao.TabIndex = 147;
            lbl_VlPermissao.Text = "lbl_VlPermissao";
            lbl_VlPermissao.Visible = false;
            // 
            // frm_FornecedorPesquisa
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1180, 1035);
            Controls.Add(lbl_VlPermissao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Limpar);
            Controls.Add(txt_destino);
            Controls.Add(dgv_FornecedorPesquisa);
            Controls.Add(txt_referencia);
            Controls.Add(cbx_coluna);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1198, 1082);
            MinimumSize = new Size(1198, 1018);
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
        private TextBox txt_referencia;
        private DataGridView dgv_FornecedorPesquisa;
        private TextBox txt_destino;
        private Button btn_Limpar;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn COD;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tel1;
        private DataGridViewTextBoxColumn Tel2;
        private DataGridViewTextBoxColumn cnpj;
        private DataGridViewTextBoxColumn email;
        private MenuStrip menuStrip1;
        private ToolStripTextBox txt_usuario;
        private ToolStripMenuItem Usuario;
        private Label lbl_VlPermissao;
    }
}