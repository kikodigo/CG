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
    public partial class frm_alterarSenha : Form
    {
        public frm_alterarSenha()
        {
            InitializeComponent();
            txt_senha.PasswordChar = '*';
            txt_confirmar.PasswordChar = '*';
        }
        Classes.conexao conn = new Classes.conexao();
        private string sql;
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (!txt_senha.Text.Equals(txt_confirmar.Text))
            {
                MessageBox.Show("Senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Classes.hash crypt = new Classes.hash();
                    //passando txt de string para byte
                    byte[] senhaCrypto = new UTF8Encoding().GetBytes(txt_senha.Text);
                    //passando array de bytes como parametro e armazenando na variavel
                    string senhaMd5 = crypt.Md5(senhaCrypto).ToString();

                    sql = string.Format("update usuario set senha = '{0}' where usuario_id = '{1}'", senhaMd5, frm_login.id);

                    conn.AlterarTabelas(sql);
                    MessageBox.Show("Senha alterada\nFaça login novamente", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    frm_login login = new frm_login();
                    login.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops, algo deu errado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_config config = new frm_config();
            config.ShowDialog();
            this.Close();
        }
    }
}
