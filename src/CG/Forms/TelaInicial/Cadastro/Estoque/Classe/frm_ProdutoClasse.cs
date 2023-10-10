using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_ProdutoClasse : Form
    {
        public frm_ProdutoClasse(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;


            DataTable resultado = new DataTable();
            //resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
        }

        public void controleacesso(string CodPerfil)
        {
            switch (CodPerfil)
            {
                case "1":

                    break;

                case "2":
                    tsm_excluir.Visible = false;
                    break;

                case "3":
                    tsm_excluir.Visible = false;
                    tsm_editar.Visible = false;

                    break;

                case "4":
                    tsm_editar.Visible = false;
                    tsm_novo.Visible = false;
                    tsm_excluir.Visible = false;
                    tsm_salvar.Visible = false;
                    tsm_cancelar.Visible = false;

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
        //Classes.permissoes mPermissao = new Classes.permissoes();

        public void preencher(DataTable resultado)
        {

            txt_codigo.Text = resultado.Rows[0]["cod"].ToString();
            txt_Classe.Text = resultado.Rows[0]["classe"].ToString();

            cbx_ativo.Text = resultado.Rows[0]["ativo"].ToString();
            cbx_Patrimonio.Text = resultado.Rows[0]["patrimonio"].ToString();
        }

        public frm_ProdutoClasse(String valor, string usuario)
        {
            InitializeComponent();
            txt_codigo.Text = valor;
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT * FROM `esto_classe` WHERE `cod` = '{0}'", txt_codigo.Text);
            //resultado = mConn.LeituraLinha(dadosql);

            preencher(resultado);

            txt_usuario.Text = usuario;
            this.TopMost = true;
        }

        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();
        public void bloquearbotao()
        {

            txt_Classe.Enabled = false;

            tsm_salvar.Enabled = false;
            tsm_novo.Enabled = true;
            tsm_editar.Enabled = true;
            tsm_anterior.Enabled = true;
            tsm_proximo.Enabled = true;
            tsm_excluir.Enabled = true;
            tsm_pesquisar.Enabled = true;
            tsm_cancelar.Enabled = false;

            chx_editar.Checked = false;

            cbx_Patrimonio.Enabled = false;
            cbx_ativo.Enabled = false;

            lbl_codigo.ForeColor = Color.Gray;
            lbl_classe.ForeColor = Color.Gray;
            lbl_ativo.ForeColor = Color.Gray;
            lbl_patrimonio.ForeColor = Color.Gray;



        }
        public void liberarbotao()
        {
            txt_Classe.Enabled = true;

            tsm_salvar.Enabled = true;
            tsm_novo.Enabled = false;
            tsm_editar.Enabled = false;
            tsm_anterior.Enabled = false;
            tsm_proximo.Enabled = false;
            tsm_excluir.Enabled = false;
            tsm_pesquisar.Enabled = false;
            tsm_cancelar.Enabled = true;

            cbx_ativo.Enabled = true;
            cbx_Patrimonio.Enabled = true;

            lbl_codigo.ForeColor = Color.White;
            lbl_classe.ForeColor = Color.White;
            lbl_patrimonio.ForeColor = Color.White;
            lbl_ativo.ForeColor = Color.White;
        }



        private void Frm_ProdutoClasse_Load(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();

            //Verificação do menor Registro no banco de dados
            dadosql = string.Format("SELECT MIN(cod) FROM esto_classe");
            //resultado = mConn.LeituraLinha(dadosql);
            //------

            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {

                //Consulta no banco com o menor registro encontrato 
                // dadosql = string.Format("SELECT * FROM `estoque` WHERE `estoque`.`cod` = 248");
                dadosql = string.Format("SELECT * FROM `esto_classe` WHERE `cod` = '{0}'", resultado.Rows[0]["MIN(cod)"].ToString());
                //resultado = mConn.LeituraLinha(dadosql);
                //------

                preencher(resultado);
            }
            bloquearbotao();
        }



        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            liberarbotao();
            txt_Classe.Text = "";
            txt_codigo.Text = "";
            cbx_ativo.Text = "SIM";
        }

        private void Tsm_editar_Click(object sender, EventArgs e)
        {
            chx_editar.Checked = true;
            liberarbotao();
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            string salvo1, salvo2, codigo;
            int vlcodigo;

            if (chx_editar.Checked == true)
            {

                dadosql = string.Format("SELECT `patrimonio` FROM esto_classe WHERE `cod` = '{0}' ", txt_codigo.Text);
                //resultado = mConn.LeituraLinha(dadosql);
                if (resultado.Rows[0]["patrimonio"].ToString() != cbx_Patrimonio.Text)
                {
                    dadosql = string.Format(" SELECT COUNT(`codclasse`) AS QTD FROM `v_patrimonio` where `codclasse` = '{0}'", txt_codigo.Text);
                    //resultado = mConn.LeituraLinha(dadosql);
                    if (resultado.Rows[0]["QTD"].ToString() != "0")
                    {
                        salvo1 = "Item não foi atualizado. \nExistem patrimônios vinculados a itens dessa classe.";
                        salvo2 = "Erro";
                    }
                    else
                    {
                        dadosql = string.Format("UPDATE esto_classe SET `classe` = '{0}',`patrimonio`= '{1}',`ativo`= '{2}' WHERE `cod` = '{3}' ", txt_Classe.Text, cbx_Patrimonio.Text, cbx_ativo.Text, txt_codigo.Text);
                        salvo1 = "Item atualizado com exito";
                        salvo2 = "ATUALIZADO";
                    }
                }
                else
                {
                    dadosql = string.Format("UPDATE esto_classe SET `classe` = '{0}',`patrimonio`= '{1}',`ativo`= '{2}' WHERE `cod` = '{3}' ", txt_Classe.Text, cbx_Patrimonio.Text, cbx_ativo.Text, txt_codigo.Text);
                    salvo1 = "Item atualizado com exito";
                    salvo2 = "ATUALIZADO";
                }



            }
            else
            {

                dadosql = string.Format("INSERT INTO `esto_classe` (`cod`, `classe`, `patrimonio`, `ativo`) VALUES (NULL, '{0}', '{1}', '{2}')", txt_Classe.Text, cbx_Patrimonio.Text, cbx_ativo.Text);

                salvo1 = "Item Criado com Exito";
                salvo2 = "CRIADO";

            }
            //mConn.Inserirdb(dadosql);
            if (salvo2 == "ATUALIZADO")
            {
                vlcodigo = Convert.ToInt16(txt_codigo.Text);
                dadosql = string.Format("SELECT * FROM `esto_classe` WHERE `cod` ='{0}'", vlcodigo);

                //resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
                bloquearbotao();
                MessageBox.Show(salvo1, salvo2);
            }
            else
            {

                dadosql = string.Format("SELECT MAX(cod) FROM esto_classe");
                //resultado = mConn.LeituraLinha(dadosql);
                codigo = resultado.Rows[0]["MAX(cod)"].ToString();
                dadosql = string.Format("SELECT * FROM `esto_classe` WHERE `cod` ='{0}'", codigo);

                //resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);

                bloquearbotao();
                MessageBox.Show(salvo1, salvo2);
            }
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            bloquearbotao();
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM esto_classe");
            //resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {

                txt_codigo.Text = resultado.Rows[0]["MIN(cod)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt16(txt_codigo.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(cod)"]))
            {
                dadosql = string.Format("SELECT * FROM `esto_classe` WHERE `cod` ='{0}'", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);

                preencher(resultado);

                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = true;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM esto_classe WHERE cod < '{0}' ORDER BY cod DESC LIMIT 1", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            // Verificação do ultimo registro do banco de dados
            dadosql = string.Format("SELECT MAX(cod) FROM esto_classe");
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
                dadosql = string.Format("SELECT * FROM `esto_classe` WHERE `cod` ='{0}'", vlcodigo);
                ////resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
                tsm_proximo.Enabled = false;
            }
            else
            {
                tsm_anterior.Enabled = true;
                dadosql = string.Format("SELECT * FROM esto_classe WHERE cod > '{0}' ORDER BY cod LIMIT 1", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
        }

        private void Tsm_pesquisar_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            frm_ProdutoClassePesquisa Produtoclass = new frm_ProdutoClassePesquisa(txt_usuario.Text);
            Produtoclass.ShowDialog();
            this.Close();
        }

        private void Tsm_excluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir esta Classe? \nExclusão apenas troca a opção ativo para NÃO", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int vlcodigo;
                DataTable resultado = new DataTable();
                vlcodigo = Convert.ToInt16(txt_codigo.Text);

                dadosql = string.Format("UPDATE esto_classe SET ativo = 'NAO' WHERE cod ='{0}'", vlcodigo);

                //resultado = mConn.LeituraLinha(dadosql);

                MessageBox.Show("Item excluido com exito!", "Excluido");
                dadosql = string.Format("SELECT * FROM esto_classe where `cod` = '{0}'", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Processo Cancelado!", "Cancelado");
            }
        }


    }
}
