using System;
using System.Drawing;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
        }
        private string sql;
        Classes.conexao conn = new Classes.conexao();


        private void btn_apagarConta_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Realmente deseja apagar sua conta?", "Deletar Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    sql = string.Format("delete from gerenciador where usuario ='" + frm_login.id + "'");
                    conn.AlterarTabelas(sql);
                    sql = string.Format("delete from usuario where usuario_id ='" + frm_login.id + "'");
                    conn.AlterarTabelas(sql);
                    MessageBox.Show("Conta apagada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            frm_ReqCadastro index = new frm_ReqCadastro();
            index.ShowDialog();
            this.Close();
        }

        private void btn_alterarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_alterarConta alterar = new frm_alterarConta();
            alterar.ShowDialog();
            this.Close();
        }

        private void btn_deletarSenhas_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Realmente deseja apagar\nTodas as senhas?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    sql = string.Format("delete from gerenciador where usuario = '" + frm_login.id + "'");
                    conn.AlterarTabelas(sql);
                    sql = string.Format("alter table gerenciador auto_increment = 1");
                    conn.AlterarTabelas(sql);

                    MessageBox.Show("Senhas deletadas", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops, algo deu errado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_deletarSenhas_MouseHover(object sender, EventArgs e)
        {
            btn_deletarSenhas.BackColor = Color.FromArgb(29, 126, 219);
            btn_deletarSenhas.FlatStyle = FlatStyle.Popup;
        }

        private void btn_deletarSenhas_MouseLeave(object sender, EventArgs e)
        {
            btn_deletarSenhas.BackColor = Color.FromArgb(10, 10, 10);
            btn_deletarSenhas.FlatStyle = FlatStyle.Flat;
        }

        private void btn_alterarConta_MouseHover(object sender, EventArgs e)
        {
            btn_alterarConta.BackColor = Color.FromArgb(29, 126, 219);
            btn_alterarConta.FlatStyle = FlatStyle.Popup;
        }

        private void btn_alterarConta_MouseLeave(object sender, EventArgs e)
        {
            btn_alterarConta.BackColor = Color.FromArgb(10, 10, 10);
            btn_alterarConta.FlatStyle = FlatStyle.Flat;
        }

        private void btn_apagarConta_MouseHover(object sender, EventArgs e)
        {
            btn_apagarConta.BackColor = Color.FromArgb(29, 126, 219);
            btn_apagarConta.FlatStyle = FlatStyle.Popup;
        }

        private void btn_apagarConta_MouseLeave(object sender, EventArgs e)
        {
            btn_apagarConta.BackColor = Color.FromArgb(10, 10, 10);
            btn_apagarConta.FlatStyle = FlatStyle.Flat;
        }
    }
}
