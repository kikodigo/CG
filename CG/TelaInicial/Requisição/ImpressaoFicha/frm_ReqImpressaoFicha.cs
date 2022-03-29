using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Imaging;  
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;


namespace CG.Tela_Inicial.Requisição.Impressão_Ficha
{
    public partial class frm_ReqImpressaoFicha : Form
    {
        public frm_ReqImpressaoFicha()
        {
            InitializeComponent();
        }

        private string dadosql;
        Classes.dbconect mConn = new Classes.dbconect();

        private string dadosmssql;
        Classes.mssqlconect msConn = new Classes.mssqlconect();

        private void Frm_ReqImpressaoFicha_Load(object sender, EventArgs e)
        {

            
            dadosql = string.Format("SELECT `codreq` FROM `requerimento` where `status` <> \"EM ANDAMENTO\" AND `status`<> \"AGUARDANDO APROVAÇÃO\" ORDER BY `codreq` DESC ");
            cbx_nreq.DisplayMember = "codreq";
            cbx_nreq.DataSource = mConn.ConsultaTabela(dadosql);
            cbx_nreq.Text = "";
            txt_contrato.Text = "";
            txt_setor.Text = "";

            dadosql = string.Format("SELECT `qtd_lib`,`descricao` FROM `req_item`  WHERE `func`= 'VAZIO'");
            dgv_descricoes.DataSource = mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT `qtd_lib` AS `Entrega` FROM `req_item` WHERE `func`= 'NADINHA' ");
            dgv_dataEntrega.DataSource = mConn.LeituraLinha(dadosql);

            txt_dataADM.Text = null;
            txt_colaborador.Text = null;
            txt_funcao.Text = null;
            txt_Nreg.Text = null;
            txt_Nreq.Text = null;
            txt_dataDEM.Text = null;
            txt_setor.Text = null;
            
            txt_informacoes.BackColor = Color.White;
            txt_dataADM.BackColor = Color.White;
            txt_colaborador.BackColor = Color.White;
            txt_funcao.BackColor = Color.White;
            txt_Nreg.BackColor = Color.White;
            txt_Nreq.BackColor = Color.White;
            txt_dataDEM.BackColor = Color.White;
            txt_setor.BackColor = Color.White;
            txt_informacoes.BackColor = Color.White;
            txt_contrato.BackColor = Color.White;

            txt_informacoes.ForeColor = Color.Black;
            txt_dataADM.ForeColor = Color.Black;
            txt_colaborador.ForeColor = Color.Black;
            txt_funcao.ForeColor = Color.Black;
            txt_Nreg.ForeColor = Color.Black;
            txt_Nreq.ForeColor = Color.Black;
            txt_dataDEM.ForeColor = Color.Black;
            txt_setor.ForeColor = Color.Black;
           // txt_informacoes.ForeColor = Color.Black;




        }
        Bitmap bmp;
        private void Imprimeprev()
        {
            bmp = new Bitmap(this.Width, this.Height);

            this.TopMost = true;
            Graphics mg = Graphics.FromImage(bmp);
            mg.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            mg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            // mg.CopyFromScreen(this.Location.X +10, this.Location.Y +75, 25, 85, this.Size);
            mg.CopyFromScreen(this.Location.X + 10, this.Location.Y + 75, 25, 85, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);


            this.printDocument1.DefaultPageSettings.Landscape = true;


            // printDocument1.Print();
            // printPreviewDialog1.ShowDialog();


            this.TopMost = false;
            (printPreviewDialog1 as Form).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
           //  this.printDocument1.Print();
        }


        private void Imprime()
        {
            bmp = new Bitmap(this.Width, this.Height);

            this.TopMost = true;
            Graphics mg = Graphics.FromImage(bmp);
            mg.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            mg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            // mg.CopyFromScreen(this.Location.X +10, this.Location.Y +75, 25, 85, this.Size);
            mg.CopyFromScreen(this.Location.X + 10, this.Location.Y + 75, 25, 85, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);


            this.printDocument1.DefaultPageSettings.Landscape = true;


            // printDocument1.Print();
            // printPreviewDialog1.ShowDialog();


            this.TopMost = false;
            (printPreviewDialog1 as Form).WindowState = FormWindowState.Maximized;
           //printPreviewDialog1.ShowDialog();
             this.printDocument1.Print();
        }


        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            // pre visualiza 

