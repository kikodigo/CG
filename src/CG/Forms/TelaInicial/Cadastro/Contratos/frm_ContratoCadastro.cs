using System.Data;

namespace CG.Tela_Inicial.Cadastro.Contratos
{
    public partial class frm_ContratoCadastro : Form
    {
        public frm_ContratoCadastro()
        {
            InitializeComponent();
        }
        public frm_ContratoCadastro(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

            DataTable resultado = new DataTable();
            //resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
            this.TopMost = true;
        }

        public frm_ContratoCadastro(string usuario, string valor)
        {
            InitializeComponent();

            dadosmssql = string.Format("select nomccu from vetorh.dbo.r018ccu");
            cbx_contrato.DisplayMember = "nomccu";
            //cbx_contrato.DataSource = msConn.ConsultaTabela(dadosmssql);



            txt_usuario.Text = usuario;
            txt_codigo.Text = valor;

            DataTable resultado = new DataTable();
            //resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();



            dadosql = string.Format("SELECT * FROM `contrato` where `codcc` = '{0}'", txt_codigo.Text);
            //resultado = mConn.LeituraTabela(dadosql);

            Preencher(resultado);

            this.TopMost = true;

        }


        private readonly string permissao;
        //Classes.permissoes mPermissao = new Classes.permissoes();

        private string dadosmssql;
        //Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();
        public void bloquearbotao()
        {
            cbx_estado.Enabled = false;
            cbx_cidade.Enabled = false;

            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            txt_num.Enabled = false;
            txt_cep.Enabled = false;
            txt_contato.Enabled = false;
            txt_tel1.Enabled = false;
            txt_tel2.Enabled = false;
            txt_obs.Enabled = false;
            txt_PrLimite.Enabled = false;

            tsm_limpar.Enabled = false;
            tsm_salvar.Enabled = false;
            tsm_editar.Enabled = true;
            tsm_pesquisar.Enabled = true;
            tsm_cancelar.Enabled = false;

            lbl_Contrato.ForeColor = Color.Gray;
            lbl_Telefone1.ForeColor = Color.Gray;
            lbl_Telefone2.ForeColor = Color.Gray;
            lbl_CEP.ForeColor = Color.Gray;
            lbl_Rua.ForeColor = Color.Gray;
            lbl_Estado.ForeColor = Color.Gray;
            lbl_Bairro.ForeColor = Color.Gray;
            lbl_Contato.ForeColor = Color.Gray;
            lbl_Cidade.ForeColor = Color.Gray;
            lbl_PrecoLimite.ForeColor = Color.Gray;
            lbl_N.ForeColor = Color.Gray;
            lbl_Observacao.ForeColor = Color.Gray;
        }

        public void liberarbotao()
        {
            cbx_estado.Enabled = true;
            cbx_cidade.Enabled = true;
            cbx_cidade.Enabled = true;
            cbx_estado.Enabled = true;

            txt_bairro.Enabled = true;
            txt_rua.Enabled = true;
            txt_num.Enabled = true;
            txt_cep.Enabled = true;
            txt_contato.Enabled = true;
            txt_tel1.Enabled = true;
            txt_tel2.Enabled = true;
            txt_obs.Enabled = true;
            txt_PrLimite.Enabled = true;

            tsm_limpar.Enabled = true;
            tsm_salvar.Enabled = true;
            tsm_editar.Enabled = false;
            tsm_pesquisar.Enabled = false;
            tsm_cancelar.Enabled = true;

            lbl_Contrato.ForeColor = Color.White;
            lbl_Telefone1.ForeColor = Color.White;
            lbl_Telefone2.ForeColor = Color.White;
            lbl_CEP.ForeColor = Color.White;
            lbl_Rua.ForeColor = Color.White;
            lbl_Estado.ForeColor = Color.White;
            lbl_Bairro.ForeColor = Color.White;
            lbl_Contato.ForeColor = Color.White;
            lbl_Cidade.ForeColor = Color.White;
            lbl_PrecoLimite.ForeColor = Color.White;
            lbl_N.ForeColor = Color.White;
            lbl_Observacao.ForeColor = Color.White;
        }

        public void Preencher(DataTable dados)
        {

            cbx_estado.Text = dados.Rows[0]["estado"].ToString();
            cbx_contrato.Text = dados.Rows[0]["nome_contrato"].ToString();
            cbx_cidade.Text = dados.Rows[0]["cidade"].ToString();

            txt_bairro.Text = dados.Rows[0]["bairro"].ToString();
            txt_rua.Text = dados.Rows[0]["rua"].ToString();
            txt_num.Text = dados.Rows[0]["num"].ToString();
            txt_cep.Text = dados.Rows[0]["cep"].ToString();
            txt_contato.Text = dados.Rows[0]["contato"].ToString();
            txt_tel1.Text = dados.Rows[0]["tel1"].ToString();
            txt_tel2.Text = dados.Rows[0]["tel2"].ToString();
            txt_PrLimite.Text = dados.Rows[0]["prlimite"].ToString();
            txt_obs.Text = dados.Rows[0]["obs"].ToString();



        }

