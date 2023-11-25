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
using System.Xml.Serialization;
using System.IO;
using System.Xml;


namespace CG.Tela_Inicial.Controle_Estoque.Saida
{
    public partial class frm_ControleEntrada : Form
    {
        public frm_ControleEntrada()
        {
            InitializeComponent();
        }
        public frm_ControleEntrada(DataTable tabela, string usuario,string codforne,string dataemi, string nNota)
        {
            InitializeComponent();

            
            DataTable resultado = new DataTable();
            string cod, qtd, vlu, vlt;
            int contador = 0;
            txt_DataEmissao.Text = dataemi;
            txt_Nnota.Text = nNota;
                        
            Novo();
            dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` = '{0}'", codforne);
            //resultado = mConn.LeituraTabela(dadosql);
            mtb_cnpj.Text = resultado.Rows[0]["doc"].ToString();
            lbl_codfor.Text = resultado.Rows[0]["cod"].ToString();

            while (contador < tabela.Rows.Count)
            {
                dadosql = string.Format("");
                cod = tabela.Rows[contador]["Cod Interno"].ToString();
                qtd = tabela.Rows[contador]["Qtd"].ToString();
                vlu = tabela.Rows[contador]["Valor Un"].ToString();
                vlt = tabela.Rows[contador]["Valor Total"].ToString();



                dadosql = string.Format("SELECT * FROM `esto_entrada_item` WHERE `coddesc` = '{0}' AND `codentr` = '{1}'", cod, txt_CodEntrada.Text);
                //resultado = mConn.LeituraTabela(dadosql);
                if (resultado.Rows.Count == 0)
                {
                    dadosql = string.Format("INSERT INTO `esto_entrada_item` (`cod`, `codentr`, `coddesc`, `qtd`, `prunit`, `prtotal`) VALUES(NULL, '{0}', '{1}', '{2}', '{3}', '{4}')", txt_CodEntrada.Text, cod, qtd.Replace(",","").Replace("0",""), vlu.Replace("R$", "").Replace(",", "."), vlt.Replace("R$", "").Replace(",", "."));
                    //mConn.Inserirdb(dadosql);



                }
                else
                {
                    MessageBox.Show("Item já inserido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                contador++;
            }
            

        

            dadosql = string.Format("UPDATE `esto_entrada` SET `vltotal` = (SELECT SUM(`prtotal`) FROM `esto_entrada_item` WHERE `codentr` = '{0}') WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
            //mConn.Inserirdb(dadosql);

            dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
            //resultado =  mConn.ConsultaTabela(dadosql);

            dadosql = string.Format("UPDATE `esto_entrada` SET `datemi` = '{0}', `codfor` = '{1}', `nnota` = '{2}', `vltotal` = '{3}', `status` = '{4}' WHERE `codentr` = {5}", Convert.ToDateTime(txt_DataEmissao.Text).ToString("yyyy-MM-dd"), codforne, txt_Nnota.Text, resultado.Rows[0]["vltotal"].ToString().Replace("R$", "").Replace(".", "").Replace(",", "."), txt_Status.Text, txt_CodEntrada.Text);
            //mConn.Inserirdb(dadosql);



            dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
            //resultado = mConn.LeituraTabela(dadosql);
            preencher(resultado);

           
            txt_usuario.Text = usuario;        
          

        }
        public frm_ControleEntrada(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }

        private string dadosmssql;
        //Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        //Classes.dbconect mConn = new Classes.dbconect();

        private void Liberarbotao()
        {

            //----  TSM
            tsm_salvar.Enabled = true;
            tsm_novo.Enabled = false;
            tsm_editar.Enabled = false;
            tsm_anterior.Enabled = false;
            tsm_proximo.Enabled = false;
            tsm_excluir.Enabled = false;
            tsm_pesquisar.Enabled = false;
            tsm_cancelar.Enabled = true;




            //---- LBL
            lbl_CodEntrada.ForeColor = Color.White;
            lbl_DataEntrada.ForeColor = Color.White;
            lbl_DataEmissao.ForeColor = Color.White;
            lbl_Fornecedor.ForeColor = Color.White;
            lbl_Cnpj.ForeColor = Color.White;
            lbl_NNota.ForeColor = Color.White;
            lbl_Descricao.ForeColor = Color.White;
            lbl_Qtd.ForeColor = Color.White;
            lbl_PrUnitario.ForeColor = Color.White;
            lbl_PrTotal.ForeColor = Color.White;
            lbl_VlTotalCompra.ForeColor = Color.White;

            //---- txt | CBX
            txt_Qtd.Enabled = true;
            txt_PrUnit.Enabled = true;
            cbx_Descricao.Enabled = true;
            txt_DataEmissao.Enabled = true;
            cbx_Fornecedor.Enabled = true;
            if (txt_Status.Text == "EM ANDAMENTO")
            {
                chx_Liberar.Enabled = true;
            }
            else
            {
                chx_Liberar.Enabled = false;
            }


            //--- BTN 
            btn_Adicionar.Enabled = true;
            btn_Excluir.Enabled = true;
        }
        private void Bloquearbotao()
        {
            //----  TSM
            tsm_salvar.Enabled = false;
            tsm_novo.Enabled = true;
            tsm_editar.Enabled = true;
            tsm_anterior.Enabled = true;
            tsm_proximo.Enabled = true;
            tsm_excluir.Enabled = true;
            tsm_pesquisar.Enabled = true;
            tsm_cancelar.Enabled = false;




            //---- LBL
            lbl_CodEntrada.ForeColor = Color.Gray;
            lbl_DataEntrada.ForeColor = Color.Gray;
            lbl_DataEmissao.ForeColor = Color.Gray;
            lbl_Fornecedor.ForeColor = Color.Gray;
            lbl_Cnpj.ForeColor = Color.Gray;
            lbl_NNota.ForeColor = Color.Gray;
            lbl_Descricao.ForeColor = Color.Gray;
            lbl_Qtd.ForeColor = Color.Gray;
            lbl_PrUnitario.ForeColor = Color.Gray;
            lbl_PrTotal.ForeColor = Color.Gray;
            lbl_VlTotalCompra.ForeColor = Color.Gray;

            //---- txt | CBX | CHX
            txt_Qtd.Enabled = false;
            txt_PrUnit.Enabled = false;
            txt_DataEmissao.Enabled = false;

            cbx_Descricao.Enabled = false;
            cbx_Fornecedor.Enabled = false;

            chx_editar.Checked = false;
            chx_Liberar.Enabled = false;


            //--- BTN 
            btn_Adicionar.Enabled = false;
            btn_Excluir.Enabled = false;

        }
        private void Limpeza()
        {
            txt_CodEntrada.Text = "";
            txt_DataEntrada.Text = "";
            txt_DataEmissao.Text = "";
            txt_Fornecedor.Text = "";
            txt_Nnota.Text = "";
            txt_Qtd.Text = "";
            txt_PrUnit.Text = "";
            txt_PrTotal.Text = "";
            txt_VlTotalNota.Text = "";

            cbx_Fornecedor.Text = "";
            cbx_Descricao.Text = "";
            cbx_Descricao.Text = "";

            mtb_cnpj.Text = "";


        }
        private void preencher(DataTable dados)
        {
            txt_CodEntrada.Text = dados.Rows[0]["codentr"].ToString();

            if (dados.Rows[0]["datent"].ToString() != "01/01/0001 00:00:00")
                txt_DataEntrada.Text = Convert.ToDateTime(dados.Rows[0]["datent"].ToString()).ToString("dd/MM/yyyy");

            if (dados.Rows[0]["datemi"].ToString() != "01/01/0001 00:00:00")
                txt_DataEmissao.Text = Convert.ToDateTime(dados.Rows[0]["datemi"].ToString()).ToString("dd/MM/yyyy");

            txt_Nnota.Text = dados.Rows[0]["nnota"].ToString();
            txt_VlTotalNota.Text = Convert.ToDouble(dados.Rows[0]["vltotal"].ToString()).ToString("C");
            txt_Status.Text = dados.Rows[0]["status"].ToString();

            if (dados.Rows[0]["status"].ToString() == "EM ANDAMENTO")
            {
                chx_Liberar.Enabled = true;
                chx_Liberar.Checked = false;
            }
            else
            {
                chx_Liberar.Enabled = false;
                if (dados.Rows[0]["status"].ToString() == "LIBERADO")
                {
                    chx_Liberar.Checked = true;
                }
            }

            lbl_codfor.Text = dados.Rows[0]["codfor"].ToString();

            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `nome`,`doc` FROM `fornecedor` WHERE `cod` = '{0}'", dados.Rows[0]["codfor"].ToString());
            //resultado = mConn.LeituraLinha(dadosql);
            if (resultado.Rows.Count != 0)
            {
                cbx_Fornecedor.Text = resultado.Rows[0]["nome"].ToString();
                mtb_cnpj.Text = resultado.Rows[0]["doc"].ToString();
            }
            PreencherDgv();

        }
        private void PreencherDgv()
        {
            DataGridViewCellStyle dgvstyle = new DataGridViewCellStyle();

            dadosql = string.Format("SELECT i.`cod` as `Codigo`,i.`coddesc` as `Cod.Produto`,e.descricao as `Descrição`,i.`qtd` as `Quantidade`,CONCAT('R$ ', REPLACE(REPLACE(REPLACE(FORMAT(i.`prunit`, 2),'.',';'),',','.'),';',',')) as `Pr.Unitário`,  CONCAT('R$ ', REPLACE(REPLACE(REPLACE(FORMAT(i.`prtotal`, 2),'.',';'),',','.'),';',',')) as `Pr.Total` FROM `esto_entrada_item` as i INNER JOIN estoque as e on i.`coddesc` = e.cod WHERE i.`codentr` = '{0}'", txt_CodEntrada.Text);

            //dgv_TabelaItens.DataSource = mConn.LeituraTabela(dadosql);
            this.dgv_TabelaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


        }

        private void frm_ControleEntrada_Load(object sender, EventArgs e)
        {            
            if(txt_CodEntrada.Text == "")
            {               
                dadosql = string.Format("SELECT `descricao` FROM `estoque` where `ativo` = 'SIM' ORDER BY `descricao` ASC ");
                cbx_Descricao.DisplayMember = "descricao";
                //cbx_Descricao.DataSource = mConn.ConsultaTabela(dadosql);
                cbx_Descricao.Text = "";

                dadosql = string.Format("SELECT `nome` FROM `fornecedor`");
                cbx_Fornecedor.DisplayMember = "nome";
                //cbx_Fornecedor.DataSource = mConn.ConsultaTabela(dadosql);
                cbx_Fornecedor.Text = "";
                mtb_cnpj.Text = null;

                DataTable resultado = new DataTable();
                dadosql = string.Format("SELECT * FROM `esto_entrada` where `codentr` = (SELECT MAX(`codentr`) from `esto_entrada`)");
                //resultado = mConn.LeituraTabela(dadosql);
                if (dgv_TabelaItens.Rows.Count == 0)
                {
                    preencher(resultado);

                }
                Bloquearbotao();
            }
            else
            {
                Liberarbotao();
            }
        }
      
        private void txt_Qtd_TextChanged(object sender, EventArgs e)
        {
            if (txt_Qtd.Text == "" || txt_PrUnit.Text == "")
            {
                txt_PrTotal.Text = "";
            }
            else
            {
                Double vrtotal = Convert.ToDouble(txt_PrUnit.Text.Replace(".", ",").Replace("R$", "")) * Convert.ToDouble(txt_Qtd.Text.Replace(".", ","));
                txt_PrTotal.Text = vrtotal.ToString("C");
            }
        }
        private void txt_PrUnit_Leave(object sender, EventArgs e)
        {
            if (txt_PrUnit.Text != "")
            {
                Double valor = Convert.ToDouble(txt_PrUnit.Text.Replace(".", ",").Replace("R$", ""));
                txt_PrUnit.Text = valor.ToString("C");
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            txt_DataEntrada.Text = DateTime.Today.ToShortDateString();

        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            Limpeza();
            Novo();
            Liberarbotao();
            
        }
        private void Novo()
        {

            DataTable resultado = new DataTable();
            txt_DataEntrada.Text = DateTime.Today.ToShortDateString();
            dadosql = string.Format("SELECT * FROM `esto_entrada`");
            //resultado = mConn.LeituraTabela(dadosql);
            if (resultado.Rows.Count == 0)
            {
                dadosql = string.Format("INSERT INTO `esto_entrada` (`cod`, `codentr`, `datent`, `datemi`, `codfor`, `nnota`, `vltotal`, `status`) VALUES (NULL, '1', '{0}', '0000-00-00', '', '', '0','EM ANDAMENTO')", Convert.ToDateTime(txt_DataEntrada.Text).ToString("yyyy-MM-dd"));
                //mConn.Inserirdb(dadosql);

                dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '1'");
                //resultado = mConn.LeituraTabela(dadosql);
                preencher(resultado);
                dgv_TabelaItens.DataSource = null;
            }
            else
            {
                dadosql = string.Format("SELECT MAX(`codentr`) as 'ultimo' FROM `esto_entrada`");
                //resultado = mConn.LeituraTabela(dadosql);

                int cod = Convert.ToInt32(resultado.Rows[0]["ultimo"].ToString());
                cod++;
                dadosql = string.Format("INSERT INTO `esto_entrada` (`cod`, `codentr`, `datent`, `datemi`, `codfor`, `nnota`, `vltotal`, `status`) VALUES (NULL, '{0}', '{1}', '0000-00-00', '', '', '0','EM ANDAMENTO')", cod, Convert.ToDateTime(txt_DataEntrada.Text).ToString("yyyy-MM-dd"));
                //mConn.Inserirdb(dadosql);
                dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", cod);
                //resultado = mConn.LeituraTabela(dadosql);
                preencher(resultado);
                dgv_TabelaItens.DataSource = null;
            }
        }
        private void tsm_editar_Click(object sender, EventArgs e)
        {
            Liberarbotao();
            chx_editar.Checked = true;
        }

        private void tsm_salvar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `cod` FROM `fornecedor` WHERE `doc` = '{0}'", mtb_cnpj.Text);
            //resultado = mConn.LeituraLinha(dadosql);
            if (resultado.Rows.Count != 0)
            {
                lbl_codfor.Text = resultado.Rows[0]["cod"].ToString();

            }


            if (mtb_cnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim() != "")
            {
                dadosql = string.Format("UPDATE `esto_entrada` SET `datemi` = '{0}', `codfor` = '{1}', `nnota` = '{2}', `vltotal` = '{3}', `status` = '{4}' WHERE `codentr` = {5}", Convert.ToDateTime(txt_DataEmissao.Text).ToString("yyyy-MM-dd"), lbl_codfor.Text, txt_Nnota.Text, txt_VlTotalNota.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), txt_Status.Text, txt_CodEntrada.Text);
                //mConn.Inserirdb(dadosql);


                if (chx_Liberar.Checked == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja liberar os itens abaixo no estoque?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dadosql = string.Format("SELECT i.`codentr`,i.`coddesc`,i.`qtd`,e.`descricao`,e.`estoqueatual` FROM `esto_entrada_item` as i INNER JOIN `estoque` as e on i.`coddesc` = e.`cod` WHERE i.`codentr` = '{0}'", txt_CodEntrada.Text);

                        //resultado = mConn.LeituraTabela(dadosql);
                        int contador = 0;
                        while (contador < resultado.Rows.Count)
                        {
                            dadosql = string.Format("UPDATE `estoque` SET `estoqueatual` = `estoqueatual` + {0} WHERE `estoque`.`cod` = '{1}'", resultado.Rows[contador]["qtd"].ToString(), resultado.Rows[contador]["coddesc"].ToString());

                            //mConn.Inserirdb(dadosql);

                            contador++;
                        }
                        dadosql = string.Format("UPDATE `esto_entrada` SET `status` = 'LIBERADO' WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
                        //mConn.Inserirdb(dadosql);

                        dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
                        // resultado = mConn.LeituraTabela(dadosql);
                        preencher(resultado);

                    }
                }
                Bloquearbotao();

            }
            else
            {
                MessageBox.Show("Não é possivel salvar entrada de mercadoria sem fornecedor selecionado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void tsm_cancelar_Click(object sender, EventArgs e)
        {
            if (chx_editar.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("Deseja realmente cancelar esta Entrada? \nTudo que ja foi preenchido será perdido!", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    //Exclui o cabeçalho da entrada.
                    dadosql = string.Format("DELETE FROM `esto_entrada` WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
                    //mConn.Inserirdb(dadosql);

                    //Exclui os itens da entrada.
                    dadosql = string.Format("DELETE FROM `esto_entrada_item` WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
                    //mConn.Inserirdb(dadosql);

                    //Carrega o ultimo registro 
                    DataTable resultado = new DataTable();
                    dadosql = string.Format("SELECT * FROM `esto_entrada` where `codentr` = (SELECT MAX(`codentr`) from `esto_entrada`)");
                    //resultado = mConn.LeituraTabela(dadosql);


                    Bloquearbotao();
                    preencher(resultado);
                }
            }
            else
            {
                Bloquearbotao();
            }
        }

        private void lbl_Cnpj_Click(object sender, EventArgs e)
        {
            //DataTable resultado = new DataTable();
            //dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `doc` = '{0}'",mtb_cnpj.Text);
            //resultado = mConn.LeituraTabela(dadosql);
            //MessageBox.Show(resultado.Rows[0]["nome"].ToString());

            if (mtb_cnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim() == "")
            {
                MessageBox.Show("TA EM BRANCO");
                MessageBox.Show(mtb_cnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim());
            }
            else
            {
                MessageBox.Show("não ta branco");
                MessageBox.Show(mtb_cnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim());

            }

        }
        private void cbx_Fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `cod`,`doc` FROM `fornecedor` WHERE `nome` = '{0}'", cbx_Fornecedor.Text);
            //resultado = mConn.LeituraTabela(dadosql);
            mtb_cnpj.Text = resultado.Rows[0]["doc"].ToString();
            lbl_codfor.Text = resultado.Rows[0]["cod"].ToString();
        }



        private void btn_Adicionar_Click(object sender, EventArgs e)
        {

            if (mtb_cnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim() != "")
            {

                if (cbx_Descricao.Text == "" || txt_Qtd.Text == "" || txt_PrUnit.Text == "")
                {
                    MessageBox.Show("Por favor, os campos Descrição, Quantidade e Preço Unitário não podem estar em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataTable resultado = new DataTable();
                    dadosql = string.Format("SELECT `cod` FROM `estoque` WHERE `descricao` = '{0}'", cbx_Descricao.Text);
                    //resultado = mConn.LeituraTabela(dadosql);
                    int coddesc = Convert.ToInt32(resultado.Rows[0]["cod"].ToString());


                    dadosql = string.Format("SELECT * FROM `esto_entrada_item` WHERE `coddesc` = '{0}' AND `codentr` = '{1}'", coddesc, txt_CodEntrada.Text);
                    //resultado = mConn.LeituraTabela(dadosql);
                    if (resultado.Rows.Count == 0)
                    {
                        dadosql = string.Format("INSERT INTO `esto_entrada_item` (`cod`, `codentr`, `coddesc`, `qtd`, `prunit`, `prtotal`) VALUES(NULL, '{0}', '{1}', '{2}', '{3}', '{4}')", txt_CodEntrada.Text, coddesc, txt_Qtd.Text, txt_PrUnit.Text.Replace("R$", "").Replace(",", "."), txt_PrTotal.Text.Replace("R$", "").Replace(",", "."));
                        //mConn.Inserirdb(dadosql);

                        dadosql = string.Format("UPDATE `esto_entrada` SET `vltotal` = (SELECT SUM(`prtotal`) FROM `esto_entrada_item` WHERE `codentr` = '{0}') WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
                        //mConn.Inserirdb(dadosql);

                        dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
                        //resultado = mConn.LeituraTabela(dadosql);


                        txt_Qtd.Text = "";
                        txt_PrUnit.Text = "";
                        cbx_Descricao.Text = "";
                        preencher(resultado);
                    }
                    else
                    {
                        MessageBox.Show("Item já inserido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é possivel adicionar item sem fornecedor selecionado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgv_TabelaItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_CodTabela.Text = dgv_TabelaItens.CurrentRow.Cells[0].Value.ToString();
            cbx_Descricao.Text = dgv_TabelaItens.CurrentRow.Cells[2].Value.ToString();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();

            dadosql = string.Format("DELETE FROM `esto_entrada_item` WHERE `cod` = '{0}' ", lbl_CodTabela.Text);
            //mConn.Inserirdb(dadosql);

            dadosql = string.Format("UPDATE `esto_entrada` SET `vltotal` = (SELECT SUM(`prtotal`) FROM `esto_entrada_item` WHERE `codentr` = '{0}') WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
            //mConn.Inserirdb(dadosql);

            dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", txt_CodEntrada.Text);
            //resultado = mConn.LeituraTabela(dadosql);

            preencher(resultado);
        }



        private void tsm_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MIN(`codentr`) FROM `esto_entrada`");
            //resultado = mConn.LeituraLinha(dadosql);
            tsm_proximo.Enabled = true;
            if (string.IsNullOrWhiteSpace(txt_CodEntrada.Text))
            {
                txt_CodEntrada.Text = resultado.Rows[0]["MIN(`codentr`)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt32(txt_CodEntrada.Text);
            Limpeza();
            if (vlcodigo.Equals(resultado.Rows[0]["MIN(`codentr`)"]))
            {
                dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);

                preencher(resultado);
                tsm_anterior.Enabled = false;
            }
            else
            {
                tsm_anterior.Enabled = true;

                dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` < '{0}' ORDER BY `codentr` DESC LIMIT 1", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
        }