            e.Graphics.DrawImageUnscaled(bmp,0,0);


        }

        private void Cbx_contratos_SelectedIndexChanged(object sender, EventArgs e)
        {

            


            DataTable resultado = new DataTable();
            dadosql = string.Format("SELECT `contrato` FROM `requerimento` WHERE codreq = '{0}' ", cbx_nreq.Text);

            resultado = mConn.LeituraLinha(dadosql);
            txt_contrato.Text =  resultado.Rows[0]["contrato"].ToString();
            txt_setor.Text = resultado.Rows[0]["contrato"].ToString();

            dadosql = string.Format("SELECT * FROM `req_item` where codreq = '{0}' GROUP BY func", cbx_nreq.Text);
            cbx_SelectFunc.DisplayMember = "func";
            cbx_SelectFunc.DataSource = mConn.ConsultaTabela(dadosql);
            cbx_SelectFunc.Text = "";


            dadosql = string.Format("SELECT `qtd_lib`,`descricao` FROM `req_item`  WHERE `func`= 'Vazio Completo'");
            dgv_descricoes.DataSource = mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT `qtd_lib` AS `Entrega` FROM `req_item` WHERE `func`= 'Vazio Completo' ");
            dgv_dataEntrega.DataSource = mConn.LeituraLinha(dadosql);

            dadosql = string.Format("SELECT `qtd_lib` AS `Assinatura`,`func` AS `Devolução`,`cargo`AS `Assinatura` FROM `req_item` WHERE `func`= 'NADINHA'");
            dgv_assinaturas.DataSource = mConn.LeituraLinha(dadosql);


            txt_dataADM.Text = null;
            txt_colaborador.Text = null;
            txt_funcao.Text = null;
            txt_Nreg.Text = null;
            txt_Nreq.Text = null;
            txt_dataDEM.Text = null;


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Impressão_Ficha.frm_ReqImpressaoFichaRel form = new Impressão_Ficha.frm_ReqImpressaoFichaRel();

            //Impressao_Ficha.frm_ReqImpressaoFichaRel form = Impresso_Ficha.frm_ReqImpressaoFichaRel
            
            form.Show();
        }

