using CG.Core.Services;
using CG.Domain.Data;
using CG.Domain.Enum;
using CG.Domain.Response;
using CG.Util;
using CpfCnpjLibrary;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace CG
{
    public partial class frm_FornecedorCadastro : Form
    {
        public readonly FornecedorServices _fornecedorServices;
        public readonly HttpExternalQueries _httpExternalQueries;

        public frm_FornecedorCadastro(string usuario)
        {
            InitializeComponent();
            _fornecedorServices = new FornecedorServices();
            _httpExternalQueries = new HttpExternalQueries();

            txt_Usuario.Text = usuario;
            cbx_Status.DataSource = Enum.GetValues(typeof(StatusEnum));
        }

        public frm_FornecedorCadastro(string valor, string usuario)
        {
            InitializeComponent();
            DataTable resultado = new DataTable();
            //dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `cod` = '{0}'", valor);
            //resultado = mConn.LeituraLinha(dadosql);
            //------

            //preencher(resultado);
            this.TopMost = true;
            txt_Usuario.Text = usuario;
        }

        private void Frm_FornecedorCadastro_Load(object sender, EventArgs e)
        {
            UtilForms.CarregamentoDeFormsDesabilitandoCancelareSalvar(menuStrip1.Items);
            var firstFornec = _fornecedorServices.GetLastFornecAsync();
            UtilForms.PreencherCampos(this, firstFornec);
        }

        private void Tsm_novo_Click(object sender, EventArgs e)
        {
            UtilForms.StatusControles(this, true);
            UtilForms.StatusItensMenu(menuStrip1.Items, false);
            UtilForms.LimparCampos(this);
            txt_Razao.Focus();
        }

        private void Tsm_cancelar_Click(object sender, EventArgs e)
        {
            UtilForms.StatusControles(this, false);
            UtilForms.StatusItensMenu(menuStrip1.Items, true);

            if (!chx_editar.Checked)
            {
                var lastFornec = _fornecedorServices.GetLastFornecAsync();
                UtilForms.PreencherCampos(this, lastFornec);
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
            UtilForms.StatusControles(this, true);
            UtilForms.StatusItensMenu(menuStrip1.Items, false);
            chx_editar.Checked = true;
        }

        private void Tsm_salvar_Click(object sender, EventArgs e)
        {
            if (UtilForms.ValidarDoc(txt_DocNum.Text))
            {
                var fornec = UtilForms.GerarObjeto<FornecedorData>(this);
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
                    MessageBox.Show($"Algum problema ocorreu durante a" +
                      $"{(chx_editar.Checked ? "edição" : "inserção")}" +
                      $"do fornecedor. \n" +
                      $"Error: {string.Join(" - ", result.Errors)}",
                      "ERRO",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
                else
                {
                    UtilForms.StatusControles(this, false);
                    UtilForms.StatusItensMenu(menuStrip1.Items, true);
                    chx_editar.Checked = false;
                }
            }
            else
            {
                MessageBox.Show($"{lbl_DocNum.Text} esta invalido",
                    "Documento inalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Tsm_anterior_Click(object sender, EventArgs e)
        {
            var previousFornec = _fornecedorServices.GetPreviousFornecById(txt_Id.Text);

            if (previousFornec.HasError) 
            {
                MessageBox.Show(string.Join(" - ", previousFornec.Errors),
                    "Fornecedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                UtilForms.PreencherCampos(this, previousFornec.Data);
            }

        }

        private void Tsm_proximo_Click(object sender, EventArgs e)
        {
            var nextFornec = _fornecedorServices.GetNextFornecById(txt_Id.Text);

            if (nextFornec.HasError)
            {
                MessageBox.Show(string.Join(" - ", nextFornec.Errors),
                    "Fornecedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                UtilForms.PreencherCampos(this, nextFornec.Data);
            }
        }

        private void Tsm_pesquisa_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_FornecedorPesquisa fornpesq = new frm_FornecedorPesquisa();
            fornpesq.ShowDialog();
        }

        private void txt_DocNum_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_DocNum.Text))
            {
                if (!Cnpj.Validar(txt_DocNum.Text))
                {
                    MessageBox.Show($"{lbl_DocNum.Text} esta invalido",
                                      "Documento inalido",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);

                    txt_DocNum.Focus();
                }
            }
        }

        private void tsm_Excluir_Click(object sender, EventArgs e)
        {
            //Fazer: Verificar em outras tabelas se ja existe utilização desse fornecedor, se sim. apenas inativar
        }
    }
}