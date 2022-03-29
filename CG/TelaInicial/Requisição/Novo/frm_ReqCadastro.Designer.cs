namespace CG
{
    partial class frm_ReqCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReqCadastro));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.txt_numreq = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.cbx_descricao = new System.Windows.Forms.ComboBox();
            this.cbx_contrato = new System.Windows.Forms.ComboBox();
            this.cbx_motivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_duplicar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.cbx_funcionario = new System.Windows.Forms.ComboBox();
            this.txt_matr = new System.Windows.Forms.TextBox();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd_Liberada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_itens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soma_item_liberado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_coditem = new System.Windows.Forms.Label();
            this.chx_liberar = new System.Windows.Forms.CheckBox();
            this.btn_Cancelar_Edicao = new System.Windows.Forms.Button();
            this.btn_ExcluirItem = new System.Windows.Forms.Button();
            this.txt_QtdTotal = new System.Windows.Forms.TextBox();
            this.chx_editar = new System.Windows.Forms.CheckBox();
            this.txt_QtdTotalLib = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_numreqtroca = new System.Windows.Forms.ComboBox();
            this.txt_reqdatatroca = new System.Windows.Forms.TextBox();
            this.lbl_reqtroca = new System.Windows.Forms.Label();
            this.lbl_datatroca = new System.Windows.Forms.Label();
            this.cbx_DescricaoTroca = new System.Windows.Forms.ComboBox();
            this.lbl_CodItemTroca = new System.Windows.Forms.Label();
            this.chx_Fun_Sem_Cadastro = new System.Windows.Forms.CheckBox();
            this.txt_FuncSemCadastro = new System.Windows.Forms.TextBox();
            this.cbx_CargoSemCadastro = new System.Windows.Forms.ComboBox();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_adicionar.Enabled = false;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_adicionar.Location = new System.Drawing.Point(523, 174);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(212, 32);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // txt_numreq
            // 
            this.txt_numreq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numreq.BackColor = System.Drawing.Color.White;
            this.txt_numreq.Enabled = false;
            this.txt_numreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numreq.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_numreq.Location = new System.Drawing.Point(46, 57);
            this.txt_numreq.Name = "txt_numreq";
            this.txt_numreq.Size = new System.Drawing.Size(202, 24);
            this.txt_numreq.TabIndex = 5;
            // 
            // txt_data
            // 
            this.txt_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_data.BackColor = System.Drawing.Color.White;
            this.txt_data.Enabled = false;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_data.Location = new System.Drawing.Point(249, 57);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(207, 24);
            this.txt_data.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nº Requisição";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(43, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contrato";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(246, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data";
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_visualizar.Location = new System.Drawing.Point(739, 174);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(192, 32);
            this.btn_visualizar.TabIndex = 14;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = false;
            this.btn_visualizar.Click += new System.EventHandler(this.Btn_visualizar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(43, 136);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 18;
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_funcionario.ForeColor = System.Drawing.Color.Gray;
            this.lbl_funcionario.Location = new System.Drawing.Point(43, 126);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(86, 18);
            this.lbl_funcionario.TabIndex = 19;
            this.lbl_funcionario.Text = "Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(518, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descrição";
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_qtd.ForeColor = System.Drawing.Color.Gray;
            this.lbl_qtd.Location = new System.Drawing.Point(518, 80);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(83, 18);
            this.lbl_qtd.TabIndex = 21;
            this.lbl_qtd.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Enabled = false;
            this.txt_quantidade.Location = new System.Drawing.Point(521, 101);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(128, 20);
            this.txt_quantidade.TabIndex = 22;
            // 
            // cbx_descricao
            // 
            this.cbx_descricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_descricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_descricao.Enabled = false;
            this.cbx_descricao.FormattingEnabled = true;
            this.cbx_descricao.Location = new System.Drawing.Point(521, 56);
            this.cbx_descricao.Name = "cbx_descricao";
            this.cbx_descricao.Size = new System.Drawing.Size(410, 21);
            this.cbx_descricao.TabIndex = 26;
            this.cbx_descricao.SelectedIndexChanged += new System.EventHandler(this.Cbx_descricao_SelectedIndexChanged);
            // 
            // cbx_contrato
            // 
            this.cbx_contrato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_contrato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_contrato.Enabled = false;
            this.cbx_contrato.FormattingEnabled = true;
            this.cbx_contrato.Location = new System.Drawing.Point(46, 101);
            this.cbx_contrato.Name = "cbx_contrato";
            this.cbx_contrato.Size = new System.Drawing.Size(410, 21);
            this.cbx_contrato.TabIndex = 29;
            this.cbx_contrato.SelectedIndexChanged += new System.EventHandler(this.Cbx_contrato_SelectedIndexChanged);
            // 
            // cbx_motivo
            // 
            this.cbx_motivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_motivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_motivo.Enabled = false;
            this.cbx_motivo.FormattingEnabled = true;
            this.cbx_motivo.Items.AddRange(new object[] {
            "ADMISSÃO/SUBSTITUIÇÃO",
            "ADMISSÃO/FERISTA",
            "REPOSIÇÃO",
            "IMPLANTAÇÃO",
            "COMPLEMENTO/ADMINISSÃO",
            "TROCA"});
            this.cbx_motivo.Location = new System.Drawing.Point(650, 101);
            this.cbx_motivo.Name = "cbx_motivo";
            this.cbx_motivo.Size = new System.Drawing.Size(281, 21);
            this.cbx_motivo.TabIndex = 31;
            this.cbx_motivo.SelectedIndexChanged += new System.EventHandler(this.Cbx_motivo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(647, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Motivo";
            // 
            // btn_duplicar
            // 
            this.btn_duplicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_duplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_duplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_duplicar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_duplicar.Location = new System.Drawing.Point(46, 646);
            this.btn_duplicar.Name = "btn_duplicar";
            this.btn_duplicar.Size = new System.Drawing.Size(59, 27);
            this.btn_duplicar.TabIndex = 41;
            this.btn_duplicar.Text = "Duplicar";
            this.btn_duplicar.UseVisualStyleBackColor = false;
            this.btn_duplicar.Click += new System.EventHandler(this.Btn_duplicar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(43, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Cargo";
            // 
            // txt_cargo
            // 
            this.txt_cargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cargo.BackColor = System.Drawing.Color.White;
            this.txt_cargo.Enabled = false;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cargo.Location = new System.Drawing.Point(46, 192);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(410, 24);
            this.txt_cargo.TabIndex = 42;
            // 
            // cbx_funcionario
            // 
            this.cbx_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_funcionario.Enabled = false;
            this.cbx_funcionario.FormattingEnabled = true;
            this.cbx_funcionario.Location = new System.Drawing.Point(47, 146);
            this.cbx_funcionario.Name = "cbx_funcionario";
            this.cbx_funcionario.Size = new System.Drawing.Size(409, 21);
            this.cbx_funcionario.TabIndex = 45;
            this.cbx_funcionario.SelectedIndexChanged += new System.EventHandler(this.Cbx_funcionario_SelectedIndexChanged);
            // 
            // txt_matr
            // 
            this.txt_matr.Enabled = false;
            this.txt_matr.Location = new System.Drawing.Point(415, 170);
            this.txt_matr.Name = "txt_matr";
            this.txt_matr.Size = new System.Drawing.Size(41, 20);
            this.txt_matr.TabIndex = 46;
            this.txt_matr.Text = "txt recebe matricula do funcionario";
            this.txt_matr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.qtd,
            this.Qtd_Liberada,
            this.Motivo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_produtos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_produtos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_produtos.Location = new System.Drawing.Point(521, 252);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.Size = new System.Drawing.Size(410, 390);
            this.dgv_produtos.TabIndex = 47;
            this.dgv_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_produtos_CellDoubleClick);
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 160;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "qtd";
            this.qtd.HeaderText = "Qtd.";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 40;
            // 
            // Qtd_Liberada
            // 
            this.Qtd_Liberada.DataPropertyName = "qtd_lib";
            this.Qtd_Liberada.HeaderText = "Qtd.Lib";
            this.Qtd_Liberada.Name = "Qtd_Liberada";
            this.Qtd_Liberada.ReadOnly = true;
            this.Qtd_Liberada.Width = 45;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 140;
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToDeleteRows = false;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.Funcionarios,
            this.qtd_itens,
            this.Soma,
            this.soma_item_liberado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_funcionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_funcionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_funcionario.Location = new System.Drawing.Point(46, 252);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.ReadOnly = true;
            this.dgv_funcionario.RowHeadersVisible = false;
            this.dgv_funcionario.Size = new System.Drawing.Size(410, 390);
            this.dgv_funcionario.TabIndex = 48;
            this.dgv_funcionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_funcionario_CellDoubleClick);
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "matr_func";
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Width = 55;
            // 
            // Funcionarios
            // 
            this.Funcionarios.DataPropertyName = "func";
            this.Funcionarios.HeaderText = "Funcionarios";
            this.Funcionarios.Name = "Funcionarios";
            this.Funcionarios.ReadOnly = true;
            this.Funcionarios.Width = 199;
            // 
            // qtd_itens
            // 
            this.qtd_itens.DataPropertyName = "qtd_item_func";
            this.qtd_itens.HeaderText = "Qtd Itens";
            this.qtd_itens.Name = "qtd_itens";
            this.qtd_itens.ReadOnly = true;
            this.qtd_itens.Width = 40;
            // 
            // Soma
            // 
            this.Soma.DataPropertyName = "soma_item_func";
            this.Soma.HeaderText = "Soma Itens";
            this.Soma.Name = "Soma";
            this.Soma.ReadOnly = true;
            this.Soma.Width = 40;
            // 
            // soma_item_liberado
            // 
            this.soma_item_liberado.DataPropertyName = "soma_item_func_lib";
            this.soma_item_liberado.HeaderText = "Soma Itens Lib.";
            this.soma_item_liberado.Name = "soma_item_liberado";
            this.soma_item_liberado.ReadOnly = true;
            this.soma_item_liberado.Width = 73;
            // 
            // lbl_coditem
            // 
            this.lbl_coditem.AutoSize = true;
            this.lbl_coditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_coditem.ForeColor = System.Drawing.Color.White;
            this.lbl_coditem.Location = new System.Drawing.Point(836, 35);
            this.lbl_coditem.Name = "lbl_coditem";
            this.lbl_coditem.Size = new System.Drawing.Size(95, 18);
            this.lbl_coditem.TabIndex = 49;
            this.lbl_coditem.Text = "Cod_produto";
            this.lbl_coditem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chx_liberar
            // 
            this.chx_liberar.AutoSize = true;
            this.chx_liberar.Enabled = false;
            this.chx_liberar.Location = new System.Drawing.Point(111, 652);
            this.chx_liberar.Name = "chx_liberar";
            this.chx_liberar.Size = new System.Drawing.Size(58, 17);
            this.chx_liberar.TabIndex = 50;
            this.chx_liberar.Text = "Liberar";
            this.chx_liberar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar_Edicao
            // 
            this.btn_Cancelar_Edicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar_Edicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_Cancelar_Edicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar_Edicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar_Edicao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cancelar_Edicao.Location = new System.Drawing.Point(523, 211);
            this.btn_Cancelar_Edicao.Name = "btn_Cancelar_Edicao";
            this.btn_Cancelar_Edicao.Size = new System.Drawing.Size(212, 32);
            this.btn_Cancelar_Edicao.TabIndex = 51;
            this.btn_Cancelar_Edicao.Text = "Cancelar Edição";
            this.btn_Cancelar_Edicao.UseVisualStyleBackColor = false;
            this.btn_Cancelar_Edicao.Visible = false;
            this.btn_Cancelar_Edicao.Click += new System.EventHandler(this.Btn_Cancelar_Edicao_Click);
            // 
            // btn_ExcluirItem
            // 
            this.btn_ExcluirItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_ExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ExcluirItem.Location = new System.Drawing.Point(739, 211);
            this.btn_ExcluirItem.Name = "btn_ExcluirItem";
            this.btn_ExcluirItem.Size = new System.Drawing.Size(192, 32);
            this.btn_ExcluirItem.TabIndex = 52;
            this.btn_ExcluirItem.Text = "Excluir Item";
            this.btn_ExcluirItem.UseVisualStyleBackColor = false;
            this.btn_ExcluirItem.Visible = false;
            this.btn_ExcluirItem.Click += new System.EventHandler(this.Btn_ExcluirItem_Click);
            // 
            // txt_QtdTotal
            // 
            this.txt_QtdTotal.Enabled = false;
            this.txt_QtdTotal.Location = new System.Drawing.Point(734, 652);
            this.txt_QtdTotal.Name = "txt_QtdTotal";
            this.txt_QtdTotal.Size = new System.Drawing.Size(55, 20);
            this.txt_QtdTotal.TabIndex = 53;
            this.txt_QtdTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chx_editar
            // 
            this.chx_editar.AutoSize = true;
            this.chx_editar.Location = new System.Drawing.Point(403, 38);
            this.chx_editar.Name = "chx_editar";
            this.chx_editar.Size = new System.Drawing.Size(53, 17);
            this.chx_editar.TabIndex = 54;
            this.chx_editar.Text = "Editar";
            this.chx_editar.UseVisualStyleBackColor = true;
            this.chx_editar.Visible = false;
            // 
            // txt_QtdTotalLib
            // 
            this.txt_QtdTotalLib.Enabled = false;
            this.txt_QtdTotalLib.Location = new System.Drawing.Point(876, 652);
            this.txt_QtdTotalLib.Name = "txt_QtdTotalLib";
            this.txt_QtdTotalLib.Size = new System.Drawing.Size(55, 20);
            this.txt_QtdTotalLib.TabIndex = 55;
            this.txt_QtdTotalLib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Total Solicitado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(796, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Total Liberado";
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_status.Location = new System.Drawing.Point(175, 651);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(148, 18);
            this.lbl_status.TabIndex = 58;
            this.lbl_status.Text = "Status da Requisição";
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
            this.tsm_excluir,
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 27);
            this.menuStrip1.TabIndex = 59;
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
            // cbx_numreqtroca
            // 
            this.cbx_numreqtroca.FormattingEnabled = true;
            this.cbx_numreqtroca.Location = new System.Drawing.Point(523, 147);
            this.cbx_numreqtroca.Name = "cbx_numreqtroca";
            this.cbx_numreqtroca.Size = new System.Drawing.Size(115, 21);
            this.cbx_numreqtroca.TabIndex = 60;
            this.cbx_numreqtroca.Visible = false;
            this.cbx_numreqtroca.SelectedIndexChanged += new System.EventHandler(this.Cbx_numreqtroca_SelectedIndexChanged);
            // 
            // txt_reqdatatroca
            // 
            this.txt_reqdatatroca.Location = new System.Drawing.Point(644, 147);
            this.txt_reqdatatroca.Name = "txt_reqdatatroca";
            this.txt_reqdatatroca.Size = new System.Drawing.Size(114, 20);
            this.txt_reqdatatroca.TabIndex = 61;
            this.txt_reqdatatroca.Visible = false;
            // 
            // lbl_reqtroca
            // 
            this.lbl_reqtroca.AutoSize = true;
            this.lbl_reqtroca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_reqtroca.ForeColor = System.Drawing.Color.White;
            this.lbl_reqtroca.Location = new System.Drawing.Point(520, 126);
            this.lbl_reqtroca.Name = "lbl_reqtroca";
            this.lbl_reqtroca.Size = new System.Drawing.Size(82, 18);
            this.lbl_reqtroca.TabIndex = 62;
            this.lbl_reqtroca.Text = "Requisição";
            this.lbl_reqtroca.Visible = false;
            this.lbl_reqtroca.DoubleClick += new System.EventHandler(this.Lbl_reqtroca_DoubleClick);
            // 
            // lbl_datatroca
            // 
            this.lbl_datatroca.AutoSize = true;
            this.lbl_datatroca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_datatroca.ForeColor = System.Drawing.Color.White;
            this.lbl_datatroca.Location = new System.Drawing.Point(641, 125);
            this.lbl_datatroca.Name = "lbl_datatroca";
            this.lbl_datatroca.Size = new System.Drawing.Size(39, 18);
            this.lbl_datatroca.TabIndex = 63;
            this.lbl_datatroca.Text = "Data";
            this.lbl_datatroca.Visible = false;
            // 
            // cbx_DescricaoTroca
            // 
            this.cbx_DescricaoTroca.FormattingEnabled = true;
            this.cbx_DescricaoTroca.Location = new System.Drawing.Point(764, 146);
            this.cbx_DescricaoTroca.Name = "cbx_DescricaoTroca";
            this.cbx_DescricaoTroca.Size = new System.Drawing.Size(167, 21);
            this.cbx_DescricaoTroca.TabIndex = 64;
            this.cbx_DescricaoTroca.Visible = false;
            this.cbx_DescricaoTroca.SelectedIndexChanged += new System.EventHandler(this.Cbx_DescricaoTroca_SelectedIndexChanged);
            // 
            // lbl_CodItemTroca
            // 
            this.lbl_CodItemTroca.AutoSize = true;
            this.lbl_CodItemTroca.Location = new System.Drawing.Point(852, 129);
            this.lbl_CodItemTroca.Name = "lbl_CodItemTroca";
            this.lbl_CodItemTroca.Size = new System.Drawing.Size(79, 13);
            this.lbl_CodItemTroca.TabIndex = 65;
            this.lbl_CodItemTroca.Text = "Cod_itemTroca";
            this.lbl_CodItemTroca.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_CodItemTroca.Visible = false;
            // 
            // chx_Fun_Sem_Cadastro
            // 
            this.chx_Fun_Sem_Cadastro.AutoSize = true;
            this.chx_Fun_Sem_Cadastro.Enabled = false;
            this.chx_Fun_Sem_Cadastro.Location = new System.Drawing.Point(353, 128);
            this.chx_Fun_Sem_Cadastro.Name = "chx_Fun_Sem_Cadastro";
            this.chx_Fun_Sem_Cadastro.Size = new System.Drawing.Size(103, 17);
            this.chx_Fun_Sem_Cadastro.TabIndex = 66;
            this.chx_Fun_Sem_Cadastro.Text = "Não Cadastrado";
            this.chx_Fun_Sem_Cadastro.UseVisualStyleBackColor = true;
            this.chx_Fun_Sem_Cadastro.CheckedChanged += new System.EventHandler(this.Chx_Fun_Sem_Cadastro_CheckedChanged);
            // 
            // txt_FuncSemCadastro
            // 
            this.txt_FuncSemCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FuncSemCadastro.Location = new System.Drawing.Point(46, 146);
            this.txt_FuncSemCadastro.Name = "txt_FuncSemCadastro";
            this.txt_FuncSemCadastro.Size = new System.Drawing.Size(406, 20);
            this.txt_FuncSemCadastro.TabIndex = 67;
            this.txt_FuncSemCadastro.Visible = false;
            this.txt_FuncSemCadastro.TextChanged += new System.EventHandler(this.Txt_FuncSemCadastro_TextChanged);
            // 
            // cbx_CargoSemCadastro
            // 
            this.cbx_CargoSemCadastro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_CargoSemCadastro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_CargoSemCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_CargoSemCadastro.FormattingEnabled = true;
            this.cbx_CargoSemCadastro.Location = new System.Drawing.Point(47, 193);
            this.cbx_CargoSemCadastro.Name = "cbx_CargoSemCadastro";
            this.cbx_CargoSemCadastro.Size = new System.Drawing.Size(405, 23);
            this.cbx_CargoSemCadastro.TabIndex = 68;
            this.cbx_CargoSemCadastro.Visible = false;
            this.cbx_CargoSemCadastro.SelectedIndexChanged += new System.EventHandler(this.Cbx_CargoSemCadastro_SelectedIndexChanged);
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(894, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 146;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // frm_ReqCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.cbx_CargoSemCadastro);
            this.Controls.Add(this.txt_FuncSemCadastro);
            this.Controls.Add(this.chx_Fun_Sem_Cadastro);
            this.Controls.Add(this.lbl_CodItemTroca);
            this.Controls.Add(this.cbx_DescricaoTroca);
            this.Controls.Add(this.lbl_datatroca);
            this.Controls.Add(this.lbl_reqtroca);
            this.Controls.Add(this.txt_reqdatatroca);
            this.Controls.Add(this.cbx_numreqtroca);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_QtdTotalLib);
            this.Controls.Add(this.chx_editar);
            this.Controls.Add(this.txt_QtdTotal);
            this.Controls.Add(this.btn_ExcluirItem);
            this.Controls.Add(this.btn_Cancelar_Edicao);
            this.Controls.Add(this.chx_liberar);
            this.Controls.Add(this.lbl_coditem);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.txt_matr);
            this.Controls.Add(this.cbx_funcionario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.btn_duplicar);
            this.Controls.Add(this.cbx_motivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_contrato);
            this.Controls.Add(this.cbx_descricao);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_funcionario);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_numreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(990, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "frm_ReqCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Requerimento";
            this.Load += new System.EventHandler(this.Frm_req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox txt_numreq;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_funcionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.ComboBox cbx_descricao;
        private System.Windows.Forms.ComboBox cbx_contrato;
        private System.Windows.Forms.ComboBox cbx_motivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_duplicar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.ComboBox cbx_funcionario;
        private System.Windows.Forms.TextBox txt_matr;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.Label lbl_coditem;
        private System.Windows.Forms.CheckBox chx_liberar;
        private System.Windows.Forms.Button btn_Cancelar_Edicao;
        private System.Windows.Forms.Button btn_ExcluirItem;
        private System.Windows.Forms.TextBox txt_QtdTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd_Liberada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_itens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soma;
        private System.Windows.Forms.DataGridViewTextBoxColumn soma_item_liberado;
        private System.Windows.Forms.CheckBox chx_editar;
        private System.Windows.Forms.TextBox txt_QtdTotalLib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_novo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisa;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir;
        private System.Windows.Forms.ComboBox cbx_numreqtroca;
        private System.Windows.Forms.TextBox txt_reqdatatroca;
        private System.Windows.Forms.Label lbl_reqtroca;
        private System.Windows.Forms.Label lbl_datatroca;
        private System.Windows.Forms.ComboBox cbx_DescricaoTroca;
        private System.Windows.Forms.Label lbl_CodItemTroca;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.CheckBox chx_Fun_Sem_Cadastro;
        private System.Windows.Forms.TextBox txt_FuncSemCadastro;
        private System.Windows.Forms.ComboBox cbx_CargoSemCadastro;
        private System.Windows.Forms.Label lbl_VlPermissao;
    }
}