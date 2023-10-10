using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_ProdutoUnidade : Form
    {
        public frm_ProdutoUnidade(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }
        public frm_ProdutoUnidade(String valor, String usuario)
        {
            InitializeComponent();
            txt_codigo.Text = valor;
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT * FROM `esto_unidade` WHERE `cod` = '{0}'", txt_codigo.Text);
            //resultado = mConn.LeituraLinha(dadosql);

            txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
            txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
            cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();
            txt_usuario.Text = usuario;
            this.TopMost = true;
        }
        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();


        public void bloquearbotao()
        {


            txt_unidade.Enabled = true;

            tsm_salvar.Enabled = false;
            tsm_novo.Enabled = true;
            tsm_editar.Enabled = true;
            tsm_anterior.Enabled = true;
            tsm_proximo.Enabled = true;
            tsm_pesquisa.Enabled = true;
            tsm_cancelar.Enabled = false;

            chx_editar.Checked = false;

            label1.ForeColor = Color.Gray;
            label2.ForeColor = Color.Gray;


        }
        public void liberarbotao()
        {
            txt_unidade.Enabled = true;

            tsm_salvar.Enabled = true;
            tsm_novo.Enabled = false;
            tsm_editar.Enabled = false;
            tsm_anterior.Enabled = false;
            tsm_proximo.Enabled = false;
            tsm_pesquisa.Enabled = false;
            tsm_cancelar.Enabled = true;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;

        }
        private void Frm_ProdutoUnidade_Load(object sender, EventArgs e)
        {


            DataTable resultado = new DataTable();

            //Verificação do menor Registro no banco de dados
            dadosql = string.Format("SELECT MIN(cod) FROM esto_unidade");
            //resultado = mConn.LeituraLinha(dadosql);
            //------

            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {

                //Consulta no banco com o menor registro encontrato 
                // dadosql = string.Format("SELECT * FROM `estoque` WHERE `estoque`.`cod` = 248");
                dadosql = string.Format("SELECT * FROM `esto_unidade` WHERE `cod` = '{0}'", resultado.Rows[0]["MIN(cod)"].ToString());
                //resultado = mConn.LeituraLinha(dadosql);
                //------

                txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
                txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();

            }

        }



        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            liberarbotao();
            txt_codigo.Text = "";
            txt_unidade.Text = "";
        }

        private void Tsm_editar_Click(object sender, EventArgs e)
        {
            chx_editar.Checked = true;
            liberarbotao();
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            string salvo1, salvo2, codigo;
            int vlcodigo;

            if (chx_editar.Checked == true)
            {
                dadosql = string.Format("UPDATE esto_unidade SET `unidade` = '{0}',`ativo`= '{1}' WHERE `cod` = '{2}' ", txt_unidade.Text, cbx_ativo.Text, txt_codigo.Text);
                salvo1 = " Item atualizado com exito";
                salvo2 = "ATUALIZADO";
            }
            else
            {

                dadosql = string.Format("insert into esto_unidade values(NULL,'{0}','{1}')", txt_unidade.Text, cbx_ativo.Text);

                salvo1 = "Item Criado com Exito";
                salvo2 = "CRIADO";

            }
            //mConn.Inserirdb(dadosql);
            DataTable resultado = new DataTable();
            if (salvo2 == "ATUALIZADO")
            {
                vlcodigo = Convert.ToInt16(txt_codigo.Text);
                dadosql = string.Format("SELECT * FROM `esto_unidade` WHERE `cod` ='{0}'", vlcodigo);

                //resultado = mConn.LeituraLinha(dadosql);
                txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
                txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();
                bloquearbotao();
                MessageBox.Show(salvo1, salvo2);
            }
            else
            {

                dadosql = string.Format("SELECT MAX(cod) FROM esto_unidade");
                //resultado = mConn.LeituraLinha(dadosql);
                codigo = resultado.Rows[0]["MAX(cod)"].ToString();
                dadosql = string.Format("SELECT * FROM `esto_unidade` WHERE `cod` ='{0}'", codigo);

                //resultado = mConn.LeituraLinha(dadosql);
                txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
                txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();

                bloquearbotao();
                MessageBox.Show(salvo1, salvo2);
            }
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            chx_editar.Checked = false;
            bloquearbotao();
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM esto_unidade");
            //resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {

                txt_codigo.Text = resultado.Rows[0]["MIN(cod)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt16(txt_codigo.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(cod)"]))
            {
                dadosql = string.Format("SELECT * FROM `esto_unidade` WHERE `cod` ='{0}'", vlcodigo);
                ////resultado = mConn.LeituraLinha(dadosql);

                txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
                txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();

                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = true;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM esto_unidade WHERE cod < '{0}' ORDER BY cod DESC LIMIT 1", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
                txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();
            }
        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            // Verificação do ultimo registro do banco de dados
            dadosql = string.Format("SELECT MAX(cod) FROM esto_unidade");
            DataTable resultado = new DataTable();
            //resultado = mConn.LeituraLinha(dadosql);
            //-----

            //Verificação se o campo CODIGO esta vazio, caso esteja será preenchido com o ultimo valor do banco
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {
                txt_codigo.Text = resultado.Rows[0]["MAX(cod)"].ToString();
            }
            //-----

            // Criação de variavel para conversão de STRING para INT 
            int vlcodigo;
            vlcodigo = Convert.ToInt16(txt_codigo.Text);
            // -----

            if (vlcodigo.Equals(resultado.Rows[0]["MAX(cod)"]))
            {
                dadosql = string.Format("SELECT * FROM `esto_unidade` WHERE `cod` ='{0}'", vlcodigo);
                ////resultado = mConn.LeituraLinha(dadosql);
                txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
                txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();
                tsm_proximo.Enabled = false;
            }
            else
            {
                tsm_anterior.Enabled = true;
                dadosql = string.Format("SELECT * FROM esto_unidade WHERE cod > '{0}' ORDER BY cod LIMIT 1", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
                txt_unidade.Text = resultado.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();
            }

        }

        private void Tsm_pesquisa_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            frm_ProdutoUnidadePesquisa Produtounid = new frm_ProdutoUnidadePesquisa(txt_usuario.Text);
            Produtounid.ShowDialog();
            this.Close();

        }


    }
}
