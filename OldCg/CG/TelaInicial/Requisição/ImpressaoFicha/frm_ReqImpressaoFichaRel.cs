using System;
using System.Data;
using System.Windows.Forms;

namespace CG.Tela_Inicial.Requisição.Impressão_Ficha
{
    public partial class frm_ReqImpressaoFichaRel : Form
    {
        public frm_ReqImpressaoFichaRel()
        {
            InitializeComponent();
        }
        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        private void Frm_ReqImpressaoFichaRel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_cgDataSet.req_item'. Você pode movê-la ou removê-la conforme necessário.
            //this.req_itemTableAdapter.Fill(this.db_cgDataSet.req_item);

            DataSet ficha = new DataSet();


            dadosql = string.Format("SELECT * FROM `req_item` where matr_func = '2420' and codreq = '30'");

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "X:\\Publico\\TI\\Visual Studio\\Controle Gest\\CG\\CG\\TelaInicial\\Requisição\\ImpressaoFicha\\rel_ficha.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dataset_ficha", mConn.ConsultaTabela(dadosql)));
            reportViewer1.DocumentMapCollapsed = true;


            this.reportViewer1.RefreshReport();


            // this.req_itemTableAdapter.Fill(mConn.ConsultaTabela(dadosql));
        }

    }
}
