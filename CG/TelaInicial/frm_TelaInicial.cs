using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.IO;


namespace CG
{
    public partial class frm_TelaInicial : Form
    {

        
        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();


        public frm_TelaInicial (string usuariologado)
        {
            InitializeComponent();
          
            txt_usuario.Text = usuariologado;

        }


        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Requisiação>Novo - Criação de uma nova requisição

            frm_ReqCadastro req = new frm_ReqCadastro(txt_usuario.Text);
            req.ShowDialog();
        }
                

     
        private void NovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_OCMMCadastro ocmm = new frm_OCMMCadastro();
            ocmm.ShowDialog();
        }

     
             

        private void RetornoFichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Requisição> Retorno Fichas - Retorno de fichas de EPI 

            CG.Tela_Inicial.Requisição.Retorno_Ficha.frm_ReqRetornoFicha reqficha = new Tela_Inicial.Requisição.Retorno_Ficha.frm_ReqRetornoFicha();
            reqficha.ShowDialog();
        }

        private void ImpressãoFichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Requisição>Impressão de Ficha - Impressão de fichas de EPI

            Tela_Inicial.Requisição.Impressão_Ficha.frm_ReqImpressaoFicha impficha = new Tela_Inicial.Requisição.Impressão_Ficha.frm_ReqImpressaoFicha();
            impficha.ShowDialog();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Requisição>Consulta - CONSULTA DE REQUISIÇÃO

            Tela_Inicial.Requisição.Consulta.frm_ReqConsulta consulta = new Tela_Inicial.Requisição.Consulta.frm_ReqConsulta(txt_usuario.Text);
            consulta.ShowDialog();
        }

      

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Relatorio>Log -  Log do sistema

            Tela_Inicial.Relatorios.frm_log log = new Tela_Inicial.Relatorios.frm_log();
            log.ShowDialog();
        }

      

        private void CadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Cadastro>Contrato>Cadastro - CADASTRO DE ENDEREÇO DE CONTRATOS

            Tela_Inicial.Cadastro.Contratos.frm_ContratoCadastro contr = new Tela_Inicial.Cadastro.Contratos.frm_ContratoCadastro(txt_usuario.Text);
            contr.ShowDialog();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastro>Estoque>Produto>Cadastro - CADASTRO DE PRODUTO

            frm_ProdutoCadastro ProdutoCadastro = new frm_ProdutoCadastro(txt_usuario.Text);
            ProdutoCadastro.ShowDialog();
        }



        private void CadastroToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //Cadastro>Empresa>Cadastro - CADASTRO DAS INFORMAÇÕES DA EMPRESA

            CG.Tela_Inicial.Cadastro.Empresa.frm_EmpresaCadastro empcadastro = new Tela_Inicial.Cadastro.Empresa.frm_EmpresaCadastro(txt_usuario.Text);
            empcadastro.ShowDialog();
        }

        private void PesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastro>Estoque>Produto>Pesquisa - PESQUISA DE PRODUTO

            Frm_ProdutoPesquisa prodpesquisa = new Frm_ProdutoPesquisa(txt_usuario.Text);
            prodpesquisa.ShowDialog();
        }

        private void PesquisaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Cadastro>Contrato>Pesquisa -  Pesquisa de Contrato

            CG.Tela_Inicial.Cadastro.Contratos.frm_ContratoPesquisa pesquisacontr = new CG.Tela_Inicial.Cadastro.Contratos.frm_ContratoPesquisa(txt_usuario.Text);
            pesquisacontr.ShowDialog();

        }

        private void PesquisaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //Cadastro>Funcionarios>Pesquisa - Pesquisa de funcionarios

            Tela_Inicial.Cadastro.Funcionarios.frm_Funcionarios func = new Tela_Inicial.Cadastro.Funcionarios.frm_Funcionarios(txt_usuario.Text);
            func.Show();
        }

        private void CadastroToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //Cadastro>Fornecedor>Cadastro - Cadastro de Fornecedor

            frm_FornecedorCadastro FornecedorCadastro = new frm_FornecedorCadastro(txt_usuario.Text);
            FornecedorCadastro.ShowDialog();
        }

        private void CadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Cadastro>Estoque>Classe>Cadastro -  Cadastro de Classes de Produto

            frm_ProdutoClasse CadastroClasse = new frm_ProdutoClasse(txt_usuario.Text);
            CadastroClasse.ShowDialog();

        }

        private void PesquisaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Cadastro>Estoque>Unidade>Pesquisa - Pesquisa de Unidades de produto cadastradas

            frm_ProdutoUnidadePesquisa PesquisaUnidade = new frm_ProdutoUnidadePesquisa(txt_usuario.Text);
            PesquisaUnidade.ShowDialog();

        }

        private void PesquisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Cadastro>Estoque>Classe>Pesquisa - Pesquisa de Classes de produto cadastradas

            frm_ProdutoClassePesquisa PesquisaClasse = new frm_ProdutoClassePesquisa(txt_usuario.Text);
            PesquisaClasse.ShowDialog();

        }

        private void CadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Cadastro>Estoque>Unidade>Cadastro - Cadastro de unidades de produtos

            frm_ProdutoUnidade CadastroUnidade = new frm_ProdutoUnidade(txt_usuario.Text);
            CadastroUnidade.ShowDialog();

        }

        private void PesquisaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //Cadastro>Fornecedor>Pesquisa - Pesquisa de fornecedores cadastrador

            frm_FornecedorCadastro CadastroFornecedor = new frm_FornecedorCadastro(txt_usuario.Text);
            CadastroFornecedor.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e) // easter egg do jukera 
        {
            if(Convert.ToInt32(lbl_contador.Text) == 100)
            {
                MessageBox.Show("TAPOOOOOOOOORRAAAAA MENÓ \n YODA, AJUDA, AJUDA AJUDA ... YODAAAAAA", "TAPORRA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbl_contador.Text = "0";
            }
            lbl_contador.Text =  Convert.ToString(Convert.ToInt32(lbl_contador.Text) + 1);


        }

        private void produtoPorPostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastro>Fornecedor>Pesquisa - Pesquisa de fornecedores cadastrador

            frm_ProdutoPostoCadastro produtopostocadastro = new frm_ProdutoPostoCadastro(txt_usuario.Text);
            produtopostocadastro.ShowDialog();
        }

        private void frm_TelaInicial_Load(object sender, EventArgs e)
        {

        }
        
        
        private void btn_TesteEmail_Click(object sender, EventArgs e)
        {

            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT * FROM `estoque` WHERE `descricao` = 'qweqweqw'");
            resultado = mConn.LeituraTabela(dadosql);

            try
            {
                MessageBox.Show(resultado.Rows[0]["descricao"].ToString());
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());;
            }

        }

       

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastro>Fornecedor>Pesquisa - Pesquisa de fornecedores cadastrador

            Tela_Inicial.Controle_Estoque.Saida.frm_ControleSaida saidaestoque = new Tela_Inicial.Controle_Estoque.Saida.frm_ControleSaida(txt_usuario.Text);
            saidaestoque.Show();
        }

        private void correiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial.ControleEstoque.Correios.frm_correios correios = new TelaInicial.ControleEstoque.Correios.frm_correios();
            correios.Show();
        }

       

        private void XMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CG.TelaInicial.ControleEstoque.Entrada.frm_VistoriaXml xml = new TelaInicial.ControleEstoque.Entrada.frm_VistoriaXml(txt_usuario.Text);
            xml.Show();
        }

        private void ComumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CG.Tela_Inicial.Controle_Estoque.Saida.frm_ControleEntrada entrada = new Tela_Inicial.Controle_Estoque.Saida.frm_ControleEntrada(txt_usuario.Text);
            entrada.Show();
        }
    }
    
}
