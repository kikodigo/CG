using CG.Core.Services;
using CG.Domain.Data;
using CG.Util;

namespace CG
{
    public partial class frm_FornecedorPesquisa : Form
    {
        public readonly FornecedorServices _fornecedorServices;
        public readonly CommonService _commonService;

        public frm_FornecedorPesquisa(string usuario, string table)
        {
            InitializeComponent();
            _fornecedorServices = new FornecedorServices();
            _commonService = new CommonService(table);

            txt_Usuario.Text = usuario;

            cbx_coluna.SelectedIndex = 1;
        }

        public void Listar()
        {
            var listFornec = _commonService.GetAllValues<FornecedorData>();

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
            Listar();
        }

        private void Dgv_FornecedorPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idFornec = this.dgv_FornecedorPesquisa.CurrentRow.Cells[0].Value.ToString();

            var frmCadastroFornec = new frm_FornecedorCadastro(txt_Usuario.Text, idFornec);

            this.Close();
            frmCadastroFornec.Show();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Referencia.Text = "";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string column = null;
            switch (cbx_coluna.Text)
            {
                case "Codigo":
                    column = "Id";
                    break;

                case "Razão":
                    column = "Razao";

                    break;
                case "CNPJ / CPF":
                    column = "DocNum";

                    break;
                case "E-Mail":
                    column = "email";

                    break;
                case "Fantasia":
                    column = "Fantasia";

                    break;

                default:
                    MsgBoxUtil.MsgBoxError("Opção Invalida", "Erro");
                    return;

            }

            var result = _commonService.GetAllValuesByReference<FornecedorData>(txt_Referencia.Text, column);

            dgv_FornecedorPesquisa.DataSource = result.Data;
            //dadosql = string.Format("SELECT `cod`,`nome`,`tel1`,`tel2`,`doc`,`email` FROM `fornecedor` WHERE `{0}` LIKE '%{1}%'", coluna, txt_referencia.Text);
            //dgv_FornecedorPesquisa.DataSource = mConn.ConsultaTabela(dadosql);
        }
    }
}
