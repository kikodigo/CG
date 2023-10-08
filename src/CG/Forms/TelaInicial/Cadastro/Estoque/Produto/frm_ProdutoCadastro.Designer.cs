namespace CG
{
    partial class frm_ProdutoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProdutoCadastro));
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_EstAtual = new System.Windows.Forms.Label();
            this.lbl_EstMinimo = new System.Windows.Forms.Label();
            this.lbl_CA = new System.Windows.Forms.Label();
            this.lbl_PrCusto = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_EstoqueAtual = new System.Windows.Forms.TextBox();
            this.txt_PrCusto = new System.Windows.Forms.TextBox();
            this.txt_EstoqueMinimo = new System.Windows.Forms.TextBox();
            this.txt_ca = new System.Windows.Forms.TextBox();
            this.lbl_Classe = new System.Windows.Forms.Label();
            this.cbx_classe = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Unidade = new System.Windows.Forms.Label();
            this.cbx_ativo = new System.Windows.Forms.ComboBox();
            this.lbl_Ativo = new System.Windows.Forms.Label();
            this.chx_editar = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.btn_SelecionarFoto = new System.Windows.Forms.Button();
            this.btn_ExcluirFoto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gpb_Itens = new System.Windows.Forms.GroupBox();
            this.dgv_contratos = new System.Windows.Forms.DataGridView();
            this.btn_remover = new System.Windows.Forms.Button();
            this.cbx_contratos = new System.Windows.Forms.ComboBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tb_Imagem = new System.Windows.Forms.TabPage();
            this.chx_CarregarFoto = new System.Windows.Forms.CheckBox();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.tb_Contrato = new System.Windows.Forms.TabPage();
            this.tb_Patrimonio = new System.Windows.Forms.TabPage();
            this.tb_CdExt = new System.Windows.Forms.TabPage();
            this.btn_ExCodExt = new System.Windows.Forms.Button();
            this.lbl_CodExtCod = new System.Windows.Forms.Label();
            this.lbl_CodExtFornec = new System.Windows.Forms.Label();
            this.txt_CodExtCod = new System.Windows.Forms.TextBox();
            this.cbx_CodExtForne = new System.Windows.Forms.ComboBox();
            this.btn_ExcCodExt = new System.Windows.Forms.Button();
            this.btn_AddCodExt = new System.Windows.Forms.Button();
            this.lbl_CodClasse = new System.Windows.Forms.Label();
            this.lbl_CodUnidade = new System.Windows.Forms.Label();
            this.cbx_Unidade = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_Ncm = new System.Windows.Forms.TextBox();
            this.lbl_Ncm = new System.Windows.Forms.Label();
            this.dgv_CodExt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpb_Itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contratos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Tb_Imagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.tb_Contrato.SuspendLayout();
            this.tb_Patrimonio.SuspendLayout();
            this.tb_CdExt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CodExt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Cod.Location = new System.Drawing.Point(18, 50);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cod.TabIndex = 6;
            this.lbl_Cod.Text = "Codigo";
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Descricao.Location = new System.Drawing.Point(101, 50);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_Descricao.TabIndex = 7;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // lbl_EstAtual
            // 
            this.lbl_EstAtual.AutoSize = true;
            this.lbl_EstAtual.ForeColor = System.Drawing.Color.Gray;
            this.lbl_EstAtual.Location = new System.Drawing.Point(280, 97);
            this.lbl_EstAtual.Name = "lbl_EstAtual";
            this.lbl_EstAtual.Size = new System.Drawing.Size(52, 13);
            this.lbl_EstAtual.TabIndex = 8;
            this.lbl_EstAtual.Text = "Est. Atual";
            // 
            // lbl_EstMinimo
            // 
            this.lbl_EstMinimo.AutoSize = true;
            this.lbl_EstMinimo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_EstMinimo.Location = new System.Drawing.Point(393, 96);
            this.lbl_EstMinimo.Name = "lbl_EstMinimo";
            this.lbl_EstMinimo.Size = new System.Drawing.Size(61, 13);
            this.lbl_EstMinimo.TabIndex = 9;
            this.lbl_EstMinimo.Text = "Est. Minimo";
            // 
            // lbl_CA
            // 
            this.lbl_CA.AutoSize = true;
            this.lbl_CA.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CA.Location = new System.Drawing.Point(478, 50);
            this.lbl_CA.Name = "lbl_CA";
            this.lbl_CA.Size = new System.Drawing.Size(27, 13);
            this.lbl_CA.TabIndex = 10;
            this.lbl_CA.Text = "C.A.";
            // 
            // lbl_PrCusto
            // 
            this.lbl_PrCusto.AutoSize = true;
            this.lbl_PrCusto.ForeColor = System.Drawing.Color.Gray;
            this.lbl_PrCusto.Location = new System.Drawing.Point(382, 50);
            this.lbl_PrCusto.Name = "lbl_PrCusto";
            this.lbl_PrCusto.Size = new System.Drawing.Size(80, 13);
            this.lbl_PrCusto.TabIndex = 11;
            this.lbl_PrCusto.Text = "Preço de Custo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_codigo.Location = new System.Drawing.Point(21, 66);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(81, 20);
            this.txt_codigo.TabIndex = 12;
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.SystemColors.Window;
            this.txt_descricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_descricao.Enabled = false;
            this.txt_descricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_descricao.Location = new System.Drawing.Point(103, 66);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(276, 20);
            this.txt_descricao.TabIndex = 13;
            // 
            // txt_EstoqueAtual
            // 
            this.txt_EstoqueAtual.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EstoqueAtual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EstoqueAtual.Enabled = false;
            this.txt_EstoqueAtual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_EstoqueAtual.Location = new System.Drawing.Point(282, 113);
            this.txt_EstoqueAtual.Name = "txt_EstoqueAtual";
            this.txt_EstoqueAtual.Size = new System.Drawing.Size(113, 20);
            this.txt_EstoqueAtual.TabIndex = 14;
            // 
            // txt_PrCusto
            // 
            this.txt_PrCusto.BackColor = System.Drawing.SystemColors.Window;
            this.txt_PrCusto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PrCusto.Enabled = false;
            this.txt_PrCusto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_PrCusto.Location = new System.Drawing.Point(380, 66);
            this.txt_PrCusto.Name = "txt_PrCusto";
            this.txt_PrCusto.Size = new System.Drawing.Size(99, 20);
            this.txt_PrCusto.TabIndex = 15;
            // 
            // txt_EstoqueMinimo
            // 
            this.txt_EstoqueMinimo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EstoqueMinimo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EstoqueMinimo.Enabled = false;
            this.txt_EstoqueMinimo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_EstoqueMinimo.Location = new System.Drawing.Point(396, 113);
            this.txt_EstoqueMinimo.Name = "txt_EstoqueMinimo";
            this.txt_EstoqueMinimo.Size = new System.Drawing.Size(113, 20);
            this.txt_EstoqueMinimo.TabIndex = 16;
            // 
            // txt_ca
            // 
            this.txt_ca.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ca.Enabled = false;
            this.txt_ca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ca.Location = new System.Drawing.Point(480, 66);
            this.txt_ca.Name = "txt_ca";
            this.txt_ca.Size = new System.Drawing.Size(129, 20);
            this.txt_ca.TabIndex = 17;
            // 
            // lbl_Classe
            // 
            this.lbl_Classe.AutoSize = true;
            this.lbl_Classe.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Classe.Location = new System.Drawing.Point(18, 96);
            this.lbl_Classe.Name = "lbl_Classe";
            this.lbl_Classe.Size = new System.Drawing.Size(38, 13);
            this.lbl_Classe.TabIndex = 18;
            this.lbl_Classe.Text = "Classe";
            // 
            // cbx_classe
            // 
            this.cbx_classe.BackColor = System.Drawing.SystemColors.Window;
            this.cbx_classe.Enabled = false;
            this.cbx_classe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbx_classe.Location = new System.Drawing.Point(21, 112);
            this.cbx_classe.Name = "cbx_classe";
            this.cbx_classe.Size = new System.Drawing.Size(133, 21);
            this.cbx_classe.TabIndex = 19;
            this.cbx_classe.SelectedIndexChanged += new System.EventHandler(this.cbx_classe_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 120);
            this.dataGridView1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Patrimonio";
            // 
            // lbl_Unidade
            // 
            this.lbl_Unidade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Unidade.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Unidade.Location = new System.Drawing.Point(152, 96);
            this.lbl_Unidade.Name = "lbl_Unidade";
            this.lbl_Unidade.Size = new System.Drawing.Size(100, 13);
            this.lbl_Unidade.TabIndex = 28;
            this.lbl_Unidade.Text = "Unidade";
            // 
            // cbx_ativo
            // 
            this.cbx_ativo.BackColor = System.Drawing.SystemColors.Window;
            this.cbx_ativo.Enabled = false;
            this.cbx_ativo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbx_ativo.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.cbx_ativo.Location = new System.Drawing.Point(512, 113);
            this.cbx_ativo.Name = "cbx_ativo";
            this.cbx_ativo.Size = new System.Drawing.Size(97, 21);
            this.cbx_ativo.TabIndex = 27;
            // 
            // lbl_Ativo
            // 
            this.lbl_Ativo.AutoSize = true;
            this.lbl_Ativo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ativo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Ativo.Location = new System.Drawing.Point(509, 97);
            this.lbl_Ativo.Name = "lbl_Ativo";
            this.lbl_Ativo.Size = new System.Drawing.Size(31, 13);
            this.lbl_Ativo.TabIndex = 26;
            this.lbl_Ativo.Text = "Ativo";
            // 
            // chx_editar
            // 
            this.chx_editar.AutoSize = true;
            this.chx_editar.Location = new System.Drawing.Point(481, 30);
            this.chx_editar.Name = "chx_editar";
            this.chx_editar.Size = new System.Drawing.Size(66, 17);
            this.chx_editar.TabIndex = 29;
            this.chx_editar.Text = "EDIÇÃO";
            this.chx_editar.UseVisualStyleBackColor = true;
            this.chx_editar.Visible = false;
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
            this.tsm_pesquisar,
            this.tsm_excluir,
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 27);
            this.menuStrip1.TabIndex = 30;
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
            // tsm_pesquisar
            // 
            this.tsm_pesquisar.Name = "tsm_pesquisar";
            this.tsm_pesquisar.Size = new System.Drawing.Size(65, 23);
            this.tsm_pesquisar.Text = "Pesquisa";
            this.tsm_pesquisar.Click += new System.EventHandler(this.Tsm_pesquisar_Click);
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
            this.Usuario.Size = new System.Drawing.Size(62, 23);
            this.Usuario.Text = "Usuário:";
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(546, 28);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 31;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // btn_SelecionarFoto
            // 
            this.btn_SelecionarFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SelecionarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SelecionarFoto.Enabled = false;
            this.btn_SelecionarFoto.FlatAppearance.BorderSize = 0;
            this.btn_SelecionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelecionarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelecionarFoto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SelecionarFoto.Location = new System.Drawing.Point(6, 423);
            this.btn_SelecionarFoto.Name = "btn_SelecionarFoto";
            this.btn_SelecionarFoto.Size = new System.Drawing.Size(221, 33);
            this.btn_SelecionarFoto.TabIndex = 32;
            this.btn_SelecionarFoto.Text = "Selecionar foto";
            this.btn_SelecionarFoto.UseVisualStyleBackColor = false;
            this.btn_SelecionarFoto.Click += new System.EventHandler(this.Btn_CarregarFoto_Click);
            // 
            // btn_ExcluirFoto
            // 
            this.btn_ExcluirFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExcluirFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ExcluirFoto.Enabled = false;
            this.btn_ExcluirFoto.FlatAppearance.BorderSize = 0;
            this.btn_ExcluirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirFoto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ExcluirFoto.Location = new System.Drawing.Point(233, 423);
            this.btn_ExcluirFoto.Name = "btn_ExcluirFoto";
            this.btn_ExcluirFoto.Size = new System.Drawing.Size(226, 33);
            this.btn_ExcluirFoto.TabIndex = 33;
            this.btn_ExcluirFoto.Text = "Excluir foto";
            this.btn_ExcluirFoto.UseVisualStyleBackColor = false;
            this.btn_ExcluirFoto.Click += new System.EventHandler(this.Btn_ExcluirFoto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 147;
            this.label11.Visible = false;
            // 
            // gpb_Itens
            // 
            this.gpb_Itens.Controls.Add(this.dgv_contratos);
            this.gpb_Itens.Controls.Add(this.btn_remover);
            this.gpb_Itens.Controls.Add(this.cbx_contratos);
            this.gpb_Itens.Controls.Add(this.btn_adicionar);
            this.gpb_Itens.ForeColor = System.Drawing.Color.Gray;
            this.gpb_Itens.Location = new System.Drawing.Point(6, 6);
            this.gpb_Itens.Name = "gpb_Itens";
            this.gpb_Itens.Size = new System.Drawing.Size(569, 252);
            this.gpb_Itens.TabIndex = 151;
            this.gpb_Itens.TabStop = false;
            this.gpb_Itens.Text = "Contratos";
            // 
            // dgv_contratos
            // 
            this.dgv_contratos.AllowUserToAddRows = false;
            this.dgv_contratos.AllowUserToDeleteRows = false;
            this.dgv_contratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_contratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contratos.Location = new System.Drawing.Point(6, 83);
            this.dgv_contratos.Name = "dgv_contratos";
            this.dgv_contratos.ReadOnly = true;
            this.dgv_contratos.RowHeadersVisible = false;
            this.dgv_contratos.Size = new System.Drawing.Size(557, 163);
            this.dgv_contratos.TabIndex = 146;
            // 
            // btn_remover
            // 
            this.btn_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_remover.Enabled = false;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_remover.Location = new System.Drawing.Point(301, 48);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(262, 29);
            this.btn_remover.TabIndex = 149;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            // 
            // cbx_contratos
            // 
            this.cbx_contratos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_contratos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_contratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_contratos.FormattingEnabled = true;
            this.cbx_contratos.Location = new System.Drawing.Point(6, 19);
            this.cbx_contratos.Name = "cbx_contratos";
            this.cbx_contratos.Size = new System.Drawing.Size(557, 23);
            this.cbx_contratos.TabIndex = 147;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_adicionar.Enabled = false;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_adicionar.Location = new System.Drawing.Point(6, 48);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(289, 29);
            this.btn_adicionar.TabIndex = 148;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tb_Imagem);
            this.tabControl1.Controls.Add(this.tb_Contrato);
            this.tabControl1.Controls.Add(this.tb_Patrimonio);
            this.tabControl1.Controls.Add(this.tb_CdExt);
            this.tabControl1.Location = new System.Drawing.Point(21, 181);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 488);
            this.tabControl1.TabIndex = 152;
            // 
            // Tb_Imagem
            // 
            this.Tb_Imagem.BackColor = System.Drawing.Color.DimGray;
            this.Tb_Imagem.Controls.Add(this.chx_CarregarFoto);
            this.Tb_Imagem.Controls.Add(this.txt_image);
            this.Tb_Imagem.Controls.Add(this.pb_Foto);
            this.Tb_Imagem.Controls.Add(this.btn_SelecionarFoto);
            this.Tb_Imagem.Controls.Add(this.btn_ExcluirFoto);
            this.Tb_Imagem.Location = new System.Drawing.Point(4, 22);
            this.Tb_Imagem.Name = "Tb_Imagem";
            this.Tb_Imagem.Padding = new System.Windows.Forms.Padding(3);
            this.Tb_Imagem.Size = new System.Drawing.Size(581, 462);
            this.Tb_Imagem.TabIndex = 0;
            this.Tb_Imagem.Text = "Imagem";
            // 
            // chx_CarregarFoto
            // 
            this.chx_CarregarFoto.AutoSize = true;
            this.chx_CarregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_CarregarFoto.Location = new System.Drawing.Point(462, 428);
            this.chx_CarregarFoto.Name = "chx_CarregarFoto";
            this.chx_CarregarFoto.Size = new System.Drawing.Size(118, 20);
            this.chx_CarregarFoto.TabIndex = 36;
            this.chx_CarregarFoto.Text = "Carregar foto";
            this.chx_CarregarFoto.UseVisualStyleBackColor = true;
            this.chx_CarregarFoto.CheckedChanged += new System.EventHandler(this.chx_CarregarFoto_CheckedChanged);
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(6, 397);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(128, 20);
            this.txt_image.TabIndex = 35;
            this.txt_image.Visible = false;
            // 
            // pb_Foto
            // 
            this.pb_Foto.Location = new System.Drawing.Point(3, 6);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(575, 411);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Foto.TabIndex = 34;
            this.pb_Foto.TabStop = false;
            // 
            // tb_Contrato
            // 
            this.tb_Contrato.BackColor = System.Drawing.Color.DimGray;
            this.tb_Contrato.Controls.Add(this.gpb_Itens);
            this.tb_Contrato.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Contrato.Location = new System.Drawing.Point(4, 22);
            this.tb_Contrato.Name = "tb_Contrato";
            this.tb_Contrato.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Contrato.Size = new System.Drawing.Size(581, 462);
            this.tb_Contrato.TabIndex = 1;
            this.tb_Contrato.Text = "Contratos";
            // 
            // tb_Patrimonio
            // 
            this.tb_Patrimonio.BackColor = System.Drawing.Color.DimGray;
            this.tb_Patrimonio.Controls.Add(this.label8);
            this.tb_Patrimonio.Controls.Add(this.dataGridView1);
            this.tb_Patrimonio.Location = new System.Drawing.Point(4, 22);
            this.tb_Patrimonio.Name = "tb_Patrimonio";
            this.tb_Patrimonio.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Patrimonio.Size = new System.Drawing.Size(581, 462);
            this.tb_Patrimonio.TabIndex = 2;
            this.tb_Patrimonio.Text = "Patrimônio";
            // 
            // tb_CdExt
            // 
            this.tb_CdExt.BackColor = System.Drawing.Color.DimGray;
            this.tb_CdExt.Controls.Add(this.dgv_CodExt);
            this.tb_CdExt.Controls.Add(this.btn_ExCodExt);
            this.tb_CdExt.Controls.Add(this.lbl_CodExtCod);
            this.tb_CdExt.Controls.Add(this.lbl_CodExtFornec);
            this.tb_CdExt.Controls.Add(this.txt_CodExtCod);
            this.tb_CdExt.Controls.Add(this.cbx_CodExtForne);
            this.tb_CdExt.Controls.Add(this.btn_ExcCodExt);
            this.tb_CdExt.Controls.Add(this.btn_AddCodExt);
            this.tb_CdExt.ForeColor = System.Drawing.Color.White;
            this.tb_CdExt.Location = new System.Drawing.Point(4, 22);
            this.tb_CdExt.Name = "tb_CdExt";
            this.tb_CdExt.Padding = new System.Windows.Forms.Padding(3);
            this.tb_CdExt.Size = new System.Drawing.Size(581, 462);
            this.tb_CdExt.TabIndex = 3;
            this.tb_CdExt.Text = "Codigo Externo";
            // 
            // btn_ExCodExt
            // 
            this.btn_ExCodExt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExCodExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ExCodExt.Enabled = false;
            this.btn_ExCodExt.FlatAppearance.BorderSize = 0;
            this.btn_ExCodExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExCodExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExCodExt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ExCodExt.Location = new System.Drawing.Point(431, 50);
            this.btn_ExCodExt.Name = "btn_ExCodExt";
            this.btn_ExCodExt.Size = new System.Drawing.Size(144, 33);
            this.btn_ExCodExt.TabIndex = 173;
            this.btn_ExCodExt.Text = "Ex. Cod. Externo";
            this.btn_ExCodExt.UseVisualStyleBackColor = false;
            this.btn_ExCodExt.Click += new System.EventHandler(this.btn_ExCodExt_Click);
            // 
            // lbl_CodExtCod
            // 
            this.lbl_CodExtCod.AutoSize = true;
            this.lbl_CodExtCod.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CodExtCod.Location = new System.Drawing.Point(294, 7);
            this.lbl_CodExtCod.Name = "lbl_CodExtCod";
            this.lbl_CodExtCod.Size = new System.Drawing.Size(79, 13);
            this.lbl_CodExtCod.TabIndex = 172;
            this.lbl_CodExtCod.Text = "Codigo Externo";
            // 
            // lbl_CodExtFornec
            // 
            this.lbl_CodExtFornec.AutoSize = true;
            this.lbl_CodExtFornec.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CodExtFornec.Location = new System.Drawing.Point(6, 7);
            this.lbl_CodExtFornec.Name = "lbl_CodExtFornec";
            this.lbl_CodExtFornec.Size = new System.Drawing.Size(61, 13);
            this.lbl_CodExtFornec.TabIndex = 156;
            this.lbl_CodExtFornec.Text = "Fornecedor";
            // 
            // txt_CodExtCod
            // 
            this.txt_CodExtCod.Location = new System.Drawing.Point(297, 23);
            this.txt_CodExtCod.Name = "txt_CodExtCod";
            this.txt_CodExtCod.Size = new System.Drawing.Size(278, 20);
            this.txt_CodExtCod.TabIndex = 171;
            // 
            // cbx_CodExtForne
            // 
            this.cbx_CodExtForne.FormattingEnabled = true;
            this.cbx_CodExtForne.Location = new System.Drawing.Point(6, 23);
            this.cbx_CodExtForne.Name = "cbx_CodExtForne";
            this.cbx_CodExtForne.Size = new System.Drawing.Size(278, 21);
            this.cbx_CodExtForne.TabIndex = 170;
            // 
            // btn_ExcCodExt
            // 
            this.btn_ExcCodExt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExcCodExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ExcCodExt.Enabled = false;
            this.btn_ExcCodExt.FlatAppearance.BorderSize = 0;
            this.btn_ExcCodExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcCodExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcCodExt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ExcCodExt.Location = new System.Drawing.Point(219, 49);
            this.btn_ExcCodExt.Name = "btn_ExcCodExt";
            this.btn_ExcCodExt.Size = new System.Drawing.Size(207, 33);
            this.btn_ExcCodExt.TabIndex = 169;
            this.btn_ExcCodExt.Text = "Excluir";
            this.btn_ExcCodExt.UseVisualStyleBackColor = false;
            this.btn_ExcCodExt.Click += new System.EventHandler(this.Btn_ExcCodExt_Click);
            // 
            // btn_AddCodExt
            // 
            this.btn_AddCodExt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddCodExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddCodExt.Enabled = false;
            this.btn_AddCodExt.FlatAppearance.BorderSize = 0;
            this.btn_AddCodExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCodExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCodExt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_AddCodExt.Location = new System.Drawing.Point(6, 49);
            this.btn_AddCodExt.Name = "btn_AddCodExt";
            this.btn_AddCodExt.Size = new System.Drawing.Size(207, 33);
            this.btn_AddCodExt.TabIndex = 168;
            this.btn_AddCodExt.Text = "Adicionar";
            this.btn_AddCodExt.UseVisualStyleBackColor = false;
            this.btn_AddCodExt.Click += new System.EventHandler(this.btn_AddCodExt_Click);
            // 
            // lbl_CodClasse
            // 
            this.lbl_CodClasse.AutoSize = true;
            this.lbl_CodClasse.ForeColor = System.Drawing.Color.White;
            this.lbl_CodClasse.Location = new System.Drawing.Point(76, 97);
            this.lbl_CodClasse.Name = "lbl_CodClasse";
            this.lbl_CodClasse.Size = new System.Drawing.Size(40, 13);
            this.lbl_CodClasse.TabIndex = 153;
            this.lbl_CodClasse.Text = "Codigo";
            // 
            // lbl_CodUnidade
            // 
            this.lbl_CodUnidade.AutoSize = true;
            this.lbl_CodUnidade.ForeColor = System.Drawing.Color.White;
            this.lbl_CodUnidade.Location = new System.Drawing.Point(212, 96);
            this.lbl_CodUnidade.Name = "lbl_CodUnidade";
            this.lbl_CodUnidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_CodUnidade.TabIndex = 154;
            this.lbl_CodUnidade.Text = "Codigo";
            this.lbl_CodUnidade.Click += new System.EventHandler(this.lbl_CodUnidade_Click);
            // 
            // cbx_Unidade
            // 
            this.cbx_Unidade.Enabled = false;
            this.cbx_Unidade.FormattingEnabled = true;
            this.cbx_Unidade.Location = new System.Drawing.Point(155, 112);
            this.cbx_Unidade.Name = "cbx_Unidade";
            this.cbx_Unidade.Size = new System.Drawing.Size(121, 21);
            this.cbx_Unidade.TabIndex = 155;
            this.cbx_Unidade.SelectedIndexChanged += new System.EventHandler(this.cbx_Unidade_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_Ncm
            // 
            this.txt_Ncm.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Ncm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Ncm.Enabled = false;
            this.txt_Ncm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Ncm.Location = new System.Drawing.Point(21, 155);
            this.txt_Ncm.Name = "txt_Ncm";
            this.txt_Ncm.Size = new System.Drawing.Size(81, 20);
            this.txt_Ncm.TabIndex = 157;
            // 
            // lbl_Ncm
            // 
            this.lbl_Ncm.AutoSize = true;
            this.lbl_Ncm.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Ncm.Location = new System.Drawing.Point(18, 139);
            this.lbl_Ncm.Name = "lbl_Ncm";
            this.lbl_Ncm.Size = new System.Drawing.Size(31, 13);
            this.lbl_Ncm.TabIndex = 156;
            this.lbl_Ncm.Text = "NCM";
            // 
            // dgv_CodExt
            // 
            this.dgv_CodExt.AllowUserToAddRows = false;
            this.dgv_CodExt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CodExt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CodExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CodExt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CodExt.Location = new System.Drawing.Point(11, 88);
            this.dgv_CodExt.Name = "dgv_CodExt";
            this.dgv_CodExt.ReadOnly = true;
            this.dgv_CodExt.RowHeadersVisible = false;
            this.dgv_CodExt.Size = new System.Drawing.Size(564, 368);
            this.dgv_CodExt.TabIndex = 174;
            // 
            // frm_ProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(634, 681);
            this.Controls.Add(this.txt_Ncm);
            this.Controls.Add(this.lbl_Ncm);
            this.Controls.Add(this.cbx_Unidade);
            this.Controls.Add(this.lbl_CodUnidade);
            this.Controls.Add(this.lbl_CodClasse);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.chx_editar);
            this.Controls.Add(this.cbx_ativo);
            this.Controls.Add(this.lbl_Ativo);
            this.Controls.Add(this.lbl_Unidade);
            this.Controls.Add(this.cbx_classe);
            this.Controls.Add(this.lbl_Classe);
            this.Controls.Add(this.txt_ca);
            this.Controls.Add(this.txt_EstoqueMinimo);
            this.Controls.Add(this.txt_PrCusto);
            this.Controls.Add(this.txt_EstoqueAtual);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_PrCusto);
            this.Controls.Add(this.lbl_CA);
            this.Controls.Add(this.lbl_EstMinimo);
            this.Controls.Add(this.lbl_EstAtual);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ProdutoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.Frm_ProdutoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpb_Itens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contratos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Tb_Imagem.ResumeLayout(false);
            this.Tb_Imagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.tb_Contrato.ResumeLayout(false);
            this.tb_Patrimonio.ResumeLayout(false);
            this.tb_Patrimonio.PerformLayout();
            this.tb_CdExt.ResumeLayout(false);
            this.tb_CdExt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CodExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Label lbl_EstAtual;
        private System.Windows.Forms.Label lbl_EstMinimo;
        private System.Windows.Forms.Label lbl_CA;
        private System.Windows.Forms.Label lbl_PrCusto;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_EstoqueAtual;
        private System.Windows.Forms.TextBox txt_PrCusto;
        private System.Windows.Forms.TextBox txt_EstoqueMinimo;
        private System.Windows.Forms.TextBox txt_ca;
        private System.Windows.Forms.Label lbl_Classe;
        private System.Windows.Forms.ComboBox cbx_classe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Unidade;
        private System.Windows.Forms.ComboBox cbx_ativo;
        private System.Windows.Forms.Label lbl_Ativo;
        private System.Windows.Forms.CheckBox chx_editar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_novo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
        private System.Windows.Forms.Button btn_SelecionarFoto;
        private System.Windows.Forms.Button btn_ExcluirFoto;
        private System.Windows.Forms.PictureBox pb_Foto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpb_Itens;
        private System.Windows.Forms.DataGridView dgv_contratos;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.ComboBox cbx_contratos;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tb_Imagem;
        private System.Windows.Forms.TabPage tb_Contrato;
        private System.Windows.Forms.TabPage tb_Patrimonio;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.CheckBox chx_CarregarFoto;
        private System.Windows.Forms.Label lbl_CodClasse;
        private System.Windows.Forms.Label lbl_CodUnidade;
        private System.Windows.Forms.ComboBox cbx_Unidade;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tb_CdExt;
        private System.Windows.Forms.Label lbl_CodExtCod;
        private System.Windows.Forms.Label lbl_CodExtFornec;
        private System.Windows.Forms.TextBox txt_CodExtCod;
        private System.Windows.Forms.ComboBox cbx_CodExtForne;
        private System.Windows.Forms.Button btn_ExcCodExt;
        private System.Windows.Forms.Button btn_AddCodExt;
        private System.Windows.Forms.Button btn_ExCodExt;
        private System.Windows.Forms.TextBox txt_Ncm;
        private System.Windows.Forms.Label lbl_Ncm;
        private System.Windows.Forms.DataGridView dgv_CodExt;
    }
}