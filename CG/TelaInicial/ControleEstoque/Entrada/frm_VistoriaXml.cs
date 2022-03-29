using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CG.TelaInicial.ControleEstoque.Entrada
{
    public partial class frm_VistoriaXml : Form
    {
        public frm_VistoriaXml()
        {
            InitializeComponent();
        }
        public frm_VistoriaXml(string usuario)
        {
            InitializeComponent();
            txt_usuario.Text = usuario;
        }

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        private void Frm_VistoriaXml_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void LerXmlNfe(string CaminhoArquivo)
        {
            DataTable table = new DataTable();
            DataTable resultado = new DataTable();

            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Id Externo", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("NCM", typeof(string));
            table.Columns.Add("Qtd", typeof(string));
            table.Columns.Add("Valor Un", typeof(string));
            table.Columns.Add("Valor Total", typeof(string));

            var arquivo = CaminhoArquivo;
            var fimItens = false;
            var isEmitente = false;
            var item = "";
            var cProd = "";
            var xProd = "";
            var ncm = "";
            var qCom = "";
            var vUnCom = "";
            var vProd = "";
            using (XmlReader meuXml = XmlReader.Create(arquivo))
            {
                // cabeçalho, dados do emitente
                while (meuXml.Read()) 
                {
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "emit")
                        isEmitente = true;
                    else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dest")
                        break;


                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nNF")
                        txt_Nnota.Text = meuXml.ReadElementString();

                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dhEmi")
                        txt_DataEmissao.Text = XmlConvert.ToDateTime(meuXml.ReadElementString()).ToString("dd/MM/yyyy");




                    if (isEmitente)
                    {
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CNPJ")
                            mtb_cnpj.Text = meuXml.ReadElementString();


                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xNome")
                        
                            txt_Fornecedor.Text = meuXml.ReadElementString();
                            
                        
                    }

                }




                while (meuXml.Read())
                {
                 
                    //---- Itens

                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                    {
                        //lendo atributo da tag <det>
                        item = meuXml.GetAttribute("nItem");

                        //variaveis para guardar o conteudo do item
                        cProd = "";
                        xProd = "";
                        ncm = "";
                        qCom = "";
                        vUnCom = "";
                        vProd = "";
                    }
                    else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "total")
                    {
                        fimItens = true;
                    }
                    if (!fimItens)
                    {
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd")
                            cProd = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd")
                            xProd = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "NCM")
                            ncm = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
                            qCom = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
                            vUnCom = meuXml.ReadElementString();


                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vProd")
                        {
                            vProd = meuXml.ReadElementString();

                            table.Rows.Add(item, cProd, xProd, ncm, Convert.ToDouble(qCom.Replace(".", ",")).ToString("F"), Convert.ToDouble(vUnCom.Replace(".", ",")).ToString("C"), Convert.ToDouble(vProd.Replace(".", ",")).ToString("C"));

                        }

                    }
                    //---- Rodapé

                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vNF")
                        txt_VlTotalNota.Text = Convert.ToDouble(meuXml.ReadElementString().Replace(".", ",")).ToString("C");

                }
                dgv_TabelaItens.DataSource = table;
                this.dgv_TabelaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }

            dadosql = string.Format("SELECT * FROM `fornecedor` WHERE `doc` = '{0}'", mtb_cnpj.Text);

            resultado = mConn.LeituraTabela(dadosql);
            if (resultado.Rows.Count != 0)
            {
                txt_CodForne.Text = resultado.Rows[0]["cod"].ToString();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Fornecedor não cadastrado.\nDeseja cadastrar com os dados da nota?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {

                    dadosql = string.Format("INSERT INTO `fornecedor` (`cod`, `nome`, `estado`, `cidade`, `bairro`, `rua`, `num`, `cep`, `contato`, `tel1`, `tel2`, `tipodoc`, `doc`, `tipocont`, `ag`, `op`, `ct`, `email`, `site`, `ativo`) VALUES(NULL, '{0}', '', '', '', '', '', '', '', '', '', '', '{1}', '', '', '', '', '', '', 'SIM')", txt_Fornecedor.Text, mtb_cnpj.Text.Replace(",", "."));
                    mConn.Inserirdb(dadosql);


                    dadosql = string.Format("SELECT `cod` FROM `fornecedor` WHERE `doc` = '{0}'", mtb_cnpj.Text);
                    resultado = mConn.LeituraLinha(dadosql);
                    try
                    {
                        // lbl_codfor.Text = resultado.Rows[0]["cod"].ToString();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message.ToString());
                        MessageBox.Show(erro.ToString());
                    }
                                       
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Processo cancelado!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        [Obsolete]


        private void Btn_SelecionarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML Files(*.xml)|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LerXmlNfe(dialog.FileName);
            }
            Vistoria();
        }

        private void Vistoria()
        {
            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `cod` FROM `fornecedor` WHERE `doc` = '{0}'", mtb_cnpj.Text);
            resultado = mConn.ConsultaTabela(dadosql);

            int contador = 0;
            string codext, codforne = resultado.Rows[0]["cod"].ToString();
            try
            {
                DataTable Table = new DataTable();
                DataTable Itens = new DataTable();

                Table.Columns.Add("Item", typeof(string));
                Table.Columns.Add("Id Externo", typeof(string));
                Table.Columns.Add("Descrição", typeof(string));
                Table.Columns.Add("Qtd", typeof(string));
                Table.Columns.Add("Valor Un", typeof(string));
                Table.Columns.Add("Valor Total", typeof(string));

                Itens.Columns.Add("Cod Interno", typeof(string));
                Itens.Columns.Add("Descrição", typeof(string));
                Itens.Columns.Add("Qtd", typeof(string));
                Itens.Columns.Add("Valor Un", typeof(string));
                Itens.Columns.Add("Valor Total", typeof(string));

                while (contador < dgv_TabelaItens.RowCount)
                {
                    // ele faz consulta na tabela de codigo externo
                    codext = null;
                    codext = dgv_TabelaItens.Rows[contador].Cells["Id Externo"].Value.ToString();
                    dadosql = string.Format("SELECT `codprod` FROM `esto_codext` WHERE `codext` ='{0}' AND `codforne` ='{1}'", codext, codforne);
                    resultado = mConn.ConsultaTabela(dadosql);

                    // se a tiver algum retorno ele será inserido na tabela itens que será adicionado
                    if (resultado.Rows.Count != 0)
                    {
                        dadosql = string.Format("SELECT `cod`,`descricao`,`estoqueatual` FROM `estoque` WHERE `cod` = '{0}'", resultado.Rows[0]["codprod"].ToString());
                        resultado = mConn.ConsultaTabela(dadosql);
                        Itens.Rows.Add(resultado.Rows[0]["cod"].ToString(), resultado.Rows[0]["descricao"].ToString(), dgv_TabelaItens.Rows[contador].Cells["Qtd"].Value.ToString(), dgv_TabelaItens.Rows[contador].Cells["Valor Un"].Value.ToString(), dgv_TabelaItens.Rows[contador].Cells["Valor Total"].Value.ToString());
                    }
                    //se retornar zerado ele adicionará o item "cru" da XML na table para informar que tem um erro
                    else
                    {
                        Table.Rows.Add(dgv_TabelaItens.Rows[contador].Cells["Item"].Value.ToString(), dgv_TabelaItens.Rows[contador].Cells["Id Externo"].Value.ToString(), dgv_TabelaItens.Rows[contador].Cells["Descrição"].Value.ToString(), dgv_TabelaItens.Rows[contador].Cells["Qtd"].Value.ToString(), dgv_TabelaItens.Rows[contador].Cells["Valor Un"].Value.ToString(), dgv_TabelaItens.Rows[contador].Cells["Valor Total"].Value.ToString());
                    }


                    contador++;

                }
                dgv_Falha.DataSource = Table;
                dgv_Itens.DataSource = Itens;
                this.dgv_Falha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                this.dgv_Itens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                if (Table.Rows.Count != 0)
                {
                    tbc_Itens.SelectedTab = tbp_Falha;
                    MessageBox.Show("Atenção! \nExistem "+Table.Rows.Count.ToString() + " itens sem cadastro de codigo externo. \nPor favor, verifique o cadastro de estoque \nNão é permitido a liberação de XML com falhas.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

                Table = null;
                Itens = null;
            }
            catch (Exception erro)
            {
                MessageBox.Show(dadosql);
                MessageBox.Show(erro.Message.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(erro.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Btn_Liberar_Click(object sender, EventArgs e)
        {

            if(dgv_Falha.RowCount == 0)
            {
                DataTable dt = new DataTable();
                //Adiciona as colunas existentes.
                foreach (DataGridViewColumn column in dgv_Itens.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adiciona as linhas existentes.
                foreach (DataGridViewRow row in dgv_Itens.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }

                CG.Tela_Inicial.Controle_Estoque.Saida.frm_ControleEntrada entrada = new Tela_Inicial.Controle_Estoque.Saida.frm_ControleEntrada(dt, txt_usuario.Text, txt_CodForne.Text, txt_DataEmissao.Text, txt_Nnota.Text);
                entrada.Show();
            }
            else
            {
                MessageBox.Show("Não é possivel importar XML com itens com codigo externo faltantes.\nExistem " + dgv_Falha.RowCount.ToString() + " iten(s) que não foram cadastrados.\nPor favor, verifique no cadastro de produtos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbc_Itens.SelectedTab = tbp_Falha;

            }          

        }

    }
}
