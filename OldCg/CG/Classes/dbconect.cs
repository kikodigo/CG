using MySqlConnector;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CG.Classes
{
    class dbconect
    {
        private MySqlConnection conectar;

        public string String_Conexao()
        {

            String Caminho = "C:\\CG\\db.ini";
            if (!System.IO.File.Exists(Caminho)) System.IO.File.Create(Caminho).Close();
            StreamReader sr = new StreamReader(Caminho);

            // modelo de caminho de server = "persist security info = false;server=srv-bkp;database=db_cg;uid=glpi;pwd=GESTservi3627;convert zero datetime=True;"

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

        public int login(string sql)
        {
            Conectdb();
            int i;
            MySqlCommand command = conectar.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            conectar.Close();
            return i;
        }

        public void Inserirdb(string dadosql)
        {
            Conectdb();
            MySqlCommand codigodb = new MySqlCommand(dadosql, conectar);
            try
            {
                codigodb.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show(erro.ToString());
                MessageBox.Show(dadosql);
            }

            conectar.Close();

        }

        public DataTable ConsultaTabela(string dadosql)
        {
            Conectdb();
            MySqlDataAdapter consulta = new MySqlDataAdapter(dadosql, conectar);
            DataTable tabela = new DataTable();
            consulta.Fill(tabela);
            conectar.Close();
            return tabela;
        }

        public DataTable LeituraTabela(string dadosql)
        {
            Conectdb();
            MySqlCommand comando = new MySqlCommand(dadosql, conectar);
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conectar.Close();
            return dt;
        }
        public DataTable LeituraLinha(string dadosql)
        {
            Conectdb();
            MySqlCommand comando = new MySqlCommand(dadosql, conectar);
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conectar.Close();
            return dt;
        }


        public DataTable ficha(string dadosql)
        {
            Conectdb();

            MySqlDataAdapter consulta = new MySqlDataAdapter(dadosql, conectar);
            DataTable tabela = new DataTable();
            consulta.Fill(tabela);
            conectar.Close();

            return tabela;

        }

        public void log(string usuario, string tela, string metodo, string acao, string detalhe)
        {
            Conectdb();
            string dadosql = string.Format("INSERT INTO `log` (`cod`, `usuario`, `tela`, `metodo`, `acao`, `data`, `detalhe`) VALUES(NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", usuario, tela, metodo, acao, Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd"), detalhe);

            MySqlCommand codigodb = new MySqlCommand(dadosql, conectar);

            codigodb.ExecuteNonQuery();
            conectar.Close();

        }

    }
}
