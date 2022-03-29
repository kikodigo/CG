namespace CG.TelaInicial.ControleEstoque.Entrada
{
    partial class frm_VistoriaXml
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
            this.dgv_TabelaItens = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsm_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_usuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelecionarXml = new System.Windows.Forms.Button();
            this.lbl_Cnpj = new System.Windows.Forms.Label();
            this.lbl_DataEmissao = new System.Windows.Forms.Label();
            this.lbl_NNota = new System.Windows.Forms.Label();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_DataEmissao = new System.Windows.Forms.TextBox();
            this.txt_Nnota = new System.Windows.Forms.TextBox();
            this.lbl_Fornecedor = new System.Windows.Forms.Label();
            this.txt_Fornecedor = new System.Windows.Forms.TextBox();
            this.lbl_VlTotalCompra = new System.Windows.Forms.Label();
            this.txt_VlTotalNota = new System.Windows.Forms.TextBox();
            this.dgv_Falha = new System.Windows.Forms.DataGridView();
            this.dgv_Itens = new System.Windows.Forms.DataGridView();
            this.btn_Liberar = new System.Windows.Forms.Button();
            this.tbc_Itens = new System.Windows.Forms.TabControl();
            this.tbp_ConteudoXml = new System.Windows.Forms.TabPage();
            this.tbp_ItensInseridos = new System.Windows.Forms.TabPage();
            this.tbp_Falha = new System.Windows.Forms.TabPage();
            this.lbl_CodForne = new System.Windows.Forms.Label();
            this.txt_CodForne = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaItens)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Falha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens)).BeginInit();
            this.tbc_Itens.SuspendLayout();
            this.tbp_ConteudoXml.SuspendLayout();
            this.tbp_ItensInseridos.SuspendLayout();
            this.tbp_Falha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TabelaItens
            // 
            this.dgv_TabelaItens.AllowUserToAddRows = false;
            this.dgv_TabelaItens.AllowUserToDeleteRows = false;
            this.dgv_TabelaItens.AllowUserToResizeRows = false;
            this.dgv_TabelaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_TabelaItens.Location = new System.Drawing.Point(6, 6);
            this.dgv_TabelaItens.Name = "dgv_TabelaItens";
            this.dgv_TabelaItens.RowHeadersVisible = false;
            this.dgv_TabelaItens.Size = new System.Drawing.Size(930, 503);
            this.dgv_TabelaItens.TabIndex = 167;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_novo,
            this.tsm_editar,
            this.tsm_salvar,
            this.tsm_cancelar,
            this.tsm_anterior,
            this.tsm_proximo,
            this.tsm_pesquisar,
            this.tsm_excluir,
            this.txt_usuario,
            this.toolStripMenuItem6});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(974, 27);
            this.menuStrip2.TabIndex = 168;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsm_novo
            // 
            this.tsm_novo.Name = "tsm_novo";
            this.tsm_novo.Size = new System.Drawing.Size(48, 23);
            this.tsm_novo.Text = "Novo";
            this.tsm_novo.Visible = false;
            // 
            // tsm_editar
            // 
            this.tsm_editar.Name = "tsm_editar";
            this.tsm_editar.Size = new System.Drawing.Size(49, 23);
            this.tsm_editar.Text = "Editar";
            this.tsm_editar.Visible = false;
            // 
            // tsm_salvar
            // 
            this.tsm_salvar.Name = "tsm_salvar";
            this.tsm_salvar.Size = new System.Drawing.Size(50, 23);
            this.tsm_salvar.Text = "Salvar";
            this.tsm_salvar.Visible = false;
            // 
            // tsm_cancelar
            // 
            this.tsm_cancelar.Name = "tsm_cancelar";
            this.tsm_cancelar.Size = new System.Drawing.Size(65, 23);
            this.tsm_cancelar.Text = "Cancelar";
            this.tsm_cancelar.Visible = false;
            // 
            // tsm_anterior
            // 
            this.tsm_anterior.Name = "tsm_anterior";
            this.tsm_anterior.Size = new System.Drawing.Size(62, 23);
            this.tsm_anterior.Text = "Anterior";
            this.tsm_anterior.Visible = false;
            // 
            // tsm_proximo
            // 
            this.tsm_proximo.Name = "tsm_proximo";
            this.tsm_proximo.Size = new System.Drawing.Size(64, 23);
            this.tsm_proximo.Text = "Proximo";
            this.tsm_proximo.Visible = false;
            // 
            // tsm_pesquisar
            // 
            this.tsm_pesquisar.Name = "tsm_pesquisar";
            this.tsm_pesquisar.Size = new System.Drawing.Size(65, 23);
            this.tsm_pesquisar.Text = "Pesquisa";
            this.tsm_pesquisar.Visible = false;
            // 
            // tsm_excluir
            // 
            this.tsm_excluir.Name = "tsm_excluir";
            this.tsm_excluir.Size = new System.Drawing.Size(54, 23);
            this.tsm_excluir.Text = "Excluir";
            this.tsm_excluir.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(59, 23);
            this.toolStripMenuItem6.Text = "Usuario";
            // 
            // btn_SelecionarXml
            // 
            this.btn_SelecionarXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SelecionarXml.FlatAppearance.BorderSize = 0;
            this.btn_SelecionarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelecionarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelecionarXml.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SelecionarXml.Location = new System.Drawing.Point(804, 86);
            this.btn_SelecionarXml.Name = "btn_SelecionarXml";
            this.btn_SelecionarXml.Size = new System.Drawing.Size(154, 30);
            this.btn_SelecionarXml.TabIndex = 169;
            this.btn_SelecionarXml.Text = "Selecione Xml";
            this.btn_SelecionarXml.UseVisualStyleBackColor = false;
            this.btn_SelecionarXml.Click += new System.EventHandler(this.Btn_SelecionarXml_Click);
            // 
            // lbl_Cnpj
            // 
            this.lbl_Cnpj.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_Cnpj.AutoSize = true;
            this.lbl_Cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cnpj.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Cnpj.Location = new System.Drawing.Point(842, 31);
            this.lbl_Cnpj.Name = "lbl_Cnpj";
            this.lbl_Cnpj.Size = new System.Drawing.Size(48, 18);
            this.lbl_Cnpj.TabIndex = 198;
            this.lbl_Cnpj.Text = "CNPJ";
            // 
            // lbl_DataEmissao
            // 
            this.lbl_DataEmissao.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_DataEmissao.AutoSize = true;
            this.lbl_DataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataEmissao.ForeColor = System.Drawing.Color.Gray;
            this.lbl_DataEmissao.Location = new System.Drawing.Point(97, 76);
            this.lbl_DataEmissao.Name = "lbl_DataEmissao";
            this.lbl_DataEmissao.Size = new System.Drawing.Size(102, 18);
            this.lbl_DataEmissao.TabIndex = 197;
            this.lbl_DataEmissao.Text = "Data Emissão";
            // 
            // lbl_NNota
            // 
            this.lbl_NNota.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_NNota.AutoSize = true;
            this.lbl_NNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NNota.ForeColor = System.Drawing.Color.Gray;
            this.lbl_NNota.Location = new System.Drawing.Point(9, 75);
            this.lbl_NNota.Name = "lbl_NNota";
            this.lbl_NNota.Size = new System.Drawing.Size(80, 18);
            this.lbl_NNota.TabIndex = 196;
            this.lbl_NNota.Text = "Nº da Nota";
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Enabled = false;
            this.mtb_cnpj.Location = new System.Drawing.Point(845, 52);
            this.mtb_cnpj.Mask = "00,000,000/0000-00";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(117, 20);
            this.mtb_cnpj.TabIndex = 195;
            // 
            // txt_DataEmissao
            // 
            this.txt_DataEmissao.Enabled = false;
            this.txt_DataEmissao.Location = new System.Drawing.Point(100, 96);
            this.txt_DataEmissao.Name = "txt_DataEmissao";
            this.txt_DataEmissao.Size = new System.Drawing.Size(99, 20);
            this.txt_DataEmissao.TabIndex = 194;
            // 
            // txt_Nnota
            // 
            this.txt_Nnota.Enabled = false;
            this.txt_Nnota.Location = new System.Drawing.Point(12, 96);
            this.txt_Nnota.Name = "txt_Nnota";
            this.txt_Nnota.Size = new System.Drawing.Size(82, 20);
            this.txt_Nnota.TabIndex = 193;
            // 
            // lbl_Fornecedor
            // 
            this.lbl_Fornecedor.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_Fornecedor.AutoSize = true;
            this.lbl_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fornecedor.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Fornecedor.Location = new System.Drawing.Point(129, 31);
            this.lbl_Fornecedor.Name = "lbl_Fornecedor";
            this.lbl_Fornecedor.Size = new System.Drawing.Size(85, 18);
            this.lbl_Fornecedor.TabIndex = 201;
            this.lbl_Fornecedor.Text = "Fornecedor";
            // 
            // txt_Fornecedor
            // 
            this.txt_Fornecedor.Enabled = false;
            this.txt_Fornecedor.Location = new System.Drawing.Point(132, 52);
            this.txt_Fornecedor.Name = "txt_Fornecedor";
            this.txt_Fornecedor.Size = new System.Drawing.Size(707, 20);
            this.txt_Fornecedor.TabIndex = 202;
            // 
            // lbl_VlTotalCompra
            // 
            this.lbl_VlTotalCompra.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_VlTotalCompra.AutoSize = true;
            this.lbl_VlTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VlTotalCompra.ForeColor = System.Drawing.Color.Gray;
            this.lbl_VlTotalCompra.Location = new System.Drawing.Point(202, 75);
            this.lbl_VlTotalCompra.Name = "lbl_VlTotalCompra";
            this.lbl_VlTotalCompra.Size = new System.Drawing.Size(120, 18);
            this.lbl_VlTotalCompra.TabIndex = 204;
            this.lbl_VlTotalCompra.Text = "Valor da Compra";
            // 
            // txt_VlTotalNota
            // 
            this.txt_VlTotalNota.Enabled = false;
            this.txt_VlTotalNota.Location = new System.Drawing.Point(205, 96);
            this.txt_VlTotalNota.Name = "txt_VlTotalNota";
            this.txt_VlTotalNota.Size = new System.Drawing.Size(154, 20);
            this.txt_VlTotalNota.TabIndex = 203;
            // 
            // dgv_Falha
            // 
            this.dgv_Falha.AllowUserToAddRows = false;
            this.dgv_Falha.AllowUserToDeleteRows = false;
            this.dgv_Falha.AllowUserToResizeRows = false;
            this.dgv_Falha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Falha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Falha.Location = new System.Drawing.Point(6, 6);
            this.dgv_Falha.Name = "dgv_Falha";
            this.dgv_Falha.RowHeadersVisible = false;
            this.dgv_Falha.Size = new System.Drawing.Size(930, 503);
            this.dgv_Falha.TabIndex = 206;
            // 
            // dgv_Itens
            // 
            this.dgv_Itens.AllowUserToAddRows = false;
            this.dgv_Itens.AllowUserToDeleteRows = false;
            this.dgv_Itens.AllowUserToResizeRows = false;
            this.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Itens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Itens.Location = new System.Drawing.Point(6, 6);
            this.dgv_Itens.Name = "dgv_Itens";
            this.dgv_Itens.RowHeadersVisible = false;
            this.dgv_Itens.Size = new System.Drawing.Size(930, 503);
            this.dgv_Itens.TabIndex = 207;
            // 
            // btn_Liberar
            // 
            this.btn_Liberar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Liberar.FlatAppearance.BorderSize = 0;
            this.btn_Liberar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Liberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Liberar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Liberar.Location = new System.Drawing.Point(644, 86);
            this.btn_Liberar.Name = "btn_Liberar";
            this.btn_Liberar.Size = new System.Drawing.Size(154, 30);
            this.btn_Liberar.TabIndex = 208;
            this.btn_Liberar.Text = "Liberar Itens";
            this.btn_Liberar.UseVisualStyleBackColor = false;
            this.btn_Liberar.Click += new System.EventHandler(this.Btn_Liberar_Click);
            // 
            // tbc_Itens
            // 
            this.tbc_Itens.Controls.Add(this.tbp_ConteudoXml);
            this.tbc_Itens.Controls.Add(this.tbp_ItensInseridos);
            this.tbc_Itens.Controls.Add(this.tbp_Falha);
            this.tbc_Itens.Location = new System.Drawing.Point(12, 128);
            this.tbc_Itens.Name = "tbc_Itens";
            this.tbc_Itens.SelectedIndex = 0;
            this.tbc_Itens.Size = new System.Drawing.Size(950, 541);
            this.tbc_Itens.TabIndex = 209;
            // 
            // tbp_ConteudoXml
            // 
            this.tbp_ConteudoXml.BackColor = System.Drawing.Color.DimGray;
            this.tbp_ConteudoXml.Controls.Add(this.dgv_TabelaItens);
            this.tbp_ConteudoXml.Location = new System.Drawing.Point(4, 22);
            this.tbp_ConteudoXml.Name = "tbp_ConteudoXml";
            this.tbp_ConteudoXml.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ConteudoXml.Size = new System.Drawing.Size(942, 515);
            this.tbp_ConteudoXml.TabIndex = 0;
            this.tbp_ConteudoXml.Text = "Conteudo da XML";
            // 
            // tbp_ItensInseridos
            // 
            this.tbp_ItensInseridos.BackColor = System.Drawing.Color.DimGray;
            this.tbp_ItensInseridos.Controls.Add(this.dgv_Itens);
            this.tbp_ItensInseridos.Location = new System.Drawing.Point(4, 22);
            this.tbp_ItensInseridos.Name = "tbp_ItensInseridos";
            this.tbp_ItensInseridos.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ItensInseridos.Size = new System.Drawing.Size(942, 515);
            this.tbp_ItensInseridos.TabIndex = 1;
            this.tbp_ItensInseridos.Text = "Itens a ser inserido";
            // 
            // tbp_Falha
            // 
            this.tbp_Falha.BackColor = System.Drawing.Color.DimGray;
            this.tbp_Falha.Controls.Add(this.dgv_Falha);
            this.tbp_Falha.Location = new System.Drawing.Point(4, 22);
            this.tbp_Falha.Name = "tbp_Falha";
            this.tbp_Falha.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Falha.Size = new System.Drawing.Size(942, 515);
            this.tbp_Falha.TabIndex = 2;
            this.tbp_Falha.Text = "Itens com falha";
            // 
            // lbl_CodForne
            // 
            this.lbl_CodForne.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_CodForne.AutoSize = true;
            this.lbl_CodForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodForne.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CodForne.Location = new System.Drawing.Point(9, 31);
            this.lbl_CodForne.Name = "lbl_CodForne";
            this.lbl_CodForne.Size = new System.Drawing.Size(117, 18);
            this.lbl_CodForne.TabIndex = 211;
            this.lbl_CodForne.Text = "Cod Fornecedor";
            // 
            // txt_CodForne
            // 
            this.txt_CodForne.Enabled = false;
            this.txt_CodForne.Location = new System.Drawing.Point(12, 52);
            this.txt_CodForne.Name = "txt_CodForne";
            this.txt_CodForne.Size = new System.Drawing.Size(114, 20);
            this.txt_CodForne.TabIndex = 210;
            // 
            // frm_VistoriaXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.lbl_CodForne);
            this.Controls.Add(this.txt_CodForne);
            this.Controls.Add(this.tbc_Itens);
            this.Controls.Add(this.btn_Liberar);
            this.Controls.Add(this.lbl_VlTotalCompra);
            this.Controls.Add(this.txt_VlTotalNota);
            this.Controls.Add(this.txt_Fornecedor);
            this.Controls.Add(this.lbl_Fornecedor);
            this.Controls.Add(this.lbl_Cnpj);
            this.Controls.Add(this.lbl_DataEmissao);
            this.Controls.Add(this.lbl_NNota);
            this.Controls.Add(this.mtb_cnpj);
            this.Controls.Add(this.txt_DataEmissao);
            this.Controls.Add(this.txt_Nnota);
            this.Controls.Add(this.btn_SelecionarXml);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frm_VistoriaXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VistoriaXml";
            this.Load += new System.EventHandler(this.Frm_VistoriaXml_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaItens)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Falha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens)).EndInit();
            this.tbc_Itens.ResumeLayout(false);
            this.tbp_ConteudoXml.ResumeLayout(false);
            this.tbp_ItensInseridos.ResumeLayout(false);
            this.tbp_Falha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TabelaItens;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsm_novo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editar;
        private System.Windows.Forms.ToolStripMenuItem tsm_salvar;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_pesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir;
        private System.Windows.Forms.ToolStripTextBox txt_usuario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button btn_SelecionarXml;
        private System.Windows.Forms.Label lbl_Cnpj;
        private System.Windows.Forms.Label lbl_DataEmissao;
        private System.Windows.Forms.Label lbl_NNota;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.TextBox txt_DataEmissao;
        private System.Windows.Forms.TextBox txt_Nnota;
        private System.Windows.Forms.Label lbl_Fornecedor;
        private System.Windows.Forms.TextBox txt_Fornecedor;
        private System.Windows.Forms.Label lbl_VlTotalCompra;
        private System.Windows.Forms.TextBox txt_VlTotalNota;
        private System.Windows.Forms.DataGridView dgv_Falha;
        private System.Windows.Forms.DataGridView dgv_Itens;
        private System.Windows.Forms.Button btn_Liberar;
        private System.Windows.Forms.TabControl tbc_Itens;
        private System.Windows.Forms.TabPage tbp_ConteudoXml;
        private System.Windows.Forms.TabPage tbp_ItensInseridos;
        private System.Windows.Forms.TabPage tbp_Falha;
        private System.Windows.Forms.Label lbl_CodForne;
        private System.Windows.Forms.TextBox txt_CodForne;
    }
}