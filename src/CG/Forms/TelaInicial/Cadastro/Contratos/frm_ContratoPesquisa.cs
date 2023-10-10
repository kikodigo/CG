using System;
using System.Windows.Forms;

namespace CG.Tela_Inicial.Cadastro.Contratos
{
    public partial class frm_ContratoPesquisa : Form
    {
        public frm_ContratoPesquisa()
        {
            InitializeComponent();
        }

        public frm_ContratoPesquisa(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

            this.TopMost = true;
        }
        private string permissao;
        //Classes.permissoes mPermissao = new Classes.permissoes();

        private string dadosmssql;
        //Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();


        private void frm_ContratoPesquisa_Load(object sender, EventArgs e)
        {
            dadosql = string.Format("SELECT `codcc` as `Codigo Contrato`,`nome_contrato` as `Nome do Contrato`,`contato` as `Contato`,`tel1` as `Telefone 1`,`tel2`as `Telefone 2` FROM `contrato`");
            //dgv_ContratoPesquisa.DataSource = mConn.LeituraTabela(dadosql);
        }

        private void txt_referencia_TextChanged(object sender, EventArgs e)
        {
            string coluna = null;
            switch (cbx_coluna.Text)
            {
                case "Codigo Contrato":
                    coluna = "codcc";

                    break;
                case "Nome do Contrato":
                    coluna = "nome_contrato";

                    break;
                case "Contato":
                    coluna = "contato";

                    break;

                default:
                    MessageBox.Show("Opção Invalida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
            dadosql = string.Format("SELECT `codcc` as `Codigo Contrato`,`nome_contrato` as `Nome do Contrato`,`contato` as `Contato`,`tel1` as `Telefone 1`,`tel2`as `Telefone 2`  FROM `estoque` WHERE `{0}` LIKE '%{1}%'", coluna, txt_referencia.Text);

            //dgv_ContratoPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }

        private void dgv_ContratoPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_destino.Text = this.dgv_ContratoPesquisa.CurrentRow.Cells[0].Value.ToString();

            frm_ContratoCadastro contrato = new frm_ContratoCadastro(txt_usuario.Text, txt_destino.Text);
            this.TopMost = false;
            this.Close();
            contrato.Show();

        }
    }
}
