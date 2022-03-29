namespace CG.Tela_Inicial.Requisição
{
    partial class frm_ReqPesquise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReqPesquise));
            this.dgv_ReqPesquisa = new System.Windows.Forms.DataGridView();
            this.NReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAprovado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previsao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetornoFicha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.cbx_coluna = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReqPesquisa)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ReqPesquisa
            // 
            this.dgv_ReqPesquisa.AllowUserToAddRows = false;
            this.dgv_ReqPesquisa.AllowUserToDeleteRows = false;
            this.dgv_ReqPesquisa.AllowUserToResizeColumns = false;
            this.dgv_ReqPesquisa.AllowUserToResizeRows = false;
            this.dgv_ReqPesquisa.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_ReqPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReqPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NReq,
            this.Data,
            this.Contrato,
            this.DataAprovado,
            this.Status,
            this.obs,
            this.Previsao,
            this.DataEnvio,
            this.TipoEnvio,
            this.RetornoFicha});
            this.dgv_ReqPesquisa.Location = new System.Drawing.Point(13, 89);
            this.dgv_ReqPesquisa.Name = "dgv_ReqPesquisa";
            this.dgv_ReqPesquisa.ReadOnly = true;
            this.dgv_ReqPesquisa.RowHeadersVisible = false;
            this.dgv_ReqPesquisa.Size = new System.Drawing.Size(949, 580);
            this.dgv_ReqPesquisa.TabIndex = 11;
            this.dgv_ReqPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ReqPesquisa_CellDoubleClick);
            // 
            // NReq
            // 
            this.NReq.DataPropertyName = "codreq";
            this.NReq.HeaderText = "N°Req";
            this.NReq.Name = "NReq";
            this.NReq.ReadOnly = true;
            this.NReq.Width = 50;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Contrato
            // 
            this.Contrato.DataPropertyName = "contrato";
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.ReadOnly = true;
            // 
            // DataAprovado
            // 
            this.DataAprovado.DataPropertyName = "data_aprov";
            this.DataAprovado.HeaderText = "Data Aprovado";
            this.DataAprovado.Name = "DataAprovado";
            this.DataAprovado.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Obs";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            // 
            // Previsao
            // 
            this.Previsao.DataPropertyName = "prev";
            this.Previsao.HeaderText = "Previsão";
            this.Previsao.Name = "Previsao";
            this.Previsao.ReadOnly = true;
            // 
            // DataEnvio
            // 
            this.DataEnvio.DataPropertyName = "data_envio";
            this.DataEnvio.HeaderText = "Data de Envio";
            this.DataEnvio.Name = "DataEnvio";
            this.DataEnvio.ReadOnly = true;
            // 
            // TipoEnvio
            // 
            this.TipoEnvio.DataPropertyName = "tipo_envio";
            this.TipoEnvio.HeaderText = "Tipo Envio";
            this.TipoEnvio.Name = "TipoEnvio";
            this.TipoEnvio.ReadOnly = true;
            // 
            // RetornoFicha
            // 
            this.RetornoFicha.DataPropertyName = "retorno_ficha";
            this.RetornoFicha.HeaderText = "Retorno Ficha";
            this.RetornoFicha.Name = "RetornoFicha";
            this.RetornoFicha.ReadOnly = true;
            // 
            // txt_referencia
            // 
            this.txt_referencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_referencia.Location = new System.Drawing.Point(132, 59);
            this.txt_referencia.MinimumSize = new System.Drawing.Size(650, 21);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(732, 21);
            this.txt_referencia.TabIndex = 10;
            this.txt_referencia.TextChanged += new System.EventHandler(this.Txt_referencia_TextChanged);
            // 
            // cbx_coluna
            // 
            this.cbx_coluna.FormattingEnabled = true;
            this.cbx_coluna.Items.AddRange(new object[] {
            "N°Req",
            "Contrato",
            "Data",
            "Data Aprovado",
            "Status"});
            this.cbx_coluna.Location = new System.Drawing.Point(13, 60);
            this.cbx_coluna.Name = "cbx_coluna";
            this.cbx_coluna.Size = new System.Drawing.Size(118, 21);
            this.cbx_coluna.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(129, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coluna";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Limpar.Location = new System.Drawing.Point(870, 60);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(92, 21);
            this.btn_Limpar.TabIndex = 13;
            this.btn_Limpar.Text = "Limpar ";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // txt_destino
            // 
            this.txt_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_destino.Location = new System.Drawing.Point(764, 35);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(100, 21);
            this.txt_destino.TabIndex = 12;
            this.txt_destino.Visible = false;
            this.txt_destino.TextChanged += new System.EventHandler(this.txt_destino_TextChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.Usuario});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(974, 27);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
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
            this.Usuario.Size = new System.Drawing.Size(59, 23);
            this.Usuario.Text = "Usuario";
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(870, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 146;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // frm_ReqPesquise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.dgv_ReqPesquisa);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.cbx_coluna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(990, 720);
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "frm_ReqPesquise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Requerimento";
            this.Load += new System.EventHandler(this.Frm_ReqPesquise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReqPesquisa)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ReqPesquisa;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.ComboBox cbx_coluna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn NReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAprovado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previsao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetornoFicha;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
    }
}