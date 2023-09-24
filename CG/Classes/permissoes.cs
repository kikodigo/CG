using MySqlConnector;
using System;
using System.Data;
using System.IO;


namespace CG.Classes
{
    class permissoes
    {

        private MySqlConnection conectar;


        public string String_Conexao()
        {


            String Caminho = "C:\\CG\\db.ini";
            if (!System.IO.File.Exists(Caminho)) System.IO.File.Create(Caminho).Close();
            StreamReader sr = new StreamReader(Caminho);

            // modelo de caminho de server = "persist security info = false;server=srv-bkp;database=db_cg;uid=glpi;pwd=GESTservi3627;"

            string conect = sr.ReadLine();
            sr.Close();
            return conect;
        }

        public void Conectdb()
        {
            conectar = new MySqlConnection(String_Conexao());
            if (conectar.State == ConnectionState.Closed)
                conectar.Open();
            //return conectar;
        }

        public DataTable consulta(string usuario, string tela)
        {
            Conectdb();

            string dadosql = string.Format("SELECT `perfil` FROM `usuario` WHERE `usuario` = '{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(dadosql, conectar);
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            // conectar.Close();
            //MessageBox.Show("O codigo de perfil é : " + dt.Rows[0]["perfil"].ToString());
            string codperfil = dt.Rows[0]["perfil"].ToString();

            //Conectdb();

            dadosql = string.Format("SELECT `{0}` FROM `permissao` WHERE `perfil` ='{1}'", tela, codperfil);

            MySqlCommand comando2 = new MySqlCommand(dadosql, conectar);
            MySqlDataReader dr2 = comando2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            conectar.Close();
            string permissaotela = dt2.Rows[0][tela].ToString();

            //MessageBox.Show("O usuario é : "+usuario+" | O codigo de perfil é : "+codperfil+" | a permissão é :" +permissaotela);




            return dt2;

        }



    }
}
