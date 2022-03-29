using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
            txt_senha.PasswordChar = '*';
            txt_confirmar.PasswordChar = '*';
        }
        //variaveis
        Classes.conexao conn = new Classes.conexao();
        private string sql;


        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();


        private void carregardgv()
        {
            dadosql = string.Format("SELECT `usuario_id`,`nome`,`usuario`,`perfil` FROM `v_user` ORDER BY `usuario_id` ASC");
            dgv_usuarios.DataSource = mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT * FROM `perfil`");
            dgv_perfil.DataSource = mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT * FROM `v_permissao`");
            dgv_permissoes.DataSource = mConn.LeituraLinha(dadosql);

            this.dgv_permissoes.Columns["Permissao_Perfil"].Frozen = true; // só para congelar a primeira coluna para melhor visualização

            dadosql = string.Format("SELECT `perfil` FROM `perfil`");
            cbx_UsuarioPerfil.DisplayMember = "perfil";
            cbx_UsuarioPerfil.DataSource = mConn.LeituraTabela(dadosql);
            cbx_UsuarioPerfil.Text = "";

        }

        private void limpaperfil()
        {
            txt_perfil.Text = null;
            rbt_atualizar.Checked = false;
            rbt_adicionar.Checked = false;
            lbl_CodPerfil.Text = null;
        }

        private void limpausuario()
        {
            chx_alterarsenha.Enabled = false;
            chx_alterarsenha.Checked = false;

            txt_username.Text = null;
            txt_confirmar.Text = null;
            txt_senha.Text = null;
            txt_senha.Enabled = true;
            txt_confirmar.Enabled = true;
            txt_nome.Text = null;
            cbx_UsuarioPerfil.Text = null;            
            lbl_UsuarioPerfilCod.Text = null;
            
            btn_entrar.Text = "Cadastrar";
        }

        private void limpapermissao()
        {
            rbt_PermissaoNegado.Checked = false;
            rbt_PermissaoTotal.Checked = false;
            rbt_PermissaoLNE.Checked = false;
            rbt_PermissaoLN.Checked = false;
            rbt_permissaoL.Checked = false;
            txt_PermissaoPerfil.Text = null;
            lbl_PermissaoCodPerfil.Text = null;
            lbl_PermissaoTela.Text = null;
            txt_PermissaoTela.Text = null;
            lbl_CodPermissao.Text = null;

        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (!txt_senha.Text.Equals(txt_confirmar.Text))
            {
                MessageBox.Show("Senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_senha.Clear();
                txt_confirmar.Clear();
            }
            else
            {
                if(btn_entrar.Text == "Atualizar")
                {
                    if(chx_alterarsenha.Checked == true)
                    {
                        Classes.hash crypt = new Classes.hash();
                        //passando txt de string para byte
                        byte[] senhaCrypto = new UTF8Encoding().GetBytes(txt_senha.Text);
                        //passando array de bytes como parametro e armazenando na variavel
                        string senhaMd5 = crypt.Md5(senhaCrypto).ToString();

                        sql = string.Format("UPDATE `usuario` SET `senha` = '{0}' WHERE `usuario` = '{1}'", senhaMd5, txt_username.Text);

                        conn.AlterarTabelas(sql);
                    }


                   dadosql = string.Format("UPDATE `usuario` SET `usuario` = '{0}', `nome` = '{1}', `perfil` = '{2}' WHERE `usuario`.`usuario_id` = '{3}'", txt_username.Text, txt_nome.Text,lbl_UsuarioPerfilCod.Text, lbl_UsuarioIdCod.Text);
                    mConn.LeituraTabela(dadosql);
                    
                }
                else
                {

                    sql = string.Format("select * from usuario where usuario = '{0}'", txt_username.Text);

                    if (conn.ConsultarTabelas(sql).Rows.Count > 0)
                    {
                        MessageBox.Show("Este nome de usuário já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Classes.hash crypt = new Classes.hash();
                        //passando txt de string para byte
                        byte[] senhaCrypto = new UTF8Encoding().GetBytes(txt_senha.Text);
                        //passando array de bytes como parametro e armazenando na variavel
                        string senhaMd5 = crypt.Md5(senhaCrypto).ToString();

                        sql = string.Format("insert into usuario(usuario_id,usuario,senha,nome,data_cadastro,perfil) values(null,'{0}','{1}','{2}',now(),'{3}')", txt_username.Text, senhaMd5, txt_nome.Text,lbl_UsuarioPerfilCod.Text);

                        conn.AlterarTabelas(sql);

                        txt_username.Text = null;
                        txt_confirmar.Text = null;
                        txt_senha.Text = null;
                        txt_nome.Text = null;
                        cbx_UsuarioPerfil.Text = null;
                        chx_alterarsenha.Enabled = false;
                        btn_entrar.Text = "Cadastrar";
                    }
                }
               

            }
            carregardgv();
            limpausuario();

        }


 
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
            this.Close();
        }

        private void Frm_cadastro_Load(object sender, EventArgs e)
        {
            carregardgv();

            dadosql = string.Format("SELECT `perfil` FROM `perfil`");
            cbx_UsuarioPerfil.DisplayMember = "perfil";
            cbx_UsuarioPerfil.DataSource = mConn.LeituraTabela(dadosql);
            cbx_UsuarioPerfil.Text = "";

            limpausuario();

        }

        private void Dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = this.dgv_usuarios.CurrentRow.Cells[1].Value.ToString();
            txt_username.Text = this.dgv_usuarios.CurrentRow.Cells[2].Value.ToString();
            cbx_UsuarioPerfil.Text = this.dgv_usuarios.CurrentRow.Cells[3].Value.ToString();
            lbl_UsuarioIdCod.Text = this.dgv_usuarios.CurrentRow.Cells[0].Value.ToString();



            txt_senha.Enabled = false;
            txt_confirmar.Enabled = false;
            chx_alterarsenha.Enabled = true;
            chx_alterarsenha.Checked = false;
            btn_entrar.Text = "Atualizar";
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            limpausuario();
            
        }


        private void Chx_alterarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_senha.Enabled == false)
            {

                txt_senha.Enabled = true;
                txt_confirmar.Enabled = true;
            }
            else
            {
                txt_senha.Enabled = false;
                txt_confirmar.Enabled = false;
            }
        }

        private void Btn_perfilOK_Click(object sender, EventArgs e)
        {
            if((rbt_adicionar.Checked == true ) | (rbt_atualizar.Checked == true))
            {

                dadosql = string.Format("SELECT* FROM `perfil` WHERE `perfil` = '{0}'", txt_perfil.Text);
                mConn.Inserirdb(dadosql);



                if (rbt_adicionar.Checked == true)
                {
                    DataTable resultado = new DataTable();

                    dadosql = string.Format("INSERT INTO `perfil` (`cod`, `perfil`) VALUES(NULL, '{0}')",txt_perfil.Text);
                    mConn.Inserirdb(dadosql);


                    dadosql = string.Format("SELECT `cod` FROM `perfil` where perfil = '{0}'", txt_perfil.Text);
                    resultado = mConn.LeituraLinha(dadosql);

                   

                    dadosql = string.Format(" INSERT INTO `permissao` (`cod`, `perfil`, `frm_TelaInicial`, `frm_ContratoCadastro`, `frm_ContratoPesquisa`, `frm_EmpresaCadastro`, `frm_ProdutoClasse`, `frm_ProdutoClassePesquisa`, `frm_ProdutoCadastro`, `frm_ProdutoPesquisa`, `frm_ProdutoUnidade`, `frm_ProdutoUnidadePesquisa`, `frm_FornecedorCadastro`, `frm_FornecedorPesquisa`, `frm_Funcionarios`, `frm_ReqConsulta`, `frm_ReqImpressaoFicha`, `frm_ReqCadastro`, `frm_ReqPesquise`, `frm_ReqVisualizador`, `frm_ReqRetornoFicha`) VALUES(NULL, '{0}', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1')", resultado.Rows[0]["cod"].ToString());
                    mConn.Inserirdb(dadosql);


                }

               if(rbt_atualizar.Checked == true)
                {
                  
                    dadosql = string.Format("  UPDATE `perfil` SET `perfil` = '{0}' WHERE `perfil`.`cod` = '{1}'", txt_perfil.Text,lbl_CodPerfil.Text);
                    mConn.Inserirdb(dadosql);                   

                }


                carregardgv();
                limpaperfil();

            }
            else
            {
                MessageBox.Show("Selecione uma das opções acima","ERRO!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            limpaperfil();

        }

        private void Btn_perfilCancela_Click(object sender, EventArgs e)
        {
            limpaperfil();
        }

        private void Dgv_perfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_CodPerfil.Text = this.dgv_perfil.CurrentRow.Cells[0].Value.ToString();
            txt_perfil.Text = this.dgv_perfil.CurrentRow.Cells[1].Value.ToString();
        }

        private void Btn_PerfilDeletar_Click(object sender, EventArgs e)
        {
            if(lbl_CodPerfil.Text != "")
            {

            
                DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este perfil?", "Excluir", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                
                    dadosql = string.Format("DELETE FROM `perfil` WHERE `cod` = '{0}'", lbl_CodPerfil.Text);
                    mConn.Inserirdb(dadosql);

                    dadosql = string.Format("DELETE FROM `permissao` WHERE `perfil` = '{0}'", lbl_CodPerfil.Text);
                    mConn.Inserirdb(dadosql);

                    carregardgv();
            

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Processo Cancelado!", "Cancelado");
                }
                limpaperfil();
            }
            else
            {
                MessageBox.Show("Selecione um perfil a ser deletado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_PermissaoOk_Click(object sender, EventArgs e)
        {

            if((txt_PermissaoPerfil.Text == "") || (txt_PermissaoTela.Text == "") ||(lbl_CodPermissao.Text == ""))
            {
                MessageBox.Show("Por favor, Selecione uma tela e sua permissão","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {

                dadosql = string.Format("UPDATE `permissao` SET `{0}` = '{1}' WHERE `perfil` = '{2}'", lbl_PermissaoTela.Text, lbl_CodPermissao.Text, lbl_PermissaoCodPerfil.Text);

                     mConn.Inserirdb(dadosql);

                limpapermissao();
                carregardgv();
            }


        }

        private void Rbt_PermissaoTotal_CheckedChanged(object sender, EventArgs e)
        {
            lbl_CodPermissao.Text = "1";
        }

        private void Rbt_PermissaoLNE_CheckedChanged(object sender, EventArgs e)
        {
            lbl_CodPermissao.Text = "2";
        }

        private void Rbt_PermissaoLN_CheckedChanged(object sender, EventArgs e)
        {
            lbl_CodPermissao.Text = "3";
        }

        private void Rbt_permissaoL_CheckedChanged(object sender, EventArgs e)
        {
            lbl_CodPermissao.Text = "4";
        }

        private void Rbt_PermissaoNegado_CheckedChanged(object sender, EventArgs e)
        {
            lbl_CodPermissao.Text = "0";
        }

        private void Pnl_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cbx_UsuarioPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbx_UsuarioPerfil.Text != "")
            {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `cod` FROM `perfil` where perfil = '{0}'", cbx_UsuarioPerfil.Text);
            resultado = mConn.LeituraLinha(dadosql);
            lbl_UsuarioPerfilCod.Text = resultado.Rows[0]["cod"].ToString();
            }

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Dgv_permissoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_PermissaoPerfil.Text = this.dgv_permissoes.CurrentRow.Cells[0].Value.ToString();
            txt_PermissaoTela.Text = this.dgv_permissoes.CurrentCell.OwningColumn.HeaderText.ToString();
            lbl_PermissaoTela.Text = this.dgv_permissoes.CurrentCell.OwningColumn.DataPropertyName.ToString();

                //define lbl com cod de perfil

                DataTable resultado = new DataTable();
                dadosql = string.Format("SELECT `cod` FROM `perfil` where perfil = '{0}'", txt_PermissaoPerfil.Text);
                resultado = mConn.LeituraLinha(dadosql);
                lbl_PermissaoCodPerfil.Text = resultado.Rows[0]["cod"].ToString();

        }
    }
}
