namespace CG.Tela_Inicial.Cadastro.Contratos
{
    partial class frm_ContratoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ContratoCadastro));
            this.txt_tel1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_tel2 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_N = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.cbx_cidade = new System.Windows.Forms.ComboBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Contato = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_Rua = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.lbl_Telefone2 = new System.Windows.Forms.Label();
            this.lbl_Telefone1 = new System.Windows.Forms.Label();
            this.lbl_Contrato = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.txt_PrLimite = new System.Windows.Forms.TextBox();
            this.lbl_PrecoLimite = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_limpar = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_contrato = new System.Windows.Forms.ComboBox();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.lbl_Observacao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tel1
            // 
            this.txt_tel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel1.Location = new System.Drawing.Point(521, 162);
            this.txt_tel1.Name = "txt_tel1";
            this.txt_tel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tel1.Size = new System.Drawing.Size(100, 21);
            this.txt_tel1.TabIndex = 136;
            // 
            // txt_tel2
            // 
            this.txt_tel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel2.Location = new System.Drawing.Point(622, 162);
            this.txt_tel2.MaximumSize = new System.Drawing.Size(98, 21);
            this.txt_tel2.MinimumSize = new System.Drawing.Size(98, 21);
            this.txt_tel2.Name = "txt_tel2";
            this.txt_tel2.Size = new System.Drawing.Size(98, 21);
            this.txt_tel2.TabIndex = 136;
            // 
            // lbl_N
            // 
            this.lbl_N.AutoSize = true;
            this.lbl_N.ForeColor = System.Drawing.Color.Gray;
            this.lbl_N.Location = new System.Drawing.Point(229, 146);
            this.lbl_N.Name = "lbl_N";
            this.lbl_N.Size = new System.Drawing.Size(19, 13);
            this.lbl_N.TabIndex = 131;
            this.lbl_N.Text = "Nº";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(228, 162);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(48, 21);
            this.txt_num.TabIndex = 92;
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Cod.Location = new System.Drawing.Point(23, 56);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(26, 13);
            this.lbl_Cod.TabIndex = 129;
            this.lbl_Cod.Text = "Cod";
            // 
            // cbx_cidade
            // 
            this.cbx_cidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_cidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cidade.FormattingEnabled = true;
            this.cbx_cidade.Location = new System.Drawing.Point(95, 118);
            this.cbx_cidade.Name = "cbx_cidade";
            this.cbx_cidade.Size = new System.Drawing.Size(324, 23);
            this.cbx_cidade.TabIndex = 89;
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Cidade.Location = new System.Drawing.Point(92, 102);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cidade.TabIndex = 122;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Contato
            // 
            this.lbl_Contato.AutoSize = true;
            this.lbl_Contato.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Contato.Location = new System.Drawing.Point(347, 146);
            this.lbl_Contato.Name = "lbl_Contato";
            this.lbl_Contato.Size = new System.Drawing.Size(44, 13);
            this.lbl_Contato.TabIndex = 113;
            this.lbl_Contato.Text = "Contato";
            // 
            // txt_contato
            // 
            this.txt_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contato.Location = new System.Drawing.Point(350, 162);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(170, 21);
            this.txt_contato.TabIndex = 94;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_bairro.Location = new System.Drawing.Point(422, 118);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(298, 23);
            this.txt_bairro.TabIndex = 90;
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Bairro.Location = new System.Drawing.Point(421, 102);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_Bairro.TabIndex = 112;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // cbx_estado
            // 
            this.cbx_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbx_estado.Location = new System.Drawing.Point(24, 118);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(69, 23);
            this.cbx_estado.TabIndex = 88;
            this.cbx_estado.SelectedIndexChanged += new System.EventHandler(this.Cbx_estado_SelectedIndexChanged);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Estado.Location = new System.Drawing.Point(23, 102);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_Estado.TabIndex = 111;
            this.lbl_Estado.Text = "Estado";
            // 
            // txt_cep
            // 
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(277, 162);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(71, 21);
            this.txt_cep.TabIndex = 93;
            // 
            // txt_rua
            // 
            this.txt_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(24, 162);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(203, 21);
            this.txt_rua.TabIndex = 91;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_codigo.Location = new System.Drawing.Point(24, 72);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(127, 23);
            this.txt_codigo.TabIndex = 109;
            // 
            // lbl_Rua
            // 
            this.lbl_Rua.AutoSize = true;
            this.lbl_Rua.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Rua.Location = new System.Drawing.Point(23, 146);
            this.lbl_Rua.Name = "lbl_Rua";
            this.lbl_Rua.Size = new System.Drawing.Size(27, 13);
            this.lbl_Rua.TabIndex = 108;
            this.lbl_Rua.Text = "Rua";
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CEP.Location = new System.Drawing.Point(274, 146);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(28, 13);
            this.lbl_CEP.TabIndex = 107;
            this.lbl_CEP.Text = "CEP";
            // 
            // lbl_Telefone2
            // 
            this.lbl_Telefone2.AutoSize = true;
            this.lbl_Telefone2.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Telefone2.Location = new System.Drawing.Point(620, 146);
            this.lbl_Telefone2.Name = "lbl_Telefone2";
            this.lbl_Telefone2.Size = new System.Drawing.Size(58, 13);
            this.lbl_Telefone2.TabIndex = 106;
            this.lbl_Telefone2.Text = "Telefone 2";
            // 
            // lbl_Telefone1
            // 
            this.lbl_Telefone1.AutoSize = true;
            this.lbl_Telefone1.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Telefone1.Location = new System.Drawing.Point(519, 146);
            this.lbl_Telefone1.Name = "lbl_Telefone1";
            this.lbl_Telefone1.Size = new System.Drawing.Size(58, 13);
            this.lbl_Telefone1.TabIndex = 105;
            this.lbl_Telefone1.Text = "Telefone 1";
            // 
            // lbl_Contrato
            // 
            this.lbl_Contrato.AutoSize = true;
            this.lbl_Contrato.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Contrato.Location = new System.Drawing.Point(152, 56);
            this.lbl_Contrato.Name = "lbl_Contrato";
            this.lbl_Contrato.Size = new System.Drawing.Size(47, 13);
            this.lbl_Contrato.TabIndex = 104;
            this.lbl_Contrato.Text = "Contrato";
            // 
            // txt_obs
            // 
            this.txt_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obs.Location = new System.Drawing.Point(24, 241);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(696, 247);
            this.txt_obs.TabIndex = 139;
            this.txt_obs.TextChanged += new System.EventHandler(this.Txt_obs_TextChanged);
            // 
            // txt_PrLimite
            // 
            this.txt_PrLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrLimite.Location = new System.Drawing.Point(24, 201);
            this.txt_PrLimite.Name = "txt_PrLimite";
            this.txt_PrLimite.Size = new System.Drawing.Size(97, 21);
            this.txt_PrLimite.TabIndex = 140;
            // 
            // lbl_PrecoLimite
            // 
            this.lbl_PrecoLimite.AutoSize = true;
            this.lbl_PrecoLimite.ForeColor = System.Drawing.Color.Gray;
            this.lbl_PrecoLimite.Location = new System.Drawing.Point(23, 185);
            this.lbl_PrecoLimite.Name = "lbl_PrecoLimite";
            this.lbl_PrecoLimite.Size = new System.Drawing.Size(65, 13);
            this.lbl_PrecoLimite.TabIndex = 141;
            this.lbl_PrecoLimite.Text = "Preço Limite";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_editar,
            this.tsm_salvar,
            this.tsm_cancelar,
            this.tsm_pesquisar,
            this.tsm_limpar,
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 27);
            this.menuStrip1.TabIndex = 143;
            this.menuStrip1.Text = "menuStrip1";
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
            // tsm_pesquisar
            // 
            this.tsm_pesquisar.Name = "tsm_pesquisar";
            this.tsm_pesquisar.Size = new System.Drawing.Size(69, 23);
            this.tsm_pesquisar.Text = "Pesquisar";
            this.tsm_pesquisar.Click += new System.EventHandler(this.Tsm_pesquisar_Click);
            // 
            // tsm_limpar
            // 
            this.tsm_limpar.Name = "tsm_limpar";
            this.tsm_limpar.Size = new System.Drawing.Size(106, 23);
            this.tsm_limpar.Text = "Limpar Campos ";
            this.tsm_limpar.Click += new System.EventHandler(this.Tsm_limpar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.Window;
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
            // cbx_contrato
            // 
            this.cbx_contrato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_contrato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_contrato.FormattingEnabled = true;
            this.cbx_contrato.Location = new System.Drawing.Point(153, 72);
            this.cbx_contrato.Name = "cbx_contrato";
            this.cbx_contrato.Size = new System.Drawing.Size(567, 23);
            this.cbx_contrato.TabIndex = 144;
            this.cbx_contrato.SelectedIndexChanged += new System.EventHandler(this.Cbx_contrato_SelectedIndexChanged_1);
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(642, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 145;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // lbl_Observacao
            // 
            this.lbl_Observacao.AutoSize = true;
            this.lbl_Observacao.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Observacao.Location = new System.Drawing.Point(23, 225);
            this.lbl_Observacao.Name = "lbl_Observacao";
            this.lbl_Observacao.Size = new System.Drawing.Size(65, 13);
            this.lbl_Observacao.TabIndex = 151;
            this.lbl_Observacao.Text = "Observação";
            // 
            // frm_ContratoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(739, 500);
            this.Controls.Add(this.lbl_Observacao);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.cbx_contrato);
            this.Controls.Add(this.txt_PrLimite);
            this.Controls.Add(this.lbl_PrecoLimite);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.txt_tel1);
            this.Controls.Add(this.txt_tel2);
            this.Controls.Add(this.lbl_N);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.cbx_cidade);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Contato);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_Rua);
            this.Controls.Add(this.lbl_CEP);
            this.Controls.Add(this.lbl_Telefone2);
            this.Controls.Add(this.lbl_Telefone1);
            this.Controls.Add(this.lbl_Contrato);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ContratoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contrato";
            this.Load += new System.EventHandler(this.Frm_ContratoCadastro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox txt_tel1;
        private System.Windows.Forms.MaskedTextBox txt_tel2;
        private System.Windows.Forms.Label lbl_N;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.ComboBox cbx_cidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Contato;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_Rua;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_Telefone2;
        private System.Windows.Forms.Label lbl_Telefone1;
        private System.Windows.Forms.Label lbl_Contrato;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.TextBox txt_PrLimite;
        private System.Windows.Forms.Label lbl_PrecoLimite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsm_limpar;
        private System.Windows.Forms.ComboBox cbx_contrato;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
        private System.Windows.Forms.Label lbl_Observacao;
    }
}