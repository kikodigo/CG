using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;


namespace CG.Tela_Inicial.Requisição.Consulta
{
    public partial class frm_ReqConsulta : Form
    {
        public frm_ReqConsulta()
        {
            InitializeComponent();
        }
        public frm_ReqConsulta(string usuario)
        {
            
            InitializeComponent();
            txt_usuario.Text = usuario;
        }

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();
        private void Frm_ReqConsulta_Load(object sender, EventArgs e)
        {
            dadosql = string.Format("SELECT `codreq`,`data`,`contrato`,`data_aprov`,`status`,`obs`,`prev`,`data_envio`,`tipo_envio`,`retorno_ficha` FROM `requerimento` ORDER BY `codreq` DESC");
            dgv_ReqPesquisa.DataSource = mConn.LeituraLinha(dadosql);            
            cbx_coluna.Text = "N°Req";           
        }

        private void Txt_referencia_TextChanged(object sender, EventArgs e)
        {
            string coluna = cbx_coluna.Text;
            switch (coluna)
            {
                case "N°Req":
                    coluna = "codreq";
                    break;

                case "Contrato":
                    coluna = "contrato";
                    break;

                case "Data":
                    coluna = "data";
                    break;

                case "Data Aprovado":
                    coluna = "data_aprov";
                    break;

                case "Status":
                    coluna = "status";
                    break;
            }
            dadosql = string.Format("SELECT `codreq`,`data`,`contrato`,`data_aprov`,`status`,`obs`,`prev`,`data_envio`,`tipo_envio`,`retorno_ficha` FROM `requerimento` WHERE `{0}` LIKE '%{1}%' ORDER BY `codreq` DESC ", coluna, txt_referencia.Text);
            dgv_ReqPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }

        private void Dgv_ReqPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_controle.Text = dgv_ReqPesquisa.CurrentRow.Cells[0].Value.ToString();
            txt_numreq.Text = dgv_ReqPesquisa.CurrentRow.Cells[0].Value.ToString();
            txt_data.Text = Convert.ToDateTime(dgv_ReqPesquisa.CurrentRow.Cells[1].Value).ToString("dd/MM/yyyy").Replace("01/01/0001", "");
            txt_contrato.Text = dgv_ReqPesquisa.CurrentRow.Cells[2].Value.ToString();
            txt_aprovado.Text = Convert.ToDateTime(dgv_ReqPesquisa.CurrentRow.Cells[3].Value).ToString("dd/MM/yyyy").Replace("01/01/0001", "");
            txt_status.Text = dgv_ReqPesquisa.CurrentRow.Cells[4].Value.ToString();
            txt_observacao.Text = dgv_ReqPesquisa.CurrentRow.Cells[5].Value.ToString();
            txt_DataEnvio.Text = Convert.ToDateTime(dgv_ReqPesquisa.CurrentRow.Cells[6].Value).ToString("dd/MM/yyyy").Replace("01/01/0001","");
            txt_Previsao.Text = Convert.ToDateTime(dgv_ReqPesquisa.CurrentRow.Cells[7].Value).ToString("dd/MM/yyyy").Replace("01/01/0001", "");
            txt_TipoEnvio.Text = dgv_ReqPesquisa.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
