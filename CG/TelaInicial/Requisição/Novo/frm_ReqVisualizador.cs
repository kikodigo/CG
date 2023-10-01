using System;
using System.Data;
using System.Windows.Forms;

namespace CG.Tela_Inicial.Requisição
{
    public partial class frm_ReqVisualizador : Form
    {
        public frm_ReqVisualizador()
        {
            InitializeComponent();
        }
        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        public frm_ReqVisualizador(string valor)
        {
            InitializeComponent();
            txt_numreq.Text = valor;
            dadosql = string.Format("SELECT `matr_func`,`func`,`cargo`,`descricao`,`qtd`,`qtd_lib`,`motivo` FROM `req_item` WHERE `codreq` = {0}", txt_numreq.Text);
            dgv_visualizador.DataSource = mConn.LeituraLinha(dadosql);

            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT * FROM `requerimento` where  `codreq` = {0}", txt_numreq.Text);
            resultado = mConn.LeituraLinha(dadosql);
            txt_data.Text = Convert.ToDateTime(resultado.Rows[0]["data"]).ToString("dd/MM/yyyy");
            txt_contrato.Text = resultado.Rows[0]["contrato"].ToString();
            txt_status.Text = resultado.Rows[0]["status"].ToString();
            this.TopMost = true;


        }

        private void Frm_ReqVisualizador_Load(object sender, EventArgs e)
        {
            if (txt_status.Text != "AGUARDANDO APROVAÇÃO")
            {
                txt_QtdLib.Enabled = false;
                btn_aprovar.Enabled = false;
                btn_alterar.Enabled = false;

            }
        }

        private void Dgv_visualizador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_matr.Text = this.dgv_visualizador.CurrentRow.Cells[0].Value.ToString();
            txt_func.Text = this.dgv_visualizador.CurrentRow.Cells[1].Value.ToString();
            txt_descricao.Text = this.dgv_visualizador.CurrentRow.Cells[3].Value.ToString();
            txt_QtdLib.Text = this.dgv_visualizador.CurrentRow.Cells[5].Value.ToString();
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if ((txt_matr.Text == "") | (txt_func.Text == "") | (txt_descricao.Text == "") | (txt_QtdLib.Text == ""))
            {
                MessageBox.Show("Selecione um funcionario abaixo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                dadosql = string.Format(" UPDATE `req_item` SET `qtd_lib` = '{0}' WHERE `codreq` = '{1}' AND `matr_func` = '{2}' AND `descricao` = '{3}'", txt_QtdLib.Text, txt_numreq.Text, txt_matr.Text, txt_descricao.Text);
                mConn.LeituraLinha(dadosql);

                dadosql = string.Format("SELECT `matr_func`,`func`,`cargo`,`descricao`,`qtd`,`qtd_lib`,`motivo` FROM `req_item` WHERE `codreq` = {0}", txt_numreq.Text);
                dgv_visualizador.DataSource = mConn.LeituraLinha(dadosql);


            }

        }

        private void Txt_QtdLib_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_aprovar_Click(object sender, EventArgs e)
        {
            if (txt_status.Text == "AGUARDANDO APROVAÇÃO")
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente aprovar esta requisição?", "Aprovação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {

                    DataTable resultado = new DataTable();
                    DateTime dt = DateTime.Now;
                    string str = dt.ToString("yyy-MM-dd");

                    dadosql = string.Format("UPDATE `requerimento` SET `status` = 'APROVADO',`data_aprov` = '{0}' WHERE `requerimento`.`codreq` = {1}", str, txt_numreq.Text);
                    mConn.LeituraLinha(dadosql);

                    dadosql = string.Format("SELECT * FROM `requerimento` where  `codreq` = {0}", txt_numreq.Text);
                    resultado = mConn.LeituraLinha(dadosql);

                    txt_data.Text = Convert.ToDateTime(resultado.Rows[0]["data"]).ToString("dd/MM/yyyy");
                    txt_contrato.Text = resultado.Rows[0]["contrato"].ToString();
                    txt_status.Text = resultado.Rows[0]["status"].ToString();

                    txt_QtdLib.Enabled = false;
                    btn_alterar.Enabled = false;
                    btn_aprovar.Enabled = false;


                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Processo Cancelado!", "Cancelado");
                }
            }
            else
            {
                MessageBox.Show(string.Format("Requisição esta com o status em  {0} \nNão pode ser aprovada!", txt_status.Text), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Txt_QtdLib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((txt_matr.Text == "") | (txt_func.Text == "") | (txt_descricao.Text == "") | (txt_QtdLib.Text == ""))
                {
                    MessageBox.Show("Selecione um funcionario abaixo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    dadosql = string.Format(" UPDATE `req_item` SET `qtd_lib` = '{0}' WHERE `codreq` = '{1}' AND `matr_func` = '{2}' AND `descricao` = '{3}'", txt_QtdLib.Text, txt_numreq.Text, txt_matr.Text, txt_descricao.Text);
                    mConn.LeituraLinha(dadosql);

                    dadosql = string.Format("SELECT `matr_func`,`func`,`cargo`,`descricao`,`qtd`,`qtd_lib`,`motivo` FROM `req_item` WHERE `codreq` = {0}", txt_numreq.Text);
                    dgv_visualizador.DataSource = mConn.LeituraLinha(dadosql);


                }
            }
        }

        private void Dgv_visualizador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
