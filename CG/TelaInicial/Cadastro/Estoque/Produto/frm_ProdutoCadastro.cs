using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;


namespace CG
{
    public partial class frm_ProdutoCadastro : Form
    {

        public frm_ProdutoCadastro(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

            DataTable resultado = new DataTable();
            resultado = mPermissao.consulta(usuario, this.Name);                        
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
        }

        public void Inserir_Imagem()
        {
            byte[] imagem_byte = null;

            FileStream fstream = new FileStream(this.txt_image.Text, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fstream);

            imagem_byte = br.ReadBytes((int)fstream.Length);

            string server = mConn.String_Conexao();

            string sintax = "INSERT INTO `esto_foto` (`cod`, `cod_prod`, `foto`) VALUES(NULL, @codigo,@foto)";

            MySqlConnection CONEXAO = new MySqlConnection(server);

            MySqlCommand comando_inserir = new MySqlCommand(sintax, CONEXAO);

            MySqlDataReader meu_reader;

            CONEXAO.Open();

            comando_inserir.Parameters.Add(new MySqlParameter("@codigo", txt_codigo.Text));

            comando_inserir.Parameters.Add(new MySqlParameter("@foto", imagem_byte));

            meu_reader = comando_inserir.ExecuteReader();

            CONEXAO.Close();

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
                        MessageBox.Show("Falha ao carregar Perfil.\nInforme o Administrador do sistema.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;

                }
           
        }

        public string foto = "";

        private string permissao;
        Classes.permissoes mPermissao = new Classes.permissoes();

