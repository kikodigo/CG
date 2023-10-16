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
            cbx_Estado = new ComboBox();
            label7 = new Label();
            txt_Cep = new TextBox();
            txt_Rua = new TextBox();
            txt_Fantasia = new TextBox();
            txt_Id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Bairro = new TextBox();
            label8 = new Label();
            txt_Contato = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            txt_Op = new TextBox();
            txt_Ag = new TextBox();
            txt_Ct = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txt_Email = new TextBox();
            label18 = new Label();
            label19 = new Label();
            txt_Num = new TextBox();
            txt_Site = new TextBox();
            label20 = new Label();
            lkl_site = new LinkLabel();
            chx_editar = new CheckBox();
            cbx_Status = new ComboBox();
            label21 = new Label();
            menuStrip1 = new MenuStrip();
            tsm_Novo = new ToolStripMenuItem();
            tsm_Editar = new ToolStripMenuItem();
            tsm_Salvar = new ToolStripMenuItem();
            tsm_Cancelar = new ToolStripMenuItem();
            tsm_Anterior = new ToolStripMenuItem();
            tsm_Proximo = new ToolStripMenuItem();
            tsm_Pesquisa = new ToolStripMenuItem();
            txt_Usuario = new ToolStripTextBox();
            tsm_Usuario = new ToolStripMenuItem();
            tsm_Excluir = new ToolStripMenuItem();
            lbl_VlPermissao = new Label();
            txt_Tel1 = new TextBox();
            txt_Tel2 = new TextBox();
            txt_Razao = new TextBox();
            label12 = new Label();
            txt_Cidade = new TextBox();
            txt_DocNum = new TextBox();
            txt_TipoCont = new TextBox();
            txt_Pix = new TextBox();
            label22 = new Label();
            txt_Obs = new TextBox();
            label23 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbx_Estado
            // 
            cbx_Estado.AutoCompleteMode = AutoCompleteMode.Append;
            cbx_Estado.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Estado.Enabled = false;
            cbx_Estado.FormattingEnabled = true;
            cbx_Estado.Items.AddRange(new object[] { "MG", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbx_Estado.Location = new Point(363, 156);
            cbx_Estado.Margin = new Padding(4, 3, 4, 3);
            cbx_Estado.Name = "cbx_Estado";
            cbx_Estado.Size = new Size(46, 23);
            cbx_Estado.TabIndex = 1;
            cbx_Estado.SelectedIndexChanged += Cbx_estado_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(359, 137);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 40;
            label7.Text = "Estado";
            // 
            // txt_Cep
            // 
            txt_Cep.Enabled = false;
            txt_Cep.Location = new Point(292, 156);
            txt_Cep.Margin = new Padding(4, 3, 4, 3);
            txt_Cep.MaxLength = 8;
            txt_Cep.Name = "txt_Cep";
            txt_Cep.Size = new Size(63, 23);
            txt_Cep.TabIndex = 6;
            txt_Cep.Text = "32072010";
            // 
            // txt_Rua
            // 
            txt_Rua.Enabled = false;
            txt_Rua.Location = new Point(22, 156);
            txt_Rua.Margin = new Padding(4, 3, 4, 3);
            txt_Rua.Name = "txt_Rua";
            txt_Rua.Size = new Size(201, 23);
            txt_Rua.TabIndex = 4;
            // 
            // txt_Fantasia
            // 
            txt_Fantasia.Enabled = false;
            txt_Fantasia.Location = new Point(147, 112);
            txt_Fantasia.Margin = new Padding(4, 3, 4, 3);
            txt_Fantasia.Name = "txt_Fantasia";
            txt_Fantasia.Size = new Size(703, 23);
            txt_Fantasia.TabIndex = 0;
            // 
            // txt_Id
            // 
            txt_Id.Enabled = false;
            txt_Id.Location = new Point(22, 67);
            txt_Id.Margin = new Padding(4, 3, 4, 3);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(38, 23);
            txt_Id.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(21, 138);
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
            label5.Location = new Point(289, 138);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 32;
            label5.Text = "CEP";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(310, 181);
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
            label3.Location = new Point(199, 182);
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
            label2.Location = new Point(147, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 29;
            label2.Text = "Nome Fantasia";
            // 
            // label1
            // 
            label1.Location = new Point(2, 377);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 57;
            // 
            // txt_Bairro
            // 
            txt_Bairro.Enabled = false;
            txt_Bairro.Location = new Point(603, 156);
            txt_Bairro.Margin = new Padding(4, 3, 4, 3);
            txt_Bairro.Name = "txt_Bairro";
            txt_Bairro.Size = new Size(247, 23);
            txt_Bairro.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(602, 137);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 44;
            label8.Text = "Bairro";
            // 
            // txt_Contato
            // 
            txt_Contato.Enabled = false;
            txt_Contato.Location = new Point(20, 200);
            txt_Contato.Margin = new Padding(4, 3, 4, 3);
            txt_Contato.Name = "txt_Contato";
            txt_Contato.Size = new Size(175, 23);
            txt_Contato.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(20, 182);
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
            label10.Location = new Point(409, 137);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 58;
            label10.Text = "Cidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(21, 232);
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
            label13.Location = new Point(264, 231);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 70;
            label13.Text = "Operação";
            // 
            // txt_Op
            // 
            txt_Op.Enabled = false;
            txt_Op.Location = new Point(267, 250);
            txt_Op.Margin = new Padding(4, 3, 4, 3);
            txt_Op.Name = "txt_Op";
            txt_Op.Size = new Size(103, 23);
            txt_Op.TabIndex = 14;
            // 
            // txt_Ag
            // 
            txt_Ag.Enabled = false;
            txt_Ag.Location = new Point(144, 250);
            txt_Ag.Margin = new Padding(4, 3, 4, 3);
            txt_Ag.Name = "txt_Ag";
            txt_Ag.Size = new Size(115, 23);
            txt_Ag.TabIndex = 13;
            // 
            // txt_Ct
            // 
            txt_Ct.Enabled = false;
            txt_Ct.Location = new Point(378, 250);
            txt_Ct.Margin = new Padding(4, 3, 4, 3);
            txt_Ct.Name = "txt_Ct";
            txt_Ct.Size = new Size(174, 23);
            txt_Ct.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(140, 231);
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
            label15.Location = new Point(369, 231);
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
            label16.Location = new Point(21, 94);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 72;
            label16.Text = "CNPJ / CPF";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(23, 48);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(18, 15);
            label17.TabIndex = 73;
            label17.Text = "ID";
            label17.Click += label17_Click;
            // 
            // txt_Email
            // 
            txt_Email.Enabled = false;
            txt_Email.Location = new Point(435, 200);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(144, 23);
            txt_Email.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(432, 181);
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
            label19.Location = new Point(230, 138);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(21, 15);
            label19.TabIndex = 78;
            label19.Text = "Nº";
            // 
            // txt_Num
            // 
            txt_Num.Enabled = false;
            txt_Num.Location = new Point(229, 156);
            txt_Num.Margin = new Padding(4, 3, 4, 3);
            txt_Num.Name = "txt_Num";
            txt_Num.Size = new Size(55, 23);
            txt_Num.TabIndex = 5;
            // 
            // txt_Site
            // 
            txt_Site.Enabled = false;
            txt_Site.Location = new Point(587, 200);
            txt_Site.Margin = new Padding(4, 3, 4, 3);
            txt_Site.Name = "txt_Site";
            txt_Site.Size = new Size(263, 23);
            txt_Site.TabIndex = 17;
            txt_Site.TextChanged += Txt_site_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Gray;
            label20.Location = new Point(587, 181);
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
            lkl_site.Location = new Point(25, 376);
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
            chx_editar.Location = new Point(690, 31);
            chx_editar.Margin = new Padding(4, 3, 4, 3);
            chx_editar.Name = "chx_editar";
            chx_editar.Size = new Size(63, 19);
            chx_editar.TabIndex = 82;
            chx_editar.Text = "EDITAR";
            chx_editar.UseVisualStyleBackColor = true;
            chx_editar.Visible = false;
            // 
            // cbx_Status
            // 
            cbx_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Status.Enabled = false;
            cbx_Status.FormattingEnabled = true;
            cbx_Status.Location = new Point(676, 377);
            cbx_Status.Margin = new Padding(4, 3, 4, 3);
            cbx_Status.Name = "cbx_Status";
            cbx_Status.Size = new Size(174, 23);
            cbx_Status.Sorted = true;
            cbx_Status.TabIndex = 18;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Gray;
            label21.Location = new Point(673, 358);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(39, 15);
            label21.TabIndex = 83;
            label21.Text = "Status";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsm_Novo, tsm_Editar, tsm_Salvar, tsm_Cancelar, tsm_Anterior, tsm_Proximo, tsm_Pesquisa, txt_Usuario, tsm_Usuario, tsm_Excluir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(862, 27);
            menuStrip1.TabIndex = 87;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Novo
            // 
            tsm_Novo.Name = "tsm_Novo";
            tsm_Novo.Size = new Size(48, 23);
            tsm_Novo.Text = "Novo";
            tsm_Novo.Click += Tsm_novo_Click;
            // 
            // tsm_Editar
            // 
            tsm_Editar.Name = "tsm_Editar";
            tsm_Editar.Size = new Size(49, 23);
            tsm_Editar.Text = "Editar";
            tsm_Editar.Click += Tsm_editar_Click;
            // 
            // tsm_Salvar
            // 
            tsm_Salvar.Name = "tsm_Salvar";
            tsm_Salvar.Size = new Size(50, 23);
            tsm_Salvar.Text = "Salvar";
            tsm_Salvar.Click += Tsm_salvar_Click;
            // 
            // tsm_Cancelar
            // 
            tsm_Cancelar.Name = "tsm_Cancelar";
            tsm_Cancelar.Size = new Size(65, 23);
            tsm_Cancelar.Text = "Cancelar";
            tsm_Cancelar.Click += Tsm_cancelar_Click;
            // 
            // tsm_Anterior
            // 
            tsm_Anterior.Name = "tsm_Anterior";
            tsm_Anterior.Size = new Size(62, 23);
            tsm_Anterior.Text = "Anterior";
            tsm_Anterior.Click += Tsm_anterior_Click;
            // 
            // tsm_Proximo
            // 
            tsm_Proximo.Name = "tsm_Proximo";
            tsm_Proximo.Size = new Size(64, 23);
            tsm_Proximo.Text = "Proximo";
            tsm_Proximo.Click += Tsm_proximo_Click;
            // 
            // tsm_Pesquisa
            // 
            tsm_Pesquisa.Name = "tsm_Pesquisa";
            tsm_Pesquisa.Size = new Size(65, 23);
            tsm_Pesquisa.Text = "Pesquisa";
            tsm_Pesquisa.Click += Tsm_pesquisa_Click;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Alignment = ToolStripItemAlignment.Right;
            txt_Usuario.Enabled = false;
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(116, 23);
            // 
            // tsm_Usuario
            // 
            tsm_Usuario.Alignment = ToolStripItemAlignment.Right;
            tsm_Usuario.Name = "tsm_Usuario";
            tsm_Usuario.Size = new Size(59, 23);
            tsm_Usuario.Text = "Usuario";
            // 
            // tsm_Excluir
            // 
            tsm_Excluir.Name = "tsm_Excluir";
            tsm_Excluir.Size = new Size(54, 23);
            tsm_Excluir.Text = "Excluir";
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
            // txt_Tel1
            // 
            txt_Tel1.Enabled = false;
            txt_Tel1.Location = new Point(203, 200);
            txt_Tel1.Margin = new Padding(4, 3, 4, 3);
            txt_Tel1.Name = "txt_Tel1";
            txt_Tel1.Size = new Size(100, 23);
            txt_Tel1.TabIndex = 149;
            // 
            // txt_Tel2
            // 
            txt_Tel2.Enabled = false;
            txt_Tel2.Location = new Point(311, 200);
            txt_Tel2.Margin = new Padding(4, 3, 4, 3);
            txt_Tel2.Name = "txt_Tel2";
            txt_Tel2.Size = new Size(116, 23);
            txt_Tel2.TabIndex = 150;
            // 
            // txt_Razao
            // 
            txt_Razao.Enabled = false;
            txt_Razao.Location = new Point(66, 67);
            txt_Razao.Margin = new Padding(4, 3, 4, 3);
            txt_Razao.Name = "txt_Razao";
            txt_Razao.Size = new Size(783, 23);
            txt_Razao.TabIndex = 151;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(64, 48);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 152;
            label12.Text = "Razão Social";
            // 
            // txt_Cidade
            // 
            txt_Cidade.Enabled = false;
            txt_Cidade.Location = new Point(414, 156);
            txt_Cidade.Margin = new Padding(4, 3, 4, 3);
            txt_Cidade.Name = "txt_Cidade";
            txt_Cidade.Size = new Size(181, 23);
            txt_Cidade.TabIndex = 153;
            // 
            // txt_DocNum
            // 
            txt_DocNum.Enabled = false;
            txt_DocNum.Location = new Point(22, 112);
            txt_DocNum.Margin = new Padding(4, 3, 4, 3);
            txt_DocNum.Name = "txt_DocNum";
            txt_DocNum.Size = new Size(117, 23);
            txt_DocNum.TabIndex = 154;
            txt_DocNum.Leave += txt_DocNum_Leave;
            // 
            // txt_TipoCont
            // 
            txt_TipoCont.Enabled = false;
            txt_TipoCont.Location = new Point(21, 250);
            txt_TipoCont.Margin = new Padding(4, 3, 4, 3);
            txt_TipoCont.Name = "txt_TipoCont";
            txt_TipoCont.Size = new Size(115, 23);
            txt_TipoCont.TabIndex = 155;
            // 
            // txt_Pix
            // 
            txt_Pix.Enabled = false;
            txt_Pix.Location = new Point(560, 250);
            txt_Pix.Margin = new Padding(4, 3, 4, 3);
            txt_Pix.Name = "txt_Pix";
            txt_Pix.Size = new Size(289, 23);
            txt_Pix.TabIndex = 156;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Gray;
            label22.Location = new Point(551, 231);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(23, 15);
            label22.TabIndex = 157;
            label22.Text = "Pix";
            // 
            // txt_Obs
            // 
            txt_Obs.Enabled = false;
            txt_Obs.Location = new Point(20, 297);
            txt_Obs.Margin = new Padding(4, 3, 4, 3);
            txt_Obs.Multiline = true;
            txt_Obs.Name = "txt_Obs";
            txt_Obs.Size = new Size(830, 58);
            txt_Obs.TabIndex = 159;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Gray;
            label23.Location = new Point(20, 279);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(28, 15);
            label23.TabIndex = 158;
            label23.Text = "Obs";
            // 
            // frm_FornecedorCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(862, 424);
            Controls.Add(txt_Obs);
            Controls.Add(label23);
            Controls.Add(txt_Pix);
            Controls.Add(label22);
            Controls.Add(txt_TipoCont);
            Controls.Add(txt_DocNum);
            Controls.Add(txt_Cidade);
            Controls.Add(txt_Razao);
            Controls.Add(label12);
            Controls.Add(txt_Tel2);
            Controls.Add(txt_Tel1);
            Controls.Add(lbl_VlPermissao);
            Controls.Add(cbx_Status);
            Controls.Add(label21);
            Controls.Add(chx_editar);
            Controls.Add(lkl_site);
            Controls.Add(txt_Site);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(txt_Num);
            Controls.Add(txt_Email);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(txt_Op);
            Controls.Add(txt_Ag);
            Controls.Add(txt_Ct);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_Contato);
            Controls.Add(txt_Bairro);
            Controls.Add(label8);
            Controls.Add(cbx_Estado);
            Controls.Add(label7);
            Controls.Add(txt_Cep);
            Controls.Add(txt_Rua);
            Controls.Add(txt_Fantasia);
            Controls.Add(txt_Id);
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
            MaximumSize = new Size(878, 463);
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
        private ComboBox cbx_Estado;
        private Label label7;
        private TextBox txt_Cep;
        private TextBox txt_Rua;
        private TextBox txt_Fantasia;
        private TextBox txt_Id;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Bairro;
        private Label label8;
        private TextBox txt_Contato;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private TextBox txt_Op;
        private TextBox txt_Ag;
        private TextBox txt_Ct;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txt_Email;
        private Label label18;
        private Label label19;
        private TextBox txt_Num;
        private TextBox txt_Site;
        private Label label20;
        private LinkLabel lkl_site;
        private CheckBox chx_editar;
        private ComboBox cbx_Status;
        private Label label21;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsm_Novo;
        private ToolStripMenuItem tsm_Editar;
        private ToolStripMenuItem tsm_Salvar;
        private ToolStripMenuItem tsm_Cancelar;
        private ToolStripMenuItem tsm_Anterior;
        private ToolStripMenuItem tsm_Proximo;
        private ToolStripMenuItem tsm_Pesquisa;
        private ToolStripTextBox txt_Usuario;
        private ToolStripMenuItem tsm_Usuario;
        private Label lbl_VlPermissao;
        private TextBox txt_Tel1;
        private TextBox txt_Tel2;
        private TextBox txt_Razao;
        private Label label12;
        private TextBox txt_Cidade;
        private TextBox txt_DocNum;
        private TextBox txt_TipoCont;
        private ToolStripMenuItem tsm_Excluir;
        private TextBox txt_Pix;
        private Label label22;
        private TextBox txt_Obs;
        private Label label23;
    }
}