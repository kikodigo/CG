using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CG.Tela_Inicial.Cadastro.Empresa
{
    public partial class frm_EmpresaCadastro : Form
    {


        public frm_EmpresaCadastro(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;


            DataTable resultado = new DataTable();
            //resultado = mPermissao.consulta(usuario, this.Name);
            lbl_VlPermissao.Text = resultado.Rows[0][this.Name].ToString();
        }

        public void controleacesso(string CodPerfil)
        {
            switch (CodPerfil)
            {
                case "1":

                    break;

                case "2":
                    break;

                case "3":
                    tsm_editar.Visible = false;

                    break;

                case "4":
                    tsm_editar.Visible = false;
                    tsm_salvar.Visible = false;
                    tsm_cancelar.Visible = false;

                    break;

                case "0":
                    MessageBox.Show("Acesso negado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    break;

                default:
                    MessageBox.Show("Falha ao carregar Perfil.\\nInforme o Administrador do sistema.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;

            }

        }

        private string permissao;
        //Classes.permissoes mPermissao = new Classes.permissoes();


        public void bloquearbotao()
        {
            txt_razao.Enabled = false;
            txt_nome.Enabled = false;
            txt_cnpj.Enabled = false;
            txt_estado.Enabled = false;
            txt_cidade.Enabled = false;
            txt_bairro.Enabled = false;
            txt_rua.Enabled = false;
            txt_num.Enabled = false;
            txt_cep.Enabled = false;
            txt_tel1.Enabled = false;
            txt_tel2.Enabled = false;

            tsm_salvar.Enabled = false;
            tsm_editar.Enabled = true;
            tsm_cancelar.Enabled = false;

            label0.ForeColor = Color.Gray;
            label1.ForeColor = Color.Gray;
            label2.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label5.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
            label7.ForeColor = Color.Gray;
            label8.ForeColor = Color.Gray;
            label9.ForeColor = Color.Gray;
            label10.ForeColor = Color.Gray;
        }
        public void liberarbotao()
        {
            txt_razao.Enabled = true;
            txt_nome.Enabled = true;
            txt_cnpj.Enabled = true;
            txt_estado.Enabled = true;
            txt_cidade.Enabled = true;
            txt_bairro.Enabled = true;
            txt_rua.Enabled = true;
            txt_num.Enabled = true;
            txt_cep.Enabled = true;
            txt_tel1.Enabled = true;
            txt_tel2.Enabled = true;

            tsm_salvar.Enabled = true;
            tsm_editar.Enabled = false;
            tsm_cancelar.Enabled = true;

            label0.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
        }







        private void Frm_EmpresaCadastro_Load(object sender, EventArgs e)
        {
            bloquearbotao();
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liberarbotao();
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            bloquearbotao();
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            bloquearbotao();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
