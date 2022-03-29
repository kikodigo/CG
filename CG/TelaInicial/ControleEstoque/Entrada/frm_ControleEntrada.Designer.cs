namespace CG.Tela_Inicial.Controle_Estoque.Saida
{
    partial class frm_ControleEntrada
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
            this.tsm_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.txt_Nnota = new System.Windows.Forms.TextBox();
            this.txt_VlTotalNota = new System.Windows.Forms.TextBox();
            this.txt_DataEmissao = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgv_TabelaItens = new System.Windows.Forms.DataGridView();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NNota = new System.Windows.Forms.Label();
            this.lbl_DataEmissao = new System.Windows.Forms.Label();
            this.lbl_VlTotalCompra = new System.Windows.Forms.Label();
            this.lbl_Cnpj = new System.Windows.Forms.Label();
            this.lbl_Fornecedor = new System.Windows.Forms.Label();
            this.txt_Fornecedor = new System.Windows.Forms.TextBox();
            this.lbl_CodEntrada = new System.Windows.Forms.Label();
            this.txt_CodEntrada = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.cbx_Descricao = new System.Windows.Forms.ComboBox();
            this.txt_Qtd = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_Qtd = new System.Windows.Forms.Label();
            this.lbl_PrUnitario = new System.Windows.Forms.Label();
            this.txt_PrUnit = new System.Windows.Forms.TextBox();
            this.lbl_PrTotal = new System.Windows.Forms.Label();
            this.txt_PrTotal = new System.Windows.Forms.TextBox();
            this.lbl_DataEntrada = new System.Windows.Forms.Label();
            this.txt_DataEntrada = new System.Windows.Forms.TextBox();
            this.cbx_Fornecedor = new System.Windows.Forms.ComboBox();
            this.chx_editar = new System.Windows.Forms.CheckBox();
            this.lbl_CodTabela = new System.Windows.Forms.Label();
            this.chx_Liberar = new System.Windows.Forms.CheckBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_codfor = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaItens)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripMenuItem6});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(974, 27);
            this.menuStrip2.TabIndex = 89;
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
            this.tsm_editar.Click += new System.EventHandler(this.tsm_editar_Click);
            // 
            // tsm_salvar
            // 
            this.tsm_salvar.Name = "tsm_salvar";
            this.tsm_salvar.Size = new System.Drawing.Size(50, 23);
            this.tsm_salvar.Text = "Salvar";
            this.tsm_salvar.Click += new System.EventHandler(this.tsm_salvar_Click);
            // 
            // tsm_cancelar
            // 
            this.tsm_cancelar.Name = "tsm_cancelar";
            this.tsm_cancelar.Size = new System.Drawing.Size(65, 23);
            this.tsm_cancelar.Text = "Cancelar";
            this.tsm_cancelar.Click += new System.EventHandler(this.tsm_cancelar_Click);
            // 
            // tsm_anterior
            // 
            this.tsm_anterior.Name = "tsm_anterior";
            this.tsm_anterior.Size = new System.Drawing.Size(62, 23);
            this.tsm_anterior.Text = "Anterior";
            this.tsm_anterior.Click += new System.EventHandler(this.tsm_anterior_Click);
            // 
            // tsm_proximo
            // 
            this.tsm_proximo.Name = "tsm_proximo";
            this.tsm_proximo.Size = new System.Drawing.Size(64, 23);
            this.tsm_proximo.Text = "Proximo";
            this.tsm_proximo.Click += new System.EventHandler(this.tsm_proximo_Click);
            // 
            // tsm_pesquisar
            // 
            this.tsm_pesquisar.Name = "tsm_pesquisar";
            this.tsm_pesquisar.Size = new System.Drawing.Size(65, 23);
            this.tsm_pesquisar.Text = "Pesquisa";
            // 
            // tsm_excluir
            // 
            this.tsm_excluir.Name = "tsm_excluir";
            this.tsm_excluir.Size = new System.Drawing.Size(54, 23);
            this.tsm_excluir.Text = "Excluir";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(59, 23);
            this.toolStripMenuItem6.Text = "Usuario";
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(584, 30);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 147;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // txt_Nnota
            // 
            this.txt_Nnota.Enabled = false;
            this.txt_Nnota.Location = new System.Drawing.Point(880, 63);
            this.txt_Nnota.Name = "txt_Nnota";
            this.txt_Nnota.Size = new System.Drawing.Size(82, 20);
            this.txt_Nnota.TabIndex = 149;
            // 
            // txt_VlTotalNota
            // 
            this.txt_VlTotalNota.Enabled = false;
            this.txt_VlTotalNota.Location = new System.Drawing.Point(808, 650);
            this.txt_VlTotalNota.Name = "txt_VlTotalNota";
            this.txt_VlTotalNota.Size = new System.Drawing.Size(154, 20);
            this.txt_VlTotalNota.TabIndex = 156;
            // 
            // txt_DataEmissao
            // 
            this.txt_DataEmissao.Enabled = false;
            this.txt_DataEmissao.Location = new System.Drawing.Point(203, 62);
            this.txt_DataEmissao.Name = "txt_DataEmissao";
            this.txt_DataEmissao.Size = new System.Drawing.Size(99, 20);
            this.txt_DataEmissao.TabIndex = 160;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgv_TabelaItens
            // 
            this.dgv_TabelaItens.AllowUserToAddRows = false;
            this.dgv_TabelaItens.AllowUserToDeleteRows = false;
            this.dgv_TabelaItens.AllowUserToResizeRows = false;
            this.dgv_TabelaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_TabelaItens.Location = new System.Drawing.Point(12, 136);
            this.dgv_TabelaItens.Name = "dgv_TabelaItens";
            this.dgv_TabelaItens.RowHeadersVisible = false;
            this.dgv_TabelaItens.Size = new System.Drawing.Size(950, 508);
            this.dgv_TabelaItens.TabIndex = 166;
            this.dgv_TabelaItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_TabelaItens_CellContentClick);
            this.dgv_TabelaItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TabelaItens_CellDoubleClick);
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Enabled = false;
            this.mtb_cnpj.Location = new System.Drawing.Point(757, 63);
            this.mtb_cnpj.Mask = "00,000,000/0000-00";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(117, 20);
            this.mtb_cnpj.TabIndex = 170;
            // 
            // lbl_NNota
            // 
            this.lbl_NNota.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_NNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NNota.AutoSize = true;
            this.lbl_NNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NNota.ForeColor = System.Drawing.Color.Gray;
            this.lbl_NNota.Location = new System.Drawing.Point(877, 42);
            this.lbl_NNota.Name = "lbl_NNota";
            this.lbl_NNota.Size = new System.Drawing.Size(80, 18);
            this.lbl_NNota.TabIndex = 171;
            this.lbl_NNota.Text = "Nº da Nota";
            // 
            // lbl_DataEmissao
            // 
            this.lbl_DataEmissao.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_DataEmissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataEmissao.AutoSize = true;
            this.lbl_DataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataEmissao.ForeColor = System.Drawing.Color.Gray;
            this.lbl_DataEmissao.Location = new System.Drawing.Point(200, 42);
            this.lbl_DataEmissao.Name = "lbl_DataEmissao";
            this.lbl_DataEmissao.Size = new System.Drawing.Size(102, 18);
            this.lbl_DataEmissao.TabIndex = 172;
            this.lbl_DataEmissao.Text = "Data Emissão";
            // 
            // lbl_VlTotalCompra
            // 
            this.lbl_VlTotalCompra.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_VlTotalCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_VlTotalCompra.AutoSize = true;
            this.lbl_VlTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VlTotalCompra.ForeColor = System.Drawing.Color.Gray;
            this.lbl_VlTotalCompra.Location = new System.Drawing.Point(645, 650);
            this.lbl_VlTotalCompra.Name = "lbl_VlTotalCompra";
            this.lbl_VlTotalCompra.Size = new System.Drawing.Size(157, 18);
            this.lbl_VlTotalCompra.TabIndex = 174;
            this.lbl_VlTotalCompra.Text = "Valor Total da Compra";
            // 
            // lbl_Cnpj
            // 
            this.lbl_Cnpj.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_Cnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Cnpj.AutoSize = true;
            this.lbl_Cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cnpj.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Cnpj.Location = new System.Drawing.Point(754, 42);
            this.lbl_Cnpj.Name = "lbl_Cnpj";
            this.lbl_Cnpj.Size = new System.Drawing.Size(48, 18);
            this.lbl_Cnpj.TabIndex = 175;
            this.lbl_Cnpj.Text = "CNPJ";
            this.lbl_Cnpj.Click += new System.EventHandler(this.lbl_Cnpj_Click);
            // 
            // lbl_Fornecedor
            // 
            this.lbl_Fornecedor.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_Fornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Fornecedor.AutoSize = true;
            this.lbl_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fornecedor.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Fornecedor.Location = new System.Drawing.Point(305, 41);
            this.lbl_Fornecedor.Name = "lbl_Fornecedor";
            this.lbl_Fornecedor.Size = new System.Drawing.Size(85, 18);
            this.lbl_Fornecedor.TabIndex = 178;
            this.lbl_Fornecedor.Text = "Fornecedor";
            // 
            // txt_Fornecedor
            // 
            this.txt_Fornecedor.Enabled = false;
            this.txt_Fornecedor.Location = new System.Drawing.Point(308, 62);
            this.txt_Fornecedor.Name = "txt_Fornecedor";
            this.txt_Fornecedor.Size = new System.Drawing.Size(443, 20);
            this.txt_Fornecedor.TabIndex = 177;
            // 
            // lbl_CodEntrada
            // 
            this.lbl_CodEntrada.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_CodEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CodEntrada.AutoSize = true;
            this.lbl_CodEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodEntrada.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CodEntrada.Location = new System.Drawing.Point(9, 41);
            this.lbl_CodEntrada.Name = "lbl_CodEntrada";
            this.lbl_CodEntrada.Size = new System.Drawing.Size(91, 18);
            this.lbl_CodEntrada.TabIndex = 180;
            this.lbl_CodEntrada.Text = "Cod Entrada";
            // 
            // txt_CodEntrada
            // 
            this.txt_CodEntrada.Enabled = false;
            this.txt_CodEntrada.Location = new System.Drawing.Point(12, 62);
            this.txt_CodEntrada.Name = "txt_CodEntrada";
            this.txt_CodEntrada.Size = new System.Drawing.Size(88, 20);
            this.txt_CodEntrada.TabIndex = 179;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Adicionar.Enabled = false;
            this.btn_Adicionar.FlatAppearance.BorderSize = 0;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Adicionar.Location = new System.Drawing.Point(780, 100);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(88, 30);
            this.btn_Adicionar.TabIndex = 181;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Excluir.Location = new System.Drawing.Point(874, 100);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(88, 30);
            this.btn_Excluir.TabIndex = 182;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // cbx_Descricao
            // 
            this.cbx_Descricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Descricao.Enabled = false;
            this.cbx_Descricao.FormattingEnabled = true;
            this.cbx_Descricao.Location = new System.Drawing.Point(12, 109);
            this.cbx_Descricao.Name = "cbx_Descricao";
            this.cbx_Descricao.Size = new System.Drawing.Size(509, 21);
            this.cbx_Descricao.TabIndex = 183;
            this.cbx_Descricao.SelectedIndexChanged += new System.EventHandler(this.Cbx_Descricao_SelectedIndexChanged);
            // 
            // txt_Qtd
            // 
            this.txt_Qtd.Enabled = false;
            this.txt_Qtd.Location = new System.Drawing.Point(527, 110);
            this.txt_Qtd.Name = "txt_Qtd";
            this.txt_Qtd.Size = new System.Drawing.Size(80, 20);
            this.txt_Qtd.TabIndex = 184;
            this.txt_Qtd.TextChanged += new System.EventHandler(this.txt_Qtd_TextChanged);
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_Descricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Descricao.Location = new System.Drawing.Point(9, 88);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(76, 18);
            this.lbl_Descricao.TabIndex = 185;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // lbl_Qtd
            // 
            this.lbl_Qtd.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_Qtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Qtd.AutoSize = true;
            this.lbl_Qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qtd.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Qtd.Location = new System.Drawing.Point(524, 89);
            this.lbl_Qtd.Name = "lbl_Qtd";
            this.lbl_Qtd.Size = new System.Drawing.Size(83, 18);
            this.lbl_Qtd.TabIndex = 186;
            this.lbl_Qtd.Text = "Quantidade";
            // 
            // lbl_PrUnitario
            // 
            this.lbl_PrUnitario.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_PrUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PrUnitario.AutoSize = true;
            this.lbl_PrUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrUnitario.ForeColor = System.Drawing.Color.Gray;
            this.lbl_PrUnitario.Location = new System.Drawing.Point(610, 89);
            this.lbl_PrUnitario.Name = "lbl_PrUnitario";
            this.lbl_PrUnitario.Size = new System.Drawing.Size(82, 18);
            this.lbl_PrUnitario.TabIndex = 188;
            this.lbl_PrUnitario.Text = "Pr. Unitario";
            // 
            // txt_PrUnit
            // 
            this.txt_PrUnit.Enabled = false;
            this.txt_PrUnit.Location = new System.Drawing.Point(613, 110);
            this.txt_PrUnit.Name = "txt_PrUnit";
            this.txt_PrUnit.Size = new System.Drawing.Size(74, 20);
            this.txt_PrUnit.TabIndex = 187;
            this.txt_PrUnit.TextChanged += new System.EventHandler(this.Txt_PrUnit_TextChanged);
            this.txt_PrUnit.Leave += new System.EventHandler(this.txt_PrUnit_Leave);
            // 
            // lbl_PrTotal
            // 
            this.lbl_PrTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_PrTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PrTotal.AutoSize = true;
            this.lbl_PrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrTotal.ForeColor = System.Drawing.Color.Gray;
            this.lbl_PrTotal.Location = new System.Drawing.Point(690, 89);
            this.lbl_PrTotal.Name = "lbl_PrTotal";
            this.lbl_PrTotal.Size = new System.Drawing.Size(64, 18);
            this.lbl_PrTotal.TabIndex = 190;
            this.lbl_PrTotal.Text = "Pr. Total";
            // 
            // txt_PrTotal
            // 
            this.txt_PrTotal.Enabled = false;
            this.txt_PrTotal.Location = new System.Drawing.Point(693, 110);
            this.txt_PrTotal.Name = "txt_PrTotal";
            this.txt_PrTotal.Size = new System.Drawing.Size(81, 20);
            this.txt_PrTotal.TabIndex = 189;
            // 
            // lbl_DataEntrada
            // 
            this.lbl_DataEntrada.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_DataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataEntrada.AutoSize = true;
            this.lbl_DataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataEntrada.ForeColor = System.Drawing.Color.Gray;
            this.lbl_DataEntrada.Location = new System.Drawing.Point(103, 41);
            this.lbl_DataEntrada.Name = "lbl_DataEntrada";
            this.lbl_DataEntrada.Size = new System.Drawing.Size(94, 18);
            this.lbl_DataEntrada.TabIndex = 192;
            this.lbl_DataEntrada.Text = "Data Entrada";
            this.lbl_DataEntrada.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_DataEntrada
            // 
            this.txt_DataEntrada.Enabled = false;
            this.txt_DataEntrada.Location = new System.Drawing.Point(106, 62);
            this.txt_DataEntrada.Name = "txt_DataEntrada";
            this.txt_DataEntrada.Size = new System.Drawing.Size(91, 20);
            this.txt_DataEntrada.TabIndex = 191;
            // 
            // cbx_Fornecedor
            // 
            this.cbx_Fornecedor.FormattingEnabled = true;
            this.cbx_Fornecedor.Location = new System.Drawing.Point(308, 62);
            this.cbx_Fornecedor.Name = "cbx_Fornecedor";
            this.cbx_Fornecedor.Size = new System.Drawing.Size(443, 21);
            this.cbx_Fornecedor.TabIndex = 194;
            this.cbx_Fornecedor.SelectedIndexChanged += new System.EventHandler(this.cbx_Fornecedor_SelectedIndexChanged);
            // 
            // chx_editar
            // 
            this.chx_editar.AutoSize = true;
            this.chx_editar.Location = new System.Drawing.Point(681, 30);
            this.chx_editar.Name = "chx_editar";
            this.chx_editar.Size = new System.Drawing.Size(66, 17);
            this.chx_editar.TabIndex = 195;
            this.chx_editar.Text = "EDITAR";
            this.chx_editar.UseVisualStyleBackColor = true;
            this.chx_editar.Visible = false;
            // 
            // lbl_CodTabela
            // 
            this.lbl_CodTabela.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_CodTabela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CodTabela.AutoSize = true;
            this.lbl_CodTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodTabela.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CodTabela.Location = new System.Drawing.Point(91, 88);
            this.lbl_CodTabela.Name = "lbl_CodTabela";
            this.lbl_CodTabela.Size = new System.Drawing.Size(76, 18);
            this.lbl_CodTabela.TabIndex = 196;
            this.lbl_CodTabela.Text = "Descrição";
            // 
            // chx_Liberar
            // 
            this.chx_Liberar.AutoSize = true;
            this.chx_Liberar.Enabled = false;
            this.chx_Liberar.Location = new System.Drawing.Point(171, 653);
            this.chx_Liberar.Name = "chx_Liberar";
            this.chx_Liberar.Size = new System.Drawing.Size(58, 17);
            this.chx_Liberar.TabIndex = 197;
            this.chx_Liberar.Text = "Liberar";
            this.chx_Liberar.UseVisualStyleBackColor = true;
            // 
            // txt_Status
            // 
            this.txt_Status.Enabled = false;
            this.txt_Status.Location = new System.Drawing.Point(65, 650);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(100, 20);
            this.txt_Status.TabIndex = 198;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 199;
            this.label1.Text = "Status";
            // 
            // lbl_codfor
            // 
            this.lbl_codfor.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_codfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codfor.AutoSize = true;
            this.lbl_codfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codfor.ForeColor = System.Drawing.Color.Gray;
            this.lbl_codfor.Location = new System.Drawing.Point(415, 41);
            this.lbl_codfor.Name = "lbl_codfor";
            this.lbl_codfor.Size = new System.Drawing.Size(85, 18);
            this.lbl_codfor.TabIndex = 200;
            this.lbl_codfor.Text = "Fornecedor";
            // 
            // frm_ControleEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.lbl_codfor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.chx_Liberar);
            this.Controls.Add(this.lbl_CodTabela);
            this.Controls.Add(this.chx_editar);
            this.Controls.Add(this.cbx_Fornecedor);
            this.Controls.Add(this.lbl_DataEntrada);
            this.Controls.Add(this.txt_DataEntrada);
            this.Controls.Add(this.lbl_PrTotal);
            this.Controls.Add(this.txt_PrTotal);
            this.Controls.Add(this.lbl_PrUnitario);
            this.Controls.Add(this.txt_PrUnit);
            this.Controls.Add(this.lbl_Qtd);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.txt_Qtd);
            this.Controls.Add(this.cbx_Descricao);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.lbl_CodEntrada);
            this.Controls.Add(this.txt_CodEntrada);
            this.Controls.Add(this.lbl_Fornecedor);
            this.Controls.Add(this.txt_Fornecedor);
            this.Controls.Add(this.lbl_Cnpj);
            this.Controls.Add(this.lbl_VlTotalCompra);
            this.Controls.Add(this.lbl_DataEmissao);
            this.Controls.Add(this.lbl_NNota);
            this.Controls.Add(this.mtb_cnpj);
            this.Controls.Add(this.dgv_TabelaItens);
            this.Controls.Add(this.txt_DataEmissao);
            this.Controls.Add(this.txt_VlTotalNota);
            this.Controls.Add(this.txt_Nnota);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frm_ControleEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ControleEntrada";
            this.Load += new System.EventHandler(this.frm_ControleEntrada_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsm_novo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Label lbl_VlPermissao;
        private System.Windows.Forms.TextBox txt_Nnota;
        private System.Windows.Forms.TextBox txt_VlTotalNota;
        private System.Windows.Forms.TextBox txt_DataEmissao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgv_TabelaItens;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.Label lbl_NNota;
        private System.Windows.Forms.Label lbl_DataEmissao;
        private System.Windows.Forms.Label lbl_VlTotalCompra;
        private System.Windows.Forms.Label lbl_Cnpj;
        private System.Windows.Forms.Label lbl_Fornecedor;
        private System.Windows.Forms.TextBox txt_Fornecedor;
        private System.Windows.Forms.Label lbl_CodEntrada;
        private System.Windows.Forms.TextBox txt_CodEntrada;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.ComboBox cbx_Descricao;
        private System.Windows.Forms.TextBox txt_Qtd;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Label lbl_Qtd;
        private System.Windows.Forms.Label lbl_PrUnitario;
        private System.Windows.Forms.TextBox txt_PrUnit;
        private System.Windows.Forms.Label lbl_PrTotal;
        private System.Windows.Forms.TextBox txt_PrTotal;
        private System.Windows.Forms.Label lbl_DataEntrada;
        private System.Windows.Forms.TextBox txt_DataEntrada;
        private System.Windows.Forms.ComboBox cbx_Fornecedor;
        private System.Windows.Forms.CheckBox chx_editar;
        private System.Windows.Forms.Label lbl_CodTabela;
        private System.Windows.Forms.CheckBox chx_Liberar;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_codfor;
    }
}