        private void Chx_SelectFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_SelectFunc.Enabled == false)
            {
                cbx_SelectFunc.Enabled = true;
            }
            else
            {
                cbx_SelectFunc.Enabled = false;
                cbx_SelectFunc.Text = "";
            }
        }

     

        private void Cbx_SelectFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();

            dadosql = string.Format("SELECT `qtd_lib`,`descricao` FROM `req_item`  WHERE `func`= '{0}' and `codreq` = {1}", cbx_SelectFunc.Text ,cbx_nreq.Text);
            dgv_descricoes.DataSource = mConn.LeituraLinha(dadosql);


            //consulta do nome no mysql e consulta da matricula no SQL server
                dadosql = string.Format("SELECT `matr_func` FROM `req_func` WHERE `func` = '{0}' GROUP by `matr_func`", cbx_SelectFunc.Text);
                resultado = mConn.LeituraLinha(dadosql);
                lbl_matricula.Text = resultado.Rows[0]["matr_func"].ToString();
            //--


            // Consulta SQL Server para preenchimento dos campos
            string codcargo,sitafa;
            dadosmssql = string.Format("select numcad,datadm,datafa,codcar,sitafa from vetorh.dbo.r034fun where numcad = {0}",lbl_matricula.Text);
            resultado = msConn.ConsultaTabela(dadosmssql);
            txt_Nreg.Text = resultado.Rows[0]["numcad"].ToString();
            txt_dataADM.Text =  resultado.Rows[0]["datadm"].ToString();

           // txt_dataADM2.Text = resultado.Rows[0]["datadm"].ToString();

            sitafa = resultado.Rows[0]["datafa"].ToString();
            if (sitafa == "7" && sitafa == "3" && sitafa == "53")
            {
                txt_dataDEM.Text = resultado.Rows[0]["datafa"].ToString();
            }            

            codcargo = resultado.Rows[0]["codcar"].ToString();

            dadosmssql = string.Format("select titcar from vetorh.dbo.r024car where codcar = '{0}'", codcargo);
            resultado = msConn.ConsultaTabela(dadosmssql);
            txt_funcao.Text = resultado.Rows[0]["titcar"].ToString();


            txt_colaborador.Text = cbx_SelectFunc.Text;
            txt_Nreq.Text = cbx_nreq.Text;

            
            // limpa as DGV
                dadosql = string.Format("SELECT `qtd_lib` AS `Entrega` FROM `req_item` WHERE `func`= 'NADINHA' ");
                dgv_dataEntrega.DataSource = mConn.LeituraLinha(dadosql);


                dadosql = string.Format("SELECT `qtd_lib` AS `Assinatura`,`func` AS `Devolução`,`cargo`AS `Assinatura` FROM `req_item` WHERE `func`= 'NADINHA'");
                dgv_assinaturas.DataSource = mConn.LeituraLinha(dadosql);
            // ----



           
            dadosql = string.Format("SELECT COUNT(`descricao`) AS `Entrega` FROM `req_item`  WHERE `func`= '{0}' and `codreq` = {1}", cbx_SelectFunc.Text, cbx_nreq.Text);
            resultado = mConn.LeituraLinha(dadosql);

            dgv_dataEntrega.DataSource = null;
            dgv_assinaturas.DataSource = null;
                       

            if (dgv_dataEntrega.Columns.Count.ToString() == "0")
            {
                
                dgv_dataEntrega.Columns.Add("Data Entrega", "Data Entrega");

            }
            else
            {
                int x = 0;
                while (x == Convert.ToInt32(dgv_dataEntrega.Columns.Count.ToString()))
                {

                    dgv_dataEntrega.Columns.Remove("Data Entrega");


                    x++;
                }

            }


            if (dgv_assinaturas.Columns.Count.ToString() == "0")
            {

                dgv_assinaturas.Columns.Add("Ass. Entrega", "Ass. Entrega");

                dgv_assinaturas.Columns.Add("Data Devolução", "Data Devolução");

                dgv_assinaturas.Columns.Add("Ass. Devolução", "Ass. Devolução");

            }
            else
            {
                int x = 0;
                while (x == Convert.ToInt32(dgv_assinaturas.Columns.Count.ToString()))
                {
                    dgv_assinaturas.Columns.Remove("Ass. Entrega");

                    dgv_assinaturas.Columns.Remove("Data Devolução");

                    dgv_assinaturas.Columns.Remove("Ass. Devolução");


                    x++;
                }

            }



            dgv_assinaturas.Rows.Add(Convert.ToInt32(resultado.Rows[0]["Entrega"].ToString()));

            dgv_dataEntrega.Rows.Add(Convert.ToInt32(resultado.Rows[0]["Entrega"].ToString()));



            int contador = 0;
            while (contador < Convert.ToInt32(dgv_descricoes.Rows.Count.ToString()))
            {
                dadosql = string.Format("SELECT `ca` FROM `estoque` WHERE `descricao` = '{0}'", dgv_descricoes.Rows[contador].Cells[2].Value.ToString());
                resultado = mConn.ConsultaTabela(dadosql);
                

                if(dgv_descricoes.Rows.Count.ToString() != "0")
                {
                   
                    dgv_descricoes.Rows[contador].Cells["CA"].Value = resultado.Rows[0]["CA"].ToString();
                }



                contador++;
            }


        }

        private void Btn_imprime_Click(object sender, EventArgs e)
        {
            if(chx_visualizar.Checked == true)
            {
                Imprimeprev();

            }
            else
            {

                Imprime();
            }
            
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();


            if (cbx_nreq.Text != "")
            {
                if (chx_SelectFunc.Checked == false)
                {


                    //imprime toda a requisição
                    int restante = 0, total = 0;

                    dadosql = string.Format("SELECT COUNT(`func`)  FROM `req_func` where codreq = '{0}'", cbx_nreq.Text);
                    resultado = mConn.ConsultaTabela(dadosql);

                    total = Convert.ToInt32(resultado.Rows[0]["COUNT(`func`)"].ToString());
                    lbl_total.Text = resultado.Rows[0]["COUNT(`func`)"].ToString();



                    if (lbl_restante.Text == "rest_inicial")
                    {
                        cbx_SelectFunc.SelectedIndex = total - 1;
                        cbx_SelectFunc.SelectedIndex = 0;
                        lbl_restante.Text = restante.ToString();
                    }




                    if (Convert.ToInt32(lbl_restante.Text) <= Convert.ToInt32(lbl_total.Text) )
                    {
                        restante = Convert.ToInt32(lbl_restante.Text);
                        
                            


                        if(lbl_restante.Text != "1")
                        {
                            restante--;
                            cbx_SelectFunc.SelectedIndex = restante - 1;
                        }


                        lbl_restante.Text = restante.ToString();

                        if (Convert.ToInt32(lbl_restante.Text) >= Convert.ToInt32(lbl_total.Text))
                        {
                            txt_status.Text = lbl_total.Text + "/" + lbl_total.Text;

                        }
                        else
                        {
                            txt_status.Text = lbl_restante.Text + "/" + lbl_total.Text;
                        }

                    }
                    else
                    {
                        restante = Convert.ToInt32(lbl_restante.Text);
                        restante--;
                        lbl_restante.Text = restante.ToString();
                        txt_status.Text = lbl_total.Text + "/" + lbl_total.Text;
                    }

                }
              
            }
            else
            {
                MessageBox.Show("Selecione uma Requisiação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_proximo_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();


            if (cbx_nreq.Text != "")
            {
                if (chx_SelectFunc.Checked == false)
                {


                    //imprime toda a requisição
                    int restante = 0, total = 0;

                    dadosql = string.Format("SELECT COUNT(`func`)  FROM `req_func` where codreq = '{0}'", cbx_nreq.Text);
                    resultado = mConn.ConsultaTabela(dadosql);

                    total = Convert.ToInt32(resultado.Rows[0]["COUNT(`func`)"].ToString());
                    lbl_total.Text = resultado.Rows[0]["COUNT(`func`)"].ToString();

                    if (lbl_restante.Text == "rest_inicial")
                    {
                        cbx_SelectFunc.SelectedIndex = total - 1;
                        cbx_SelectFunc.SelectedIndex = 0;
                        lbl_restante.Text = restante.ToString();
                    }




                    if (Convert.ToInt32(lbl_restante.Text) <= Convert.ToInt32(lbl_total.Text))
                    {
                        restante = Convert.ToInt32(lbl_restante.Text);
                        restante++;
                        lbl_restante.Text = restante.ToString();


                        if (Convert.ToInt32(lbl_restante.Text) > Convert.ToInt32(lbl_total.Text))
                        {
                            cbx_SelectFunc.SelectedIndex = restante - 2;
                        }
                        else
                        {
                            cbx_SelectFunc.SelectedIndex = restante - 1;
                        }
                       // Imprime();


                        if (Convert.ToInt32(lbl_restante.Text) >= Convert.ToInt32(lbl_total.Text))
                        {
                            txt_status.Text = lbl_total.Text + "/" + lbl_total.Text;

                        }
                        else
                        {
                            txt_status.Text = lbl_restante.Text + "/" + lbl_total.Text;
                        }

                    }
                    else
                    {
                        txt_status.Text = lbl_total.Text + "/" + lbl_total.Text;
                    }



                }
            }
            else
            {
                MessageBox.Show("Selecione uma Requisiação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
