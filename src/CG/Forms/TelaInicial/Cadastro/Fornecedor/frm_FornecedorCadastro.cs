using CG.Core.Services;
using CG.Domain.Data;
using CG.Domain.Enum;
using CG.Util;
using CpfCnpjLibrary;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace CG
{
    public partial class frm_FornecedorCadastro : Form
    {
        public readonly UtilForms _utilForms;
        public readonly FornecedorServices _fornecedorServices;
        public readonly HttpExternalQueries _httpExternalQueries;

        public frm_FornecedorCadastro(string usuario)
        {
            InitializeComponent();
            _fornecedorServices = new FornecedorServices();
            _utilForms = new UtilForms();
            _httpExternalQueries = new HttpExternalQueries();

            txt_Usuario.Text = usuario;
            cbx_Status.DataSource = Enum.GetValues(typeof(StatusEnum));
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
            txt_Usuario.Text = usuario;
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
            txt_Cidade.Text = "";
            txt_TipoCont.Text = "";


            cbx_Uf.Text = "";

            cbx_Status.Text = "SIM";

            txt_DocNum.Text = "";
        }

        public void Preencher(FornecedorData dados)
        {
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

        private void Frm_FornecedorCadastro_Load(object sender, EventArgs e)
        {
            UtilForms.CarregamentoDeFormsDesabilitandoCancelareSalvar(menuStrip1.Items);
            var firstFornec = _fornecedorServices.GetFirstFornec().Result;
            UtilForms.PreencherCampos(this, firstFornec);
        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            UtilForms.StatusControles(this, true);
            UtilForms.StatusItensMenu(menuStrip1.Items, false);
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            UtilForms.StatusControles(this, false);
            UtilForms.StatusItensMenu(menuStrip1.Items, true);
            chx_editar.Checked = false;
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
        }

        private void Cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            dadosql = string.Format("select id FROM estado WHERE uf = '{0}'", cbx_Uf.Text);
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



        private void Tsm_editar_Click(object sender, EventArgs e)
        {
            chx_editar.Checked = true;
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            var fornecToInsert = UtilForms.GerarObjeto<FornecedorData>(this);
            var result = _fornecedorServices.InsertFornec(fornecToInsert);


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
                tsm_Anterior.Enabled = false;
                tsm_Proximo.Enabled = true;
            }
            else
            {
                tsm_Proximo.Enabled = true;

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
                tsm_Proximo.Enabled = false;

            }
            else
            {
                tsm_Anterior.Enabled = true;
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
            var fornec = _httpExternalQueries.GetEmpresaPorCNPJ(Cnpj.FormatarSemPontuacao(txt_DocNum.Text));
            txt_Fantasia.Text = fornec.Fantasia;
            txt_Razao.Text = fornec.Nome;
            txt_Cep.Text = fornec.Cep;
            txt_Rua.Text = fornec.Logradouro;
            txt_Cidade.Text = fornec.Municipio;
            cbx_Uf.Text = fornec.UF;
            txt_Bairro.Text = fornec.Bairro;
            txt_Email.Text = fornec.Email;
            txt_Tel1.Text = fornec.Telefone;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var bla = _httpExternalQueries.GetEnderecoPorCep(txt_Cep.Text);
            txt_Rua.Text = bla.logradouro;
            txt_Cidade.Text = bla.localidade;
            cbx_Uf.Text = bla.uf;
            txt_Bairro.Text = bla.bairro;
        }

        private void txt_DocNum_Leave(object sender, EventArgs e)
        {
            if (!Cnpj.Validar(txt_DocNum.Text))
            {
                MessageBox.Show("Documento Invalido.");
                txt_DocNum.Focus();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {


        }
    }
}