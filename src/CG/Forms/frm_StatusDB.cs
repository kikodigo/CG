using CG.Core.Services;
using ZstdSharp.Unsafe;

namespace CG
{
    public partial class frm_StatusDB : Form
    {
        private readonly LoginServices _LoginServices;

        public frm_StatusDB()
        {
            InitializeComponent();
            _LoginServices = new LoginServices();
        }
        private void StatusDb()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                var result = _LoginServices.StatusDb();

                this.Invoke((MethodInvoker)delegate
                {
                    if (result)
                    {
                        lbl_StatusDb.Text = "Conectado!";
                        lbl_StatusDb.ForeColor = Color.DarkGreen;
                        btn_entrar.Enabled = true;
                    }
                    else
                    {
                        lbl_StatusDb.Text = "Erro!";
                        lbl_StatusDb.ForeColor = Color.DarkRed;
                        btn_entrar.Enabled = false;
                    }
                });

            }).Start();
        }      

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            var frmLogin = new frm_login();
           
            frmLogin.Show();
            
        }

        private void frm_StatusDB_Load(object sender, EventArgs e)
        {
            StatusDb();
        }

        private void btn_Reconect_Click(object sender, EventArgs e)
        {
            StatusDb();
        }
    }
}
