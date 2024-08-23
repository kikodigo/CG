using CG.Domain.Constants;

namespace CG.Forms.TelaInicial
{
    public partial class frm_TelaInicial : Form
    {
        public frm_TelaInicial()
        {
        }


        public frm_TelaInicial(string userLogged)
        {
            InitializeComponent();

            txt_Usuario.Text = userLogged;

        }


        private void pictureBox1_Click(object sender, EventArgs e) // easter egg do jukera 
        {
            if (Convert.ToInt32(lbl_contador.Text) == 100)
            {
                MessageBox.Show("TAPOOOOOOOOORRAAAAA MENÓ \n YODA, AJUDA, AJUDA AJUDA ... YODAAAAAA", "TAPORRA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbl_contador.Text = "0";
            }
            lbl_contador.Text = (Convert.ToInt32(lbl_contador.Text) + 1).ToString();
        }

        private void frm_TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void Tsm_Fornec_Cadastro_Click(object sender, EventArgs e)
        {
            var forneCadastro = new frm_FornecedorCadastro(txt_Usuario.Text);
            forneCadastro.Show();
        }

        private void frm_TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void pesquisaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var fornecPesquisa = new frm_FornecedorPesquisa(txt_Usuario.Text, TableConstants.FORNEC_TABLE);
            fornecPesquisa.Show();
        }
    }
}
