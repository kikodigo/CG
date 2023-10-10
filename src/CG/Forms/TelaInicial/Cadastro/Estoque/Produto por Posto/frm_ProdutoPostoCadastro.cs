using System.Data;


namespace CG
{
    public partial class frm_ProdutoPostoCadastro : Form
    {

        public frm_ProdutoPostoCadastro(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

            DataTable resultado = new DataTable();
            //resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
        }

        public void Atualiza_DGV()
        {
            dgv_ProdutoPorPosto.ForeColor = Color.Black;
            dgv_Funcionarios.ForeColor = Color.Black;

            dadosql = string.Format("SELECT  `Codigo Descrição`, `Descrição` FROM `v_esto_posto_por_item` where `Codigo Posto` = '{0}' ORDER by `Codigo Descrição` ASC", txt_CodigoPosto.Text);
            //dgv_ProdutoPorPosto.DataSource = mConn.ConsultaTabela(dadosql);


            dadosmssql = string.Format("select numcad , nomfun  from vetorh.dbo.r034fun where (sitafa<>7 And sitafa<>3 And sitafa<>53 and postra = '{0}')  ORDER by nomfun ASC", txt_CodigoPosto.Text);
            ////dgv_Funcionarios.DataSource = msConn.ConsultaTabela(dadosmssql);

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
                    MessageBox.Show("Falha ao carregar Perfil.\nInforme o Administrador do sistema.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;

            }

        }

        private string permissao;
        ////Classes.permissoes mPermissao = new Classes.permissoes();

        //declaração da classe de comunicação do MYSQL e a Variavel de comunicação
        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();

        private string dadosmssql;
        //Classes.mssqlconect msConn = new Classes.mssqlconect();


        //bloqueia todos os botões e txt/cbx alterando cor das lbl

        private void Atualiza_Descricao()
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `cod_classe` FROM `esto_classe_posto`");
            //resultado = mConn.ConsultaTabela(dadosql);
            int i = 0, contador = resultado.Rows.Count;
            string ComandoMysql, valor;

            ComandoMysql = string.Format("SELECT `descricao` FROM `estoque` WHERE `ativo` = 'sim'");

            while (i < contador)
            {
                if (i == 0)
                {
                    valor = string.Format(" and  `classe` = '{0}' ", resultado.Rows[i]["cod_classe"].ToString());
                }
                else
                {
                    valor = string.Format(" or  `classe` = '{0}' ", resultado.Rows[i]["cod_classe"].ToString());
                }

                ComandoMysql = ComandoMysql + valor;

                i++;
            }

            cbx_descricao.DisplayMember = "descricao";
            //cbx_descricao.DataSource = mConn.LeituraLinha(ComandoMysql);

        }

        private void Frm_ProdutoPostoCadastro_Load(object sender, EventArgs e)
        {
            controleacesso(lbl_VlPermissao.Text);

            dadosmssql = string.Format("select desred from vetorh.dbo.r017pos where estpos = '2' order by desred asc");
            cbx_Posto.DisplayMember = "desred";
            //cbx_Posto.DataSource = msConn.ConsultaTabela(dadosmssql);


            Atualiza_Descricao();
            Atualiza_DGV();

        }

        private void cbx_Posto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();

            string CodigoPosto, NumeroLocal, CodigoCusto, CodigoCargo, CodigoVinculo;

            dadosmssql = string.Format("select postra from vetorh.dbo.r017pos where desred = '{0}' and estpos = '2'", cbx_Posto.Text);
            //resultado = msConn.ConsultaTabela(dadosmssql);
            txt_CodigoPosto.Text = CodigoPosto = resultado.Rows[0]["postra"].ToString();


            dadosmssql = string.Format("select postra, numloc, codccu, codcar, codvin from vetorh.dbo.r017car where postra = '{0}'", CodigoPosto);

            ////resultado = msConn.ConsultaTabela(dadosmssql);



            //txt_CodigoPosto.Text = CodigoPosto = resultado.Rows[0]["postra"].ToString();
            txt_NumeroLocal.Text = NumeroLocal = resultado.Rows[0]["numloc"].ToString();
            txt_CodigoContrato.Text = CodigoCusto = resultado.Rows[0]["codccu"].ToString();
            txt_CodigoCargo.Text = CodigoCargo = resultado.Rows[0]["codcar"].ToString();
            txt_CodigoVinculo.Text = CodigoVinculo = resultado.Rows[0]["codvin"].ToString();


