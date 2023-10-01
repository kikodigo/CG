using System;
using System.Data;
using System.Windows.Forms;

namespace CG
{
    public partial class Frm_ProdutoPesquisa : Form
    {



        public Frm_ProdutoPesquisa(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;


            DataTable resultado = new DataTable();
            resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
            this.TopMost = true;
        }

        public void controleacesso(string CodPerfil)
        {
            switch (CodPerfil)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":


                    break;

                case "4":


                    break;

                case "0":
                    MessageBox.Show("Acesso negado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    break;

                default:
                    MessageBox.Show("Falha ao carregar Perfil.\\nInforme o Administrador do sistema.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;

            }

        }

        private string permissao;
        Classes.permissoes mPermissao = new Classes.permissoes();

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();
        public void Listar()
        {
            dadosql = "SELECT * FROM `v_estoque` ORDER BY `cod` ASC";
            dgv_ProdutoPesquisa.DataSource = mConn.ConsultaTabela(dadosql);

            dadosql = string.Format("SELECT MIN(cod) FROM estoque");
            DataTable resultado = new DataTable();
            resultado = mConn.LeituraLinha(dadosql);

            txt_destino.Text = resultado.Rows[0]["MIN(cod)"].ToString();

        }


        private void Button1_Click_2(object sender, EventArgs e)
        {
            txt_referencia.Text = "";

        }


        private void Frm_ProdutoPesquisa_Load(object sender, EventArgs e)
        {
            Listar();
            cbx_coluna.Text = "Descrição";

        }


        private void Txt_referencia_TextChanged(object sender, EventArgs e)
        {


            string coluna, vlreferencia;
            vlreferencia = txt_referencia.Text;
            coluna = cbx_coluna.Text;
            if (coluna.Equals("DESCRIÇÃO"))
            {
                coluna = "descricao";
            }
            if (coluna.Equals("CODIGO"))
            {
                coluna = "cod";
            }

            dadosql = string.Format("SELECT* FROM `v_estoque` WHERE `{0}` LIKE '%{1}%'", coluna, vlreferencia);

            dgv_ProdutoPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }



        private void Dgv_ProdutoPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_destino.Text = this.dgv_ProdutoPesquisa.CurrentRow.Cells[0].Value.ToString();
            frm_ProdutoCadastro destino = new frm_ProdutoCadastro(txt_destino.Text, txt_usuario.Text);
            this.TopMost = false;
            this.Close();
            destino.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
