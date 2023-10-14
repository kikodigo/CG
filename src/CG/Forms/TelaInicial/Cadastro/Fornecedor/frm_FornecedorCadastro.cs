using CG.Core.Services;
using CG.Domain.Data;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace CG
{
    public partial class frm_FornecedorCadastro : Form
    {
        public readonly FornecedorServices _fornecedorServices;

        public frm_FornecedorCadastro(string usuario)
        {
            InitializeComponent();
            _fornecedorServices = new FornecedorServices();
            txt_usuario.Text = usuario;
        }


        public frm_FornecedorCadastro(string valor, string usuario)
        {
            InitializeComponent();
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` = '{0}'", valor);
            //resultado = mConn.LeituraLinha(dadosql);
            //------

            //preencher(resultado);
            this.TopMost = true;
            txt_usuario.Text = usuario;

        }

        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();

        private void limpar()
        {
            txt_Id.Text = "";
            txt_Fantasia.Text = "";
            txt_Bairro.Text = "";
            txt_Rua.Text = "";
            txt_Num.Text = "";
            txt_Contato.Text = "";
            txt_Tel1.Text = "";
            txt_Tel2.Text = "";
            txt_Ag.Text = "";
            txt_Op.Text = "";
            txt_Ct.Text = "";
            txt_Site.Text = "";
            txt_Email.Text = "";

            

            cbx_Estado.Text = "";
            txt_Cidade.Text = "";
            txt_TipoConta.Text = "";
            cbx_ativo.Text = "SIM";

            txt_DocNum.Text = "";
        }
        public void bloquearbotao()
        {
            txt_Fantasia.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_Rua.Enabled = false;
            txt_Num.Enabled = false;
            txt_Cep.Enabled = false;
            txt_Contato.Enabled = false;
            txt_Tel1.Enabled = false;
            txt_Tel2.Enabled = false;
            txt_Ag.Enabled = false;
            txt_Op.Enabled = false;
            txt_Ct.Enabled = false;
            txt_Email.Enabled = false;
            txt_Site.Enabled = false;

            cbx_Estado.Enabled = false;
            txt_Cidade.Enabled = false;
            txt_TipoConta.Enabled = false;
            cbx_ativo.Enabled = false;

            txt_DocNum.Enabled = false;

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

            txt_Fantasia.Enabled = true;
            txt_Bairro.Enabled = true;
            txt_Rua.Enabled = true;
            txt_Num.Enabled = true;
            txt_Cep.Enabled = true;
            txt_Contato.Enabled = true;
            txt_Tel1.Enabled = true;
            txt_Tel2.Enabled = true;
            txt_Ag.Enabled = true;
            txt_Op.Enabled = true;
            txt_Ct.Enabled = true;
            txt_Email.Enabled = true;
            txt_Site.Enabled = true;

            txt_DocNum.Enabled = true;

            txt_TipoConta.Enabled = true;
            txt_Cidade.Enabled = true;
            cbx_Estado.Enabled = true;
            cbx_ativo.Enabled = true;
            cbx_Estado.Enabled = true;
            txt_Cidade.Enabled = true;


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

        public void Preencher(FornecedorData dados)
        {

            //Todo: Precisa ajustar os nomes dos Txt e cbx com o mesmo nome com do objeto FornecedorData
            asdadasdassaasdasdasd

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && control.Name.StartsWith("txt_"))
                {
                    string propertyName = control.Name.Substring(4); // Remove o prefixo "txt_"
                    PropertyInfo propertyInfo = dados.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        string valor = propertyInfo.GetValue(dados)?.ToString();
                        textBox.Text = valor;
                    }
                }
                else if (control is ComboBox comboBox && control.Name.StartsWith("cbx_"))
                {
                    string propertyName = control.Name.Substring(4); // Remove o prefixo "cbx_"
                    PropertyInfo propertyInfo = dados.GetType().GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        string valor = propertyInfo.GetValue(dados)?.ToString();
                        comboBox.Text = valor;
                    }
                }
            }
        }

        //public void preencher(FornecedorData dados)
        //{

        //    txt_codigo.Text = dados.Cod.ToString();
        //    txt_nome.Text = dados.Nome;
        //    txt_bairro.Text = dados.Bairro;
        //    txt_rua.Text = dados.Rua;
        //    txt_num.Text = dados.Num;
        //    txt_cep.Text = dados.Cep;
        //    txt_contato.Text = dados.Contato;
        //    txt_tel1.Text = dados.Tel1;
        //    txt_tel2.Text = dados.Tel2;
        //    txt_ag.Text = dados.Ag;
        //    txt_op.Text = dados.Op;
        //    txt_ct.Text = dados.Ct;
        //    txt_email.Text = dados.Email;
        //    txt_site.Text = dados.Site;

        //    cbx_estado.Text = dados.Estado;
        //    cbx_cidade.Text = dados.Cidade;
        //    cbx_TipoConta.Text = dados.Tipocont;
        //    cbx_ativo.Text = dados.Status.ToString();

        //    mtb_Doc.Text = dados.Doc;

        //}

        private void Frm_FornecedorCadastro_Load(object sender, EventArgs e)
        {

            //--------

            DataTable resultado = new DataTable();

            //Verificação do menor Registro no banco de dados
            //dadosql = string.Format("SELECT MIN(cod) FROM fornecedor");
            //resultado = mConn.LeituraLinha(dadosql);
            //------

            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {

                //Consulta no banco com o menor registro encontrato
                // dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` = '{0}'", resultado.Rows[0]["MIN(cod)"].ToString());
                //resultado = mConn.LeituraLinha(dadosql);
                //------

                //preencher(resultado);
            }
            // bloquearbotao();
            tsm_cancelar.Enabled = false;
            tsm_salvar.Enabled = false;

        }



        private void Txt_site_TextChanged(object sender, EventArgs e)
        {

            lkl_site.Text = txt_Site.Text;
            if (txt_Site.Text == "")
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

            dadosql = string.Format("select id FROM estado WHERE uf = '{0}'", cbx_Estado.Text);
            DataTable resultado = new DataTable();
            ////resultado = mConn.LeituraLinha(dadosql);
            //dadosql = string.Format("SELECT nome FROM `cidade` WHERE estado = '{0}'", resultado.Rows[0]["id"].ToString());
            //cbx_cidade.DisplayMember = "nome";
            //cbx_cidade.DataSource = mConn.LeituraTabela(dadosql);
        }



        private void txt_Tel1_Leave_1(object sender, EventArgs e)
        {
            // if (Convert.ToInt32(txt_Tel1.Text.Length) == 11)
            // {
            //     txt_Tel1.Mask = "(00)00000 - 0000";
            //  }

        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            string ultimo, ultimo1;
            int valor;
            dadosql = string.Format("SELECT MAX(cod) FROM fornecedor");
            //resultado = mConn.LeituraLinha(dadosql);
            ultimo = resultado.Rows[0]["MAX(cod)"].ToString();
            valor = Convert.ToInt16(ultimo);
            valor++;
            ultimo1 = Convert.ToString(valor);
            limpar();
            liberarbotao();

            txt_Id.Text = ultimo1;
            txt_Tel1.Text = "";
            txt_Tel2.Text = "";

            cbx_ativo.Text = "SIM";
            txt_Cidade.Text = "";
            cbx_Estado.Text = "";
            txt_TipoConta.Text = "";


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
                dadosql = string.Format("UPDATE `fornecedor` SET `nome` = '{0}',`estado` = '{1}', `cidade` = '{2}', `bairro` = '{3}', `rua` = '{4}', `num` = '{5}', `cep` = '{6}', `contato` = '{7}', `tel1` = '{8}', `tel2` = '{9}', `tipodoc` = '', `doc` = '{10}', `tipocont` = '{11}', `ag` = '{12}', `op` = '{13}', `ct` = '{14}', `email` = '{15}', `site` = '{16}', `ativo` = '{17}' WHERE `fornecedor`.`cod` = '{18}'", txt_Fantasia.Text, cbx_Estado.Text, txt_Cidade.Text, txt_Bairro.Text, txt_Rua.Text, txt_Num.Text, txt_Cep.Text, txt_Contato.Text, txt_Tel1.Text, txt_Tel2.Text, txt_DocNum.Text.Replace(",", "."), txt_TipoConta.Text, txt_Ag.Text, txt_Op.Text, txt_Ct.Text, txt_Email.Text, txt_Site.Text, cbx_ativo.Text, txt_Id.Text);
                salvo1 = " Item atualizado com exito";
                salvo2 = "ATUALIZADO";
            }
            else
            //Caso o botão editar não seja selecionado, ira inserir um registro 
            {
                dadosql = string.Format("INSERT INTO `fornecedor` (`cod`, `nome`, `estado`, `cidade`, `bairro`, `rua`, `num`, `cep`, `contato`, `tel1`, `tel2`, `tipodoc`, `doc`, `tipocont`, `ag`, `op`, `ct`, `email`, `site`, `ativo`) VALUES (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')", txt_Fantasia.Text, cbx_Estado.Text, txt_Cidade.Text, txt_Bairro.Text, txt_Rua.Text, txt_Num.Text, txt_Cep.Text, txt_Contato.Text, txt_Tel1.Text, txt_Tel2.Text, txt_DocNum.Text.Replace(",", "."), txt_TipoConta.Text, txt_Ag.Text, txt_Op.Text, txt_Ct.Text, txt_Email.Text, txt_Site.Text, cbx_ativo.Text);

                salvo1 = "Item Criado com Exito";
                salvo2 = "CRIADO";

            }
            //mConn.Inserirdb(dadosql);
            if (salvo2 == "ATUALIZADO")
            {
                vlcodigo = Convert.ToInt16(txt_Id.Text);
                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);

                //resultado = mConn.LeituraLinha(dadosql);

                //preencher(resultado);

                bloquearbotao();

                MessageBox.Show(salvo1, salvo2);

            }
            else
            {

                dadosql = string.Format("SELECT MAX(cod) FROM fornecedor");
                //resultado = mConn.LeituraLinha(dadosql);
                codigo = resultado.Rows[0]["MAX(cod)"].ToString();
                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", codigo);

                //resultado = mConn.LeituraLinha(dadosql);

                //preencher(resultado);

                bloquearbotao();
                MessageBox.Show(salvo1, salvo2);
            }



        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM fornecedor");
            //resultado = mConn.LeituraLinha(dadosql);
            if (chx_editar.Checked == true)
            {
                if ((txt_Id.Text != resultado.Rows[0]["MIN(cod)"].ToString()) | (txt_Id.Text == ""))
                {

                }
            }
            else
            {
                txt_Id.Text = resultado.Rows[0]["MIN(cod)"].ToString();
            }
            int vlcodigo;
            vlcodigo = Convert.ToInt16(txt_Id.Text);
            dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);
            //resultado = mConn.LeituraLinha(dadosql);
            //preencher(resultado);
            chx_editar.Checked = false;
            bloquearbotao();
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM fornecedor");
            //resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {

                txt_Id.Text = resultado.Rows[0]["MIN(cod)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt16(txt_Id.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(cod)"]))
            {
                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);

               // preencher(resultado);
                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = true;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM fornecedor WHERE cod < '{0}' ORDER BY cod DESC LIMIT 1", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
               // preencher(resultado);
            }
        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            // Verificação do ultimo registro do banco de dados
            dadosql = string.Format("SELECT MAX(cod) FROM fornecedor");
            DataTable resultado = new DataTable();
            //resultado = mConn.LeituraLinha(dadosql);
            //-----

            //Verificação se o campo CODIGO esta vazio, caso esteja será preenchido com o ultimo valor do banco
            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                txt_Id.Text = resultado.Rows[0]["MAX(cod)"].ToString();
            }
            //-----

            // Criação de variavel para conversão de STRING para INT 
            int vlcodigo;
            vlcodigo = Convert.ToInt16(txt_Id.Text);
            // -----

            if (vlcodigo.Equals(resultado.Rows[0]["MAX(cod)"]))
            {

                dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` ='{0}'", vlcodigo);

                //resultado = mConn.LeituraLinha(dadosql);
                //preencher(resultado);
                tsm_proximo.Enabled = false;

            }
            else
            {
                tsm_anterior.Enabled = true;
                dadosql = string.Format("SELECT * FROM fornecedor WHERE cod > '{0}' ORDER BY cod LIMIT 1", vlcodigo);

                //resultado = mConn.LeituraLinha(dadosql);
                //preencher(resultado);

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
                vlcodigo = Convert.ToInt16(txt_Id.Text);

                dadosql = string.Format("UPDATE fornecedor SET ativo = 'NAO' WHERE cod ='{0}'", vlcodigo);

                //resultado = mConn.LeituraLinha(dadosql);

                MessageBox.Show("Item excluido com exito!", "Excluido");
                dadosql = string.Format("SELECT * FROM fornecedor where `cod` = '{0}'", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                //preencher(resultado);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Processo Cancelado!", "Cancelado");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txt_DocNum.Text.Replace(",", "").Replace("-",""));

            if (txt_DocNum.Text == "   ,   ,   -" || txt_DocNum.Text == "  ,   ,   /    -")
            {
                MessageBox.Show("em branco");
            }
            else
            {
                MessageBox.Show("VAI PORRA !!!");
                int x = txt_DocNum.Text.Replace(",", "").Replace("-", "").Replace("/", "").Length;

                MessageBox.Show(x.ToString());
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            var bla = _fornecedorServices.GetFirstFornec().Result;

            Preencher(bla);
        }
    }
}