        public void limpatudo()
        {
            cbx_estado.Text = "";
            cbx_cidade.Text = "";

            txt_bairro.Text = "";
            txt_rua.Text = "";
            txt_num.Text = "";
            txt_cep.Text = "";
            txt_contato.Text = "";
            txt_tel1.Text = "";
            txt_tel2.Text = "";
            txt_obs.Text = "";
            txt_PrLimite.Text = "";
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
                    tsm_editar.Visible = false;
                    break;

                case "0":
                    MessageBox.Show("Acesso negado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    break;

                default:
                    MessageBox.Show("Falha ao carregar Perfil.\nInforme o Administrador do sistema.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;

            }
        }

        private void Frm_ContratoCadastro_Load(object sender, EventArgs e)
        {

            if (txt_codigo.Text == "")
            {
                dadosmssql = string.Format("select nomccu from vetorh.dbo.r018ccu");
                cbx_contrato.DisplayMember = "nomccu";
                //cbx_contrato.DataSource = msConn.ConsultaTabela(dadosmssql);

            }


            bloquearbotao();
            controleacesso(lbl_VlPermissao.Text);



        }

        private void Cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dadosql = string.Format("select id FROM estado WHERE uf = '{0}'", cbx_estado.Text);
            DataTable resultado = new DataTable();
            //resultado = mConn.LeituraLinha(dadosql);
            dadosql = string.Format("SELECT nome FROM `cidade` WHERE estado = '{0}'", resultado.Rows[0]["id"].ToString());
            cbx_cidade.DisplayMember = "nome";
            //cbx_cidade.DataSource = mConn.LeituraTabela(dadosql);
        }

        private void Tsm_editar_Click(object sender, EventArgs e)
        {
            liberarbotao();
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `nome_contrato` FROM contrato WHERE `nome_contrato` = '{0}'", cbx_contrato.Text);
            //resultado = mConn.LeituraTabela(dadosql);
            if (resultado.Rows.Count == 0)
            {
                dadosql = string.Format("INSERT INTO `contrato` (`cod`, `codcc`, `nome_contrato`, `estado`, `cidade`, `bairro`, `rua`, `num`,`cep`, `contato`, `tel1`, `tel2`, `obs`,`prlimite`) VALUES(NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", txt_codigo.Text, cbx_contrato.Text, cbx_estado.Text, cbx_cidade.Text, txt_bairro.Text, txt_rua.Text, txt_num.Text, txt_cep.Text, txt_contato.Text, txt_tel1.Text, txt_tel2.Text, txt_obs.Text, txt_PrLimite.Text);
                //mConn.Inserirdb(dadosql);
            }
            else
            {


                dadosql = string.Format("UPDATE `contrato` SET `estado` = '{0}', `cidade` = '{1}', `bairro` = '{2}', `rua` = '{3}', `num` = '{4}',`cep` = '{5}', `contato` = '{6}', `tel1` = '{7}', `tel2` = '{8}', `obs` = '{9}', `prlimite` = '{11}' WHERE `codcc` = '{10}'", cbx_estado.Text, cbx_cidade.Text, txt_bairro.Text, txt_rua.Text, txt_num.Text, txt_cep.Text, txt_contato.Text, txt_tel1.Text, txt_tel2.Text, txt_obs.Text, txt_codigo.Text, txt_PrLimite.Text.Replace(',', '.'));
                //mConn.Inserirdb(dadosql);
            }

            bloquearbotao();
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            bloquearbotao();
        }

        private void Tsm_pesquisar_Click(object sender, EventArgs e)
        {
            frm_ContratoPesquisa ctrp = new frm_ContratoPesquisa(txt_usuario.Text);
            ctrp.Show();
            this.TopMost = false;
            this.Close();

        }

        private void Tsm_limpar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Limpar todos os campos ?", "Limpeza", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                cbx_cidade.Text = "";
                cbx_estado.Text = "";
                txt_bairro.Text = "";
                txt_rua.Text = "";
                txt_num.Text = "";
                txt_cep.Text = "";
                txt_contato.Text = "";
                txt_tel1.Text = "";
                txt_tel2.Text = "";
                txt_PrLimite.Text = "0";
                txt_obs.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Processo Cancelado!", "Cancelado");
            }
        }

        private void Txt_obs_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cbx_contrato_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dadosmssql = string.Format("select codccu from vetorh.dbo.r018ccu where nomccu = '{0}'", cbx_contrato.Text);
            DataTable resultado = new DataTable();
            //resultado = msConn.ConsultaTabela(dadosmssql);
            //w

            if (cbx_contrato.Text != "")
            {
                txt_codigo.Text = resultado.Rows[0]["codccu"].ToString();
            }





            dadosql = string.Format("SELECT * FROM `contrato` where `codcc` = '{0}'", txt_codigo.Text);
            //resultado = mConn.LeituraTabela(dadosql);

            if (resultado.Rows.Count != 0)
            {
                Preencher(resultado);
            }
            else
            {
                cbx_estado.Text = "";
                cbx_cidade.Text = "";

                txt_bairro.Text = "";
                txt_rua.Text = "";
                txt_num.Text = "";
                txt_cep.Text = "";
                txt_contato.Text = "";
                txt_tel1.Text = "";
                txt_tel2.Text = "";
                txt_obs.Text = "";
                txt_PrLimite.Text = "";

            }



        }

    }
}
