using System;
using System.Data;
using System.Windows.Forms;

namespace CG
{
    public partial class frm_FornecedorPesquisa : Form
    {
        public frm_FornecedorPesquisa()
        {
            InitializeComponent();
        }
        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();
        public void Listar()
        {
            dadosql = "SELECT `cod`,`nome`,`tel1`,`tel2`,`doc`,`email` FROM `fornecedor`";
            dgv_FornecedorPesquisa.DataSource = mConn.ConsultaTabela(dadosql);

            dadosql = string.Format("SELECT MIN(cod) FROM fornecedor");
            DataTable resultado = new DataTable();
            resultado = mConn.LeituraLinha(dadosql);

            txt_destino.Text = resultado.Rows[0]["MIN(cod)"].ToString();

        }
        private void Frm_FornecedorPesquisa_Load(object sender, EventArgs e)
        {
            cbx_coluna.Text = "Nome";
            Listar();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

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

            dadosql = string.Format("SELECT `cod`,`nome`,`tel1`,`tel2`,`doc`,`email` FROM `fornecedor` WHERE `{0}` LIKE '%{1}%'", coluna, txt_referencia.Text);
            dgv_FornecedorPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }

        private void Dgv_FornecedorPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_destino.Text = this.dgv_FornecedorPesquisa.CurrentRow.Cells[0].Value.ToString();
            frm_FornecedorCadastro destino = new frm_FornecedorCadastro(txt_destino.Text);
            this.Close();
            destino.Show();
        }

        private void Dgv_FornecedorPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
