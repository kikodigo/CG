namespace CG
{
    partial class frm_gerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gerenciador));
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_idCampo = new System.Windows.Forms.Label();
            this.nud_id = new System.Windows.Forms.NumericUpDown();
            this.lbl_alterar = new System.Windows.Forms.Label();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_id)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.AllowUserToResizeColumns = false;
            this.dgv_info.AllowUserToResizeRows = false;
            this.dgv_info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_info.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.servico,
            this.user,
            this.senha});
            this.dgv_info.Location = new System.Drawing.Point(0, 83);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.ReadOnly = true;
            this.dgv_info.Size = new System.Drawing.Size(455, 245);
            this.dgv_info.TabIndex = 0;
            this.dgv_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_info_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // servico
            // 
            this.servico.DataPropertyName = "siteNome";
            this.servico.HeaderText = "Nome do Serviço";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            // 
            // user
            // 
            this.user.DataPropertyName = "login";
            this.user.HeaderText = "Nome de Usuário";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // lbl_idCampo
            // 
            this.lbl_idCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_idCampo.AutoSize = true;
            this.lbl_idCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idCampo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_idCampo.Location = new System.Drawing.Point(36, 401);
            this.lbl_idCampo.Name = "lbl_idCampo";
            this.lbl_idCampo.Size = new System.Drawing.Size(97, 18);
            this.lbl_idCampo.TabIndex = 3;
            this.lbl_idCampo.Text = "ID do campo:";
            // 
            // nud_id
            // 
            this.nud_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.nud_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_id.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nud_id.Location = new System.Drawing.Point(13, 438);
            this.nud_id.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nud_id.Name = "nud_id";
            this.nud_id.Size = new System.Drawing.Size(161, 26);
            this.nud_id.TabIndex = 4;
            // 
            // lbl_alterar
            // 
            this.lbl_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alterar.AutoSize = true;
            this.lbl_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alterar.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_alterar.Location = new System.Drawing.Point(23, 419);
            this.lbl_alterar.Name = "lbl_alterar";
            this.lbl_alterar.Size = new System.Drawing.Size(142, 16);
            this.lbl_alterar.TabIndex = 24;
            this.lbl_alterar.Text = "(a se alterar ou excluir)";
            // 
            // lbl_erro
            // 
            this.lbl_erro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(98, 369);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro.TabIndex = 25;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.pnl_header.Controls.Add(this.lbl_headerText);
            this.pnl_header.Controls.Add(this.panel2);
            this.pnl_header.Controls.Add(this.btn_voltar);
            this.pnl_header.Location = new System.Drawing.Point(-4, -4);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(459, 93);
            this.pnl_header.TabIndex = 26;
            this.pnl_header.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_header_Paint);
            // 
            // lbl_headerText
            // 
            this.lbl_headerText.AutoSize = true;
            this.lbl_headerText.BackColor = System.Drawing.Color.DimGray;
            this.lbl_headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_headerText.Location = new System.Drawing.Point(127, 33);
            this.lbl_headerText.Name = "lbl_headerText";
            this.lbl_headerText.Size = new System.Drawing.Size(206, 29);
            this.lbl_headerText.TabIndex = 28;
            this.lbl_headerText.Text = "Gerenciar Senhas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 3);
            this.panel2.TabIndex = 27;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_voltar.BackColor = System.Drawing.Color.DimGray;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_voltar.Image = global::CG.Properties.Resources.back;
            this.btn_voltar.Location = new System.Drawing.Point(3, 3);
            this.btn_voltar.MaximumSize = new System.Drawing.Size(1024, 768);
            this.btn_voltar.MinimumSize = new System.Drawing.Size(1024, 768);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(1024, 768);
            this.btn_voltar.TabIndex = 23;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(230, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(343, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 3);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frm_gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(456, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.lbl_alterar);
            this.Controls.Add(this.nud_id);
            this.Controls.Add(this.lbl_idCampo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_info);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar";
            this.Load += new System.EventHandler(this.Frm_gerenciador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_id)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Label lbl_idCampo;
        private System.Windows.Forms.NumericUpDown nud_id;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_alterar;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_headerText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.Panel panel1;
    }
}