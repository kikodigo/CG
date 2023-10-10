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
            cbx_estado = new ComboBox();
            label7 = new Label();
            txt_cep = new TextBox();
            txt_rua = new TextBox();
            txt_nome = new TextBox();
            txt_codigo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_bairro = new TextBox();
            label8 = new Label();
            txt_contato = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cbx_cidade = new ComboBox();
            cbx_TipoConta = new ComboBox();
            label11 = new Label();
            label13 = new Label();
            txt_op = new TextBox();
            txt_ag = new TextBox();
            txt_ct = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txt_email = new TextBox();
            label18 = new Label();
            label19 = new Label();
            txt_num = new TextBox();
            txt_site = new TextBox();
            label20 = new Label();
            lkl_site = new LinkLabel();
            chx_editar = new CheckBox();
            cbx_ativo = new ComboBox();
            label21 = new Label();
            txt_tel2 = new MaskedTextBox();
            txt_tel1 = new MaskedTextBox();
            menuStrip1 = new MenuStrip();
            tsm_novo = new ToolStripMenuItem();
            tsm_editar = new ToolStripMenuItem();
            tsm_salvar = new ToolStripMenuItem();
            tsm_cancelar = new ToolStripMenuItem();
            tsm_anterior = new ToolStripMenuItem();
            tsm_proximo = new ToolStripMenuItem();
            tsm_pesquisa = new ToolStripMenuItem();
            tsm_excluir = new ToolStripMenuItem();
            txt_usuario = new ToolStripTextBox();
            Usuario = new ToolStripMenuItem();
            lbl_VlPermissao = new Label();
            mtb_Doc = new MaskedTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbx_estado
            // 
            cbx_estado.AutoCompleteMode = AutoCompleteMode.Append;
            cbx_estado.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_estado.Enabled = false;
            cbx_estado.FormattingEnabled = true;
            cbx_estado.Items.AddRange(new object[] { "MG", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbx_estado.Location = new Point(438, 67);
            cbx_estado.Margin = new Padding(4, 3, 4, 3);
            cbx_estado.Name = "cbx_estado";
            cbx_estado.Size = new Size(80, 23);
            cbx_estado.TabIndex = 1;
            cbx_estado.SelectedIndexChanged += Cbx_estado_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(434, 48);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 40;
            label7.Text = "Estado";
            // 
            // txt_cep
            // 
            txt_cep.Enabled = false;
            txt_cep.Location = new Point(282, 122);
            txt_cep.Margin = new Padding(4, 3, 4, 3);
            txt_cep.Multiline = true;
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(153, 24);
            txt_cep.TabIndex = 6;
            // 
            // txt_rua
            // 
            txt_rua.Enabled = false;
            txt_rua.Location = new Point(22, 122);
            txt_rua.Margin = new Padding(4, 3, 4, 3);
            txt_rua.Multiline = true;
            txt_rua.Name = "txt_rua";
            txt_rua.Size = new Size(201, 24);
            txt_rua.TabIndex = 4;
            // 
            // txt_nome
            // 
            txt_nome.Enabled = false;
            txt_nome.Location = new Point(104, 67);
            txt_nome.Margin = new Padding(4, 3, 4, 3);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(332, 24);
            txt_nome.TabIndex = 0;
            // 
            // txt_codigo
            // 
            txt_codigo.Enabled = false;
            txt_codigo.Location = new Point(22, 67);
            txt_codigo.Margin = new Padding(4, 3, 4, 3);
            txt_codigo.Multiline = true;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(80, 24);
            txt_codigo.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(21, 104);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 33;
            label6.Text = "Rua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(279, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 32;
            label5.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(724, 104);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 31;
            label4.Text = "Telefone 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(607, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 30;
            label3.Text = "Telefone 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(102, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 29;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.Location = new Point(-2, 283);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 27);
            label1.TabIndex = 57;
            // 
            // txt_bairro
            // 
            txt_bairro.Enabled = false;
            txt_bairro.Location = new Point(667, 67);
            txt_bairro.Margin = new Padding(4, 3, 4, 3);
            txt_bairro.Multiline = true;
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(173, 24);
            txt_bairro.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(666, 48);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 44;
            label8.Text = "Bairro";
            // 
            // txt_contato
            // 
            txt_contato.Enabled = false;
            txt_contato.Location = new Point(438, 122);
            txt_contato.Margin = new Padding(4, 3, 4, 3);
            txt_contato.Multiline = true;
            txt_contato.Name = "txt_contato";
            txt_contato.Size = new Size(170, 24);
            txt_contato.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(434, 104);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 48;
            label9.Text = "Contato";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(516, 48);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 58;
            label10.Text = "Cidade";
            // 
            // cbx_cidade
            // 
            cbx_cidade.AutoCompleteMode = AutoCompleteMode.Append;
            cbx_cidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_cidade.Enabled = false;
            cbx_cidade.FormattingEnabled = true;
            cbx_cidade.Location = new Point(519, 67);
            cbx_cidade.Margin = new Padding(4, 3, 4, 3);
            cbx_cidade.Name = "cbx_cidade";
            cbx_cidade.Size = new Size(146, 23);
            cbx_cidade.TabIndex = 2;
            // 
            // cbx_TipoConta
            // 
            cbx_TipoConta.AutoCompleteMode = AutoCompleteMode.Append;
            cbx_TipoConta.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_TipoConta.Enabled = false;
            cbx_TipoConta.FormattingEnabled = true;
            cbx_TipoConta.Items.AddRange(new object[] { "CONTA CORRENTE", "POUPANÇA", "FACIL" });
            cbx_TipoConta.Location = new Point(282, 186);
            cbx_TipoConta.Margin = new Padding(4, 3, 4, 3);
            cbx_TipoConta.Name = "cbx_TipoConta";
            cbx_TipoConta.Size = new Size(153, 23);
            cbx_TipoConta.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(282, 167);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 63;
            label11.Text = "Tipo de Conta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(558, 167);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 70;
            label13.Text = "Operação";
            // 
            // txt_op
            // 
            txt_op.Enabled = false;
            txt_op.Location = new Point(561, 186);
            txt_op.Margin = new Padding(4, 3, 4, 3);
            txt_op.Multiline = true;
            txt_op.Name = "txt_op";
            txt_op.Size = new Size(103, 24);
            txt_op.TabIndex = 14;
            // 
            // txt_ag
            // 
            txt_ag.Enabled = false;
            txt_ag.Location = new Point(438, 186);
            txt_ag.Margin = new Padding(4, 3, 4, 3);
            txt_ag.Multiline = true;
            txt_ag.Name = "txt_ag";
            txt_ag.Size = new Size(122, 24);
            txt_ag.TabIndex = 13;
            // 
            // txt_ct
            // 
            txt_ct.Enabled = false;
            txt_ct.Location = new Point(666, 186);
            txt_ct.Margin = new Padding(4, 3, 4, 3);
            txt_ct.Multiline = true;
            txt_ct.Name = "txt_ct";
            txt_ct.Size = new Size(174, 24);
            txt_ct.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(434, 167);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 66;
            label14.Text = "Agencia";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(663, 167);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 65;
            label15.Text = "Conta";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(21, 167);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(34, 15);
            label16.TabIndex = 72;
            label16.Text = "CNPJ";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(23, 48);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 73;
            label17.Text = "Cod";
            label17.Click += label17_Click;
            // 
            // txt_email
            // 
            txt_email.Enabled = false;
            txt_email.Location = new Point(22, 239);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(258, 24);
            txt_email.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(19, 220);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(41, 15);
            label18.TabIndex = 74;
            label18.Text = "E-Mail";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Gray;
            label19.Location = new Point(226, 104);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(21, 15);
            label19.TabIndex = 78;
            label19.Text = "Nº";
            // 
            // txt_num
            // 
            txt_num.Enabled = false;
            txt_num.Location = new Point(225, 122);
            txt_num.Margin = new Padding(4, 3, 4, 3);
            txt_num.Multiline = true;
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(55, 24);
            txt_num.TabIndex = 5;
            // 
            // txt_site
            // 
            txt_site.Enabled = false;
            txt_site.Location = new Point(282, 239);
            txt_site.Margin = new Padding(4, 3, 4, 3);
            txt_site.Multiline = true;
            txt_site.Name = "txt_site";
            txt_site.Size = new Size(382, 24);
            txt_site.TabIndex = 17;
            txt_site.TextChanged += Txt_site_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Gray;
            label20.Location = new Point(282, 220);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(26, 15);
            label20.TabIndex = 79;
            label20.Text = "Site";
            // 
            // lkl_site
            // 
            lkl_site.ActiveLinkColor = Color.DarkGray;
            lkl_site.AutoSize = true;
            lkl_site.LinkColor = Color.FromArgb(255, 128, 0);
            lkl_site.Location = new Point(21, 282);
            lkl_site.Margin = new Padding(4, 0, 4, 0);
            lkl_site.Name = "lkl_site";
            lkl_site.Size = new Size(26, 15);
            lkl_site.TabIndex = 81;
            lkl_site.TabStop = true;
            lkl_site.Text = "Site";
            lkl_site.LinkClicked += Lkl_site_LinkClicked;
            // 
            // chx_editar
            // 
            chx_editar.AutoSize = true;
            chx_editar.Location = new Point(764, 278);
            chx_editar.Margin = new Padding(4, 3, 4, 3);
            chx_editar.Name = "chx_editar";
            chx_editar.Size = new Size(63, 19);
            chx_editar.TabIndex = 82;
            chx_editar.Text = "EDITAR";
            chx_editar.UseVisualStyleBackColor = true;
            chx_editar.Visible = false;
            // 
            // cbx_ativo
            // 
            cbx_ativo.AutoCompleteMode = AutoCompleteMode.Append;
            cbx_ativo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_ativo.Enabled = false;
            cbx_ativo.FormattingEnabled = true;
            cbx_ativo.Items.AddRange(new object[] { "SIM", "NAO" });
            cbx_ativo.Location = new Point(666, 239);
            cbx_ativo.Margin = new Padding(4, 3, 4, 3);
            cbx_ativo.Name = "cbx_ativo";
            cbx_ativo.Size = new Size(174, 23);
            cbx_ativo.TabIndex = 18;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Gray;
            label21.Location = new Point(663, 220);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(35, 15);
            label21.TabIndex = 83;
            label21.Text = "Ativo";
            // 
            // txt_tel2
            // 
            txt_tel2.Enabled = false;
            txt_tel2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tel2.Location = new Point(727, 122);
            txt_tel2.Margin = new Padding(4, 3, 4, 3);
            txt_tel2.MaximumSize = new Size(114, 21);
            txt_tel2.MinimumSize = new Size(114, 21);
            txt_tel2.Name = "txt_tel2";
            txt_tel2.Size = new Size(114, 21);
            txt_tel2.TabIndex = 85;
            // 
            // txt_tel1
            // 
            txt_tel1.BorderStyle = BorderStyle.FixedSingle;
            txt_tel1.Enabled = false;
            txt_tel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tel1.Location = new Point(609, 122);
            txt_tel1.Margin = new Padding(4, 3, 4, 3);
            txt_tel1.Name = "txt_tel1";
            txt_tel1.RightToLeft = RightToLeft.No;
            txt_tel1.Size = new Size(116, 21);
            txt_tel1.TabIndex = 86;
            txt_tel1.Leave += Txt_tel1_Leave_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsm_novo, tsm_editar, tsm_salvar, tsm_cancelar, tsm_anterior, tsm_proximo, tsm_pesquisa, tsm_excluir, txt_usuario, Usuario });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(862, 27);
            menuStrip1.TabIndex = 87;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsm_novo
            // 
            tsm_novo.Name = "tsm_novo";
            tsm_novo.Size = new Size(48, 23);
            tsm_novo.Text = "Novo";
            tsm_novo.Click += Tsm_novo_Click;
            // 
            // tsm_editar
            // 
            tsm_editar.Name = "tsm_editar";
            tsm_editar.Size = new Size(49, 23);
            tsm_editar.Text = "Editar";
            tsm_editar.Click += Tsm_editar_Click;
            // 
            // tsm_salvar
            // 
            tsm_salvar.Name = "tsm_salvar";
            tsm_salvar.Size = new Size(50, 23);
            tsm_salvar.Text = "Salvar";
            tsm_salvar.Click += Tsm_salvar_Click;
            // 
            // tsm_cancelar
            // 
            tsm_cancelar.Name = "tsm_cancelar";
            tsm_cancelar.Size = new Size(65, 23);
            tsm_cancelar.Text = "Cancelar";
            tsm_cancelar.Click += Tsm_cancelar_Click;
            // 
            // tsm_anterior
            // 
            tsm_anterior.Name = "tsm_anterior";
            tsm_anterior.Size = new Size(62, 23);
            tsm_anterior.Text = "Anterior";
            tsm_anterior.Click += Tsm_anterior_Click;
            // 
            // tsm_proximo
            // 
            tsm_proximo.Name = "tsm_proximo";
            tsm_proximo.Size = new Size(64, 23);
            tsm_proximo.Text = "Proximo";
            tsm_proximo.Click += Tsm_proximo_Click;
            // 
            // tsm_pesquisa
            // 
            tsm_pesquisa.Name = "tsm_pesquisa";
            tsm_pesquisa.Size = new Size(65, 23);
            tsm_pesquisa.Text = "Pesquisa";
            tsm_pesquisa.Click += Tsm_pesquisa_Click;
            // 
            // tsm_excluir
            // 
            tsm_excluir.Name = "tsm_excluir";
            tsm_excluir.Size = new Size(54, 23);
            tsm_excluir.Text = "Excluir";
            tsm_excluir.Click += Tsm_excluir_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Alignment = ToolStripItemAlignment.Right;
            txt_usuario.Enabled = false;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(116, 23);
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
            lbl_VlPermissao.Location = new Point(761, 31);
            lbl_VlPermissao.Margin = new Padding(4, 0, 4, 0);
            lbl_VlPermissao.Name = "lbl_VlPermissao";
            lbl_VlPermissao.Size = new Size(89, 15);
            lbl_VlPermissao.TabIndex = 147;
            lbl_VlPermissao.Text = "lbl_VlPermissao";
            lbl_VlPermissao.Visible = false;
            // 
            // mtb_Doc
            // 
            mtb_Doc.Location = new Point(24, 186);
            mtb_Doc.Margin = new Padding(4, 3, 4, 3);
            mtb_Doc.Mask = "00.000.000/0000-00";
            mtb_Doc.Name = "mtb_Doc";
            mtb_Doc.Size = new Size(256, 23);
            mtb_Doc.TabIndex = 148;
            // 
            // frm_FornecedorCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(862, 324);
            Controls.Add(mtb_Doc);
            Controls.Add(lbl_VlPermissao);
            Controls.Add(txt_tel1);
            Controls.Add(txt_tel2);
            Controls.Add(cbx_ativo);
            Controls.Add(label21);
            Controls.Add(chx_editar);
            Controls.Add(lkl_site);
            Controls.Add(txt_site);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(txt_num);
            Controls.Add(txt_email);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(txt_op);
            Controls.Add(txt_ag);
            Controls.Add(txt_ct);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(cbx_TipoConta);
            Controls.Add(label11);
            Controls.Add(cbx_cidade);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_contato);
            Controls.Add(txt_bairro);
            Controls.Add(label8);
            Controls.Add(cbx_estado);
            Controls.Add(label7);
            Controls.Add(txt_cep);
            Controls.Add(txt_rua);
            Controls.Add(txt_nome);
            Controls.Add(txt_codigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(878, 363);
            MinimumSize = new Size(878, 363);
            Name = "frm_FornecedorCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Fornecedor";
            Load += Frm_FornecedorCadastro_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbx_estado;
        private Label label7;
        private TextBox txt_cep;
        private TextBox txt_rua;
        private TextBox txt_nome;
        private TextBox txt_codigo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_bairro;
        private Label label8;
        private TextBox txt_contato;
        private Label label9;
        private Label label10;
        private ComboBox cbx_cidade;
        private ComboBox cbx_TipoConta;
        private Label label11;
        private Label label13;
        private TextBox txt_op;
        private TextBox txt_ag;
        private TextBox txt_ct;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txt_email;
        private Label label18;
        private Label label19;
        private TextBox txt_num;
        private TextBox txt_site;
        private Label label20;
        private LinkLabel lkl_site;
        private CheckBox chx_editar;
        private ComboBox cbx_ativo;
        private Label label21;
        private MaskedTextBox txt_tel2;
        public MaskedTextBox txt_tel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsm_novo;
        private ToolStripMenuItem tsm_editar;
        private ToolStripMenuItem tsm_salvar;
        private ToolStripMenuItem tsm_cancelar;
        private ToolStripMenuItem tsm_anterior;
        private ToolStripMenuItem tsm_proximo;
        private ToolStripMenuItem tsm_pesquisa;
        private ToolStripMenuItem tsm_excluir;
        private ToolStripTextBox txt_usuario;
        private ToolStripMenuItem Usuario;
        private Label lbl_VlPermissao;
        private MaskedTextBox mtb_Doc;
    }
}