using CG.TelaInicial.ControleEstoque.Saida;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CG.Tela_Inicial.Controle_Estoque.Saida
{
    public partial class frm_ControleSaida : Form
    {
        public frm_ControleSaida()
        {
            InitializeComponent();
        }

        public frm_ControleSaida(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }

        private string dadosmssql;
        Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();


        public void Bloquearbotao()
        {


            // Txt|CBX|CHX - controle de editaveis
            cbx_Contrato.Enabled = false;
            cbx_Descricao.Enabled = false;
            cbx_req.Enabled = false;
            cbx_MetEnvio.Enabled = false;

            txt_Qtd.Enabled = false;
            txt_InfoEnvio.Enabled = false;
            txt_Data.Enabled = false;
            txt_PrevisaoEnvio.Enabled = false;
            txt_Obs.Enabled = false;

            btn_adicionar.Enabled = false;
            btn_ExcluirItem.Enabled = false;
            btn_ReqTransferencia.Enabled = false;

            chx_Patrimonio.Checked = false;
            chx_Patrimonio.Enabled = false;
            chx_Editar.Checked = false;


            //-----

            //TSM - Barra superior
            tsm_novo.Enabled = true;
            tsm_salvar.Enabled = false;
            tsm_editar.Enabled = true;
            tsm_anterior.Enabled = true;
            tsm_proximo.Enabled = true;
            tsm_excluir.Enabled = true;
            tsm_pesquisar.Enabled = true;
            tsm_cancelar.Enabled = false;
            //------

            //lbl - Controle de Labels
            lbl_Cod.ForeColor = Color.Gray;
            lbl_Data.ForeColor = Color.Gray;
            lbl_Contrato1.ForeColor = Color.Gray;
            lbl_req.ForeColor = Color.Gray;
            lbl_Contrato2.ForeColor = Color.Gray;
            lbl_Descricao.ForeColor = Color.Gray;
            lbl_qtd.ForeColor = Color.Gray;
            lbl_InfoEnvio.ForeColor = Color.Gray;
            lbl_Status.ForeColor = Color.Gray;
            lbl_MetEnvio.ForeColor = Color.Gray;
            lbl_DataEnvio.ForeColor = Color.Gray;
            lbl_PreviEnvio.ForeColor = Color.Gray;
            lbl_Obs.ForeColor = Color.Gray;
            lbl_Status.ForeColor = Color.Gray;
            chx_Patrimonio.ForeColor = Color.Gray;
            //------

        }

        public void Liberarbotao()
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `status` FROM `esto_saida` WHERE `codsaida` = '{0}'", txt_Cod.Text);
            resultado = mConn.LeituraLinha(dadosql);
            if ((resultado.Rows[0]["status"].ToString() == "ENVIADO" || resultado.Rows[0]["status"].ToString() == "CANCELADO") & chx_Editar.Checked == true)
            {
                MessageBox.Show("Requisição esta com o status em " + resultado.Rows[0]["status"].ToString() + " impedindo qualquer alteração. \nQualquer duvida, entre em contato com o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Txt|CBX|CHX - controle de editaveis
                if (cbx_Contrato.Text == "")
                {
                    cbx_Contrato.Enabled = true;
                }
                else
                {
                    cbx_Contrato.Enabled = false;
                }

                cbx_Descricao.Enabled = true;
                cbx_req.Enabled = true;
                cbx_MetEnvio.Enabled = true;

                txt_Qtd.Enabled = true;
                txt_InfoEnvio.Enabled = true;
                txt_PrevisaoEnvio.Enabled = true;
                txt_Obs.Enabled = true;

                btn_adicionar.Enabled = true;
                btn_ExcluirItem.Enabled = true;
                btn_ReqTransferencia.Enabled = true;

                chx_Liberar.Enabled = true;

                //-----

                //TSM - Barra superior
                tsm_salvar.Enabled = true;
                tsm_novo.Enabled = false;
                tsm_editar.Enabled = false;
                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = false;
                tsm_pesquisar.Enabled = false;
                tsm_cancelar.Enabled = true;
                //--------

                //lbl - Controle de Labels
                lbl_Cod.ForeColor = Color.White;
                lbl_Data.ForeColor = Color.White;
                lbl_Contrato1.ForeColor = Color.White;
                lbl_req.ForeColor = Color.White;
                lbl_Contrato2.ForeColor = Color.White;
                lbl_Descricao.ForeColor = Color.White;
                lbl_qtd.ForeColor = Color.White;
                lbl_InfoEnvio.ForeColor = Color.White;
                lbl_MetEnvio.ForeColor = Color.White;
                lbl_DataEnvio.ForeColor = Color.White;
                lbl_PreviEnvio.ForeColor = Color.White;
                lbl_Obs.ForeColor = Color.White;
                lbl_Status.ForeColor = Color.White;
                //------
            }
        }

        public void Preencher(DataTable resultado)
        {

            txt_Cod.Text = resultado.Rows[0]["codsaida"].ToString();
            txt_Data.Text = Convert.ToDateTime(resultado.Rows[0]["data"]).ToString("dd/MM/yyyy");
            cbx_Contrato.Text = resultado.Rows[0]["nomcont"].ToString();
            txt_Status.Text = resultado.Rows[0]["status"].ToString();
            if (resultado.Rows[0]["metenvio"].ToString() == "")
            {
                cbx_MetEnvio.Text = null;
            }
            else
            {
                cbx_MetEnvio.Text = resultado.Rows[0]["metenvio"].ToString();
            }

            txt_InfoEnvio.Text = resultado.Rows[0]["infoenvio"].ToString();
            txt_Obs.Text = resultado.Rows[0]["obs"].ToString();

            if (resultado.Rows[0]["dataenvio"].ToString() != "01/01/0001 00:00:00")
                txt_DataEnvio.Text = Convert.ToDateTime(resultado.Rows[0]["dataenvio"]).ToString("dd/MM/yyyy");

            if (resultado.Rows[0]["prevenvio"].ToString() != "01/01/0001 00:00:00")
                txt_PrevisaoEnvio.Text = Convert.ToDateTime(resultado.Rows[0]["prevenvio"]).ToString("dd/MM/yyyy");




            if ((resultado.Rows[0]["status"].ToString() == "ENVIADO" || resultado.Rows[0]["status"].ToString() == "CANCELADO"))
            {
                chx_Liberar.Checked = true;
                chx_Liberar.Enabled = false;
            }
            else
            {
                chx_Liberar.Checked = false;
            }



            PreencherDgv();
        }

        public void PreencherDgv()
        {

            dadosql = string.Format("SELECT `cod`,`coditem`,`descricao`,`patrimonio`,`resp_envio` FROM `v_patrimonio` WHERE `codsaida` ='{0}'", txt_Cod.Text);
            dgv_Patrimonio.DataSource = mConn.LeituraTabela(dadosql);


            dadosql = string.Format("SELECT `coditem`,`descricao`,`qtd`,`req` FROM `v_esto_saida_item` where `codsaida` = '{0}'", txt_Cod.Text);
            dgv_SaidaCompleto.DataSource = mConn.LeituraTabela(dadosql);

        }

        public void limpar_campos()
        {
            txt_Cod.Text = "";
            txt_Data.Text = "";
            txt_Qtd.Text = "";
            txt_Status.Text = "";
            txt_DataEnvio.Text = "";
            txt_InfoEnvio.Text = "";
            txt_PrevisaoEnvio.Text = "";
            txt_Obs.Text = "";
            txt_contrato.Text = "";
            txt_Status.Text = "";

            cbx_Contrato.Text = "";
            cbx_Descricao.Text = "";
            cbx_MetEnvio.Text = "";
            cbx_req.Text = "";


            chx_Editar.Checked = false;
            chx_Liberar.Checked = false;
            chx_Patrimonio.Checked = false;

        }

        private void frm_ControleSaida_Load(object sender, EventArgs e)
        {

            dadosql = string.Format("SELECT `codreq` FROM `requerimento` where `status` = 'APROVADO' ORDER BY `requerimento`.`codreq` DESC");
            cbx_req.DisplayMember = "codreq";
            cbx_req.DataSource = mConn.ConsultaTabela(dadosql);
            cbx_req.Text = "";


            dadosql = string.Format("SELECT `descricao` FROM `estoque` where `ativo` = 'SIM'");
            cbx_Descricao.DisplayMember = "descricao";
            cbx_Descricao.DataSource = mConn.ConsultaTabela(dadosql);
            cbx_Descricao.Text = "";


            dadosmssql = string.Format("select nomccu from vetorh.dbo.r018ccu order by nomccu asc");
            cbx_Contrato.DisplayMember = "nomccu";
            cbx_Contrato.DataSource = msConn.ConsultaTabela(dadosmssql);
            cbx_Contrato.Text = "";



            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MAX(`codsaida`) as 'ULTIMO' FROM `esto_saida`");
            resultado = mConn.LeituraLinha(dadosql);
            dadosql = string.Format("SELECT * FROM `esto_saida` WHERE `codsaida` = '{0}'", resultado.Rows[0]["ULTIMO"].ToString());
            resultado = mConn.LeituraLinha(dadosql);

            Preencher(resultado);



            dgv_TotalCompleto.DataSource = null;
            dgv_TotalItens.DataSource = null;
            txt_contrato.Text = "";
            Bloquearbotao();
        }

        private void cbx_Contratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `contrato` FROM `requerimento` where `codreq` = '{0}'", cbx_req.Text);
            resultado = mConn.LeituraLinha(dadosql);
            txt_contrato.Text = resultado.Rows[0]["contrato"].ToString();

            dadosql = string.Format("SELECT `coditem`, `descricao`, sum(`qtd_lib`) FROM `req_item` where `codreq` = '{0}' GROUP by `coditem`", cbx_req.Text);
            dgv_TotalItens.DataSource = mConn.LeituraTabela(dadosql);

            dadosql = string.Format("SELECT `func`,`descricao`,`qtd_lib` FROM `req_item` WHERE `codreq` = {0}", cbx_req.Text);
            dgv_TotalCompleto.DataSource = mConn.LeituraTabela(dadosql);

        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();
            if ((cbx_Descricao.Text == "") && (txt_Qtd.Text == ""))
            {
                MessageBox.Show("Por favor, selecione um item e informe a quantidade!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dadosql = string.Format("SELECT `req` FROM `esto_saida_item` WHERE `codsaida` = '{0}' LIMIT 1", txt_Cod.Text);
                resultado = mConn.LeituraTabela(dadosql);
                if (resultado.Rows.Count != 0)
                {
                    //if (resultado.Rows[0]["req"].ToString() != "0" || resultado.Rows[0]["SOMA"].ToString() != "")
                    //{
                    //MessageBox.Show(resultado.Rows[0]["SOMA"].ToString());
                    MessageBox.Show("Já existe itens neste controle referente a uma requisição! \nNão é permitido inserir itens a mais de um controle vinculado a uma requisição!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                }
                else
                {
                    if (txt_Qtd.Text == "0")
                    {
                        MessageBox.Show("A quantidade não pode ser 0", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dadosmssql = string.Format("select codccu from vetorh.dbo.r018ccu where nomccu = '{0}'", cbx_Contrato.Text);
                        resultado = msConn.ConsultaTabela(dadosmssql);
                        string codcontrato = resultado.Rows[0]["codccu"].ToString();

                        dadosql = string.Format("SELECT `cod` FROM `estoque` WHERE `descricao` = '{0}'", cbx_Descricao.Text);
                        resultado = mConn.ConsultaTabela(dadosql);
                        string coditem = resultado.Rows[0]["cod"].ToString();

                        dadosql = string.Format("INSERT INTO `esto_saida_item` (`cod`, `codsaida`, `codcont`, `nomcont`, `coditem`, `qtd`, `req`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '0')", txt_Cod.Text, codcontrato, cbx_Contrato.Text, coditem, txt_Qtd.Text);
                        mConn.Inserirdb(dadosql);

                        if (chx_Patrimonio.Checked)
                        {
                            int x = 0;
                            while (x < Convert.ToInt32(txt_Qtd.Text))
                            {
                                dadosql = string.Format("INSERT INTO `esto_patrimonio` (`cod`, `codsaida`, `nomcont`, `coditem`, `patrimonio`, `data_saida`, `resp_envio`, `recebedor`, `data_retorno`, `resp_retorno`) VALUES (NULL, '{0}', '{1}', '{2}', 0, '0000-00-00','', '', '0000-00-00', '')", txt_Cod.Text, cbx_Contrato.Text, coditem);
                                mConn.Inserirdb(dadosql);
                                x++;
                            }
                        }
                        PreencherDgv();
                    }
                }




            }
        }

        private void btn_ExcluirItem_Click(object sender, EventArgs e)
        {
            // btn_adicionar.PerformClick();
            DataTable resultado = new DataTable();

            dadosql = string.Format("SELECT COUNT(*) AS `QTD` FROM `esto_saida_item` WHERE `codsaida` = '{0}' AND `coditem` = '{1}'", txt_Cod.Text, lbl_CodItem.Text);
            resultado = mConn.LeituraLinha(dadosql);
            if (resultado.Rows[0]["QTD"].ToString() != "0")
            {
                dadosql = string.Format("SELECT SUM(`req`) AS `SOMA` FROM `esto_saida_item` WHERE `codsaida` = '{0}'", txt_Cod.Text);
                resultado = mConn.LeituraTabela(dadosql);
                if (resultado.Rows[0]["SOMA"].ToString() != "0")
                {
                    MessageBox.Show("Existe itens neste controle referente a uma requisição! \nNão é permitido excluir itens de um controle vinculado a uma requisição!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    dadosql = string.Format("SELECT COUNT(*) AS `QTD` FROM `esto_patrimonio` WHERE `codsaida` = '{0}' AND `coditem` = '{1}'", txt_Cod.Text, lbl_CodItem.Text);
                    resultado = mConn.LeituraLinha(dadosql);
                    if (resultado.Rows[0]["QTD"].ToString() == "0")
                    {
                        dadosql = string.Format("DELETE FROM `esto_saida_item` WHERE `codsaida` = '{0}' AND `coditem` = '{1}'", txt_Cod.Text, lbl_CodItem.Text);
                        mConn.Inserirdb(dadosql);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Existem itens no campo de patrimônio.\nA exclusão irá remover todos os itens tanto da descrição geral quanto do campo de patrimônio. \nDeseja reslmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {
                            dadosql = string.Format("DELETE FROM `esto_saida_item` WHERE `codsaida` = '{0}' AND `coditem` = '{1}'", txt_Cod.Text, lbl_CodItem.Text);
                            mConn.Inserirdb(dadosql);

                            dadosql = string.Format("DELETE FROM `esto_patrimonio` WHERE `codsaida` = '{0}' AND `coditem` = '{1}'", txt_Cod.Text, lbl_CodItem.Text);
                            mConn.Inserirdb(dadosql);

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Processo cancelado!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Não existe esse item na listagem abaixo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            PreencherDgv();
        }

        private void tsm_novo_Click(object sender, EventArgs e)
        {
            limpar_campos();

            txt_Data.Text = DateTime.Now.ToShortDateString();

            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT COUNT(cod) FROM `esto_saida`");
            resultado = mConn.LeituraLinha(dadosql);

            if (resultado.Rows[0]["COUNT(cod)"].ToString() == "0")
            {
                dadosql = string.Format("INSERT INTO `esto_saida` (`cod`, `codsaida`, `data`, `codcont`, `nomcont`, `status`, `metenvio`, `infoenvio`, `prevenvio`, `dataenvio`, `obs`) VALUES(NULL, '1', '{0}', '', '', 'EM ANDAMENTO', '', '', '0000-00-00', '0000-00-00', '')", Convert.ToDateTime(txt_Data.Text).ToString("yyyy-MM-dd"));
                mConn.Inserirdb(dadosql);

                dadosql = string.Format("SELECT * FROM `esto_saida` where `codsaida` = '1'");
                resultado = mConn.LeituraLinha(dadosql);

                Preencher(resultado);

            }
            else
            {
                dadosql = string.Format("SELECT max(`codsaida`) AS 'ULTIMO' FROM `esto_saida`");
                resultado = mConn.LeituraLinha(dadosql);
                int cod = Convert.ToInt32(resultado.Rows[0]["ULTIMO"].ToString());
                cod++;

                dadosql = string.Format("INSERT INTO `esto_saida` (`cod`, `codsaida`, `data`, `codcont`, `nomcont`, `status`, `metenvio`, `infoenvio`, `prevenvio`, `dataenvio`, `obs`) VALUES(NULL, '{0}', '{1}', '', '', 'EM ANDAMENTO', '', '', '0000-00-00', '0000-00-00', '')", cod, Convert.ToDateTime(txt_Data.Text).ToString("yyyy-MM-dd"));
                mConn.Inserirdb(dadosql);

                dadosql = string.Format("SELECT * FROM `esto_saida` where `codsaida` = '{0}'", cod);
                resultado = mConn.LeituraLinha(dadosql);

                Preencher(resultado);

            }
            Liberarbotao();

        }

        private void tsm_cancelar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            if (chx_Editar.Checked == false)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente cancelar? \nTudo que foi feito será excluido. \nInclusive os patrimônios.", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    dadosql = string.Format("DELETE FROM `esto_saida` WHERE `codsaida` = '{0}'", txt_Cod.Text);
                    mConn.Inserirdb(dadosql);

                    dadosql = string.Format("DELETE FROM `esto_saida_item` WHERE `codsaida` = '{0}'", txt_Cod.Text);
                    mConn.Inserirdb(dadosql);

                    dadosql = string.Format("DELETE FROM `esto_patrimonio` WHERE `codsaida` = '{0}'", txt_Cod.Text);
                    mConn.Inserirdb(dadosql);

                    dadosql = string.Format("SELECT MAX(`codsaida`) as 'ULTIMO' FROM `esto_saida`");
                    resultado = mConn.LeituraLinha(dadosql);
                    dadosql = string.Format("SELECT * FROM `esto_saida` WHERE `codsaida` = '{0}'", resultado.Rows[0]["ULTIMO"].ToString());
                    resultado = mConn.LeituraLinha(dadosql);

                    Preencher(resultado);


                }

            }
            else
            {
                dadosql = string.Format("SELECT * FROM `esto_saida` where `codsaida` = '{0}'", txt_Cod.Text);
                resultado = mConn.LeituraLinha(dadosql);

                Preencher(resultado);
            }

            Bloquearbotao();
        }

        private void tsm_editar_Click(object sender, EventArgs e)
        {
            chx_Editar.Checked = true;
            Liberarbotao();
        }

        private void tsm_salvar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            DateTime dt = new DateTime();
            string PrevEnvio;
            if (txt_PrevisaoEnvio.Text == "")
            {
                PrevEnvio = "0000-00-00";
            }
            else
            {
                dt = Convert.ToDateTime(txt_PrevisaoEnvio.Text);

                PrevEnvio = dt.ToString("yyyy-MM-dd");
            }


            if (chx_Liberar.Checked == true && cbx_Contrato.Text != "")
            {
                txt_DataEnvio.Text = DateTime.Now.ToShortDateString();
                txt_Status.Text = "ENVIADO";

                dadosql = string.Format("SELECT s.codsaida,e.`cod`,e.`descricao`,e.`estoqueatual`,s.qtd FROM `estoque` AS e INNER JOIN esto_saida_item AS s ON e.`cod` = s.coditem WHERE s.`codsaida` = '{0}'", txt_Cod.Text);
                resultado = mConn.LeituraTabela(dadosql);
                int contador = 0;
                while (contador < resultado.Rows.Count)
                {
                    dadosql = string.Format("UPDATE `estoque` SET `estoqueatual` = `estoqueatual` - {0} WHERE `estoque`.`cod` = '{1}'", resultado.Rows[contador]["qtd"].ToString(), resultado.Rows[contador]["cod"].ToString());

                    mConn.Inserirdb(dadosql);

                    contador++;
                }


                dadosql = string.Format("UPDATE `requerimento` SET `status` = '{0}', `prev` = '{1}', `data_envio` = '{2}', `tipo_envio` = '{3}' WHERE `codreq` = (SELECT `req` FROM `esto_saida_item` WHERE `codsaida` = {4} GROUP BY `req`)", txt_Status.Text, PrevEnvio, Convert.ToDateTime(txt_DataEnvio.Text).ToString("yyyy-MM-dd"), cbx_MetEnvio.Text, txt_Cod.Text);
                mConn.Inserirdb(dadosql);

            }
            if (cbx_Contrato.Text != "")
            {
                dadosmssql = string.Format("select codccu from vetorh.dbo.r018ccu where nomccu = '{0}'", cbx_Contrato.Text);
                resultado = msConn.ConsultaTabela(dadosmssql);
                string codcontrato = resultado.Rows[0]["codccu"].ToString();



                dadosql = string.Format("UPDATE `esto_saida` SET `codcont` = '{0}', `nomcont` = '{1}', `status` = '{2}', `metenvio` = '{3}', `infoenvio` = '{4}', `prevenvio` = '{5}',  `obs` = '{6}' WHERE `codsaida` = {7}", codcontrato, cbx_Contrato.Text, txt_Status.Text, cbx_MetEnvio.Text, txt_InfoEnvio.Text, PrevEnvio, txt_Obs.Text, txt_Cod.Text);
                mConn.Inserirdb(dadosql);

                txt_PrevisaoEnvio.Text = null;
                Bloquearbotao();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um contrato", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void cbx_MetEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_MetEnvio.Text == "CORREIOS")
            {
                lbl_InfoEnvio.Text = "Codigo de Rastreio";
            }
            else
            {
                lbl_InfoEnvio.Text = "Informações do envio";
            }
        }



        private void frm_ControleSaida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tsm_novo.Enabled == false)
            {
                DialogResult Resposta;
                Resposta = MessageBox.Show("Deseja realmente fechar essa tela? \nTodas as alterações não serão salvas.", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resposta.Equals(DialogResult.No))
                {
                    e.Cancel = true;
                }
            }

        }

        private void btn_PatriAdicionar_Click(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT COUNT(`cod`) as 'resultado' FROM `esto_patrimonio` WHERE `patrimonio` =  '{0}'", txt_Patrimonio.Text);
            resultado = mConn.ConsultaTabela(dadosql);

            if (Convert.ToInt32(resultado.Rows[0]["resultado"].ToString()) == 0)
            {
                dadosql = string.Format("UPDATE `esto_patrimonio` SET `patrimonio` = '{0}', `resp_envio` = '{1}' WHERE `esto_patrimonio`.`cod` = {2}", txt_Patrimonio.Text, txt_PatriResponsavel.Text, txt_PatriCod.Text);
                mConn.Inserirdb(dadosql);

                PreencherDgv();

                txt_PatriCod.Text = "";
                txt_Patrimonio.Text = "";
                txt_PatriResponsavel.Text = "";
            }
            else
            {
                dadosql = string.Format("SELECT * FROM `v_patrimonio` WHERE `patrimonio` ='{0}'", txt_Patrimonio.Text);
                resultado = mConn.ConsultaTabela(dadosql);
                MessageBox.Show("Já existe um item com este patrimônio! \nEsta vinculado a saida: \nCodigo de Saida: " + resultado.Rows[0]["codsaida"].ToString() + "\nContrato: " + resultado.Rows[0]["nomcont"].ToString() + "\nItem:" + resultado.Rows[0]["descricao"].ToString() + "", "Patrimônio em duplicidade.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dgv_Patrimonio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_PatriCod.Text = this.dgv_Patrimonio.CurrentRow.Cells[0].Value.ToString();
            lbl_CodItem.Text = this.dgv_Patrimonio.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_PatriExcluir_Click(object sender, EventArgs e)
        {

            DialogResult Resposta;
            Resposta = MessageBox.Show("Deseja excluir este item? \nSerá subtraido 1 na quantidade geral. \nCaso queira apenas retirar o patrimônio apenas edite este item.", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta.Equals(DialogResult.Yes))
            {
                DataTable resultado = new DataTable();


                dadosql = string.Format("SELECT `coditem` FROM `v_patrimonio` WHERE  `cod` = '{0}'", txt_PatriCod.Text);
                resultado = mConn.LeituraTabela(dadosql);
                int coditem = Convert.ToInt32(resultado.Rows[0]["coditem"].ToString());


                dadosql = string.Format("DELETE FROM `esto_patrimonio` WHERE `esto_patrimonio`.`cod` = '{0}'", txt_PatriCod.Text);
                mConn.Inserirdb(dadosql);


                dadosql = string.Format("SELECT count(cod) FROM `v_patrimonio` WHERE `codsaida` = '{0}' and `coditem` = '{1}'", txt_Cod.Text, lbl_CodItem.Text);
                resultado = mConn.LeituraTabela(dadosql);
                int qtd = Convert.ToInt32(resultado.Rows[0]["count(cod)"].ToString());


                dadosql = string.Format("UPDATE `esto_saida_item` SET `qtd` = '{0}' WHERE `codsaida` = '{1}' AND `coditem` = '{2}'", qtd, txt_Cod.Text, coditem);
                resultado = mConn.LeituraTabela(dadosql);


                PreencherDgv();

            }
        }

        private void cbx_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();

            dadosql = string.Format("SELECT `classe` FROM `estoque` WHERE `descricao` = '{0}'", cbx_Descricao.Text);
            resultado = mConn.LeituraTabela(dadosql);

            dadosql = string.Format("SELECT `patrimonio` FROM `esto_classe` WHERE `cod` = '{0}'", resultado.Rows[0]["classe"].ToString());
            resultado = mConn.LeituraTabela(dadosql);

            if (resultado.Rows[0]["patrimonio"].ToString() == "SIM")
            {
                chx_Patrimonio.Enabled = true;
                chx_Patrimonio.ForeColor = Color.White;
            }
            else
            {
                chx_Patrimonio.Enabled = false;
                chx_Patrimonio.ForeColor = Color.Gray;
            }


        }


        private void dgv_SaidaCompleto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_Descricao.Text = this.dgv_SaidaCompleto.CurrentRow.Cells[1].Value.ToString();
            lbl_CodItem.Text = this.dgv_SaidaCompleto.CurrentRow.Cells[0].Value.ToString();
        }

        private void lbl_DataEnvio_Click(object sender, EventArgs e)
        {
            //txt_DataEnvio.Text = DateTime.Now.ToShortDateString();

        }

        private void btn_ReqTransferencia_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            int contador = 0;


            dadosql = string.Format("SELECT COUNT(`req`) AS `QTD` FROM `esto_saida_item` WHERE `req` = '{0}'", cbx_req.Text);
            resultado = mConn.ConsultaTabela(dadosql);

            if (resultado.Rows[0]["QTD"].ToString() == "0")
            {

                dadosql = string.Format("SELECT `req` FROM `esto_saida_item` WHERE `codsaida` = '{0}' AND `req` <> 0", txt_Cod.Text);
                resultado = mConn.ConsultaTabela(dadosql);
                if (resultado.Rows.Count == 0)
                {


                    /////////////////////////////
                    ///

                    cbx_Contrato.Text = txt_contrato.Text;
                    dadosmssql = string.Format("select codccu from vetorh.dbo.r018ccu where nomccu = '{0}'", cbx_Contrato.Text);
                    resultado = msConn.ConsultaTabela(dadosmssql);
                    string codcontrato = resultado.Rows[0]["codccu"].ToString();

                    dadosql = string.Format("SELECT `coditem`, `descricao`, sum(`qtd_lib`) as `qtd` FROM `req_item` where `codreq` = '{0}' GROUP by `coditem`", cbx_req.Text);
                    resultado = mConn.LeituraTabela(dadosql);
                    while (contador < resultado.Rows.Count)
                    {
                        dadosql = string.Format("INSERT INTO `esto_saida_item` (`cod`, `codsaida`, `codcont`, `nomcont`, `coditem`, `qtd`, `req`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txt_Cod.Text, codcontrato, cbx_Contrato.Text, resultado.Rows[contador]["coditem"].ToString(), resultado.Rows[contador]["qtd"].ToString(), cbx_req.Text);
                        mConn.Inserirdb(dadosql);

                        contador++;
                    }
                    PreencherDgv();
                }
                else
                {
                    MessageBox.Show("Já existe a requisição " + resultado.Rows[0]["req"].ToString() + " inserida \nNão é permitido inserir mais de 1 requisição por controle de saida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            else
            {
                MessageBox.Show("Requisição ja foi inserida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void chx_Liberar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chx_Liberar_Click(object sender, EventArgs e)
        {
            if (chx_Liberar.Checked == true)
            {
                DialogResult Resposta;
                Resposta = MessageBox.Show("Deseja realmente liberar a saida de Nº:" + txt_Cod.Text + "? \nConfira todos os campos antes da liberação. \nApós conferencia apenas salve a saida com o campo \"Liberar\" marcado.", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resposta.Equals(DialogResult.Yes))
                {
                    DataTable resultado = new DataTable();
                    dadosql = string.Format("SELECT s.codsaida,e.`cod`,e.`descricao`,e.`estoqueatual`,s.qtd FROM `estoque` AS e INNER JOIN esto_saida_item AS s ON e.`cod` = s.coditem WHERE  e.estoqueatual < s.`qtd` AND s.`codsaida` = '{0}'", txt_Cod.Text);
                    resultado = mConn.LeituraTabela(dadosql);
                    if (resultado.Rows.Count != 0)
                    {
                        MessageBox.Show("Existem itens com estoque insuficiente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult Resposta1;
                        Resposta1 = MessageBox.Show("Deseja visualizar a listagem de itens?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resposta1.Equals(DialogResult.Yes))
                        {
                            CG.TelaInicial.ControleEstoque.Saida.frm_ControleSaida_SemEstoque semestoque = new TelaInicial.ControleEstoque.Saida.frm_ControleSaida_SemEstoque(resultado);
                            semestoque.ShowDialog();
                        }
                        chx_Liberar.Checked = false;
                    }
                    else
                    {
                        chx_Liberar.Checked = true;
                    }
                }
                else
                {
                    chx_Liberar.Checked = false;
                }
            }
        }

        private void tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(`codsaida`) FROM `esto_saida`");
            resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_Cod.Text))
            {

                txt_Cod.Text = resultado.Rows[0]["MIN(`codsaida`)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt32(txt_Cod.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(`codsaida`)"]))
            {
                dadosql = string.Format("SELECT * FROM `esto_saida` WHERE `codsaida` = '{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);

                Preencher(resultado);
                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = true;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM `esto_saida` WHERE `codsaida` < '{0}' ORDER BY `codsaida` DESC LIMIT 1", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);
                Preencher(resultado);
            }
        }

        private void tsm_proximo_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MAX(`codsaida`) FROM `esto_saida`");
            resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_Cod.Text))
            {

                txt_Cod.Text = resultado.Rows[0]["MAX(`codsaida`)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt32(txt_Cod.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MAX(`codsaida`)"]))
            {
                dadosql = string.Format("SELECT * FROM `esto_saida` WHERE `codsaida` = '{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);

                Preencher(resultado);
                tsm_proximo.Enabled = false;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM `esto_saida` WHERE `codsaida` > '{0}' ORDER BY `codsaida` ASC LIMIT 1", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);
                Preencher(resultado);
            }
        }

        private void tsm_pesquisar_Click(object sender, EventArgs e)
        {
            frm_ControleSaida_Pesquisa pesq = new frm_ControleSaida_Pesquisa(txt_usuario.Text);
            pesq.Show();
        }
    }
}
