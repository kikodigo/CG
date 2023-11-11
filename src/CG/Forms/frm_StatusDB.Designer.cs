namespace CG
{
    partial class frm_StatusDB : Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StatusDB));
            pnl_header = new Panel();
            lbl_headerText = new Label();
            pictureBox1 = new PictureBox();
            btn_entrar = new Button();
            lbl_erro = new Label();
            lbl_cadastro = new Label();
            label1 = new Label();
            lbl_StatusDb = new Label();
            btn_Reconect = new Button();
            pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Anchor = AnchorStyles.None;
            pnl_header.BackColor = Color.Gray;
            pnl_header.Controls.Add(lbl_headerText);
            pnl_header.ForeColor = SystemColors.ControlText;
            pnl_header.Location = new Point(-10, -186);
            pnl_header.Margin = new Padding(5, 4, 5, 4);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(472, 184);
            pnl_header.TabIndex = 10;
            // 
            // lbl_headerText
            // 
            lbl_headerText.AutoSize = true;
            lbl_headerText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_headerText.ForeColor = SystemColors.ControlLight;
            lbl_headerText.Location = new Point(175, 79);
            lbl_headerText.Margin = new Padding(5, 0, 5, 0);
            lbl_headerText.Name = "lbl_headerText";
            lbl_headerText.Size = new Size(0, 31);
            lbl_headerText.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.C_G;
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btn_entrar
            // 
            btn_entrar.Anchor = AnchorStyles.None;
            btn_entrar.BackColor = Color.FromArgb(64, 67, 73);
            btn_entrar.Enabled = false;
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.ForeColor = SystemColors.ControlLightLight;
            btn_entrar.Location = new Point(49, 305);
            btn_entrar.Margin = new Padding(5, 4, 5, 4);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(174, 61);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // lbl_erro
            // 
            lbl_erro.Anchor = AnchorStyles.None;
            lbl_erro.AutoSize = true;
            lbl_erro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_erro.ForeColor = Color.Red;
            lbl_erro.Location = new Point(49, 333);
            lbl_erro.Margin = new Padding(5, 0, 5, 0);
            lbl_erro.Name = "lbl_erro";
            lbl_erro.Size = new Size(0, 25);
            lbl_erro.TabIndex = 11;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.Anchor = AnchorStyles.None;
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cadastro.ForeColor = SystemColors.Control;
            lbl_cadastro.Location = new Point(49, 398);
            lbl_cadastro.Margin = new Padding(5, 0, 5, 0);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(0, 25);
            lbl_cadastro.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 224);
            label1.Name = "label1";
            label1.Size = new Size(118, 35);
            label1.TabIndex = 16;
            label1.Text = "StatusDB:";
            // 
            // lbl_StatusDb
            // 
            lbl_StatusDb.AutoSize = true;
            lbl_StatusDb.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_StatusDb.Location = new Point(220, 225);
            lbl_StatusDb.Name = "lbl_StatusDb";
            lbl_StatusDb.Size = new Size(161, 35);
            lbl_StatusDb.TabIndex = 17;
            lbl_StatusDb.Text = "Carregando...";
            // 
            // btn_Reconect
            // 
            btn_Reconect.Anchor = AnchorStyles.None;
            btn_Reconect.BackColor = Color.FromArgb(64, 67, 73);
            btn_Reconect.FlatAppearance.BorderSize = 0;
            btn_Reconect.FlatStyle = FlatStyle.Flat;
            btn_Reconect.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Reconect.ForeColor = SystemColors.ControlLightLight;
            btn_Reconect.Location = new Point(233, 305);
            btn_Reconect.Margin = new Padding(5, 4, 5, 4);
            btn_Reconect.Name = "btn_Reconect";
            btn_Reconect.Size = new Size(174, 61);
            btn_Reconect.TabIndex = 18;
            btn_Reconect.Text = "Reconectar";
            btn_Reconect.UseVisualStyleBackColor = false;
            btn_Reconect.Click += btn_Reconect_Click;
            // 
            // frm_StatusDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(456, 394);
            Controls.Add(btn_Reconect);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_StatusDb);
            Controls.Add(label1);
            Controls.Add(lbl_cadastro);
            Controls.Add(lbl_erro);
            Controls.Add(pnl_header);
            Controls.Add(btn_entrar);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "frm_StatusDB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CG - Login";
            Load += frm_StatusDB_Load;
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnl_header;
        private Button btn_entrar;
        private Label lbl_erro;
        private Label lbl_cadastro;
        private Label lbl_headerText;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbl_StatusDb;
        private Button btn_Reconect;
    }
}

