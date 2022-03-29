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

namespace CG.Tela_Inicial.Cadastro.Funcionarios
{
    public partial class frm_Funcionarios : Form
    {
        public frm_Funcionarios()
        {
            InitializeComponent();
        }

        public frm_Funcionarios(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }

        private string dadosmssql;
        Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        private void Atualiza_DGV()
        {
            string coluna = "" ;           

            switch (cbx_coluna.Text) {
                case "Matrícula":
                    coluna = "e.numcad";
                    break;
                case "Nome":
                    coluna = "e.nomfun";
                    break;
                case "Codigo Cargo":
                    coluna = "e.codcar";
                    break;
                case "Cargo":
                    coluna = "c.titred";
                    break;
                case "Codigo Contrato":
                    coluna = "e.codccu";
                    break;
                case "Contrato":
                    coluna = "cu.nomccu";
                    break;
                case "Numero Local":
                    coluna = "e.numloc";
                    break;
                case "Local":
                    coluna = "lo.nomloc";
                    break;
                case "Codigo Posto":
                    coluna = "e.postra";
                    break;
                case "Posto de Trabalho":
                    coluna = "p.desred";
                    break;

            }            
            
            dadosmssql = string.Format("select e.numcad as 'Matrícula', e.nomfun as 'Nome', e.codcar as 'Cod. Cargo', c.titred as 'Cargo',  e.codccu as 'Cod. Contrato', cu.nomccu as 'Contrato' , e.numloc as 'Num. Local', lo.nomloc as 'Local', e.postra as 'Cod. Posto', p.desred as 'Posto de Trabalho' from vetorh.dbo.r034fun as e inner join vetorh.dbo.r017pos as p on (e.postra = p.postra) inner join vetorh.dbo.r024car as c on (e.codcar = c.codcar)inner join vetorh.dbo.r016orn as lo on (e.numloc = lo.numloc) inner join vetorh.dbo.r018ccu as cu on (e.codccu = cu.codccu)WHERE (e.sitafa<>7 And e.sitafa<>3 And e.sitafa<>53 and p.estpos = 2 and {0} like '%{1}%') order by e.nomfun asc", coluna, txt_referencia.Text);
           
            dgv_funcionario.DataSource = msConn.ConsultaTabela(dadosmssql);

        }

        private void frm_Funcionarios_Load(object sender, EventArgs e)
        {
                        
            cbx_coluna.SelectedIndex = 1;
            Atualiza_DGV();
            
        }

       

        private void Txt_referencia_TextChanged(object sender, EventArgs e)
        {
            Atualiza_DGV();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_referencia.Text = null;
            Atualiza_DGV();
        }
               
    }
}
