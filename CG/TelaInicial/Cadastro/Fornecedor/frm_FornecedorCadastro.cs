using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_FornecedorCadastro : Form
    {
        public frm_FornecedorCadastro(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }


      
        public frm_FornecedorCadastro(string valor, string usuario)
        {
            InitializeComponent();
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` = '{0}'", valor);
            resultado = mConn.LeituraLinha(dadosql);
            //------

            preencher(resultado);
            this.TopMost = true;
            txt_usuario.Text = usuario;

        }

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        private void limpar()
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";
            txt_num.Text = "";
            txt_contato.Text = "";
            txt_tel1.Text = "";
            txt_tel2.Text = "";
            txt_ag.Text = "";
            txt_op.Text = "";
            txt_ct.Text = "";
            txt_site.Text = "";
            txt_email.Text = "";

            cbx_estado.Text = "";
            cbx_cidade.Text = "";
            cbx_TipoConta.Text = "";
            cbx_ativo.Text = "SIM";

            mtb_Doc.Text = "";
            
            
            
            

        }
        public void bloquearbotao()
        {
            txt_nome.Enabled = false;
            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            txt_num.Enabled = false;
            txt_cep.Enabled = false;
            txt_contato.Enabled = false;
            txt_tel1.Enabled = false;
            txt_tel2.Enabled = false;
            txt_ag.Enabled = false;
            txt_op.Enabled = false;
            txt_ct.Enabled = false;
            txt_email.Enabled = false;
            txt_site.Enabled = false;

            cbx_estado.Enabled = false;
            cbx_cidade.Enabled = false;
            cbx_TipoConta.Enabled = false;
            cbx_ativo.Enabled = false;

            mtb_Doc.Enabled = false;      
            
            tsm_novo.Enabled = true;
            tsm_salvar.Enabled = false;
            tsm_editar.Enabled = true;
            tsm_anterior.Enabled = true;
            tsm_proximo.Enabled = true;
            tsm_excluir.Enabled = true;
            tsm_pesquisa.Enabled = true;
            tsm_cancelar.Enabled = false;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
        }
        public void liberarbotao()
        {
            
            txt_nome.Enabled = true;
            txt_bairro.Enabled = true;
            txt_rua.Enabled = true;
            txt_num.Enabled = true;
            txt_cep.Enabled = true;
            txt_contato.Enabled = true;
            txt_tel1.Enabled = true;
            txt_tel2.Enabled = true;
            txt_ag.Enabled = true;
            txt_op.Enabled = true;
            txt_ct.Enabled = true;
            txt_email.Enabled = true;
            txt_site.Enabled = true;         
            
            mtb_Doc.Enabled = true;

            cbx_TipoConta.Enabled = true;
            cbx_cidade.Enabled = true;
            cbx_estado.Enabled = true;
            cbx_ativo.Enabled = true;
            cbx_estado.Enabled = true;
            cbx_cidade.Enabled = true;


            tsm_salvar.Enabled = true;
            tsm_novo.Enabled = false;
            tsm_editar.Enabled = false;
            tsm_anterior.Enabled = false;
            tsm_proximo.Enabled = false;
            tsm_excluir.Enabled = false;
            tsm_pesquisa.Enabled = false;
            tsm_cancelar.Enabled = true;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
        }
        public void preencher(DataTable dados)
        {

            txt_codigo.Text = dados.Rows[0]["cod"].ToString();
            txt_nome.Text = dados.Rows[0]["nome"].ToString();
            txt_bairro.Text = dados.Rows[0]["bairro"].ToString();
            txt_rua.Text = dados.Rows[0]["rua"].ToString();
            txt_num.Text = dados.Rows[0]["num"].ToString();
            txt_cep.Text = dados.Rows[0]["cep"].ToString();
            txt_contato.Text = dados.Rows[0]["contato"].ToString();
            txt_tel1.Text = dados.Rows[0]["tel1"].ToString();
            txt_tel2.Text = dados.Rows[0]["tel2"].ToString();
            txt_ag.Text = dados.Rows[0]["ag"].ToString();
            txt_op.Text = dados.Rows[0]["op"].ToString();
            txt_ct.Text = dados.Rows[0]["ct"].ToString();
            txt_email.Text = dados.Rows[0]["email"].ToString();
            txt_site.Text = dados.Rows[0]["site"].ToString();

            cbx_estado.Text = dados.Rows[0]["estado"].ToString();
            cbx_cidade.Text = dados.Rows[0]["cidade"].ToString();
            cbx_TipoConta.Text = dados.Rows[0]["tipocont"].ToString();
            cbx_ativo.Text = dados.Rows[0]["ativo"].ToString();

            mtb_Doc.Text = dados.Rows[0]["doc"].ToString();
            
            
            
        }
        private void Frm_FornecedorCadastro_Load(object sender, EventArgs e)
        {

            //--------

            DataTable resultado = new DataTable();

            //Verificação do menor Registro no banco de dados
            dadosql = string.Format("SELECT MIN(cod) FROM fornecedor");
            resultado = mConn.LeituraLinha(dadosql);
            //------

            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {

                //Consulta no banco com o menor registro encontrato
                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` = '{0}'", resultado.Rows[0]["MIN(cod)"].ToString());
                resultado = mConn.LeituraLinha(dadosql);
                //------

                preencher(resultado);
            }
            bloquearbotao();
            tsm_cancelar.Enabled = false;
            tsm_salvar.Enabled = false;
           
        }



        private void Txt_site_TextChanged(object sender, EventArgs e)
        {

            lkl_site.Text = txt_site.Text;
            if (txt_site.Text == "")
            {
                lkl_site.Text = "Site";
            }
        }

        private void Lkl_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja realmente abrir o site?", "Site", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                Process.Start(lkl_site.Text);

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Processo Cancelado!", "Cancelado");
            }
        }

        private void Cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            dadosql = string.Format("select id FROM estado WHERE uf = '{0}'", cbx_estado.Text);
            DataTable resultado = new DataTable();
            resultado = mConn.LeituraLinha(dadosql);
            dadosql = string.Format("SELECT nome FROM `cidade` WHERE estado = '{0}'", resultado.Rows[0]["id"].ToString());
            cbx_cidade.DisplayMember = "nome";
            cbx_cidade.DataSource = mConn.LeituraTabela(dadosql);
        }

    

        private void Txt_tel1_Leave_1(object sender, EventArgs e)
        {
           // if (Convert.ToInt32(txt_tel1.Text.Length) == 11)
           // {
           //     txt_tel1.Mask = "(00)00000 - 0000";
          //  }
           
        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            string ultimo, ultimo1;
            int valor;
            dadosql = string.Format("SELECT MAX(cod) FROM fornecedor");
            resultado = mConn.LeituraLinha(dadosql);
            ultimo = resultado.Rows[0]["MAX(cod)"].ToString();
            valor = Convert.ToInt16(ultimo);
            valor++;
            ultimo1 = Convert.ToString(valor);
            limpar();
            liberarbotao();

            txt_codigo.Text = ultimo1;
            txt_tel1.Text = "";
            txt_tel2.Text = "";

            cbx_ativo.Text = "SIM";
            cbx_cidade.Text = "";
            cbx_estado.Text = "";
            cbx_TipoConta.Text = "";

            
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
            DataTable resultado = new DataTable();
            

            if (chx_editar.Checked == true)
                //Atualização dos dados do fornecedor no banco
            {
                dadosql = string.Format("UPDATE `fornecedor` SET `nome` = '{0}',`estado` = '{1}', `cidade` = '{2}', `bairro` = '{3}', `rua` = '{4}', `num` = '{5}', `cep` = '{6}', `contato` = '{7}', `tel1` = '{8}', `tel2` = '{9}', `tipodoc` = '', `doc` = '{10}', `tipocont` = '{11}', `ag` = '{12}', `op` = '{13}', `ct` = '{14}', `email` = '{15}', `site` = '{16}', `ativo` = '{17}' WHERE `fornecedor`.`cod` = '{18}'", txt_nome.Text, cbx_estado.Text, cbx_cidade.Text, txt_bairro.Text, txt_rua.Text, txt_num.Text, txt_cep.Text, txt_contato.Text, txt_tel1.Text, txt_tel2.Text, mtb_Doc.Text.Replace(",","."), cbx_TipoConta.Text, txt_ag.Text, txt_op.Text, txt_ct.Text, txt_email.Text, txt_site.Text, cbx_ativo.Text, txt_codigo.Text);
                salvo1 = " Item atualizado com exito";
                salvo2 = "ATUALIZADO";
            }
            else
                //Caso o botão editar não seja selecionado, ira inserir um registro 
            {
                dadosql = string.Format("INSERT INTO `fornecedor` (`cod`, `nome`, `estado`, `cidade`, `bairro`, `rua`, `num`, `cep`, `contato`, `tel1`, `tel2`, `tipodoc`, `doc`, `tipocont`, `ag`, `op`, `ct`, `email`, `site`, `ativo`) VALUES (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')", txt_nome.Text, cbx_estado.Text, cbx_cidade.Text, txt_bairro.Text, txt_rua.Text, txt_num.Text, txt_cep.Text, txt_contato.Text, txt_tel1.Text, txt_tel2.Text,  mtb_Doc.Text.Replace(",","."), cbx_TipoConta.Text, txt_ag.Text, txt_op.Text, txt_ct.Text, txt_email.Text, txt_site.Text, cbx_ativo.Text);

                salvo1 = "Item Criado com Exito";
                salvo2 = "CRIADO";

            }
            mConn.Inserirdb(dadosql);           
            if (salvo2 == "ATUALIZADO")
            {
                vlcodigo = Convert.ToInt16(txt_codigo.Text);
                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);

                resultado = mConn.LeituraLinha(dadosql);

                preencher(resultado);

                bloquearbotao();

                MessageBox.Show(salvo1, salvo2);

            }
            else
            {

                dadosql = string.Format("SELECT MAX(cod) FROM fornecedor");
                resultado = mConn.LeituraLinha(dadosql);
                codigo = resultado.Rows[0]["MAX(cod)"].ToString();
                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", codigo);

                resultado = mConn.LeituraLinha(dadosql);

                preencher(resultado);

                bloquearbotao();
                MessageBox.Show(salvo1, salvo2);
            }



        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM fornecedor");
            resultado = mConn.LeituraLinha(dadosql);
            if (chx_editar.Checked == true)
            {
                if ((txt_codigo.Text != resultado.Rows[0]["MIN(cod)"].ToString()) | (txt_codigo.Text == ""))
                {

                }
            }
            else
            {
                txt_codigo.Text = resultado.Rows[0]["MIN(cod)"].ToString();
            }
            int vlcodigo;
            vlcodigo = Convert.ToInt16(txt_codigo.Text);
            dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);
            resultado = mConn.LeituraLinha(dadosql);
            preencher(resultado);
            chx_editar.Checked = false;
            bloquearbotao();
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM fornecedor");
            resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {

                txt_codigo.Text = resultado.Rows[0]["MIN(cod)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt16(txt_codigo.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(cod)"]))
            {
                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);

                preencher(resultado);
                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = true;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM fornecedor WHERE cod < '{0}' ORDER BY cod DESC LIMIT 1", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            // Verificação do ultimo registro do banco de dados
            dadosql = string.Format("SELECT MAX(cod) FROM fornecedor");
            DataTable resultado = new DataTable();
            resultado = mConn.LeituraLinha(dadosql);
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

                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);

                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
                tsm_proximo.Enabled = false;

            }
            else
            {
                tsm_anterior.Enabled = true;
                dadosql = string.Format("SELECT * FROM fornecedor WHERE cod > '{0}' ORDER BY cod LIMIT 1", vlcodigo);

                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);

            }
        }

        private void Tsm_pesquisa_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_FornecedorPesquisa fornpesq = new frm_FornecedorPesquisa();
            fornpesq.ShowDialog();
        }

        private void Tsm_excluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o produto? \nExclusão apenas troca a opção ativo para NÃO", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int vlcodigo;
                DataTable resultado = new DataTable();
                vlcodigo = Convert.ToInt16(txt_codigo.Text);

                dadosql = string.Format("UPDATE fornecedor SET ativo = 'NAO' WHERE cod ='{0}'", vlcodigo);

                resultado = mConn.LeituraLinha(dadosql);

                MessageBox.Show("Item excluido com exito!", "Excluido");
                dadosql = string.Format("SELECT * FROM fornecedor where `cod` = '{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Processo Cancelado!", "Cancelado");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mtb_Doc.Text.Replace(",", "").Replace("-",""));

            if(mtb_Doc.Text == "   ,   ,   -" || mtb_Doc.Text == "  ,   ,   /    -")
            {
                MessageBox.Show("em branco");
            }
            else 
            {
                MessageBox.Show("VAI PORRA !!!");
                int x = mtb_Doc.Text.Replace(",", "").Replace("-", "").Replace("/", "").Length;

                MessageBox.Show(x.ToString());
            }
        }
    }
}