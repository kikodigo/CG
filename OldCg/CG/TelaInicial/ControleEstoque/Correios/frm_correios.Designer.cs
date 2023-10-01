
namespace CG.TelaInicial.ControleEstoque.Correios
{
    partial class frm_correios
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
            this.btn_Rastrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CodObj = new System.Windows.Forms.TextBox();
            this.txt_Local = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Rastrear
            // 
            this.btn_Rastrear.Location = new System.Drawing.Point(390, 151);
            this.btn_Rastrear.Name = "btn_Rastrear";
            this.btn_Rastrear.Size = new System.Drawing.Size(75, 23);
            this.btn_Rastrear.TabIndex = 0;
            this.btn_Rastrear.Text = "Rastrear";
            this.btn_Rastrear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Obj";
            // 
            // txt_CodObj
            // 
            this.txt_CodObj.Location = new System.Drawing.Point(178, 154);
            this.txt_CodObj.Name = "txt_CodObj";
            this.txt_CodObj.Size = new System.Drawing.Size(206, 20);
            this.txt_CodObj.TabIndex = 2;
            // 
            // txt_Local
            // 
            this.txt_Local.Location = new System.Drawing.Point(284, 204);
            this.txt_Local.Name = "txt_Local";
            this.txt_Local.Size = new System.Drawing.Size(100, 20);
            this.txt_Local.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local";
            // 
            // txt_Data
            // 
            this.txt_Data.Location = new System.Drawing.Point(284, 245);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(100, 20);
            this.txt_Data.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data e hora";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(178, 287);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(206, 20);
            this.txt_Descricao.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição";
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(178, 204);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(100, 20);
            this.txt_Categoria.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(178, 243);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo";
            // 
            // frm_correios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Local);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CodObj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Rastrear);
            this.Name = "frm_correios";
            this.Text = "frm_correios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rastrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CodObj;
        private System.Windows.Forms.TextBox txt_Local;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label6;
    }
}