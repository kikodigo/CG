namespace CG.Tela_Inicial.Requisição.Consulta
{
    partial class frm_ReqConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReqConsulta));
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.cbx_coluna = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_controle = new System.Windows.Forms.TextBox();
            this.RetornoFicha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.DataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAprovado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previsao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ReqPesquisa = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_numreq = new System.Windows.Forms.TextBox();
            this.txt_contrato = new System.Windows.Forms.TextBox();
            this.txt_aprovado = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.txt_TipoEnvio = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            this.txt_Previsao = new System.Windows.Forms.TextBox();
            this.txt_DataEnvio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReqPesquisa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_referencia
            // 
            this.txt_referencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_referencia.Location = new System.Drawing.Point(131, 53);
            this.txt_referencia.MinimumSize = new System.Drawing.Size(650, 21);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(732, 21);
            this.txt_referencia.TabIndex = 17;
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
            this.cbx_coluna.Location = new System.Drawing.Point(12, 54);
            this.cbx_coluna.Name = "cbx_coluna";
            this.cbx_coluna.Size = new System.Drawing.Size(118, 21);
            this.cbx_coluna.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(128, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Coluna";
            // 
            // txt_controle
            // 
            this.txt_controle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_controle.Location = new System.Drawing.Point(763, 32);
            this.txt_controle.Name = "txt_controle";
            this.txt_controle.Size = new System.Drawing.Size(100, 21);
            this.txt_controle.TabIndex = 19;
            this.txt_controle.Visible = false;
            // 
            // RetornoFicha
            // 
            this.RetornoFicha.DataPropertyName = "retorno_ficha";
            this.RetornoFicha.HeaderText = "Retorno Ficha";
            this.RetornoFicha.Name = "RetornoFicha";
            this.RetornoFicha.ReadOnly = true;
            // 
            // TipoEnvio
            // 
            this.TipoEnvio.DataPropertyName = "tipo_envio";
            this.TipoEnvio.HeaderText = "Tipo Envio";
            this.TipoEnvio.Name = "TipoEnvio";
            this.TipoEnvio.ReadOnly = true;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Limpar.Location = new System.Drawing.Point(869, 54);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(92, 21);
            this.btn_Limpar.TabIndex = 20;
            this.btn_Limpar.Text = "Limpar ";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // DataEnvio
            // 
            this.DataEnvio.DataPropertyName = "data_envio";
            this.DataEnvio.HeaderText = "Data de Envio";
            this.DataEnvio.Name = "DataEnvio";
            this.DataEnvio.ReadOnly = true;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Obs";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DataAprovado
            // 
            this.DataAprovado.DataPropertyName = "data_aprov";
            this.DataAprovado.HeaderText = "Data Aprovado";
            this.DataAprovado.Name = "DataAprovado";
            this.DataAprovado.ReadOnly = true;
            // 
            // Contrato
            // 
            this.Contrato.DataPropertyName = "contrato";
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // NReq
            // 
            this.NReq.DataPropertyName = "codreq";
            this.NReq.HeaderText = "N°Req";
            this.NReq.Name = "NReq";
            this.NReq.ReadOnly = true;
            this.NReq.Width = 50;
            // 
            // Previsao
            // 
            this.Previsao.DataPropertyName = "prev";
            this.Previsao.HeaderText = "Previsão";
            this.Previsao.Name = "Previsao";
            this.Previsao.ReadOnly = true;
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
            this.dgv_ReqPesquisa.Location = new System.Drawing.Point(13, 81);
            this.dgv_ReqPesquisa.Name = "dgv_ReqPesquisa";
            this.dgv_ReqPesquisa.ReadOnly = true;
            this.dgv_ReqPesquisa.RowHeadersVisible = false;
            this.dgv_ReqPesquisa.Size = new System.Drawing.Size(949, 510);
            this.dgv_ReqPesquisa.TabIndex = 18;
            this.dgv_ReqPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ReqPesquisa_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 27);
            this.menuStrip1.TabIndex = 24;
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 23);
            this.toolStripMenuItem1.Text = "Usuario:";
            // 
            // txt_numreq
            // 
            this.txt_numreq.Enabled = false;
            this.txt_numreq.Location = new System.Drawing.Point(14, 610);
            this.txt_numreq.Name = "txt_numreq";
            this.txt_numreq.Size = new System.Drawing.Size(56, 20);
            this.txt_numreq.TabIndex = 25;
            // 
            // txt_contrato
            // 
            this.txt_contrato.Enabled = false;
            this.txt_contrato.Location = new System.Drawing.Point(182, 610);
            this.txt_contrato.Name = "txt_contrato";
            this.txt_contrato.Size = new System.Drawing.Size(432, 20);
            this.txt_contrato.TabIndex = 26;
            // 
            // txt_aprovado
            // 
            this.txt_aprovado.Enabled = false;
            this.txt_aprovado.Location = new System.Drawing.Point(620, 610);
            this.txt_aprovado.Name = "txt_aprovado";
            this.txt_aprovado.Size = new System.Drawing.Size(100, 20);
            this.txt_aprovado.TabIndex = 27;
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Location = new System.Drawing.Point(726, 610);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(235, 20);
            this.txt_status.TabIndex = 28;
            // 
            // txt_observacao
            // 
            this.txt_observacao.Enabled = false;
            this.txt_observacao.Location = new System.Drawing.Point(13, 649);
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(493, 20);
            this.txt_observacao.TabIndex = 29;
            // 
            // txt_TipoEnvio
            // 
            this.txt_TipoEnvio.Location = new System.Drawing.Point(726, 649);
            this.txt_TipoEnvio.Name = "txt_TipoEnvio";
            this.txt_TipoEnvio.Size = new System.Drawing.Size(236, 20);
            this.txt_TipoEnvio.TabIndex = 30;
            // 
            // txt_data
            // 
            this.txt_data.Enabled = false;
            this.txt_data.Location = new System.Drawing.Point(76, 610);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(100, 20);
            this.txt_data.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "NºReq";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(74, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(179, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Contrato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(617, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Aprovado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(723, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(511, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Previsão";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(620, 633);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Data de Envio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(723, 633);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Tipo de Envio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(12, 633);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Observação";
            // 
            // lbl_VlPermissao
            // 
            this.lbl_VlPermissao.AutoSize = true;
            this.lbl_VlPermissao.Enabled = false;
            this.lbl_VlPermissao.Location = new System.Drawing.Point(882, 32);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 146;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // txt_Previsao
            // 
            this.txt_Previsao.Enabled = false;
            this.txt_Previsao.Location = new System.Drawing.Point(512, 649);
            this.txt_Previsao.Name = "txt_Previsao";
            this.txt_Previsao.Size = new System.Drawing.Size(100, 20);
            this.txt_Previsao.TabIndex = 147;
            // 
            // txt_DataEnvio
            // 
            this.txt_DataEnvio.Enabled = false;
            this.txt_DataEnvio.Location = new System.Drawing.Point(620, 648);
            this.txt_DataEnvio.Name = "txt_DataEnvio";
            this.txt_DataEnvio.Size = new System.Drawing.Size(100, 20);
            this.txt_DataEnvio.TabIndex = 148;
            // 
            // frm_ReqConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.txt_DataEnvio);
            this.Controls.Add(this.txt_Previsao);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_TipoEnvio);
            this.Controls.Add(this.txt_observacao);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_aprovado);
            this.Controls.Add(this.txt_contrato);
            this.Controls.Add(this.txt_numreq);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.cbx_coluna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.dgv_ReqPesquisa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_controle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ReqConsulta";
            this.Text = "Consulta de Requerimento";
            this.Load += new System.EventHandler(this.Frm_ReqConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReqPesquisa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.ComboBox cbx_coluna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_controle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetornoFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEnvio;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAprovado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn NReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previsao;
        private System.Windows.Forms.DataGridView dgv_ReqPesquisa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txt_numreq;
        private System.Windows.Forms.TextBox txt_contrato;
        private System.Windows.Forms.TextBox txt_aprovado;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.TextBox txt_TipoEnvio;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_VlPermissao;
        private System.Windows.Forms.TextBox txt_Previsao;
        private System.Windows.Forms.TextBox txt_DataEnvio;
    }
}