            dadosmssql = string.Format("select (select nomloc from vetorh.dbo.r016orn where numloc = (select top(1) numloc from vetorh.dbo.r017car where postra = '{0}' order by datini desc)) as 'Nome_Local',(select nomccu from vetorh.dbo.r018ccu where codccu = (select top(1) codccu from vetorh.dbo.r017car where postra = '{0}' order by datini desc)) as 'Nome_Contrato',(select titred from vetorh.dbo.r024car where codcar = (select top(1) codcar from vetorh.dbo.r017car where postra = '{0}' order by datini desc )) as 'Nome_Cargo', (select desvin from vetorh.dbo.r022vin where codvin = (select top(1) codvin from vetorh.dbo.r017car where postra = '{0}')) as 'Nome_Vinculo'", CodigoPosto);

            //resultado = msConn.ConsultaTabela(dadosmssql);


            txt_NomeLocal.Text = resultado.Rows[0]["Nome_Local"].ToString();
            txt_NomeContrato.Text = resultado.Rows[0]["Nome_Contrato"].ToString();
            txt_NomeCargo.Text = resultado.Rows[0]["Nome_Cargo"].ToString();
            txt_NomeVinculo.Text = resultado.Rows[0]["Nome_Vinculo"].ToString();



            Atualiza_DGV();
        }

        private void btn_InformarClasse_Click(object sender, EventArgs e)
        {
            CG.TelaInicial.Cadastro.Estoque.Produto_por_Posto.frm_ProdutoPostoClasse ppc = new TelaInicial.Cadastro.Estoque.Produto_por_Posto.frm_ProdutoPostoClasse(txt_usuario.Text);
            ppc.Show();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            Atualiza_Descricao();
            Atualiza_DGV();
        }

        private void btn_InserirItem_Click(object sender, EventArgs e)
        {

            if (txt_CodigoDescricao.Text == "" | txt_CodigoPosto.Text == "")
            {
                MessageBox.Show("deu ruim em ");
            }
            else
            {
                DataTable resultado = new DataTable();
                dadosql = string.Format("SELECT* FROM `esto_posto_por_item` WHERE `cod_posto` = '{0}' AND `cod_descricao`= '{1}'", txt_CodigoPosto.Text, txt_CodigoDescricao.Text);
                //resultado = mConn.ConsultaTabela(dadosql);

                if (resultado.Rows.Count == 0)
                {
                    dadosql = string.Format("INSERT INTO `esto_posto_por_item` (`cod`, `cod_posto`, `cod_descricao`) VALUES(NULL, '{0}', '{1}')", txt_CodigoPosto.Text, txt_CodigoDescricao.Text);
                    //mConn.Inserirdb(dadosql);

                }
                else
                {
                    MessageBox.Show("Item já inserido!", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Atualiza_DGV();
            }

            //INSERT INTO `esto_posto_por_item` (`cod`, `cod_posto`, `cod_descricao`) VALUES(NULL, '123', '2')
        }

        private void btn_ExcluirItem_Click(object sender, EventArgs e)
        {
            if (txt_CodigoDescricao.Text == "" | txt_CodigoPosto.Text == "")
            {
                MessageBox.Show("deu ruim em ");
            }
            else
            {
                DataTable resultado = new DataTable();
                dadosql = string.Format("SELECT* FROM `esto_posto_por_item` WHERE `cod_posto` = '{0}' AND `cod_descricao`= '{1}'", txt_CodigoPosto.Text, txt_CodigoDescricao.Text);
                //resultado = mConn.ConsultaTabela(dadosql);

                if (resultado.Rows.Count != 0)
                {
                    dadosql = string.Format("DELETE FROM esto_posto_por_item WHERE `cod_posto` = '{0}' AND `cod_descricao` = '{1}'", txt_CodigoPosto.Text, txt_CodigoDescricao.Text);
                    //mConn.Inserirdb(dadosql);

                }
                else
                {
                    MessageBox.Show("Item não localizado!", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Atualiza_DGV();
            }
        }

        private void cbx_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `cod` FROM `estoque` where `descricao` = '{0}'", cbx_descricao.Text);
            //resultado = mConn.ConsultaTabela(dadosql);
            txt_CodigoDescricao.Text = resultado.Rows[0]["cod"].ToString();

        }

        private void dgv_ProdutoPorPosto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Cod_Descricao;
            Cod_Descricao = this.dgv_ProdutoPorPosto.CurrentRow.Cells[0].Value.ToString();
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `descricao` FROM `estoque` WHERE `cod` = '{0}'", Cod_Descricao);
            //resultado = mConn.ConsultaTabela(dadosql);
            cbx_descricao.Text = resultado.Rows[0]["descricao"].ToString();
        }
    }
}
