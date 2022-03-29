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
    public partial class frm_OCMMCadastro : Form
    {
        public frm_OCMMCadastro()
        {
            InitializeComponent();
        }
        private string dadosmssql;
        Classes.mssqlconect msConn = new Classes.mssqlconect();

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();
        public void bloquearbotao()
        {
            

            txt_limitecompra.Enabled = false;
            txt_endereco.Enabled = false;
            txt_contato.Enabled = false;
            txt_tel.Enabled = false;
            txt_contato.Enabled = false;
            txt_PrevEntrega.Enabled = false;
            txt_MotCompra.Enabled = false;
            txt_Unidade.Enabled = false;
            txt_Quantidade.Enabled = false;
            txt_VlCusto.Enabled = false;
            txt_VlTotalItem.Enabled = false;
            txt_condicao.Enabled = false;
            txt_VlTotalOc.Enabled = false;

            cbx_Contrato.Enabled = false;
            cbx_Fornecedor.Enabled = false;            
            cbx_Descricao.Enabled = false;            

            tsm_novo.Enabled = true;
            tsm_salvar.Enabled = false;
            tsm_editar.Enabled = true;
            tsm_pesquisar.Enabled = true;
            tsm_cancelar.Enabled = false;
            tsm_excluir.Enabled = true;

            chx_editar.Checked = false;

            label1.ForeColor = Color.Gray;
            label2.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label5.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
            label7.ForeColor = Color.Gray;
            label8.ForeColor = Color.Gray;
            label9.ForeColor = Color.Gray;
            label10.ForeColor = Color.Gray;            
            label13.ForeColor = Color.Gray;
            label14.ForeColor = Color.Gray;
            label15.ForeColor = Color.Gray;
            label16.ForeColor = Color.Gray;
            label17.ForeColor = Color.Gray;
            label18.ForeColor = Color.Gray;
            label19.ForeColor = Color.Gray;
        }
        public void liberarbotao()
        {

            txt_limitecompra.Enabled = true;
            txt_endereco.Enabled = true;
            txt_contato.Enabled = true;
            txt_tel.Enabled = true;
            txt_contato.Enabled = true;
            txt_PrevEntrega.Enabled = true;
            txt_MotCompra.Enabled = true;
            txt_Unidade.Enabled = true;
            txt_Quantidade.Enabled = true;
            txt_VlCusto.Enabled = true;
            txt_VlTotalItem.Enabled = true;
            txt_condicao.Enabled = true;
            txt_VlTotalOc.Enabled = true;

            cbx_Contrato.Enabled = true;            
            cbx_Fornecedor.Enabled = true;            
            cbx_Descricao.Enabled = true;           

            tsm_novo.Enabled = false;
            tsm_salvar.Enabled = true;
            tsm_editar.Enabled = false;
            tsm_pesquisar.Enabled = false;
            tsm_cancelar.Enabled = true;
            tsm_excluir.Enabled = false;

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
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
        }
        public void Preencher(DataTable dados)
        {

            txt_Data.Text = dados.Rows[0]["estado"].ToString();
            txt_limitecompra.Text = dados.Rows[0]["bairro"].ToString();
            txt_endereco.Text = dados.Rows[0]["rua"].ToString();
            txt_contato.Text = dados.Rows[0]["cep"].ToString();
            txt_tel.Text = dados.Rows[0]["contato"].ToString();
            txt_PrevEntrega.Text = dados.Rows[0]["tel1"].ToString();
            txt_MotCompra.Text = dados.Rows[0]["tel2"].ToString();
            txt_condicao.Text = dados.Rows[0]["prlimite"].ToString();

            cbx_Contrato.Text = dados.Rows[0]["cidade"].ToString();            
            cbx_Fornecedor.Text = dados.Rows[0]["num"].ToString();
            
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

        private void Frm_OCMMCadastro_Load(object sender, EventArgs e)
        {
            
            dadosql = string.Format("SELECT * FROM `contrato`");
            cbx_Contrato.DisplayMember = "nome_contrato";
            cbx_Contrato.DataSource = mConn.LeituraLinha(dadosql);
            cbx_Contrato.Text = "";
            lbl_CodContrato.Text = "";


            dadosql = string.Format("SELECT descricao FROM `estoque` WHERE `ativo` = \"SIM\" ");
            cbx_Descricao.DisplayMember = "descricao";
            cbx_Descricao.DataSource = mConn.ConsultaTabela(dadosql);
            cbx_Descricao.Text = "";


            dadosql = string.Format(" SELECT `nome` FROM `fornecedor` WHERE `ativo` = \"SIM\" ");
            cbx_Fornecedor.DisplayMember = "nome";
            cbx_Fornecedor.DataSource = mConn.ConsultaTabela(dadosql);
            cbx_Fornecedor.Text = "";
            bloquearbotao();
        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            liberarbotao();

            DataTable resultado = new DataTable();
            txt_Data.Text = DateTime.Now.ToShortDateString();
            dadosql = string.Format("SELECT * FROM `ocmm`");
            resultado = mConn.LeituraLinha(dadosql);

            if(resultado.Rows.Count.ToString() == "0")
            {
                txt_NumOc.Text = "1";
                dadosql = string.Format("INSERT INTO `ocmm` (`cod`, `codmm`, `data`, `contrato`, `fornecedor`, `prev_entrega`, `motivo`, `condicao`, `vl_total`) VALUES(NULL, '{0}', '{1}', '', '', '', '', '', 0)",txt_NumOc.Text ,txt_Data.Text);
                mConn.Inserirdb(dadosql);
            }
            else
            {
                MessageBox.Show("Deu 0 não em lek lek");
            }
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja cancelar realmente?", "Limpeza", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {

                if (chx_editar.Checked == false)
                {                    
                    dadosql = string.Format("DELETE FROM `ocmm` WHERE `codmm` = '{0}'", txt_NumOc.Text);
                    mConn.Inserirdb(dadosql);

                    // inserir aki o DELETE dos dados do DGV

                }
                else
                {

                }
                bloquearbotao();
                LimparTextBoxes(this.Controls);
                chx_editar.Checked = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }



        }

        private void Cbx_Contrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            dadosmssql = string.Format("select codccu from vetorh.dbo.r018ccu where nomccu = '{0}'", cbx_Contrato.Text);
            DataTable resultado = new DataTable();
            resultado = msConn.ConsultaTabela(dadosmssql);

            lbl_CodContrato.Text = resultado.Rows[0]["codccu"].ToString();

        }

        private void Tsm_editar_Click(object sender, EventArgs e)
        {
            chx_editar.Checked = true;
            liberarbotao();
        }

        private void Cbx_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            dadosql = string.Format("SELECT `cod`,`unidade`,`prcusto` FROM `estoque` WHERE `descricao`= '{0}'", cbx_Descricao.Text);
            DataTable resultado = new DataTable();
            resultado = mConn.ConsultaTabela(dadosql);

            lbl_CodDescr.Text = resultado.Rows[0]["cod"].ToString();
            txt_Unidade.Text = resultado.Rows[0]["unidade"].ToString();
            txt_VlCusto.Text = resultado.Rows[0]["prcusto"].ToString();

        }

        private void Txt_Quantidade_TextChanged(object sender, EventArgs e)
        {
            if(txt_Quantidade.Text != "")
            {
                int valor = Convert.ToInt32(txt_VlCusto.Text) + Convert.ToInt32(txt_Quantidade.Text);

                txt_VlTotalItem.Text = "R$ " + Convert.ToString(valor);
             //   MessageBox.Show(Convert.ToString(valor));
            }
            else
            {
                txt_VlTotalItem.Text = "";
            }
            
           // txt_VlTotalItem.Text = Convert.ToInt32(txt_VlCusto.Text);

        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }
    }
}
