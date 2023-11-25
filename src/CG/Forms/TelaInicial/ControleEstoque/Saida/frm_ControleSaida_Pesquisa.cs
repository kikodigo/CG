using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG.TelaInicial.ControleEstoque.Saida
{
    public partial class frm_ControleSaida_Pesquisa : Form
    {
        public frm_ControleSaida_Pesquisa()
        {
            InitializeComponent();
        }
        public frm_ControleSaida_Pesquisa(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

        }

        private string dadosmssql;
        //Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();

        private void PreencherDGV(DataTable resultado)
        {
            dgv_ControleSaida.DataSource = resultado;

        }

        private void frm_ControleSaida_Pesquisa_Load(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `codsaida`,`data`,`nomcont`,`status`,`metenvio`,`infoenvio`,`prevenvio`,`dataenvio`,`obs` FROM `esto_saida` ORDER BY `codsaida`  ASC");
            //resultado = mConn.ConsultaTabela(dadosql);
            PreencherDGV(resultado);            
        }
    }
}
