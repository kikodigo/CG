using CG.Core.Services;
using CG.Domain.Data;
using CG.Util;
using System.Data;

namespace CG
{
    public partial class frm_FornecedorPesquisa : Form
    {
        public readonly FornecedorServices _fornecedorServices;

        public frm_FornecedorPesquisa(string usuario)
        {
            InitializeComponent();
            _fornecedorServices = new FornecedorServices();

            txt_Usuario.Text = usuario;
        }

        public void Listar()
        {
            var listFornec = _fornecedorServices.GetAllFornec();

            if (listFornec.HasError)
            {
                MsgBoxUtil.MsgBoxError(listFornec.Errors.FirstOrDefault(), "Error");
            }
            else
            {
                dgv_FornecedorPesquisa.DataSource = listFornec.Data;
            }
        }
        private void Frm_FornecedorPesquisa_Load(object sender, EventArgs e)
        {
            cbx_coluna.Text = "Nome";
            Listar();
        }

        private void Txt_referencia_TextChanged(object sender, EventArgs e)
        {
            string coluna = null;
            switch (cbx_coluna.Text)
            {
                case "Codigo":
                    coluna = "cod";

                    break;
                case "Nome":
                    coluna = "nome";

                    break;
                case "CNPJ / CPF":
                    coluna = "doc";

                    break;
                case "E-Mail":
                    coluna = "email";

                    break;

                default:
                    MessageBox.Show("Opção Invalida");
                    break;

            }

            //dadosql = string.Format("SELECT `cod`,`nome`,`tel1`,`tel2`,`doc`,`email` FROM `fornecedor` WHERE `{0}` LIKE '%{1}%'", coluna, txt_referencia.Text);
            //dgv_FornecedorPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }

        private void Dgv_FornecedorPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idFornec = this.dgv_FornecedorPesquisa.CurrentRow.Cells[0].Value.ToString();

            var frmCadastroFornec = new frm_FornecedorCadastro(txt_Usuario.Text, idFornec);

            this.Close();
            frmCadastroFornec.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbx_coluna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
