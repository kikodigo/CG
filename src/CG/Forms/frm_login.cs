using CG.Core.Services;

namespace CG
{
    public partial class frm_login : Form
    {
        private readonly LoginServices _LoginServices;

        public frm_login()
        {
            InitializeComponent();
            _LoginServices = new LoginServices();

        }

        private void btn_entrar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_senha.Text)
                    || string.IsNullOrWhiteSpace(txt_senha.Text)
                    || string.IsNullOrEmpty(txt_username.Text)
                    || string.IsNullOrWhiteSpace(txt_username.Text)
                    || txt_username.Text == "Usuário"
                    || txt_senha.Text == "Senha")
                {
                    MessageBox.Show("Por favor, digite seu usuário e senha.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lbl_erro.Text = "";

                var loginStatus = _LoginServices.Login(txt_username.Text, txt_senha.Text);

                if (loginStatus)
                {
                    this.Hide();

                    var telaInicialForm = new frm_TelaInicial(txt_username.Text);
                    telaInicialForm.Show();
                }
                else
                {
                    lbl_erro.Text = "Nome de usuário ou senha inválidos!";
                }
            }
            catch (Exception ex)
            {

                // gerar log 


                //_logger.LogError($"Error in {typeof(ConsentUpdateWrkConsumer).Assembly.GetName().Name} application in process " +
                //$"{spanContextName}.{nameMethod} \n" +
                //$"ErrorMessage: {ex.Message}, \n" +
                //$"StackTrace: {ex.StackTrace}, \n" +
                //$"Details: {ex.GetType().FullName}, \n" +
                //$"ProcessKey: {traceKeys.ProcessKey}, \n" +
                //$"TrackId: {traceKeys.TrackId},\n" +
                //$"MessageReceived: {message}");
                throw;
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

            if (txt_senha.Text == "Senha")
            {
                txt_senha.Text = "";
                txt_senha.PasswordChar = '*';
            }
            if (string.IsNullOrWhiteSpace(txt_senha.Text))
            {
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

        private void Txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_entrar_ClickAsync(sender, e);
            }
        }

        private void Txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) | (e.KeyChar == 9))
            {
                txt_senha.Focus();
            }
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
