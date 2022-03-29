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

namespace CG.Tela_Inicial.Requisição.Retorno_Ficha
{
    public partial class frm_ReqRetornoFicha : Form
    {
        public frm_ReqRetornoFicha()
        {
            InitializeComponent();
        }

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();
        private void Frm_ReqRetornoFicha_Load(object sender, EventArgs e)
        {
            dadosql = string.Format("SELECT `codreq`,`contrato`,`retorno_ficha` FROM `requerimento` where `status` <> \"EM ANDAMENTO\" AND `status`<> \"AGUARDANDO APROVAÇÃO\" ORDER BY `codreq` DESC");
            dgv_reqcontrato.DataSource = mConn.LeituraLinha(dadosql);
           
        }

        private void Dgv_reqcontrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nreq = this.dgv_reqcontrato.CurrentRow.Cells[0].Value.ToString();
            txt_NumReq.Text = this.dgv_reqcontrato.CurrentRow.Cells[0].Value.ToString();
            txt_contrato.Text = this.dgv_reqcontrato.CurrentRow.Cells[1].Value.ToString();
            txt_FichaEpi.Text = this.dgv_reqcontrato.CurrentRow.Cells[2].Value.ToString();
            txt_matricula.Text = "";
            txt_funcionario.Text = "";
            txt_retorno.Text = "";
            txt_retorno.Enabled = false;

            dadosql = string.Format(" SELECT `matr_func`,`func`,`retorno_ficha` FROM `req_func` where `codreq` = '{0}' ORDER BY `func` DESC",nreq);
            dgv_func.DataSource = mConn.LeituraLinha(dadosql);
            
        }

        private void Dgv_func_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_matricula.Text = dgv_func.CurrentRow.Cells[0].Value.ToString();
            txt_funcionario.Text = dgv_func.CurrentRow.Cells[1].Value.ToString();
            txt_retorno.Text = Convert.ToDateTime(dgv_func.CurrentRow.Cells[2].Value).ToString("dd/MM/yyyy").Replace("01/01/0001", "");
            if (txt_retorno.Text == "")
            {
                txt_retorno.Enabled = true;
            }
            else
            {
                txt_retorno.Enabled = false;
            }
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("UPDATE `req_func` SET `retorno_ficha` = '{0}' WHERE `req_func`.`codreq` = '{1}' and `matr_func`= '{2}' ", Convert.ToDateTime(txt_retorno.Text).ToString("yyyy-MM-dd"), txt_NumReq.Text,txt_matricula.Text);
            mConn.LeituraLinha(dadosql);

            

            dadosql = string.Format("SELECT concat(format (((SELECT COUNT(`retorno_ficha`) FROM `req_func` WHERE `retorno_ficha` <> '0000-00-00' and `codreq` = {0})/ (SELECT COUNT(`retorno_ficha`) FROM `req_func` WHERE `codreq` = {0})*100),1),'%') as percent",txt_NumReq.Text);
            resultado = mConn.LeituraLinha(dadosql);

            string percent = resultado.Rows[0]["percent"].ToString();

            dadosql = string.Format("UPDATE `requerimento` SET `retorno_ficha` = '{0}' WHERE `codreq` = '{1}'",percent,txt_NumReq.Text);
            mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT `codreq`,`contrato`,`retorno_ficha` FROM `requerimento` where `status` <> \"EM ANDAMENTO\" AND `status`<> \"AGUARDANDO APROVAÇÃO\" ORDER BY `codreq` DESC");
            dgv_reqcontrato.DataSource = mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT `matr_func`,`func`,`retorno_ficha` FROM `req_func` where `codreq` = '{0}' ORDER BY `func` DESC", txt_NumReq.Text);
            dgv_func.DataSource = mConn.LeituraLinha(dadosql);

            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
