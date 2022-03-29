namespace CG.Tela_Inicial.Requisição.Impressão_Ficha
{
    partial class frm_ReqImpressaoFichaRel
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_cgDataSet = new CG.db_cgDataSet();
            this.reqitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.req_itemTableAdapter = new CG.db_cgDataSetTableAdapters.req_itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_cgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqitemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataset_ficha";
            reportDataSource1.Value = this.reqitemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CG.TelaInicial.Requisição.ImpressaoFicha.rel_ficha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_cgDataSet
            // 
            this.db_cgDataSet.DataSetName = "db_cgDataSet";
            this.db_cgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reqitemBindingSource
            // 
            this.reqitemBindingSource.DataMember = "req_item";
            this.reqitemBindingSource.DataSource = this.db_cgDataSet;
            // 
            // req_itemTableAdapter
            // 
            this.req_itemTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReqImpressaoFichaRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReqImpressaoFichaRel";
            this.Text = "frm_ReqImpressaoFichaRel";
            this.Load += new System.EventHandler(this.Frm_ReqImpressaoFichaRel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_cgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqitemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_cgDataSet db_cgDataSet;
        private System.Windows.Forms.BindingSource reqitemBindingSource;
        private db_cgDataSetTableAdapters.req_itemTableAdapter req_itemTableAdapter;
    }
}