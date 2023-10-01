namespace CG
{
    partial class frm_FornecedorCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FornecedorCadastro));
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_cidade = new System.Windows.Forms.ComboBox();
            this.cbx_TipoConta = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_op = new System.Windows.Forms.TextBox();
            this.txt_ag = new System.Windows.Forms.TextBox();
            this.txt_ct = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_site = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lkl_site = new System.Windows.Forms.LinkLabel();
            this.chx_editar = new System.Windows.Forms.CheckBox();
            this.cbx_ativo = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_tel2 = new System.Windows.Forms.MaskedTextBox();
            this.txt_tel1 = new System.Windows.Forms.MaskedTextBox();
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
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.mtb_Doc = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_estado
            // 
            this.cbx_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_estado.Enabled = false;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "MG",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbx_estado.Location = new System.Drawing.Point(375, 58);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(69, 21);
            this.cbx_estado.TabIndex = 1;
            this.cbx_estado.SelectedIndexChanged += new System.EventHandler(this.Cbx_estado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(372, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Estado";
            // 
            // txt_cep
            // 
            this.txt_cep.Enabled = false;
            this.txt_cep.Location = new System.Drawing.Point(242, 106);
            this.txt_cep.Multiline = true;
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(132, 21);
            this.txt_cep.TabIndex = 6;
            // 
            // txt_rua
            // 
            this.txt_rua.Enabled = false;
            this.txt_rua.Location = new System.Drawing.Point(19, 106);
            this.txt_rua.Multiline = true;
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(173, 21);
            this.txt_rua.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(89, 58);
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(285, 21);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(19, 58);
            this.txt_codigo.Multiline = true;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(69, 21);
            this.txt_codigo.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(18, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(239, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(621, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Telefone 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(520, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Telefone 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(87, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 57;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Enabled = false;
            this.txt_bairro.Location = new System.Drawing.Point(572, 58);
            this.txt_bairro.Multiline = true;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(149, 21);
            this.txt_bairro.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(571, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Bairro";
            // 
            // txt_contato
            // 
            this.txt_contato.Enabled = false;
            this.txt_contato.Location = new System.Drawing.Point(375, 106);
            this.txt_contato.Multiline = true;
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(146, 21);
            this.txt_contato.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(372, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Contato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(442, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Cidade";
            // 
            // cbx_cidade
            // 
            this.cbx_cidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_cidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_cidade.Enabled = false;
            this.cbx_cidade.FormattingEnabled = true;
            this.cbx_cidade.Location = new System.Drawing.Point(445, 58);
            this.cbx_cidade.Name = "cbx_cidade";
            this.cbx_cidade.Size = new System.Drawing.Size(126, 21);
            this.cbx_cidade.TabIndex = 2;
            // 
            // cbx_TipoConta
            // 
            this.cbx_TipoConta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_TipoConta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_TipoConta.Enabled = false;
            this.cbx_TipoConta.FormattingEnabled = true;
            this.cbx_TipoConta.Items.AddRange(new object[] {
            "CONTA CORRENTE",
            "POUPANÇA",
            "FACIL"});
            this.cbx_TipoConta.Location = new System.Drawing.Point(242, 161);
            this.cbx_TipoConta.Name = "cbx_TipoConta";
            this.cbx_TipoConta.Size = new System.Drawing.Size(132, 21);
            this.cbx_TipoConta.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(242, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Tipo de Conta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(478, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "Operação";
            // 
            // txt_op
            // 
            this.txt_op.Enabled = false;
            this.txt_op.Location = new System.Drawing.Point(481, 161);
            this.txt_op.Multiline = true;
            this.txt_op.Name = "txt_op";
            this.txt_op.Size = new System.Drawing.Size(89, 21);
            this.txt_op.TabIndex = 14;
            // 
            // txt_ag
            // 
            this.txt_ag.Enabled = false;
            this.txt_ag.Location = new System.Drawing.Point(375, 161);
            this.txt_ag.Multiline = true;
            this.txt_ag.Name = "txt_ag";
            this.txt_ag.Size = new System.Drawing.Size(105, 21);
            this.txt_ag.TabIndex = 13;
            // 
            // txt_ct
            // 
            this.txt_ct.Enabled = false;
            this.txt_ct.Location = new System.Drawing.Point(571, 161);
            this.txt_ct.Multiline = true;
            this.txt_ct.Name = "txt_ct";
            this.txt_ct.Size = new System.Drawing.Size(150, 21);
            this.txt_ct.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(372, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Agencia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(568, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Conta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(18, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "CNPJ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(20, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "Cod";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(19, 207);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(222, 21);
            this.txt_email.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(16, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "E-Mail";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(194, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 78;
            this.label19.Text = "Nº";
            // 
            // txt_num
            // 
            this.txt_num.Enabled = false;
            this.txt_num.Location = new System.Drawing.Point(193, 106);
            this.txt_num.Multiline = true;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(48, 21);
            this.txt_num.TabIndex = 5;
            // 
            // txt_site
            // 
            this.txt_site.Enabled = false;
            this.txt_site.Location = new System.Drawing.Point(242, 207);
            this.txt_site.Multiline = true;
            this.txt_site.Name = "txt_site";
            this.txt_site.Size = new System.Drawing.Size(328, 21);
            this.txt_site.TabIndex = 17;
            this.txt_site.TextChanged += new System.EventHandler(this.Txt_site_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Gray;
            this.label20.Location = new System.Drawing.Point(242, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 79;
            this.label20.Text = "Site";
            // 
            // lkl_site
            // 
            this.lkl_site.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.lkl_site.AutoSize = true;
            this.lkl_site.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lkl_site.Location = new System.Drawing.Point(18, 244);
            this.lkl_site.Name = "lkl_site";
            this.lkl_site.Size = new System.Drawing.Size(25, 13);
            this.lkl_site.TabIndex = 81;
            this.lkl_site.TabStop = true;
            this.lkl_site.Text = "Site";
            this.lkl_site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lkl_site_LinkClicked);
            // 
            // chx_editar
            // 
            this.chx_editar.AutoSize = true;
            this.chx_editar.Location = new System.Drawing.Point(655, 241);
            this.chx_editar.Name = "chx_editar";
            this.chx_editar.Size = new System.Drawing.Size(66, 17);
            this.chx_editar.TabIndex = 82;
            this.chx_editar.Text = "EDITAR";
            this.chx_editar.UseVisualStyleBackColor = true;
            this.chx_editar.Visible = false;
            // 
            // cbx_ativo
            // 
            this.cbx_ativo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_ativo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_ativo.Enabled = false;
            this.cbx_ativo.FormattingEnabled = true;
            this.cbx_ativo.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.cbx_ativo.Location = new System.Drawing.Point(571, 207);
            this.cbx_ativo.Name = "cbx_ativo";
            this.cbx_ativo.Size = new System.Drawing.Size(150, 21);
            this.cbx_ativo.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Gray;
            this.label21.Location = new System.Drawing.Point(568, 191);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 83;
            this.label21.Text = "Ativo";
            // 
            // txt_tel2
            // 
            this.txt_tel2.Enabled = false;
            this.txt_tel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel2.Location = new System.Drawing.Point(623, 106);
            this.txt_tel2.MaximumSize = new System.Drawing.Size(98, 21);
            this.txt_tel2.MinimumSize = new System.Drawing.Size(98, 21);
            this.txt_tel2.Name = "txt_tel2";
            this.txt_tel2.Size = new System.Drawing.Size(98, 21);
            this.txt_tel2.TabIndex = 85;
            // 
            // txt_tel1
            // 
            this.txt_tel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tel1.Enabled = false;
            this.txt_tel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel1.Location = new System.Drawing.Point(522, 106);
            this.txt_tel1.Name = "txt_tel1";
            this.txt_tel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tel1.Size = new System.Drawing.Size(100, 21);
            this.txt_tel1.TabIndex = 86;
            this.txt_tel1.Leave += new System.EventHandler(this.Txt_tel1_Leave_1);
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
            this.menuStrip1.Size = new System.Drawing.Size(739, 27);
            this.menuStrip1.TabIndex = 87;
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
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(652, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 147;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // mtb_Doc
            // 
            this.mtb_Doc.Location = new System.Drawing.Point(21, 161);
            this.mtb_Doc.Mask = "00.000.000/0000-00";
            this.mtb_Doc.Name = "mtb_Doc";
            this.mtb_Doc.Size = new System.Drawing.Size(220, 20);
            this.mtb_Doc.TabIndex = 148;
            // 
            // frm_FornecedorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(739, 281);
            this.Controls.Add(this.mtb_Doc);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.txt_tel1);
            this.Controls.Add(this.txt_tel2);
            this.Controls.Add(this.cbx_ativo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.chx_editar);
            this.Controls.Add(this.lkl_site);
            this.Controls.Add(this.txt_site);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_op);
            this.Controls.Add(this.txt_ag);
            this.Controls.Add(this.txt_ct);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbx_TipoConta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbx_cidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(755, 320);
            this.MinimumSize = new System.Drawing.Size(755, 320);
            this.Name = "frm_FornecedorCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.Frm_FornecedorCadastro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_cidade;
        private System.Windows.Forms.ComboBox cbx_TipoConta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_op;
        private System.Windows.Forms.TextBox txt_ag;
        private System.Windows.Forms.TextBox txt_ct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_site;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.LinkLabel lkl_site;
        private System.Windows.Forms.CheckBox chx_editar;
        private System.Windows.Forms.ComboBox cbx_ativo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox txt_tel2;
        public System.Windows.Forms.MaskedTextBox txt_tel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_novo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisa;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
        private System.Windows.Forms.MaskedTextBox mtb_Doc;
    }
}