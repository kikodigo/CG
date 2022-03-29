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
    public partial class frm_ReqCadastro : Form
    {

        public frm_ReqCadastro()
        {
            InitializeComponent();
        }

        public frm_ReqCadastro(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

        } 

        public frm_ReqCadastro(string usuario,string numreq)
        {

            InitializeComponent();
            txt_usuario.Text = usuario;
            txt_numreq.Text = numreq;

        }

        private string dadosmssql;
        Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        public void Bloquearbotao()
        {
            cbx_contrato.Enabled = false;
            cbx_motivo.Enabled = false;
            cbx_descricao.Enabled = false;
            cbx_funcionario.Enabled = false;
            txt_quantidade.Enabled = false;
            tsm_novo.Enabled = true;
            tsm_salvar.Enabled = false;
            tsm_editar.Enabled = true;
            tsm_anterior.Enabled = true;
            tsm_proximo.Enabled = true;
            tsm_excluir.Enabled = true;
            tsm_pesquisa.Enabled = true;
            tsm_cancelar.Enabled = false;
            btn_adicionar.Enabled = false;
            chx_liberar.Enabled = false;
            label1.ForeColor = Color.Gray;
            lbl_funcionario.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            lbl_qtd.ForeColor = Color.Gray;
            label5.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
            label7.ForeColor = Color.Gray;
            this.dgv_produtos.Enabled = false;

            if ((lbl_status.Text == "APROVADO") | (lbl_status.Text == "AGUARDANDO APROVAÇÃO"))
            {
                tsm_editar.Enabled = false;
                chx_liberar.Checked = true;

            }
            else
            {
                tsm_editar.Enabled = true;
                chx_liberar.Checked = false;
            }

            if(lbl_status.Text == "CANCELADO")
            {
                tsm_editar.Enabled = false;
                tsm_cancelar.Enabled = false;
                tsm_excluir.Enabled = false;

            }
        }

        public void Liberarbotao()
        {
            cbx_contrato.Enabled = true;
            cbx_motivo.Enabled = true;
            cbx_descricao.Enabled = true;
            cbx_funcionario.Enabled = true;
            txt_quantidade.Enabled = true;
            tsm_salvar.Enabled = true;
            tsm_novo.Enabled = false;
            tsm_editar.Enabled = false;
            tsm_anterior.Enabled = false;
            tsm_proximo.Enabled = false;
            tsm_pesquisa.Enabled = false;
            tsm_cancelar.Enabled = true;
            chx_liberar.Enabled = true;
            chx_liberar.Checked = false;
            label1.ForeColor = Color.White;
            lbl_funcionario.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            lbl_qtd.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            this.dgv_produtos.Enabled = true;
            chx_Fun_Sem_Cadastro.Enabled = true;
            chx_Fun_Sem_Cadastro.Checked = false;
        }

        public void Preencher(DataTable dados)
        {
           
            txt_numreq.Text = dados.Rows[0]["codreq"].ToString();
            txt_data.Text = Convert.ToDateTime(dados.Rows[0]["data"]).ToString("dd/MM/yyyy");
            cbx_contrato.Text = dados.Rows[0]["contrato"].ToString();
            lbl_status.Text = dados.Rows[0]["status"].ToString();

            if((lbl_status.Text == "APROVADO") | (lbl_status.Text == "AGUARDANDO APROVAÇÃO") | (lbl_status.Text == "CANCELADO"))
            {
                tsm_editar.Enabled = false;
                chx_liberar.Checked = true;
                
            }
            else
            {
                tsm_editar.Enabled = true;
                chx_liberar.Checked = false;
            }

            cbx_numreqtroca.Text = "";
            cbx_numreqtroca.Visible = false;

            txt_reqdatatroca.Text = "";
            txt_reqdatatroca.Visible = false;

            cbx_DescricaoTroca.Text = "";
            cbx_DescricaoTroca.Visible = false;

            cbx_numreqtroca.Visible = false;
            txt_reqdatatroca.Visible = false;

            lbl_datatroca.Visible = false;
            lbl_reqtroca.Visible = false;
            lbl_CodItemTroca.Visible = false;

            cbx_descricao.Text = "";
            cbx_motivo.Text = "";
            txt_quantidade.Text = "";

            lbl_coditem.Text = "";

        }
        public void Preencher_dgv()
        {

            dadosql = string.Format("SELECT `matr_func`,`func`,`qtd_item_func`,`soma_item_func`,`soma_item_func_lib` FROM `req_item_qtd_fun` WHERE `codreq` = {0}", txt_numreq.Text);
                dgv_funcionario.DataSource = mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT `descricao`,`qtd`,`motivo`,`qtd_lib` FROM `req_item`  WHERE `matr_func`= '{0}' and `codreq` = {1}", txt_matr.Text, txt_numreq.Text);
                dgv_produtos.DataSource = mConn.LeituraLinha(dadosql);
                
            txt_QtdTotal.Text = dgv_funcionario.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[Soma.Name].Value ?? 0)).ToString();
            txt_QtdTotalLib.Text = dgv_funcionario.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[soma_item_liberado.Name].Value ?? 0)).ToString();
        }

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
        
        private void Frm_req_Load(object sender, EventArgs e)
        {


            dadosmssql = string.Format("select nomccu from vetorh.dbo.r018ccu");
            cbx_contrato.DisplayMember = "nomccu";
            cbx_contrato.DataSource = msConn.ConsultaTabela(dadosmssql);
            cbx_contrato.Text = "";

            dadosmssql = string.Format("select titred from vetorh.dbo.r024car");
            cbx_CargoSemCadastro.DisplayMember = "titred";
            cbx_CargoSemCadastro.DataSource = msConn.ConsultaTabela(dadosmssql);
            cbx_CargoSemCadastro.Text = "";
                     


            //dadosql = string.Format("SELECT descricao FROM `estoque` WHERE `ativo` = 'SIM' ");
            //cbx_descricao.DisplayMember = "descricao";
            //cbx_descricao.DataSource = mConn.ConsultaTabela(dadosql);
            //cbx_descricao.Text = "";

            // dadosmssql = string.Format("select nomfun from vetorh.dbo.r034fun WHERE (r034fun.sitafa<>7 And r034fun.sitafa<>3 And r034fun.sitafa<>53)");

            Bloquearbotao();

            DataTable resultado = new DataTable();

            dadosql = string.Format("SELECT * FROM `requerimento`");
            resultado = mConn.LeituraTabela(dadosql);
            if (resultado.Rows.Count == 0)
            {
                
            }
            else
            {
                if (txt_numreq.Text == "")
                {
                                       
                    dadosql = string.Format("SELECT MAX(codreq) FROM requerimento");
                    resultado = mConn.LeituraLinha(dadosql);

                    string ultimo = resultado.Rows[0]["MAX(codreq)"].ToString();

                    dadosql = string.Format("SELECT * FROM `requerimento` WHERE codreq = {0}", Convert.ToInt32(ultimo));
                    resultado = mConn.LeituraLinha(dadosql);
                    Preencher(resultado);
                    Preencher_dgv();
                }
                else
                {

                    dadosql = string.Format("SELECT * FROM `requerimento` WHERE codreq = {0}", Convert.ToInt32(txt_numreq.Text));
                    resultado = mConn.LeituraLinha(dadosql);
                    Preencher(resultado);
                    Preencher_dgv();
                }
              

            }
            this.dgv_funcionario.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_produtos.DefaultCellStyle.ForeColor = Color.Black;
            
            lbl_coditem.Text = "";
        }

        private void Cbx_contrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_funcionario.Text = "";
            DataTable resultado = new DataTable();
            dadosmssql = string.Format("select codccu from vetorh.dbo.r018ccu where nomccu = '{0}'", cbx_contrato.Text);
            resultado = msConn.ConsultaTabela(dadosmssql);
            string codcontrato;

            codcontrato = resultado.Rows[0]["codccu"].ToString();
            dadosmssql = string.Format("select nomfun from vetorh.dbo.r034fun WHERE (sitafa<>7 And sitafa<>3 And sitafa<>53 And codccu = '{0}') order by nomfun asc", codcontrato);


            cbx_funcionario.DisplayMember = "nomfun";
            cbx_funcionario.DataSource = msConn.ConsultaTabela(dadosmssql);
        } 

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            cbx_contrato.Enabled = false;
            DataTable resultado = new DataTable();
            if ((cbx_descricao.Text == "") | (txt_quantidade.Text == "") | (cbx_motivo.Text == ""))
            {
                MessageBox.Show("Preencha todos os 3 campos a cima!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            else
            {

                if (btn_adicionar.Text == "Editar")  // IF direcionado apenas para editar os itens
                {
                    btn_adicionar.Text = "Adicionar";
                    btn_Cancelar_Edicao.Visible = false;
                    btn_ExcluirItem.Visible = false;


                    dadosql = string.Format("SELECT * FROM `req_item` WHERE `codreq` = '{0}' AND `coditem` = '{1}' AND `matr_func`= '{2}' ", txt_numreq.Text, lbl_coditem.Text, txt_matr.Text);

                    resultado = mConn.LeituraLinha(dadosql);  // IF vinculado as funções de troca
                    if (resultado.Rows.Count != 0 && resultado.Rows[0]["motivo"].ToString() == cbx_motivo.Text)
                    {

                        dadosql = string.Format("UPDATE `req_troca` SET `req_origem` = '{0}', `cod_item` = '{1}', `cod_item_origem` = '{2}' WHERE `req_nova` = '{3}' and `mtr_func` = '{4}' ",cbx_numreqtroca.Text, lbl_coditem.Text, lbl_CodItemTroca.Text, txt_numreq.Text, txt_matr.Text);
                        mConn.Inserirdb(dadosql);
                    }
                    else
                    {

                        if (cbx_motivo.Text == "TROCA")
                        {
                            dadosql = string.Format("INSERT INTO `req_troca` (`cod`, `req_origem`, `req_nova`, `mtr_func`, `cod_item`, `cod_item_origem`) VALUES (NULL,'{0}', '{1}', '{2}', '{3}' ,'{4}')", cbx_numreqtroca.Text, txt_numreq.Text, txt_matr.Text, lbl_coditem.Text, lbl_CodItemTroca.Text);
                            mConn.Inserirdb(dadosql);
                        }
                        else
                        {
                        
                        string item = resultado.Rows[0]["coditem"].ToString();
                        dadosql = string.Format("DELETE FROM `req_troca` WHERE `req_nova` = '{0}' and `mtr_func` = '{1}' and `cod_item` = '{2}'", Convert.ToInt32(txt_numreq.Text), txt_matr.Text, item);
                        mConn.Inserirdb(dadosql);
                        }

                    }
                                       
                    dadosql = string.Format("UPDATE `req_item` SET `coditem` = '{0}', `descricao` = '{1}', `qtd` = '{2}',`qtd_lib` = '{2}' , `motivo` = '{3}' WHERE `codreq` = {4} AND `descricao` = '{5}' AND `matr_func`={6}", lbl_coditem.Text, cbx_descricao.Text, txt_quantidade.Text, cbx_motivo.Text, txt_numreq.Text,this.dgv_produtos.CurrentRow.Cells[0].Value.ToString(),txt_matr.Text);
                    mConn.LeituraLinha(dadosql);
               }

                else // else caso não seja ETIDAR os campos
                {
                    
                    // Verificador de duplicidade de itens
                    dadosql = string.Format("SELECT * FROM `req_item` WHERE `codreq` = {0} AND `coditem` = {1} AND `matr_func`= {2}", Convert.ToInt32(txt_numreq.Text), Convert.ToInt32(lbl_coditem.Text), Convert.ToInt32(txt_matr.Text));
                    resultado = mConn.LeituraLinha(dadosql);

                    if (resultado.Rows.Count != 0)
                    {
                        MessageBox.Show("Item já inserido","Item duplicado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        
                    }
                    else // caso item não esteja em duplicidade -  inserção direta 
                    {


                        if(chx_Fun_Sem_Cadastro.Checked == true)
                        {
                            dadosql = string.Format("SELECT * FROM `req_item` WHERE `codreq` = {0} AND `matr_func`= {1}", Convert.ToInt32(txt_numreq.Text), Convert.ToInt32(txt_matr.Text));
                            resultado = mConn.LeituraLinha(dadosql);
                            if(resultado.Rows.Count != 0)
                            {
                                txt_matr.Text =  resultado.Rows[0]["matr_func"].ToString();
                            }
                            else
                            {
                                dadosql = string.Format("SELECT * FROM `req_item` ORDER BY `codreq` DESC");
                                resultado = mConn.LeituraLinha(dadosql);
                                txt_matr.Text = resultado.Rows[0]["cod"].ToString();
                            }

                                                                                 
                        }
                        

                            dadosql = string.Format("INSERT INTO `req_item` (`cod`, `codreq`, `matr_func`, `func`, `cargo`, `coditem`, `descricao`, `qtd`, `qtd_lib`, `motivo`) VALUES (NULL, {0}, {1}, '{2}', '{3}', {4}, '{5}','{6}','{6}','{7}')", txt_numreq.Text, txt_matr.Text, cbx_funcionario.Text, txt_cargo.Text, Convert.ToInt32(lbl_coditem.Text), cbx_descricao.Text, txt_quantidade.Text, cbx_motivo.Text);
                            mConn.Inserirdb(dadosql);


                        dadosql = string.Format("SELECT * FROM `req_func` WHERE `matr_func`= '{0}' and `codreq` = {1}",txt_matr.Text,txt_numreq.Text);
                        resultado = mConn.LeituraLinha(dadosql);
                       
                            if (resultado.Rows.Count == 0)
                            {
                                dadosql = string.Format("INSERT INTO `req_func` (`cod`, `codreq`, `matr_func`, `func`,`retorno_ficha`) VALUES (NULL, {0}, {1}, '{2}','0000-00-00')", txt_numreq.Text, txt_matr.Text,cbx_funcionario.Text);
                                mConn.Inserirdb(dadosql);
                            }

                            if(cbx_motivo.Text == "TROCA")
                            {

                            dadosql = string.Format("INSERT INTO `req_troca` (`cod`, `req_origem`, `req_nova`, `mtr_func`, `cod_item`, `cod_item_origem`) VALUES (NULL,'{0}', '{1}', '{2}', '{3}' ,'{4}')", cbx_numreqtroca.Text, txt_numreq.Text, txt_matr.Text, lbl_coditem.Text, lbl_CodItemTroca.Text);
                            mConn.Inserirdb(dadosql);
                            }
                    }
                }
            }
            Preencher_dgv();

            btn_visualizar.Enabled = true;

            cbx_numreqtroca.Text = "";
            cbx_numreqtroca.Visible = false;
            cbx_DescricaoTroca.Text = "";
            cbx_DescricaoTroca.Visible = false;
            cbx_numreqtroca.Visible = false;
            cbx_motivo.Text = "";
            cbx_descricao.Text = "";

            txt_reqdatatroca.Text = "";
            txt_reqdatatroca.Visible = false;
            txt_reqdatatroca.Visible = false;
            txt_quantidade.Text = "";            

            lbl_datatroca.Visible = false;
            lbl_reqtroca.Visible = false;
            lbl_CodItemTroca.Visible = false;         

        }

        private void Cbx_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cargo.Text = "";
            if (cbx_funcionario.Text != "")
            {
                string codcargo, codPosto;
                DataTable resultado = new DataTable();
                dadosmssql = string.Format("select * from vetorh.dbo.r034fun where nomfun = '{0}'", cbx_funcionario.Text);
                resultado = msConn.ConsultaTabela(dadosmssql);
                txt_matr.Text = resultado.Rows[0]["numcad"].ToString();
               
                    codcargo = resultado.Rows[0]["codcar"].ToString();
                    codPosto = resultado.Rows[0]["postra"].ToString();

                dadosmssql = string.Format("select * from vetorh.dbo.r024car WHERE codcar = '{0}'", codcargo);
                resultado = msConn.ConsultaTabela(dadosmssql);
                txt_cargo.Text = resultado.Rows[0]["titred"].ToString();




                dadosql = string.Format("SELECT Descrição FROM `v_esto_posto_por_item` WHERE `ativo` = 'SIM' AND `Codigo Posto` = '{0}'",codPosto);
                cbx_descricao.DisplayMember = "Descrição";
                cbx_descricao.DataSource = mConn.ConsultaTabela(dadosql);
                cbx_descricao.Text = "";



            }
            if(this.dgv_produtos.Enabled == true)
            {
                btn_adicionar.Enabled = true;
            }
          
        }
        
        private void Btn_visualizar_Click(object sender, EventArgs e)
        {
            CG.Tela_Inicial.Requisição.frm_ReqVisualizador destino = new CG.Tela_Inicial.Requisição.frm_ReqVisualizador(txt_numreq.Text);            
            destino.Show();
        }

        private void Dgv_funcionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_funcionario.Text = this.dgv_funcionario.CurrentRow.Cells[1].Value.ToString();
            txt_matr.Text = this.dgv_funcionario.CurrentRow.Cells[0].Value.ToString();
            dadosql = string.Format("SELECT `descricao`,`qtd`,`qtd_lib`,`motivo` FROM `req_item`  WHERE `matr_func`= '{0}' and `codreq` = {1}", txt_matr.Text, txt_numreq.Text);
            dgv_produtos.DataSource = mConn.LeituraLinha(dadosql);

        }

        private void Dgv_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_descricao.Text = this.dgv_produtos.CurrentRow.Cells[0].Value.ToString();
            txt_quantidade.Text = this.dgv_produtos.CurrentRow.Cells[1].Value.ToString();
            cbx_motivo.Text = this.dgv_produtos.CurrentRow.Cells[2].Value.ToString();
            btn_Cancelar_Edicao.Visible = true;
            btn_ExcluirItem.Visible = true;
            btn_adicionar.Text = "Editar";    

                if(cbx_motivo.Text == "TROCA")
                {
                    dadosql = string.Format(" SELECT `codreq` FROM `req_func` WHERE `matr_func` = '{0}'", txt_matr.Text);
                    cbx_numreqtroca.DisplayMember = "codreq";
                    cbx_numreqtroca.DataSource = mConn.ConsultaTabela(dadosql);

                    cbx_DescricaoTroca.Visible = true;
                    cbx_numreqtroca.Visible = true;
                    txt_reqdatatroca.Visible = true;

                    lbl_CodItemTroca.Visible = true;
                    lbl_reqtroca.Visible = true;
                    lbl_datatroca.Visible = true;

                    DataTable resultado = new DataTable();
                    dadosql = string.Format("SELECT * FROM `req_troca` WHERE `req_nova` = '{0}' AND `mtr_func` = '{1}'", txt_numreq.Text , txt_matr.Text);
                    resultado = mConn.ConsultaTabela(dadosql);

                    cbx_numreqtroca.Text  = resultado.Rows[0]["req_origem"].ToString();
                   string coditemorigem = resultado.Rows[0]["cod_item_origem"].ToString();


                    dadosql = string.Format("SELECT `data` FROM `requerimento` WHERE `codreq` = '{0}'", cbx_numreqtroca.Text);
                    resultado = mConn.LeituraLinha(dadosql);
                    txt_reqdatatroca.Text = resultado.Rows[0]["data"].ToString();

                    dadosql = string.Format("SELECT `descricao` FROM `req_item` WHERE `matr_func` = '{0}' and `codreq` = '{1}' ", txt_matr.Text, cbx_numreqtroca.Text);
                    //cbx_DescricaoTroca.DisplayMember = "descricao";
                    cbx_DescricaoTroca.DataSource = mConn.ConsultaTabela(dadosql);

                    dadosql = string.Format("SELECT `descricao` FROM `estoque` WHERE `cod` = '{0}'", coditemorigem);
                    resultado = mConn.LeituraLinha(dadosql);
                    cbx_DescricaoTroca.Text = resultado.Rows[0]["descricao"].ToString();


                }
        }

        private void Cbx_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {


            if(cbx_descricao.Text != "System.Data.DataRowView" | cbx_descricao.Text == "")
            {
                DataTable resultado = new DataTable();
                dadosql = string.Format("SELECT cod FROM `estoque` WHERE descricao = '{0}'", cbx_descricao.Text);
                resultado = mConn.ConsultaTabela(dadosql);

                lbl_coditem.Text = resultado.Rows[0]["cod"].ToString();
            }
            
           // MessageBox.Show(cbx_descricao.Text);
        }

        private void Btn_Cancelar_Edicao_Click(object sender, EventArgs e)
        {
            btn_adicionar.Text = "Adicionar";
            btn_Cancelar_Edicao.Visible = false;
            btn_ExcluirItem.Visible = false;
        }

        private void Btn_ExcluirItem_Click(object sender, EventArgs e)
        {
            btn_adicionar.Text = "Adicionar";
            btn_Cancelar_Edicao.Visible = false;
            btn_ExcluirItem.Visible = false;

                dadosql = string.Format("DELETE FROM `req_item` WHERE matr_func = {0} AND coditem = {1} and codreq = {2}",txt_matr.Text, lbl_coditem.Text, txt_numreq.Text);
            mConn.Inserirdb(dadosql);

            Preencher_dgv();
        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            DateTime dt = DateTime.Now;
            string str = dt.ToString("yyy-MM-dd");

            txt_data.Text = DateTime.Now.ToShortDateString();
            dadosql = string.Format("SELECT * FROM `requerimento`");
            resultado = mConn.LeituraLinha(dadosql);

            if (resultado.Rows.Count.ToString() == "0")
            {

                Liberarbotao();
                LimparTextBoxes(this.Controls);
                txt_numreq.Text = "1";


                dadosql = string.Format("INSERT INTO `requerimento` (`cod`, `codreq`, `data`, `contrato`, `data_aprov`, `status`, `obs`, `prev`, `data_envio`, `tipo_envio`, `retorno_ficha`) VALUES(NULL, '{0}','{1}', '', '0000-00-00', 'EM ANDAMENTO', '', '0000-00-00', '0000-00-00', '', '0')", txt_numreq.Text, Convert.ToDateTime(txt_data.Text).ToString("yyy-MM-dd"));
                mConn.Inserirdb(dadosql);
                mConn.log(txt_usuario.Text, this.AccessibilityObject.Name, MethodBase.GetCurrentMethod().Name, "CRIAÇÃO", "\"" + dadosql.Replace("'", "|") + "\"");
            }
            else
            {
                //declaração de variaveis
                //foi necessario 2 variaveis string para aceitas as conversões de string para int e de int para string
                string ultimo, ultimo1;
                int valor;

                //efetua a consulta no banco do maior codigo de regristro
                dadosql = string.Format("SELECT MAX(codreq) FROM requerimento");
                resultado = mConn.LeituraLinha(dadosql);
                ultimo = resultado.Rows[0]["MAX(codreq)"].ToString();

                //converte o codigo para int e soma 1 para o usuario verificar qual é o proximo registro
                valor = Convert.ToInt16(ultimo);
                valor++;
                ultimo1 = Convert.ToString(valor);


                dadosql = string.Format("INSERT INTO `requerimento` (`cod`, `codreq`, `data`, `contrato`, `data_aprov`, `status`, `obs`, `prev`, `data_envio`, `tipo_envio`, `retorno_ficha`) VALUES(NULL, '{0}','{1}', '', '0000-00-00', 'EM ANDAMENTO', '', '0000-00-00', '0000-00-00', '', '')", ultimo1, Convert.ToDateTime(txt_data.Text).ToString("yyy-MM-dd"));
                mConn.Inserirdb(dadosql);


                Liberarbotao();
                LimparTextBoxes(this.Controls);
                txt_numreq.Text = ultimo1;
                txt_data.Text = DateTime.Now.ToShortDateString();

                mConn.log(txt_usuario.Text, this.AccessibilityObject.Name, MethodBase.GetCurrentMethod().Name, "CRIAÇÃO", "\"" + dadosql.Replace("'", "|") + "\"");
            }

            Preencher_dgv();
            lbl_status.Text = "EM ANDAMENTO";
        }

        private void Tsm_editar_Click(object sender, EventArgs e)
        {
            chx_editar.Checked = true;
            if ((lbl_status.Text == "APROVADO") | (lbl_status.Text == "AGUARDANDO APROVAÇÃO"))
            {
                chx_liberar.Enabled = false;
                chx_liberar.Checked = true;

            }
            else
            {
                chx_liberar.Enabled = true;
                chx_liberar.Checked = false;
            }
            Liberarbotao();
            btn_adicionar.Enabled = true;
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            if (chx_liberar.Checked == true)
            {
                dadosql = string.Format("UPDATE `requerimento` SET `contrato` = '{0}', `status` = 'AGUARDANDO APROVAÇÃO' WHERE `requerimento`.`codreq` = {1}", cbx_contrato.Text, Convert.ToInt32(txt_numreq.Text));
                mConn.Inserirdb(dadosql);
            }
            else
            {
                dadosql = string.Format("UPDATE `requerimento` SET `contrato` = '{0}' WHERE `requerimento`.`codreq` = {1}", cbx_contrato.Text, Convert.ToInt32(txt_numreq.Text));
                mConn.Inserirdb(dadosql);
            }
            dadosql = string.Format("SELECT * FROM `requerimento` WHERE codreq = {0}", Convert.ToInt32(txt_numreq.Text));
            resultado = mConn.LeituraLinha(dadosql);

            Preencher(resultado);
            Preencher_dgv();
            Bloquearbotao();
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Cancelar realmente?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {

                if (chx_editar.Checked == false)
                {
                    // Uma breve verificação se o usuario esta editando algum item
                    if (btn_adicionar.Text == "Editar")
                    {
                        MessageBox.Show("Finalize a edição antes de cancelar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        DataTable resultado = new DataTable();
                        if (txt_numreq.Text != "")
                        {
                            dadosql = string.Format("DELETE FROM `requerimento` WHERE `codreq` = {0}", txt_numreq.Text);
                            mConn.Inserirdb(dadosql);

                            dadosql = string.Format("SELECT * FROM `req_item` WHERE `codreq` = {0}", txt_numreq.Text);
                            resultado = mConn.LeituraLinha(dadosql);
                            if (resultado.Rows.Count != 0)
                            {

                                dadosql = string.Format("DELETE FROM `req_item` WHERE `codreq` = {0}", txt_numreq.Text);
                                mConn.Inserirdb(dadosql);

                            }

                            dadosql = string.Format("SELECT * FROM `req_func` WHERE `codreq` = {0}", txt_numreq.Text);
                            resultado = mConn.LeituraLinha(dadosql);
                            if (resultado.Rows.Count != 0)
                            {

                                dadosql = string.Format("DELETE FROM `req_func` WHERE `codreq` = {0}", txt_numreq.Text);
                                mConn.Inserirdb(dadosql);

                            }

                            dadosql = string.Format("SELECT * FROM `req_troca` WHERE `req_nova` = {0}", txt_numreq.Text);
                            resultado = mConn.LeituraLinha(dadosql);
                            if (resultado.Rows.Count != 0)
                            {

                                dadosql = string.Format("DELETE FROM `req_troca` WHERE `req_nova` = {0}", txt_numreq.Text);
                                mConn.Inserirdb(dadosql);

                            }


                            dadosql = string.Format(" SELECT MAX(codreq) FROM requerimento");
                            resultado = mConn.LeituraLinha(dadosql);

                            string ultimo = resultado.Rows[0]["MAX(codreq)"].ToString();

                            dadosql = string.Format("SELECT * FROM `requerimento` WHERE codreq = {0}", Convert.ToInt32(ultimo));
                            resultado = mConn.LeituraLinha(dadosql);
                            Preencher(resultado);
                            Preencher_dgv();
                        }

                    }

                }
                chx_editar.Checked = false;
                Bloquearbotao();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(codreq) FROM requerimento");
            resultado = mConn.LeituraLinha(dadosql);
            if (string.IsNullOrWhiteSpace(txt_numreq.Text))
            {

                txt_numreq.Text = resultado.Rows[0]["MIN(codreq)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt16(txt_numreq.Text);
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(codreq)"]))
            {
                dadosql = string.Format("SELECT * FROM `requerimento` WHERE `codreq` ='{0}'", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);

                Preencher(resultado);
                Preencher_dgv();
                tsm_anterior.Enabled = false;
                tsm_proximo.Enabled = true;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM requerimento WHERE codreq < '{0}' ORDER BY cod DESC LIMIT 1", vlcodigo);
                resultado = mConn.LeituraLinha(dadosql);
                Preencher(resultado);
                Preencher_dgv();
            }
        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            // Verificação do ultimo registro do banco de dados
            dadosql = string.Format("SELECT MAX(codreq) FROM requerimento");
            DataTable resultado = new DataTable();
            resultado = mConn.LeituraLinha(dadosql);
            //-----

            //Verificação se o campo CODIGO esta vazio, caso esteja será preenchido com o ultimo valor do banco
            if (string.IsNullOrWhiteSpace(txt_numreq.Text))
            {
                txt_numreq.Text = resultado.Rows[0]["MAX(cod)"].ToString();
            }
            //-----

            // Criação de variavel para conversão de STRING para INT 
            int vlcodigo;
            vlcodigo = Convert.ToInt16(txt_numreq.Text);
            // -----

            if (vlcodigo.Equals(resultado.Rows[0]["MAX(codreq)"]))
            {

                dadosql = string.Format("SELECT * FROM `requerimento` WHERE `codreq` ='{0}'", vlcodigo);


                resultado = mConn.LeituraLinha(dadosql);
                Preencher(resultado);
                Preencher_dgv();
                tsm_proximo.Enabled = false;

            }
            else
            {
                tsm_anterior.Enabled = true;
                dadosql = string.Format("SELECT * FROM requerimento WHERE codreq > '{0}' ORDER BY cod LIMIT 1", vlcodigo);

                resultado = mConn.LeituraLinha(dadosql);
                Preencher(resultado);
                Preencher_dgv();
            }
        }

        private void Tsm_pesquisa_Click(object sender, EventArgs e)
        {
            this.Close();
            CG.Tela_Inicial.Requisição.frm_ReqPesquise destino = new CG.Tela_Inicial.Requisição.frm_ReqPesquise(txt_usuario.Text);
            destino.Show();
        }

        private void Tsm_excluir_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir a requisição ?  \nA exclusão de requisição não é reversivel \nNº "+ txt_numreq.Text + " - " + cbx_contrato.Text , "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                dadosql = string.Format("UPDATE `requerimento` SET `status` = 'CANCELADO' WHERE `codreq` = '{0}'", txt_numreq.Text);
                 mConn.Inserirdb(dadosql);

            }
            else if (dialogResult == DialogResult.No)
            {

            }
            Bloquearbotao();

            

        }

        private void Cbx_motivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable resultado = new DataTable();
            if (cbx_motivo.Text == "TROCA")
            {
                dadosql = string.Format(" SELECT `codreq` FROM `req_func` WHERE `matr_func` = '{0}'", txt_matr.Text);
                cbx_numreqtroca.DisplayMember = "codreq";
                cbx_numreqtroca.DataSource = mConn.ConsultaTabela(dadosql);

                cbx_DescricaoTroca.Visible = true;
                cbx_numreqtroca.Visible = true;
                txt_reqdatatroca.Visible = true;

                lbl_CodItemTroca.Visible = true;
                lbl_reqtroca.Visible = true;
                lbl_datatroca.Visible = true;

            }
            else
            {

                cbx_DescricaoTroca.Visible = false;
                cbx_numreqtroca.Visible = false;
                txt_reqdatatroca.Visible = false;

                lbl_CodItemTroca.Visible = false;
                lbl_reqtroca.Visible = false;
                lbl_datatroca.Visible = false;
            }

        }

        private void Cbx_numreqtroca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `data` FROM `requerimento` WHERE `codreq` = '{0}'", cbx_numreqtroca.Text);
            resultado = mConn.LeituraLinha(dadosql);
            txt_reqdatatroca.Text = Convert.ToDateTime(resultado.Rows[0]["data"]).ToString("dd/MM/yyyy");

            dadosql = string.Format("SELECT `descricao` FROM `req_item` WHERE `matr_func` = '{0}' and `codreq` = '{1}' ", txt_matr.Text ,cbx_numreqtroca.Text);
            cbx_DescricaoTroca.DisplayMember = "descricao";
            cbx_DescricaoTroca.DataSource = mConn.ConsultaTabela(dadosql);


        }      

        private void Lbl_reqtroca_DoubleClick(object sender, EventArgs e)
        {
            CG.Tela_Inicial.Requisição.frm_ReqVisualizador destino = new CG.Tela_Inicial.Requisição.frm_ReqVisualizador(cbx_numreqtroca.Text);
            destino.Show();
        }

        private void Cbx_DescricaoTroca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT cod FROM `estoque` WHERE descricao = '{0}'", cbx_DescricaoTroca.Text);
            resultado = mConn.ConsultaTabela(dadosql);
            lbl_CodItemTroca.Text = resultado.Rows[0]["cod"].ToString();
        }

        private void Chx_Fun_Sem_Cadastro_CheckedChanged(object sender, EventArgs e)
        {

            if(cbx_funcionario.Visible == false)
            {
                cbx_funcionario.Visible = true;
                cbx_CargoSemCadastro.Visible = false;
                cbx_descricao.DataSource = null;
                cbx_descricao.Text = "";

                txt_FuncSemCadastro.Visible = false;                
                txt_cargo.Visible = true;
                txt_matr.Text = "";

                lbl_funcionario.Text = "Funcionario";
                btn_adicionar.Enabled = false;                            
                
            }
            else
            {
                txt_FuncSemCadastro.Visible = true;
                txt_cargo.Visible = false;
                txt_matr.Text = "0";

                cbx_funcionario.Visible = false;
                cbx_CargoSemCadastro.Text = "";
                cbx_CargoSemCadastro.Visible = true;
                cbx_descricao.DataSource = null;

                lbl_funcionario.Text = "Funcionario não cadastrado";
                
                btn_adicionar.Enabled = true;              
                
                dadosql = string.Format("SELECT `descricao` FROM `estoque` WHERE `ativo` = 'SIM'");
                cbx_descricao.DisplayMember = "descricao";
                cbx_descricao.DataSource = mConn.ConsultaTabela(dadosql);
                cbx_descricao.Text = "";

            }

           
        }

        private void Txt_FuncSemCadastro_TextChanged(object sender, EventArgs e)
        {
            cbx_funcionario.Text = txt_FuncSemCadastro.Text;
        }

        private void Cbx_CargoSemCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cargo.Text = cbx_CargoSemCadastro.Text;
        }
        private void Btn_duplicar_Click(object sender, EventArgs e)
        {

        }
    }
}
