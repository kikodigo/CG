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
    public partial class frm_alterar : Form
    {

        public frm_alterar(decimal id_valor)
        {
            InitializeComponent();
            decimal id = id_valor;
            lbl_id.Text = id.ToString();


        }
        //variaveis
        Classes.conexao conn = new Classes.conexao();
        frm_gerenciador gerenciador = new frm_gerenciador();

        private string sql;
        //alterar
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_usuario.Text) || string.IsNullOrWhiteSpace(txt_nomesite.Text) || string.IsNullOrWhiteSpace(txt_senha.Text)))
            {
                lbl_erro.Text = "Todos os campos devem ser preenchidos";
            }
            else
            {
                sql = string.Format("update gerenciador set siteNome = '{0}', login = '{1}', senha = '{2}' where id = '{3}'",
                txt_nomesite.Text, txt_usuario.Text, txt_senha.Text, lbl_id.Text);

                conn.AlterarTabelas(sql);
                MessageBox.Show("Campo alterado", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            gerenciador.ShowDialog();
            this.Close();
        }

        private void frm_alterar_Load(object sender, EventArgs e)
        {

            sql = string.Format("select * from gerenciador where usuario = '{0}' and id = '{1}'", frm_login.id, lbl_id.Text);
            DataTable result = new DataTable();
            result = conn.ConsultarTabelas(sql);

            if (result.Rows.Count > 0)
            {
                txt_usuario.Text = result.Rows[0]["login"].ToString();
                txt_senha.Text = result.Rows[0]["senha"].ToString();
                txt_nomesite.Text = result.Rows[0]["siteNome"].ToString();
            }
            else
            {
                MessageBox.Show("ID inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Hide();
                gerenciador.ShowDialog();
                this.Close();
            }
        }
        //metodos
        public void Limpar()
        {
            txt_usuario.Clear();
            txt_nomesite.Clear();
            txt_senha.Clear();
            txt_nomesite.Focus();
        }

    }
}
