using System;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_ProdutoUnidadePesquisa : Form
    {
        public frm_ProdutoUnidadePesquisa()
        {
            InitializeComponent();
        }
        public frm_ProdutoUnidadePesquisa(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }

        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();
        public void Listar()
        {
            dadosql = "select * from esto_unidade";
            //dgv_ProdutoPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }

        private void Dgv_ProdutoPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_ProdutoUnidadePesquisa_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Dgv_ProdutoPesquisa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_destino.Text = this.dgv_ProdutoPesquisa.CurrentRow.Cells[0].Value.ToString();
            frm_ProdutoUnidade destino = new frm_ProdutoUnidade(txt_destino.Text);
            this.Close();
            destino.Show();
        }

        private void Txt_referencia_TextChanged(object sender, EventArgs e)
        {
            string coluna, vlreferencia;
            vlreferencia = txt_referencia.Text;
            coluna = cbx_coluna.Text;
            if (coluna.Equals("UNIDADE"))
            {
                coluna = "unidade";
            }
            if (coluna.Equals("CODIGO"))
            {
                coluna = "cod";
            }
            dadosql = string.Format("SELECT* FROM `esto_unidade` WHERE `{0}` LIKE '%{1}%'", coluna, vlreferencia);

            //dgv_ProdutoPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            txt_referencia.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dgv_ProdutoPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_destino.Text = this.dgv_ProdutoPesquisa.CurrentRow.Cells[0].Value.ToString();
            frm_ProdutoUnidade destino = new frm_ProdutoUnidade(txt_destino.Text, txt_usuario.Text);
            this.Close();
            destino.Show();
        }
    }
}
