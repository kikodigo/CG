using System;
using System.Data;
using System.Windows.Forms;

namespace CG.TelaInicial.Cadastro.Estoque.Produto_por_Posto
{
    public partial class frm_ProdutoPostoClasse : Form
    {
        public frm_ProdutoPostoClasse()
        {
            InitializeComponent();
        }

        public frm_ProdutoPostoClasse(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

        }

        private string dadosql;
        ////Classes.dbconect mConn = new Classes.dbconect();

        private string dadosmssql;
        //Classes.mssqlconect msConn = new Classes.mssqlconect();

        private void atualizadgv()
        {
            dadosql = "SELECT classe as 'Classe' FROM `v_esto_classe_posto` ORDER BY `cod_classe` ASC";
            //dgv_EstoClassePosto.DataSource = mConn.ConsultaTabela(dadosql);
        }
        private void frm_ProdutoPostoClasse_Load(object sender, EventArgs e)
        {
            dadosql = string.Format("select classe from esto_classe where ativo = 'sim'");
            cbx_Classes.DisplayMember = "classe";
            //cbx_Classes.DataSource = mConn.LeituraTabela(dadosql);

            atualizadgv();

        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            string codigo;

            dadosql = string.Format("SELECT `cod` FROM `esto_classe` where `classe` = '{0}'", cbx_Classes.Text);
            //resultado = mConn.ConsultaTabela(dadosql);
            codigo = resultado.Rows[0]["cod"].ToString();


            dadosql = string.Format("SELECT * FROM `esto_classe_posto` where `cod_classe` = '{0}'", codigo);
            //resultado = mConn.ConsultaTabela(dadosql);
            if (resultado.Rows.Count == 0)
            {
                dadosql = string.Format("INSERT INTO `esto_classe_posto` (`cod`, `cod_classe`) VALUES(NULL, '{0}')", codigo);
                //mConn.Inserirdb(dadosql);
                atualizadgv();
            }
            else
            {
                MessageBox.Show("Itens ja existe!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();
            string codigo;

            dadosql = string.Format("SELECT `cod` FROM `esto_classe` where `classe` = '{0}'", cbx_Classes.Text);
            //resultado = mConn.ConsultaTabela(dadosql);
            codigo = resultado.Rows[0]["cod"].ToString();


            dadosql = string.Format("SELECT * FROM `esto_classe_posto` where `cod_classe` = '{0}'", codigo);
            ////resultado = mConn.ConsultaTabela(dadosql);
            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("Itens não localizado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                dadosql = string.Format("DELETE FROM `esto_classe_posto` WHERE `cod_classe` = '{0}'", codigo);
                //mConn.Inserirdb(dadosql);
                atualizadgv();

            }

        }

        private void dgv_EstoClassePosto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_Classes.Text = this.dgv_EstoClassePosto.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
