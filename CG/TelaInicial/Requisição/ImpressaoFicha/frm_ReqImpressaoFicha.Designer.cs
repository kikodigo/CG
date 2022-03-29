namespace CG.Tela_Inicial.Requisição.Impressão_Ficha
{
    partial class frm_ReqImpressaoFicha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReqImpressaoFicha));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cbx_nreq = new System.Windows.Forms.ComboBox();
            this.cbx_SelectFunc = new System.Windows.Forms.ComboBox();
            this.chx_SelectFunc = new System.Windows.Forms.CheckBox();
            this.dgv_dataEntrega = new System.Windows.Forms.DataGridView();
            this.Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_setor = new System.Windows.Forms.TextBox();
            this.txt_funcao = new System.Windows.Forms.TextBox();
            this.txt_colaborador = new System.Windows.Forms.TextBox();
            this.txt_Nreg = new System.Windows.Forms.TextBox();
            this.dgv_assinaturas = new System.Windows.Forms.DataGridView();
            this.Assinatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolução = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_descricoes = new System.Windows.Forms.DataGridView();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_informacoes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Nreq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dataADM = new System.Windows.Forms.MaskedTextBox();
            this.txt_dataDEM = new System.Windows.Forms.MaskedTextBox();
            this.lbl_restante = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_imprime = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.txt_contrato = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chx_visualizar = new System.Windows.Forms.CheckBox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assinaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_descricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(64, 8);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(56, 23);
            this.btn_proximo.TabIndex = 5;
            this.btn_proximo.Text = "Proximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.Btn_proximo_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cbx_nreq
            // 
            this.cbx_nreq.FormattingEnabled = true;
            this.cbx_nreq.Location = new System.Drawing.Point(55, 7);
            this.cbx_nreq.Name = "cbx_nreq";
            this.cbx_nreq.Size = new System.Drawing.Size(60, 21);
            this.cbx_nreq.TabIndex = 6;
            this.cbx_nreq.SelectedIndexChanged += new System.EventHandler(this.Cbx_contratos_SelectedIndexChanged);
            // 
            // cbx_SelectFunc
            // 
            this.cbx_SelectFunc.Enabled = false;
            this.cbx_SelectFunc.FormattingEnabled = true;
            this.cbx_SelectFunc.Location = new System.Drawing.Point(536, 8);
            this.cbx_SelectFunc.Name = "cbx_SelectFunc";
            this.cbx_SelectFunc.Size = new System.Drawing.Size(220, 21);
            this.cbx_SelectFunc.TabIndex = 7;
            this.cbx_SelectFunc.SelectedIndexChanged += new System.EventHandler(this.Cbx_SelectFunc_SelectedIndexChanged);
            // 
            // chx_SelectFunc
            // 
            this.chx_SelectFunc.AutoSize = true;
            this.chx_SelectFunc.Location = new System.Drawing.Point(406, 10);
            this.chx_SelectFunc.Name = "chx_SelectFunc";
            this.chx_SelectFunc.Size = new System.Drawing.Size(134, 17);
            this.chx_SelectFunc.TabIndex = 8;
            this.chx_SelectFunc.Text = "Selecionar Funcionario";
            this.chx_SelectFunc.UseVisualStyleBackColor = true;
            this.chx_SelectFunc.CheckedChanged += new System.EventHandler(this.Chx_SelectFunc_CheckedChanged);
            // 
            // dgv_dataEntrega
            // 
            this.dgv_dataEntrega.AllowUserToAddRows = false;
            this.dgv_dataEntrega.AllowUserToDeleteRows = false;
            this.dgv_dataEntrega.AllowUserToResizeColumns = false;
            this.dgv_dataEntrega.AllowUserToResizeRows = false;
            this.dgv_dataEntrega.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dataEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entrega});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dataEntrega.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dataEntrega.Enabled = false;
            this.dgv_dataEntrega.Location = new System.Drawing.Point(10, 387);
            this.dgv_dataEntrega.Name = "dgv_dataEntrega";
            this.dgv_dataEntrega.ReadOnly = true;
            this.dgv_dataEntrega.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_dataEntrega.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dataEntrega.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_dataEntrega.Size = new System.Drawing.Size(105, 282);
            this.dgv_dataEntrega.TabIndex = 9;
            // 
            // Entrega
            // 
            this.Entrega.DataPropertyName = "Entrega";
            this.Entrega.HeaderText = "Data Entrega";
            this.Entrega.Name = "Entrega";
            this.Entrega.ReadOnly = true;
            this.Entrega.Width = 102;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(285, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ficha de controle e entrega de equipamento de proteção individual ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Setor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Colaborador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Função";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nº Registro";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(725, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data Admissão ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(724, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Demissão ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_setor
            // 
            this.txt_setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_setor.Location = new System.Drawing.Point(224, 121);
            this.txt_setor.Name = "txt_setor";
            this.txt_setor.ReadOnly = true;
            this.txt_setor.Size = new System.Drawing.Size(490, 22);
            this.txt_setor.TabIndex = 19;
            // 
            // txt_funcao
            // 
            this.txt_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcao.Location = new System.Drawing.Point(224, 171);
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.ReadOnly = true;
            this.txt_funcao.Size = new System.Drawing.Size(490, 22);
            this.txt_funcao.TabIndex = 20;
            // 
            // txt_colaborador
            // 
            this.txt_colaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_colaborador.Location = new System.Drawing.Point(224, 146);
            this.txt_colaborador.Name = "txt_colaborador";
            this.txt_colaborador.ReadOnly = true;
            this.txt_colaborador.Size = new System.Drawing.Size(306, 22);
            this.txt_colaborador.TabIndex = 21;
            // 
            // txt_Nreg
            // 
            this.txt_Nreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nreg.Location = new System.Drawing.Point(626, 146);
            this.txt_Nreg.Name = "txt_Nreg";
            this.txt_Nreg.ReadOnly = true;
            this.txt_Nreg.Size = new System.Drawing.Size(88, 22);
            this.txt_Nreg.TabIndex = 22;
            // 
            // dgv_assinaturas
            // 
            this.dgv_assinaturas.AllowUserToAddRows = false;
            this.dgv_assinaturas.AllowUserToDeleteRows = false;
            this.dgv_assinaturas.AllowUserToResizeColumns = false;
            this.dgv_assinaturas.AllowUserToResizeRows = false;
            this.dgv_assinaturas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_assinaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_assinaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assinatura,
            this.Devolução,
            this.AssDevolucao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_assinaturas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_assinaturas.Enabled = false;
            this.dgv_assinaturas.Location = new System.Drawing.Point(640, 387);
            this.dgv_assinaturas.Name = "dgv_assinaturas";
            this.dgv_assinaturas.ReadOnly = true;
            this.dgv_assinaturas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_assinaturas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_assinaturas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_assinaturas.Size = new System.Drawing.Size(427, 282);
            this.dgv_assinaturas.TabIndex = 25;
            // 
            // Assinatura
            // 
            this.Assinatura.HeaderText = "Ass. Entrega";
            this.Assinatura.Name = "Assinatura";
            this.Assinatura.ReadOnly = true;
            this.Assinatura.Width = 155;
            // 
            // Devolução
            // 
            this.Devolução.HeaderText = "Data Devolução";
            this.Devolução.Name = "Devolução";
            this.Devolução.ReadOnly = true;
            this.Devolução.Width = 110;
            // 
            // AssDevolucao
            // 
            this.AssDevolucao.HeaderText = "Ass. Devolução";
            this.AssDevolucao.Name = "AssDevolucao";
            this.AssDevolucao.ReadOnly = true;
            this.AssDevolucao.Width = 160;
            // 
            // dgv_descricoes
            // 
            this.dgv_descricoes.AllowUserToAddRows = false;
            this.dgv_descricoes.AllowUserToDeleteRows = false;
            this.dgv_descricoes.AllowUserToResizeColumns = false;
            this.dgv_descricoes.AllowUserToResizeRows = false;
            this.dgv_descricoes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_descricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_descricoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantidade,
            this.Column1,
            this.CA});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_descricoes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_descricoes.Enabled = false;
            this.dgv_descricoes.Location = new System.Drawing.Point(121, 387);
            this.dgv_descricoes.Name = "dgv_descricoes";
            this.dgv_descricoes.ReadOnly = true;
            this.dgv_descricoes.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_descricoes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_descricoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_descricoes.Size = new System.Drawing.Size(513, 282);
            this.dgv_descricoes.TabIndex = 26;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "qtd_lib";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "descricao";
            this.Column1.HeaderText = "DESCRIÇÃO DO EQUIPAMENTO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 355;
            // 
            // CA
            // 
            this.CA.HeaderText = "CA";
            this.CA.Name = "CA";
            this.CA.ReadOnly = true;
            this.CA.Width = 75;
            // 
            // txt_informacoes
            // 
            this.txt_informacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_informacoes.ForeColor = System.Drawing.Color.Black;
            this.txt_informacoes.Location = new System.Drawing.Point(10, 209);
            this.txt_informacoes.Multiline = true;
            this.txt_informacoes.Name = "txt_informacoes";
            this.txt_informacoes.ReadOnly = true;
            this.txt_informacoes.Size = new System.Drawing.Size(1055, 138);
            this.txt_informacoes.TabIndex = 27;
            this.txt_informacoes.Text = resources.GetString("txt_informacoes.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nº Req";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-42, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1189, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "____________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Nreq
            // 
            this.txt_Nreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nreq.Location = new System.Drawing.Point(846, 118);
            this.txt_Nreq.Name = "txt_Nreq";
            this.txt_Nreq.ReadOnly = true;
            this.txt_Nreq.Size = new System.Drawing.Size(100, 22);
            this.txt_Nreq.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(717, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nº Requerimento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1061, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "ASSINATURA DO COLABORADOR: ______________________________________________________" +
    "_______________________________________ DATA: _____/_____/__________";
            // 
            // txt_dataADM
            // 
            this.txt_dataADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataADM.Location = new System.Drawing.Point(846, 143);
            this.txt_dataADM.Mask = "00/00/0000";
            this.txt_dataADM.Name = "txt_dataADM";
            this.txt_dataADM.ReadOnly = true;
            this.txt_dataADM.Size = new System.Drawing.Size(100, 22);
            this.txt_dataADM.TabIndex = 39;
            this.txt_dataADM.ValidatingType = typeof(System.DateTime);
            // 
            // txt_dataDEM
            // 
            this.txt_dataDEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataDEM.Location = new System.Drawing.Point(846, 170);
            this.txt_dataDEM.Mask = "00/00/0000";
            this.txt_dataDEM.Name = "txt_dataDEM";
            this.txt_dataDEM.ReadOnly = true;
            this.txt_dataDEM.Size = new System.Drawing.Size(100, 22);
            this.txt_dataDEM.TabIndex = 40;
            this.txt_dataDEM.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_restante
            // 
            this.lbl_restante.AutoSize = true;
            this.lbl_restante.Location = new System.Drawing.Point(1024, 114);
            this.lbl_restante.Name = "lbl_restante";
            this.lbl_restante.Size = new System.Drawing.Size(56, 13);
            this.lbl_restante.TabIndex = 41;
            this.lbl_restante.Text = "rest_inicial";
            this.lbl_restante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_restante.Visible = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(1023, 134);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(27, 13);
            this.lbl_total.TabIndex = 42;
            this.lbl_total.Text = "total";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total.Visible = false;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(120, 10);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(54, 20);
            this.txt_status.TabIndex = 43;
            this.txt_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_imprime
            // 
            this.btn_imprime.Location = new System.Drawing.Point(174, 8);
            this.btn_imprime.Name = "btn_imprime";
            this.btn_imprime.Size = new System.Drawing.Size(56, 23);
            this.btn_imprime.TabIndex = 44;
            this.btn_imprime.Text = "Imprime";
            this.btn_imprime.UseVisualStyleBackColor = true;
            this.btn_imprime.Click += new System.EventHandler(this.Btn_imprime_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(6, 8);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(56, 23);
            this.btn_anterior.TabIndex = 45;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.Btn_anterior_Click);
            // 
            // txt_contrato
            // 
            this.txt_contrato.Location = new System.Drawing.Point(121, 8);
            this.txt_contrato.Name = "txt_contrato";
            this.txt_contrato.ReadOnly = true;
            this.txt_contrato.Size = new System.Drawing.Size(279, 20);
            this.txt_contrato.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chx_visualizar);
            this.groupBox1.Controls.Add(this.btn_proximo);
            this.groupBox1.Controls.Add(this.btn_anterior);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.btn_imprime);
            this.groupBox1.Location = new System.Drawing.Point(760, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 34);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // chx_visualizar
            // 
            this.chx_visualizar.AutoSize = true;
            this.chx_visualizar.Location = new System.Drawing.Point(237, 12);
            this.chx_visualizar.Name = "chx_visualizar";
            this.chx_visualizar.Size = new System.Drawing.Size(70, 17);
            this.chx_visualizar.TabIndex = 46;
            this.chx_visualizar.Text = "Visualizar";
            this.chx_visualizar.UseVisualStyleBackColor = true;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(1024, 154);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(49, 13);
            this.lbl_matricula.TabIndex = 48;
            this.lbl_matricula.Text = "matricula";
            this.lbl_matricula.Visible = false;
            // 
            // frm_ReqImpressaoFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 681);
            this.Controls.Add(this.cbx_SelectFunc);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_contrato);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_restante);
            this.Controls.Add(this.txt_dataDEM);
            this.Controls.Add(this.txt_dataADM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Nreq);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_informacoes);
            this.Controls.Add(this.dgv_descricoes);
            this.Controls.Add(this.dgv_assinaturas);
            this.Controls.Add(this.txt_Nreg);
            this.Controls.Add(this.txt_colaborador);
            this.Controls.Add(this.txt_funcao);
            this.Controls.Add(this.txt_setor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dataEntrega);
            this.Controls.Add(this.chx_SelectFunc);
            this.Controls.Add(this.cbx_nreq);
            this.Name = "frm_ReqImpressaoFicha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Impressão de Fichas EPI";
            this.Load += new System.EventHandler(this.Frm_ReqImpressaoFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assinaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_descricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_proximo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cbx_nreq;
        private System.Windows.Forms.ComboBox cbx_SelectFunc;
        private System.Windows.Forms.CheckBox chx_SelectFunc;
        private System.Windows.Forms.DataGridView dgv_dataEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_setor;
        private System.Windows.Forms.TextBox txt_funcao;
        private System.Windows.Forms.TextBox txt_colaborador;
        private System.Windows.Forms.TextBox txt_Nreg;
        private System.Windows.Forms.DataGridView dgv_assinaturas;
        private System.Windows.Forms.DataGridView dgv_descricoes;
        private System.Windows.Forms.TextBox txt_informacoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Nreq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_dataADM;
        private System.Windows.Forms.MaskedTextBox txt_dataDEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assinatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolução;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA;
        private System.Windows.Forms.Label lbl_restante;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_imprime;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.TextBox txt_contrato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.CheckBox chx_visualizar;
    }
}