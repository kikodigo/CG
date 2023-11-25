
namespace CG.TelaInicial.ControleEstoque.Saida
{
    partial class frm_ControleSaida_SemEstoque
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
            this.dgv_ControleSaidaSemEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControleSaidaSemEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ControleSaidaSemEstoque
            // 
            this.dgv_ControleSaidaSemEstoque.AllowUserToAddRows = false;
            this.dgv_ControleSaidaSemEstoque.AllowUserToDeleteRows = false;
            this.dgv_ControleSaidaSemEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ControleSaidaSemEstoque.Location = new System.Drawing.Point(12, 12);
            this.dgv_ControleSaidaSemEstoque.Name = "dgv_ControleSaidaSemEstoque";
            this.dgv_ControleSaidaSemEstoque.ReadOnly = true;
            this.dgv_ControleSaidaSemEstoque.RowHeadersVisible = false;
            this.dgv_ControleSaidaSemEstoque.Size = new System.Drawing.Size(950, 657);
            this.dgv_ControleSaidaSemEstoque.TabIndex = 167;
            // 
            // frm_ControleSaida_SemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.dgv_ControleSaidaSemEstoque);
            this.Name = "frm_ControleSaida_SemEstoque";
            this.Text = "frm_ControleSaida_SemEstoque";
            this.Load += new System.EventHandler(this.frm_ControleSaida_SemEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControleSaidaSemEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ControleSaidaSemEstoque;
    }
}