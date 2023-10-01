namespace CG.Tela_Inicial.Requisição
{
    partial class frm_ReqVisualizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReqVisualizador));
            this.txt_numreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.dgv_visualizador = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionários = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdLiberada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_func = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_matr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_QtdLib = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_aprovar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VlPermissao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visualizador)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_numreq
            // 
            this.txt_numreq.Enabled = false;
            this.txt_numreq.Location = new System.Drawing.Point(12, 47);
            this.txt_numreq.Name = "txt_numreq";
            this.txt_numreq.Size = new System.Drawing.Size(89, 20);
            this.txt_numreq.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Requisição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(105, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contrato";
            // 
            // txt_contrato
            // 
            this.txt_contrato.Enabled = false;
            this.txt_contrato.Location = new System.Drawing.Point(102, 47);
            this.txt_contrato.Name = "txt_contrato";
            this.txt_contrato.Size = new System.Drawing.Size(406, 20);
            this.txt_contrato.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(506, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // txt_data
            // 
            this.txt_data.Enabled = false;
            this.txt_data.Location = new System.Drawing.Point(509, 47);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(72, 20);
            this.txt_data.TabIndex = 4;
            // 
            // dgv_visualizador
            // 
            this.dgv_visualizador.AllowUserToAddRows = false;
            this.dgv_visualizador.AllowUserToDeleteRows = false;
            this.dgv_visualizador.AllowUserToResizeRows = false;
            this.dgv_visualizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visualizador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Funcionários,
            this.Cargo,
            this.Descricao,
            this.QtdSolicitada,
            this.QtdLiberada,
            this.Motivo});
            this.dgv_visualizador.Location = new System.Drawing.Point(12, 123);
            this.dgv_visualizador.Name = "dgv_visualizador";
            this.dgv_visualizador.ReadOnly = true;
            this.dgv_visualizador.RowHeadersVisible = false;
            this.dgv_visualizador.Size = new System.Drawing.Size(950, 546);
            this.dgv_visualizador.TabIndex = 6;
            this.dgv_visualizador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_visualizador_CellContentClick);
            this.dgv_visualizador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_visualizador_CellDoubleClick);
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "matr_func";
            this.Matricula.FillWeight = 70F;
            this.Matricula.HeaderText = "Matrícula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 70;
            // 
            // Funcionários
            // 
            this.Funcionários.DataPropertyName = "func";
            this.Funcionários.FillWeight = 200F;
            this.Funcionários.HeaderText = "Funcionários";
            this.Funcionários.Name = "Funcionários";
            this.Funcionários.ReadOnly = true;
            this.Funcionários.Width = 200;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "cargo";
            this.Cargo.FillWeight = 150F;
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 150;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.FillWeight = 200F;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // QtdSolicitada
            // 
            this.QtdSolicitada.DataPropertyName = "qtd";
            this.QtdSolicitada.FillWeight = 80F;
            this.QtdSolicitada.HeaderText = "Qtd.Solicitada";
            this.QtdSolicitada.Name = "QtdSolicitada";
            this.QtdSolicitada.ReadOnly = true;
            this.QtdSolicitada.Width = 80;
            // 
            // QtdLiberada
            // 
            this.QtdLiberada.DataPropertyName = "qtd_lib";
            this.QtdLiberada.FillWeight = 80F;
            this.QtdLiberada.HeaderText = "Qtd.Liberada";
            this.QtdLiberada.Name = "QtdLiberada";
            this.QtdLiberada.ReadOnly = true;
            this.QtdLiberada.Width = 80;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "motivo";
            this.Motivo.FillWeight = 200F;
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(579, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Location = new System.Drawing.Point(582, 47);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(128, 20);
            this.txt_status.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(280, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descrição";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Enabled = false;
            this.txt_descricao.Location = new System.Drawing.Point(282, 86);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(299, 20);
            this.txt_descricao.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(105, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Funcionário";
            // 
            // txt_func
            // 
            this.txt_func.Enabled = false;
            this.txt_func.Location = new System.Drawing.Point(102, 86);
            this.txt_func.Name = "txt_func";
            this.txt_func.Size = new System.Drawing.Size(179, 20);
            this.txt_func.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Matrícula";
            // 
            // txt_matr
            // 
            this.txt_matr.Enabled = false;
            this.txt_matr.Location = new System.Drawing.Point(12, 86);
            this.txt_matr.Name = "txt_matr";
            this.txt_matr.Size = new System.Drawing.Size(89, 20);
            this.txt_matr.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(579, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Qtd.Liberada";
            // 
            // txt_QtdLib
            // 
            this.txt_QtdLib.Location = new System.Drawing.Point(582, 86);
            this.txt_QtdLib.Name = "txt_QtdLib";
            this.txt_QtdLib.Size = new System.Drawing.Size(128, 20);
            this.txt_QtdLib.TabIndex = 15;
            this.txt_QtdLib.TextChanged += new System.EventHandler(this.Txt_QtdLib_TextChanged);
            this.txt_QtdLib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_QtdLib_KeyPress);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_alterar.Location = new System.Drawing.Point(732, 46);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(112, 62);
            this.btn_alterar.TabIndex = 17;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // btn_aprovar
            // 
            this.btn_aprovar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_aprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aprovar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_aprovar.Location = new System.Drawing.Point(850, 47);
            this.btn_aprovar.Name = "btn_aprovar";
            this.btn_aprovar.Size = new System.Drawing.Size(112, 62);
            this.btn_aprovar.TabIndex = 18;
            this.btn_aprovar.Text = "Aprovar";
            this.btn_aprovar.UseVisualStyleBackColor = false;
            this.btn_aprovar.Click += new System.EventHandler(this.Btn_aprovar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_usuario,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 27);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
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
            this.lbl_VlPermissao.Location = new System.Drawing.Point(872, 27);
            this.lbl_VlPermissao.Name = "lbl_VlPermissao";
            this.lbl_VlPermissao.Size = new System.Drawing.Size(80, 13);
            this.lbl_VlPermissao.TabIndex = 146;
            this.lbl_VlPermissao.Text = "lbl_VlPermissao";
            this.lbl_VlPermissao.Visible = false;
            // 
            // frm_ReqVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.lbl_VlPermissao);
            this.Controls.Add(this.btn_aprovar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_QtdLib);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_func);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_matr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.dgv_visualizador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_contrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numreq);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(990, 720);
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "frm_ReqVisualizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Requerimento";
            this.Load += new System.EventHandler(this.Frm_ReqVisualizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visualizador)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.DataGridView dgv_visualizador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_func;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_matr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_QtdLib;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_aprovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionários;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdLiberada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.Label lbl_VlPermissao;
    }
}