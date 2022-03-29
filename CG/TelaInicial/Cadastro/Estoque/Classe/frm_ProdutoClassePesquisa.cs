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

namespace CG
{
    public partial class frm_ProdutoClassePesquisa : Form
    {
        public frm_ProdutoClassePesquisa()
        {
            InitializeComponent();
        }
        public frm_ProdutoClassePesquisa(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

        DataTable resultado = new DataTable();
            resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
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
            dadosql = "select * from esto_classe";
            dgv_ProdutoPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
            dadosql = string.Format("SELECT MIN(cod) FROM esto_classe");
            DataTable resultado = new DataTable();
            resultado = mConn.LeituraLinha(dadosql);

            txt_destino.Text = resultado.Rows[0]["MIN(cod)"].ToString();
        }

        private void Frm_ProdutoClassePesquisa_Load(object sender, EventArgs e)
        {
            cbx_coluna.Text = "CLASSE";
            Listar();

        }

        private void Txt_referencia_TextChanged(object sender, EventArgs e)
        {
            string coluna, vlreferencia;
            vlreferencia = txt_referencia.Text;
            coluna = cbx_coluna.Text;
            if (coluna.Equals("CLASSE"))
            {
                coluna = "classe";
            }
            if (coluna.Equals("CODIGO"))
            {
                coluna = "cod";
            }
            dadosql = string.Format("SELECT * FROM `esto_classe` WHERE `{0}` LIKE '%{1}%'", coluna, vlreferencia);

            dgv_ProdutoPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txt_referencia.Text = "";
        }

        private void Dgv_ProdutoPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_destino.Text = this.dgv_ProdutoPesquisa.CurrentRow.Cells[0].Value.ToString();
            frm_ProdutoClasse destino = new frm_ProdutoClasse(txt_destino.Text, txt_usuario.Text);
            this.Close();
            destino.Show();
        }
        private void Dgv_ProdutoPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
