namespace CG
{
    partial class frm_ProdutoPostoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProdutoPostoCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CodigoPosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.cbx_Posto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NumeroLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CodigoContrato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CodigoCargo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_ProdutoPorPosto = new System.Windows.Forms.DataGridView();
            this.btn_InserirItem = new System.Windows.Forms.Button();
            this.btn_ExcluirItem = new System.Windows.Forms.Button();
            this.txt_NomeLocal = new System.Windows.Forms.TextBox();
            this.txt_NomeCargo = new System.Windows.Forms.TextBox();
            this.txt_NomeContrato = new System.Windows.Forms.TextBox();
            this.txt_NomeVinculo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CodigoVinculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_descricao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_InformarClasse = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.txt_CodigoDescricao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutoPorPosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo posto";
            // 
            // txt_CodigoPosto
            // 
            this.txt_CodigoPosto.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CodigoPosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoPosto.Enabled = false;
            this.txt_CodigoPosto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CodigoPosto.Location = new System.Drawing.Point(17, 52);
            this.txt_CodigoPosto.Name = "txt_CodigoPosto";
            this.txt_CodigoPosto.Size = new System.Drawing.Size(107, 20);
            this.txt_CodigoPosto.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(127, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Postos de Trabalho";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 27);
            this.menuStrip1.TabIndex = 30;
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
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(723, 9);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 31;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // cbx_Posto
            // 
            this.cbx_Posto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Posto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Posto.FormattingEnabled = true;
            this.cbx_Posto.Location = new System.Drawing.Point(130, 53);
            this.cbx_Posto.Name = "cbx_Posto";
            this.cbx_Posto.Size = new System.Drawing.Size(457, 21);
            this.cbx_Posto.TabIndex = 33;
            this.cbx_Posto.SelectedIndexChanged += new System.EventHandler(this.cbx_Posto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(127, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Local";
            // 
            // txt_NumeroLocal
            // 
            this.txt_NumeroLocal.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NumeroLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NumeroLocal.Enabled = false;
            this.txt_NumeroLocal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_NumeroLocal.Location = new System.Drawing.Point(17, 94);
            this.txt_NumeroLocal.Name = "txt_NumeroLocal";
            this.txt_NumeroLocal.Size = new System.Drawing.Size(107, 20);
            this.txt_NumeroLocal.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Numero Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(127, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Contrato";
            // 
            // txt_CodigoContrato
            // 
            this.txt_CodigoContrato.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CodigoContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoContrato.Enabled = false;
            this.txt_CodigoContrato.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CodigoContrato.Location = new System.Drawing.Point(17, 139);
            this.txt_CodigoContrato.Name = "txt_CodigoContrato";
            this.txt_CodigoContrato.Size = new System.Drawing.Size(107, 20);
            this.txt_CodigoContrato.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(14, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Codigo Contrato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(127, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cargo";
            // 
            // txt_CodigoCargo
            // 
            this.txt_CodigoCargo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CodigoCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoCargo.Enabled = false;
            this.txt_CodigoCargo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CodigoCargo.Location = new System.Drawing.Point(17, 186);
            this.txt_CodigoCargo.Name = "txt_CodigoCargo";
            this.txt_CodigoCargo.Size = new System.Drawing.Size(107, 20);
            this.txt_CodigoCargo.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(14, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Codigo Cargo";
            // 
            // dgv_ProdutoPorPosto
            // 
            this.dgv_ProdutoPorPosto.AllowUserToAddRows = false;
            this.dgv_ProdutoPorPosto.AllowUserToDeleteRows = false;
            this.dgv_ProdutoPorPosto.AllowUserToResizeRows = false;
            this.dgv_ProdutoPorPosto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProdutoPorPosto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodDescricao,
            this.Descricao});
            this.dgv_ProdutoPorPosto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ProdutoPorPosto.Location = new System.Drawing.Point(17, 354);
            this.dgv_ProdutoPorPosto.Name = "dgv_ProdutoPorPosto";
            this.dgv_ProdutoPorPosto.RowHeadersVisible = false;
            this.dgv_ProdutoPorPosto.Size = new System.Drawing.Size(570, 315);
            this.dgv_ProdutoPorPosto.TabIndex = 46;
            this.dgv_ProdutoPorPosto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProdutoPorPosto_CellDoubleClick);
            // 
            // btn_InserirItem
            // 
            this.btn_InserirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_InserirItem.FlatAppearance.BorderSize = 0;
            this.btn_InserirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InserirItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_InserirItem.Location = new System.Drawing.Point(17, 315);
            this.btn_InserirItem.Name = "btn_InserirItem";
            this.btn_InserirItem.Size = new System.Drawing.Size(203, 33);
            this.btn_InserirItem.TabIndex = 47;
            this.btn_InserirItem.Text = "Inserir Item";
            this.btn_InserirItem.UseVisualStyleBackColor = false;
            this.btn_InserirItem.Click += new System.EventHandler(this.btn_InserirItem_Click);
            // 
            // btn_ExcluirItem
            // 
            this.btn_ExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ExcluirItem.FlatAppearance.BorderSize = 0;
            this.btn_ExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ExcluirItem.Location = new System.Drawing.Point(226, 315);
            this.btn_ExcluirItem.Name = "btn_ExcluirItem";
            this.btn_ExcluirItem.Size = new System.Drawing.Size(203, 33);
            this.btn_ExcluirItem.TabIndex = 48;
            this.btn_ExcluirItem.Text = "Excluir Item";
            this.btn_ExcluirItem.UseVisualStyleBackColor = false;
            this.btn_ExcluirItem.Click += new System.EventHandler(this.btn_ExcluirItem_Click);
            // 
            // txt_NomeLocal
            // 
            this.txt_NomeLocal.Enabled = false;
            this.txt_NomeLocal.Location = new System.Drawing.Point(130, 95);
            this.txt_NomeLocal.Name = "txt_NomeLocal";
            this.txt_NomeLocal.Size = new System.Drawing.Size(457, 20);
            this.txt_NomeLocal.TabIndex = 49;
            // 
            // txt_NomeCargo
            // 
            this.txt_NomeCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NomeCargo.Enabled = false;
            this.txt_NomeCargo.Location = new System.Drawing.Point(130, 187);
            this.txt_NomeCargo.Name = "txt_NomeCargo";
            this.txt_NomeCargo.Size = new System.Drawing.Size(457, 20);
            this.txt_NomeCargo.TabIndex = 50;
            // 
            // txt_NomeContrato
            // 
            this.txt_NomeContrato.Enabled = false;
            this.txt_NomeContrato.Location = new System.Drawing.Point(130, 140);
            this.txt_NomeContrato.Name = "txt_NomeContrato";
            this.txt_NomeContrato.Size = new System.Drawing.Size(457, 20);
            this.txt_NomeContrato.TabIndex = 51;
            // 
            // txt_NomeVinculo
            // 
            this.txt_NomeVinculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NomeVinculo.Enabled = false;
            this.txt_NomeVinculo.Location = new System.Drawing.Point(130, 231);
            this.txt_NomeVinculo.Name = "txt_NomeVinculo";
            this.txt_NomeVinculo.Size = new System.Drawing.Size(457, 20);
            this.txt_NomeVinculo.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(127, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Vinculo";
            // 
            // txt_CodigoVinculo
            // 
            this.txt_CodigoVinculo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CodigoVinculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoVinculo.Enabled = false;
            this.txt_CodigoVinculo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CodigoVinculo.Location = new System.Drawing.Point(17, 230);
            this.txt_CodigoVinculo.Name = "txt_CodigoVinculo";
            this.txt_CodigoVinculo.Size = new System.Drawing.Size(107, 20);
            this.txt_CodigoVinculo.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(14, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Codigo Vinculo";
            // 
            // cbx_descricao
            // 
            this.cbx_descricao.FormattingEnabled = true;
            this.cbx_descricao.Location = new System.Drawing.Point(130, 286);
            this.cbx_descricao.Name = "cbx_descricao";
            this.cbx_descricao.Size = new System.Drawing.Size(432, 21);
            this.cbx_descricao.TabIndex = 56;
            this.cbx_descricao.SelectedIndexChanged += new System.EventHandler(this.cbx_descricao_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(127, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Descrição";
            // 
            // btn_InformarClasse
            // 
            this.btn_InformarClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_InformarClasse.FlatAppearance.BorderSize = 0;
            this.btn_InformarClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InformarClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InformarClasse.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_InformarClasse.Location = new System.Drawing.Point(435, 315);
            this.btn_InformarClasse.Name = "btn_InformarClasse";
            this.btn_InformarClasse.Size = new System.Drawing.Size(152, 33);
            this.btn_InformarClasse.TabIndex = 58;
            this.btn_InformarClasse.Text = "Informar Classe";
            this.btn_InformarClasse.UseVisualStyleBackColor = false;
            this.btn_InformarClasse.Click += new System.EventHandler(this.btn_InformarClasse_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Atualizar.FlatAppearance.BorderSize = 0;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Atualizar.Location = new System.Drawing.Point(565, 286);
            this.btn_Atualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(22, 22);
            this.btn_Atualizar.TabIndex = 60;
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // txt_CodigoDescricao
            // 
            this.txt_CodigoDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CodigoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoDescricao.Enabled = false;
            this.txt_CodigoDescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CodigoDescricao.Location = new System.Drawing.Point(17, 286);
            this.txt_CodigoDescricao.Name = "txt_CodigoDescricao";
            this.txt_CodigoDescricao.Size = new System.Drawing.Size(107, 20);
            this.txt_CodigoDescricao.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(14, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Codigo Descrição";
            // 
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.AllowUserToAddRows = false;
            this.dgv_Funcionarios.AllowUserToDeleteRows = false;
            this.dgv_Funcionarios.AllowUserToResizeRows = false;
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.NomeFuncionario});
            this.dgv_Funcionarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Funcionarios.Location = new System.Drawing.Point(593, 53);
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.RowHeadersVisible = false;
            this.dgv_Funcionarios.Size = new System.Drawing.Size(369, 616);
            this.dgv_Funcionarios.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(593, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Funcionarios";
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "numcad";
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            this.matricula.Width = 70;
            // 
            // NomeFuncionario
            // 
            this.NomeFuncionario.DataPropertyName = "nomfun";
            this.NomeFuncionario.HeaderText = "Nome Funcionário";
            this.NomeFuncionario.Name = "NomeFuncionario";
            this.NomeFuncionario.Width = 296;
            // 
            // CodDescricao
            // 
            this.CodDescricao.DataPropertyName = "Codigo Descrição";
            this.CodDescricao.HeaderText = "Codigo Descrição";
            this.CodDescricao.Name = "CodDescricao";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descrição";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 467;
            // 
            // frm_ProdutoPostoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgv_Funcionarios);
            this.Controls.Add(this.txt_CodigoDescricao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_InformarClasse);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbx_descricao);
            this.Controls.Add(this.txt_NomeVinculo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_CodigoVinculo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_NomeContrato);
            this.Controls.Add(this.txt_NomeCargo);
            this.Controls.Add(this.txt_NomeLocal);
            this.Controls.Add(this.btn_InserirItem);
            this.Controls.Add(this.btn_ExcluirItem);
            this.Controls.Add(this.dgv_ProdutoPorPosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_CodigoCargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CodigoContrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NumeroLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Posto);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CodigoPosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ProdutoPostoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto por Posto";
            this.Load += new System.EventHandler(this.Frm_ProdutoPostoCadastro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutoPorPosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CodigoPosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
        private System.Windows.Forms.ComboBox cbx_Posto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NumeroLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CodigoContrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CodigoCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_ProdutoPorPosto;
        private System.Windows.Forms.Button btn_InserirItem;
        private System.Windows.Forms.Button btn_ExcluirItem;
        private System.Windows.Forms.TextBox txt_NomeLocal;
        private System.Windows.Forms.TextBox txt_NomeCargo;
        private System.Windows.Forms.TextBox txt_NomeContrato;
        private System.Windows.Forms.TextBox txt_NomeVinculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CodigoVinculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_descricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_InformarClasse;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.TextBox txt_CodigoDescricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_Funcionarios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}