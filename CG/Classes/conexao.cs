using MySqlConnector;
using System;
using System.Data;

namespace CG.Classes
{
    class conexao
    {
        private MySqlConnection conexaoDB;
        public void Conectar()
        {
            conexaoDB = new MySqlConnection("persist security info = false;server=srv-bkp;database=db_cg;uid=glpi;pwd=GESTservi3627222;");
            if (conexaoDB.State == ConnectionState.Closed)
                conexaoDB.Open();
        }
        public void AlterarTabelas(string sql)
        {
            Conectar();
            MySqlCommand comandosAlt = new MySqlCommand(sql, conexaoDB);
            comandosAlt.ExecuteNonQuery();
            conexaoDB.Close();
        }
        public DataTable ConsultarTabelas(string sql)
        {
            Conectar();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexaoDB);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexaoDB.Close();
            return resultado;
        }
        public int login(string sql)
        {
            Conectar();
            int i;
            MySqlCommand command = conexaoDB.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            conexaoDB.Close();
            return i;
        }



    }
}