        public frm_ProdutoCadastro(string valor,string usuario)
        {
            //Retorna valor selecionado do frm_ProdutoPesquisa
            InitializeComponent();
            txt_codigo.Text = valor;
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` = '{0}'", txt_codigo.Text);
            resultado = mConn.LeituraLinha(dadosql);
            // função de preenchimento
            preencher(resultado);
            txt_usuario.Text = usuario;
            resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
            //manter o formulario na frente, pois quando retorna normal ele esta indo para traz de tudo 
            this.TopMost = true;

        }

        //declaração da classe de comunicação do MYSQL e a Variavel de comunicação
        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

       

        //bloqueia todos os botões e txt/cbx alterando cor das lbl
        public void bloquearbotao()
        {


            txt_CodExtCod.Enabled = false;
            txt_Ncm.Enabled = false;
            txt_descricao.Enabled = false;
            txt_ca.Enabled = false;
            txt_EstoqueAtual.Enabled = false;
            txt_EstoqueMinimo.Enabled = false;
            txt_PrCusto.Enabled = false;

            cbx_classe.Enabled = false;
            cbx_Unidade.Enabled = false;
            cbx_ativo.Enabled = false;
            cbx_CodExtForne.Enabled = false;

            tsm_salvar.Enabled = false;
            tsm_novo.Enabled = true;
            tsm_editar.Enabled = true;
            tsm_anterior.Enabled = true;
            tsm_proximo.Enabled = true;
            tsm_excluir.Enabled = true;
            tsm_pesquisar.Enabled = true;
            tsm_cancelar.Enabled = false;

            chx_editar.Checked = false;

            btn_SelecionarFoto.Enabled = false;
            btn_ExcluirFoto.Enabled = false;
            btn_AddCodExt.Enabled = false;
            btn_ExcCodExt.Enabled = false;
            btn_ExCodExt.Enabled = false;

            

            
            

            lbl_Cod.ForeColor = Color.Gray;
            lbl_Descricao.ForeColor = Color.Gray;
            lbl_EstAtual.ForeColor = Color.Gray;
            lbl_EstMinimo.ForeColor = Color.Gray;
            lbl_CA.ForeColor = Color.Gray;
            lbl_PrCusto.ForeColor = Color.Gray;
            lbl_Classe.ForeColor = Color.Gray;
            lbl_Unidade.ForeColor = Color.Gray;
            lbl_Ativo.ForeColor = Color.Gray;
            lbl_CodExtCod.ForeColor = Color.Gray;
            lbl_CodExtFornec.ForeColor = Color.Gray;
            lbl_Ncm.ForeColor = Color.Gray;
        }

        //libera todos os botões e txt/cbx alterando cor das lbl
        public void liberarbotao()
        {
            txt_descricao.Enabled = true;
            txt_ca.Enabled = true;
            txt_EstoqueAtual.Enabled = true;
            txt_EstoqueMinimo.Enabled = true;
            txt_PrCusto.Enabled = true;
            txt_CodExtCod.Enabled = true;
            txt_Ncm.Enabled = true;

            tsm_salvar.Enabled = true;
            tsm_novo.Enabled = false;
            tsm_editar.Enabled = false;
            tsm_anterior.Enabled = false;
            tsm_proximo.Enabled = false;
            tsm_excluir.Enabled = false;
            tsm_pesquisar.Enabled = false;
            tsm_cancelar.Enabled = true;

            cbx_classe.Enabled = true;
            cbx_Unidade.Enabled = true;
            cbx_ativo.Enabled = true;
            cbx_CodExtForne.Enabled = true;

            btn_SelecionarFoto.Enabled = true;
            btn_ExcluirFoto.Enabled = true;
            btn_AddCodExt.Enabled = true;
            btn_ExcCodExt.Enabled = true;
            btn_ExCodExt.Enabled = true;       



            lbl_Cod.ForeColor = Color.White;
            lbl_Descricao.ForeColor = Color.White;
            lbl_EstAtual.ForeColor = Color.White;
            lbl_EstMinimo.ForeColor = Color.White;
            lbl_CA.ForeColor = Color.White;
            lbl_PrCusto.ForeColor = Color.White;
            lbl_Classe.ForeColor = Color.White;
            lbl_Unidade.ForeColor = Color.White;
            lbl_Ativo.ForeColor = Color.White;
            lbl_CodExtCod.ForeColor = Color.White;
            lbl_CodExtFornec.ForeColor = Color.White;
            lbl_Ncm.ForeColor = Color.White;

            if (chx_editar.Checked == false)
            {
              pb_Foto.Image = null;
            }
        }

        // função para preenchimento de todas as textbox e combobox
        public void preencher(DataTable dados)
            {
            
                txt_codigo.Text = dados.Rows[0]["cod"].ToString();
                txt_descricao.Text = dados.Rows[0]["descricao"].ToString();            
                txt_EstoqueAtual.Text = dados.Rows[0]["estoqueatual"].ToString();
                txt_EstoqueMinimo.Text = dados.Rows[0]["estoqueminimo"].ToString();
                txt_PrCusto.Text = dados.Rows[0]["prcusto"].ToString();
                txt_ca.Text = dados.Rows[0]["ca"].ToString();

                cbx_classe.Text = dados.Rows[0]["classe"].ToString();
                cbx_Unidade.Text = dados.Rows[0]["unidade"].ToString();
                cbx_ativo.Text = dados.Rows[0]["ativo"].ToString();



                if (chx_CarregarFoto.Checked == true) 
                {
                    dadosql = string.Format("SELECT `foto` FROM `esto_foto`where `cod_prod`= '{0}'", txt_codigo.Text);

                    DataTable resultado = new DataTable();
                    resultado = mConn.LeituraLinha(dadosql);

                    if (resultado.Rows.Count != 0)
                    {
                        byte[] imagem = (byte[])(resultado.Rows[0]["foto"]);

                        if (imagem == null)
                        {
                            pb_Foto.Image = null;
                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(imagem);
                            pb_Foto.Image = System.Drawing.Image.FromStream(mstream);

                        }
                    }
                    else
                    {
                        pb_Foto.Image = null;
                    }
                }
            PreencherDgv();

            }

        public void PreencherDgv()
        {
            dadosql = string.Format("SELECT f.`nome`, e.`codext` FROM `esto_codext` as e INNER JOIN `fornecedor` as f on e.`codforne` = f.`cod` WHERE `codprod` = '{0}'", txt_codigo.Text);
            dgv_CodExt.DataSource = mConn.LeituraTabela(dadosql);
            this.dgv_CodExt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


        }

        //Função para limpar todos os campos, mas ainda sim será necessario usar " " em alguns casos
        private void LimparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                if (ctrl.GetType() == typeof(ComboBox))
                {
                    ctrl.Text = string.Empty; //limpa todos os controles do tipo TextBox
                }
            }
        }

        private void Frm_ProdutoCadastro_Load(object sender, EventArgs e)
        {

            //ComboBox Recebendo Tabelas de Classes e Unidades
            dadosql = string.Format("select classe from esto_classe where ativo = 'sim'");
            cbx_classe.DisplayMember = "classe";
            cbx_classe.DataSource = mConn.LeituraTabela(dadosql);
            cbx_classe.Text = "";

            dadosql = string.Format("select unidade from esto_unidade where ativo = 'sim'");
            cbx_Unidade.DisplayMember = "unidade";
            cbx_Unidade.DataSource = mConn.LeituraTabela(dadosql);
            cbx_Unidade.Text = "";

            dadosql = string.Format("SELECT `nome` FROM `fornecedor` WHERE `ativo` = 'SIM'");
            cbx_CodExtForne.DisplayMember = "nome";
            cbx_CodExtForne.DataSource = mConn.LeituraTabela(dadosql);
            cbx_CodExtForne.Text = "";
            //--------

            DataTable resultado = new DataTable();
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {


                //Verificação do menor Registro no banco de dados
                dadosql = string.Format("SELECT MIN(cod) FROM estoque");
                resultado = mConn.LeituraLinha(dadosql);
                //------

                //Consulta no banco com o menor registro encontrato
                dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` = '{0}'", resultado.Rows[0]["MIN(cod)"].ToString());
                resultado = mConn.LeituraLinha(dadosql);
                //------

            }
            else
            {
                //Consulta o codigo ja possa estar preenchido do form retornado da pesquisa
                dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` = '{0}'", txt_codigo.Text);
                resultado = mConn.LeituraLinha(dadosql);
                //------               
            }


            preencher(resultado);



            tsm_cancelar.Enabled = false;
            tsm_salvar.Enabled = false;
            bloquearbotao();

            controleacesso(lbl_VlPermissao.Text);


        }
        //botão para Novo Registro 

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            //declaração de variaveis
            //foi necessario 2 variaveis string para aceitas as conversões de string para int e de int para string
            DataTable resultado = new DataTable();
            string ultimo, ultimo1;
            int valor;

            //efetua a consulta no banco do maior codigo de regristro
            dadosql = string.Format("SELECT MAX(cod) FROM estoque");
            resultado = mConn.LeituraLinha(dadosql);
            ultimo = resultado.Rows[0]["MAX(cod)"].ToString();

            //converte o codigo para int e soma 1 para o usuario verificar qual é o proximo registro
            valor = Convert.ToInt16(ultimo);
            valor++;
            ultimo1 = Convert.ToString(valor);

            //libera os botões e limpa todos os campos sujos
            liberarbotao();
            LimparTextBoxes(this.Controls);

            //define o campo codigo com o ultimo registro +1 e ja coloca na combobox de ATIVO como SIM para que o usuario não precise inserir manualmente            
            txt_codigo.Text = ultimo1;
            cbx_ativo.Text = "SIM";
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
            dadosql = string.Format("SELECT * FROM `estoque` WHERE `descricao` ='{0}'", txt_descricao.Text);
            resultado = mConn.LeituraLinha(dadosql);
            if ((resultado.Rows.Count == 0) | (chx_editar.Checked == true))
            {
                if (chx_editar.Checked == true)
                {
                    dadosql = string.Format("UPDATE estoque SET `descricao` = '{0}',`classe` = '{1}',`unidade` = '{2}',`estoqueatual`= '{3}',`estoqueminimo` = '{4}',`prcusto` = '{5}',`ca`= '{6}',`ncm` = '{7}',`ativo` = '{8}' WHERE `cod` = '{9}' ", txt_descricao.Text, lbl_CodClasse.Text, lbl_CodUnidade.Text, txt_EstoqueAtual.Text, txt_EstoqueMinimo.Text, txt_PrCusto.Text.Replace(',','.'), txt_ca.Text,txt_Ncm.Text, cbx_ativo.Text, txt_codigo.Text);
                    salvo1 = " Item atualizado com exito";
                    salvo2 = "ATUALIZADO";
                }
                else
                {

                    if (txt_PrCusto.Text == "")
                    {
                        txt_PrCusto.Text = "0";
                    }
                    if (txt_EstoqueAtual.Text == "")
                    {
                        txt_EstoqueAtual.Text = "0";
                    }
                    if (txt_EstoqueMinimo.Text == "")
                    {
                        txt_EstoqueMinimo.Text = "0";
                    }
                    if (txt_ca.Text == "")
                    {
                        txt_ca.Text = "0";
                    }

                    dadosql = string.Format("insert into estoque values(NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", txt_descricao.Text, lbl_CodClasse.Text, lbl_CodUnidade.Text, txt_EstoqueAtual.Text, txt_EstoqueMinimo.Text, txt_PrCusto.Text.Replace(',', '.'), txt_ca.Text,txt_Ncm.Text, cbx_ativo.Text);

                    salvo1 = "Item Criado com Exito";
                    salvo2 = "CRIADO";

                }
                mConn.Inserirdb(dadosql);

                if (txt_image.Text != "" & txt_image.Text != null)
                {
                    dadosql = string.Format("SELECT * FROM `esto_foto` WHERE `cod_prod` = '{0}'", txt_codigo.Text);
                 
                    resultado = mConn.LeituraLinha(dadosql);

                    if (resultado.Rows.Count == 0)
                    {
                        Inserir_Imagem();
                    }
                    else
                    {
                        dadosql = string.Format("DELETE FROM `esto_foto` WHERE `cod_prod` = '{0}'", txt_codigo.Text);
                        mConn.LeituraLinha(dadosql);

                        Inserir_Imagem();
                    }
                }
                else
                {
                    this.foto = "";
                    pb_Foto.Image = null;
                    dadosql = string.Format("DELETE FROM `esto_foto` WHERE `cod_prod` = '{0}'", txt_codigo.Text);
                    mConn.LeituraLinha(dadosql);                    

                }



                if (salvo2 == "ATUALIZADO")
                {
                    vlcodigo = Convert.ToInt16(txt_codigo.Text);
                    dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` ='{0}'", vlcodigo);

                    resultado = mConn.LeituraLinha(dadosql);
                    preencher(resultado);
                    bloquearbotao();
                    MessageBox.Show(salvo1, salvo2,MessageBoxButtons.OK);

                }
                else
                {

                    dadosql = string.Format("SELECT MAX(cod) FROM estoque");
                    resultado = mConn.LeituraLinha(dadosql);
                    codigo = resultado.Rows[0]["MAX(cod)"].ToString();
                    dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` ='{0}'", codigo);

                    resultado = mConn.LeituraLinha(dadosql);
                    preencher(resultado);


                    bloquearbotao();
                    MessageBox.Show(salvo1, salvo2);
                }
            }
            else
            {
                MessageBox.Show("Item existente com codigo: " + resultado.Rows[0]["cod"].ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis e a verificação do menor valor da tabela 
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM estoque");
            resultado = mConn.LeituraLinha(dadosql);
            // verifica se foi clicado o botão editar, se foi clicado é para continuar exibindo o valor normal, se foi clicado em novo ele vai preencher tudo com o primeiro registro
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

            //Pesquisa o menor valor e preenche em todos os campos bloqueando todos os campos e botões necessarios
            int vlcodigo;
            vlcodigo = Convert.ToInt16(txt_codigo.Text);
            dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` ='{0}'", vlcodigo);
            resultado = mConn.LeituraLinha(dadosql);
            preencher(resultado);
            bloquearbotao();
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(cod) FROM estoque");
            resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {

                txt_codigo.Text = resultado.Rows[0]["MIN(cod)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt16(txt_codigo.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(cod)"]))
            {
                dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` ='{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);

                preencher(resultado);
                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = true;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM v_estoque WHERE cod < '{0}' ORDER BY cod DESC LIMIT 1", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            // Verificação do ultimo registro do banco de dados
            dadosql = string.Format("SELECT MAX(cod) FROM estoque");
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

                dadosql = string.Format("SELECT * FROM `v_estoque` WHERE `cod` ='{0}'", vlcodigo);


                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
                tsm_proximo.Enabled = false;

            }
            else
            {
                tsm_anterior.Enabled = true;
                dadosql = string.Format("SELECT * FROM v_estoque WHERE cod > '{0}' ORDER BY cod LIMIT 1", vlcodigo);

                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);

            }
        }
        private void Tsm_pesquisar_Click(object sender, EventArgs e)
        {   
            Frm_ProdutoPesquisa prodpesq = new Frm_ProdutoPesquisa(txt_usuario.Text);
            prodpesq.ShowDialog();
            this.TopMost = false;
            this.Close();
        }


        private void Tsm_excluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o produto? \nExclusão apenas troca a opção ativo para NÃO", "Excluir", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {

                int vlcodigo;
                DataTable resultado = new DataTable();
                vlcodigo = Convert.ToInt16(txt_codigo.Text);

                dadosql = string.Format("UPDATE estoque SET ativo = 'NAO' WHERE cod ='{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);

                MessageBox.Show("Item excluido com exito!", "Excluido");
                dadosql = string.Format("SELECT * FROM v_estoque where `cod` = '{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Processo cancelado!", "Cancelado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void Btn_CarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.* ";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txt_image.Text = foto;
                pb_Foto.ImageLocation = foto;
    
            }                     
        }
        private void Btn_ExcluirFoto_Click(object sender, EventArgs e)
        {

            //dadosql = string.Format(" DELETE FROM `esto_foto` WHERE `cod_prod` = '{0}'", txt_codigo.Text);
          //  mConn.LeituraLinha(dadosql);

            this.foto = "";
            pb_Foto.Image = null;

        }

        private void chx_CarregarFoto_CheckedChanged(object sender, EventArgs e)
        {
            if (chx_CarregarFoto.Checked == true)
            {
                dadosql = string.Format("SELECT `foto` FROM `esto_foto`where `cod_prod`= '{0}'", txt_codigo.Text);

                DataTable resultado = new DataTable();
                resultado = mConn.LeituraLinha(dadosql);

                if (resultado.Rows.Count != 0)
                {
                    byte[] imagem = (byte[])(resultado.Rows[0]["foto"]);

                    if (imagem == null)
                    {
                        pb_Foto.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imagem);
                        pb_Foto.Image = System.Drawing.Image.FromStream(mstream);

                    }
                }
                else
                {
                    pb_Foto.Image = null;
                }
            }
            else
            {
                pb_Foto.Image = null;
            }
        }

        private void cbx_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
          
            dadosql = string.Format("SELECT `cod` FROM esto_classe where `classe` = '{0}'", cbx_classe.Text);
            resultado = mConn.LeituraLinha(dadosql);
            lbl_CodClasse.Text = resultado.Rows[0]["cod"].ToString();
        }
        
        private void cbx_Unidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();

            dadosql = string.Format("SELECT `cod` FROM esto_unidade where `unidade` = '{0}'", cbx_Unidade.Text);
            resultado = mConn.LeituraLinha(dadosql);
            lbl_CodUnidade.Text = resultado.Rows[0]["cod"].ToString();
        }

        private void lbl_CodUnidade_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExCodExt_Click(object sender, EventArgs e)
        {
            CG.TelaInicial.Cadastro.Estoque.Produto.frm_ExCodExt excodext = new TelaInicial.Cadastro.Estoque.Produto.frm_ExCodExt();
            excodext.ShowDialog();
        }

        private void btn_AddCodExt_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `cod` FROM `fornecedor` WHERE `nome` = '{0}'", cbx_CodExtForne.Text);
            resultado = mConn.LeituraTabela(dadosql);

            dadosql = string.Format("SELECT * FROM `esto_codext` WHERE `codprod` = '{0}' AND `codext` = '{1}' AND `codforne` = '{2}'",txt_codigo.Text,txt_CodExtCod.Text,resultado.Rows[0]["cod"].ToString());
                resultado = mConn.LeituraTabela(dadosql);

            if(resultado.Rows.Count == 0)
            {
                dadosql = string.Format("SELECT `cod` FROM `fornecedor` WHERE `nome` = '{0}'", cbx_CodExtForne.Text);
                resultado = mConn.LeituraTabela(dadosql);

                dadosql = string.Format("INSERT INTO `esto_codext` (`cod`, `codforne`, `codprod`, `codext`) VALUES (NULL, '{0}', '{1}', '{2}')", resultado.Rows[0]["cod"].ToString(), txt_codigo.Text, txt_CodExtCod.Text);
                mConn.Inserirdb(dadosql);
                PreencherDgv();
            }
            else
            {
                MessageBox.Show("Codigo externo ja inserdido para esse produto e para esse fornecedor. \nCertifique que as informações estejam corretas","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void Btn_ExcCodExt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CodExtCod.Text))
            {
                MessageBox.Show("Campo Codigo Externo não pode ser em branco","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable resultado = new DataTable();

                dadosql = string.Format("SELECT `cod` FROM `fornecedor` WHERE `nome` = '{0}'", cbx_CodExtForne.Text);
                resultado = mConn.LeituraTabela(dadosql);

                dadosql = string.Format("SELECT * FROM `esto_codext` WHERE `codprod` = '{0}' AND `codext` = '{1}' AND `codforne` = '{2}'", txt_codigo.Text, txt_CodExtCod.Text, resultado.Rows[0]["cod"].ToString());
                resultado = mConn.LeituraTabela(dadosql);

                if (resultado.Rows.Count != 0)
                {

                    DialogResult resposta = MessageBox.Show("Deseja realmente excluir esse codigo externo?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (resposta == DialogResult.Yes)
                    {

                        dadosql = string.Format("SELECT `cod` FROM `fornecedor` WHERE `nome` = '{0}'", cbx_CodExtForne.Text);
                        resultado = mConn.LeituraTabela(dadosql);

                        dadosql = string.Format("DELETE FROM `esto_codext` WHERE `codforne` = '{0}' AND `codprod` = '{1}' AND `codext` = '{2}'", resultado.Rows[0]["cod"].ToString(), txt_codigo.Text, txt_CodExtCod.Text);
                        mConn.Inserirdb(dadosql);
                        PreencherDgv();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo Externo não localizado. \nPor favor acione o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

        }

        private void Dgv_CodExt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CodExtCod.Text = dgv_CodExt.CurrentRow.Cells[1].Value.ToString();
        }

     
    }
}
