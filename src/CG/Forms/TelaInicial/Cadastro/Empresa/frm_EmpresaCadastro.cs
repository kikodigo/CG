using CG.Util;
using System.Data;

namespace CG.Tela_Inicial.Cadastro.Empresa
{
    public partial class frm_EmpresaCadastro : Form
    {


        public frm_EmpresaCadastro(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;

        }

        private void tsm_salvar_Click(object sender, EventArgs e)
        {

        }

        private void tsm_editar_Click(object sender, EventArgs e)
        {
            FormsUtil.StatusControles(this, true);
            FormsUtil.StatusItensMenu(menuStrip1.Items, false);
            chx_editar.Checked = true;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

        }

        private void tsm_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
