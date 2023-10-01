using System;
using System.Data;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_alterarConta : Form
    {
        public frm_alterarConta()
        {
            InitializeComponent();
        }
        private string sql;
        Classes.conexao conn = new Classes.conexao();

        //carregar info do usuario ao carregar form
        private void frm_alterarConta_Load(object sender, EventArgs e)
        {
            sql = string.Format("select * from usuario where usuario_id = '{0}'", frm_login.id);
            DataTable result = new DataTable();
            result = conn.ConsultarTabelas(sql);

            if (result.Rows.Count > 0)
            {
                txt_nome.Text = result.Rows[0]["nome"].ToString();
                txt_username.Text = result.Rows[0]["usuario"].ToString();
            }
            else
            {
                MessageBox.Show("Ops, algo deu errado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //btn alterar
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //testeando se vazio
            if ((string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_nome.Text)))
            {
                lbl_erro.Text = "Todos os campos devem ser preenchidos";
            }
            else
            {
                //testando se o username do txt é igual ao username do camarada
                sql = string.Format("select * from usuario where usuario = '{0}'", txt_username.Text);
                if (txt_username.Text.Equals(frm_login.usuario))
                {
                    AlterarUsuario();
                }
                //se nao for igual testa se usuario ja existe
                else if (conn.ConsultarTabelas(sql).Rows.Count > 0)
                {
                    MessageBox.Show("Este nome de usuário já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AlterarUsuario();
                }


            }
        }
        private void btn_alterarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_alterarSenha altSenha = new frm_alterarSenha();
            altSenha.ShowDialog();
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_config config = new frm_config();
            config.ShowDialog();
            this.Close();
        }
        //metodos
        public void Limpar()
        {
            txt_username.Clear();
            txt_nome.Clear();
        }
        public void AlterarUsuario()
        {
            try
            {
                sql = string.Format("update usuario set usuario = '{0}', nome = '{1}' where usuario_id = '{2}'",
                txt_username.Text, txt_nome.Text, frm_login.id);

                conn.AlterarTabelas(sql);
                MessageBox.Show("Informações alteradas\nFaça login novamente", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();

                this.Hide();
                frm_login login = new frm_login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, algo deu errado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
