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

namespace CG.Tela_Inicial.Requisição
{
    public partial class frm_ReqPesquise : Form
    {
        public frm_ReqPesquise()
        {
            InitializeComponent();
        }


        public frm_ReqPesquise(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();


        private void Frm_ReqPesquise_Load(object sender, EventArgs e)
        {
            dadosql = string.Format("SELECT `codreq`,`data`,`contrato`,`data_aprov`,`status`,`obs`,`prev`,`data_envio`,`tipo_envio`,`retorno_ficha` FROM `requerimento` ORDER BY `codreq` DESC");
            dgv_ReqPesquisa.DataSource = mConn.LeituraLinha(dadosql);
            this.TopMost = true;
            cbx_coluna.Text = "N°Req";

        }

        private void Txt_referencia_TextChanged(object sender, EventArgs e)
        {
           string coluna=cbx_coluna.Text;
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

                    //inserir  o defoul aki 
                    
            }
            dadosql = string.Format("SELECT `codreq`,`data`,`contrato`,`data_aprov`,`status`,`obs`,`prev`,`data_envio`,`tipo_envio`,`retorno_ficha` FROM `requerimento` WHERE `{0}` LIKE '%{1}%' ORDER BY `codreq` DESC ", coluna, txt_referencia.Text);
            dgv_ReqPesquisa.DataSource = mConn.ConsultaTabela(dadosql);

        }

        private void Dgv_ReqPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_destino.Text = this.dgv_ReqPesquisa.CurrentRow.Cells[0].Value.ToString();
            frm_ReqCadastro destino = new frm_ReqCadastro(txt_usuario.Text, txt_destino.Text);
            this.Close();
            destino.Show();
        }

        private void txt_destino_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
