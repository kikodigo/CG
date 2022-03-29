namespace CG.Tela_Inicial.Requisição.Retorno_Ficha
{
    partial class frm_ReqRetornoFicha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReqRetornoFicha));
            this.dgv_reqcontrato = new System.Windows.Forms.DataGridView();
            this.NReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retornofichareq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_func = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumReq = new System.Windows.Forms.TextBox();
            this.txt_contrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FichaEpi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_retorno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_funcionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reqcontrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_func)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reqcontrato
            // 
            this.dgv_reqcontrato.AllowUserToAddRows = false;
            this.dgv_reqcontrato.AllowUserToDeleteRows = false;
            this.dgv_reqcontrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reqcontrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NReq,
            this.contrato,
            this.retornofichareq});
            this.dgv_reqcontrato.Location = new System.Drawing.Point(20, 74);
            this.dgv_reqcontrato.Name = "dgv_reqcontrato";
            this.dgv_reqcontrato.ReadOnly = true;
            this.dgv_reqcontrato.RowHeadersVisible = false;
            this.dgv_reqcontrato.Size = new System.Drawing.Size(409, 537);
            this.dgv_reqcontrato.TabIndex = 0;
            this.dgv_reqcontrato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_reqcontrato_CellDoubleClick);
            // 
            // NReq
            // 
            this.NReq.DataPropertyName = "codreq";
            this.NReq.FillWeight = 130F;
            this.NReq.HeaderText = "N°Req";
            this.NReq.Name = "NReq";
            this.NReq.ReadOnly = true;
            this.NReq.Width = 130;
            // 
            // contrato
            // 
            this.contrato.DataPropertyName = "contrato";
            this.contrato.FillWeight = 150F;
            this.contrato.HeaderText = "Contrato";
            this.contrato.Name = "contrato";
            this.contrato.ReadOnly = true;
            this.contrato.Width = 150;
            // 
            // retornofichareq
            // 
            this.retornofichareq.DataPropertyName = "retorno_ficha";
            this.retornofichareq.FillWeight = 130F;
            this.retornofichareq.HeaderText = "Fichas EPI";
            this.retornofichareq.Name = "retornofichareq";
            this.retornofichareq.ReadOnly = true;
            this.retornofichareq.Width = 130;
            // 
            // dgv_func
            // 
            this.dgv_func.AllowUserToAddRows = false;
            this.dgv_func.AllowUserToDeleteRows = false;
            this.dgv_func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_func.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.Func,
            this.DataRetorno});
            this.dgv_func.Location = new System.Drawing.Point(452, 74);
            this.dgv_func.Name = "dgv_func";
            this.dgv_func.ReadOnly = true;
            this.dgv_func.RowHeadersVisible = false;
            this.dgv_func.Size = new System.Drawing.Size(506, 537);
            this.dgv_func.TabIndex = 1;
            this.dgv_func.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_func_CellDoubleClick);
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "matr_func";
            this.matricula.FillWeight = 120F;
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Width = 120;
            // 
            // Func
            // 
            this.Func.DataPropertyName = "func";
            this.Func.FillWeight = 260F;
            this.Func.HeaderText = "Funcionário";
            this.Func.Name = "Func";
            this.Func.ReadOnly = true;
            this.Func.Width = 260;
            // 
            // DataRetorno
            // 
            this.DataRetorno.DataPropertyName = "retorno_ficha";
            this.DataRetorno.FillWeight = 130F;
            this.DataRetorno.HeaderText = "Data Retorno Ficha";
            this.DataRetorno.Name = "DataRetorno";
            this.DataRetorno.ReadOnly = true;
            this.DataRetorno.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N°Req";
            // 
            // txt_NumReq
            // 
            this.txt_NumReq.Location = new System.Drawing.Point(20, 28);
            this.txt_NumReq.Name = "txt_NumReq";
            this.txt_NumReq.Size = new System.Drawing.Size(48, 20);
            this.txt_NumReq.TabIndex = 3;
            // 
            // txt_contrato
            // 
            this.txt_contrato.Location = new System.Drawing.Point(69, 28);
            this.txt_contrato.Name = "txt_contrato";
            this.txt_contrato.Size = new System.Drawing.Size(281, 20);
            this.txt_contrato.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(66, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contrato";
            // 
            // txt_FichaEpi
            // 
            this.txt_FichaEpi.Location = new System.Drawing.Point(351, 28);
            this.txt_FichaEpi.Name = "txt_FichaEpi";
            this.txt_FichaEpi.Size = new System.Drawing.Size(78, 20);
            this.txt_FichaEpi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(348, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fichas EPI";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txt_retorno
            // 
            this.txt_retorno.Enabled = false;
            this.txt_retorno.Location = new System.Drawing.Point(750, 27);
            this.txt_retorno.Name = "txt_retorno";
            this.txt_retorno.Size = new System.Drawing.Size(114, 20);
            this.txt_retorno.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(747, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data Retorno Ficha";
            // 
            // txt_funcionario
            // 
            this.txt_funcionario.Location = new System.Drawing.Point(534, 27);
            this.txt_funcionario.Name = "txt_funcionario";
            this.txt_funcionario.Size = new System.Drawing.Size(215, 20);
            this.txt_funcionario.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(526, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Funcionário";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(452, 27);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(81, 20);
            this.txt_matricula.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(449, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Matricula";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Alterar.Location = new System.Drawing.Point(866, 27);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(88, 21);
            this.btn_Alterar.TabIndex = 14;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // frm_ReqRetornoFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 625);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.txt_retorno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_funcionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_FichaEpi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NumReq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_func);
            this.Controls.Add(this.dgv_reqcontrato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(990, 720);
            this.MinimumSize = new System.Drawing.Size(990, 664);
            this.Name = "frm_ReqRetornoFicha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retorno de Ficha";
            this.Load += new System.EventHandler(this.Frm_ReqRetornoFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reqcontrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_func)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reqcontrato;
        private System.Windows.Forms.DataGridView dgv_func;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NumReq;
        private System.Windows.Forms.TextBox txt_contrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FichaEpi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_retorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_funcionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn retornofichareq;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRetorno;
    }
}