        private void tsm_proximo_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT MAX(`codentr`) FROM `esto_entrada`");
            //resultado = mConn.LeituraLinha(dadosql);
            tsm_anterior.Enabled = true;

            if (string.IsNullOrWhiteSpace(txt_CodEntrada.Text))
            {

                txt_CodEntrada.Text = resultado.Rows[0]["MAX(`codentr`)"].ToString();
            }
            int vlcodigo;

            vlcodigo = Convert.ToInt32(txt_CodEntrada.Text);
            Limpeza();
            if (vlcodigo.Equals(resultado.Rows[0]["MAX(`codentr`)"]))
            {
                dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` = '{0}'", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);

                preencher(resultado);
                tsm_proximo.Enabled = false;
            }
            else
            {
                tsm_proximo.Enabled = true;

                dadosql = string.Format("SELECT * FROM `esto_entrada` WHERE `codentr` > '{0}' ORDER BY `codentr` ASC LIMIT 1", vlcodigo);
                //resultado = mConn.LeituraLinha(dadosql);
                preencher(resultado);
            }
        }

        private void Dgv_TabelaItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cbx_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_PrUnit_TextChanged(object sender, EventArgs e)
        {
            if (txt_Qtd.Text == "" || txt_PrUnit.Text == "")
            {
                txt_PrTotal.Text = "";
            }
            else
            {
                Double vrtotal = Convert.ToDouble(txt_PrUnit.Text.Replace(".", ",").Replace("R$", "")) * Convert.ToDouble(txt_Qtd.Text.Replace(".", ","));
                txt_PrTotal.Text = vrtotal.ToString("C");
            }
        }
    }
}
