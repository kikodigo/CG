using CG.Core.Services;
using CG.Domain.Constants;
using CG.Domain.Data;
using CG.Domain.Enum;
using CG.Domain.Response;
using CG.Util;
using CpfCnpjLibrary;
using System.Diagnostics;

namespace CG
{
    public partial class frm_FornecedorCadastro : Form
    {
        private readonly FornecedorServices _fornecedorServices;
        private readonly CommonService _commonService;
        private readonly HttpExternalQueries _httpExternalQueries;

        private readonly string FORNEC_TABLE = TableConstants.FORNEC_TABLE;

        public frm_FornecedorCadastro(string usuario)
        {
            InitializeComponent();
            _fornecedorServices = new FornecedorServices();
            _commonService = new CommonService(FORNEC_TABLE);
            _httpExternalQueries = new HttpExternalQueries();

            txt_Usuario.Text = usuario;
            cbx_Status.DataSource = Enum.GetValues(typeof(StatusEnum));

            FormsUtil.CarregamentoDeFormsDesabilitandoCancelareSalvar(menuStrip1.Items);
            var lastFornec = _commonService.GetLastValueAsync<FornecedorData>();
            FormsUtil.PreencherCampos(this, lastFornec);
        }

        public frm_FornecedorCadastro(string usuario, string id)
        {
            InitializeComponent();
            _fornecedorServices = new FornecedorServices();
            _commonService = new CommonService(FORNEC_TABLE);
            _httpExternalQueries = new HttpExternalQueries();

            txt_Usuario.Text = usuario;
            cbx_Status.DataSource = Enum.GetValues(typeof(StatusEnum));

            CarregamentoFrmCadastrosVindodaPesquisa(id);
        }

        private void CarregamentoFrmCadastrosVindodaPesquisa(string id)
        {
            FormsUtil.CarregamentoDeFormsDesabilitandoCancelareSalvar(menuStrip1.Items);
            var fornec = _commonService.GetValueById<FornecedorData>(id);
            FormsUtil.LimparCampos(this);
            FormsUtil.PreencherCampos(this, fornec.Data);
        }

        private void Frm_FornecedorCadastro_Load(object sender, EventArgs e)
        {

        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            FormsUtil.StatusControles(this, true);
            FormsUtil.StatusItensMenu(menuStrip1.Items, false);
            FormsUtil.LimparCampos(this);
            txt_Razao.Focus();
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            FormsUtil.StatusControles(this, false);
            FormsUtil.StatusItensMenu(menuStrip1.Items, true);

            if (!chx_editar.Checked)
            {
                var lastFornec = _commonService.GetLastValueAsync<FornecedorData>();
                FormsUtil.PreencherCampos(this, lastFornec);
            }

            chx_editar.Checked = false;
        }

        private void Txt_site_TextChanged(object sender, EventArgs e)
        {
            lkl_site.Text = txt_Site.Text;
            if (string.IsNullOrEmpty(txt_Site.Text))
            {
                lkl_site.Text = "Site";
            }
        }

