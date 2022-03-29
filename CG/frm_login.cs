using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_login : Form
    {
        //variaveis
        private string sql;
        public static string id;
        public static string usuario;
        //instacia classe conexao
        //Classes.conexao conn = new Classes.conexao();
        Classes.dbconect mCoon = new Classes.dbconect();
        private string dadosql;

        public frm_login()
        {       
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Classes.hash crypt = new Classes.hash();
            //passando txt de string para byte
            byte[] senhaCrypto = new UTF8Encoding().GetBytes(txt_senha.Text);
            //passando array de bytes como parametro e armazenando na variavel
            string senhaMd5 = crypt.Md5(senhaCrypto).ToString();



             sql = string.Format("select usuario from usuario where usuario = '{0}' and senha = '{1}'", txt_username.Text, senhaMd5);
            
            //validar usuario
            try
            {
                if (mCoon.login(sql) == 0)
                {
                    lbl_erro.Text = "Nome de usuário ou senha inválidos!";
                }
                else
                {
                    //pegar id e nome do usuario
                    sql = string.Format("select usuario_id,usuario from usuario where usuario = '{0}'", txt_username.Text);
                    DataTable result = new DataTable();
                    result = mCoon.ConsultaTabela(sql);
                    id = result.Rows[0]["usuario_id"].ToString();
                    usuario = result.Rows[0]["usuario"].ToString();

                    //abrir formulario index
                 
                    this.Hide();

                    // definição de abertura de tela para criação de novo usuario
                    
                        if (txt_username.Text.Equals("cgadm"))
                        {
                           // MessageBox.Show("gerenciar");
                            frm_cadastro cadastro = new frm_cadastro();
                            cadastro.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                           // MessageBox.Show("normal");
                            frm_TelaInicial telaInicial = new frm_TelaInicial(usuario);
                            telaInicial.ShowDialog();
                            this.Close();
                        }
                                         
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro inesperado ocorreu\nPedimos desculpas pela inconveniência.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                txt_username.Text = "Usuário";                
            }

            if (txt_username.Text == "Usuário")
            {
                txt_username.Text = "";
            }
        }
        private void txt_senha_Enter(object sender, EventArgs e)
        {

            if(txt_senha.Text == "Senha")
            {
                txt_senha.Text = "";
                txt_senha.PasswordChar = '*';
            }
            if (string.IsNullOrWhiteSpace(txt_senha.Text)) {
                txt_senha.Text = "";
                txt_senha.PasswordChar = '*';
            }

        }
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                txt_username.Text = "Usuário";
            }
        }
        private void txt_senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_senha.Text))
            {
                txt_senha.Text = "Senha";
                txt_senha.PasswordChar = '\0';
            }

            
        }

        private void llbl_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            frm_cadastro cadastro = new frm_cadastro();
            cadastro.ShowDialog();
            this.Close();
        }

        private void Lbl_headerText_Click(object sender, EventArgs e)
        {

        }

       

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load_1(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void Txt_username_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void Txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Classes.hash crypt = new Classes.hash();
                //passando txt de string para byte
                byte[] senhaCrypto = new UTF8Encoding().GetBytes(txt_senha.Text);
                //passando array de bytes como parametro e armazenando na variavel
                string senhaMd5 = crypt.Md5(senhaCrypto).ToString();

                sql = string.Format("select usuario from usuario where usuario = '{0}' and senha = '{1}'", txt_username.Text, senhaMd5);
                
                //validar usuario
                try
                {
                    if (mCoon.login(sql) == 0)
                    {
                        lbl_erro.Text = "Nome de usuário ou senha inválidos!";
                    }
                    else
                    {
                        //pegar id e nome do usuario
                        sql = string.Format("select usuario_id,usuario from usuario where usuario = '{0}'", txt_username.Text);
                        DataTable result = new DataTable();
                        result = mCoon.ConsultaTabela(sql);
                        id = result.Rows[0]["usuario_id"].ToString();
                        usuario = result.Rows[0]["usuario"].ToString();

                        //abrir formulario index

                        this.Hide();

                        // definição de abertura de tela para criação de novo usuario

                        if (txt_username.Text.Equals("cgadm"))
                        {
                            // MessageBox.Show("gerenciar");
                            frm_cadastro cadastro = new frm_cadastro();
                            cadastro.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // MessageBox.Show("normal");
                            frm_TelaInicial telaInicial = new frm_TelaInicial(usuario);
                            telaInicial.ShowDialog();
                            this.Close();
                        }

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Um erro inesperado ocorreu\nPedimos desculpas pela inconveniência.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) | (e.KeyChar == 9))
            {
                txt_senha.Focus();
            }
        }

        private void Txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbx_user_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `nomcont` FROM `esto_saida_item` where `codsaida` = 7 LIMIT 1");
            resultado = mCoon.LeituraTabela(dadosql);
            MessageBox.Show(resultado.Rows[0]["nomcont"].ToString());
            


        }
    }
}
