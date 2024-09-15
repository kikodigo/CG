using CG.Core.Services;
using CG.Domain.Constants;
using CG.Domain.Data;
using CG.Util;

namespace CG.Tela_Inicial.Cadastro.Empresa
{
    public partial class frm_EmpresaCadastro : Form
    {
        private readonly EmpresaServices _empresaServices;
        private readonly CommonService _commonService;

        public frm_EmpresaCadastro(string usuario)
        {
            InitializeComponent();
            _empresaServices = new EmpresaServices();
            _commonService = new CommonService(TableConstants.EMPRESA_TABLE);
            txt_usuario.Text = usuario;

            var lastEmpresa = _commonService.GetLastValueAsync<EmpresaData>();
            FormsUtil.PreencherCampos(this, lastEmpresa);

            FormsUtil.StatusControles(this, false);
            FormsUtil.StatusItensMenu(menuStrip1.Items, true);
        }

        private void tsm_salvar_Click(object sender, EventArgs e)
        {
            FormsUtil.StatusControles(this, false);
            FormsUtil.StatusItensMenu(menuStrip1.Items, true);

            var empresaData = FormsUtil.GerarObjeto<EmpresaData>(this);

            _empresaServices.InsertOrUpdateEmpresa(empresaData);

        }

        private void tsm_editar_Click(object sender, EventArgs e)
        {
            FormsUtil.StatusControles(this, true);
            FormsUtil.StatusItensMenu(menuStrip1.Items, false);
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            var httpExternalQueries = new HttpExternalQueries();
            var empresahttp = httpExternalQueries.GetEmpresaPorCNPJ(txt_DocNum.Text);
            
            if (empresahttp != null)
            {
                var idAtual = txt_Id.Text;
                FormsUtil.PreencherCampos(this, empresahttp);
                txt_Id.Text = idAtual;
            }

        }

        private void tsm_cancelar_Click(object sender, EventArgs e)
        {
            var lastEmpresa = _commonService.GetLastValueAsync<EmpresaData>();
            FormsUtil.PreencherCampos(this, lastEmpresa);

            FormsUtil.StatusControles(this, false);
            FormsUtil.StatusItensMenu(menuStrip1.Items, true);
        }
    }
}