        private void Lkl_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente abrir o site?", "Site", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start(lkl_site.Text);
            }
        }

        private void Tsm_editar_Click(object sender, EventArgs e)
        {
            FormsUtil.StatusControles(this, true);
            FormsUtil.StatusItensMenu(menuStrip1.Items, false);
            chx_editar.Checked = true;
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            if (FormsUtil.ValidarDoc(txt_DocNum.Text))
            {
                var fornec = FormsUtil.GerarObjeto<FornecedorData>(this);
                var result = new GenericResponse<FornecedorData>();

                if (chx_editar.Checked)
                {
                    result = _fornecedorServices.UpdateFornec(fornec);
                }
                else
                {
                    result = _fornecedorServices.InsertFornec(fornec);
                }

                if (result.HasError)
                {
                    MsgBoxUtil.MsgBoxError($"Algum problema ocorreu durante a" +
                      $"{(chx_editar.Checked ? "edição" : "inserção")}" +
                      $"do fornecedor. \n" +
                      $"Error: {string.Join(" - ", result.Errors)}",
                      "ERRO");
                }
                else
                {
                    FormsUtil.StatusControles(this, false);
                    FormsUtil.StatusItensMenu(menuStrip1.Items, true);
                    chx_editar.Checked = false;
                }
            }
            else
            {
                MsgBoxUtil.MsgBoxError($"{txt_DocNum.Text} esta invalido",
                    "Documento inalido");
            }
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            var previousFornec = _commonService.GetPreviousValueById<FornecedorData>(txt_Id.Text);

            if (previousFornec.HasError)
            {
                MsgBoxUtil.MsgBoxInformation(string.Join(" - ", previousFornec.Errors),
                    "Fornecedor");
            }
            else
            {
                FormsUtil.PreencherCampos(this, previousFornec.Data);
            }

        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            var nextFornec = _commonService.GetNextValueById<FornecedorData>(txt_Id.Text);

            if (nextFornec.HasError)
            {
                MsgBoxUtil.MsgBoxInformation(string.Join(" - ", nextFornec.Errors),
                    "Fornecedor");
            }
            else
            {
                FormsUtil.PreencherCampos(this, nextFornec.Data);
            }
        }

        private void Tsm_pesquisa_Click(object sender, EventArgs e)
        {
            frm_FornecedorPesquisa fornpesq = new frm_FornecedorPesquisa(txt_Usuario.Text);
            this.Close();
            fornpesq.Show();
        }

        private void txt_DocNum_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_DocNum.Text))
            {
                switch (txt_DocNum.Text.Length)
                {
                    case 11:
                        if (!Cpf.Validar(txt_DocNum.Text))
                        {
                            MsgBoxUtil.MsgBoxError($"{lbl_DocNum.Text} esta invalido",
                                "Documento inalido");

                            txt_DocNum.Focus();
                        }
                        break;
                    
                    case 14:
                        if (!Cnpj.Validar(txt_DocNum.Text))
                        {
                            MsgBoxUtil.MsgBoxError($"{lbl_DocNum.Text} esta invalido",
                                "Documento inalido");

                            txt_DocNum.Focus();
                        }
                        break;
                    
                    default:
                        MsgBoxUtil.MsgBoxError($"{lbl_DocNum.Text} esta invalido",
                            "Documento inalido");

                        txt_DocNum.Focus();
                        break;
                }
                
               
            }
        }

        private void tsm_Excluir_Click(object sender, EventArgs e)
        {
            var messageToMsgBox = $"Deseja excluir o forcedor? \n" +
                $"Razão Social: {txt_Razao.Text}\n" +
                $"CNPJ: {txt_DocNum.Text}\n";

            if (MsgBoxUtil.MsgBoxQuestion(messageToMsgBox, "Excluir"))
            {
                var fornec = FormsUtil.GerarObjeto<FornecedorData>(this);
                var result = new GenericResponse<bool>();

                //TODO: Verificar em outras tabelas se ja existe utiliza��o desse fornecedor, se sim. apenas inativar

                result = _fornecedorServices.DeleteFornec(fornec);

                if (result.HasError)
                {
                    MsgBoxUtil.MsgBoxError($"Algum problema ocorreu durante a" +
                      $"{(chx_editar.Checked ? "edição" : "inserção")}" +
                      $"do fornecedor. \n" +
                      $"Error: {string.Join(" - ", result.Errors)}",
                      "ERRO");

                    return;
                }
                else
                {
                    FormsUtil.StatusControles(this, false);
                    FormsUtil.StatusItensMenu(menuStrip1.Items, true);
                    chx_editar.Checked = false;
                }
            }

            var lastFornec = _commonService.GetLastValueAsync<FornecedorData>();
            FormsUtil.PreencherCampos(this, lastFornec);
        }
    }
}