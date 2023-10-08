namespace CG
{
    public partial class frm_TelaInicial : Form
    {
        public frm_TelaInicial(string userLogged)
        {
            InitializeComponent();

            txt_usuario.Text = userLogged;

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
    }

}
