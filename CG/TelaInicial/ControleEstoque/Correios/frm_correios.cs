using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace CG.TelaInicial.ControleEstoque.Correios
{
    public partial class frm_correios : Form
    {
        public frm_correios()
        {
            InitializeComponent();
        }

     
        //private void btn_Rastrear_Click(object sender, EventArgs e)
        //{


        //    try
        //    {
        //        // Limpa campos que receberão os dados do rastreamento
        //        txt_Categoria.Text = txt_Codigo.Text = txt_Data.Text =
        //            txt_Local.Text = txt_Descricao.Text = string.Empty;


        //        // Aciona o webservice para busca dos dados
        //        var client = new wsRastreio.ServiceClient();
        //        var requestInterceptor = new InspectorBehavior();
        //        client.Endpoint.Behaviors.Add(requestInterceptor);
        //        client.buscaEventos("ECT", "SRO", "L", "", "001", txt_CodObj.Text);

        //        // Recupera as informações do Xml
        //        var ser = new XmlSerializer(typeof(Envelope));
        //        var envelope = new Envelope();
        //        using (TextReader reader = new StringReader(requestInterceptor.LastResponseXML))
        //        {
        //            envelope = (Envelope)ser.Deserialize(reader);
        //        }

        //        // Cria objeto para receber as informações
        //        var objetoRastreado = envelope.Body.buscaEventosResponse.@return.objeto;
        //        // Povo os campos com as informaçóes
        //        txt_Categoria.Text = objetoRastreado.categoria;
        //        txt_Codigo.Text = objetoRastreado.evento[0].codigo.ToString();
        //        txt_Data.Text = objetoRastreado.evento[0].data + " às " + objetoRastreado.evento[0].hora;
        //        txt_Local.Text = objetoRastreado.evento[0].local;
        //        txt_Descricao.Text = objetoRastreado.evento[0].descricao;
        //    }
        //    catch
        //    {
        //        MessageBox.Show(
        //            "Não foi possível fazer a busca neste momento pois o serviço dos Correios se encontra fora do ar!",
        //            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }


      // }
    }
}
